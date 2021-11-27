using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filns_Interfaces;

namespace Filns_Backend {
    

    public interface ISheetReader : ISupportFileFormats{
        Dictionary<string,string> readSheets(  IData data  );
        Dictionary<string,string> readSheet(  IDataSheet sheet  );
    }
}
