using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholismoApp.Infraestructure
{
    public class AlcoholRepository
    {
        public double Calculo(string bebida, double cantidad, double peso)
        {
            bebida = bebida.ToLower();
            double ml;
            double grados_alcohol;
            double AlcoholConsu;
            double AlcoholDirec;
            double MasaEtan;
            double VolumenSang;
            double AlcoholSangre;


            switch (bebida)
            {
                case "cerveza":
                    ml = 330 * cantidad;
                    grados_alcohol = 5;
                    break;
                case "vino":
                    ml = 100 * cantidad;
                    grados_alcohol = 12;
                    break;
                case "vermu":
                    ml = 70 * cantidad;
                    grados_alcohol = 17;
                    break;
                case "licor":
                    ml = 45 * cantidad;
                    grados_alcohol = 23;
                    break;
                case "brandy":
                    ml = 45 * cantidad;
                    grados_alcohol = 38;
                    break;
                case "combinado":
                    ml = 50 * cantidad;
                    grados_alcohol = 38;
                    break;
                default:
                    return 50;
            }

            //Calcular el total de alcohol consumido
            AlcoholConsu = ((grados_alcohol/ 100) * ml);

            //Cantidad de alcohol directo a la sangre
            AlcoholDirec = (.15) * AlcoholConsu;

            //Masa etanol en sangre
            MasaEtan = (0.789) * AlcoholDirec;

            //Volumen en la sangre considerando su peso
            VolumenSang = (.08) * peso;

            //Alcohol en la sangre
            AlcoholSangre = MasaEtan / VolumenSang;

            return AlcoholSangre;
        }
    }
}