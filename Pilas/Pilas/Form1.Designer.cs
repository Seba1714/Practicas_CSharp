namespace Pilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.btnAddNodo = new System.Windows.Forms.Button();
            this.listPila = new System.Windows.Forms.ListBox();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(262, 223);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreNodo.TabIndex = 1;
            // 
            // btnAddNodo
            // 
            this.btnAddNodo.Location = new System.Drawing.Point(262, 258);
            this.btnAddNodo.Name = "btnAddNodo";
            this.btnAddNodo.Size = new System.Drawing.Size(75, 23);
            this.btnAddNodo.TabIndex = 2;
            this.btnAddNodo.Text = "Apilar";
            this.btnAddNodo.UseVisualStyleBackColor = true;
            this.btnAddNodo.Click += new System.EventHandler(this.btnAddNodo_Click);
            // 
            // listPila
            // 
            this.listPila.Location = new System.Drawing.Point(33, 35);
            this.listPila.Name = "listPila";
            this.listPila.Size = new System.Drawing.Size(197, 329);
            this.listPila.TabIndex = 5;
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(262, 297);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(75, 23);
            this.btnDesapilar.TabIndex = 4;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.listPila);
            this.Controls.Add(this.btnAddNodo);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.Button btnAddNodo;
        private System.Windows.Forms.ListBox listPila;
        private System.Windows.Forms.Button btnDesapilar;
    }
}