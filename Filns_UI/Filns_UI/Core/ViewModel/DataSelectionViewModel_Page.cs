using Filns_UI.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Filns_UI.Core.ViewModel {
    partial class DataSelectionViewModel : INotifyPropertyChanged{
        
        public ObservableCollection<DataVariableM> PageVariables_Collection = new ObservableCollection<DataVariableM>();
        public ObservableCollection<DataVariableM> PageVariables { get{ return PageVariables_Collection;  }  set { PageVariables_Collection = value; } }

        public string documentPath;
        
        //              UI CALLS 
        // ################################# // 
        public void loadDocument(TextBox resBox){
            string str = OSCaller.openFile();
            documentPath = str;
            resBox.Text = str;
        }

        //              END CALLS
        // ################################# //
        public IDocument getDocument(){
            
            if(     string.IsNullOrEmpty( documentPath )    )
                throw new Exception("document path was not set before requesting Creation");

            return new Document(documentPath);
        }





    }
}
