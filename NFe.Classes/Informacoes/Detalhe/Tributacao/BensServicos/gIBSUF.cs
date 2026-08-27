using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações do IBS para a UF
    /// </summary>
    public class gIBSUF
    {
        private decimal _pIBSUF;
        private decimal _vIBSUF;

        /// <summary>
        ///     UB18 - Alíquota do IBS de competência das UF (tamanho 3v2-4)
        /// </summary>
        public decimal pIBSUF
        {
            get { return _pIBSUF; }
            set { _pIBSUF = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB21 - Grupo de Informações do Diferimento
        /// </summary>
        public gDif gDif { get; set; }

        /// <summary>
        ///     UB24 - Grupo de Informações da devolução de tributos
        /// </summary>
        public gDevTrib gDevTrib { get; set; }

        /// <summary>
        ///     UB26 - Grupo de informações da redução da alíquota
        /// </summary>
        public gRed gRed { get; set; }

        /// <summary>
        ///     UB35 - Valor do IBS de competência da UF (tamanho 13v2)
        /// </summary>
        public decimal vIBSUF
        {
            get { return _vIBSUF.Arredondar(2); }
            set {  _vIBSUF = value.Arredondar(2); }
        }
    }
}
