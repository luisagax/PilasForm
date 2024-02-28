using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class frmPilas : Form
    {
        Stack ts = new Stack();
        public frmPilas()
        {
            InitializeComponent();
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ts.Push(txtNombre.Text);
            txtNombre.Focus();
            txtNombre.Clear();
        }

        private void btnMostarElementos_Click(object sender, EventArgs e)
        {
            int conteo = ts.Count;
            for (int i = 0; i < conteo; i++)
            {
                lboPeliculas.Items.Add(ts.Pop());
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if(ts.Count > 0)
                txtNombre.Text = ts.Peek().ToString();
        }
    }
}
