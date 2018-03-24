using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Archivos_d_texto_y_Textos_Binarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream DOCUMENTO = new FileStream(openFileDialog1.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(DOCUMENTO);
            char c1 = br.ReadChar();
            char c2 = br.ReadChar();

            if (c1 == 'B' && c2 == 'M')
            {
                int tam = br.ReadInt32();
                br.ReadInt64();
                br.ReadInt32();

                int ancho = br.ReadInt32();
                int alto = br.ReadInt32();

                br.ReadInt16();
                Int16 bitspixel;
                bitspixel = br.ReadInt16();

            }
            br.Close();
        }
    }
}
