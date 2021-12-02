using Filns_UI.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filns_Interfaces;
using Filns_Backend;
using Filns_UI.Core.Model;

namespace Filns_UI.Core {

    static class FilnsEndNode {

        public static void Create(DataSelectionViewModel viewModel) {

            IDataSheet[] sheets = viewModel.getDataSheets().ToArray();
            IDocument document = viewModel.getDocument();
            IData data = new DataM(document, sheets);

            string extension = data.document.filepath.Split(".")[1];
            string[] temppath =   data.document.filepath.Split("\\");

            string path = "";
            for( int i = 0 ; i < temppath.Length - 1 ; i++) { // i do not want the last element;
                path += "\\" +temppath[ i ];
            }
            path += "myResultingFile" + extension;
            data.resultDoc = new Document(path);

            Program backend = new Program();
            backend.CreateDocument(data);

        }

        public static void Validate(DataSelectionViewModel viewModel ) {
            
            IDataSheet[] sheets = viewModel.getDataSheets().ToArray();
            IDocument document = viewModel.getDocument();
            IData data = new DataM(document, sheets);

            Console.WriteLine(data);
            // TODO DLL VALIDATE THESE OBJECTS 
        }

    }
}
