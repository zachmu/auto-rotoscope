using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace JockerSoft.Media
{
					  
	[ComImport, Guid("65BD0711-24D2-4ff7-9324-ED2E5D3ABAFA")]
	public class MediaDet
	{
	}
	
	
	[ComVisible(true), ComImport, Guid("65BD0710-24D2-4ff7-9324-ED2E5D3ABAFA"), InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IMediaDet
	{
		void get_Filter();
        
		void put_Filter(); 
        
		void get_OutputStreams( [Out] out int pVal);
        
		void get_CurrentStream( [Out] out int pVal);
        
		void put_CurrentStream( [In] int newVal);
        
		void get_StreamType( [Out] out Guid pVal);
        
		void get_StreamTypeB( [Out, MarshalAs(UnmanagedType.BStr)] out string pVal);
        
		void get_StreamLength( [Out] double pVal);

		[return: MarshalAs(UnmanagedType.BStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void get_Filename( [Out, MarshalAs(UnmanagedType.BStr)] out string pVal);
        
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void put_Filename( [In, MarshalAs(UnmanagedType.BStr)] string newVal);



        
		void GetBitmapBits( 
			double StreamTime,	//mah (e tutti gli altri double)
			int pBufferSize,
			byte pBuffer,	//mah
			int Width,
			int Height);
        
		void  WriteBitmapBits( double StreamTime,
			long Width,
			long Height,
			[In, MarshalAs(UnmanagedType.BStr)] string Filename);
        
		void get_StreamMediaType( [Out] out AM_MEDIA_TYPE pVal);
        
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSampleGrabber([MarshalAs(UnmanagedType.Interface)] out ISampleGrabber ppVal);
 
//		void  GetSampleGrabber( [Out] out ISampleGrabber ppVal);
        
		void get_FrameRate( [Out] out double pVal);
        
		void EnterBitmapGrabMode( double SeekTime);
	}

	[ComVisible(true), ComImport, Guid("6B652FFF-11FE-4fce-92AD-0266B5D7C78F"), InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
	public interface ISampleGrabber
	{
		//	[PreserveSig]
		void SetOneShot( [In] bool OneShot);
        
		void SetMediaType( [In, MarshalAs(UnmanagedType.LPStruct)] AM_MEDIA_TYPE pType);
        
		void GetConnectedMediaType( [Out, MarshalAs(UnmanagedType.LPStruct)] out AM_MEDIA_TYPE pType);
        
		void SetBufferSamples( [In] bool BufferThem);
        
		void GetCurrentBuffer( ref int pBufferSize,
			[Out] IntPtr pBuffer);
        
		void GetCurrentSample( [Out] out IntPtr ppSample);
        
		void SetCallback( ISampleGrabberCB pCallback, int WhichMethodToCallback) ;
	}

	[ComImport, Guid("0579154A-2B53-4994-B0D0-E773148EFF85")]
	public interface ISampleGrabberCB
	{
		void SampleCB( 
			double SampleTime,
			IMediaSample pSample);
        
		void BufferCB( 
			double SampleTime,
			IntPtr pBuffer,
			int BufferLen);
	}

	[ComImport, Guid("56a8689a-0ad4-11ce-b03a-0020af0ba770"), InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
	public interface IMediaSample
	{
		void GetPointer( [Out] out IntPtr ppBuffer);
        
		int GetSize( );
        
		void GetTime( 
			[Out] out long pTimeStart,	//Mah no long ma REFERENCE_TIME
			[Out] out long pTimeEnd);
        
		void SetTime( 
			[In, MarshalAs(UnmanagedType.LPStruct)] REFERENCE_TIME pTimeStart,
			[In, MarshalAs(UnmanagedType.LPStruct)] REFERENCE_TIME pTimeEnd);
        
		void IsSyncPoint();
        
		void SetSyncPoint( [In, MarshalAs(UnmanagedType.Bool)] bool bIsSyncPoint);
        
		void IsPreroll();
        
		void SetPreroll( [In, MarshalAs(UnmanagedType.Bool)] bool bIsPreroll);
        
		int GetActualDataLength();
        
		void SetActualDataLength( int length);
        

		void GetMediaType( [Out, MarshalAs(UnmanagedType.LPStruct)]	out AM_MEDIA_TYPE	ppMediaType);
        
		void SetMediaType( [In, MarshalAs(UnmanagedType.LPStruct)] AM_MEDIA_TYPE pMediaType);
        
		void IsDiscontinuity();
        
		void SetDiscontinuity( [In, MarshalAs(UnmanagedType.Bool)] bool bDiscontinuity);
        
		void GetMediaTime( 
			[Out] out long pTimeStart,	//mah, no long ma REFERENCE_TIME
			[Out] out long pTimeEnd);
        
		void SetMediaTime( 
			[In, MarshalAs(UnmanagedType.LPStruct)] REFERENCE_TIME pTimeStart,
			[In, MarshalAs(UnmanagedType.LPStruct)] REFERENCE_TIME pTimeEnd);
        
	};
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public class REFERENCE_TIME
	{
		public REFERENCE_TIME( long Value )
		{
			this.Value = Value;
		}
		public long		Value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct AM_MEDIA_TYPE
	{
		public Guid majortype;
		public Guid subtype;
		[MarshalAs(UnmanagedType.Bool)]
		public bool bFixedSizeSamples;
		[MarshalAs(UnmanagedType.Bool)]
		public bool bTemporalCompression;
		public int lSampleSize;
		public Guid formattype;
		public IntPtr pUnk;
		public int cbFormat;
		public IntPtr pbFormat;
	}
	
}
