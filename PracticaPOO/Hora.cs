using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    internal class Hora
    {
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public Hora(int horas, int minutos, int segundos)
        {
            this.Horas = horas;
            this.Minutos = minutos;
            this.Segundos = segundos;
        }
        public Hora(string horario)
        {
            string[] arrayHorarioSeparado = horario.Split(':');

            this.Horas = int.Parse(arrayHorarioSeparado[0]);
            this.Minutos = int.Parse(arrayHorarioSeparado[1]);
            this.Segundos = int.Parse(arrayHorarioSeparado[2]);
        }

        public string Imprimir()
        {
            string mensaje = $"{Horas.ToString()} HORAS, {Minutos.ToString()} MINUTOS Y {Segundos.ToString()} SEGUNDOS";
            return mensaje;
        }
    }
}
