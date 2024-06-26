﻿using Logica.Librery;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using LinqToDB;
using System.Drawing.Text;

namespace Logica
{
    public class LEstudiantes : Library
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        private Bitmap _imgBitmap;
        private DataGridView _dataGrid;
        private NumericUpDown _numericUpDown;
        private Paginator<Estudiante> _paginador;
        private List<Estudiante> listEstudiante;
        private String _action = "insert";

        //private Library librarys;


        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, Object[] objeto)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //this.librarys = new Library();
            this.image = (PictureBox)objeto[0];
            this._imgBitmap = (Bitmap)objeto[1];
            this._dataGrid = (DataGridView)objeto[2];
            this._numericUpDown = (NumericUpDown)objeto[3];
            Restablecer();
        }


        public void Registrar()
        {
            int Contador = 0;
            var email = this.listLabel[3].Text;


            //var email = ;


            this.listTextBox.ForEach(textBox =>
            {
                if (textBox.Text == "")
                {
                    this.listLabel[Contador].Text = $"{this.listLabel[Contador].Text}requerido";
                    this.listLabel[Contador].ForeColor = Color.Red;
                    this.listTextBox[Contador].Focus();

                }

                if (this.listLabel[Contador].Text == email)
                {
                    if (!textBoxEvent.FormatEmail(Convert.ToString(textBox)))
                    {
                        listLabel[Contador].Text = "Email no valido";
                        this.listLabel[Contador].ForeColor = Color.Red;
                        this.listTextBox[Contador].Focus();
                    }
                    else
                    {
                        var user = _Estudiante.Where(u => u.email.Equals(listTextBox[3].Text)).ToList();

                        if (user.Count.Equals(0))
                        {
                            Save();
                        }
                        else
                        {
                            if (user[0].id.Equals(_idEstudiante))
                            {
                                Save();
                            }
                            else
                            {
                                listLabel[Contador].Text = "Email ya esta registrado";
                                this.listLabel[Contador].ForeColor = Color.Red;
                                this.listTextBox[Contador].Focus();
                            }
                        }
                    }
                }



                Contador++;
            });

        }

        private void Save()
        {

            BeginTransactionAsync();

            try
            {
                var imageArray = uploadingimage.ImageToByte(this.image.Image);

                switch (_action)
                {
                    case "insert":
                        _Estudiante.Value(e => e.nid, listTextBox[0].Text)
                        .Value(e => e.nombre, listTextBox[1].Text)
                        .Value(e => e.apellido, listTextBox[2].Text)
                        .Value(e => e.email, listTextBox[3].Text)
                        .Value(e => e.image, imageArray)
                        .Insert()
                        ;
                        break;
                    case "update":
                        _Estudiante.Where(e => e.id.Equals(_idEstudiante))
                        .Set(e => e.nid, listTextBox[0].Text)
                        .Set(e => e.nombre, listTextBox[1].Text)
                        .Set(e => e.apellido, listTextBox[2].Text)
                        .Set(e => e.email, listTextBox[3].Text)
                        .Set(e => e.image, imageArray)
                        .Update()
                        ;
                        break;

                    default:
                        break;
                }



                CommitTransaction();
                Restablecer();

            }
            catch (Exception e)
            {
                RollbackTransaction();
            }


        }

        private int _reg_por_pagina = 2, _num_pagina = 1;

        public void SearchEstudiante(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();

            int inicio = (_num_pagina - 1) * _reg_por_pagina;

            if (campo.Equals(""))
            {
                query = _Estudiante.ToList();
            }
            else
            {
                query = _Estudiante.Where(c => c.nid.StartsWith(campo)
                || c.nombre.StartsWith(campo)
                || c.apellido.StartsWith(campo)
                ).ToList();
            }

            if (query.Count > 0)
            {
                this._dataGrid.DataSource = query.Select(c => new
                {
                    c.id,
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.email,
                    c.image,
                }).Skip(inicio).Take(_reg_por_pagina).ToList();

                this._dataGrid.Columns[0].Visible = false;
                this._dataGrid.Columns[5].Visible = false;
                this._dataGrid.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                this._dataGrid.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            else
            {
                this._dataGrid.DataSource = query.Select(c =>
                new
                {
                    c.id,
                    c.nombre,
                    c.apellido,
                    c.email
                }).ToList();
            }


        }

        public void Paginador(String metodo)
        {
            switch (metodo)
            {
                case "Primero":
                    _num_pagina = _paginador.primero();
                    break;
                case "Anterior":
                    _num_pagina = _paginador.anterior();
                    break;
                case "Siguiente":
                    _num_pagina = _paginador.siguiente();
                    break;
                case "Ultimo":
                    _num_pagina = _paginador.ultimo();
                    break;
            }
            SearchEstudiante("");
        }

        private int _idEstudiante = 0;
        public void getEstudiante()
        {
            _action = "update";
            _idEstudiante = Convert.ToInt32(_dataGrid.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGrid.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(_dataGrid.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(_dataGrid.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(_dataGrid.CurrentRow.Cells[4].Value);

            try
            {
                byte[] arrayImage = (byte[])_dataGrid.CurrentRow.Cells[5].Value;
                image.Image = uploadingimage.byteArrayToImagen(arrayImage);

            }
            catch (Exception e)
            {
                image.Image = _imgBitmap;
            }


        }

        public void Registro_Paginas()
        {
            _num_pagina = 1;
            _reg_por_pagina = (int)this._numericUpDown.Value;
            var list = _Estudiante.ToList();

            if (list.Count > 0)
            {
                _paginador = new Paginator<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);

                SearchEstudiante("");

            }

        }

        public void Restablecer()
        {
            _action = "insert";
            _num_pagina = 1;
            _idEstudiante = 0;
            image.Image = this._imgBitmap;
            listLabel[0].Text = "Nid: ";
            listLabel[1].Text = "Nombre: ";
            listLabel[2].Text = "Apellido: ";
            listLabel[3].Text = "Email: ";

            listLabel.ForEach((element) =>
            {
                element.ForeColor = Color.LightSlateGray;
            });

            listTextBox.ForEach((element) =>
            {
                element.Text = "";
            });


            listEstudiante = _Estudiante.ToList();

            if (listEstudiante.Count > 0)
            {
                _paginador = new Paginator<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
            }
            SearchEstudiante("");
        }

        public void Eliminar()
        {
            if (_idEstudiante.Equals(0))
            {
                MessageBox.Show("Seleccione un estudiante");
            }
            else
            {
                if(MessageBox.Show("Estas seguro de eliminar el estudiante? ", "Eliminar estudiante",
                    MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    _Estudiante.Where(c => c.id.Equals(_idEstudiante)).Delete();
                    Restablecer();

                }
            }

        }

    }
}
