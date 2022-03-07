using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal3 : Form
    {
        public frmPrincipal3()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Cierra todo el Aplicativo
            Application.Exit();
            
            // Cierra la venta
            //this.Close();
        }

        private void frmPrincipal3_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "UTN App";
        }

        private void PbMostrarMenu_Click(object sender, EventArgs e)
        {
            //== es de comparacion
            //= Parallel asignacion
            //if--estructura condicional
            //ocultarme el panel de menu cuando este desplegado
            if (pnlMenu.Width==170)
            {
                //cambia el ancho a 0
                pnlMenu.Width = 0;
            }else
            {
                //si es 0 me lo pasa a 170
                pnlMenu.Width = 170;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.ShowDialog();
        }
    }
}
