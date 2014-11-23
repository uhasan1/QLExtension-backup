/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace QuantLib {

public class MCDiscreteArithmeticASEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MCDiscreteArithmeticASEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.MCDiscreteArithmeticASEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MCDiscreteArithmeticASEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MCDiscreteArithmeticASEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_MCDiscreteArithmeticASEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance, int maxSamples, int seed) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_0(GeneralizedBlackScholesProcess.getCPtr(process), traits, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance, maxSamples, seed), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance, int maxSamples) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_1(GeneralizedBlackScholesProcess.getCPtr(process), traits, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance, maxSamples), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_2(GeneralizedBlackScholesProcess.getCPtr(process), traits, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits, bool brownianBridge, bool antitheticVariate, int requiredSamples) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_3(GeneralizedBlackScholesProcess.getCPtr(process), traits, brownianBridge, antitheticVariate, requiredSamples), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits, bool brownianBridge, bool antitheticVariate) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_4(GeneralizedBlackScholesProcess.getCPtr(process), traits, brownianBridge, antitheticVariate), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits, bool brownianBridge) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_5(GeneralizedBlackScholesProcess.getCPtr(process), traits, brownianBridge), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCDiscreteArithmeticASEngine(GeneralizedBlackScholesProcess process, string traits) : this(NQuantLibcPINVOKE.new_MCDiscreteArithmeticASEngine__SWIG_6(GeneralizedBlackScholesProcess.getCPtr(process), traits), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}