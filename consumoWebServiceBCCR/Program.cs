using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace consumoWebServiceBCCR
{
    class Program
    {
        static void Main(string[] args)
        {
            cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos cliente = new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();
            DataSet tipoCambio = cliente.ObtenerIndicadoresEconomicos("317", "15/11/2014","15/11/2014", "Gregory Hidalgo", "N");
            Console.WriteLine("Código Indicador: "+ tipoCambio.Tables[0].Rows[0].ItemArray[0].ToString());
            Console.WriteLine("Fecha Consulta: " + tipoCambio.Tables[0].Rows[0].ItemArray[1].ToString());
            Console.WriteLine("Valor tipo cambio: " + tipoCambio.Tables[0].Rows[0].ItemArray[2].ToString());
            Console.ReadLine();
        }
    }
}