//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class encoder__StructField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal encoder__StructField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(encoder__StructField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~encoder__StructField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_encoder__StructField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_GoString_ Name {
    set {
      skycoinPINVOKE.encoder__StructField_Name_set(swigCPtr, SWIGTYPE_p_GoString_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoString_ ret = new SWIGTYPE_p_GoString_(skycoinPINVOKE.encoder__StructField_Name_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_GoUint32_ Kind {
    set {
      skycoinPINVOKE.encoder__StructField_Kind_set(swigCPtr, SWIGTYPE_p_GoUint32_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoUint32_ ret = new SWIGTYPE_p_GoUint32_(skycoinPINVOKE.encoder__StructField_Kind_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_GoString_ Type {
    set {
      skycoinPINVOKE.encoder__StructField_Type_set(swigCPtr, SWIGTYPE_p_GoString_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoString_ ret = new SWIGTYPE_p_GoString_(skycoinPINVOKE.encoder__StructField_Type_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_GoString_ Tag {
    set {
      skycoinPINVOKE.encoder__StructField_Tag_set(swigCPtr, SWIGTYPE_p_GoString_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoString_ ret = new SWIGTYPE_p_GoString_(skycoinPINVOKE.encoder__StructField_Tag_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public encoder__StructField() : this(skycoinPINVOKE.new_encoder__StructField(), true) {
  }

}
