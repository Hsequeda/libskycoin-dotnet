//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class cipher_SHA256s : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal cipher_SHA256s(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(cipher_SHA256s obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~cipher_SHA256s() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_cipher_SHA256s(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public cipher_SHA256 getAt(int i) {
    global::System.IntPtr cPtr = skycoinPINVOKE.cipher_SHA256s_getAt(swigCPtr, i);
    cipher_SHA256 ret = (cPtr == global::System.IntPtr.Zero) ? null : new cipher_SHA256(cPtr, false);
    return ret;
  }

  public int setAt(int i, cipher_SHA256 hash) {
    int ret = skycoinPINVOKE.cipher_SHA256s_setAt(swigCPtr, i, cipher_SHA256.getCPtr(hash));
    return ret;
  }

  public int isEqual(cipher_SHA256s a) {
    int ret = skycoinPINVOKE.cipher_SHA256s_isEqual(swigCPtr, cipher_SHA256s.getCPtr(a));
    return ret;
  }

  public void allocate(int n) {
    skycoinPINVOKE.cipher_SHA256s_allocate(swigCPtr, n);
  }

  public void release() {
    skycoinPINVOKE.cipher_SHA256s_release(swigCPtr);
  }

  public cipher_SHA256 data {
    set {
      skycoinPINVOKE.cipher_SHA256s_data_set(swigCPtr, cipher_SHA256.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.cipher_SHA256s_data_get(swigCPtr);
      cipher_SHA256 ret = (cPtr == global::System.IntPtr.Zero) ? null : new cipher_SHA256(cPtr, false);
      return ret;
    } 
  }

  public int count {
    set {
      skycoinPINVOKE.cipher_SHA256s_count_set(swigCPtr, value);
    } 
    get {
      int ret = skycoinPINVOKE.cipher_SHA256s_count_get(swigCPtr);
      return ret;
    } 
  }

  public cipher_SHA256s() : this(skycoinPINVOKE.new_cipher_SHA256s(), true) {
  }

}
