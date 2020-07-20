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

namespace ejercicioLp2_u2
{
    public partial class Mensaje2 : Form
    {
        public Mensaje2()
        {
            InitializeComponent();
        }
        string rutalocal;
        public void setRuta(string ruta)
        {
            lstcontenido.Items.Add(ruta);


        }

        private void Mensaje2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

      

        public static string getExtension(string filename)
        {
            int index = filename.LastIndexOf('.');

            if (index == -1)
            {
                return "";
            }
            else
            {
                return filename.Substring(index + 1);
            }
        }
    }
}
