namespace Filns_Interfaces {

    public class DataSheet :IDataSheet {
        public string path{ get; set; }
        public string alias{ get; set; }
        public DataSheet() { }
        public DataSheet(string path, string alias){
            this.path = path;
            this.alias = alias;
        }

            public override string ToString() {
        
            return "DataSheet: [ path = "+path+","+alias+"]";
        
        }
    }
    
}