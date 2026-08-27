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
    /// Grupo de informações da Tributação Regular
    /// </summary>
    public class gTribRegular
    {
        private decimal _pAliqEfetRegIBSUF;
        private decimal _vTribRegIBSUF;
        private decimal _pAliqEfetRegIBSMun;
        private decimal _vTribRegIBSMun;
        private decimal _pAliqEfetRegCBS;
        private decimal _vTribRegCBS;

        /// <summary>
        ///     UB69 - Código de Situação Tributária do IBS e CBS
        /// </summary>
        public CstIBSCBS CSTReg { get; set; }

        /// <summary>
        ///     UB70 - Código de Classificação Tributária do IBS e CBS
        /// </summary>
        public cClassTribIBSCBS cClassTribReg { get; set; }

        /// <summary>
        ///     UB71 - Valor da alíquota do IBS da UF (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqEfetRegIBSUF
        {
            get { return _pAliqEfetRegIBSUF; }
            set { _pAliqEfetRegIBSUF = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB72 - Valor do Tributo do IBS da UF (tamanho 13v2)
        /// </summary>
        public decimal vTribRegIBSUF
        {
            get { return _vTribRegIBSUF.Arredondar(2); }
            set { _vTribRegIBSUF = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB72a - Valor da alíquota do IBS do Município (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqEfetRegIBSMun
        {
            get { return _pAliqEfetRegIBSMun; }
            set { _pAliqEfetRegIBSMun = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB72b - Valor do Tributo do IBS do Município (tamanho 13v2)
        /// </summary>
        public decimal vTribRegIBSMun
        {
            get { return _vTribRegIBSMun.Arredondar(2); }
            set { _vTribRegIBSMun = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB72c - Valor da alíquota da CBS (tamanho 3v2-4)
        /// </summary>
        public decimal pAliqEfetRegCBS
        {
            get { return _pAliqEfetRegCBS; }
            set { _pAliqEfetRegCBS = value.Arredondar(4); }
        }

        /// <summary>
        ///     UB72d - Valor do Tributo da CBS (tamanho 13v2)
        /// </summary>
        public decimal vTribRegCBS
        {
            get { return _vTribRegCBS.Arredondar(2); }
            set { _vTribRegCBS = value.Arredondar(2); }
        }

    }
}
