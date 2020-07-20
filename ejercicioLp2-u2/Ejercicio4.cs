using ejercicioLp2_u2.Entidad;
using ejercicioLp2_u2.Negocio;
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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.txt;*.docx)|*.jpg;*.png;*.gif;.txt;*.docx";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                
                txtruta.Text = opf.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtruta.Text== "No selecciono")
            {
                MessageBox.Show("no hay ruta");
                return;
            }

            string ruta = txtruta.Text;
            FileInfo infos = new FileInfo(ruta);
            ClsMetadata o = new ClsMetadata();
            ClsNegMetadata ob = new ClsNegMetadata();
            o.nombre = infos.Name;
            o.tipo = infos.Extension;          
            o.ubicacion = infos.FullName;
            o.size = infos.Length;
            o.creacion = infos.CreationTime;
            o.modificacion = infos.LastWriteTime;
            o.leido=infos.LastAccessTime;
            ob.RegistarMetadata(o);

            


           MessageBox.Show("Cargado Al Fichero");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mensaje3 f = new Mensaje3();
            f.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio5 f = new Ejercicio5();
            f.Show();
            this.Hide();
        }
    }
}
