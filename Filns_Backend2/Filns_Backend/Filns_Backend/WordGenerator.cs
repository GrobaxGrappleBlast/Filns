using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Filns_Backend
{
    class WordGenerator
    {

        private void FindAndReplace(Word.Application wordApp, object toFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref toFindText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike, ref nmatchAllForms, ref forward,
                ref wrap, ref format, ref replaceWithText, ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza, ref matchControl);

        }

        internal void CreateWordDocument(object filename, object saveAs, string[] alias, object[,] replacementVal)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document newWordDocument = null;

            //should wrap this in a try/catch
            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                newWordDocument = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                newWordDocument.Activate();

                // Find and replace
                for(int i = 0; i < alias.Length; i++)
                {
                    this.FindAndReplace(wordApp, alias[i], replacementVal[i+1,1]);
                }

            }
            else
            {
                throw new FileNotFoundException("File not found"); // Should throw a filenotfound exception
            }

            //Save as
            newWordDocument.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            newWordDocument.Close();
            wordApp.Quit();
            Console.WriteLine("File created");
        }

    }
}
