//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class cli__SendAmount : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal cli__SendAmount(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(cli__SendAmount obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~cli__SendAmount() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_cli__SendAmount(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_GoString_ Addr {
    set {
      skycoinPINVOKE.cli__SendAmount_Addr_set(swigCPtr, SWIGTYPE_p_GoString_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoString_ ret = new SWIGTYPE_p_GoString_(skycoinPINVOKE.cli__SendAmount_Addr_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_GoInt64_ Coins {
    set {
      skycoinPINVOKE.cli__SendAmount_Coins_set(swigCPtr, SWIGTYPE_p_GoInt64_.getCPtr(value));
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GoInt64_ ret = new SWIGTYPE_p_GoInt64_(skycoinPINVOKE.cli__SendAmount_Coins_get(swigCPtr), true);
      if (skycoinPINVOKE.SWIGPendingException.Pending) throw skycoinPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public cli__SendAmount() : this(skycoinPINVOKE.new_cli__SendAmount(), true) {
  }

}
