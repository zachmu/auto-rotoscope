using System;
using System.Drawing;
using System.Runtime.InteropServices;



namespace JockerSoft.Media
{
	public class Video
	{
		[StructLayout(LayoutKind.Sequential)]
			public class VideoInfoHeader
		{
			public DsRect SrcRect;
			public DsRect TargetRect;
			public int BitRate;
			public int BitErrorRate;
			public long AvgTimePerFrame;
			public BitmapInfoHeader BmiHeader;
		}

		///
		/// From BITMAPINFOHEADER
		///
		[StructLayout(LayoutKind.Sequential, Pack=2)]
			public class BitmapInfoHeader
		{
			public int Size;
			public int Width;
			public int Height;
			public short Planes;
			public short BitCount;
			public int Compression;
			public int ImageSize;
			public int XPelsPerMeter;
			public int YPelsPerMeter;
			public int ClrUsed;
			public int ClrImportant;
		}

		[StructLayout(LayoutKind.Sequential)]
			public class DsRect
		{
			public int left;
			public int top;
			public int right;
			public int bottom;

			///
			/// Empty contructor. Initialize all fields to 0
			///
			public DsRect()
			{
				this.left = 0;
				this.top = 0;
				this.right = 0;
				this.bottom = 0;
			}

			///
			/// A parametred constructor. Initialize fields with given values.
			///
			/// the left value
			/// the top value
			/// the right value
			/// the bottom value
			public DsRect(int left, int top, int right, int bottom)
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			///
			/// A parametred constructor. Initialize fields with a given .
			///
			/// A
			///
			/// Warning, DsRect define a rectangle by defining two of his corners and define a rectangle with his upper/left corner, his width and his height.
			///
			public DsRect(Rectangle rectangle)
			{
				this.left = rectangle.Left;
				this.top = rectangle.Top;
				this.right = rectangle.Right;
				this.bottom = rectangle.Bottom;
			}

			///
			/// Provide de string representation of this DsRect instance
			///
			/// A string formated like this : [left, top - right, bottom]
			public override string ToString()
			{
				return string.Format("[{0}, {1} - {2}, {3}]", this.left, this.top, this.right, this.bottom);
			}

			public override int GetHashCode()
			{
				return this.left.GetHashCode() |
					this.top.GetHashCode() |
					this.right.GetHashCode() |
					this.bottom.GetHashCode();
			}

			///
			/// Define implicit cast between DirectShowLib.DsRect and System.Drawing.Rectangle for languages supporting this feature.
			/// VB.Net doesn't support implicit cast. for similar functionality.
			///
			/// // Define a new Rectangle instance
			/// Rectangle r = new Rectangle(0, 0, 100, 100);
			/// // Do implicit cast between Rectangle and DsRect
			/// DsRect dsR = r;
			///
			/// Console.WriteLine(dsR.ToString());
			///
			///
			/// a DsRect to be cast
			/// A casted System.Drawing.Rectangle
			public static implicit operator Rectangle(DsRect r)
			{
				return r.ToRectangle();
			}

			///
			/// Define implicit cast between System.Drawing.Rectangle and DirectShowLib.DsRect for languages supporting this feature.
			/// VB.Net doesn't support implicit cast. for similar functionality.
			///
			/// // Define a new DsRect instance
			/// DsRect dsR = new DsRect(0, 0, 100, 100);
			/// // Do implicit cast between DsRect and Rectangle
			/// Rectangle r = dsR;
			///
			/// Console.WriteLine(r.ToString());
			///
			///
			/// A System.Drawing.Rectangle to be cast
			/// A casted DsRect
			public static implicit operator DsRect(Rectangle r)
			{
				return new DsRect(r);
			}

			///
			/// Get the System.Drawing.Rectangle equivalent to this DirectShowLib.DsRect instance.
			///
			/// A System.Drawing.Rectangle
			public Rectangle ToRectangle()
			{
				return new Rectangle(this.left, this.top, (this.right - this.left), (this.bottom - this.top));
			}

			///
			/// Get a new DirectShowLib.DsRect instance for a given
			///
			/// The used to initialize this new DirectShowLib.DsGuid
			/// A new instance of DirectShowLib.DsGuid
			public static DsRect FromRectangle(Rectangle r)
			{
				return new DsRect(r);
			}
		}

		public static Bitmap GetBitmap(string FileName, double time)
		{
			try
			{
				Interop.qedit.MediaDetClass md = new Interop.qedit.MediaDetClass();
				md.Filename = FileName;
				md.CurrentStream = 0;
				Interop.qedit._AMMediaType mt = md.StreamMediaType;
				VideoInfoHeader vih = (VideoInfoHeader)Marshal.PtrToStructure( mt.pbFormat, typeof(VideoInfoHeader) );
				int width = vih.BmiHeader.Width;
				int height = vih.BmiHeader.Height;

				IntPtr bufPtr = IntPtr.Zero;
				int bufSize = 0;
				// call once to get the buffer size needed
				md.GetBitmapBits( 0.0, ref bufSize, bufPtr, width, height );

				//allocate memory
				bufPtr = Marshal.AllocHGlobal( bufSize );
				// call to retrieve the dib
				if(time <= md.StreamLength)
					md.GetBitmapBits( time, ref bufSize, bufPtr, width, height);
				else
					md.GetBitmapBits( 0.0, ref bufSize, bufPtr, width, height);

				// create a bitmap object; 40 is the size of the header on a 32-bit machine
				Bitmap result = new Bitmap( width, height, width*3,
					System.Drawing.Imaging.PixelFormat.Format24bppRgb, new IntPtr( (int)bufPtr + 40 ));
				result.RotateFlip( RotateFlipType.Rotate180FlipX );
				//System.Runtime.InteropServices.Marshal.FreeHGlobal(bufPtr);
				return result;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			return null;
		}
	} 
}
