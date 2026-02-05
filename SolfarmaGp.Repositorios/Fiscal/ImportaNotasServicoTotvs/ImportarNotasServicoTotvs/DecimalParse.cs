using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ImportarNotasServicoTotvs
{
    public class DecimalParse
    {
        
            public static decimal ParseDecimal(object value)
            {
                if (value == DBNull.Value) return 0;

                string s = value.ToString();

                // Se tiver vírgula, usa cultura pt-BR
                if (s.Contains(","))
                    return decimal.Parse(s, new CultureInfo("pt-BR"));

                // Se tiver ponto, usa cultura Invariant
                return decimal.Parse(s, CultureInfo.InvariantCulture);
            }

       
    }
}
