﻿#pragma checksum "C:\Users\Nilo Sandes\source\repos\RhianCavalcanti\Pokedex-PET-IFPE\POKEDEX-SiDi\Views\PokemonDetalhado.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2FE5953A5CCEBB0F1934843FDD6E37FA2229BBFD346D4507C423B78E9EC05ABD"
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
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PokemonDetalhado_obj26_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPokemonDetalhado_Bindings
        {
            private global::POKEDEX_SiDi.Model.PokemonDb dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj26;
            private global::Windows.UI.Xaml.Controls.TextBlock obj27;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj27TextDisabled = false;

            public PokemonDetalhado_obj26_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 114 && columnNumber == 48)
                {
                    isobj27TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 26: // Views\PokemonDetalhado.xaml line 105
                        this.obj26 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 27: // Views\PokemonDetalhado.xaml line 114
                        this.obj27 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj26.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::POKEDEX_SiDi.Model.PokemonDb) item, 1 << phase);
            }

            public void Recycle()
            {
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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::POKEDEX_SiDi.Model.PokemonDb)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::POKEDEX_SiDi.Model.PokemonDb obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 114
                    if (!isobj27TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj27, obj, null);
                    }
                }
            }
        }

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
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Controls.ListView obj24;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj18TextDisabled = false;
            private static bool isobj24ItemsSourceDisabled = false;

            public PokemonDetalhado_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 219 && columnNumber == 36)
                {
                    isobj18TextDisabled = true;
                }
                else if (lineNumber == 85 && columnNumber == 27)
                {
                    isobj24ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 18: // Views\PokemonDetalhado.xaml line 218
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 24: // Views\PokemonDetalhado.xaml line 83
                        this.obj24 = (global::Windows.UI.Xaml.Controls.ListView)target;
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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
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

            // Update methods for each path node used in binding steps.
            private void Update_(global::POKEDEX_SiDi.Views.PokemonDetalhado obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                        this.Update_listaParaTela(obj.listaParaTela, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 218
                    if (!isobj18TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                    }
                }
            }
            private void Update_listaParaTela(global::System.Collections.Generic.List<global::POKEDEX_SiDi.Model.PokemonDb> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 83
                    if (!isobj24ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj24, obj, null);
                    }
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
            case 2: // Views\PokemonDetalhado.xaml line 47
                {
                    this.Pokelist = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\PokemonDetalhado.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.NextTenPokemon_Click;
                }
                break;
            case 4: // Views\PokemonDetalhado.xaml line 197
                {
                    this.whiteBack = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 5: // Views\PokemonDetalhado.xaml line 309
                {
                    this.Edit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Edit).Click += this.Edit_Click;
                }
                break;
            case 6: // Views\PokemonDetalhado.xaml line 310
                {
                    this.Delete = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Views\PokemonDetalhado.xaml line 312
                {
                    this.DeleteConfirm = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 8: // Views\PokemonDetalhado.xaml line 316
                {
                    this.Delete_Y = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Delete_Y).Click += this.Delete_Click;
                }
                break;
            case 9: // Views\PokemonDetalhado.xaml line 317
                {
                    this.Delete_N = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Delete_N).Click += this.Delete_N_Click;
                }
                break;
            case 10: // Views\PokemonDetalhado.xaml line 272
                {
                    this.AtaqueBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 11: // Views\PokemonDetalhado.xaml line 283
                {
                    this.HpBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 12: // Views\PokemonDetalhado.xaml line 296
                {
                    this.DefesaBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 13: // Views\PokemonDetalhado.xaml line 237
                {
                    this.Especie = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\PokemonDetalhado.xaml line 241
                {
                    this.EspeciePokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\PokemonDetalhado.xaml line 226
                {
                    this.Ataque = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\PokemonDetalhado.xaml line 230
                {
                    this.atkPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\PokemonDetalhado.xaml line 215
                {
                    this.Nome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\PokemonDetalhado.xaml line 218
                {
                    this.namePokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Views\PokemonDetalhado.xaml line 152
                {
                    this.img = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 20: // Views\PokemonDetalhado.xaml line 162
                {
                    this.basePokemon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 21: // Views\PokemonDetalhado.xaml line 176
                {
                    this.PreviousPokemonImg = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.PreviousPokemonImg).Click += this.PreviousPokemonImg_Click;
                }
                break;
            case 22: // Views\PokemonDetalhado.xaml line 185
                {
                    this.NextPokemonImg = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NextPokemonImg).Click += this.NextPokemonImg_Click;
                }
                break;
            case 23: // Views\PokemonDetalhado.xaml line 69
                {
                    global::Windows.UI.Xaml.Controls.Button element23 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element23).Click += this.PreviousTenPokemon_Click;
                }
                break;
            case 24: // Views\PokemonDetalhado.xaml line 83
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
            case 26: // Views\PokemonDetalhado.xaml line 105
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element26 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    PokemonDetalhado_obj26_Bindings bindings = new PokemonDetalhado_obj26_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element26.DataContext);
                    element26.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element26, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element26, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

