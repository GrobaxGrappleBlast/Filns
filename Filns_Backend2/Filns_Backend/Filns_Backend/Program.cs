using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filns_Interfaces;

namespace Filns_Backend
{
    public class Program
    {

        WordReader WordReader = new WordReader();
        WordGenerator WordGenerator = new WordGenerator();
        DataSheetReader DataSheetReader = new DataSheetReader();
        DataSheetReader2 DataSheetReader2 = new DataSheetReader2();
        List<string> aliasList = new List<string>();

        public Program(){
            
        }

        public IData CreateDocument(IData data){


            
            aliasList = WordReader.ReadAlias(data.document.filepath);
            string[] alias2 = aliasList.ToArray();


            WordGenerator.CreateWordDocument(
                data.document.filepath,
                data.resultDoc.filepath,
                alias2,
                DataSheetReader2.ReadSheet(
                    data.dataSheets[0].path,
                    1)
                );

            return data;

        }

        

    }
}
