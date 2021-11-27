using Filns_Interfaces;
namespace Filns_UI.Core.Model  {

        public class DocumentM : IDocument{

        string _filepath;
        IDocAttribute[] attrs; 

        string IDocument.filepath { get { return _filepath; } set { _filepath = value;  } }
        Filns_Interfaces.IDocAttribute[ ] IDocument.vars { get { return attrs; } set { attrs = value;  } }

        public override string ToString(){

                string str = " Document : [" +
                "filepath :" + _filepath;  

                str += "vars: {";
                foreach(IDocAttribute v in attrs){
                    str += v.ToString();
                }
                str += "}";

                str += "]";
                return str;
            }
        }

}