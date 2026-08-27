using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Identificacao
{
    // NT2025.002
    /// <summary>
    ///     BB01 - Grupo de notas de antecipação de pagamento
    /// </summary>
    public class gPagAntecipado
    {
        /// <summary>
        ///     BB02 - Chave de acesso da NF-e de antecipação de pagamento
        /// </summary>
        [XmlElement("refNFe")]
        public List<string> refNFe { get; set; }

    }
}
