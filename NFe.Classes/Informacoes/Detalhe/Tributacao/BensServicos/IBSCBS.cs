using NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos.Tipos;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    ///     Informações do Imposto de Bens e Serviços - IBS e da Contribuição de Bens e Serviços - CBS
    /// </summary>
    public class IBSCBS
    {
        /// <summary>
        ///     UB13 - Código de Situação Tributária do IBS e CBS
        /// </summary>
        public CstIBSCBS CST { get; set; }

        /// <summary>
        ///     UB14 - Código de Classificação Tributária do IBS e CBS
        /// </summary>
        public cClassTribIBSCBS cClassTrib { get; set; }

        /// <summary>
        ///     UB14a - Indica a natureza da operação de doação, orientando a apuração e a geração de débitos ou estornos conforme o cenário
        ///     Informar quando doação 
        /// </summary>
        public string indDoacao { get; set; }

        // grupo UB14k (pai UB12) NT2025.002 v1.30
        #region UB14k

        /// <summary>
        ///     UB15 - Grupo de Informações do IBS e da CBS
        /// </summary>
        public gIBSCBS gIBSCBS { get; set; }

        /// <summary>
        ///     UB84 - Grupo de Informações do IBS e CBS em operações com imposto monofásico
        /// </summary>
        public gIBSCBSMono gIBSCBSMono { get; set; }

        /// <summary>
        ///     UB106 - Transferências de Crédito
        /// </summary>
        public gTransfCred gTransfCred { get; set; }

        // NT2025.002 v1.30
        /// <summary>
        ///     UB112 - Ajuste de Competência
        /// </summary>
        public gAjusteCompet gAjusteCompet { get; set; }

        #endregion //UB14k

        // NT2025.002 v1.30
        /// <summary>
        ///     UB116 - Estorno de Crédito 
        /// </summary>
        public gEstornoCred gEstornoCred { get; set; }

        // grupo UB119 (pai UB12)
        #region UB119

        /// <summary>
        ///     UB120 - Crédito Presumido da Operação
        /// </summary>
        public gCredPresOper gCredPresOper { get; set; }

        /// <summary>
        ///     UB131 - Grupo para apropriação de crédito presumido de IBS sobre o saldo devedor na ZFM(art. 450, § 1º, LC 214/25)
        /// </summary>
        public gCredPresIBSZFM gCredPresIBSZFM { get; set; }

        #endregion //UB119
    }
}
