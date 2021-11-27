using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filns_UI.Core.OSSpecifics.Windows{
    class Win_OS : A_OS{
        public override string openFile(){
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true){
                return openFileDlg.FileName;
            }else { return null;  }
        }

    }
}
