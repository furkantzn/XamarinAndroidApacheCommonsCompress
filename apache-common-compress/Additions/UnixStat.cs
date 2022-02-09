using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Apache.Commons.Compress.Archivers.Zip
{

	[Register("org/apache/commons/compress/archivers/zip/UnixStat", DoNotGenerateAcw = true)]
	public abstract class UnixStat : global::Java.Lang.Object
	{

		internal UnixStat()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='DEFAULT_DIR_PERM']"
		[Register("DEFAULT_DIR_PERM")]
		public const int DefaultDirPerm = (int)493;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='DEFAULT_FILE_PERM']"
		[Register("DEFAULT_FILE_PERM")]
		public const int DefaultFilePerm = (int)420;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='DEFAULT_LINK_PERM']"
		[Register("DEFAULT_LINK_PERM")]
		public const int DefaultLinkPerm = (int)511;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='DIR_FLAG']"
		[Register("DIR_FLAG")]
		public const int DirFlag = (int)16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='FILE_FLAG']"
		[Register("FILE_FLAG")]
		public const int FileFlag = (int)32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='FILE_TYPE_FLAG']"
		[Register("FILE_TYPE_FLAG")]
		public const int FileTypeFlag = (int)61440;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='LINK_FLAG']"
		[Register("LINK_FLAG")]
		public const int LinkFlag = (int)40960;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='UnixStat']/field[@name='PERM_MASK']"
		[Register("PERM_MASK")]
		public const int PermMask = (int)4095;
	}

	[Register("org/apache/commons/compress/archivers/zip/UnixStat", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'UnixStat' type. This type will be removed in a future release.", error: true)]
	public abstract class UnixStatConsts : UnixStat
	{

		private UnixStatConsts()
		{
		}
	}

}
