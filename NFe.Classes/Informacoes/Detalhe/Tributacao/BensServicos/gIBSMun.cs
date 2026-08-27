using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações do IBS para o município
    /// </summary>
    public class gIBSMun
    {
        private decimal _pIBSMun;
        private decimal _vIBSMun;

        /// <summary>
        ///     UB37 - Alíquota do IBS de competência do Município (tamanho 3v2-4)
        /// </summary>
        public decimal pIBSMun
        {
            get { return _pIBSMun; }
            set { _pIBSMun = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB40 - Grupo de Informações do Diferimento
        /// </summary>
        public gDif gDif { get; set; }

        /// <summary>
        ///     UB43 - Grupo de Informações da devolução de tributos
        /// </summary>
        public gDevTrib gDevTrib { get; set; }

        /// <summary>
        ///     UB45 - Grupo de informações da redução da alíquota
        /// </summary>
        public gRed gRed { get; set; }

        /// <summary>
        ///     UB54 - Valor do IBS de competência do Município (tamanho 13v2)
        /// </summary>
        public decimal vIBSMun
        {
            get { return _vIBSMun.Arredondar(2); }
            set { _vIBSMun = value.Arredondar(2); }
        }

    }
}
