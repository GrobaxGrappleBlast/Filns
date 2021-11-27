
using System.Collections.Generic;

namespace Filns_Interfaces {

    public class Data : IData {
    private IDocument _resultDoc;
    private IDocument _document;
    private IDataSheet[ ] _datasheets;
    private List<IDocAttribute> _list = new List<IDocAttribute>();
    private string _imgSrc = "";
    public Data() {}

    public IDocument resultDoc { get { return _resultDoc; } set { _resultDoc = value; } }
    public IDocument document { get { return _document; } set { _document = value; } }
    public IDataSheet[ ] dataSheets { get { return _datasheets; } set { _datasheets = value; } }
    public List<IDocAttribute> AttributesInDocument { get { return _list; } set { _list = value; } }
    public string imageSource { get { return _imgSrc; } set { _imgSrc = value; } }

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
}