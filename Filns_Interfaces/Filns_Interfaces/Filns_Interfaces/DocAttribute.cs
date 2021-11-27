namespace Filns_Interfaces {

    public interface IDocAttribute
    {
        string value { get; set; }
        string alias { get; set; }
        string alias_source { get; set; }
    }

    public class DocAttribute: IDocAttribute{
        public string value { get; set; }
        public string alias { get; set; }
        public string alias_source { get; set; }
        
        public DocAttribute(){}

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