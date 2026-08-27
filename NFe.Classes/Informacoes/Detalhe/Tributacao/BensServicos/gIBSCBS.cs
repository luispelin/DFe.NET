using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações do IBS e da CBS
    /// </summary>
    public class gIBSCBS
    {
        private decimal _vBC;
        private decimal _vIBS;

        /// <summary>
        ///     UB16 - Base de cálculo do IBS e CBS (tamanho 13v2)
        /// </summary>
        public decimal vBC
        {
            get { return _vBC.Arredondar(2); }
            set { _vBC = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB17 - Grupo de Informações do IBS para a UF
        /// </summary>
        public gIBSUF gIBSUF { get; set; }

        /// <summary>
        ///     UB36 - Grupo de Informações do IBS para o município
        /// </summary>
        public gIBSMun gIBSMun { get; set; }

        /// <summary>
        ///     UB54a - Valor do IBS (tamanho 13v2)
        /// </summary>
        public decimal vIBS
        {
            get { return _vIBS.Arredondar(2); }
            set { _vIBS = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB55 - Grupo de Informações da CBS
        /// </summary>
        public gCBS gCBS { get; set; }

        /// <summary>
        ///     UB68 - Grupo de informações da Tributação Regular
        /// </summary>
        public gTribRegular gTribRegular { get; set; }

        /// <summary>
        ///     UB82a - Grupo de informações da composição do valor do IBS e da CBS em compras governamentais
        /// </summary>
        public gTribCompraGov gTribCompraGov { get; set; }
    }
}
