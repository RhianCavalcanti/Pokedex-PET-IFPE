﻿#pragma checksum "C:\Users\Adan\Desktop\ProjetoFinalSiDi\Pokedex-PET-IFPE\POKEDEX-SiDi\Views\PokemonDetalhado.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7BF4BF5631A0FA26D0E519F230FAA5F4295DF9C20185521C336027332AB55CC"
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
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PokemonDetalhado_obj25_Bindings :
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
            private global::System.WeakReference obj25;
            private global::Windows.UI.Xaml.Controls.TextBlock obj26;
            private global::Windows.UI.Xaml.Controls.Image obj27;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj26TextDisabled = false;
            private static bool isobj27SourceDisabled = false;

            public PokemonDetalhado_obj25_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 114 && columnNumber == 48)
                {
                    isobj26TextDisabled = true;
                }
                else if (lineNumber == 109 && columnNumber == 44)
                {
                    isobj27SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 25: // Views\PokemonDetalhado.xaml line 105
                        this.obj25 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 26: // Views\PokemonDetalhado.xaml line 114
                        this.obj26 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 27: // Views\PokemonDetalhado.xaml line 109
                        this.obj27 = (global::Windows.UI.Xaml.Controls.Image)target;
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
                            (this.obj25.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
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
                        this.Update_Image(obj.Image, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 114
                    if (!isobj26TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj26, obj, null);
                    }
                }
            }
            private void Update_Image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 109
                    if (!isobj27SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj27, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
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
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;
            private global::Windows.UI.Xaml.Controls.ListView obj23;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj19TextDisabled = false;
            private static bool isobj23ItemsSourceDisabled = false;

            private PokemonDetalhado_obj1_BindingsTracking bindingsTracking;

            public PokemonDetalhado_obj1_Bindings()
            {
                this.bindingsTracking = new PokemonDetalhado_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 201 && columnNumber == 36)
                {
                    isobj19TextDisabled = true;
                }
                else if (lineNumber == 85 && columnNumber == 31)
                {
                    isobj23ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 19: // Views\PokemonDetalhado.xaml line 200
                        this.obj19 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 23: // Views\PokemonDetalhado.xaml line 83
                        this.obj23 = (global::Windows.UI.Xaml.Controls.ListView)target;
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

            // Update methods for each path node used in binding steps.
            private void Update_(global::POKEDEX_SiDi.Views.PokemonDetalhado obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_pokeSelected(obj.pokeSelected, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_listaParaATela(obj.listaParaATela, phase);
                    }
                }
            }
            private void Update_pokeSelected(global::POKEDEX_SiDi.Model.PokemonDb obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_pokeSelected_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_pokeSelected_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 200
                    if (!isobj19TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, obj, null);
                    }
                }
            }
            private void Update_listaParaATela(global::System.Collections.Generic.List<global::POKEDEX_SiDi.Model.PokemonDb> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\PokemonDetalhado.xaml line 83
                    if (!isobj23ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj23, obj, null);
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
            case 4: // Views\PokemonDetalhado.xaml line 179
                {
                    this.whiteBack = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 5: // Views\PokemonDetalhado.xaml line 276
                {
                    this.AtaqueBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // Views\PokemonDetalhado.xaml line 288
                {
                    this.HpBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 7: // Views\PokemonDetalhado.xaml line 300
                {
                    this.DefesaBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 8: // Views\PokemonDetalhado.xaml line 311
                {
                    this.SpAtkBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 9: // Views\PokemonDetalhado.xaml line 322
                {
                    this.SpDefBarra = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 10: // Views\PokemonDetalhado.xaml line 243
                {
                    this.Speed = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\PokemonDetalhado.xaml line 247
                {
                    this.SpeedPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\PokemonDetalhado.xaml line 231
                {
                    this.Height = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\PokemonDetalhado.xaml line 235
                {
                    this.AltPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\PokemonDetalhado.xaml line 219
                {
                    this.Weight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\PokemonDetalhado.xaml line 223
                {
                    this.PesoPokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\PokemonDetalhado.xaml line 208
                {
                    this.Type = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\PokemonDetalhado.xaml line 212
                {
                    this.typePokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\PokemonDetalhado.xaml line 197
                {
                    this.Nome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Views\PokemonDetalhado.xaml line 200
                {
                    this.namePokemon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // Views\PokemonDetalhado.xaml line 152
                {
                    this.img = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 21: // Views\PokemonDetalhado.xaml line 163
                {
                    this.basePokemon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 22: // Views\PokemonDetalhado.xaml line 69
                {
                    global::Windows.UI.Xaml.Controls.Button element22 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element22).Click += this.PreviousTenPokemon_Click;
                }
                break;
            case 23: // Views\PokemonDetalhado.xaml line 83
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
            case 25: // Views\PokemonDetalhado.xaml line 105
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element25 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    PokemonDetalhado_obj25_Bindings bindings = new PokemonDetalhado_obj25_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element25.DataContext);
                    element25.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element25, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element25, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

