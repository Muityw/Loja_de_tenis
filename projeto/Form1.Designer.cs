namespace projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nike = new System.Windows.Forms.Button();
            this.puma = new System.Windows.Forms.Button();
            this.adidas = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nike
            // 
            this.nike.BackColor = System.Drawing.Color.Transparent;
            this.nike.FlatAppearance.BorderSize = 0;
            this.nike.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nike.Location = new System.Drawing.Point(360, 428);
            this.nike.Name = "nike";
            this.nike.Size = new System.Drawing.Size(115, 51);
            this.nike.TabIndex = 0;
            this.nike.UseVisualStyleBackColor = false;
            // 
            // puma
            // 
            this.puma.BackColor = System.Drawing.Color.Transparent;
            this.puma.FlatAppearance.BorderSize = 0;
            this.puma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.puma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.puma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puma.Location = new System.Drawing.Point(515, 406);
            this.puma.Name = "puma";
            this.puma.Size = new System.Drawing.Size(115, 83);
            this.puma.TabIndex = 1;
            this.puma.UseVisualStyleBackColor = false;
            // 
            // adidas
            // 
            this.adidas.BackColor = System.Drawing.Color.Transparent;
            this.adidas.FlatAppearance.BorderSize = 0;
            this.adidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.adidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.adidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adidas.Location = new System.Drawing.Point(674, 406);
            this.adidas.Name = "adidas";
            this.adidas.Size = new System.Drawing.Size(115, 73);
            this.adidas.TabIndex = 2;
            this.adidas.UseVisualStyleBackColor = false;
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.Transparent;
            this.entrar.FlatAppearance.BorderSize = 0;
            this.entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Location = new System.Drawing.Point(1057, 12);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(115, 120);
            this.entrar.TabIndex = 3;
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.adidas);
            this.Controls.Add(this.puma);
            this.Controls.Add(this.nike);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button nike;
        private Button puma;
        private Button adidas;
        private Button entrar;
    }
}