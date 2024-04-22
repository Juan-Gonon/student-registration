using Logica.Librery;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Library
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, Object[] objeto)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
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
                    }
                }



                Contador++;
            });

        }
    }
}
