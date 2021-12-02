using Filns_UI.Core;
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
using System.Xaml;
using WPF_CloseButton;
using Filns_UI.Core.ViewModel;
using Filns_UI.Core.View;

namespace Filns_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{

        DataSelectionViewModel ViewModel ;
       
        public MainWindow(){
            InitializeComponent();

            this.ViewModel = (DataSelectionViewModel) this.Resources["ViewModel"];
            
            this.ViewModel.init();

            UpdateLayout();
        }


        private void SheetItem_Btn1Click(object sender , EventArgs e) {
            this.ViewModel.removeSheetItem(sender );
        }
        private void SheetItem_Btn2Click(object sender , EventArgs e) {
            this.ViewModel.getFileURL(sender);
        }

        byte o = 10;
        byte r = 0,g=0,b=0;
        private void addSheet_click(object sender , RoutedEventArgs e) {
            
            
            this.ViewModel.addSheetItem();
        
        }
    }

    public partial class MainWindow : Window {
        
        public Brush Style_Primary{
            get { return (Brush) GetValue(Style_PrimaryP); }
            set { SetValue(Style_PrimaryP, value); }}
        public static readonly DependencyProperty Style_PrimaryP = DependencyProperty.Register(nameof(Style_Primary),typeof(Brush), typeof(MainWindow), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
         public Brush Style_Secondary{
            get { return (Brush) GetValue(Style_SecondaryP); }
            set { SetValue(Style_SecondaryP, value); }}
        public static readonly DependencyProperty Style_SecondaryP = DependencyProperty.Register(nameof(Style_Secondary),typeof(Brush), typeof(MainWindow), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });
      
        private void loadWordFile(object sender , RoutedEventArgs e) {
            this.ViewModel.loadDocument(labelDocument);
        }
    }

    public partial class MainWindow : Window {
        
        private void Button_Click_Validate(object sender , RoutedEventArgs e) {
            this.ViewModel.ValidateDocument();
        }
        private void Button_Click_Complete(object sender , RoutedEventArgs e) {
            this.ViewModel.CompleteDocument();
        }


    }
}
