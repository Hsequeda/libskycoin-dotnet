//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class wallet__Wallet : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal wallet__Wallet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(wallet__Wallet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~wallet__Wallet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_wallet__Wallet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_GoMap_ Meta {
    set {
      skycoinPINVOKE.wallet__Wallet_Meta_set(swigCPtr, SWIGTYPE_p_GoMap_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoMap_ ret = new SWIGTYPE_p_GoMap_(skycoinPINVOKE.wallet__Wallet_Meta_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_GoSlice_ Entries {
    set {
      skycoinPINVOKE.wallet__Wallet_Entries_set(swigCPtr, SWIGTYPE_p_GoSlice_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoSlice_ ret = new SWIGTYPE_p_GoSlice_(skycoinPINVOKE.wallet__Wallet_Entries_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public wallet__Wallet() : this(skycoinPINVOKE.new_wallet__Wallet(), true) {
  }

}
