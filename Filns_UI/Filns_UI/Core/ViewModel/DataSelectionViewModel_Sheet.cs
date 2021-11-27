using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Filns_UI.Core.View;
using WPF_CloseButton;


namespace Filns_UI.Core.ViewModel {

    
    partial class DataSelectionViewModel : INotifyPropertyChanged {

        public DataSelectionViewModel() {}

        // SHEETS Adding 
        public partial void init();

        // MAINTAINANCE     
        public partial void onChange(string p);
    }

    // For Operating Sheets 
    partial class DataSelectionViewModel : INotifyPropertyChanged {

        public ObservableCollection<SheetItem> sheetsCollection = new ObservableCollection<SheetItem>();
        public ObservableCollection<SheetItem> sheets { get{ return sheetsCollection;  }  set { sheetsCollection = value; } }
        
        public static int _sheetCounter;

        public partial void init() {
            /*_sheetCounter = 0;
            foreach(SheetItem i in sheetsCollection ){
                i.indexID = _sheetCounter++;
            }*/
            onChange("sheetsCollection");
        }


        //           UI CALLS 
        // ################################ //

        public void removeSheetItem( object sheet ){
            SheetItem item = sheetsCollection.First(c => c.indexID == ((SheetItem) sheet).indexID);
            bool a = sheetsCollection.Remove(item);
            onChange("sheetsCollection");
        }

        public void addSheetItem(){
            SheetItem sheet =  new SheetItem();
            sheet.indexID = _sheetCounter++;
            sheetsCollection.Add( sheet );
            onChange("sheetsCollection");
        }

        public void getFileURL(object sheet) {
            string str = OSCaller.openFile();
            sheetsCollection.First(c => c.indexID == ((SheetItem)sheet).indexID).input1String = str;
        }


        //            END CALLS 
        // ################################ //

        public  List<IDataSheet> getDataSheets(){
            List<IDataSheet> LIST = new List<IDataSheet>();
            foreach(SheetItem i in sheetsCollection){
                LIST.Add(   convertSheetItem(i)    );
            }
            return LIST;
            
            DataSheetDTO convertSheetItem(SheetItem item){
                return new DataSheetDTO(item.input1String , item.input2String);
            }
        } 

    }

    partial class DataSelectionViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public partial void onChange(string p) {
            // source https://www.youtube.com/watch?v=0IKOphciSZo
            PropertyChangedEventHandler ch = PropertyChanged;
            if(ch != null) {
                ch(this , new PropertyChangedEventArgs(p) );
            } else {
               
            }
        }
    }


            

}
