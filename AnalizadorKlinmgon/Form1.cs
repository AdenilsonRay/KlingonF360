using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorKlinmgon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            //Fechando formulario
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //executa menssagem
            DialogResult FinalizarSistema = MessageBox.Show("Finalizar o aplicativo?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //Se resposta nao cancela fechamento do sistema
            if (FinalizarSistema == DialogResult.No)
                e.Cancel = true;
        }
    }
}
