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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CTe.Classes.Informacoes.infCTeNormal.infModals.aereos;
using DFe.Utils;

namespace CTe.Classes.Informacoes.infCTeNormal.infModals
{
    public class aereo : ContainerModal
    {
        [XmlElement(Order = 1)]
        public string nMinu { get; set; }

        [XmlElement(Order = 2)]
        public string nOCA { get; set; }

        [XmlIgnore]
        public DateTime dPrevAereo { get; set; }

        [XmlElement(ElementName = "dPrevAereo", Order = 3)]
        public string ProxydPrevAereo
        {
            get { return dPrevAereo.ParaDataString(); }
            set { dPrevAereo = Convert.ToDateTime(value); }
        }

        [XmlElement(Order = 7)]
        public string xLAgEmi { get; set; }

        [XmlElement(Order = 8)]
        public string IdT { get; set; }

        [XmlElement(Order = 4)]
        public natCarga natCarga { get; set; }

        [XmlElement(Order = 5)]
        public tarifa tarifa { get; set; }

        [XmlElement(ElementName = "peri", Order = 6)]
        public List<aereoPeri> peri { get; set; }
    }
}