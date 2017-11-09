// <assemblyHash>d37cd4a7</assemblyHash>
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
extern alias cp;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("CalculatorParsing", false)]
[assembly: global::System.Reflection.AssemblyCompany("Microsoft")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("CalculatorParsing")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace CalculatorParsing.Fakes
{
    /// <summary>Shim type of CalculatorParsing.Parsing</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(cp::CalculatorParsing.Parsing))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of Parsing")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimParsing
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<cp::CalculatorParsing.Parsing>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimParsing()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimParsing(cp::CalculatorParsing.Parsing instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of Parsing.ReadOperatorsOutOfInput(String userInput)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<cp::CalculatorParsing.Parsing, string, global::System.Collections.ObjectModel.Collection<char>> ReadOperatorsOutOfInputString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("ReadOperatorsOutOfInput", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(cp::CalculatorParsing.Parsing), (object)null, 
                         "ReadOperatorsOutOfInput", typeof(global::System.Collections.ObjectModel.Collection<char>), new global::System.Type[]{typeof(string)});
                }
            }

            /// <summary>Sets the shim of Parsing.SplitInputIntoOperands(String userInput)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<cp::CalculatorParsing.Parsing, string, global::System.Collections.ObjectModel.Collection<double>> SplitInputIntoOperandsString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SplitInputIntoOperands", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(cp::CalculatorParsing.Parsing), (object)null, 
                         "SplitInputIntoOperands", typeof(global::System.Collections.ObjectModel.Collection<double>), new global::System.Type[]{typeof(string)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::CalculatorParsing.Fakes.ShimParsing.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::CalculatorParsing.Fakes.ShimParsing.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(cp::CalculatorParsing.Parsing), value);
            }
        }

        /// <summary>Binds the members of the interface to the shim.</summary>
        public global::CalculatorParsing.Fakes.ShimParsing Bind(cp::CalculatorParsing.IParsing target)
        {
            if (target == (cp::CalculatorParsing.IParsing)null)
              throw new global::System.ArgumentNullException("target");
            mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime
              .Bind<cp::CalculatorParsing.Parsing, global::CalculatorParsing.Fakes.ShimParsing, cp::CalculatorParsing.IParsing>(this, target);
            return this;
        }

        /// <summary>Sets the shim of Parsing.Parsing()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<cp::CalculatorParsing.Parsing> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(cp::CalculatorParsing.Parsing), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Parsing.ReadOperatorsOutOfInput(String userInput)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<char>> ReadOperatorsOutOfInputString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("ReadOperatorsOutOfInput", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions
                                                 .Uncurrify<cp::CalculatorParsing.Parsing, string, global::System.Collections.ObjectModel.Collection<char>>(value)), 
                     typeof(cp::CalculatorParsing.Parsing), base.Instance, 
                     "ReadOperatorsOutOfInput", typeof(global::System.Collections.ObjectModel.Collection<char>), new global::System.Type[]{typeof(string)});
            }
        }

        /// <summary>Sets the shim of Parsing.SplitInputIntoOperands(String userInput)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<double>> SplitInputIntoOperandsString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SplitInputIntoOperands", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions
                                                 .Uncurrify<cp::CalculatorParsing.Parsing, string, global::System.Collections.ObjectModel.Collection<double>>(value)), 
                     typeof(cp::CalculatorParsing.Parsing), base.Instance, 
                     "SplitInputIntoOperands", typeof(global::System.Collections.ObjectModel.Collection<double>), new global::System.Type[]{typeof(string)});
            }
        }
    }
}
namespace CalculatorParsing.Fakes
{
    /// <summary>Stub type of CalculatorParsing.IParsing</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(cp::CalculatorParsing.IParsing))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of IParsing")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubIParsing
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase<cp::CalculatorParsing.IParsing>
      , cp::CalculatorParsing.IParsing
    {
        /// <summary>Initializes a new instance of type StubIParsing</summary>
        public StubIParsing()
        {
        }

        /// <summary>Sets the stub of IParsing.ReadOperatorsOutOfInput(String userInput)</summary>
        global::System.Collections.ObjectModel.Collection<char> cp::CalculatorParsing.IParsing.ReadOperatorsOutOfInput(string userInput)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<char>> 
                ___currentMethod = ((cp::CalculatorParsing.IParsing)this).ReadOperatorsOutOfInput;
              ___observer.Enter(typeof(cp::CalculatorParsing.IParsing), (global::System.Delegate)___currentMethod, (object)userInput);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<char>> ___sh
               = this.ReadOperatorsOutOfInputString;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(userInput);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::CalculatorParsing.Fakes.StubIParsing, global::System.Collections.ObjectModel.Collection<char>>
                         (this, "CalculatorParsing.IParsing.ReadOperatorsOutOfInput");
            }
        }

        /// <summary>Sets the stub of IParsing.SplitInputIntoOperands(String userInput)</summary>
        global::System.Collections.ObjectModel.Collection<double> cp::CalculatorParsing.IParsing.SplitInputIntoOperands(string userInput)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<double>> 
                ___currentMethod = ((cp::CalculatorParsing.IParsing)this).SplitInputIntoOperands;
              ___observer.Enter(typeof(cp::CalculatorParsing.IParsing), (global::System.Delegate)___currentMethod, (object)userInput);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<double>> ___sh
               = this.SplitInputIntoOperandsString;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(userInput);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::CalculatorParsing.Fakes.StubIParsing, global::System.Collections.ObjectModel.Collection<double>>
                         (this, "CalculatorParsing.IParsing.SplitInputIntoOperands");
            }
        }

        /// <summary>Sets the stub of IParsing.ReadOperatorsOutOfInput(String userInput)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<char>> ReadOperatorsOutOfInputString;

        /// <summary>Sets the stub of IParsing.SplitInputIntoOperands(String userInput)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, global::System.Collections.ObjectModel.Collection<double>> SplitInputIntoOperandsString;
    }
}
namespace CalculatorParsing.Fakes
{
    /// <summary>Stub type of CalculatorParsing.Parsing</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(cp::CalculatorParsing.Parsing))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of Parsing")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubParsing
      : cp::CalculatorParsing.Parsing
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<cp::CalculatorParsing.Parsing>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubParsing()
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

        /// <summary>Initializes a new instance of type StubParsing</summary>
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
