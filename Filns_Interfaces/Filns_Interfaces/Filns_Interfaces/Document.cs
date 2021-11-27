namespace Filns_Interfaces {


     

        public class Document : IDocument{

            public string filepath { get; set; }
            public IDocAttribute[] vars{ get; set; }
            public Document(){}
            public Document(string filepath){
                this.filepath = filepath;
            }

            
            public override string ToString(){

                string str = " Document : [" +
                "filepath :" + filepath;  

                str += "vars: {";
                foreach(IDocAttribute v in vars){
                    str += v.ToString();
                }
                str += "}";

                str += "]";
                return str;
            }
        }

}