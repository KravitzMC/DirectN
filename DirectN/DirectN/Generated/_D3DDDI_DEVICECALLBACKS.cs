﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;
using PFND3DDDI_ALLOCATECB = System.IntPtr;
using PFND3DDDI_CREATECONTEXTCB = System.IntPtr;
using PFND3DDDI_CREATECONTEXTVIRTUALCB = System.IntPtr;
using PFND3DDDI_CREATEHWCONTEXTCB = System.IntPtr;
using PFND3DDDI_CREATEHWQUEUECB = System.IntPtr;
using PFND3DDDI_CREATEOVERLAYCB = System.IntPtr;
using PFND3DDDI_CREATEPAGINGQUEUECB = System.IntPtr;
using PFND3DDDI_CREATESYNCHRONIZATIONOBJECT2CB = System.IntPtr;
using PFND3DDDI_CREATESYNCHRONIZATIONOBJECTCB = System.IntPtr;
using PFND3DDDI_DEALLOCATE2CB = System.IntPtr;
using PFND3DDDI_DEALLOCATECB = System.IntPtr;
using PFND3DDDI_DESTROYCONTEXTCB = System.IntPtr;
using PFND3DDDI_DESTROYHWCONTEXTCB = System.IntPtr;
using PFND3DDDI_DESTROYHWQUEUECB = System.IntPtr;
using PFND3DDDI_DESTROYOVERLAYCB = System.IntPtr;
using PFND3DDDI_DESTROYPAGINGQUEUECB = System.IntPtr;
using PFND3DDDI_DESTROYSYNCHRONIZATIONOBJECTCB = System.IntPtr;
using PFND3DDDI_ESCAPECB = System.IntPtr;
using PFND3DDDI_EVICTCB = System.IntPtr;
using PFND3DDDI_FLIPOVERLAYCB = System.IntPtr;
using PFND3DDDI_FREEGPUVIRTUALADDRESSCB = System.IntPtr;
using PFND3DDDI_GETRESOURCEPRESENTPRIVATEDRIVERDATACB = System.IntPtr;
using PFND3DDDI_INVALIDATECACHECB = System.IntPtr;
using PFND3DDDI_LOCK2CB = System.IntPtr;
using PFND3DDDI_LOCKCB = System.IntPtr;
using PFND3DDDI_LOGUMDMARKERCB = System.IntPtr;
using PFND3DDDI_MAKERESIDENTCB = System.IntPtr;
using PFND3DDDI_MAPGPUVIRTUALADDRESSCB = System.IntPtr;
using PFND3DDDI_OFFERALLOCATIONS2CB = System.IntPtr;
using PFND3DDDI_OFFERALLOCATIONSCB = System.IntPtr;
using PFND3DDDI_PRESENTCB = System.IntPtr;
using PFND3DDDI_PRESENTMULTIPLANEOVERLAYCB = System.IntPtr;
using PFND3DDDI_QUERYRESIDENCYCB = System.IntPtr;
using PFND3DDDI_RECLAIMALLOCATIONS2CB = System.IntPtr;
using PFND3DDDI_RECLAIMALLOCATIONS3CB = System.IntPtr;
using PFND3DDDI_RECLAIMALLOCATIONSCB = System.IntPtr;
using PFND3DDDI_RENDERCB = System.IntPtr;
using PFND3DDDI_RESERVEGPUVIRTUALADDRESSCB = System.IntPtr;
using PFND3DDDI_SETASYNCCALLBACKSCB = System.IntPtr;
using PFND3DDDI_SETDISPLAYMODECB = System.IntPtr;
using PFND3DDDI_SETDISPLAYPRIVATEDRIVERFORMATCB = System.IntPtr;
using PFND3DDDI_SETPRIORITYCB = System.IntPtr;
using PFND3DDDI_SIGNALSYNCHRONIZATIONOBJECT2CB = System.IntPtr;
using PFND3DDDI_SIGNALSYNCHRONIZATIONOBJECTCB = System.IntPtr;
using PFND3DDDI_SIGNALSYNCHRONIZATIONOBJECTFROMCPUCB = System.IntPtr;
using PFND3DDDI_SIGNALSYNCHRONIZATIONOBJECTFROMGPU2CB = System.IntPtr;
using PFND3DDDI_SIGNALSYNCHRONIZATIONOBJECTFROMGPUCB = System.IntPtr;
using PFND3DDDI_SUBMITCOMMANDCB = System.IntPtr;
using PFND3DDDI_SUBMITCOMMANDTOHWQUEUECB = System.IntPtr;
using PFND3DDDI_SUBMITHISTORYSEQUENCECB = System.IntPtr;
using PFND3DDDI_SUBMITPRESENTBLTTOHWQUEUECB = System.IntPtr;
using PFND3DDDI_SUBMITPRESENTTOHWQUEUECB = System.IntPtr;
using PFND3DDDI_SUBMITSIGNALSYNCOBJECTSTOHWQUEUECB = System.IntPtr;
using PFND3DDDI_SUBMITWAITFORSYNCOBJECTSTOHWQUEUECB = System.IntPtr;
using PFND3DDDI_SYNCTOKENCB = System.IntPtr;
using PFND3DDDI_UNLOCK2CB = System.IntPtr;
using PFND3DDDI_UNLOCKCB = System.IntPtr;
using PFND3DDDI_UPDATEALLOCATIONPROPERTYCB = System.IntPtr;
using PFND3DDDI_UPDATEGPUVIRTUALADDRESSCB = System.IntPtr;
using PFND3DDDI_UPDATEOVERLAYCB = System.IntPtr;
using PFND3DDDI_WAITFORSYNCHRONIZATIONOBJECT2CB = System.IntPtr;
using PFND3DDDI_WAITFORSYNCHRONIZATIONOBJECTCB = System.IntPtr;
using PFND3DDDI_WAITFORSYNCHRONIZATIONOBJECTFROMCPUCB = System.IntPtr;
using PFND3DDDI_WAITFORSYNCHRONIZATIONOBJECTFROMGPUCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_DEVICECALLBACKS
    {
        public IntPtr pfnAllocateCb;
        public IntPtr pfnDeallocateCb;
        public IntPtr pfnSetPriorityCb;
        public IntPtr pfnQueryResidencyCb;
        public IntPtr pfnSetDisplayModeCb;
        public IntPtr pfnPresentCb;
        public IntPtr pfnRenderCb;
        public IntPtr pfnLockCb;
        public IntPtr pfnUnlockCb;
        public IntPtr pfnEscapeCb;
        public IntPtr pfnCreateOverlayCb;
        public IntPtr pfnUpdateOverlayCb;
        public IntPtr pfnFlipOverlayCb;
        public IntPtr pfnDestroyOverlayCb;
        public IntPtr pfnCreateContextCb;
        public IntPtr pfnDestroyContextCb;
        public IntPtr pfnCreateSynchronizationObjectCb;
        public IntPtr pfnDestroySynchronizationObjectCb;
        public IntPtr pfnWaitForSynchronizationObjectCb;
        public IntPtr pfnSignalSynchronizationObjectCb;
        public IntPtr pfnSetAsyncCallbacksCb;
        public IntPtr pfnSetDisplayPrivateDriverFormatCb;
        public IntPtr pfnOfferAllocationsCb;
        public IntPtr pfnReclaimAllocationsCb;
        public IntPtr pfnCreateSynchronizationObject2Cb;
        public IntPtr pfnWaitForSynchronizationObject2Cb;
        public IntPtr pfnSignalSynchronizationObject2Cb;
        public IntPtr pfnPresentMultiPlaneOverlayCb;
        public IntPtr pfnLogUMDMarkerCb;
        public IntPtr pfnMakeResidentCb;
        public IntPtr pfnEvictCb;
        public IntPtr pfnWaitForSynchronizationObjectFromCpuCb;
        public IntPtr pfnSignalSynchronizationObjectFromCpuCb;
        public IntPtr pfnWaitForSynchronizationObjectFromGpuCb;
        public IntPtr pfnSignalSynchronizationObjectFromGpuCb;
        public IntPtr pfnCreatePagingQueueCb;
        public IntPtr pfnDestroyPagingQueueCb;
        public IntPtr pfnLock2Cb;
        public IntPtr pfnUnlock2Cb;
        public IntPtr pfnInvalidateCacheCb;
        public IntPtr pfnReserveGpuVirtualAddressCb;
        public IntPtr pfnMapGpuVirtualAddressCb;
        public IntPtr pfnFreeGpuVirtualAddressCb;
        public IntPtr pfnUpdateGpuVirtualAddressCb;
        public IntPtr pfnCreateContextVirtualCb;
        public IntPtr pfnSubmitCommandCb;
        public IntPtr pfnDeallocate2Cb;
        public IntPtr pfnSignalSynchronizationObjectFromGpu2Cb;
        public IntPtr pfnReclaimAllocations2Cb;
        public IntPtr pfnGetResourcePresentPrivateDriverDataCb;
        public IntPtr pfnUpdateAllocationPropertyCb;
        public IntPtr pfnOfferAllocations2Cb;
        public IntPtr pfnReclaimAllocations3Cb;
        public IntPtr pfnAcquireResourceCb;
        public IntPtr pfnReleaseResourceCb;
        public IntPtr pfnCreateHwContextCb;
        public IntPtr pfnDestroyHwContextCb;
        public IntPtr pfnCreateHwQueueCb;
        public IntPtr pfnDestroyHwQueueCb;
        public IntPtr pfnSubmitCommandToHwQueueCb;
        public IntPtr pfnSubmitWaitForSyncObjectsToHwQueueCb;
        public IntPtr pfnSubmitSignalSyncObjectsToHwQueueCb;
        public IntPtr pfnSubmitPresentBltToHwQueueCb;
        public IntPtr pfnSubmitPresentToHwQueueCb;
        public IntPtr pfnSubmitHistorySequenceCb;
    }
}
