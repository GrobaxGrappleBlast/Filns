using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_CloseButton;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Filns_UI.Core.View {
    public class DataSheet : SheetItem , IDataSheet{


        private string _input1 =  null;
        private string _input2 =  null;

        public string input1 {
            get { return _input1;  }
            set { _input1 = value; } 
        }
        public string input2 {
            get { return _input2;  }
            set { _input2 = value; }
        }

        public DataSheet() {
            //this.InnerPadding = new Thickness(10);

            this.label1String ="file";
            this.label2String ="alias";

            this.input1String = "_ _ _ _ _ _ _ _ _ _ _ _";
            this.input2String = "_ _ _ _ _ _ _ _ _ _ _ _";
        }

        public string path {
            get { return input1; }
            set { input1 = value; }
        }
        public string alias {
            get { return input2; }
            set { input2 = value; }
        }
    }

    partial class dataSheet : SheetItem {
        
        // register a Click Event 
        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent(
            "click", RoutingStrategy.Bubble , typeof(RoutedEventHandler), typeof(dataSheet)
            );

        // Add functionality for the eventHandler to be Added;
        public event RoutedEventHandler click{
            add{AddHandler(ClickEvent, value); }
            remove{RemoveHandler(ClickEvent,value); }
        }

        public void RaiseClickEvent() {
            RoutedEventArgs newargs = new RoutedEventArgs(dataSheet.ClickEvent);
            RaiseEvent(newargs);
        }
        
        public void OnClick() {
            RaiseClickEvent();
            
        }
        
    }

}

