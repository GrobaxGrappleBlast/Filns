using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WPF_CloseButton;

namespace Filns_UI.Core.Model {
    partial class DataSheetM : SheetItem , IDataSheet , INotifyPropertyChanged {
        
        private string _path;
        public string path { 
            get { return _path;  }
            set { _path = value; onChange("path"); }
        }
        
        private string _alias;
        public string alias {
            get { return _alias;  }
            set { _alias = value; onChange("alias"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void onChange(string p) {
            // source https://www.youtube.com/watch?v=0IKOphciSZo
            PropertyChangedEventHandler ch = PropertyChanged;
            if(ch != null) {
                ch(this , new PropertyChangedEventArgs(p) );
            } else {
               
            }
        }
    }

}
