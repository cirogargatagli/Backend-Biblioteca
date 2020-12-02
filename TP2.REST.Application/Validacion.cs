using System;
using System.Text.RegularExpressions;

namespace TP2.REST.Application
{
    public class Validacion
    {
        public static bool ComprobarFormatoEmail(string EmailAComprobar)
        {
            string formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(EmailAComprobar, formato) && (Regex.Replace(EmailAComprobar, formato, String.Empty).Length == 0);
        }

        public static bool ValidarSoloLetras(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        public static bool ValidarDni(string dni)
        {
            return (int.TryParse(dni, out _)) && !(dni.Length < 8 || dni.Length > 8);
        }

        public static bool ValidarFecha(string fecha)
        {
            return DateTime.TryParse(fecha, out _);
        }
    }
}