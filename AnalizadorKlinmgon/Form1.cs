using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorKlingon
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

        private void SelecaoTextoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Exibir janela de selecao de arquivo
                DialogResult dr = this.textoKlingonOpenFileDialog.ShowDialog();

                //Se arquivo selecionado
                if (dr == DialogResult.OK)
                {
                    //Colocar o nome do arquivo selecionado
                    textoSelecionadoLabel.Text = textoKlingonOpenFileDialog.FileName;

                    //Colocar arquivo texto no textBox
                    using (StreamReader sr = new StreamReader(textoKlingonOpenFileDialog.FileName))
                    {
                        textoSelecionadoTextBox.Text = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                // Não pode carregar o arquivo
                MessageBox.Show("Não é possível carregar o arquivo" + textoSelecionadoLabel.Text +
                                ". Você pode não ter permissão para ler o arquivo , ou " +
                                " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
            }
        }

        private void PreposicoesButton_Click(object sender, EventArgs e)
        {
            AnalizadorK ak = new AnalizadorK();
            ak.Selecionar_Preposicoes_Klingon(textoSelecionadoTextBox.Text);

            resultadoLabel.Text = "Resultado do Teste de: PREPOSIÇÕES";

            textoSelecionadoLabel.Text = "Texto Selecionado:" + textoKlingonOpenFileDialog.SafeFileName;
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            LimpandoTela();
        }

        private void LimpandoTela()
        {
            resultadoLabel.Text = "Resultado do Teste de:";
            textoSelecionadoLabel.Text = "Texto Selecionado:";
            textoSelecionadoTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;
            selecaoTextoButton.Focus();
        }
    }
}
