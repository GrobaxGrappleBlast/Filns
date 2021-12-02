using System.Collections.Generic;

namespace Filns_Interfaces {
        public interface IData{
            IDocument resultDoc { get; set; }
            IDocument document { get; set; }
            IDataSheet[] dataSheets { get; set; }

            List<IDocAttribute> AttributesInDocument { get; set; }
            string imageSource { get; set; }
        }
    }