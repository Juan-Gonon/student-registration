﻿using System;
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
            estudiante.uploadingimage.CargarImagen(picBoxImage);
        }

        private void txtBoxNid_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxNid.Text != String.Empty)
            {
                lblNid.ForeColor = Color.Green;
                lblNid.Text = "Nid";
            }
            else
            {
                lblNid.ForeColor = Color.LightSlateGray;
            }
        }

        private void txtBoxNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numKeyPress(e);
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxNombre.Text != String.Empty)
            {
                lblNombre.ForeColor = Color.Green;
                
            }
            else
            {
                lblNombre.ForeColor= Color.LightSlateGray;
              
            }
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e);
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void txtBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxApellido.Text != String.Empty)
            {
                lblApellido.ForeColor = Color.Green;
            }
            else
            {
                lblApellido.ForeColor = Color.LightSlateGray;
            }
        }

        private void txtBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if( txtBoxEmail.Text != String.Empty)
            {
                lblEmail.ForeColor = Color.Green;
            }
            else
            {
                lblEmail.ForeColor = Color.LightSlateGray;
            }
        }
    }
}
