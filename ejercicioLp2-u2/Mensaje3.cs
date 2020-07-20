using ejercicioLp2_u2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioLp2_u2
{
    public partial class Mensaje3 : Form
    {
        public Mensaje3()
        {
            InitializeComponent();
        }

        private void Mensaje3_Load(object sender, EventArgs e)
        {
            ClsNegMetadata ob = new ClsNegMetadata();
            dgv.DataSource = ob.ListarMetadata();

        }
    }
}
