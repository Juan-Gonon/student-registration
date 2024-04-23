using Logica.Librery;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using LinqToDB;

namespace Logica
{
    public class LEstudiantes : Library
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;

        //private Library librarys;


        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, Object[] objeto)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //this.librarys = new Library();
            this.image = (PictureBox)objeto[0];
        }

        
        public void Registrar()
        {
            int Contador = 0;
            var email = this.listLabel[3].Text;


            //var email = ;


            this.listTextBox.ForEach(textBox=>
            {
                if(textBox.Text == "")
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
                        var imageArray = uploadingimage.ImageToByte(this.image.Image);


                        //var db = new Conexion();

                        //db.Insert(new Estudiante()
                        //{
                        //    nid = listTextBox[0].Text,
                        //    nombre = listTextBox[1].Text,
                        //    apellido = listTextBox[2].Text,
                        //    email = listTextBox[3].Text,
                        //});

                        _Estudiante.Value(e => e.nid, listTextBox[0].Text)
                        .Value(e => e.nombre, listTextBox[1].Text)
                        .Value(e => e.apellido, listTextBox[2].Text)
                        .Value(e => e.email, listTextBox[3].Text)
                         .Value(e => e.image, imageArray)
                        .Insert()
                        ;

                    }
                }



                Contador++;
            });

        }
    }
}
