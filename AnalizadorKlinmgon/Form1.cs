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
        #region Variáveis de classe/Construtor

        // Variaveis de Classe
        private readonly AnalizadorK analizadorObj = new AnalizadorK();

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {
            //Focando no botao selecionar arquivo
            selecaoTextoButton.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //executa menssagem
            DialogResult FinalizarSistema = MessageBox.Show("Finalizar o aplicativo?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //Se resposta nao cancela fechamento do sistema
            if (FinalizarSistema == DialogResult.No)
                e.Cancel = true;

            //Focando no botao selecionar arquivo
            selecaoTextoButton.Focus();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            // Fechando formulario
            this.Close();
        }

        private void SelecaoTextoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Limpando_Tela();

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
            // Se texto selecionado
            if (textoSelecionadoTextBox.Text.Trim() != String.Empty)
            {
                // Selecionando preposições
                resultadoTextBox.Text = analizadorObj.Selecionar_Preposicoes_Klingon(textoSelecionadoTextBox.Text);

                // Informando tipo de analize
                resultadoLabel.Text = "Resultado do Teste de: PREPOSIÇÕES";

                // Informando resultado
                textoSelecionadoLabel.Text = "Texto Selecionado:" + textoKlingonOpenFileDialog.SafeFileName;
            }
            else
            {
                // executa menssagem foca butão selecao
                DialogResult FinalizarSistema = MessageBox.Show("Selecione um texto!", "Informacao!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                selecaoTextoButton.Focus();
            }
        }

        private void VerbosButton_Click(object sender, EventArgs e)
        {
            // Se texto selecionado
            if (textoSelecionadoTextBox.Text.Trim() != String.Empty)
            {
                // Selcionando verbos
                resultadoTextBox.Text = analizadorObj.Selecionar_Verbos_Klingon(textoSelecionadoTextBox.Text);

                // Informando tipo de analize
                resultadoLabel.Text = "Resultado do Teste de: VERBOS";

                // Informando resultado
                textoSelecionadoLabel.Text = "Texto Selecionado:" + textoKlingonOpenFileDialog.SafeFileName;
            }
            else
            {
                // executa menssagem foca butão selecao
                DialogResult FinalizarSistema = MessageBox.Show("Selecione um texto!", "Informacao!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                selecaoTextoButton.Focus();
            }
        }

        private void VocabularioButton_Click(object sender, EventArgs e)
        {
            // Se texto selecionado
            if (textoSelecionadoTextBox.Text.Trim() != String.Empty)
            {
                // Selecionando vocabulario
                resultadoTextBox.Text = analizadorObj.Selecionar_Vocabulario_Klingon(textoSelecionadoTextBox.Text);

                // Informando tipo de analize
                resultadoLabel.Text = "Resultado do Teste de: VOCABULÁRIOS";

                // Informando resultado
                textoSelecionadoLabel.Text = "Texto Selecionado:" + textoKlingonOpenFileDialog.SafeFileName;
            }
            else
            {
                // executa menssagem foca butão selecao
                DialogResult FinalizarSistema = MessageBox.Show("Selecione um texto!", "Informacao!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                selecaoTextoButton.Focus();
            }
        }

        private void NumerosButton_Click(object sender, EventArgs e)
        {
            // Se texto selecionado
            if (textoSelecionadoTextBox.Text.Trim() != String.Empty)
            {
                // Selecionando numeros
                resultadoTextBox.Text = analizadorObj.Selecionar_Numeros_Bonitos_Klingon(textoSelecionadoTextBox.Text);

                // Informando tipo de analize
                resultadoLabel.Text = "Resultado do Teste de: NÚMEROS BONITOS";

                // Informando resultado
                textoSelecionadoLabel.Text = "Texto Selecionado:" + textoKlingonOpenFileDialog.SafeFileName;
            }
            else
            {
                // executa menssagem foca butão selecao
                DialogResult FinalizarSistema = MessageBox.Show("Selecione um texto!", "Informacao!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                selecaoTextoButton.Focus();
            }
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            Limpando_Tela();
        }

        #endregion

        #region Funções

        private void Limpando_Tela()
        {
            resultadoLabel.Text = "Resultado do Teste de:";
            textoSelecionadoLabel.Text = "Texto Selecionado:";
            textoSelecionadoTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;
            selecaoTextoButton.Focus();
        }

        private void Limpando_Tela_Resultado()
        {
            resultadoLabel.Text = "Resultado do Teste de:";
            resultadoTextBox.Text = string.Empty;
        }

        #endregion
    }
}
