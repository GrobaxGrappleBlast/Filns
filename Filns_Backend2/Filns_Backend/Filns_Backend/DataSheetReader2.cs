using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Filns_Backend
{
    class DataSheetReader2
    {
        //https://l.facebook.com/l.php?u=https%3A%2F%2Fstackoverflow.com%2Fquestions%2F29219683%2Fhow-to-find-all-named-ranges-in-a-workbook%3Ffbclid%3DIwAR1gjh8fkxzqXoLnh8ht9YktPpdIzhmvxYLwGOKz9XAuIrFs_B02bCPrRyk&h=AT05CpPpo5-WF5JJWDCrE8HZk-MrVtEQou2x5ITp-e6qfRmP_fMC23Sp81hpNnHjTJ6GT3UZtIUZWr_mRnXgR77oDsRRK-uM2-8L63q9pnpwxeAAP1YAGbhblWETqEG9hf59xg
        internal object[,] ReadSheet(object filename, int sheet)
        {
            object[,] finalVal = null;

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open((string)filename);
            Excel.Worksheet worksheet = excelApp.Worksheets[sheet];
            Excel.Names workBookNames = workbook.Names;
            foreach (Excel.Name n in workBookNames)
            {
                object[,] val = null;
                if (worksheet.Range[n.Name].Value2 != null)
                {
                    val = worksheet.Range[n.Name].Value2;
                    int a = 12;
                    
                }
                finalVal = val;
            }
            workbook.Close();
            excelApp.Quit();

            return finalVal;

        }
    }
}
