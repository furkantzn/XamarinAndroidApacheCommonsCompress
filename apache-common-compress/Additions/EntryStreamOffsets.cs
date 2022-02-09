using Android.Runtime;
using Java.Interop;
using System;

namespace Org.Apache.Commons.Compress.Archivers
{

	[Register("org/apache/commons/compress/archivers/EntryStreamOffsets", DoNotGenerateAcw = true)]
	public abstract class EntryStreamOffsets : global::Java.Lang.Object
	{

		internal EntryStreamOffsets()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='EntryStreamOffsets']/field[@name='OFFSET_UNKNOWN']"
		[Register("OFFSET_UNKNOWN")]
		public const long OffsetUnknown = (long)-1;
	}

	[Register("org/apache/commons/compress/archivers/EntryStreamOffsets", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'EntryStreamOffsets' type. This type will be removed in a future release.", error: true)]
	public abstract class EntryStreamOffsetsConsts : EntryStreamOffsets
	{

		private EntryStreamOffsetsConsts()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='EntryStreamOffsets']"
	[Register("org/apache/commons/compress/archivers/EntryStreamOffsets", "", "Org.Apache.Commons.Compress.Archivers.IEntryStreamOffsetsInvoker")]
	public partial interface IEntryStreamOffsets : IJavaObject, IJavaPeerable
	{

		long DataOffset
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='EntryStreamOffsets']/method[@name='getDataOffset' and count(parameter)=0]"
			[Register("getDataOffset", "()J", "GetGetDataOffsetHandler:Org.Apache.Commons.Compress.Archivers.IEntryStreamOffsetsInvoker, apache-common-compress")]
			get;
		}

		bool IsStreamContiguous
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers']/interface[@name='EntryStreamOffsets']/method[@name='isStreamContiguous' and count(parameter)=0]"
			[Register("isStreamContiguous", "()Z", "GetIsStreamContiguousHandler:Org.Apache.Commons.Compress.Archivers.IEntryStreamOffsetsInvoker, apache-common-compress")]
			get;
		}

	}

	[global::Android.Runtime.Register("org/apache/commons/compress/archivers/EntryStreamOffsets", DoNotGenerateAcw = true)]
	internal partial class IEntryStreamOffsetsInvoker : global::Java.Lang.Object, IEntryStreamOffsets
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("org/apache/commons/compress/archivers/EntryStreamOffsets", typeof(IEntryStreamOffsetsInvoker));

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

		public static IEntryStreamOffsets GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEntryStreamOffsets>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "org.apache.commons.compress.archivers.EntryStreamOffsets"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public IEntryStreamOffsetsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_getDataOffset;
#pragma warning disable 0169
		static Delegate GetGetDataOffsetHandler()
		{
			if (cb_getDataOffset == null)
				cb_getDataOffset = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_J)n_GetDataOffset);
			return cb_getDataOffset;
		}

		static long n_GetDataOffset(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.IEntryStreamOffsets>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataOffset;
		}
#pragma warning restore 0169

		IntPtr id_getDataOffset;
		public unsafe long DataOffset
		{
			get
			{
				if (id_getDataOffset == IntPtr.Zero)
					id_getDataOffset = JNIEnv.GetMethodID(class_ref, "getDataOffset", "()J");
				return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_getDataOffset);
			}
		}

		static Delegate cb_isStreamContiguous;
#pragma warning disable 0169
		static Delegate GetIsStreamContiguousHandler()
		{
			if (cb_isStreamContiguous == null)
				cb_isStreamContiguous = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsStreamContiguous);
			return cb_isStreamContiguous;
		}

		static bool n_IsStreamContiguous(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.IEntryStreamOffsets>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreamContiguous;
		}
#pragma warning restore 0169

		IntPtr id_isStreamContiguous;
		public unsafe bool IsStreamContiguous
		{
			get
			{
				if (id_isStreamContiguous == IntPtr.Zero)
					id_isStreamContiguous = JNIEnv.GetMethodID(class_ref, "isStreamContiguous", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isStreamContiguous);
			}
		}

	}

}
