using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class clsCalcularIMC
    {
        //Atributos
        private float peso;
        private float altura;
        private float IMC;
        private string EstadoSalud;
        private int noPasos;
        private float tamañoZancada;
        private float kMCaminados;
        private float kmNecesarios;
        private string planAccion;
        private bool bandera = true;

        //Propiedades
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }
        public int NoPasos { get => noPasos; set => noPasos = value; }
        public float TamañoZancada { get => tamañoZancada; set => tamañoZancada = value; }

        //Metodos o funciónes 
        public float CalcIMC()
        {
            IMC = peso / (altura * altura);
            return IMC;
        }
        public string CalcEstadoSalud()
        {
            if (IMC < 18.5)
            {
                EstadoSalud = "Bajo";
                bandera = false;
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                EstadoSalud = "Ideal";
                kmNecesarios = 3;
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                EstadoSalud = "Sobrepeso";
                kmNecesarios = 5;
            }
            else if (IMC >= 30)
            {
                EstadoSalud = "Obesidad";
                kmNecesarios = 10;
            }
            return EstadoSalud;
        }
        public float CalcularKmCaminados()
        {
            kMCaminados = noPasos * tamañoZancada / 1000;
            return kMCaminados; 
        }
        public string DefinirPlanAccion()
        {
            if (bandera == true)
            {
                if (kmNecesarios <= kMCaminados)
                {
                    planAccion = "Meta Cumplida";
                }
                else
                {
                    kmNecesarios = kmNecesarios - kMCaminados;
                    planAccion = "Necesita caminar " + kmNecesarios.ToString() + " Km";
                }
            }
            else
            {
                planAccion = "Ninguna";
            }

            return planAccion;
        }

    }
}
