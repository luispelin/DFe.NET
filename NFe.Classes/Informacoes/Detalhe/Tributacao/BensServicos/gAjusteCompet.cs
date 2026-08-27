using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002 v1.30
    /// <summary>
    /// Ajuste de Competência
    /// </summary>
    public class gAjusteCompet
    {
        private decimal _vIBS;
        private decimal _vCBS;

        /// <summary>
        ///     UB113 - Ano e mês referência do período de apuração (AAAA-MM) 
        /// </summary>
        public string competApur { get; set; }

        /// <summary>
        ///     UB114 - Valor do IBS (tamanho 13v2)
        /// </summary>
        public decimal vIBS
        {
            get { return _vIBS.Arredondar(2); }
            set { _vIBS = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB115 - valor da CBS (tamanho 13v2)
        /// </summary>
        public decimal vCBS
        {
            get { return _vCBS.Arredondar(2); }
            set { _vCBS = value.Arredondar(2); }
        }

    }
}
