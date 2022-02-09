using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Apache.Commons.Compress.Archivers
{

	[Register("org/apache/commons/compress/archivers/ArchiveEntry", DoNotGenerateAcw = true)]
	public abstract class ArchiveEntry : global::Java.Lang.Object
	{

		internal ArchiveEntry()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='ArchiveEntry']/field[@name='SIZE_UNKNOWN']"
		[Register("SIZE_UNKNOWN")]
		public const long SizeUnknown = (long)-1;
	}

	[Register("org/apache/commons/compress/archivers/ArchiveEntry", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'ArchiveEntry' type. This type will be removed in a future release.", error: true)]
	public abstract class ArchiveEntryConsts : ArchiveEntry
	{

		private ArchiveEntryConsts()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='ArchiveEntry']"
	[Register("org/apache/commons/compress/archivers/ArchiveEntry", "", "Org.Apache.Commons.Compress.Archivers.IArchiveEntryInvoker")]
	public partial interface IArchiveEntry : IJavaObject, IJavaPeerable
	{

		bool IsDirectory
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='ArchiveEntry']/method[@name='isDirectory' and count(parameter)=0]"
			[Register("isDirectory", "()Z", "GetIsDirectoryHandler:Org.Apache.Commons.Compress.Archivers.IArchiveEntryInvoker, apache-common-compress")]
			get;
		}

		global::Java.Util.Date LastModifiedDate
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='ArchiveEntry']/method[@name='getLastModifiedDate' and count(parameter)=0]"
			[Register("getLastModifiedDate", "()Ljava/util/Date;", "GetGetLastModifiedDateHandler:Org.Apache.Commons.Compress.Archivers.IArchiveEntryInvoker, apache-common-compress")]
			get;
		}

		string Name
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='ArchiveEntry']/method[@name='getName' and count(parameter)=0]"
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Apache.Commons.Compress.Archivers.IArchiveEntryInvoker, apache-common-compress")]
			get;
		}

		long Size
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='ArchiveEntry']/method[@name='getSize' and count(parameter)=0]"
			[Register("getSize", "()J", "GetGetSizeHandler:Org.Apache.Commons.Compress.Archivers.IArchiveEntryInvoker, apache-common-compress")]
			get;
		}

	}

	[global::Android.Runtime.Register("org/apache/commons/compress/archivers/ArchiveEntry", DoNotGenerateAcw = true)]
	internal partial class IArchiveEntryInvoker : global::Java.Lang.Object, IArchiveEntry
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("org/apache/commons/compress/archivers/ArchiveEntry", typeof(IArchiveEntryInvoker));

		static IntPtr java_class_ref
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IArchiveEntry GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IArchiveEntry>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "org.apache.commons.compress.archivers.ArchiveEntry"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public IArchiveEntryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_isDirectory;
#pragma warning disable 0169
		static Delegate GetIsDirectoryHandler()
		{
			if (cb_isDirectory == null)
				cb_isDirectory = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsDirectory);
			return cb_isDirectory;
		}

		static bool n_IsDirectory(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.IArchiveEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDirectory;
		}
#pragma warning restore 0169

		IntPtr id_isDirectory;
		public unsafe bool IsDirectory
		{
			get
			{
				if (id_isDirectory == IntPtr.Zero)
					id_isDirectory = JNIEnv.GetMethodID(class_ref, "isDirectory", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isDirectory);
			}
		}

		static Delegate cb_getLastModifiedDate;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedDateHandler()
		{
			if (cb_getLastModifiedDate == null)
				cb_getLastModifiedDate = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetLastModifiedDate);
			return cb_getLastModifiedDate;
		}

		static IntPtr n_GetLastModifiedDate(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.IArchiveEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.LastModifiedDate);
		}
#pragma warning restore 0169

		IntPtr id_getLastModifiedDate;
		public unsafe global::Java.Util.Date LastModifiedDate
		{
			get
			{
				if (id_getLastModifiedDate == IntPtr.Zero)
					id_getLastModifiedDate = JNIEnv.GetMethodID(class_ref, "getLastModifiedDate", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getLastModifiedDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.IArchiveEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name
		{
			get
			{
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID(class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_J)n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.IArchiveEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		IntPtr id_getSize;
		public unsafe long Size
		{
			get
			{
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID(class_ref, "getSize", "()J");
				return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_getSize);
			}
		}

	}

}
