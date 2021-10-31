using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistenciaApp.Infraestructure
{
        public class ResistenciaRepository
    {
        public string Calcular_Resistencia(string Banda_1, string Banda_2, string Banda_3, string Banda_4)
        {
            float Equivalencia;
            string tolerancia;

            Banda_1 = Banda_1.ToLower();
            Banda_2 = Banda_2.ToLower();
            Banda_3 = Banda_3.ToLower();
            Banda_4 = Banda_4.ToLower();

            switch (Banda_1)
            {
                case "negro":
                    Equivalencia = 0;
                    break;
                case "cafe":
                    Equivalencia = 10;
                    break;
                case "rojo":
                    Equivalencia = 20;
                    break;
                case "naranja":
                    Equivalencia = 30;
                    break;
                case "amarillo":
                    Equivalencia = 40;
                    break;
                case "verde":
                    Equivalencia = 50;
                    break;
                case "azul":
                    Equivalencia = 60;
                    break;
                case "violeta":
                    Equivalencia = 70;
                    break;
                case "gris":
                    Equivalencia = 80;
                    break;
                case "blanco":
                    Equivalencia = 90;
                    break;
                default:
                    return "El color indicado en la banda 1 no es valido";
            }

            switch (Banda_2)
            {
                case "negro":
                    Equivalencia = Equivalencia + 0;
                    break;
                case "cafe":
                    Equivalencia = Equivalencia + 1;
                    break;
                case "rojo":
                    Equivalencia = Equivalencia + 2;
                    break;
                case "naranja":
                    Equivalencia = Equivalencia + 3;
                    break;
                case "amarillo":
                    Equivalencia = Equivalencia + 4;
                    break;
                case "verde":
                    Equivalencia = Equivalencia + 5;
                    break;
                case "azul":
                    Equivalencia = Equivalencia + 6;
                    break;
                case "violeta":
                    Equivalencia = Equivalencia + 7;
                    break;
                case "gris":
                    Equivalencia = Equivalencia + 8;
                    break;
                case "blanco":
                    Equivalencia = Equivalencia + 9;
                    break;
                default:
                    return "El color indicado en la banda 2 no es valido";
            }

            switch (Banda_3)
            {
                case "negro":
                    Equivalencia = Equivalencia * 1;
                    break;
                case "cafe":
                    Equivalencia = Equivalencia * 10;
                    break;
                case "rojo":
                    Equivalencia = Equivalencia * 100;
                    break;
                case "naranja":
                    Equivalencia = Equivalencia * 1000;
                    break;
                case "amarillo":
                    Equivalencia = Equivalencia * 10000;
                    break;
                case "verde":
                    Equivalencia = Equivalencia * 100000;
                    break;
                case "azul":
                    Equivalencia = Equivalencia * 1000000;
                    break;
                case "dorado":
                    Equivalencia = Equivalencia / 10;
                    break;
                case "plata":
                    Equivalencia = Equivalencia / 100;
                    break;
                default:
                    return "El color indicado en la banda 3 no es valido";
            }

            switch (Banda_4)
            {
                case "dorado":
                    tolerancia = "5%";
                    break;
                case "plata":
                    tolerancia = "10%";
                    break;
                default:
                    return "El color indicado en la banda 4 no es valido";
            }

            return " El valor de la resisencia es: " + Equivalencia + " Ω y su tolerancia es de: " + tolerancia;
        }
    }
    }
