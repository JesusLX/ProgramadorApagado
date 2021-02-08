namespace PropioWAppProgramarApagado
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tBSegundos = new System.Windows.Forms.TextBox();
            this.tBMinutos = new System.Windows.Forms.TextBox();
            this.tBHoras = new System.Windows.Forms.TextBox();
            this.bttProgramarHora = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCuentaAtras = new System.Windows.Forms.Label();
            this.timerCuentaAtras = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBSegundos
            // 
            this.tBSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSegundos.Location = new System.Drawing.Point(22, 80);
            this.tBSegundos.Multiline = true;
            this.tBSegundos.Name = "tBSegundos";
            this.tBSegundos.Size = new System.Drawing.Size(147, 77);
            this.tBSegundos.TabIndex = 0;
            this.tBSegundos.Text = "00";
            this.tBSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // tBMinutos
            // 
            this.tBMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMinutos.Location = new System.Drawing.Point(200, 80);
            this.tBMinutos.Multiline = true;
            this.tBMinutos.Name = "tBMinutos";
            this.tBMinutos.Size = new System.Drawing.Size(147, 77);
            this.tBMinutos.TabIndex = 1;
            this.tBMinutos.Text = "00";
            this.tBMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // tBHoras
            // 
            this.tBHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBHoras.Location = new System.Drawing.Point(377, 80);
            this.tBHoras.Multiline = true;
            this.tBHoras.Name = "tBHoras";
            this.tBHoras.Size = new System.Drawing.Size(147, 77);
            this.tBHoras.TabIndex = 2;
            this.tBHoras.Text = "00";
            this.tBHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // bttProgramarHora
            // 
            this.bttProgramarHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttProgramarHora.Location = new System.Drawing.Point(81, 210);
            this.bttProgramarHora.Name = "bttProgramarHora";
            this.bttProgramarHora.Size = new System.Drawing.Size(88, 67);
            this.bttProgramarHora.TabIndex = 3;
            this.bttProgramarHora.Text = "Programar";
            this.bttProgramarHora.UseVisualStyleBackColor = true;
            this.bttProgramarHora.Click += new System.EventHandler(this.bttProgramarHora_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCancelar.Location = new System.Drawing.Point(387, 210);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(88, 67);
            this.bttCancelar.TabIndex = 4;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Segundos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas";
            // 
            // lbCuentaAtras
            // 
            this.lbCuentaAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbCuentaAtras.AutoSize = true;
            this.lbCuentaAtras.Location = new System.Drawing.Point(228, 237);
            this.lbCuentaAtras.Name = "lbCuentaAtras";
            this.lbCuentaAtras.Size = new System.Drawing.Size(88, 13);
            this.lbCuentaAtras.TabIndex = 8;
            this.lbCuentaAtras.Text = "Tiempo Restante";
            // 
            // timerCuentaAtras
            // 
            this.timerCuentaAtras.Interval = 1000;
            this.timerCuentaAtras.Tick += new System.EventHandler(this.timerCuentaAtras_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "+";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCuentaAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttProgramarHora);
            this.Controls.Add(this.tBHoras);
            this.Controls.Add(this.tBMinutos);
            this.Controls.Add(this.tBSegundos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBSegundos;
        private System.Windows.Forms.TextBox tBMinutos;
        private System.Windows.Forms.TextBox tBHoras;
        private System.Windows.Forms.Button bttProgramarHora;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCuentaAtras;
        private System.Windows.Forms.Timer timerCuentaAtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

