using ejercicioLp2_u2.Entidad;
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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ClsDriver> lista = new List<ClsDriver>();

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            const int CONVERSION_VALUE = 1024;

            int totaldisco_c;
            int totaldisco_d;

           
            foreach (DriveInfo d in allDrives)
            {
                double bytes1 = 0;
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                   // ClsDriver o = new ClsDriver();
                    Console.WriteLine("  Etiqueta de volumen: {0}", d.VolumeLabel);
                    Console.WriteLine("  Sistema de archivos: {0}", d.DriveFormat);
                    Console.WriteLine( "  Espacio disponible:{0, 15} bytes", d.AvailableFreeSpace);
                    Console.WriteLine( "  Espacio total disponible:  {0, 15} bytes",  d.TotalFreeSpace);
                    Console.WriteLine( "  Tamaño total de la unidad: {0, 15} bytes ", d.TotalSize);

                    bytes1 = d.TotalFreeSpace;
                    lista.Add(new ClsDriver()
                    {
                        
                        Disco=d.Name,
                        sistema = d.DriveFormat,
                        espacio_libre =  Math.Round( bytes1 / CalculateCube(CONVERSION_VALUE)),                      
                        capacidad = Math.Round( d.TotalSize/CalculateCube(CONVERSION_VALUE)),

                    });
                }

            }

            lbl1.Text = lista[0].espacio_libre.ToString()+" GB Disponibles";
            lbl2.Text = lista[0].capacidad.ToString()+" GB";
            pro1.Maximum = int.Parse(lista[0].capacidad.ToString());
            totaldisco_c = int.Parse(lista[0].capacidad.ToString()) - int.Parse(lista[0].espacio_libre.ToString());

            pro1.Value = totaldisco_c;



            lbl3.Text = lista[1].espacio_libre.ToString() + " GB Disponibles";
            lbl4.Text = lista[1].capacidad.ToString() + " GB";

            pro2.Maximum = int.Parse(lista[1].espacio_libre.ToString());
            totaldisco_d= int.Parse(lista[1].capacidad.ToString()) - int.Parse(lista[1].espacio_libre.ToString());
            pro2.Value = totaldisco_d;
        }
        public static double CalculateCube(Int32 number)
        {
            return Math.Pow(number, 3);
        }

        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio7 f = new Ejercicio7();
            f.Show();
            this.Hide();
        }
    }
}
