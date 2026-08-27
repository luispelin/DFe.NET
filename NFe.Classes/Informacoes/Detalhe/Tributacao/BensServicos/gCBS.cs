using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações da CBS 
    /// </summary>
    public class gCBS
    {
        private decimal _pCBS;
        private decimal _vCBS;

        /// <summary>
        ///     UB56 - Alíquota da CBS (tamanho 3v2-4)
        /// </summary>
        public decimal pCBS
        {
            get { return _pCBS; }
            set { _pCBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB59 - Grupo de Informações do Diferimento 
        /// </summary>
        public gDif gDif { get; set; }

        /// <summary>
        ///     UB62 - Grupo de Informações da devolução de tributos
        /// </summary>
        public gDevTrib gDevTrib { get; set; }

        /// <summary>
        ///     UB64 - Grupo de informações da redução da alíquota
        /// </summary>
        public gRed gRed { get; set; }

        /// <summary>
        ///     UB67 - Valor da CBS (tamanho 13v2)
        /// </summary>
        public decimal vCBS
        {
            get { return _vCBS.Arredondar(2); }
            set { _vCBS = value.Arredondar(2); }
        }

    }
}
