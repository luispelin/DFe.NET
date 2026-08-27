using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de informações da Tributação Monofásica Retida Anteriormente
    /// </summary>
    public class gMonoRet
    {
        private decimal _qBCMonoRet;
        private decimal _adRemIBSRet;
        private decimal _vIBSMonoRet;
        private decimal _adRemCBSRet;
        private decimal _vCBSMonoRet;

        /// <summary>
        ///     UB95 - Quantidade tributada retida anteriormente (tamanho 11v0-4)
        /// </summary>
        public decimal qBCMonoRet
        {
            get { return _qBCMonoRet; }
            set { _qBCMonoRet = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB96 - Alíquota ad rem do IBS retido anteriormente (tamanho 3v2-4)
        /// </summary>
        public decimal adRemIBSRet
        {
            get { return _adRemIBSRet; }
            set { _adRemIBSRet = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB97 - Valor do IBS retido anteriormente (tamanho 13v2)
        /// </summary>
        public decimal vIBSMonoRet
        {
            get { return _vIBSMonoRet.Arredondar(2); }
            set { _vIBSMonoRet = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB98 - Alíquota ad rem da CBS retida anteriormente (tamanho 3v2-4)
        /// </summary>
        public decimal adRemCBSRet
        {
            get { return _adRemCBSRet; }
            set { _adRemCBSRet = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB98a - Valor da CBS retida anteriormente (tamanho 13v2)
        /// </summary>
        public decimal vCBSMonoRet
        {
            get { return _vCBSMonoRet.Arredondar(2); }
            set { _vCBSMonoRet = value.Arredondar(2); }
        }

    }
}
