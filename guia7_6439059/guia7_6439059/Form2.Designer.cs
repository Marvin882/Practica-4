namespace guia7_6439059
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertar2 = new System.Windows.Forms.Button();
            this.textedad2 = new System.Windows.Forms.TextBox();
            this.textapel2 = new System.Windows.Forms.TextBox();
            this.textnom2 = new System.Windows.Forms.TextBox();
            this.textcod2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertar2
            // 
            this.insertar2.Location = new System.Drawing.Point(355, 171);
            this.insertar2.Name = "insertar2";
            this.insertar2.Size = new System.Drawing.Size(75, 23);
            this.insertar2.TabIndex = 17;
            this.insertar2.Text = "Insertar";
            this.insertar2.UseVisualStyleBackColor = true;
            this.insertar2.Click += new System.EventHandler(this.insertar2_Click);
            // 
            // textedad2
            // 
            this.textedad2.Location = new System.Drawing.Point(183, 221);
            this.textedad2.Name = "textedad2";
            this.textedad2.Size = new System.Drawing.Size(100, 20);
            this.textedad2.TabIndex = 16;
            // 
            // textapel2
            // 
            this.textapel2.Location = new System.Drawing.Point(183, 168);
            this.textapel2.Name = "textapel2";
            this.textapel2.Size = new System.Drawing.Size(100, 20);
            this.textapel2.TabIndex = 15;
            // 
            // textnom2
            // 
            this.textnom2.Location = new System.Drawing.Point(183, 110);
            this.textnom2.Name = "textnom2";
            this.textnom2.Size = new System.Drawing.Size(100, 20);
            this.textnom2.TabIndex = 14;
            // 
            // textcod2
            // 
            this.textcod2.Location = new System.Drawing.Point(183, 53);
            this.textcod2.Name = "textcod2";
            this.textcod2.Size = new System.Drawing.Size(100, 20);
            this.textcod2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo";
            // 
            // buscar2
            // 
            this.buscar2.Location = new System.Drawing.Point(355, 84);
            this.buscar2.Name = "buscar2";
            this.buscar2.Size = new System.Drawing.Size(75, 23);
            this.buscar2.TabIndex = 18;
            this.buscar2.Text = "Buscar";
            this.buscar2.UseVisualStyleBackColor = true;
            this.buscar2.Click += new System.EventHandler(this.buscar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar2);
            this.Controls.Add(this.insertar2);
            this.Controls.Add(this.textedad2);
            this.Controls.Add(this.textapel2);
            this.Controls.Add(this.textnom2);
            this.Controls.Add(this.textcod2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertar2;
        private System.Windows.Forms.TextBox textedad2;
        private System.Windows.Forms.TextBox textapel2;
        private System.Windows.Forms.TextBox textnom2;
        private System.Windows.Forms.TextBox textcod2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar2;
    }
}