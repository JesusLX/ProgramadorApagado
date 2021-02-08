using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------
using System.IO;

namespace PropioWAppProgramarApagado
{
    class ControlDelTiempo
    {
        string ruta;

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public ControlDelTiempo(string rutaBase)
        {
            Ruta = rutaBase;
        }

        public string GenerarFicheroApagar(int segundos)
        {
            string comandoApagar = "shutdown -s -t ";
            string rutaAlFichero = ruta + "apaga.bat";

            try
            {
                Stream sficheroApagar = new FileInfo(rutaAlFichero).Open(FileMode.Create, FileAccess.Write);
                StreamWriter swficheroApagar = new StreamWriter(sficheroApagar);
                // Escribe en el fichero el comando de apagado junto a los segundos que se pasan por parametros
                swficheroApagar.WriteLine(comandoApagar + segundos.ToString());

                swficheroApagar.Close();
                sficheroApagar.Close();
                return rutaAlFichero;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string GenerarFicheroCancelarApagado()
        {
            string comandoCancelarApagado = "shutdown -a";
            string rutaAlFichero = ruta + "cancelar.bat";

            try
            {
                Stream sficheroApagar = new FileInfo(rutaAlFichero).Open(FileMode.Create, FileAccess.Write);
                StreamWriter swficheroApagar = new StreamWriter(sficheroApagar);
                // Escribe en el fichero el comando de cancelar apagado
                swficheroApagar.WriteLine(comandoCancelarApagado);
                swficheroApagar.Close();
                sficheroApagar.Close();

                return rutaAlFichero;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
