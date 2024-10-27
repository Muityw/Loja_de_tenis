namespace dados_registro
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.salvar = new System.Windows.Forms.Button();
            this.nomecompletobox = new System.Windows.Forms.TextBox();
            this.senhabox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cpfbox = new System.Windows.Forms.TextBox();
            this.confirmsenhabox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.confirmemailbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.Transparent;
            this.salvar.FlatAppearance.BorderSize = 0;
            this.salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvar.Location = new System.Drawing.Point(843, 550);
            this.salvar.Margin = new System.Windows.Forms.Padding(2);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(163, 43);
            this.salvar.TabIndex = 0;
            this.salvar.UseVisualStyleBackColor = false;
            // 
            // nomecompletobox
            // 
            this.nomecompletobox.BackColor = System.Drawing.SystemColors.MenuText;
            this.nomecompletobox.ForeColor = System.Drawing.Color.White;
            this.nomecompletobox.Location = new System.Drawing.Point(207, 154);
            this.nomecompletobox.Margin = new System.Windows.Forms.Padding(2);
            this.nomecompletobox.Name = "nomecompletobox";
            this.nomecompletobox.Size = new System.Drawing.Size(349, 20);
            this.nomecompletobox.TabIndex = 1;
            this.nomecompletobox.TextChanged += new System.EventHandler(this.nomecompletobox_TextChanged);
            // 
            // senhabox
            // 
            this.senhabox.BackColor = System.Drawing.SystemColors.MenuText;
            this.senhabox.ForeColor = System.Drawing.Color.White;
            this.senhabox.Location = new System.Drawing.Point(207, 270);
            this.senhabox.Margin = new System.Windows.Forms.Padding(2);
            this.senhabox.Name = "senhabox";
            this.senhabox.Size = new System.Drawing.Size(349, 20);
            this.senhabox.TabIndex = 2;
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.emailbox.ForeColor = System.Drawing.Color.White;
            this.emailbox.Location = new System.Drawing.Point(207, 380);
            this.emailbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(349, 20);
            this.emailbox.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(207, 500);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(349, 20);
            this.textBox4.TabIndex = 4;
            // 
            // cpfbox
            // 
            this.cpfbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.cpfbox.ForeColor = System.Drawing.Color.White;
            this.cpfbox.Location = new System.Drawing.Point(655, 154);
            this.cpfbox.Margin = new System.Windows.Forms.Padding(2);
            this.cpfbox.Name = "cpfbox";
            this.cpfbox.Size = new System.Drawing.Size(341, 20);
            this.cpfbox.TabIndex = 5;
            // 
            // confirmsenhabox
            // 
            this.confirmsenhabox.BackColor = System.Drawing.SystemColors.MenuText;
            this.confirmsenhabox.ForeColor = System.Drawing.Color.White;
            this.confirmsenhabox.Location = new System.Drawing.Point(655, 270);
            this.confirmsenhabox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmsenhabox.Name = "confirmsenhabox";
            this.confirmsenhabox.Size = new System.Drawing.Size(341, 20);
            this.confirmsenhabox.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(655, 500);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(325, 20);
            this.textBox7.TabIndex = 7;
            // 
            // confirmemailbox
            // 
            this.confirmemailbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.confirmemailbox.ForeColor = System.Drawing.Color.White;
            this.confirmemailbox.Location = new System.Drawing.Point(655, 380);
            this.confirmemailbox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmemailbox.Name = "confirmemailbox";
            this.confirmemailbox.Size = new System.Drawing.Size(341, 20);
            this.confirmemailbox.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dados_registro.Properties.Resources.registro;
            this.ClientSize = new System.Drawing.Size(1195, 643);
            this.Controls.Add(this.confirmemailbox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.confirmsenhabox);
            this.Controls.Add(this.cpfbox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.senhabox);
            this.Controls.Add(this.nomecompletobox);
            this.Controls.Add(this.salvar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.TextBox nomecompletobox;
        private System.Windows.Forms.TextBox senhabox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox cpfbox;
        private System.Windows.Forms.TextBox confirmsenhabox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox confirmemailbox;
    }
}

