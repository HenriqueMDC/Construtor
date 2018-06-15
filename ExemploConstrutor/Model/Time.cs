using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Time
    {
        public int QuantidadeGolsContra { get; set; }

        public int QuantidadeDerrotas { get; set; }

        public int QuantidadeGolsFeitos { get; set; }
        
        public int QuantidadeGolsSofridos {get; set; }

        public int QuantidadeCartoesAmarelos { get; set; }

        public int QuantidadeCartoesVermelho { get; set; }

        public int QuantidadeSubstituisao { get; set; }

        public int QuantidadeFinais { get; set; }

        public int QuantidadeSemiFinais{ get; set; }

        public int QuantidadeVitorias { get; set; }

        public decimal Faturamento { get; set; }

        public string Serie { get; set; }

        public string  Pais { get; set; }

        public string Nome { get; set; }

        public Time(string nome, string pais, string serie)
        {
            Nome = nome;
            Pais = pais;
            Serie = serie;
        }

        public Time(string nome, string serie)
        {
            Nome = nome;
            Serie = serie;
        }
    }
}
