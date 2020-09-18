// This file was generated by cswinrt.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WinRT;
using WinRT.Interop;


#pragma warning disable 0169 // warning CS0169: The field '...' is never used
#pragma warning disable 0649 // warning CS0169: Field '...' is never assigned to
#pragma warning disable CA2207, CA1063, CA1033, CA1001, CA2213

namespace SimpleMathComponent
{
    [global::WinRT.WindowsRuntimeType("SimpleMathComponent")]
    [Guid("C5294299-09C8-5F7F-9FAE-46993031C242")]
    [Windows.Foundation.Metadata.ExclusiveTo(typeof(SimpleMath))]
    [Windows.Foundation.Metadata.Version(1u)]
    internal interface ISimpleMath
    {
        double add(double firstNumber, double secondNumber);
        double subtract(double firstNumber, double secondNumber);
        double multiply(double firstNumber, double secondNumber);
        double divide(double firstNumber, double secondNumber);
    }
    [global::WinRT.WindowsRuntimeType("SimpleMathComponent")]
    [global::WinRT.ProjectedRuntimeClass(nameof(_default))]
    [Windows.Foundation.Metadata.Activatable(1u)]
    [Windows.Foundation.Metadata.MarshalingBehavior(global::Windows.Foundation.Metadata.MarshalingType.Agile)]
    [Windows.Foundation.Metadata.Threading(global::Windows.Foundation.Metadata.ThreadingModel.Both)]
    [Windows.Foundation.Metadata.Version(1u)]
    public sealed class SimpleMath : global::System.Runtime.InteropServices.ICustomQueryInterface, IEquatable<SimpleMath>
    {
        public IntPtr ThisPtr => _default.ThisPtr;

        private IObjectReference _inner = null;
        private readonly Lazy<global::ABI.SimpleMathComponent.ISimpleMath> _defaultLazy;
        private readonly Dictionary<Type, object> _lazyInterfaces;

        private global::ABI.SimpleMathComponent.ISimpleMath _default => _defaultLazy.Value;

        public SimpleMath() : this(new global::ABI.SimpleMathComponent.ISimpleMath(ActivationFactory<SimpleMath>.ActivateInstance<global::ABI.SimpleMathComponent.ISimpleMath.Vftbl>()))
        {
            ComWrappersSupport.RegisterObjectForInterface(this, ThisPtr);
        }

        public static SimpleMath FromAbi(IntPtr thisPtr)
        {
            if (thisPtr == IntPtr.Zero) return null;
            var obj = MarshalInspectable.FromAbi(thisPtr);
            return obj is SimpleMath ? (SimpleMath)obj : new SimpleMath((global::ABI.SimpleMathComponent.ISimpleMath)obj);
        }

        internal SimpleMath(global::ABI.SimpleMathComponent.ISimpleMath ifc)
        {
            _defaultLazy = new Lazy<global::ABI.SimpleMathComponent.ISimpleMath>(() => ifc);
            _lazyInterfaces = new Dictionary<Type, object>()
            {
            };
        }

        public static bool operator ==(SimpleMath x, SimpleMath y) => (x?.ThisPtr ?? IntPtr.Zero) == (y?.ThisPtr ?? IntPtr.Zero);
        public static bool operator !=(SimpleMath x, SimpleMath y) => !(x == y);
        public bool Equals(SimpleMath other) => this == other;
        public override bool Equals(object obj) => obj is SimpleMath that && this == that;
        public override int GetHashCode() => ThisPtr.GetHashCode();

        private  IObjectReference GetDefaultReference<T>() => _default.AsInterface<T>();
        private  IObjectReference GetReferenceForQI() => _inner ?? _default.ObjRef;

        private struct InterfaceTag<I>{};

        private ISimpleMath AsInternal(InterfaceTag<ISimpleMath> _) => _default;

        public double add(double firstNumber, double secondNumber) => _default.add(firstNumber, secondNumber);

        public double subtract(double firstNumber, double secondNumber) => _default.subtract(firstNumber, secondNumber);

        public double multiply(double firstNumber, double secondNumber) => _default.multiply(firstNumber, secondNumber);

        public double divide(double firstNumber, double secondNumber) => _default.divide(firstNumber, secondNumber);

        private bool IsOverridableInterface(Guid iid) => false;

        global::System.Runtime.InteropServices.CustomQueryInterfaceResult global::System.Runtime.InteropServices.ICustomQueryInterface.GetInterface(ref Guid iid, out IntPtr ppv)
        {
            ppv = IntPtr.Zero;
            if (IsOverridableInterface(iid) || typeof(global::WinRT.IInspectable).GUID == iid)
            {
                return global::System.Runtime.InteropServices.CustomQueryInterfaceResult.NotHandled;
            }

            if (GetReferenceForQI().TryAs<IUnknownVftbl>(iid, out ObjectReference<IUnknownVftbl> objRef) >= 0)
            {
                using (objRef)
                {
                    ppv = objRef.GetRef();
                    return global::System.Runtime.InteropServices.CustomQueryInterfaceResult.Handled;
                }
            }

            return global::System.Runtime.InteropServices.CustomQueryInterfaceResult.NotHandled;
        }
    }
}

namespace ABI.SimpleMathComponent
{
    [global::WinRT.ObjectReferenceWrapper(nameof(_obj))]
    [Guid("C5294299-09C8-5F7F-9FAE-46993031C242")]
    public unsafe class ISimpleMath : global::SimpleMathComponent.ISimpleMath
    {
        [Guid("C5294299-09C8-5F7F-9FAE-46993031C242")]
        public struct Vftbl
        {
            internal IInspectable.Vftbl IInspectableVftbl;
            private delegate*<IntPtr, double, double, double*, int> _add_0;
            public delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int> add_0 { get => (delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int>)_add_0; set => _add_0=(delegate*<IntPtr, double, double, double*, int>)value; }
            private delegate*<IntPtr, double, double, double*, int> _subtract_1;
            public delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int> subtract_1 { get => (delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int>)_subtract_1; set => _subtract_1=(delegate*<IntPtr, double, double, double*, int>)value; }
            private delegate*<IntPtr, double, double, double*, int> _multiply_2;
            public delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int> multiply_2 { get => (delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int>)_multiply_2; set => _multiply_2=(delegate*<IntPtr, double, double, double*, int>)value; }
            private delegate*<IntPtr, double, double, double*, int> _divide_3;
            public delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int> divide_3 { get => (delegate* unmanaged[Stdcall]<IntPtr, double, double, out double, int>)_divide_3; set => _divide_3=(delegate*<IntPtr, double, double, double*, int>)value; }

            public static readonly IntPtr AbiToProjectionVftablePtr;

            static unsafe Vftbl()
            {
                AbiToProjectionVftablePtr = ComWrappersSupport.AllocateVtableMemory(typeof(Vftbl), Marshal.SizeOf<global::WinRT.IInspectable.Vftbl>() + sizeof(IntPtr) * 4);
                (*(Vftbl*)AbiToProjectionVftablePtr) = new Vftbl
                {
                    IInspectableVftbl = global::WinRT.IInspectable.Vftbl.AbiToProjectionVftable, 
                    _add_0 = &Do_Abi_add_0,
                    _subtract_1 = &Do_Abi_subtract_1,
                    _multiply_2 = &Do_Abi_multiply_2,
                    _divide_3 = &Do_Abi_divide_3
                };
            }

            [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
            private static unsafe int Do_Abi_add_0(IntPtr thisPtr, double firstNumber, double secondNumber, double* result)
            {
                double __result = default;

                *result = default;

                try
                {
                    __result = global::WinRT.ComWrappersSupport.FindObject<global::SimpleMathComponent.ISimpleMath>(thisPtr).add(firstNumber, secondNumber);
                    *result = __result;

                }
                catch (Exception __exception__)
                {
                    global::WinRT.ExceptionHelpers.SetErrorInfo(__exception__);
                    return global::WinRT.ExceptionHelpers.GetHRForException(__exception__);
                }
                return 0;
            }
            [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
            private static unsafe int Do_Abi_subtract_1(IntPtr thisPtr, double firstNumber, double secondNumber, double* result)
            {
                double __result = default;

                *result = default;

                try
                {
                    __result = global::WinRT.ComWrappersSupport.FindObject<global::SimpleMathComponent.ISimpleMath>(thisPtr).subtract(firstNumber, secondNumber);
                    *result = __result;

                }
                catch (Exception __exception__)
                {
                    global::WinRT.ExceptionHelpers.SetErrorInfo(__exception__);
                    return global::WinRT.ExceptionHelpers.GetHRForException(__exception__);
                }
                return 0;
            }
            [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
            private static unsafe int Do_Abi_multiply_2(IntPtr thisPtr, double firstNumber, double secondNumber, double* result)
            {
                double __result = default;

                *result = default;

                try
                {
                    __result = global::WinRT.ComWrappersSupport.FindObject<global::SimpleMathComponent.ISimpleMath>(thisPtr).multiply(firstNumber, secondNumber);
                    *result = __result;

                }
                catch (Exception __exception__)
                {
                    global::WinRT.ExceptionHelpers.SetErrorInfo(__exception__);
                    return global::WinRT.ExceptionHelpers.GetHRForException(__exception__);
                }
                return 0;
            }
            [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
            private static unsafe int Do_Abi_divide_3(IntPtr thisPtr, double firstNumber, double secondNumber, double* result)
            {
                double __result = default;

                *result = default;

                try
                {
                    __result = global::WinRT.ComWrappersSupport.FindObject<global::SimpleMathComponent.ISimpleMath>(thisPtr).divide(firstNumber, secondNumber);
                    *result = __result;

                }
                catch (Exception __exception__)
                {
                    global::WinRT.ExceptionHelpers.SetErrorInfo(__exception__);
                    return global::WinRT.ExceptionHelpers.GetHRForException(__exception__);
                }
                return 0;
            }
        }
        internal static ObjectReference<Vftbl> FromAbi(IntPtr thisPtr) => ObjectReference<Vftbl>.FromAbi(thisPtr);

        public static implicit operator ISimpleMath(IObjectReference obj) => (obj != null) ? new ISimpleMath(obj) : null;
        protected readonly ObjectReference<Vftbl> _obj;
        public IObjectReference ObjRef { get => _obj; }
        public IntPtr ThisPtr => _obj.ThisPtr;
        public ObjectReference<I> AsInterface<I>() => _obj.As<I>();
        public A As<A>() => _obj.AsType<A>();
        public ISimpleMath(IObjectReference obj) : this(obj.As<Vftbl>()) {}
        internal ISimpleMath(ObjectReference<Vftbl> obj)
        {
            _obj = obj;
        }

        public unsafe double add(double firstNumber, double secondNumber)
        {
            double __retval = default;
            global::WinRT.ExceptionHelpers.ThrowExceptionForHR(_obj.Vftbl.add_0(ThisPtr, firstNumber, secondNumber, out __retval));
            return __retval;
        }

        public unsafe double subtract(double firstNumber, double secondNumber)
        {
            double __retval = default;
            global::WinRT.ExceptionHelpers.ThrowExceptionForHR(_obj.Vftbl.subtract_1(ThisPtr, firstNumber, secondNumber, out __retval));
            return __retval;
        }

        public unsafe double multiply(double firstNumber, double secondNumber)
        {
            double __retval = default;
            global::WinRT.ExceptionHelpers.ThrowExceptionForHR(_obj.Vftbl.multiply_2(ThisPtr, firstNumber, secondNumber, out __retval));
            return __retval;
        }

        public unsafe double divide(double firstNumber, double secondNumber)
        {
            double __retval = default;
            global::WinRT.ExceptionHelpers.ThrowExceptionForHR(_obj.Vftbl.divide_3(ThisPtr, firstNumber, secondNumber, out __retval));
            return __retval;
        }
    }

    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    public struct SimpleMath
    {
        public static IObjectReference CreateMarshaler(global::SimpleMathComponent.SimpleMath obj) => obj is null ? null : MarshalInspectable.CreateMarshaler(obj).As<ISimpleMath.Vftbl>();
        public static IntPtr GetAbi(IObjectReference value) => value is null ? IntPtr.Zero : MarshalInterfaceHelper<object>.GetAbi(value);
        public static global::SimpleMathComponent.SimpleMath FromAbi(IntPtr thisPtr) => global::SimpleMathComponent.SimpleMath.FromAbi(thisPtr);
        public static IntPtr FromManaged(global::SimpleMathComponent.SimpleMath obj) => obj is null ? IntPtr.Zero : CreateMarshaler(obj).GetRef();
        public static unsafe MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.MarshalerArray CreateMarshalerArray(global::SimpleMathComponent.SimpleMath[] array) => MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.CreateMarshalerArray(array, (o) => CreateMarshaler(o));
        public static (int length, IntPtr data) GetAbiArray(object box) => MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.GetAbiArray(box);
        public static unsafe global::SimpleMathComponent.SimpleMath[] FromAbiArray(object box) => MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.FromAbiArray(box, FromAbi);
        public static (int length, IntPtr data) FromManagedArray(global::SimpleMathComponent.SimpleMath[] array) => MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.FromManagedArray(array, (o) => FromManaged(o));
        public static void DisposeMarshaler(IObjectReference value) => MarshalInspectable.DisposeMarshaler(value);
        public static void DisposeMarshalerArray(MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.MarshalerArray array) => MarshalInterfaceHelper<global::SimpleMathComponent.SimpleMath>.DisposeMarshalerArray(array);
        public static void DisposeAbi(IntPtr abi) => MarshalInspectable.DisposeAbi(abi);
        public static unsafe void DisposeAbiArray(object box) => MarshalInspectable.DisposeAbiArray(box);
    }
}
