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
     /*   /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        */



        WordReader WordReader = new WordReader();
        WordGenerator WordGenerator = new WordGenerator();
        DataSheetReader DataSheetReader = new DataSheetReader();
        DataSheetReader2 DataSheetReader2 = new DataSheetReader2();
        List<string> aliasList = new List<string>();
        //string[] alias = {"<name>", "<firstname>", "<birthday>", "<date>" };


        object[] vals = { "Jensen", "Filip", "21-09-98", DateTime.Now };
        int[] rangeVals = {1, 1, 4, 1};



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
