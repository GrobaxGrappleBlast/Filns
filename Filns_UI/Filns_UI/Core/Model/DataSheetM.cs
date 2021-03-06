using Filns_Interfaces;
namespace Filns_UI.Core.Model  {

    public class DataSheetM :IDataSheet {
        public string path{ get; set; }
        public string alias{ get; set; }
        public DataSheetM() { }
        public DataSheetM(string path, string alias){
            this.path = path;
            this.alias = alias;
        }

            public override string ToString() {
        
            return "DataSheet: [ path = "+path+","+alias+"]";
        
        }
    }
    
}