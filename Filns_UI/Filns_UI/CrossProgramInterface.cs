using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filns_UI.Core {


    public interface IDocAttribute {
        string value{ get; set; }
        string alias{ get; set; }
        string alias_source{ get; set; }
    }

    public class Document : IDocument{

        public string filepath { get; set; }
        public IDocAttribute[] vars{ get; set; }
        public Document(){}
        public Document(string filepath){
            this.filepath = filepath;
        }
    }
    public interface IDocument {
        string filepath { get; set; }
        IDocAttribute[] vars{ get; set; }

    }

    public class DataSheetDTO :IDataSheet {
        public string path{ get; set; }
        public string alias{ get; set; }
        public DataSheetDTO() { }
        public DataSheetDTO(string path, string alias){
            this.path = path;
            this.alias = alias;
        }
    }
    public interface IDataSheet {
        string path{ get; set; }
        string alias{ get; set; }
    }

    public class Data : IData {

        public IDocument document{ get; set; }
        public IDataSheet[] dataSheets{ get; set; }
        public List<IDocAttribute> AttributesInDocument{ get; set; }
        public string imageSource{ get; set; }
        public Data() { }
        public Data(IDocument document,IDataSheet[] dataSheets){
            this.document = document;
            this.dataSheets = dataSheets;
        }

        public override string ToString() {
            string str = "DATA : [";

            if(dataSheets.Length != 0) {
                str += "Sheets : [";
                foreach(IDataSheet s in dataSheets)
                    str += "," + s.ToString();
                str += "]";
            }
            str += document.ToString();
            str += "],";
            return base.ToString();
        }
    }
    public interface IData {

        IDocument document{ get; set; }
        IDataSheet[] dataSheets{ get; set; }

        List<IDocAttribute> AttributesInDocument{ get; set; }
        string imageSource{ get; set; }
    }

    public interface CrossProgram_UIInterface {
        IDataSheet[] getSheets();
        IDocument getDocument();
        IData createData();
    }


    public interface CrossProgram_BackendInterface{

        // file name doubles with path of the file. 
        IData LoadFile(IData data);

    }

}
