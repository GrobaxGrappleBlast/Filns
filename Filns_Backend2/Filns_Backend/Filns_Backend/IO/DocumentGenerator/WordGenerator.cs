using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using Filns_Interfaces;
using System.Runtime.InteropServices;

namespace Filns_Backend { 
    public class WordGenerator : IDocumentGenerator {

        public string[ ] supportedExtensions = {"docx"};
        string[ ] ISupportFileFormats.supportedExtensions => supportedExtensions;
        public void Generate( IData data , Dictionary<string , string> aliasValue){
            WordOperator opr = new WordOperator(data.document.filepath);
            opr.CreateWordDocument( data.resultDoc.filepath , aliasValue );
            opr.close();
        }
      
    }


    public class WordOperator {

        Word.Application wordApp;
        Word.Documents documents;
        Word.Document document;   

        object missing = Missing.Value; 
        string matchPattern = @"\[(.*?)\]"; 
        List<string> alias = new List<string>();  

        object readOnly = false;
        object isVisible = false;
        
        public WordOperator(object path){

            if(File.Exists((string)path)) {
                
                // for opening the word document
                wordApp = new Word.Application();
                wordApp.Visible = (bool) isVisible;
                documents = wordApp.Documents;
                document = documents.Open(ref path, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                // Reads text from word doc
                //document.ActiveWindow.Selection.WholeStory();
                //document.ActiveWindow.Selection.Copy();
                MatchCollection matchedAlias = Regex.Matches(document.WordOpenXML, matchPattern);
                foreach(Match match in matchedAlias)
                {
                    alias.Add(match.Groups[1].Value);
                }

            }
            else
            {
                throw new FileNotFoundException("File :" + path + "not found");
            }
        }

        public void close() {
            document.Close();
            wordApp.Quit();

            Marshal.ReleaseComObject(document);
            Marshal.ReleaseComObject(documents);
            Marshal.ReleaseComObject(wordApp);

        }
        public void open() {
            //document.Open(); ???
            document.Activate();
        }

        internal void CreateWordDocument( string saveAs, Dictionary<string, string > avpair )
        {
            // object[,] replacementVal
            for(int i = 0; i < alias.Count; i++){
                
                if( avpair.ContainsKey(alias[i]) ) { 
                    //var thisA = alias[i];
                    //var thisAV = avpair[alias[i]];
                    var ali = "["+alias[i]+"]";
                    this.FindAndReplace( ali , avpair[alias[i]]  );    
                }
            }


            object SAVE = (object) saveAs;
            document.SaveAs2(ref SAVE, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            Console.WriteLine("File created");
        }
    
          private void FindAndReplace(object toFindText, object replaceWithText)
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

    }
}






