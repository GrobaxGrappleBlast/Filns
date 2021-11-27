using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Filns_UI.Core.View;
using Filns_UI.Core;

namespace Filns_UI.Core.View
{
    /// <summary>
    /// Interaction logic for DataSheetsContainer.xaml
    /// </summary>

    public partial class DataSheetsContainer : UserControl {

        // LAYOUT VARIABLES 
        
        public DataSheetsContainer(){}


        public void addChild(DataSheet sheet){
            stackPanel.Children.Add(sheet);
        }

        public void removeChild(DataSheet sheet) {
             stackPanel.Children.Remove( sheet );
        }

        private partial void onChange(){}

    }
    public partial class DataSheetsContainer : UserControl{
        
        public CornerRadius CornerRadius{
            get { return (CornerRadius) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value);  onChange();}}
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius),typeof(CornerRadius), typeof(DataSheetsContainer), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        
        public new Thickness BorderThickness{
            get { return (Thickness) GetValue(BorderThicknessP); }
            set { SetValue(BorderThicknessP, value);  onChange();}}
        public static readonly DependencyProperty BorderThicknessP = DependencyProperty.Register(nameof(BorderThickness),typeof(Thickness), typeof(DataSheetsContainer), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });

        public new Brush Background{
            get { return (Brush) GetValue(BackgroundP); }
            set { SetValue(BackgroundP, value);  onChange();}}
        public static readonly DependencyProperty BackgroundP = DependencyProperty.Register(nameof(Background),typeof(Brush), typeof(DataSheetsContainer), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });

        public new Brush BorderBrush{
            get { return (Brush) GetValue(BorderBrushP); }
            set { SetValue(BorderBrushP, value); onChange(); }}
        public static readonly DependencyProperty BorderBrushP = DependencyProperty.Register(nameof(BorderBrush),typeof(Brush), typeof(DataSheetsContainer), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });

        private partial void onChange();
    }
}
