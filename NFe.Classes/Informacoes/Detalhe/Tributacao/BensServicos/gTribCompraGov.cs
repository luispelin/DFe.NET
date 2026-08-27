using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de informações da composição do valor do IBS e da CBS em compras governamentais
    /// </summary>
    public class gTribCompraGov
    {
        private decimal _pAliqIBSUF;
        private decimal _vTribIBSUF;
        private decimal _pAliqIBSMun;
        private decimal _vTribIBSMun;
        private decimal _pAliqCBS;
        private decimal _vTribCBS;

        /// <summary>
        ///     UB82b - Alíquota do IBS de competência do Estado (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqIBSUF
        {
            get { return _pAliqIBSUF; }
            set { _pAliqIBSUF = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB82c - Valor do Tributo do IBS da UF calculado (tamanho 13v2)
        /// </summary>
        public decimal vTribIBSUF
        {
            get { return _vTribIBSUF.Arredondar(2); }
            set { _vTribIBSUF = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB82d - Alíquota do IBS de competência do Município (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqIBSMun
        {
            get { return _pAliqIBSMun; }
            set { _pAliqIBSMun = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB82e - Valor do Tributo do IBS do Município calculado (tamanho 13v2)
        /// </summary>
        public decimal vTribIBSMun
        {
            get { return _vTribIBSMun.Arredondar(2); }
            set { _vTribIBSMun = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB82f - Alíquota da CBS (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqCBS
        {
            get { return _pAliqCBS; }
            set { _pAliqCBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB82g - Valor do Tributo da CBS calculado (tamanho 13v2)
        /// </summary>
        public decimal vTribCBS
        {
            get { return _vTribCBS.Arredondar(2); }
            set { _vTribCBS = value.Arredondar(2); }
        }

    }
}
