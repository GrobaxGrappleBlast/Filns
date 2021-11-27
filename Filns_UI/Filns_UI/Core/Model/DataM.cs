using Filns_Interfaces;
using System.Collections.Generic;

namespace Filns_UI.Core.Model {

    public class DataM : IData {

        private IDocument _res;
        private IDocument _doc;
        private IDataSheet[ ] _sheets;
        private List<Filns_Interfaces.IDocAttribute> _attrs;
        private string _imgSrc;

       
        IDocument IData.resultDoc  { get{ return _res; } set{ _res = value; } }
        IDocument IData.document  { get{ return _doc; } set{ _doc = value; } }
        IDataSheet[ ] IData.dataSheets  { get{ return _sheets; } set{ _sheets = value; } }
        List<Filns_Interfaces.IDocAttribute> IData.AttributesInDocument  { get{ return _attrs; } set{ _attrs = value; } }
        string IData.imageSource  { get{ return _imgSrc; } set{ _imgSrc = value; } }

        public DataM() { }
        public DataM(  IDocument document ,IDataSheet[ ] sheets ){
            this._doc = document;
            this._sheets = sheets;
        }
            
        public override string ToString() {
        string str = "DATA : [";

        if(_sheets.Length != 0) {
        str += "Sheets : [";
        foreach(IDataSheet s in _sheets)
            str += "," + s.ToString();
        str += "]";
        }
        str += _doc.ToString();
        str += "],";
        return base.ToString();
        }
    }
}