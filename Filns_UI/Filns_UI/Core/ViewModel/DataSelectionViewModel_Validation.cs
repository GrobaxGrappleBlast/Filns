using Filns_UI.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Filns_UI.Core.Model;

namespace Filns_UI.Core.ViewModel {
    partial class DataSelectionViewModel : INotifyPropertyChanged{

        public void ValidateDocument(){
            FilnsEndNode.Validate(this);
        }
        public void CompleteDocument() {
            FilnsEndNode.Create(this);
        }
    }
}
