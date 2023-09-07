using System.IO;
using CTe.Classes;
using CTe.Classes.Servicos.Recepcao;
using DFe.Utils;

namespace CTe.Utils.Recepcao
{
    public static class ExtRetCTe
    {
        /// <summary>
        ///     Coverte uma string XML no formato CTe para um objeto retCte
        /// </summary>
        /// <param name="retCte"></param>
        /// <param name="xmlString"></param>
        /// <returns>Retorna um objeto do tipo retCte</returns>
        public static retCTe CarregarDeXmlString(this retCTe retCte, string xmlString)
        {
            return FuncoesXml.XmlStringParaClasse<retCTe>(xmlString);
        }

        /// <summary>
        ///     Converte o objeto retEnviCte para uma string no formato XML
        /// </summary>
        /// <param name="retCte"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto retCte</returns>
        public static string ObterXmlString(this retCTe retCte)
        {
            return FuncoesXml.ClasseParaXmlString(retCte);
        }

        public static void SalvarXmlEmDisco(this retCTe retCTe, ConfiguracaoServico configuracaoServico = null)
        {
            var instanciaServico = configuracaoServico ?? ConfiguracaoServico.Instancia;

            if (instanciaServico.NaoSalvarXml()) return;

            var caminhoXml = instanciaServico.DiretorioSalvarXml;

            var arquivoSalvar = Path.Combine(caminhoXml, retCTe.protCTe.infProt.nProt + "-prot.xml");

            FuncoesXml.ClasseParaArquivoXml(retCTe, arquivoSalvar);
        }
    }
}
