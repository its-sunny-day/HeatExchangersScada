﻿#pragma checksum "..\..\ControlPipe.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D43B5ECBC634C694BC62E616A73CD9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:2.0.50727.3053
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Pipe;
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
    /// ControlPipe
    /// </summary>
    public partial class ControlPipe : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ControlPipe.xaml"
        internal Exchanger.ControlPipe UserControl;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ControlPipe.xaml"
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ControlPipe.xaml"
        internal System.Windows.VisualStateGroup VisualMainStateGroup;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ControlPipe.xaml"
        internal System.Windows.VisualState VisualMainStateOpenCasing;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ControlPipe.xaml"
        internal System.Windows.VisualState VisualMainStateCloseCasing;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ControlPipe.xaml"
        internal System.Windows.VisualState VisualMainStateFastOpenCasing;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ControlPipe.xaml"
        internal System.Windows.VisualState VisualMainStateFastCloseCasing;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\ControlPipe.xaml"
        internal Pipe.WaterWave PipeWave;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\ControlPipe.xaml"
        internal System.Windows.Shapes.Rectangle rectangle;
        
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
            System.Uri resourceLocater = new System.Uri("/Exchanger;component/controlpipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ControlPipe.xaml"
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
            this.UserControl = ((Exchanger.ControlPipe)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.VisualMainStateGroup = ((System.Windows.VisualStateGroup)(target));
            return;
            case 4:
            this.VisualMainStateOpenCasing = ((System.Windows.VisualState)(target));
            return;
            case 5:
            this.VisualMainStateCloseCasing = ((System.Windows.VisualState)(target));
            return;
            case 6:
            this.VisualMainStateFastOpenCasing = ((System.Windows.VisualState)(target));
            return;
            case 7:
            this.VisualMainStateFastCloseCasing = ((System.Windows.VisualState)(target));
            return;
            case 8:
            this.PipeWave = ((Pipe.WaterWave)(target));
            return;
            case 9:
            this.rectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
