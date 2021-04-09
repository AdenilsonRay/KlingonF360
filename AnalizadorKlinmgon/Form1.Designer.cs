namespace AnalizadorKlinmgon
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
            this.button4 = new System.Windows.Forms.Button();
            this.selecaoTextoButton = new System.Windows.Forms.Button();
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
            // 
            // preposicoesButton
            // 
            this.preposicoesButton.Location = new System.Drawing.Point(118, 415);
            this.preposicoesButton.Name = "preposicoesButton";
            this.preposicoesButton.Size = new System.Drawing.Size(120, 23);
            this.preposicoesButton.TabIndex = 1;
            this.preposicoesButton.Text = "Teste de Preposições";
            this.preposicoesButton.UseVisualStyleBackColor = true;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // selecaoTextoButton
            // 
            this.selecaoTextoButton.Location = new System.Drawing.Point(12, 415);
            this.selecaoTextoButton.Name = "selecaoTextoButton";
            this.selecaoTextoButton.Size = new System.Drawing.Size(100, 23);
            this.selecaoTextoButton.TabIndex = 4;
            this.selecaoTextoButton.Text = "Seleção de Texto";
            this.selecaoTextoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selecaoTextoButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.verbosButton);
            this.Controls.Add(this.preposicoesButton);
            this.Controls.Add(this.sairButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button preposicoesButton;
        private System.Windows.Forms.Button verbosButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button selecaoTextoButton;
    }
}

