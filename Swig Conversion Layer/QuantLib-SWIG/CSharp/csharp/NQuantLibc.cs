//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class NQuantLibc {
  public static Matrix transpose(Matrix m) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.transpose(Matrix.getCPtr(m)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix outerProduct(QlArray v1, QlArray v2) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.outerProduct(QlArray.getCPtr(v1), QlArray.getCPtr(v2)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix pseudoSqrt(Matrix m, SalvagingAlgorithm.Type a) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.pseudoSqrt(Matrix.getCPtr(m), (int)a), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int nullInt() {
    int ret = NQuantLibcPINVOKE.nullInt();
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double nullDouble() {
    double ret = NQuantLibcPINVOKE.nullDouble();
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Coupon as_coupon(CashFlow cf) {
    Coupon ret = new Coupon(NQuantLibcPINVOKE.as_coupon(CashFlow.getCPtr(cf)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FixedRateCoupon as_fixed_rate_coupon(CashFlow cf) {
    FixedRateCoupon ret = new FixedRateCoupon(NQuantLibcPINVOKE.as_fixed_rate_coupon(CashFlow.getCPtr(cf)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setCouponPricer(Leg arg0, FloatingRateCouponPricer arg1) {
    NQuantLibcPINVOKE.setCouponPricer(Leg.getCPtr(arg0), FloatingRateCouponPricer.getCPtr(arg1));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FloatingRateCoupon as_floating_rate_coupon(CashFlow cf) {
    FloatingRateCoupon ret = new FloatingRateCoupon(NQuantLibcPINVOKE.as_floating_rate_coupon(CashFlow.getCPtr(cf)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg FixedRateLeg(Schedule schedule, DayCounter dayCount, DoubleVector nominals, DoubleVector couponRates, BusinessDayConvention paymentAdjustment, DayCounter firstPeriodDayCount) {
    Leg ret = new Leg(NQuantLibcPINVOKE.FixedRateLeg__SWIG_0(Schedule.getCPtr(schedule), DayCounter.getCPtr(dayCount), DoubleVector.getCPtr(nominals), DoubleVector.getCPtr(couponRates), (int)paymentAdjustment, DayCounter.getCPtr(firstPeriodDayCount)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg FixedRateLeg(Schedule schedule, DayCounter dayCount, DoubleVector nominals, DoubleVector couponRates, BusinessDayConvention paymentAdjustment) {
    Leg ret = new Leg(NQuantLibcPINVOKE.FixedRateLeg__SWIG_1(Schedule.getCPtr(schedule), DayCounter.getCPtr(dayCount), DoubleVector.getCPtr(nominals), DoubleVector.getCPtr(couponRates), (int)paymentAdjustment), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg FixedRateLeg(Schedule schedule, DayCounter dayCount, DoubleVector nominals, DoubleVector couponRates) {
    Leg ret = new Leg(NQuantLibcPINVOKE.FixedRateLeg__SWIG_2(Schedule.getCPtr(schedule), DayCounter.getCPtr(dayCount), DoubleVector.getCPtr(nominals), DoubleVector.getCPtr(couponRates)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, bool isInArrears) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_0(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors), isInArrears), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_1(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_2(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_3(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_4(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_5(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_6(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_7(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index) {
    Leg ret = new Leg(NQuantLibcPINVOKE.IborLeg__SWIG_8(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), IborIndex.getCPtr(index)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, bool isInArrears) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_0(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors), isInArrears), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_1(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_2(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_3(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_4(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_5(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_6(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_7(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsLeg__SWIG_8(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_0(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps), DoubleVector.getCPtr(floors)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_1(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads), DoubleVector.getCPtr(caps)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_2(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings), DoubleVector.getCPtr(spreads)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_3(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays), DoubleVector.getCPtr(gearings)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_4(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention, UnsignedIntVector.getCPtr(fixingDays)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_5(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter), (int)paymentConvention), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_6(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index), DayCounter.getCPtr(paymentDayCounter)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index) {
    Leg ret = new Leg(NQuantLibcPINVOKE.CmsZeroLeg__SWIG_7(DoubleVector.getCPtr(nominals), Schedule.getCPtr(schedule), SwapIndex.getCPtr(index)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date inflationBaseDate(Date referenceDate, Period observationLag, Frequency frequency, bool indexIsInterpolated) {
    Date ret = new Date(NQuantLibcPINVOKE.inflationBaseDate(Date.getCPtr(referenceDate), Period.getCPtr(observationLag), (int)frequency, indexIsInterpolated), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPriceFromZSpread(Bond bond, YieldTermStructure discountCurve, double zSpread, DayCounter dc, Compounding compounding, Frequency freq, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.cleanPriceFromZSpread__SWIG_0(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve), zSpread, DayCounter.getCPtr(dc), (int)compounding, (int)freq, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPriceFromZSpread(Bond bond, YieldTermStructure discountCurve, double zSpread, DayCounter dc, Compounding compounding, Frequency freq) {
    double ret = NQuantLibcPINVOKE.cleanPriceFromZSpread__SWIG_1(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve), zSpread, DayCounter.getCPtr(dc), (int)compounding, (int)freq);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Matrix getCovariance(QlArray volatilities, Matrix correlations) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.getCovariance(QlArray.getCPtr(volatilities), Matrix.getCPtr(correlations)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void enableTracing() {
    NQuantLibcPINVOKE.enableTracing();
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void disableTracing() {
    NQuantLibcPINVOKE.disableTracing();
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
