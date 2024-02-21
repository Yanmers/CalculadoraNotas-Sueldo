using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClaseII
{
    public class claNomina
    {
        public double Salario(double SalarioHoras, double HorasTrabajadas, double HorasExtras)
        {
            return SalarioHoras + HorasTrabajadas + HorasExtras;
            
        }

        public double DescAfp(double Desc = 0.0287)
        {
            return Desc; 
        }


        public double DescArs(double Desc = 0.0304)
        {
            return Desc;
        }

        public double DescIrs(double SueldoBase)
        {
            if(SueldoBase >= 34685)
            {
                return 0.15;
            }
            else if(SueldoBase >= 52000)
            {
                return  0.20;
            }
            else if(SueldoBase >= 72000)
            {
                return  0.25;

            }
            else
            {
                return SueldoBase;
            }
           
        }


       

        


    }
}
