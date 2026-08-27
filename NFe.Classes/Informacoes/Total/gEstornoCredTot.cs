using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT 2025.002 v1.30
    /// <summary>
    /// Grupo total do Estorno de Crédito
    /// </summary>
    public class gEstornoCredTot
    {
        private decimal _vIBSEstCred;
        private decimal _vCBSEstCred;

        /// <summary>
        ///     W59f - Valor total do IBS estornado (tamanho 13v2)
        /// </summary>
        public decimal vIBSEstCred
        {
            get { return _vIBSEstCred.Arredondar(2); }
            set { _vIBSEstCred = value.Arredondar(2); }
        }

        /// <summary>
        ///     W59g - Valor total da CBS estornada (tamanho 13v2)
        /// </summary>
        public decimal vCBSEstCred
        {
            get { return _vCBSEstCred.Arredondar(2); }
            set { _vCBSEstCred = value.Arredondar(2); }
        }

    }
}
