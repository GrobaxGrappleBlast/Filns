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

namespace WPF_CloseButton {
    /// <summary>
    /// Interaction logic for SheetItem.xaml
    /// </summary>
    public partial class SheetItem : UserControl {
        public SheetItem() {
            InitializeComponent();
        }

        public event EventHandler Btn1Click;
        public event EventHandler Btn2Click;

        public void setEventHandlers(EventHandler e1, EventHandler e2){
            Btn1Click = e1;
            Btn2Click = e2;
        }

        private void btn1Click(object sender, EventArgs e){
            if (this.Btn1Click != null)
                this.Btn1Click( this, EventArgs.Empty );
        }

        private void btn2Click(object sender, EventArgs e){
            if (this.Btn2Click != null)
                this.Btn2Click(this, EventArgs.Empty);
        }

        public override string ToString(){
            return "SheetITem {" + indexID + "}";
        }
    }

    // Dependencies 
    public partial class SheetItem : UserControl {
        public new Brush BorderBrush{
            get { return (Brush) GetValue(BorderBrushP); }
            set { SetValue(BorderBrushP, value); }}
        public static readonly DependencyProperty BorderBrushP = DependencyProperty.Register(nameof(BorderBrush),typeof(Brush), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        
        public new Thickness BorderThickness{
            get { return (Thickness) GetValue(BorderThicknessP); }
            set { SetValue(BorderThicknessP, value); }}
        public static readonly DependencyProperty BorderThicknessP = DependencyProperty.Register(nameof(BorderThickness),typeof(Thickness), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        
        
        public CornerRadius CornerRadius{
            get { return (CornerRadius) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }}
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(nameof(CornerRadius),typeof(CornerRadius), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        
        public Thickness InnerPadding{
            get { return (Thickness) GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }}
        public static new readonly DependencyProperty PaddingProperty = DependencyProperty.Register(nameof(InnerPadding),typeof(Thickness), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        
        public CornerRadius BtnCornerRadius{
            get { return (CornerRadius) GetValue(BtnCornerRadiusProperty); }
            set { SetValue(BtnCornerRadiusProperty, value); }}
        public static readonly DependencyProperty BtnCornerRadiusProperty = DependencyProperty.Register(nameof(BtnCornerRadius),typeof(CornerRadius), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });

        #region color
        public Brush PrimaryColor{
            get { return (Brush) GetValue(PrimaryColorProperty); }
            set { SetValue(PrimaryColorProperty, value); }}
        public static readonly DependencyProperty PrimaryColorProperty = DependencyProperty.Register(nameof(PrimaryColor),typeof(Brush), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
         
        public new Brush Background{
            get { return (Brush) GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }}
        public static new readonly DependencyProperty BackgroundProperty = DependencyProperty.Register(nameof(Background),typeof(Brush), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });

        #endregion color

        #region Btn1
        public Brush Btn1Color{
            get { return (Brush) GetValue(Btn1ColorProperty); }
            set { SetValue(Btn1ColorProperty, value); }}
        public static readonly DependencyProperty Btn1ColorProperty = DependencyProperty.Register(nameof(Btn1Color),typeof(Brush), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        public object Btn1Symbol{
            get { return (object) GetValue(Btn1SymbolProperty); }
            set { SetValue(Btn1SymbolProperty, value); }}
        public static readonly DependencyProperty Btn1SymbolProperty = DependencyProperty.Register(nameof(Btn1Symbol),typeof(object), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
          
        #endregion Btn1

        
        #region Btn2
        public Brush Btn2Color{
            get { return (Brush) GetValue(Btn2ColorProperty); }
            set { SetValue(Btn2ColorProperty, value); }}
        public static readonly DependencyProperty Btn2ColorProperty = DependencyProperty.Register(nameof(Btn2Color),typeof(Brush), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        public object Btn2Symbol{
            get { return (object) GetValue(Btn2SymbolProperty); }
            set { SetValue(Btn2SymbolProperty, value); }}
        public static readonly DependencyProperty Btn2SymbolProperty = DependencyProperty.Register(nameof(Btn2Symbol),typeof(object), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        
        #endregion Btn2
    }

    public partial class SheetItem : UserControl  {

        public string label1String{
            get { return (string) GetValue(label1StringP); }
            set { SetValue(label1StringP, value); }}
        public static readonly DependencyProperty label1StringP = DependencyProperty.Register(nameof(label1String),typeof(string), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        public string input1String {
            get { return (string) GetValue(input1StringP); }
            set { SetValue(input1StringP, value); }}
        public static readonly DependencyProperty input1StringP = DependencyProperty.Register(nameof(input1String),typeof(string), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        

        public string label2String{
            get { return (string) GetValue(label2StringP); }
            set { SetValue(label2StringP, value); }}
        public static readonly DependencyProperty label2StringP = DependencyProperty.Register(nameof(label2String),typeof(string), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        public string input2String {
            get { return (string) GetValue(input2StringP); }
            set { SetValue(input2StringP, value); }}
        public static readonly DependencyProperty input2StringP = DependencyProperty.Register(nameof(input2String),typeof(string), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
        

        public int indexID{
            get { return (int) GetValue(indexIDP); }
            set { SetValue(indexIDP, value); }}
        public static readonly DependencyProperty indexIDP = DependencyProperty.Register(nameof(indexID),typeof(int), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        public bool input1ReadOnly{
            get { return (bool) GetValue(input1ReadOnlyP); }
            set { SetValue(input1ReadOnlyP, value); }}
        public static readonly DependencyProperty input1ReadOnlyP = DependencyProperty.Register(nameof(input1ReadOnly),typeof(bool), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        public bool input2ReadOnly{
            get { return (bool) GetValue(input2ReadOnlyP); }
            set { SetValue(input2ReadOnlyP, value); }}
        public static readonly DependencyProperty input2ReadOnlyP = DependencyProperty.Register(nameof(input2ReadOnly),typeof(bool), typeof(SheetItem), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
    }
}
