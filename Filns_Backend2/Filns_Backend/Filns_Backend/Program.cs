using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filns_Interfaces;
using KeyValPairStrStr = System.Collections.Generic.KeyValuePair<string,string>;

namespace Filns_Backend
{
    public class MAIN { 
        static void Main(string[] args){

            Document doc = new Document();
            doc.filepath = "C:\\Users\\hansb\\source\\repos\\FILNS_DATA\\Filns_Backend2\\Filns_Backend\\Filns_Backend\\exampleFiles\\temp2.docx";

            DataSheet sheet = new DataSheet();
            sheet.alias = "sheetAlias";
            sheet.path = " C:\\Users\\hansb\\source\\repos\\FILNS_DATA\\Filns_Backend2\\Filns_Backend\\Filns_Backend\\exampleFiles\\Testsheet1.xlsx";
            DataSheet[] sheetArr = new DataSheet[1];
            sheetArr[ 0 ] = sheet;

            Data data = new Data();
            data.dataSheets = sheetArr;
            data.document = doc;

            Program p = new Program();
            p.CreateDocument(data);

        }   
    }

    public class Program
    {

        SheetReaderManager readMGR       = new SheetReaderManager();
        DocumentGeneratorManager wordMGR = new DocumentGeneratorManager();
        IDocumentGenerator docGen;

        public Program(){
            readMGR.initialize();
            wordMGR.initialize();
        }

        public void CreateDocument(IData data){

            string ext;
            // SHEETS OPERATIONS  --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---

                // SHEETS GET A READER FOR EACH SHEET IN CASE OF DIFFERENT FILE TYPE ; 
                List<(ISheetReader,DataSheet)> readNsheet = new List<(ISheetReader, DataSheet)>();
                foreach(DataSheet sheet in data.dataSheets)
                {
                    try
                    {
                        ext = sheet.path.Split(".").Last();             //GET EXTENSION FOR SHEET
                        ISheetReader reader = readMGR.getHandler(ext);  //GET HANDLER FOR THAT EXTENSION  
                        readNsheet.Add( (reader,sheet) );               // - something
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        // TODO IMPLEMENT NOTIFICATION FOR LOADING AN UNWANTED TYPE OF FILE EXTENSION
                    }
                }

                // Foreach sheet, Add the results of pair values to the dictionary. 
                Dictionary< string , string > AVPair = new Dictionary<string, string>();
                foreach( (ISheetReader,DataSheet) pair in readNsheet )
                {
                    Dictionary<string , string > currentRes = pair.Item1.readSheet(pair.Item2);
                    foreach(KeyValPairStrStr p in currentRes)
                    {
                        AVPair.Add(p.Key , p.Value);
                    }
                }
            
            // DOCUMENT OPERATIONS --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---



                try
                {
                    ext = data.document.filepath.Split(".").Last();     // GET EXTENSION FOR Document
                    docGen = wordMGR.getHandler(ext);                   // get Handler for that document;
                    docGen.Generate(data, AVPair );
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    // TODO IMPLEMENT NOTIFICATION FOR LOADING AN UNWANTED TYPE OF FILE EXTENSION
                }
      
        }
    }
}
