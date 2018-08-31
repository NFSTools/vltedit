using System;

namespace vltedit
{
	/// <summary>
	/// Summary description for BinaryReader.
	/// </summary>
	///
	/*
	public class BinaryReader : System.IO.BinaryReader
	{
		private bool _bigEndian = true;

		public bool BigEndian
		{
			get { return _bigEndian; }
			set { _bigEndian = value; }
		}

		public BinaryReader ( System.IO.Stream input , System.Text.Encoding encoding ) :
			base(input, encoding)
		{}

		public BinaryReader ( System.IO.Stream input ) :
			base(input)
		{}
	
		public override int ReadInt32()
		{
			int value = base.ReadInt32 ();
			value = (int)(((((long)value) & 0xff000000) >> 24) |
                    ((((long)value) & 0x00ff0000) >> 8)  |
                    ((((long)value) & 0x0000ff00) << 8)  |
                    ((((long)value) & 0x000000ff) << 24));
			return value;
		}

		public override uint ReadUInt32()
		{
			uint value = base.ReadUInt32 ();
			value = (uint)((((value) & 0xff000000) >> 24) |
				(((value) & 0x00ff0000) >> 8)  |
				(((value) & 0x0000ff00) << 8)  |
				(((value) & 0x000000ff) << 24));
			return value;
		}

		public override short ReadInt16()
		{
			short value = base.ReadInt16 ();
			value = (short)((((int)(value) & 0xff00) >> 8) |
                   (((int)(value) & 0x00ff) << 8));
			return value;
		}

		public override ushort ReadUInt16()
		{
			ushort value = base.ReadUInt16 ();
			value = (ushort)((((value) & 0xff00) >> 8) |
				(((value) & 0x00ff) << 8));
			return value;
		}
	}
	*/
}
