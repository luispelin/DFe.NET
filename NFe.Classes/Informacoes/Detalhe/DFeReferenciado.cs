using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe
{
    // NT2025.002
    /// <summary>
    /// Documento Fiscal Eletrônico Referenciado 
    /// </summary>
    public class DFeReferenciado
    {
        /// <summary>
        ///     VC02 - Chave de acesso do DF-e referenciado
        /// </summary>
        public string chaveAcesso { get; set; }

        /// <summary>
        ///     VC03 - Número do item do documento referenciado
        ///     Corresponde ao atributo “nItem” do elemento “det” do documento original
        /// </summary>
        public int? nItem { get; set; }

        public bool nItemSpecified
        {
            get { return nItem.HasValue; }
        }

    }
}
