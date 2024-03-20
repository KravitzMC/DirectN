﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HRESULT : IEquatable<HRESULT>, IFormattable
    {
        private static readonly ConcurrentDictionary<int, string> _names = new ConcurrentDictionary<int, string>();

        public HRESULT(int value)
        {
            Value = value;
        }

        public HRESULT(uint value)
            : this((int)value)
        {
        }

        public HRESULT(HRESULTS value)
            : this((int)value)
        {
        }

        public int Value { get; }
        public uint UValue => (uint)Value;
        public string Name => ToString("n", null);
        public bool IsError => Value < 0;
        public bool IsSuccess => Value >= 0;
        public bool IsOk => Value == (int)HRESULTS.S_OK;
        public bool IsFalse => Value == (int)HRESULTS.S_FALSE;

        public int ThrowOnError(bool throwOnError = true) => ThrowOnErrorExcept(null, throwOnError).Value;
        public HRESULT ThrowOnErrorExcept(HRESULT exceptedValue, bool throwOnError = true) => ThrowOnErrorExcept(new[] { exceptedValue }, throwOnError);
        public HRESULT ThrowOnErrorExcept(IEnumerable<HRESULT> exceptedValues, bool throwOnError = true)
        {
            if (!throwOnError)
                return Value;

            if (exceptedValues != null && exceptedValues.Contains(this))
                return Value;

            var exception = GetException();
            if (exception != null)
                throw exception;

            return Value;
        }

        public static HRESULT RunWithRetries(Func<HRESULT> func, HRESULT retryableValue, int maxRetries = int.MaxValue, int retryWaitMs = 0, bool throwOnError = true) => RunWithRetries(func, new[] { retryableValue }, maxRetries, retryWaitMs, throwOnError);
        public static HRESULT RunWithRetries(Func<HRESULT> func, IEnumerable<HRESULT> retryableValues = null, int maxRetries = int.MaxValue, int retryWaitMs = 0, bool throwOnError = true)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var count = 0;
            HRESULT hr;
            do
            {
                hr = func().ThrowOnErrorExcept(retryableValues, throwOnError);
                if (hr.IsSuccess)
                    return hr;

                if (retryWaitMs > 0)
                {
                    Thread.Sleep(retryWaitMs);
                }
                count++;
            }
            while (count < maxRetries);
            return hr;
        }

        public Exception GetException()
        {
            if (Value == (int)HRESULTS.DISP_E_EXCEPTION)
            {
                var error = ComError.GetError();
                if (error != null)
                    return error;
            }

            if (Value < 0)
                return new Win32Exception(Value);

            return null;
        }

        public override bool Equals(object obj) => Value.Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public bool Equals(HRESULT other) => Value.Equals(other.Value);

        public override string ToString() => ToString(null, null);
        public string ToString(string format, IFormatProvider formatProvider)
        {
#pragma warning disable CA1308 // Normalize strings to uppercase
            switch (format?.ToLowerInvariant())
#pragma warning restore CA1308 // Normalize strings to uppercase
            {
                case "i":
                    return Value.ToString();

                case "u":
                    return UValue.ToString();

                case "n":
                    if (!_names.TryGetValue(Value, out string text))
                    {
                        var value = Value;
                        text = typeof(HRESULTS).GetFields(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(f => ((int)(HRESULTS)f.GetValue(null)) == value)?.Name;
                        _names[Value] = text;
                    }
                    return text;

                case "x":
                    return "0x" + Value.ToString("X8");

                default: // f
                    string name = ToString("n", formatProvider);
                    if (name != null)
                        return name + " (0x" + Value.ToString("X8") + ")";

                    return "0x" + Value.ToString("X8");
            }
        }

        public static HRESULT FromWin32(int error)
        {
            if (error < 0)
                return error;

            const int FACILITY_WIN32 = 7;
            return (uint)(error & 0x0000FFFF) | (FACILITY_WIN32 << 16) | 0x80000000;
        }

        public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;
        public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

        public static implicit operator HRESULT(int value) => new HRESULT(value);
        public static implicit operator HRESULT(uint result) => new HRESULT(result);
        public static implicit operator HRESULT(HRESULTS result) => new HRESULT(result);

        public static explicit operator uint(HRESULT hr) => hr.UValue;
        public static explicit operator int(HRESULT hr) => hr.Value;
        public static explicit operator HRESULTS(HRESULT hr) => (HRESULTS)hr.UValue;
    }
}
