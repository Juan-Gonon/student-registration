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

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
        }

        
        public void Registrar()
        {
            int Contador = 0;

            this.listTextBox.ForEach(textBox=>
            {
                if(textBox.Text == "")
                {
                    this.listLabel[Contador].Text = $"{this.listLabel[Contador].Text}requerido";
                    this.listLabel[Contador].ForeColor = Color.Red;
                    this.listTextBox[Contador].Focus();
                }
                else
                {
                    Console.WriteLine(textBox.Text);
                }
                Contador++;
            });

        }
    }
}
