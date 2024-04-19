using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Estudiantes
{
    public partial class Form1 : Form
    {

        private LEstudiantes estudiante = new LEstudiantes();

        public Form1()
        {
            InitializeComponent();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

     
        private void picBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.CargarImagen(picBoxImage);
        }
    }
}
