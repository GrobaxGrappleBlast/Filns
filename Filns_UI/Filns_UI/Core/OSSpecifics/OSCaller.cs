using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filns_UI.Core.OSSpecifics;
using Filns_UI.Core.OSSpecifics.Windows;

namespace Filns_UI.Core {
    public static class OSCaller{
        private static A_OS os;
        private static void init() {
            if(os == null);
                os = new Win_OS();
        }

        public static string openFile() {
            init();
            return os.openFile();
        }
    }
}
