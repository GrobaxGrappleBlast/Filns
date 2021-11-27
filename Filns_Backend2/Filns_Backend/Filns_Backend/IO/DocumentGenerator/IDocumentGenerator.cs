using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filns_Interfaces;

namespace Filns_Backend {
    public interface IDocumentGenerator : ISupportFileFormats {
        void Generate(IData data, Dictionary<string,string> aliasValue);
    }
}
