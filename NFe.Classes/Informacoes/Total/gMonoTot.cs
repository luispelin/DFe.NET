using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Grupo total da Monofasia 
    /// </summary>
    public class gMonoTot
    {
        private decimal _vIBSMono;
        private decimal _vCBSMono;
        private decimal _vIBSMonoReten;
        private decimal _vCBSMonoReten;
        private decimal _vIBSMonoRet;
        private decimal _vCBSMonoRet;

        /// <summary>
        ///     W58 - Total do IBS monofásico (tamanho 13v2)
        /// </summary>
        public decimal vIBSMono
        {
            get { return _vIBSMono.Arredondar(2); }
            set { _vIBSMono = value.Arredondar(2); }
        }

        /// <summary>
        ///     W59 - Total da CBS monofásica (tamanho 13v2)
        /// </summary>
        public decimal vCBSMono
        {
            get { return _vCBSMono.Arredondar(2); }
            set { _vCBSMono = value.Arredondar(2); }
        }

        /// <summary>
        ///     W59a - Total do IBS monofásico sujeito a retenção (tamanho 13v2)
        /// </summary>
        public decimal vIBSMonoReten
        {
            get { return _vIBSMonoReten.Arredondar(2); }
            set { _vIBSMonoReten = value.Arredondar(2); }
        }

        /// <summary>
        ///     W59b - Total da CBS monofásica sujeita a retenção (tamanho 13v2)
        /// </summary>
        public decimal vCBSMonoReten
        {
            get { return _vCBSMonoReten.Arredondar(2); }
            set { _vCBSMonoReten = value.Arredondar(2); }
        }

        /// <summary>
        ///     W59c - Total do IBS monofásico retido anteriormente (tamanho 13v2)
        /// </summary>
        public decimal vIBSMonoRet
        {
            get { return _vIBSMonoRet.Arredondar(2); }
            set { _vIBSMonoRet = value.Arredondar(2); }
        }

        /// <summary>
        ///     W59d - Total da CBS monofásica retida anteriormente (tamanho 13v2)
        /// </summary>
        public decimal vCBSMonoRet
        {
            get { return _vCBSMonoRet.Arredondar(2); }
            set { _vCBSMonoRet = value.Arredondar(2); }
        }

    }
}
