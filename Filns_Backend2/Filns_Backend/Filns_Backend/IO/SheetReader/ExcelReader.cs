using Filns_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Filns_Backend {
    class ExcelReader : ISheetReader , ISupportFileFormats{

        string [] _exts = { "xlsx"};
        public string [] supportedExtensions { get{ return _exts;} } 

        public  Dictionary<string,string> readSheets( IData data ) {

            Dictionary<string,string> list = new Dictionary<string,string>();
            foreach(IDataSheet s in data.dataSheets){
                foreach( 
                     System.Collections.Generic.KeyValuePair<string,string>
                     pair in privateReadSheet(s , 1)
                ){
                    list.Add(pair.Key,pair.Value);
                }
            }
            return list;
        }

        public Dictionary<string , string> readSheet(IDataSheet sheet){
            return this.privateReadSheet(sheet.path,1);
        }
       
        internal Dictionary<string,string> privateReadSheet(object filename, int sheet){
            
            Dictionary<string,string> data = new  Dictionary<string,string>();

            // TODO REMOVE int sheet, and make sure to loop through every sheet.

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open((string)filename);
            Excel.Worksheet worksheet = excelApp.Worksheets[sheet];
            Excel.Names workBookNames = workbook.Names;
            
            foreach (Excel.Name name in workBookNames)
                if (worksheet.Range[name.Name].Value2 != null) {
                    Excel.Range val = worksheet.Range[name.Name].Value2;
                    data.Add( name.Name , val.ToString() );
                }

            workbook.Close();
            excelApp.Quit();

            return data;
        }
    }
}
