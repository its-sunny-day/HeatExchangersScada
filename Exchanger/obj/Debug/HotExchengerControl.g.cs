﻿#pragma checksum "..\..\HotExchengerControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB9A3625636A604B8AD9D5543C9D2981"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:2.0.50727.3053
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Exchanger;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Exchanger {
    
    
    /// <summary>
    /// HotExchengerControl
    /// </summary>
    public partial class HotExchengerControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\HotExchengerControl.xaml"
        internal Exchanger.HotExchengerControl UserControl;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\HotExchengerControl.xaml"
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\HotExchengerControl.xaml"
        internal Exchanger.HotExchanger MainExchanger;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\HotExchengerControl.xaml"
        internal Exchanger.Valve ValveHotOut;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\HotExchengerControl.xaml"
        internal Exchanger.Valve ValveHotIn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\HotExchengerControl.xaml"
        internal Exchanger.Valve ValveColdIn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\HotExchengerControl.xaml"
        internal Exchanger.Valve ValveColdOut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Exchanger;component/hotexchengercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HotExchengerControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControl = ((Exchanger.HotExchengerControl)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MainExchanger = ((Exchanger.HotExchanger)(target));
            return;
            case 4:
            this.ValveHotOut = ((Exchanger.Valve)(target));
            return;
            case 5:
            this.ValveHotIn = ((Exchanger.Valve)(target));
            return;
            case 6:
            this.ValveColdIn = ((Exchanger.Valve)(target));
            return;
            case 7:
            this.ValveColdOut = ((Exchanger.Valve)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
