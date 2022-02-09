using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Apache.Commons.Compress.Archivers.Zip
{

	[Register("org/apache/commons/compress/archivers/zip/ZipExtraField", DoNotGenerateAcw = true)]
	public abstract class ZipExtraField : global::Java.Lang.Object
	{

		internal ZipExtraField()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/field[@name='EXTRAFIELD_HEADER_SIZE']"
		[Register("EXTRAFIELD_HEADER_SIZE")]
		public const int ExtrafieldHeaderSize = (int)4;
	}

	[Register("org/apache/commons/compress/archivers/zip/ZipExtraField", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'ZipExtraField' type. This type will be removed in a future release.", error: true)]
	public abstract class ZipExtraFieldConsts : ZipExtraField
	{

		private ZipExtraFieldConsts()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']"
	[Register("org/apache/commons/compress/archivers/zip/ZipExtraField", "", "Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker")]
	public partial interface IZipExtraField : IJavaObject, IJavaPeerable
	{

		global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort CentralDirectoryLength
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='getCentralDirectoryLength' and count(parameter)=0]"
			[Register("getCentralDirectoryLength", "()Lorg/apache/commons/compress/archivers/zip/ZipShort;", "GetGetCentralDirectoryLengthHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
			get;
		}

		global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort HeaderId
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='getHeaderId' and count(parameter)=0]"
			[Register("getHeaderId", "()Lorg/apache/commons/compress/archivers/zip/ZipShort;", "GetGetHeaderIdHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
			get;
		}

		global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort LocalFileDataLength
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='getLocalFileDataLength' and count(parameter)=0]"
			[Register("getLocalFileDataLength", "()Lorg/apache/commons/compress/archivers/zip/ZipShort;", "GetGetLocalFileDataLengthHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
			get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='getCentralDirectoryData' and count(parameter)=0]"
		[Register("getCentralDirectoryData", "()[B", "GetGetCentralDirectoryDataHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
		byte[] GetCentralDirectoryData();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='getLocalFileDataData' and count(parameter)=0]"
		[Register("getLocalFileDataData", "()[B", "GetGetLocalFileDataDataHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
		byte[] GetLocalFileDataData();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='parseFromCentralDirectoryData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register("parseFromCentralDirectoryData", "([BII)V", "GetParseFromCentralDirectoryData_arrayBIIHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
		void ParseFromCentralDirectoryData(byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.zip']/interface[@name='ZipExtraField']/method[@name='parseFromLocalFileData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register("parseFromLocalFileData", "([BII)V", "GetParseFromLocalFileData_arrayBIIHandler:Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraFieldInvoker, apache-common-compress")]
		void ParseFromLocalFileData(byte[] p0, int p1, int p2);

	}

	[global::Android.Runtime.Register("org/apache/commons/compress/archivers/zip/ZipExtraField", DoNotGenerateAcw = true)]
	internal partial class IZipExtraFieldInvoker : global::Java.Lang.Object, IZipExtraField
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("org/apache/commons/compress/archivers/zip/ZipExtraField", typeof(IZipExtraFieldInvoker));

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

		public static IZipExtraField GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IZipExtraField>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "org.apache.commons.compress.archivers.zip.ZipExtraField"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public IZipExtraFieldInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_getCentralDirectoryLength;
#pragma warning disable 0169
		static Delegate GetGetCentralDirectoryLengthHandler()
		{
			if (cb_getCentralDirectoryLength == null)
				cb_getCentralDirectoryLength = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCentralDirectoryLength);
			return cb_getCentralDirectoryLength;
		}

		static IntPtr n_GetCentralDirectoryLength(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.CentralDirectoryLength);
		}
#pragma warning restore 0169

		IntPtr id_getCentralDirectoryLength;
		public unsafe global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort CentralDirectoryLength
		{
			get
			{
				if (id_getCentralDirectoryLength == IntPtr.Zero)
					id_getCentralDirectoryLength = JNIEnv.GetMethodID(class_ref, "getCentralDirectoryLength", "()Lorg/apache/commons/compress/archivers/zip/ZipShort;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getCentralDirectoryLength), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeaderId;
#pragma warning disable 0169
		static Delegate GetGetHeaderIdHandler()
		{
			if (cb_getHeaderId == null)
				cb_getHeaderId = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetHeaderId);
			return cb_getHeaderId;
		}

		static IntPtr n_GetHeaderId(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.HeaderId);
		}
#pragma warning restore 0169

		IntPtr id_getHeaderId;
		public unsafe global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort HeaderId
		{
			get
			{
				if (id_getHeaderId == IntPtr.Zero)
					id_getHeaderId = JNIEnv.GetMethodID(class_ref, "getHeaderId", "()Lorg/apache/commons/compress/archivers/zip/ZipShort;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getHeaderId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocalFileDataLength;
#pragma warning disable 0169
		static Delegate GetGetLocalFileDataLengthHandler()
		{
			if (cb_getLocalFileDataLength == null)
				cb_getLocalFileDataLength = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetLocalFileDataLength);
			return cb_getLocalFileDataLength;
		}

		static IntPtr n_GetLocalFileDataLength(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.LocalFileDataLength);
		}
#pragma warning restore 0169

		IntPtr id_getLocalFileDataLength;
		public unsafe global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort LocalFileDataLength
		{
			get
			{
				if (id_getLocalFileDataLength == IntPtr.Zero)
					id_getLocalFileDataLength = JNIEnv.GetMethodID(class_ref, "getLocalFileDataLength", "()Lorg/apache/commons/compress/archivers/zip/ZipShort;");
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.ZipShort>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getLocalFileDataLength), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCentralDirectoryData;
#pragma warning disable 0169
		static Delegate GetGetCentralDirectoryDataHandler()
		{
			if (cb_getCentralDirectoryData == null)
				cb_getCentralDirectoryData = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCentralDirectoryData);
			return cb_getCentralDirectoryData;
		}

		static IntPtr n_GetCentralDirectoryData(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(__this.GetCentralDirectoryData());
		}
#pragma warning restore 0169

		IntPtr id_getCentralDirectoryData;
		public unsafe byte[] GetCentralDirectoryData()
		{
			if (id_getCentralDirectoryData == IntPtr.Zero)
				id_getCentralDirectoryData = JNIEnv.GetMethodID(class_ref, "getCentralDirectoryData", "()[B");
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getCentralDirectoryData), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		static Delegate cb_getLocalFileDataData;
#pragma warning disable 0169
		static Delegate GetGetLocalFileDataDataHandler()
		{
			if (cb_getLocalFileDataData == null)
				cb_getLocalFileDataData = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetLocalFileDataData);
			return cb_getLocalFileDataData;
		}

		static IntPtr n_GetLocalFileDataData(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(__this.GetLocalFileDataData());
		}
#pragma warning restore 0169

		IntPtr id_getLocalFileDataData;
		public unsafe byte[] GetLocalFileDataData()
		{
			if (id_getLocalFileDataData == IntPtr.Zero)
				id_getLocalFileDataData = JNIEnv.GetMethodID(class_ref, "getLocalFileDataData", "()[B");
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getLocalFileDataData), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		static Delegate cb_parseFromCentralDirectoryData_arrayBII;
#pragma warning disable 0169
		static Delegate GetParseFromCentralDirectoryData_arrayBIIHandler()
		{
			if (cb_parseFromCentralDirectoryData_arrayBII == null)
				cb_parseFromCentralDirectoryData_arrayBII = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLII_V)n_ParseFromCentralDirectoryData_arrayBII);
			return cb_parseFromCentralDirectoryData_arrayBII;
		}

		static void n_ParseFromCentralDirectoryData_arrayBII(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
			__this.ParseFromCentralDirectoryData(p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray(p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_parseFromCentralDirectoryData_arrayBII;
		public unsafe void ParseFromCentralDirectoryData(byte[] p0, int p1, int p2)
		{
			if (id_parseFromCentralDirectoryData_arrayBII == IntPtr.Zero)
				id_parseFromCentralDirectoryData_arrayBII = JNIEnv.GetMethodID(class_ref, "parseFromCentralDirectoryData", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray(p0);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_p0);
			__args[1] = new JValue(p1);
			__args[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_parseFromCentralDirectoryData_arrayBII, __args);
			if (p0 != null)
			{
				JNIEnv.CopyArray(native_p0, p0);
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		static Delegate cb_parseFromLocalFileData_arrayBII;
#pragma warning disable 0169
		static Delegate GetParseFromLocalFileData_arrayBIIHandler()
		{
			if (cb_parseFromLocalFileData_arrayBII == null)
				cb_parseFromLocalFileData_arrayBII = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLII_V)n_ParseFromLocalFileData_arrayBII);
			return cb_parseFromLocalFileData_arrayBII;
		}

		static void n_ParseFromLocalFileData_arrayBII(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Zip.IZipExtraField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
			__this.ParseFromLocalFileData(p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray(p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_parseFromLocalFileData_arrayBII;
		public unsafe void ParseFromLocalFileData(byte[] p0, int p1, int p2)
		{
			if (id_parseFromLocalFileData_arrayBII == IntPtr.Zero)
				id_parseFromLocalFileData_arrayBII = JNIEnv.GetMethodID(class_ref, "parseFromLocalFileData", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray(p0);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_p0);
			__args[1] = new JValue(p1);
			__args[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_parseFromLocalFileData_arrayBII, __args);
			if (p0 != null)
			{
				JNIEnv.CopyArray(native_p0, p0);
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

	}

}
