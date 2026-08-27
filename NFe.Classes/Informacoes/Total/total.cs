/********************************************************************************/
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
namespace NFe.Classes.Informacoes.Total
{
    public class total
    {
        private decimal? _vNFTot;

        /// <summary>
        ///     W02 - Grupo Totais referentes ao ICMS
        /// </summary>
        public ICMSTot ICMSTot { get; set; }

        /// <summary>
        ///     W17 - Grupo Totais referentes ao ISSQN
        /// </summary>
        public ISSQNtot ISSQNtot { get; set; }

        /// <summary>
        ///     W23 - Grupo Retenções de Tributos
        /// </summary>
        public retTrib retTrib { get; set; }

        // NT2025.002
        #region grupo W03

        // NT2025.002
        /// <summary>
        /// Grupo total do imposto seletivo 
        /// O grupo de valores totais da NF-e deve ser informado com o somatório do campo correspondente dos itens.
        /// O IS é “por fora”, por isso seu valor deve ser adicionado ao valor total da NF.
        /// </summary>
        public ISTot ISTot { get; set; }

        // NT2025.002
        /// <summary>
        /// Totais da NF-e com IBS e CBS 
        /// O grupo de valores totais da NF-e deve ser informado com o somatório do campo correspondente dos itens.
        /// O IBS e a CBS são “por fora”, por isso seus valores devem ser adicionados ao valor total da NF.
        /// </summary>
        public IBSCBSTot IBSCBSTot { get; set; }

        /// <summary>
        ///     W60 - Valor total da NF-e com IBS / CBS / IS (tamanho 13v2)
        /// </summary>
        public decimal? vNFTot
        {
            get { return _vNFTot.Arredondar(2); }
            set { _vNFTot = value.Arredondar(2); }
        }

        public bool vNFTotSpecified
        {
            get { return vNFTot.HasValue; }
        }

        #endregion //grupo W03
    }
}