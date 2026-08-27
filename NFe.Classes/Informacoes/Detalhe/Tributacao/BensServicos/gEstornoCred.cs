using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT 2025.002 v1.30
    /// <summary>
    /// Estorno de Crédito 
    /// Observação: a obrigatoriedade ou vedação do preenchimento deste grupo está condicionada
    ///     ao indicador “ind_gEstornoCred” da tabela de cClassTrib do IBS e da CBS.
    /// </summary>
    public class gEstornoCred
    {
        private decimal _vIBSEstCred;
        private decimal _vCBSEstCred;

        /// <summary>
        ///     UB117 - Valor do IBS a ser estornado (tamanho 13v2)
        /// </summary>
        public decimal vIBSEstCred
        {
            get { return _vIBSEstCred.Arredondar(2); }
            set { _vIBSEstCred = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB118 - Valor da CBS a ser estornada (tamanho 13v2)
        /// </summary>
        public decimal vCBSEstCred
        {
            get { return _vCBSEstCred.Arredondar(2); }
            set { _vCBSEstCred = value.Arredondar(2); }
        }

    }
}
