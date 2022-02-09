using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Apache.Commons.Compress.Archivers.Cpio
{

	[Register("org/apache/commons/compress/archivers/cpio/CpioConstants", DoNotGenerateAcw = true)]
	public abstract class CpioConstants : global::Java.Lang.Object
	{

		internal CpioConstants()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='BLOCK_SIZE']"
		[Register("BLOCK_SIZE")]
		public const int BlockSize = (int)512;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='CPIO_TRAILER']"
		[Register("CPIO_TRAILER")]
		public const string CpioTrailer = (string)"TRAILER!!!";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IRGRP']"
		[Register("C_IRGRP")]
		public const int CIrgrp = (int)32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IROTH']"
		[Register("C_IROTH")]
		public const int CIroth = (int)4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IRUSR']"
		[Register("C_IRUSR")]
		public const int CIrusr = (int)256;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISBLK']"
		[Register("C_ISBLK")]
		public const int CIsblk = (int)24576;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISCHR']"
		[Register("C_ISCHR")]
		public const int CIschr = (int)8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISDIR']"
		[Register("C_ISDIR")]
		public const int CIsdir = (int)16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISFIFO']"
		[Register("C_ISFIFO")]
		public const int CIsfifo = (int)4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISGID']"
		[Register("C_ISGID")]
		public const int CIsgid = (int)1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISLNK']"
		[Register("C_ISLNK")]
		public const int CIslnk = (int)40960;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISNWK']"
		[Register("C_ISNWK")]
		public const int CIsnwk = (int)36864;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISREG']"
		[Register("C_ISREG")]
		public const int CIsreg = (int)32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISSOCK']"
		[Register("C_ISSOCK")]
		public const int CIssock = (int)49152;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISUID']"
		[Register("C_ISUID")]
		public const int CIsuid = (int)2048;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_ISVTX']"
		[Register("C_ISVTX")]
		public const int CIsvtx = (int)512;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IWGRP']"
		[Register("C_IWGRP")]
		public const int CIwgrp = (int)16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IWOTH']"
		[Register("C_IWOTH")]
		public const int CIwoth = (int)2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IWUSR']"
		[Register("C_IWUSR")]
		public const int CIwusr = (int)128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IXGRP']"
		[Register("C_IXGRP")]
		public const int CIxgrp = (int)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IXOTH']"
		[Register("C_IXOTH")]
		public const int CIxoth = (int)1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='C_IXUSR']"
		[Register("C_IXUSR")]
		public const int CIxusr = (int)64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='FORMAT_NEW']"
		[Register("FORMAT_NEW")]
		public const short FormatNew = (short)1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='FORMAT_NEW_CRC']"
		[Register("FORMAT_NEW_CRC")]
		public const short FormatNewCrc = (short)2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='FORMAT_NEW_MASK']"
		[Register("FORMAT_NEW_MASK")]
		public const short FormatNewMask = (short)3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='FORMAT_OLD_ASCII']"
		[Register("FORMAT_OLD_ASCII")]
		public const short FormatOldAscii = (short)4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='FORMAT_OLD_BINARY']"
		[Register("FORMAT_OLD_BINARY")]
		public const short FormatOldBinary = (short)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='FORMAT_OLD_MASK']"
		[Register("FORMAT_OLD_MASK")]
		public const short FormatOldMask = (short)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='MAGIC_NEW']"
		[Register("MAGIC_NEW")]
		public const string MagicNew = (string)"070701";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='MAGIC_NEW_CRC']"
		[Register("MAGIC_NEW_CRC")]
		public const string MagicNewCrc = (string)"070702";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='MAGIC_OLD_ASCII']"
		[Register("MAGIC_OLD_ASCII")]
		public const string MagicOldAscii = (string)"070707";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='MAGIC_OLD_BINARY']"
		[Register("MAGIC_OLD_BINARY")]
		public const int MagicOldBinary = (int)29127;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.cpio']/interface[@name='CpioConstants']/field[@name='S_IFMT']"
		[Register("S_IFMT")]
		public const int SIfmt = (int)61440;
	}

	[Register("org/apache/commons/compress/archivers/cpio/CpioConstants", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'CpioConstants' type. This type will be removed in a future release.", error: true)]
	public abstract class CpioConstantsConsts : CpioConstants
	{

		private CpioConstantsConsts()
		{
		}
	}

}
