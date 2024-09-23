namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LV_Pila_1 = new System.Windows.Forms.ListView();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.LV_Pila_2 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_reinsertar = new System.Windows.Forms.Button();
            this.btn_addFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LV_Pila_1
            // 
            this.LV_Pila_1.HideSelection = false;
            this.LV_Pila_1.Location = new System.Drawing.Point(52, 54);
            this.LV_Pila_1.Name = "LV_Pila_1";
            this.LV_Pila_1.Size = new System.Drawing.Size(162, 354);
            this.LV_Pila_1.TabIndex = 0;
            this.LV_Pila_1.UseCompatibleStateImageBehavior = false;
            this.LV_Pila_1.SelectedIndexChanged += new System.EventHandler(this.LV_Pila_1_SelectedIndexChanged);
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(292, 169);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(151, 23);
            this.btn_push.TabIndex = 1;
            this.btn_push.Text = "Agregar al Principio";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(292, 198);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(151, 23);
            this.btn_pop.TabIndex = 2;
            this.btn_pop.Text = "POP";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // LV_Pila_2
            // 
            this.LV_Pila_2.HideSelection = false;
            this.LV_Pila_2.Location = new System.Drawing.Point(518, 54);
            this.LV_Pila_2.Name = "LV_Pila_2";
            this.LV_Pila_2.Size = new System.Drawing.Size(162, 354);
            this.LV_Pila_2.TabIndex = 3;
            this.LV_Pila_2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btn_reinsertar
            // 
            this.btn_reinsertar.Location = new System.Drawing.Point(292, 385);
            this.btn_reinsertar.Name = "btn_reinsertar";
            this.btn_reinsertar.Size = new System.Drawing.Size(151, 23);
            this.btn_reinsertar.TabIndex = 5;
            this.btn_reinsertar.Text = "REINSERT";
            this.btn_reinsertar.UseVisualStyleBackColor = true;
            // 
            // btn_addFinal
            // 
            this.btn_addFinal.Location = new System.Drawing.Point(292, 227);
            this.btn_addFinal.Name = "btn_addFinal";
            this.btn_addFinal.Size = new System.Drawing.Size(151, 23);
            this.btn_addFinal.TabIndex = 6;
            this.btn_addFinal.Text = "Agregar al Final";
            this.btn_addFinal.UseVisualStyleBackColor = true;
            this.btn_addFinal.Click += new System.EventHandler(this.btn_addFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addFinal);
            this.Controls.Add(this.btn_reinsertar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LV_Pila_2);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.LV_Pila_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Pila_1;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.ListView LV_Pila_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_reinsertar;
        private System.Windows.Forms.Button btn_addFinal;
    }
}

