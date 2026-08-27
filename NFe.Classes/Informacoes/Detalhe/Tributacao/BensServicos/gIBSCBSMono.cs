using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações do IBS e CBS em operações com imposto monofásico
    /// </summary>
    public class gIBSCBSMono
    {
        private decimal _vTotIBSMonoItem;
        private decimal _vTotCBSMonoItem;

        /// <summary>
        ///     UB84a - Grupo de informações da Tributação Monofásica Padrão
        /// </summary>
        public gMonoPadrao gMonoPadrao { get; set; }

        /// <summary>
        ///     UB90 - Grupo de informações da Tributação Monofásica Sujeita à Retenção
        /// </summary>
        public gMonoReten gMonoReten { get; set; }

        /// <summary>
        ///     UB94 - Grupo de informações da Tributação Monofásica Retida Anteriormente
        /// </summary>
        public gMonoRet gMonoRet { get; set; }

        /// <summary>
        ///     UB99 - Grupo de informações do Diferimento da Tributação Monofásica
        /// </summary>
        public gMonoDif gMonoDif { get; set; }

        /// <summary>
        ///     UB104 - Total de IBS Monofásico (tamanho 13v2)
        /// </summary>
        public decimal vTotIBSMonoItem
        {
            get { return _vTotIBSMonoItem.Arredondar(2); }
            set { _vTotIBSMonoItem = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB105 - Total da CBS Monofásica (tamanho 13v2)
        /// </summary>
        public decimal vTotCBSMonoItem
        {
            get { return _vTotCBSMonoItem.Arredondar(2); }
            set { _vTotCBSMonoItem = value.Arredondar(2); }
        }

    }
}
