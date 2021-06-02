using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Sergio;

namespace CapaVistaHRM.Sergio.Mantenimientos
{
    public partial class frmVerEmpleado : Form
    {
        ClsControladorSergio cn = new ClsControladorSergio();
        public frmVerEmpleado()
        {
            InitializeComponent();
            actualizardatagriew();
        }

        private void frmVerEmpleado_Load(object sender, EventArgs e)
        {

        }
        public void actualizardatagriew()
        {
            string tabla = "EMPLEADO";
            DataTable dt = cn.llenarTblEmpleado(tabla);
            dataGridView1.DataSource = dt;
        }
    }
}
