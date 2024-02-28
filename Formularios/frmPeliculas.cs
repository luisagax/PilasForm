using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas.Formularios
{
    public partial class frmPeliculas : Form
    {
        Stack<Clases.Peliculas> Movies = new Stack<Clases.Peliculas>();
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Movies.Push(new Clases.Peliculas { nombre = txtPelicula.Text, director = txtDirector.Text, genero = txtGenero.Text });
            txtPelicula.Clear();
            txtDirector.Clear();
            txtGenero.Clear();
            txtPelicula.Focus();
        }

        private void btnMostarElementos_Click(object sender, EventArgs e)
        {
            foreach(Clases.Peliculas x in Movies)
            {
                lboPeliculas.Items.Add($"Pelicula: {x.nombre} Director: {x.director} Genero: {x.genero}");
            }
        }
    }
}
