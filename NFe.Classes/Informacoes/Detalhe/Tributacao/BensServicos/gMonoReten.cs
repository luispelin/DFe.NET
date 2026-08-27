using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de informações da Tributação Monofásica Sujeita à Retenção
    /// </summary>
    public class gMonoReten
    {
        private decimal _qBCMonoReten;
        private decimal _adRemIBSReten;
        private decimal _vIBSMonoReten;
        private decimal _adRemCBSReten;
        private decimal _vCBSMonoReten;

        /// <summary>
        ///     UB91 - Quantidade tributada sujeita à retenção na monofasia (tamanho 11v0-4)
        /// </summary>
        public decimal qBCMonoReten
        {
            get { return _qBCMonoReten; }
            set { _qBCMonoReten = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB92 - Alíquota ad rem do IBS sujeito a retenção (tamanho 3v2-4)
        /// </summary>
        public decimal adRemIBSReten
        {
            get { return _adRemIBSReten; }
            set { _adRemIBSReten = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB93 - Valor do IBS monofásico sujeito a retenção (tamanho 13v2)
        /// </summary>
        public decimal vIBSMonoReten
        {
            get { return _vIBSMonoReten.Arredondar(2); }
            set { _vIBSMonoReten = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB93a - Alíquota ad rem da CBS sujeito a retenção (tamanho 3v2-4)
        /// </summary>
        public decimal adRemCBSReten
        {
            get { return _adRemCBSReten; }
            set { _adRemCBSReten = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB93b - Valor da CBS monofásica sujeita a retenção (tamanho 13v2)
        /// </summary>
        public decimal vCBSMonoReten
        {
            get { return _vCBSMonoReten.Arredondar(2); }
            set { _vCBSMonoReten = value.Arredondar(2); }
        }

    }
}
