using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimixTeste.Helpers
{
    public static class ColorirCardHelper
    {
        public static string Colorir(string valor)
        {
            switch (valor)
            {
                case "X":
                    return "bg-primary";
                case "Y":
                    return "bg-warning";
                case "Z":
                    return "bg-success";

                default:
                    return string.Empty;
            }
        }
    }
}
