using NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações do Crédito Presumido referente ao IBS
    /// </summary>
    public class gIBSCBSCredPres
    {
        private decimal _pCredPres;
        private decimal _vCredPres;
        private decimal _vCredPresCondSus;

        /// <summary>
        ///     Percentual do Crédito Presumido (UB124, UB128) (tamanho 3v2-4)
        /// </summary>
        public decimal pCredPres
        {
            get { return _pCredPres; }
            set { _pCredPres = value.Arredondar(4); }
        }

        /// <summary>
        ///     Valor do Crédito Presumido (UB125, UB129) (tamanho 13v2)
        /// </summary>
        public decimal vCredPres
        {
            get { return _vCredPres.Arredondar(2); }
            set { _vCredPres = value.Arredondar(2); }
        }

        /// <summary>
        ///     Valor do Crédito Presumido em condição suspensiva (UB126, UB130) (tamanho 13v2)
        /// </summary>
        public decimal vCredPresCondSus
        {
            get { return _vCredPresCondSus.Arredondar(2); }
            set { _vCredPresCondSus = value.Arredondar(2); }
        }

    }
}
