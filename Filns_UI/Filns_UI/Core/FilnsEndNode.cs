using Filns_UI.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filns_UI.Core {
    static class FilnsEndNode {

        public static void Create(DataSelectionViewModel viewModel) {

            IDataSheet[] sheets = viewModel.getDataSheets().ToArray();
            IDocument document = viewModel.getDocument();
            IData data = new Data(document, sheets);

            Trace.WriteLine("text");
            Console.WriteLine(data);
            Trace.WriteLine("text");
            // TODO DLL CREATE THINGS 

        }

        public static void Validate(DataSelectionViewModel viewModel ) {
            
            IDataSheet[] sheets = viewModel.getDataSheets().ToArray();
            IDocument document = viewModel.getDocument();
            IData data = new Data(document, sheets);

            Console.WriteLine(data);
            // TODO DLL VALIDATE THESE OBJECTS 
        }

    }
}
