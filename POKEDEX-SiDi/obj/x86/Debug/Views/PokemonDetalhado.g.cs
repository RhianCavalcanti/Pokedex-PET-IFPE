﻿#pragma checksum "C:\Users\Nilo Sandes\source\repos\RhianCavalcanti\Pokedex-PET-IFPE\POKEDEX-SiDi\Views\PokemonDetalhado.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "235852C6364E1531EB0C5FEC23EDA03B9597E4A1796863752518D70C36A13E27"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POKEDEX_SiDi.Views
{
    partial class PokemonDetalhado : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PokemonDetalhado_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPokemonDetalhado_Bindings
        {
            private global::POKEDEX_SiDi.Views.PokemonDetalhado dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj13TextDisabled = false;

            private PokemonDetalhado_obj1_BindingsTracking bindingsTracking;

            public PokemonDetalhado_obj1_Bindings()
            {
                this.bindingsTracking = new PokemonDetalhado_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 216 && columnNumber == 36)
                {
                    isobj13TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 13: // Views\PokemonDetalhado.xaml line 215
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IPokemonDetalhado_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::POKEDEX_SiDi.Views.PokemonDetalhado)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_M_setNome_757602046(int phase)
            {
                global::System.String result = this.dataRoot.setNome();
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 215
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, result, null);
                    }
                }
            }

            private void CompleteUpdate(int phase)
            {
                var functions = this.PendingFunctionBindings;
                this.PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();
                foreach (var function in functions.Values)
                {
                    function.Invoke(phase);
                }
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::POKEDEX_SiDi.Views.PokemonDetalhado obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_M_setNome_757602046(phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_M_setNome_757602046(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    if (!isobj13TextDisabled)
                    {
                        this.PendingFunctionBindings["M_setNome_757602046"] = new InvokeFunctionDelegate(this.Invoke_M_setNome_757602046); 
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class PokemonDetalhado_obj1_BindingsTracking
            {
                private global::System.WeakReference<PokemonDetalhado_obj1_Bindings> weakRefToBindingObj; 

                public PokemonDetalhado_obj1_BindingsTracking(PokemonDetalhado_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<PokemonDetalhado_obj1_Bindings>(obj);
                }

                public PokemonDetalhado_obj1_Bindings TryGetBindingObject()
                {
                    PokemonDetalhado_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\PokemonDetalhado.xaml line 42
                {
                    this.Pokelist = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\PokemonDetalhado.xaml line 53
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.NextTenPokemon_Click;
                }
                break;
            case 4: // Views\PokemonDetalhado.xaml line 192
                {
                    this.whiteBack = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 5: // Views\PokemonDetalhado.xaml line 246
                {
                    this.AtaqueBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // Views\PokemonDetalhado.xaml line 257
                {
                    this.HpBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 7: // Views\PokemonDetalhado.xaml line 270
                {
                    this.DefesaBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 8: // Views\PokemonDetalhado.xaml line 228
                {
                    this.Especie = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\PokemonDetalhado.xaml line 229
                {
                    this.EspeciePokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\PokemonDetalhado.xaml line 224
                {
                    this.Ataque = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\PokemonDetalhado.xaml line 225
                {
                    this.atkPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\PokemonDetalhado.xaml line 210
                {
                    this.Name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\PokemonDetalhado.xaml line 215
                {
                    this.namePokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\PokemonDetalhado.xaml line 147
                {
                    this.img = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 15: // Views\PokemonDetalhado.xaml line 157
                {
                    this.basePokemon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // Views\PokemonDetalhado.xaml line 171
                {
                    this.PreviousPokemonImg = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PreviousPokemonImg).Click += this.PreviousPokemonImg_Click;
                }
                break;
            case 17: // Views\PokemonDetalhado.xaml line 180
                {
                    this.NextPokemonImg = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NextPokemonImg).Click += this.NextPokemonImg_Click;
                }
                break;
            case 18: // Views\PokemonDetalhado.xaml line 64
                {
                    global::Windows.UI.Xaml.Controls.Button element18 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element18).Click += this.PreviousTenPokemon_Click;
                }
                break;
            case 19: // Views\PokemonDetalhado.xaml line 78
                {
                    this.ListaPokemonsD = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListaPokemonsD).ItemClick += this.ListaPokemonsD_ItemClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\PokemonDetalhado.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    PokemonDetalhado_obj1_Bindings bindings = new PokemonDetalhado_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

