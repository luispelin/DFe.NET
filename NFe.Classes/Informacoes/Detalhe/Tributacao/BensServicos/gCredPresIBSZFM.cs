using NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos.Tipos;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Informações do crédito presumido de IBS para fornecimentos a partir da ZFM
    /// </summary>
    public class gCredPresIBSZFM
    {
        private decimal? _vCredPresIBSZFM;

        /// <summary>
        ///     UB132 - Ano e mês referência do período de apuração (AAAA-MM) 
        /// </summary>
        public string competApur { get; set; }

        /// <summary>
        ///     UB133 - Tipo de classificação de acordo com o art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido na ZFM
        /// </summary>
        public TipoCredPresIBSZFM tpCredPresIBSZFM { get; set; }

        /// <summary>
        ///     UB134 - Valor do crédito presumido calculado sobre o saldo devedor apurado (tamanho 13v2)
        /// </summary>
        public decimal? vCredPresIBSZFM
        {
            get { return _vCredPresIBSZFM.Arredondar(2); }
            set { _vCredPresIBSZFM = value.Arredondar(2); }
        }

        public bool vCredPresIBSZFMSpecified
        {
            get { return vCredPresIBSZFM.HasValue; }
        }

    }
}
