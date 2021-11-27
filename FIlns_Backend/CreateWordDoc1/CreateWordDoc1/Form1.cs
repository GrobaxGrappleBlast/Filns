using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

//https://www.youtube.com/watch?v=0me-ntfD8Rk

namespace CreateWordDoc1
{
    public partial class Form1 : Form
    {
        WordReader WordReader = new WordReader();
        WordGenerator WordGenerator = new WordGenerator();
        DataSheetReader DataSheetReader = new DataSheetReader();
        DataSheetReader2 DataSheetReader2 = new DataSheetReader2();
        List<string> aliasList = new List<string>();
        //string[] alias = {"<name>", "<firstname>", "<birthday>", "<date>" };
        string[] alias2;
        object[] vals = { "Jensen", "Filip", "21-09-98", DateTime.Now };
        int[] rangeVals = {1, 1, 4, 1};

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aliasList = WordReader.ReadAlias(
                @"C:\Users\45615\source\repos\CreateWordDoc1\CreateWordDoc1\exampleFiles\temp2.docx");
            alias2 = aliasList.ToArray();
            WordGenerator.CreateWordDocument(
                @"C:\Users\45615\source\repos\CreateWordDoc1\CreateWordDoc1\exampleFiles\temp2.docx",
                @"C:\Users\45615\Desktop\diplom.docx",
                alias2,
                DataSheetReader2.ReadSheet(
                    @"C:\Users\45615\source\repos\CreateWordDoc1\CreateWordDoc1\exampleFiles\testsheet1.xlsx",
                    1)
                );
        }
    }
}
