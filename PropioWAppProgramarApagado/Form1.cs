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

        ControlDelTiempo controlador = new ControlDelTiempo("."+Path.DirectorySeparatorChar);

        public FormPrincipal()
        {
            InitializeComponent();
            SeAcabaTuTiempoEvent += LanzarApagado;
        }

      

        private void Global_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Back)
                return;
            else
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }

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
        private int CogerTiempo()
        {
            try
            {   // Cogemos los segundos para escribiros en el documento 
                if (tBHoras.Text == "")
                    tBHoras.Text = "0";
                if (tBMinutos.Text == "")
                    tBMinutos.Text = "0";
                if (tBSegundos.Text == "")
                    tBSegundos.Text = "0";
                horas = int.Parse(tBHoras.Text);
                minutos = int.Parse(tBMinutos.Text);
                segundos = int.Parse(tBSegundos.Text);

                minutos += horas * 60;
                segundos += minutos * 60;

                return segundos;
            }
            catch (Exception)
            {
                return -1;   
            }
        }

        private void timerCuentaAtras_Tick(object sender, EventArgs e)
        {
            int LanzarAlLlegarA = 10;
            //Cuenta atras
            tiempoRestante--;

            // Si el tiempo es menor a 10 segundos 
            if (tiempoRestante == LanzarAlLlegarA)
                LanzarApagado(null, null);
            // Si el tiempo es menor a 1 segundos 
            if (tiempoRestante == 1)
            {
                //LanzarApagado(null, null);
                this.Close();
            }
            // Imprimimos en un label el tiempo que queda
            lbCuentaAtras.Text = tiempoRestante + " segundos";
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
            //Lanzamos el fichero de apagado primero para evitar que haya otra cuenta atras ya activa
            string ficheroCancelar = controlador.GenerarFicheroCancelarApagado();
            System.Diagnostics.Process.Start(ficheroCancelar);
            timerCuentaAtras.Enabled = false;
            lbCuentaAtras.Text = "Tiempo Restante";
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerCuentaAtras.Enabled)
                LanzarApagado(null,null);
        }



    }
}
