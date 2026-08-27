using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de informações da Tributação Monofásica Padrão
    /// </summary>
    public class gMonoPadrao
    {
        private decimal _qBCMono;
        private decimal _adRemIBS;
        private decimal _adRemCBS;
        private decimal _vIBSMono;
        private decimal _vCBSMono;

        /// <summary>
        ///     UB85 - Quantidade tributada na monofasia (tamanho 11v0-4)
        /// </summary>
        public decimal qBCMono
        {
            get { return _qBCMono; }
            set { _qBCMono = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB86 - Alíquota ad rem do IBS (tamanho 3v2-4)
        /// </summary>
        public decimal adRemIBS
        {
            get { return _adRemIBS; }
            set { _adRemIBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB87 - Alíquota ad rem da CBS (tamanho 3v2-4)
        /// </summary>
        public decimal adRemCBS
        {
            get { return _adRemCBS; }
            set { _adRemCBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB88 - Valor do IBS monofásico (tamanho 13v2)
        /// </summary>
        public decimal vIBSMono
        {
            get { return _vIBSMono.Arredondar(2); }
            set { _vIBSMono = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB89 - Valor da CBS monofásica (tamanho 13v2)
        /// </summary>
        public decimal vCBSMono
        {
            get { return _vCBSMono.Arredondar(2); }
            set { _vCBSMono = value.Arredondar(2); }
        }

    }
}
