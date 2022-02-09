using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Apache.Commons.Compress.Archivers.Tar
{

	[Register("org/apache/commons/compress/archivers/tar/TarConstants", DoNotGenerateAcw = true)]
	public abstract class TarConstants : global::Java.Lang.Object
	{

		internal TarConstants()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='ATIMELEN_GNU']"
		[Register("ATIMELEN_GNU")]
		public const int AtimelenGnu = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='ATIMELEN_XSTAR']"
		[Register("ATIMELEN_XSTAR")]
		public const int AtimelenXstar = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='CHKSUMLEN']"
		[Register("CHKSUMLEN")]
		public const int Chksumlen = (int)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='CHKSUM_OFFSET']"
		[Register("CHKSUM_OFFSET")]
		public const int ChksumOffset = (int)148;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='CTIMELEN_GNU']"
		[Register("CTIMELEN_GNU")]
		public const int CtimelenGnu = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='CTIMELEN_XSTAR']"
		[Register("CTIMELEN_XSTAR")]
		public const int CtimelenXstar = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='DEFAULT_BLKSIZE']"
		[Register("DEFAULT_BLKSIZE")]
		public const int DefaultBlksize = (int)10240;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='DEFAULT_RCDSIZE']"
		[Register("DEFAULT_RCDSIZE")]
		public const int DefaultRcdsize = (int)512;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='DEVLEN']"
		[Register("DEVLEN")]
		public const int Devlen = (int)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='FORMAT_OLDGNU']"
		[Register("FORMAT_OLDGNU")]
		public const int FormatOldgnu = (int)2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='FORMAT_POSIX']"
		[Register("FORMAT_POSIX")]
		public const int FormatPosix = (int)3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='FORMAT_XSTAR']"
		[Register("FORMAT_XSTAR")]
		public const int FormatXstar = (int)4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='GIDLEN']"
		[Register("GIDLEN")]
		public const int Gidlen = (int)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='GNAMELEN']"
		[Register("GNAMELEN")]
		public const int Gnamelen = (int)32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='GNU_LONGLINK']"
		[Register("GNU_LONGLINK")]
		public const string GnuLonglink = (string)"././@LongLink";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='ISEXTENDEDLEN_GNU']"
		[Register("ISEXTENDEDLEN_GNU")]
		public const int IsextendedlenGnu = (int)1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='ISEXTENDEDLEN_GNU_SPARSE']"
		[Register("ISEXTENDEDLEN_GNU_SPARSE")]
		public const int IsextendedlenGnuSparse = (int)1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_BLK']"
		[Register("LF_BLK")]
		public const sbyte LfBlk = (sbyte)52;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_CHR']"
		[Register("LF_CHR")]
		public const sbyte LfChr = (sbyte)51;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_CONTIG']"
		[Register("LF_CONTIG")]
		public const sbyte LfContig = (sbyte)55;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_DIR']"
		[Register("LF_DIR")]
		public const sbyte LfDir = (sbyte)53;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_FIFO']"
		[Register("LF_FIFO")]
		public const sbyte LfFifo = (sbyte)54;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_GNUTYPE_LONGLINK']"
		[Register("LF_GNUTYPE_LONGLINK")]
		public const sbyte LfGnutypeLonglink = (sbyte)75;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_GNUTYPE_LONGNAME']"
		[Register("LF_GNUTYPE_LONGNAME")]
		public const sbyte LfGnutypeLongname = (sbyte)76;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_GNUTYPE_SPARSE']"
		[Register("LF_GNUTYPE_SPARSE")]
		public const sbyte LfGnutypeSparse = (sbyte)83;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_LINK']"
		[Register("LF_LINK")]
		public const sbyte LfLink = (sbyte)49;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_NORMAL']"
		[Register("LF_NORMAL")]
		public const sbyte LfNormal = (sbyte)48;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_OLDNORM']"
		[Register("LF_OLDNORM")]
		public const sbyte LfOldnorm = (sbyte)0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_PAX_EXTENDED_HEADER_LC']"
		[Register("LF_PAX_EXTENDED_HEADER_LC")]
		public const sbyte LfPaxExtendedHeaderLc = (sbyte)120;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_PAX_EXTENDED_HEADER_UC']"
		[Register("LF_PAX_EXTENDED_HEADER_UC")]
		public const sbyte LfPaxExtendedHeaderUc = (sbyte)88;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_PAX_GLOBAL_EXTENDED_HEADER']"
		[Register("LF_PAX_GLOBAL_EXTENDED_HEADER")]
		public const sbyte LfPaxGlobalExtendedHeader = (sbyte)103;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LF_SYMLINK']"
		[Register("LF_SYMLINK")]
		public const sbyte LfSymlink = (sbyte)50;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='LONGNAMESLEN_GNU']"
		[Register("LONGNAMESLEN_GNU")]
		public const int LongnameslenGnu = (int)4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAGICLEN']"
		[Register("MAGICLEN")]
		public const int Magiclen = (int)6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAGIC_ANT']"
		[Register("MAGIC_ANT")]
		public const string MagicAnt = (string)"ustar\u0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAGIC_GNU']"
		[Register("MAGIC_GNU")]
		public const string MagicGnu = (string)"ustar ";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAGIC_OFFSET']"
		[Register("MAGIC_OFFSET")]
		public const int MagicOffset = (int)257;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAGIC_POSIX']"
		[Register("MAGIC_POSIX")]
		public const string MagicPosix = (string)"ustar\u0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAGIC_XSTAR']"
		[Register("MAGIC_XSTAR")]
		public const string MagicXstar = (string)"tar\u0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAXID']"
		[Register("MAXID")]
		public const long Maxid = (long)2097151;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MAXSIZE']"
		[Register("MAXSIZE")]
		public const long Maxsize = (long)8589934591;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MODELEN']"
		[Register("MODELEN")]
		public const int Modelen = (int)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='MODTIMELEN']"
		[Register("MODTIMELEN")]
		public const int Modtimelen = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='NAMELEN']"
		[Register("NAMELEN")]
		public const int Namelen = (int)100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='OFFSETLEN_GNU']"
		[Register("OFFSETLEN_GNU")]
		public const int OffsetlenGnu = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='PAD2LEN_GNU']"
		[Register("PAD2LEN_GNU")]
		public const int Pad2lenGnu = (int)1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='PREFIXLEN']"
		[Register("PREFIXLEN")]
		public const int Prefixlen = (int)155;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='PREFIXLEN_XSTAR']"
		[Register("PREFIXLEN_XSTAR")]
		public const int PrefixlenXstar = (int)131;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='REALSIZELEN_GNU']"
		[Register("REALSIZELEN_GNU")]
		public const int RealsizelenGnu = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SIZELEN']"
		[Register("SIZELEN")]
		public const int Sizelen = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SPARSELEN_GNU']"
		[Register("SPARSELEN_GNU")]
		public const int SparselenGnu = (int)96;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SPARSELEN_GNU_SPARSE']"
		[Register("SPARSELEN_GNU_SPARSE")]
		public const int SparselenGnuSparse = (int)504;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SPARSE_HEADERS_IN_EXTENSION_HEADER']"
		[Register("SPARSE_HEADERS_IN_EXTENSION_HEADER")]
		public const int SparseHeadersInExtensionHeader = (int)21;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SPARSE_HEADERS_IN_OLDGNU_HEADER']"
		[Register("SPARSE_HEADERS_IN_OLDGNU_HEADER")]
		public const int SparseHeadersInOldgnuHeader = (int)4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SPARSE_NUMBYTES_LEN']"
		[Register("SPARSE_NUMBYTES_LEN")]
		public const int SparseNumbytesLen = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='SPARSE_OFFSET_LEN']"
		[Register("SPARSE_OFFSET_LEN")]
		public const int SparseOffsetLen = (int)12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='UIDLEN']"
		[Register("UIDLEN")]
		public const int Uidlen = (int)8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='UNAMELEN']"
		[Register("UNAMELEN")]
		public const int Unamelen = (int)32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='VERSIONLEN']"
		[Register("VERSIONLEN")]
		public const int Versionlen = (int)2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='VERSION_ANT']"
		[Register("VERSION_ANT")]
		public const string VersionAnt = (string)"\u0000\u0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='VERSION_GNU_SPACE']"
		[Register("VERSION_GNU_SPACE")]
		public const string VersionGnuSpace = (string)" \u0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='VERSION_GNU_ZERO']"
		[Register("VERSION_GNU_ZERO")]
		public const string VersionGnuZero = (string)"0\u0000";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='VERSION_OFFSET']"
		[Register("VERSION_OFFSET")]
		public const int VersionOffset = (int)263;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='VERSION_POSIX']"
		[Register("VERSION_POSIX")]
		public const string VersionPosix = (string)"00";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='XSTAR_MAGIC_LEN']"
		[Register("XSTAR_MAGIC_LEN")]
		public const int XstarMagicLen = (int)4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.tar']/interface[@name='TarConstants']/field[@name='XSTAR_MAGIC_OFFSET']"
		[Register("XSTAR_MAGIC_OFFSET")]
		public const int XstarMagicOffset = (int)508;
	}

	[Register("org/apache/commons/compress/archivers/tar/TarConstants", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'TarConstants' type. This type will be removed in a future release.", error: true)]
	public abstract class TarConstantsConsts : TarConstants
	{

		private TarConstantsConsts()
		{
		}
	}

}
