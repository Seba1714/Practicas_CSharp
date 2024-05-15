namespace Colas
{
    partial class Form1
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
            this.lstCola = new System.Windows.Forms.ListView();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(22, 47);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(181, 361);
            this.lstCola.TabIndex = 0;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(308, 85);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(172, 20);
            this.txtNombreNodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(308, 111);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 3;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(405, 111);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 4;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.lstCola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
    }
}