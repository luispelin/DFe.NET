using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de informações do Diferimento da Tributação Monofásica
    /// </summary>
    public class gMonoDif
    {
        private decimal _pDifIBS;
        private decimal _vIBSMonoDif;
        private decimal _pDifCBS;
        private decimal _vCBSMonoDif;

        /// <summary>
        ///     UB100 - Percentual do diferimento do imposto monofásico (tamanho 3v2-4)
        /// </summary>
        public decimal pDifIBS
        {
            get { return _pDifIBS; }
            set { _pDifIBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB101 - Valor do IBS monofásico diferido (tamanho 13v2)
        /// </summary>
        public decimal vIBSMonoDif
        {
            get { return _vIBSMonoDif.Arredondar(2); }
            set { _vIBSMonoDif = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB102 - Percentual do diferimento do imposto monofásico (tamanho 3v2-4)
        /// </summary>
        public decimal pDifCBS
        {
            get { return _pDifCBS; }
            set { _pDifCBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB103 - Valor da CBS Monofásica diferida (tamanho 13v2)
        /// </summary>
        public decimal vCBSMonoDif
        {
            get { return _vCBSMonoDif.Arredondar(2); }
            set { _vCBSMonoDif = value.Arredondar(2); }
        }

    }
}
