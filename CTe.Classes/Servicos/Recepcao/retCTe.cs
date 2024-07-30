using System.Xml.Serialization;
using CTe.Classes.Protocolo;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using CteEletronica = CTe.Classes.CTe;

namespace CTe.Classes.Servicos.Recepcao
{
    /// <summary>
    /// retCTe: BR01 - TAG raiz da Resposta 
    /// </summary>
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/cte")]
    public class retCTe : RetornoBase
    {
        /// <summary>
        ///     BR02 - Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        ///     BR03 - Identificação do Ambiente: 1 – Produção / 2 - Homologação
        /// </summary>
        public TipoAmbiente tpAmb { get; set; }

        /// <summary>
        ///     BR04 - Código da UF que atendeu a solicitação.
        /// </summary>
        public Estado cUF { get; set; }

        /// <summary>
        ///     BR05 - Versão do Aplicativo que recebeu o CTe. 
        /// </summary>
        public string verAplic { get; set; }

        /// <summary>
        ///     BR06 - Código do status da resposta
        /// </summary>
        public int cStat { get; set; }

        /// <summary>
        ///     BR07 - Descrição literal do status da resposta
        /// </summary>
        public string xMotivo { get; set; }

        /// <summary>
        ///     BR08 - Resposta ao processamento do CTe 
        /// </summary>
        public protCTe protCTe { get; set; }


        public static retCTe LoadXml(string xml)
        {
            var retorno = FuncoesXml.XmlStringParaClasse<retCTe>(xml);
            retorno.RetornoXmlString = xml;
            return retorno;
        }

        public static retCTe LoadXml(string xml, CteEletronica cte)
        {
            var retorno = LoadXml(xml);
            retorno.EnvioXmlString = FuncoesXml.ClasseParaXmlString(cte);
            return retorno;
        }
    }
}
