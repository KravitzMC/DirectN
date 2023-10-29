﻿namespace DirectN.MinimalD3D11
{
    // this code is ported from https://gist.github.com/d7samurai/261c69490cce0620d0bfc93003cd1052
    public static class Data
    {
        public static float[] VertexData = // float3 position, float3 normal, float2 texcoord, float4 color
        {
            -1.0f,  1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f,  1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.2f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f,  1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.8f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             1.0f,  1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.2f,  0.2f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.8f,  0.2f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.2f,  0.8f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.8f,  0.8f,  0.973f,  0.480f,  0.002f,  1.000f,
            -1.0f, -1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  1.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f, -1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.2f,  1.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f, -1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.8f,  1.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             1.0f, -1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  1.0f,  1.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             1.0f,  1.0f, -1.0f,  1.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  1.0f, -0.6f,  1.0f,  0.0f,  0.0f,  0.2f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  1.0f,  0.6f,  1.0f,  0.0f,  0.0f,  0.8f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  1.0f,  1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  0.6f, -0.6f,  1.0f,  0.0f,  0.0f,  0.2f,  0.2f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  0.6f,  0.6f,  1.0f,  0.0f,  0.0f,  0.8f,  0.2f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -0.6f, -0.6f,  1.0f,  0.0f,  0.0f,  0.2f,  0.8f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -0.6f,  0.6f,  1.0f,  0.0f,  0.0f,  0.8f,  0.8f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -1.0f, -1.0f,  1.0f,  0.0f,  0.0f,  0.0f,  1.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -1.0f, -0.6f,  1.0f,  0.0f,  0.0f,  0.2f,  1.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -1.0f,  0.6f,  1.0f,  0.0f,  0.0f,  0.8f,  1.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -1.0f,  1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  1.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f,  1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.2f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f,  1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.8f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -1.0f,  1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f,  0.6f,  1.0f,  0.0f,  0.0f,  1.0f,  0.2f,  0.2f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f,  0.6f,  1.0f,  0.0f,  0.0f,  1.0f,  0.8f,  0.2f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f, -0.6f,  1.0f,  0.0f,  0.0f,  1.0f,  0.2f,  0.8f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f, -0.6f,  1.0f,  0.0f,  0.0f,  1.0f,  0.8f,  0.8f,  0.612f,  0.000f,  0.069f,  1.000f,
             1.0f, -1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.0f,  1.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f, -1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.2f,  1.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f, -1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.8f,  1.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -1.0f, -1.0f,  1.0f,  0.0f,  0.0f,  1.0f,  1.0f,  1.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -1.0f,  1.0f,  1.0f, -1.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  1.0f,  0.6f, -1.0f,  0.0f,  0.0f,  0.2f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  1.0f, -0.6f, -1.0f,  0.0f,  0.0f,  0.8f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  1.0f, -1.0f, -1.0f,  0.0f,  0.0f,  1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  0.6f,  0.6f, -1.0f,  0.0f,  0.0f,  0.2f,  0.2f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  0.6f, -0.6f, -1.0f,  0.0f,  0.0f,  0.8f,  0.2f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -0.6f,  0.6f, -1.0f,  0.0f,  0.0f,  0.2f,  0.8f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -0.6f, -0.6f, -1.0f,  0.0f,  0.0f,  0.8f,  0.8f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -1.0f,  1.0f, -1.0f,  0.0f,  0.0f,  0.0f,  1.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -1.0f,  0.6f, -1.0f,  0.0f,  0.0f,  0.2f,  1.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -1.0f, -0.6f, -1.0f,  0.0f,  0.0f,  0.8f,  1.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -1.0f, -1.0f, -1.0f,  0.0f,  0.0f,  1.0f,  1.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  1.0f,  1.0f,  0.0f,  1.0f,  0.0f,  0.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f,  1.0f,  0.0f,  1.0f,  0.0f,  0.2f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f,  1.0f,  0.0f,  1.0f,  0.0f,  0.8f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             1.0f,  1.0f,  1.0f,  0.0f,  1.0f,  0.0f,  1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f,  0.6f,  0.0f,  1.0f,  0.0f,  0.2f,  0.2f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f,  0.6f,  0.0f,  1.0f,  0.0f,  0.8f,  0.2f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f, -0.6f,  0.0f,  1.0f,  0.0f,  0.2f,  0.8f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f, -0.6f,  0.0f,  1.0f,  0.0f,  0.8f,  0.8f,  0.000f,  0.254f,  0.637f,  1.000f,
            -1.0f,  1.0f, -1.0f,  0.0f,  1.0f,  0.0f,  0.0f,  1.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f, -1.0f,  0.0f,  1.0f,  0.0f,  0.2f,  1.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f, -1.0f,  0.0f,  1.0f,  0.0f,  0.8f,  1.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             1.0f,  1.0f, -1.0f,  0.0f,  1.0f,  0.0f,  1.0f,  1.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -1.0f, -1.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.2f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.8f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             1.0f, -1.0f, -1.0f,  0.0f, -1.0f,  0.0f,  1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f, -0.6f,  0.0f, -1.0f,  0.0f,  0.2f,  0.2f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f, -0.6f,  0.0f, -1.0f,  0.0f,  0.8f,  0.2f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f,  0.6f,  0.0f, -1.0f,  0.0f,  0.2f,  0.8f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f,  0.6f,  0.0f, -1.0f,  0.0f,  0.8f,  0.8f,  0.001f,  0.447f,  0.067f,  1.000f,
            -1.0f, -1.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.0f,  1.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.2f,  1.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.8f,  1.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             1.0f, -1.0f,  1.0f,  0.0f, -1.0f,  0.0f,  1.0f,  1.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f,  0.6f, -1.0f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f,  0.6f, -0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f, -0.6f, -0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f, -0.6f, -1.0f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f,  0.6f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f,  0.6f, -1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f, -0.6f, -1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f, -0.6f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f, -0.6f, -1.0f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f, -0.6f, -0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f, -0.6f, -0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f, -0.6f, -1.0f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f,  0.6f, -0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
            -0.6f,  0.6f, -1.0f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f,  0.6f, -1.0f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             0.6f,  0.6f, -0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.973f,  0.480f,  0.002f,  1.000f,
             1.0f,  0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f,  0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f, -0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f,  0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f, -0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  0.6f,  0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f,  0.6f,  0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f,  0.6f, -0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f,  0.6f, -0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f, -0.6f,  0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -0.6f,  0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             1.0f, -0.6f, -0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f, -0.6f, -0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.897f,  0.163f,  0.011f,  1.000f,
             0.6f,  0.6f,  1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f,  0.6f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f, -0.6f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f, -0.6f,  1.0f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f,  0.6f,  0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f,  0.6f,  1.0f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f, -0.6f,  1.0f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f, -0.6f,  0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f, -0.6f,  1.0f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f, -0.6f,  0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f, -0.6f,  0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f, -0.6f,  1.0f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f,  0.6f,  0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
             0.6f,  0.6f,  1.0f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f,  0.6f,  1.0f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -0.6f,  0.6f,  0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.612f,  0.000f,  0.069f,  1.000f,
            -1.0f,  0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f,  0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f, -0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f,  0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f, -0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -0.6f,  0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f, -0.6f,  0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f, -0.6f, -0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f, -0.6f, -0.6f,  0.0f,  1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f,  0.6f,  0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  0.6f,  0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -1.0f,  0.6f, -0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f,  0.6f, -0.6f,  0.0f, -1.0f,  0.0f, -1.0f,  0.0f,  0.127f,  0.116f,  0.408f,  1.000f,
            -0.6f,  1.0f,  0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  0.6f,  0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  0.6f, -0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f, -0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  0.6f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  0.6f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f,  1.0f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  1.0f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
             0.6f,  0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.000f,  0.254f,  0.637f,  1.000f,
            -0.6f, -0.6f,  0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f,  0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f, -0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -0.6f, -0.6f,  1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -0.6f,  0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -0.6f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f, -0.6f, -1.0f,  0.0f,  0.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -0.6f, -0.6f,  0.0f,  0.0f,  1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -1.0f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
            -0.6f, -0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -0.6f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
             0.6f, -1.0f,  0.6f,  0.0f,  0.0f, -1.0f, -1.0f,  0.0f,  0.001f,  0.447f,  0.067f,  1.000f,
        };

        public static uint[] IndexData =
        {
              0,   1,   9,   9,   8,   0,   1,   2,   5,   5,   4,   1,   6,   7,  10,  10,   9,   6,   2,   3,  11,  11,  10,   2,
             12,  13,  21,  21,  20,  12,  13,  14,  17,  17,  16,  13,  18,  19,  22,  22,  21,  18,  14,  15,  23,  23,  22,  14,
             24,  25,  33,  33,  32,  24,  25,  26,  29,  29,  28,  25,  30,  31,  34,  34,  33,  30,  26,  27,  35,  35,  34,  26,
             36,  37,  45,  45,  44,  36,  37,  38,  41,  41,  40,  37,  42,  43,  46,  46,  45,  42,  38,  39,  47,  47,  46,  38,
             48,  49,  57,  57,  56,  48,  49,  50,  53,  53,  52,  49,  54,  55,  58,  58,  57,  54,  50,  51,  59,  59,  58,  50,
             60,  61,  69,  69,  68,  60,  61,  62,  65,  65,  64,  61,  66,  67,  70,  70,  69,  66,  62,  63,  71,  71,  70,  62,
             72,  73,  74,  74,  75,  72,  76,  77,  78,  78,  79,  76,  80,  81,  82,  82,  83,  80,  84,  85,  86,  86,  87,  84,
             88,  89,  90,  90,  91,  88,  92,  93,  94,  94,  95,  92,  96,  97,  98,  98,  99,  96, 100, 101, 102, 102, 103, 100,
            104, 105, 106, 106, 107, 104, 108, 109, 110, 110, 111, 108, 112, 113, 114, 114, 115, 112, 116, 117, 118, 118, 119, 116,
            120, 121, 122, 122, 123, 120, 124, 125, 126, 126, 127, 124, 128, 129, 130, 130, 131, 128, 132, 133, 134, 134, 135, 132,
            136, 137, 138, 138, 139, 136, 140, 141, 142, 142, 143, 140, 144, 145, 146, 146, 147, 144, 148, 149, 150, 150, 151, 148,
            152, 153, 154, 154, 155, 152, 156, 157, 158, 158, 159, 156, 160, 161, 162, 162, 163, 160, 164, 165, 166, 166, 167, 164,
        };

        public static uint[] TextureData =
        {
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
            0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f,
            0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff, 0xff7f7f7f, 0xffffffff,
        };
    }
}
