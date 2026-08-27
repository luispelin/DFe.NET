using NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos.Tipos;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    ///     Informações do Imposto Seletivo 
    /// </summary>
    public class IS
    {
        private decimal _vBCIS;
        private decimal _pIS;
        private decimal? _pISEspec;
        private decimal _qTrib;
        private decimal _vIS;

        /// <summary>
        ///     UB02 - Código de Situação Tributária do Imposto Seletivo
        /// </summary>
        public CstIS CSTIS { get; set; }

        /// <summary>
        ///     UB03 - Código de Classificação Tributária do Imposto Seletivo
        /// </summary>
        public cClassTribIS cClassTribIS { get; set; }

        // grupo UB04 (pai UB01 - IS)
        #region UB04

        /// <summary>
        ///     UB05 - Valor da Base de Cálculo do Imposto Seletivo (tamanho 13v2)
        /// </summary>
        public decimal vBCIS
        {
            get { return _vBCIS.Arredondar(2); }
            set { _vBCIS = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB06 - Alíquota do Imposto Seletivo (tamanho 3v2-4)
        /// </summary>
        public decimal pIS
        {
            get { return _pIS; }
            set { _pIS = value.Arredondar(4); }
        }


        /// <summary>
        ///     UB07 - Alíquota específica por unidade de medida apropriada (tamanho 3v2-4)
        /// </summary>
        public decimal? pISEspec
        {
            get { return _pISEspec; }
            set { _pISEspec = value.Arredondar(4); }
        }

        public bool pISEspecSpecified
        {
            get { return pISEspec.HasValue; }
        }


        // grupo UB08 (pai UB04)
        #region UB08

        /// <summary>
        ///     UB09 - Unidade de Medida Tributável
        /// </summary>
        public string uTrib { get; set; }

        /// <summary>
        ///     UB10 - Quantidade Tributável (tamanho 11v0-4)
        /// </summary>
        public decimal qTrib
        {
            get { return _qTrib; }
            set { _qTrib = value.Arredondar(4); }
        }


        /// <summary>
        ///     UB11 - Valor do Imposto Seletivo (tamanho 13v2)
        /// </summary>
        public decimal vIS
        {
            get { return _vIS.Arredondar(2); }
            set { _vIS = value.Arredondar(2); }
        }

        #endregion //UB08

        #endregion //UB04

    }
}
