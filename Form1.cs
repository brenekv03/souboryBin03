using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace souboryBin03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..celaCisla.dat", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);
            int max = br.ReadInt32();
            int min = br.ReadInt32();
            int maxPosition = 0;
            while(fs.Position<fs.Length)
            {
                int cislo = br.ReadInt32();
                listBox1.Items.Add(cislo);
                if(cislo<min)
                {
                    min = cislo;
                }
                if(cislo>max)
                {
                    max = cislo;
                }
            }
        }
    }
}
