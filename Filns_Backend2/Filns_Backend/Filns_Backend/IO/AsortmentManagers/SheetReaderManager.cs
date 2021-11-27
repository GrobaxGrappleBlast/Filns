using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filns_Interfaces;

namespace Filns_Backend {
    public class SheetReaderManager : AbstractAssortmentManager<ISheetReader> {
        
        public SheetReaderManager(){
        }
        public void initialize(){
            this.addHandler(new ExcelReader());
        }
        
    }
}
