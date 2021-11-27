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
