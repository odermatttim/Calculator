// <assemblyHash>e770b51f</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=12.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias cbl;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("CalculatorBusinessLogic", false)]
[assembly: global::System.Reflection.AssemblyCompany("Microsoft")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("CalculatorBusinessLogic")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace CalculatorBusinessLogic.Fakes
{
    /// <summary>Shim type of CalculatorBusinessLogic.Calculation</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(cbl::CalculatorBusinessLogic.Calculation))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of Calculation")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimCalculation
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<cbl::CalculatorBusinessLogic.Calculation>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimCalculation()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimCalculation(cbl::CalculatorBusinessLogic.Calculation instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of Calculation.Calculate(Collection`1&lt;Double&gt; operandsCollection, Collection`1&lt;Char&gt; operatorsCollection)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<cbl::CalculatorBusinessLogic.Calculation, global::System.Collections.ObjectModel.Collection<double>, global::System.Collections.ObjectModel.Collection<char>, double> CalculateCollectionOfDoubleCollectionOfChar
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("Calculate", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(cbl::CalculatorBusinessLogic.Calculation), (object)null, 
                         "Calculate", typeof(double), new global::System.Type[]
                                                          {typeof(global::System.Collections.ObjectModel.Collection<double>), typeof(global::System.Collections.ObjectModel.Collection<char>)});
                }
            }

            /// <summary>Sets the shim of Calculation.get_Result()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<cbl::CalculatorBusinessLogic.Calculation, double> ResultGet
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_Result", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(cbl::CalculatorBusinessLogic.Calculation), (object)null, 
                         "get_Result", typeof(double), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of Calculation.set_Result(Double value)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<cbl::CalculatorBusinessLogic.Calculation, double> ResultSetDouble
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("set_Result", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(cbl::CalculatorBusinessLogic.Calculation), (object)null, 
                         "set_Result", typeof(void), new global::System.Type[]{typeof(double)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::CalculatorBusinessLogic.Fakes.ShimCalculation.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::CalculatorBusinessLogic.Fakes.ShimCalculation.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(cbl::CalculatorBusinessLogic.Calculation), value);
            }
        }

        /// <summary>Binds the members of the interface to the shim.</summary>
        public global::CalculatorBusinessLogic.Fakes.ShimCalculation Bind(cbl::CalculatorBusinessLogic.ICalculation target)
        {
            if (target == (cbl::CalculatorBusinessLogic.ICalculation)null)
              throw new global::System.ArgumentNullException("target");
            mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.Bind<cbl::CalculatorBusinessLogic.Calculation, 
                                                                               global::CalculatorBusinessLogic.Fakes.ShimCalculation, cbl::CalculatorBusinessLogic.ICalculation>(this, target);
            return this;
        }

        /// <summary>Sets the shim of Calculation.Calculate(Collection`1&lt;Double&gt; operandsCollection, Collection`1&lt;Char&gt; operatorsCollection)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.ObjectModel.Collection<double>, global::System.Collections.ObjectModel.Collection<char>, double> CalculateCollectionOfDoubleCollectionOfChar
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("Calculate", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions
                                                 .Uncurrify<cbl::CalculatorBusinessLogic.Calculation, global::System.Collections.ObjectModel.Collection<double>, 
                                                            global::System.Collections.ObjectModel.Collection<char>, double>(value)), 
                     typeof(cbl::CalculatorBusinessLogic.Calculation), base.Instance, "Calculate", typeof(double), new global::System.Type[]
                                                                                                                                                                                                               {typeof(global::System.Collections.ObjectModel.Collection<double>), typeof(global::System.Collections.ObjectModel.Collection<char>)});
            }
        }

        /// <summary>Sets the shim of Calculation.Calculation()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<cbl::CalculatorBusinessLogic.Calculation> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(cbl::CalculatorBusinessLogic.Calculation), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Calculation.get_Result()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<double> ResultGet
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_Result", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<cbl::CalculatorBusinessLogic.Calculation, double>(value)), 
                                                                                                    typeof(cbl::CalculatorBusinessLogic.Calculation), base.Instance, "get_Result", typeof(double), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Calculation.set_Result(Double value)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<double> ResultSetDouble
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("set_Result", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<cbl::CalculatorBusinessLogic.Calculation, double>(value)), 
                                                                                                    typeof(cbl::CalculatorBusinessLogic.Calculation), base.Instance, "set_Result", typeof(void), new global::System.Type[]{typeof(double)});
            }
        }
    }
}
namespace CalculatorBusinessLogic.Fakes
{
    /// <summary>Stub type of CalculatorBusinessLogic.Calculation</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(cbl::CalculatorBusinessLogic.Calculation))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of Calculation")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubCalculation
      : cbl::CalculatorBusinessLogic.Calculation
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<cbl::CalculatorBusinessLogic.Calculation>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubCalculation()
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubCalculation</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
namespace CalculatorBusinessLogic.Fakes
{
    /// <summary>Stub type of CalculatorBusinessLogic.ICalculation</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(cbl::CalculatorBusinessLogic.ICalculation))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of ICalculation")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubICalculation
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase<cbl::CalculatorBusinessLogic.ICalculation>
      , cbl::CalculatorBusinessLogic.ICalculation
    {
        /// <summary>Initializes a new instance of type StubICalculation</summary>
        public StubICalculation()
        {
        }

        /// <summary>Sets the stub of ICalculation.Calculate(Collection`1&lt;Double&gt; operandsCollection, Collection`1&lt;Char&gt; operatorsCollection)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.ObjectModel.Collection<double>, global::System.Collections.ObjectModel.Collection<char>, double> CalculateCollectionOfDoubleCollectionOfChar;

        /// <summary>Sets the stub of ICalculation.Calculate(Collection`1&lt;Double&gt; operandsCollection, Collection`1&lt;Char&gt; operatorsCollection)</summary>
        double cbl::CalculatorBusinessLogic.ICalculation.Calculate(global::System.Collections.ObjectModel.Collection<double> operandsCollection, global::System.Collections.ObjectModel.Collection<char> operatorsCollection)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.ObjectModel.Collection<double>, 
                                                                              global::System.Collections.ObjectModel.Collection<char>, double> ___currentMethod
                 = ((cbl::CalculatorBusinessLogic.ICalculation)this).Calculate;
              ___observer.Enter(typeof(cbl::CalculatorBusinessLogic.ICalculation), (global::System.Delegate)___currentMethod, 
                                (object)operandsCollection, (object)operatorsCollection);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.ObjectModel.Collection<double>, 
                                                                            global::System.Collections.ObjectModel.Collection<char>, double> ___sh = this.CalculateCollectionOfDoubleCollectionOfChar;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(operandsCollection, operatorsCollection);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::CalculatorBusinessLogic.Fakes.StubICalculation, double>
                         (this, "CalculatorBusinessLogic.ICalculation.Calculate");
            }
        }
    }
}
