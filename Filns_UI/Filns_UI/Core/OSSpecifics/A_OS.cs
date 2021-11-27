using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filns_UI.Core.OSSpecifics{
    abstract class A_OS : I_OS{
        public abstract string openFile();
    }
}
