using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateWordDoc1
{
    class Interface
    {
        public interface IDocAttribute
        {
            string value { get; set; }
            string alias { get; set; }
            string alias_source { get; set; }
        }

        public interface IDocument
        {

            string filepath { get; set; }
            IDocAttribute[] vars { get; set; }

        }
        public interface IDataSheet
        {
            string path { get; set; }
            string alias { get; set; }
        }
        public interface IData
        {

            IDocument document { get; set; }
            IDataSheet[] dataSheets { get; set; }

            List<IDocAttribute> AttributesInDocument { get; set; }
            string imageSource { get; set; }
        }

        public interface CrossProgram_UIInterface
        {
            IDataSheet[] getSheets();
            IDocument getDocument();

            IData createData();

        }


        public interface CrossProgram_BackendInterface
        {

            // file name doubles with path of the file. 
            IData LoadFile(IData data);

        }

    }
}
