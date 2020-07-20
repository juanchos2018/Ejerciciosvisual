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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        int saldo_actual;
        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            dgv1.ColumnCount = 7;
            lisarcombo();
            dgv1.Columns[0].Name = "Fecha Hora";
            dgv1.Columns[1].Name = "Nombre Producto";
            dgv1.Columns[2].Name = "Tipo";
            dgv1.Columns[3].Name = "Saldo Anterior";
            dgv1.Columns[4].Name = "Entradas";
            dgv1.Columns[5].Name = "Salidas";
            dgv1.Columns[6].Name = "Saldo Actual";

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
         
            dgv1.Rows.Clear();
            ClsProductos o = new ClsProductos();
            ClsNegProductos ob = new ClsNegProductos();
            o.id_producto= int.Parse(cboproductos.SelectedValue.ToString());
            foreach (ClsKardex item in ob.ListarKardex(o))
            {
                dgv1.Rows.Add(item.fecha, item.nombre_producto,item.tipo.tipo,item.saldo_anterior,item.entradas,item.salidas,item.saldo_actual);
            }
            var ultimo = ob.ListarKardex(o)[ob.ListarKardex(o).Count - 1];

            
           
            saldo_actual = ultimo.saldo_actual;
           


        }

        private void lisarcombo()
        {
            cboproductos.DataSource = ClsNegProductos.obtenerProductos();
            cboproductos.DisplayMember = "nombre_producto";
            cboproductos.ValueMember = "id_producto";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string tipo = cbotipo.SelectedItem.ToString();

            if (tipo.Equals("Entrada"))
            {
                int entrada = int.Parse(txtcantidad.Text);
                int total=saldo_actual+entrada;

                ClsKardex o = new ClsKardex();
                ClsTIpo ti = new ClsTIpo();
                ClsNegProductos ob = new ClsNegProductos();
                o.fecha = DateTime.Now;
                o.id_producto = int.Parse(cboproductos.SelectedValue.ToString());
                o.nombre_producto = ((ClsProductos)cboproductos.SelectedItem).nombre_producto;
                ti.tipo = cbotipo.SelectedItem.ToString();
                o.tipo = ti;
                o.saldo_anterior = saldo_actual;
                o.entradas = entrada;
                o.salidas = 0;
                o.saldo_actual = total;
                ob.RegistarKardex(o);
                MessageBox.Show("Regisrado");
            }
            else if (tipo.Equals("Salida"))
            {
                int salida=int.Parse(txtcantidad.Text);
                int total = saldo_actual - salida;
                ClsKardex o = new ClsKardex();
                ClsTIpo ti = new ClsTIpo();
                ClsNegProductos ob = new ClsNegProductos();
                o.fecha = DateTime.Now;
                o.id_producto = int.Parse(cboproductos.SelectedValue.ToString());
                o.nombre_producto = ((ClsProductos)cboproductos.SelectedItem).nombre_producto;
                ti.tipo = cbotipo.SelectedItem.ToString();
                o.tipo = ti;
                o.saldo_anterior = saldo_actual;
                o.entradas = 0;
                o.salidas = salida;
                o.saldo_actual = total;
                ob.RegistarKardex(o);
                MessageBox.Show("Regisrado");

            }

         


        }

        private void button3_Click(object sender, EventArgs e)
        {


            ClsNegProductos o = new ClsNegProductos();
            foreach (ClsProductos item in o.lista2())
            {
               // Console.WriteLine(item.id_producto.ToString(), item.nombre_producto);
                dgv1.Rows.Add(item.id_producto.ToString(), item.nombre_producto);
                //dgv1.Rows.Add(item.id_producto.ToString());
            }

            //var query = o.ParseCountryList().ToList();
            //   dgv2.DataSource = query;
            // MessageBox.Show("imprime");

            //Ejercicio3 f = new Ejercicio3();
            //f.Show();
            //this.Hide();



        }

        private void cboproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string name = ((DataRowView)cboproductos.Items[e.in])["name"];
        }

        private void cboproductos_DrawItem(object sender, DrawItemEventArgs e)
        {
            //string name = ((ComboBox)cboproductos.Items[e.Index])["name"];
            string name = (string)cboproductos.Items[e.Index];
            MessageBox.Show(name);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
