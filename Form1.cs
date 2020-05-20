using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        Atleta obj = new Atleta();
        private void btncalcularimc_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtnome.Text;
                obj.Altura= double.Parse(txtaltura.Text);
             
                obj.Peso = double.Parse(txtpeso.Text);
                obj.Idade = int.Parse(txtidade.Text);
                MessageBox.Show(""+obj.Calcularimc());
            }
            catch (FormatException)
            {
                MessageBox.Show("nos campos peso,altura e idade recebem apenas numeros");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Preencha com numeros maiores que 0");
            }
           

        }
    }
}
