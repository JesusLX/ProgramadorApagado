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
            this.tBSegundos = new System.Windows.Forms.NumericUpDown();
            this.tBMinutos = new System.Windows.Forms.NumericUpDown();
            this.tBHoras = new System.Windows.Forms.NumericUpDown();
            this.bttProgramarHora = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCuentaAtras = new System.Windows.Forms.Label();
            this.timerCuentaAtras = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nIOcultar = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMSMiniatura = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCuentaAtrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttAyuda = new System.Windows.Forms.Button();
            this.hPAyuda = new System.Windows.Forms.HelpProvider();
            this.cerrarBtt = new System.Windows.Forms.Button();
            this.cMSMiniatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBSegundos
            // 
            this.tBSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSegundos.Location = new System.Drawing.Point(29, 98);
            this.tBSegundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBSegundos.Name = "tBSegundos";
            this.tBSegundos.Size = new System.Drawing.Size(195, 107);
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
            this.tBMinutos.Location = new System.Drawing.Point(267, 98);
            this.tBMinutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBMinutos.Name = "tBMinutos";
            this.tBMinutos.Size = new System.Drawing.Size(195, 98);
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
            this.tBHoras.Location = new System.Drawing.Point(503, 98);
            this.tBHoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBHoras.Name = "tBHoras";
            this.tBHoras.Size = new System.Drawing.Size(195, 107);
            this.tBHoras.TabIndex = 2;
            this.tBHoras.Text = "00";
            this.tBHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // bttProgramarHora
            // 
            this.bttProgramarHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttProgramarHora.BackColor = System.Drawing.Color.DarkBlue;
            this.bttProgramarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttProgramarHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttProgramarHora.Location = new System.Drawing.Point(61, 272);
            this.bttProgramarHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttProgramarHora.Name = "bttProgramarHora";
            this.bttProgramarHora.Size = new System.Drawing.Size(196, 76);
            this.bttProgramarHora.TabIndex = 3;
            this.bttProgramarHora.Text = "Programar";
            this.bttProgramarHora.UseVisualStyleBackColor = false;
            this.bttProgramarHora.Click += new System.EventHandler(this.bttProgramarHora_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.bttCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttCancelar.Location = new System.Drawing.Point(503, 272);
            this.bttCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(165, 76);
            this.bttCancelar.TabIndex = 4;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = false;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Segundos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(263, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(499, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas";
            // 
            // lbCuentaAtras
            // 
            this.lbCuentaAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbCuentaAtras.AutoSize = true;
            this.lbCuentaAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuentaAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCuentaAtras.Location = new System.Drawing.Point(293, 300);
            this.lbCuentaAtras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCuentaAtras.Name = "lbCuentaAtras";
            this.lbCuentaAtras.Size = new System.Drawing.Size(168, 24);
            this.lbCuentaAtras.TabIndex = 8;
            this.lbCuentaAtras.Text = "Tiempo Restante";
            this.lbCuentaAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(229, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(465, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "+";
            // 
            // nIOcultar
            // 
            this.nIOcultar.ContextMenuStrip = this.cMSMiniatura;
            this.nIOcultar.Icon = ((System.Drawing.Icon)(resources.GetObject("nIOcultar.Icon")));
            this.nIOcultar.Text = "Progamador de apagado";
            this.nIOcultar.Visible = true;
            this.nIOcultar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIOcultar_MouseDoubleClick);
            // 
            // cMSMiniatura
            // 
            this.cMSMiniatura.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMSMiniatura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.maximizarToolStripMenuItem,
            this.cancelarCuentaAtrásToolStripMenuItem});
            this.cMSMiniatura.Name = "cMSMiniatura";
            this.cMSMiniatura.Size = new System.Drawing.Size(220, 76);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // maximizarToolStripMenuItem
            // 
            this.maximizarToolStripMenuItem.Name = "maximizarToolStripMenuItem";
            this.maximizarToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.maximizarToolStripMenuItem.Text = "Maximizar";
            this.maximizarToolStripMenuItem.Click += new System.EventHandler(this.maximizarToolStripMenuItem_Click);
            // 
            // cancelarCuentaAtrásToolStripMenuItem
            // 
            this.cancelarCuentaAtrásToolStripMenuItem.Name = "cancelarCuentaAtrásToolStripMenuItem";
            this.cancelarCuentaAtrásToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.cancelarCuentaAtrásToolStripMenuItem.Text = "Cancelar cuenta atrás";
            this.cancelarCuentaAtrásToolStripMenuItem.Click += new System.EventHandler(this.cancelarCuentaAtrásToolStripMenuItem_Click);
            // 
            // bttAyuda
            // 
            this.bttAyuda.Location = new System.Drawing.Point(568, 398);
            this.bttAyuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttAyuda.Name = "bttAyuda";
            this.bttAyuda.Size = new System.Drawing.Size(100, 28);
            this.bttAyuda.TabIndex = 12;
            this.bttAyuda.Text = "Ayuda";
            this.bttAyuda.UseVisualStyleBackColor = true;
            this.bttAyuda.Click += new System.EventHandler(this.bttAyuda_Click);
            // 
            // hPAyuda
            // 
            this.hPAyuda.HelpNamespace = "ProgramadorDeApagado.chm";
            // 
            // cerrarBtt
            // 
            this.cerrarBtt.Location = new System.Drawing.Point(61, 398);
            this.cerrarBtt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cerrarBtt.Name = "cerrarBtt";
            this.cerrarBtt.Size = new System.Drawing.Size(100, 28);
            this.cerrarBtt.TabIndex = 13;
            this.cerrarBtt.Text = "Cerrar";
            this.cerrarBtt.UseVisualStyleBackColor = true;
            this.cerrarBtt.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(723, 458);
            this.Controls.Add(this.cerrarBtt);
            this.Controls.Add(this.bttAyuda);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Prograr apagado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.cMSMiniatura.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tBSegundos;
        private System.Windows.Forms.NumericUpDown tBMinutos;
        private System.Windows.Forms.NumericUpDown tBHoras;
        private System.Windows.Forms.Button bttProgramarHora;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCuentaAtras;
        private System.Windows.Forms.Timer timerCuentaAtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon nIOcultar;
        private System.Windows.Forms.ContextMenuStrip cMSMiniatura;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarCuentaAtrásToolStripMenuItem;
        private System.Windows.Forms.Button bttAyuda;
        private System.Windows.Forms.HelpProvider hPAyuda;
        private System.Windows.Forms.Button cerrarBtt;
    }
}

