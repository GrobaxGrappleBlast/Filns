using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filns_Interfaces;
using KeyValPairStrStr = System.Collections.Generic.KeyValuePair<string,string>;
using Filns_Backend;

namespace Filns_Backend
{
    public class MAIN { 
        static void Main(string[] args){

            Document doc = new Document();
            doc.filepath = @"C:\Users\hansb\source\repos\FILNS_DATA\Filns_UI\Filns_UI\exampleFiles\temp2.docx";

            Document res = new Document();
            res.filepath = @"C:\Users\hansb\source\repos\FILNS_DATA\Filns_UI\Filns_UI\exampleFiles\RESULT.docx";


            DataSheet sheet = new DataSheet();
            sheet.alias = "sheetAlias";
            sheet.path = @"C:\Users\hansb\source\repos\FILNS_DATA\Filns_Backend2\Filns_Backend\Filns_Backend\exampleFiles\Testsheet1.xlsx";
            DataSheet[] sheetArr = new DataSheet[1];
            sheetArr[ 0 ] = sheet;

            Data data = new Data();
            data.dataSheets = sheetArr;
            data.document = doc;
            data.resultDoc = res;

            Program p = new Program();

            Console.WriteLine("dfghjkkjhgfdftyukmnbvftyujmn v");
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
                List<(ISheetReader,IDataSheet)> readNsheet = new List<(ISheetReader, IDataSheet)>();
                foreach(IDataSheet sheet in data.dataSheets)
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
                foreach( (ISheetReader,IDataSheet) pair in readNsheet )
                {
                    Dictionary<string , string > currentRes = pair.Item1.readSheet(pair.Item2);
                    foreach(KeyValPairStrStr p in currentRes)
                    {
                        AVPair.Add(p.Key , p.Value);
                    }
                }

            // DOCUMENT OPERATIONS --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
    
          
                ext = data.document.filepath.Split(".").Last();     // GET EXTENSION FOR Document
                docGen = wordMGR.getHandler(ext);                   // get Handler for that document;
                docGen.Generate(data, AVPair );
                
                
      
        }
    }
}
