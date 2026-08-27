using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Transferências de Crédito
    /// </summary>
    public class gTransfCred
    {
        private decimal _vIBS;
        private decimal _vCBS;

        /// <summary>
        ///     UB107 - Valor do IBS a ser transferido (tamanho 13v2)
        /// </summary>
        public decimal vIBS
        {
            get { return _vIBS.Arredondar(2); }
            set { _vIBS = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB108 - Valor da CBS a ser transferida (tamanho 13v2)
        /// </summary>
        public decimal vCBS
        {
            get { return _vCBS.Arredondar(2); }
            set { _vCBS = value.Arredondar(2); }
        }

    }
}
