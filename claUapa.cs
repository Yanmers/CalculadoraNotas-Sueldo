using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseII
{
    public class claUapa
    {
        public int NotaFinal(int PruebaFinal, int ActividadesPracticas, int ProyectoFinal,
            int ActitudesValores, int ParticipacionOralEscrita)
        {
            return PruebaFinal + ActividadesPracticas + ProyectoFinal + ActitudesValores + ParticipacionOralEscrita;
        }
        public string Resultado(int Nota)
        {
            if(Nota >= 70)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
        public string Literal(int Nota)
        {
            if(Nota >= 90)
            {
                return "A";
            }
            else if(Nota >= 80)
            {
                return "B";
            }
            else if (Nota >= 70)
            {
                return "C";
            }
            else if (Nota >= 60)
            {
                return "D";
            }
            else { return "F"; }
        }
    }
   
}
