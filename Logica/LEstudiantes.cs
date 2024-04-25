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
        private Bitmap _imgBitmap;

        //private Library librarys;


        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, Object[] objeto)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //this.librarys = new Library();
            this.image = (PictureBox)objeto[0];
            this._imgBitmap = (Bitmap)objeto[1];
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
                        var user = _Estudiante.Where(u => u.email.Equals(listTextBox[3].Text)).ToList();

                        if (user.Count.Equals(0))
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



                Contador++;
            });

        }

        private void Save()
        {

            var imageArray = uploadingimage.ImageToByte(this.image.Image);

            BeginTransactionAsync();

            try
            {
                _Estudiante.Value(e => e.nid, listTextBox[0].Text)
                .Value(e => e.nombre, listTextBox[1].Text)
                .Value(e => e.apellido, listTextBox[2].Text)
                .Value(e => e.email, listTextBox[3].Text)
                 .Value(e => e.image, imageArray)
                .Insert()
                ;

                CommitTransaction();
                Restablecer();

            }
            catch (Exception e)
            {
                RollbackTransaction();
            }


        }

        private void Restablecer()
        {

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

        }

    }
}
