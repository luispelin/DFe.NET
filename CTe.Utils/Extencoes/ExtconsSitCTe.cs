﻿/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
using System;
using System.IO;
using System.Xml;
using CTe.Classes;
using CTe.Classes.Servicos.Consulta;
using CTe.Classes.Servicos.Tipos;
using CTe.Utils.Validacao;
using DFe.Utils;

namespace CTe.Utils.Extencoes
{
    public static class ExtconsSitCTe
    {

        public static void ValidarSchema(this consSitCTe consSitCTe, ConfiguracaoServico configuracaoServico = null)
        {
            var xmlValidacao = consSitCTe.ObterXmlString();

            switch (consSitCTe.versao)
            {
                case versao.ve200:
                    Validador.Valida(xmlValidacao, "consSitCTe_v2.00.xsd", configuracaoServico);
                    break;
                case versao.ve300:
                    Validador.Valida(xmlValidacao, "consSitCTe_v3.00.xsd", configuracaoServico);
                    break;
                case versao.ve400:
                    Validador.Valida(xmlValidacao, "consSitCTe_v4.00.xsd", configuracaoServico);
                    break;
                default: throw new InvalidOperationException("Nos achamos um erro na hora de validar o schema, " +
                                                        "a versão está inválida, somente é permitido " +
                                                        "versão 2.00, 3.00 e 4.00");
            }
        }

        /// <summary>
        ///     Converte o objeto consSitCTe para uma string no formato XML
        /// </summary>
        /// <param name="pedConsulta"></param>
        /// <returns>Retorna uma string no formato XML com os dados do objeto consSitCTe</returns>
        public static string ObterXmlString(this consSitCTe pedConsulta)
        {
            return FuncoesXml.ClasseParaXmlString(pedConsulta);
        }

        public static void SalvarXmlEmDisco(this consSitCTe statuServCte, ConfiguracaoServico configuracaoServico = null)
        {
            var instanciaServico = configuracaoServico ?? ConfiguracaoServico.Instancia;

            if (instanciaServico.NaoSalvarXml()) return;

            var caminhoXml = instanciaServico.DiretorioSalvarXml;

            var arquivoSalvar = Path.Combine(caminhoXml, "-ped-sit.xml");

            FuncoesXml.ClasseParaArquivoXml(statuServCte, arquivoSalvar);
        }

        public static XmlDocument CriaRequestWs(this consSitCTe consStatServMdFe)
        {
            var request = new XmlDocument();
            request.LoadXml(consStatServMdFe.ObterXmlString());

            return request;
        }
    }
}