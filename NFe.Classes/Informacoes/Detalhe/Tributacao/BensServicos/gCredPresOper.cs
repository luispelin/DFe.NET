using NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002 v1.30
    /// <summary>
    /// Crédito Presumido da Operação
    /// </summary>
    public class gCredPresOper
    {
        private decimal _vBCCredPres;

        /// <summary>
        ///     UB121 - Valor da Base de Cálculo do Crédito Presumido da Operação (tamanh 13v2)
        /// </summary>
        public decimal vBCCredPres
        {
            get { return _vBCCredPres.Arredondar(2); }
            set { _vBCCredPres = value.Arredondar(2); }
        }

        /// <summary>
        ///     UB122 - Código de Classificação do Crédito Presumido
        /// </summary>
        public cClassPresIBSCBS cCredPres { get; set; }

        /// <summary>
        ///     UB123 - Grupo de Informações do Crédito Presumido referente ao IBS
        /// </summary>
        public gIBSCBSCredPres gIBSCredPres { get; set; }

        /// <summary>
        ///     UB127 - Grupo de Informações do Crédito Presumido referente a CBS
        /// </summary>
        public gIBSCBSCredPres gCBSCredPres { get; set; }

    }
}
