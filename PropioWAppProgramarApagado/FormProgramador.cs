using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------
using System.IO;

namespace PropioWAppProgramarApagado
{
    public partial class FormPrincipal : Form
    {
        private event EventHandler SeAcabaTuTiempoEvent;

        int horas = 0;
        int minutos = 0;
        int segundos = 0;
        int tiempoRestante = 0;
        bool sePuedeCerrar = false;

        ControlDelTiempo controlador = new ControlDelTiempo("."+Path.DirectorySeparatorChar);

        public FormPrincipal()
        {
            InitializeComponent();
            SeAcabaTuTiempoEvent += LanzarApagado;
        }

      
        // Evita que se introduzca algo que no sea un un numero en los textbox
        private void Global_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Back)
                return;
            else
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }
        //Lanza los fichero necesarios para apagar el ordenador en el tiempo deseado
        private void bttProgramarHora_Click(object sender, EventArgs e)
        {
            string ficheroCancelar = controlador.GenerarFicheroCancelarApagado();
            //Lanzamos cuenta atras
            
            //Calculamos el tiempo
            tiempoRestante = CogerTiempo();
            
            if (tiempoRestante != -1)
            {   //Lanzamos el fichero de apagado primero para evitar que haya otra cuenta atras ya activa
                
                System.Diagnostics.Process.Start(ficheroCancelar);
                
                // Activamos la cuenta atras
                timerCuentaAtras.Enabled = true;
            }
        }
        // Coge el tiempo de los textbox
        private int CogerTiempo()
        {
            string emptyText = "";
            string zero = "0";
            int sesenta = 60;
            int fallo = -1;
            try
            {   // Cogemos los segundos para escribiros en el documento 
                // Por si los campos están vacios les pone 0 para que no de error
                if (tBHoras.Text == emptyText)
                    tBHoras.Text = zero;
                if (tBMinutos.Text == emptyText)
                    tBMinutos.Text = zero;
                if (tBSegundos.Text == emptyText)
                    tBSegundos.Text = zero;
                horas = int.Parse(tBHoras.Text);
                minutos = int.Parse(tBMinutos.Text);
                segundos = int.Parse(tBSegundos.Text);

                minutos += horas * sesenta;
                segundos += minutos * sesenta;

                return segundos;
            }
            catch (Exception)
            {
                return fallo;   
            }
        }
        // Timer que lleva la cuenta del tiempo restante
        private void timerCuentaAtras_Tick(object sender, EventArgs e)
        {
            int hor;
            int min;
            int seg;
            int LanzarAlLlegarA = 10;
            //Cuenta atras
            tiempoRestante--;

            // Si el tiempo es menor a 10 segundos 
            if (tiempoRestante <= LanzarAlLlegarA && tiempoRestante > 0)

                LanzarApagado(null, null);
            // Si el tiempo es menor a 1 segundos 
            if (tiempoRestante == 1)
            {
                //LanzarApagado(null, null);
                this.Close();
            }
            // Imprimimos en un label el tiempo que queda
            hor = (tiempoRestante / 3600);
            min = ((tiempoRestante - hor * 3600) / 60);
            seg = tiempoRestante - (hor * 3600 + min * 60);
            lbCuentaAtras.Text = hor.ToString("00")+":"+min.ToString("00")+":"+seg.ToString("00");
            
        }

        private void LanzarApagado(object sender, EventArgs e)
        {
            //Lanzamos el fichero de apagado primero para evitar que haya otra cuenta atras ya activa
            System.Diagnostics.Process.Start(controlador.GenerarFicheroCancelarApagado());
            //Lanzamos el apagado
            System.Diagnostics.Process.Start(controlador.GenerarFicheroApagar(tiempoRestante));
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            CancelarCuentaAtras();
        }
        // Cerrar form---------------------------------------
        // Formulario cerrandose
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sePuedeCerrar || !(e.CloseReason == CloseReason.WindowsShutDown))
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                e.Cancel = true;
            }
            if (sePuedeCerrar)
            {
                e.Cancel = false;
            }
        }
        // Formulario cerrado
        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (timerCuentaAtras.Enabled)
                LanzarApagado(null, null);
        }
        //----------------------------------------------
        // Menu conextual de la mineatura-------------------
        // Doble click en el icono
        private void nIOcultar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Maximizar();
        }
        // Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sePuedeCerrar = true;
            this.Close();
        }
        // Maximizar
        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maximizar();
        }
        // Cancelar cuenta atrás
        private void cancelarCuentaAtrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarCuentaAtras();
        }

        //---------------------------------------------------------------
        /// <summary>
        /// Si el formulario está minimizado lo maximiza y hace que se muertre en la barra del sistema
        /// </summary>
        private void Maximizar()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }
        }
        /// <summary>
        /// Cancela la cuenta atrás del apagado
        /// </summary>
        private void CancelarCuentaAtras()
        {
            //Lanzamos el fichero de apagado primero para evitar que haya otra cuenta atras ya activa
            string ficheroCancelar = controlador.GenerarFicheroCancelarApagado();
            System.Diagnostics.Process.Start(ficheroCancelar);
            timerCuentaAtras.Enabled = false;
            lbCuentaAtras.Text = "Tiempo Restante";
        }

        private void bttAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hPAyuda.HelpNamespace);
        }
    }
}
