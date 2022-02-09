using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Apache.Commons.Compress.Archivers.Examples
{

	[Register("org/apache/commons/compress/archivers/examples/CloseableConsumer", DoNotGenerateAcw = true)]
	public abstract class CloseableConsumer :global::Java.Lang.Object
	{

		internal CloseableConsumer()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.examples']/interface[@name='CloseableConsumer']/field[@name='CLOSING_CONSUMER']"
		[Register("CLOSING_CONSUMER")]
		public static global::Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumer ClosingConsumer
		{
			get
			{
				const string __id = "CLOSING_CONSUMER.Lorg/apache/commons/compress/archivers/examples/CloseableConsumer;";

				var __v = _members.StaticFields.GetObjectValue(__id);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumer>(__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.compress.archivers.examples']/interface[@name='CloseableConsumer']/field[@name='NULL_CONSUMER']"
		[Register("NULL_CONSUMER")]
		public static global::Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumer NullConsumer
		{
			get
			{
				const string __id = "NULL_CONSUMER.Lorg/apache/commons/compress/archivers/examples/CloseableConsumer;";

				var __v = _members.StaticFields.GetObjectValue(__id);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumer>(__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers("org/apache/commons/compress/archivers/examples/CloseableConsumer", typeof(CloseableConsumer));
	}

	[Register("org/apache/commons/compress/archivers/examples/CloseableConsumer", DoNotGenerateAcw = true)]
	[global::System.Obsolete("Use the 'CloseableConsumer' type. This type will be removed in a future release.", error: true)]
	public abstract class CloseableConsumerConsts : CloseableConsumer
	{

		private CloseableConsumerConsts()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.compress.archivers.examples']/interface[@name='CloseableConsumer']"
	[Register("org/apache/commons/compress/archivers/examples/CloseableConsumer", "", "Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumerInvoker")]
	public partial interface ICloseableConsumer : IJavaObject, IJavaPeerable
	{

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.compress.archivers.examples']/interface[@name='CloseableConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register("accept", "(Ljava/io/Closeable;)V", "GetAccept_Ljava_io_Closeable_Handler:Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumerInvoker, apache-common-compress")]
		void Accept(global::Java.IO.ICloseable p0);

	}

	[global::Android.Runtime.Register("org/apache/commons/compress/archivers/examples/CloseableConsumer", DoNotGenerateAcw = true)]
	internal partial class ICloseableConsumerInvoker : global::Java.Lang.Object, ICloseableConsumer
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("org/apache/commons/compress/archivers/examples/CloseableConsumer", typeof(ICloseableConsumerInvoker));

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

		public static ICloseableConsumer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloseableConsumer>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "org.apache.commons.compress.archivers.examples.CloseableConsumer"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public ICloseableConsumerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_accept_Ljava_io_Closeable_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_io_Closeable_Handler()
		{
			if (cb_accept_Ljava_io_Closeable_ == null)
				cb_accept_Ljava_io_Closeable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_Accept_Ljava_io_Closeable_);
			return cb_accept_Ljava_io_Closeable_;
		}

		static void n_Accept_Ljava_io_Closeable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Compress.Archivers.Examples.ICloseableConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.IO.ICloseable)global::Java.Lang.Object.GetObject<global::Java.IO.ICloseable>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept(p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_io_Closeable_;
		public unsafe void Accept(global::Java.IO.ICloseable p0)
		{
			if (id_accept_Ljava_io_Closeable_ == IntPtr.Zero)
				id_accept_Ljava_io_Closeable_ = JNIEnv.GetMethodID(class_ref, "accept", "(Ljava/io/Closeable;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_accept_Ljava_io_Closeable_, __args);
		}

	}

}
