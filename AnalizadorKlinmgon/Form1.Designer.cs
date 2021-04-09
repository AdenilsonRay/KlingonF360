namespace AnalizadorKlingon
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sairButton = new System.Windows.Forms.Button();
            this.preposicoesButton = new System.Windows.Forms.Button();
            this.verbosButton = new System.Windows.Forms.Button();
            this.numerosButton = new System.Windows.Forms.Button();
            this.selecaoTextoButton = new System.Windows.Forms.Button();
            this.vocabularioButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.textoSelecionadoTextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.textoSelecionadoLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.textoKlingonOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(713, 415);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 0;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // preposicoesButton
            // 
            this.preposicoesButton.Location = new System.Drawing.Point(118, 415);
            this.preposicoesButton.Name = "preposicoesButton";
            this.preposicoesButton.Size = new System.Drawing.Size(120, 23);
            this.preposicoesButton.TabIndex = 1;
            this.preposicoesButton.Text = "Teste de Preposições";
            this.preposicoesButton.UseVisualStyleBackColor = true;
            this.preposicoesButton.Click += new System.EventHandler(this.PreposicoesButton_Click);
            // 
            // verbosButton
            // 
            this.verbosButton.Location = new System.Drawing.Point(244, 415);
            this.verbosButton.Name = "verbosButton";
            this.verbosButton.Size = new System.Drawing.Size(99, 23);
            this.verbosButton.TabIndex = 2;
            this.verbosButton.Text = "Teste dos Verbos";
            this.verbosButton.UseVisualStyleBackColor = true;
            // 
            // numerosButton
            // 
            this.numerosButton.Location = new System.Drawing.Point(474, 415);
            this.numerosButton.Name = "numerosButton";
            this.numerosButton.Size = new System.Drawing.Size(108, 23);
            this.numerosButton.TabIndex = 3;
            this.numerosButton.Text = "Teste dos Números";
            this.numerosButton.UseVisualStyleBackColor = true;
            // 
            // selecaoTextoButton
            // 
            this.selecaoTextoButton.Location = new System.Drawing.Point(12, 415);
            this.selecaoTextoButton.Name = "selecaoTextoButton";
            this.selecaoTextoButton.Size = new System.Drawing.Size(100, 23);
            this.selecaoTextoButton.TabIndex = 4;
            this.selecaoTextoButton.Text = "Seleção de Texto";
            this.selecaoTextoButton.UseVisualStyleBackColor = true;
            this.selecaoTextoButton.Click += new System.EventHandler(this.SelecaoTextoButton_Click);
            // 
            // vocabularioButton
            // 
            this.vocabularioButton.Location = new System.Drawing.Point(349, 415);
            this.vocabularioButton.Name = "vocabularioButton";
            this.vocabularioButton.Size = new System.Drawing.Size(119, 23);
            this.vocabularioButton.TabIndex = 5;
            this.vocabularioButton.Text = "Teste de Vocabulário";
            this.vocabularioButton.UseVisualStyleBackColor = true;
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(632, 415);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 6;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // textoSelecionadoTextBox
            // 
            this.textoSelecionadoTextBox.Location = new System.Drawing.Point(12, 32);
            this.textoSelecionadoTextBox.Multiline = true;
            this.textoSelecionadoTextBox.Name = "textoSelecionadoTextBox";
            this.textoSelecionadoTextBox.ReadOnly = true;
            this.textoSelecionadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoSelecionadoTextBox.Size = new System.Drawing.Size(474, 377);
            this.textoSelecionadoTextBox.TabIndex = 7;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(493, 32);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultadoTextBox.Size = new System.Drawing.Size(295, 377);
            this.resultadoTextBox.TabIndex = 8;
            // 
            // textoSelecionadoLabel
            // 
            this.textoSelecionadoLabel.AutoSize = true;
            this.textoSelecionadoLabel.Location = new System.Drawing.Point(9, 13);
            this.textoSelecionadoLabel.Name = "textoSelecionadoLabel";
            this.textoSelecionadoLabel.Size = new System.Drawing.Size(99, 13);
            this.textoSelecionadoLabel.TabIndex = 9;
            this.textoSelecionadoLabel.Text = "Texto Selecionado:";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(493, 13);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(118, 13);
            this.resultadoLabel.TabIndex = 10;
            this.resultadoLabel.Text = "Resultado do Teste de:";
            // 
            // textoKlingonOpenFileDialog
            // 
            this.textoKlingonOpenFileDialog.Filter = "Texto (txt;*.txt)|*.txt| Todos os arquivos (* *)|* *";
            this.textoKlingonOpenFileDialog.InitialDirectory = "@\"Bibliotecas\"";
            this.textoKlingonOpenFileDialog.ReadOnlyChecked = true;
            this.textoKlingonOpenFileDialog.RestoreDirectory = true;
            this.textoKlingonOpenFileDialog.ShowReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.textoSelecionadoLabel);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.textoSelecionadoTextBox);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.vocabularioButton);
            this.Controls.Add(this.selecaoTextoButton);
            this.Controls.Add(this.numerosButton);
            this.Controls.Add(this.verbosButton);
            this.Controls.Add(this.preposicoesButton);
            this.Controls.Add(this.sairButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Klingon F360";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button preposicoesButton;
        private System.Windows.Forms.Button verbosButton;
        private System.Windows.Forms.Button numerosButton;
        private System.Windows.Forms.Button selecaoTextoButton;
        private System.Windows.Forms.Button vocabularioButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.TextBox textoSelecionadoTextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Label textoSelecionadoLabel;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.OpenFileDialog textoKlingonOpenFileDialog;
    }
}

