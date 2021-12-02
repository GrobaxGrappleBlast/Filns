using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;

namespace Filns_Backend
{
    class WordReader
    {
        internal List<string> ReadAlias(object filename)
        {
            // for opening the word document
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document document = null;

            // for containing the read document text
            string docText = "";

            // for extracting aliases from document text
            string matchPattern = "<(.*?)>";
            List<string> alias = new List<string>();

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                document = wordApp.Documents.Open(
                ref filename, ref missing, ref readOnly,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing);

                // Reads text from word doc
                document.ActiveWindow.Selection.WholeStory();
                document.ActiveWindow.Selection.Copy();
                IDataObject data = Clipboard.GetDataObject();
                docText = data.GetData(DataFormats.Text).ToString();
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }

            document.Close();
            wordApp.Quit();

            // Uses a regular expression to extract aliases from text and add them to the alias List
            MatchCollection matchedAlias = Regex.Matches(docText, matchPattern);
            foreach(Match match in matchedAlias)
            {
                alias.Add(match.Groups[1].Value);
            }

            return alias;
        }
    }
}
