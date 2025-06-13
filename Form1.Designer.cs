namespace IMC
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstadoSalud = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPlanAccion = new System.Windows.Forms.TextBox();
            this.lblPlanaccion = new System.Windows.Forms.Label();
            this.txtNoPasos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTamZancada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado de Salud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Altura (M)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Peso";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(328, 72);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(364, 22);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(190, 293);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(5);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(132, 22);
            this.txtIMC.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(328, 40);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(5);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(364, 22);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtEstadoSalud
            // 
            this.txtEstadoSalud.Location = new System.Drawing.Point(525, 290);
            this.txtEstadoSalud.Margin = new System.Windows.Forms.Padding(5);
            this.txtEstadoSalud.Name = "txtEstadoSalud";
            this.txtEstadoSalud.Size = new System.Drawing.Size(213, 22);
            this.txtEstadoSalud.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(339, 202);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 42);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPlanAccion
            // 
            this.txtPlanAccion.Location = new System.Drawing.Point(226, 356);
            this.txtPlanAccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtPlanAccion.Name = "txtPlanAccion";
            this.txtPlanAccion.Size = new System.Drawing.Size(213, 22);
            this.txtPlanAccion.TabIndex = 5;
            // 
            // lblPlanaccion
            // 
            this.lblPlanaccion.AutoSize = true;
            this.lblPlanaccion.Location = new System.Drawing.Point(112, 362);
            this.lblPlanaccion.Name = "lblPlanaccion";
            this.lblPlanaccion.Size = new System.Drawing.Size(96, 16);
            this.lblPlanaccion.TabIndex = 9;
            this.lblPlanaccion.Text = "Plan de acción";
            // 
            // txtNoPasos
            // 
            this.txtNoPasos.Location = new System.Drawing.Point(328, 104);
            this.txtNoPasos.Margin = new System.Windows.Forms.Padding(5);
            this.txtNoPasos.Name = "txtNoPasos";
            this.txtNoPasos.Size = new System.Drawing.Size(364, 22);
            this.txtNoPasos.TabIndex = 6;
            this.txtNoPasos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoPasos_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero de pasos ";
            // 
            // txtTamZancada
            // 
            this.txtTamZancada.Location = new System.Drawing.Point(328, 136);
            this.txtTamZancada.Margin = new System.Windows.Forms.Padding(5);
            this.txtTamZancada.Name = "txtTamZancada";
            this.txtTamZancada.Size = new System.Drawing.Size(364, 22);
            this.txtTamZancada.TabIndex = 6;
            this.txtTamZancada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamZancada_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tamaño de Zancada (M)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlanaccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPlanAccion);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtTamZancada);
            this.Controls.Add(this.txtNoPasos);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEstadoSalud);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstadoSalud;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPlanAccion;
        private System.Windows.Forms.Label lblPlanaccion;
        private System.Windows.Forms.TextBox txtNoPasos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTamZancada;
        private System.Windows.Forms.Label label6;
    }
}

