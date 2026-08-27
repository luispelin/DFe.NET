using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Totais da NF-e com IBS e CBS 
    /// O grupo de valores totais da NF-e deve ser informado com o somatório do campo correspondente dos itens.
    /// O IBS e a CBS são “por fora”, por isso seus valores devem ser adicionados ao valor total da NF.
    /// </summary>
    public class IBSCBSTot
    {
        private decimal _vBCIBSCBS;

        /// <summary>
        ///     W35 - Valor total da BC do IBS e da CBS (tamanho 13v2)
        /// </summary>
        public decimal vBCIBSCBS
        {
            get { return _vBCIBSCBS.Arredondar(2); }
            set { _vBCIBSCBS = value.Arredondar(2); }
        }

        /// <summary>
        ///     W36 - Grupo total do IBS
        /// </summary>
        public gIBSTot gIBS { get; set; }

        /// <summary>
        ///     W50 - Grupo total da CBS
        /// </summary>
        public gCBSTot gCBS { get; set; }

        /// <summary>
        ///     W57 - Grupo total da Monofasia 
        /// </summary>
        public gMonoTot gMono { get; set; }

        // NT2025.002 v1.30
        /// <summary>
        ///     W59e - Grupo total do Estorno de Crédito
        /// </summary>
        public gEstornoCredTot gEstornoCred { get; set; }

    }
}
