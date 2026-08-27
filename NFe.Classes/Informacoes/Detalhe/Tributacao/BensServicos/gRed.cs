using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de informações da redução da alíquota
    /// </summary>
    public class gRed
    {
        private decimal _pRedAliq;
        private decimal _pAliEfet;

        /// <summary>
        ///     Percentual da redução de alíquota do cClassTrib (UB27, UB46, UB65) (tamanho 3v2-4)
        /// </summary>
        public decimal pRedAliq
        {
            get { return _pRedAliq; }
            set { _pRedAliq = value.Arredondar(4); }
        }

        /// <summary>
        ///     Alíquota Efetiva do IBS de competência das UF que será aplicada a Base de Cálculo (UB28, UB47) (tamanho 3v2-4)
        ///     Alíquota Efetiva da CBS que será aplicada a Base de Cálculo (UB66) (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqEfet
        {
            get { return _pAliEfet; }
            set { _pAliEfet = value.Arredondar(4); }
        }
    }
}
