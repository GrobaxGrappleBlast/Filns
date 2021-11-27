using Filns_Interfaces;
namespace  Filns_UI.Core.Model {

    public class DocAttributeM: IDocAttribute{
        public string value { get; set; }
        public string alias { get; set; }
        public string alias_source { get; set; }
        
        public DocAttributeM(){}

        public override string ToString()
        {
            string str = "DocAttribute:[";
            str += "value : " + value;
            str += "alias : " + alias;
            str += "alias_source : " + alias_source;
            str += "]";
            return str;
        }
    }


}