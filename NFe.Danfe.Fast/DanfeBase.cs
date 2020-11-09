
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
using System.IO;
using FastReport;
using FastReport.Export.Image;
using NFe.Danfe.Base;
using System.Collections.Generic;
using System.IO;

namespace NFe.Danfe.Fast
{
	public class DanfeBase: IDanfe
    {
        public Report Relatorio { get; protected set; }

        /// <summary>
        /// Abre a janela de visualização do DANFE da NFCe
        /// </summary>
        /// <param name="modal">Se true, exibe a visualização em Modal. O modo modal está disponível apenas para WinForms</param>
        public void Visualizar(bool modal = true)
        {
			// Este m�todo n�o ser� �til para o SINFe e � muito complicado de migrar para a nova vers�o do FastReport
            //Relatorio.Show(modal);
        }

        /// <summary>
        ///  Abre a janela de visualização do design do DANFE da NFCe.
        /// Chame esse método se desja fazer alterações no design do DANFE em modo run-time
        /// </summary>
        /// <param name="modal">Se true, exibe a visualização em Modal. O modo modal está disponível apenas para WinForms</param>
        public void ExibirDesign(bool modal = false)
        {
			// Este m�todo n�o ser� �til para o SINFe e � muito complicado de migrar para a nova vers�o do FastReport
			//Relatorio.Design(modal);
		}

		/// <summary>
		/// Envia a impress�o do DANFE da NFCe diretamente para a impressora
		/// </summary>
		/// <param name="exibirDialogo">Se true exibe o di�logo Imprimindo...</param>
		/// <param name="impressora">Passe a string com o nome da impressora para imprimir diretamente em determinada impressora. Caso contr�rio, a impress�o ser� feita na impressora que estiver como padr�o</param>
		public void Imprimir(bool exibirDialogo = true, string impressora = "")
        {
			// Este m�todo n�o ser� �til para o SINFe e � muito complicado de migrar para a nova vers�o do FastReport
			//Relatorio.PrintSettings.ShowDialog = exibirDialogo;
			//Relatorio.PrintSettings.Printer = impressora;
			//Relatorio.Print();
		}

		/// <summary>
		/// Converte o DANFE para PDF e salva-o no caminho/arquivo indicado
		/// </summary>
		/// <param name="arquivo">Caminho/arquivo onde deve ser salvo o PDF do DANFE</param>
		public void ExportarPdf(string arquivo)
        {
			//Relatorio.Compressed = true;
			//Relatorio.Prepare();
			//Relatorio.Export(new PDFSimpleExport(), arquivo);
		}

		public void ExportarPdf2Image(string arquivo)
		{
			Relatorio.Prepare();
			Relatorio.Export(new ImageExport() { ImageFormat = ImageExportFormat.Png }, arquivo);
		}

        /// <summary>
        /// Converte o DANFE para PDF e copia para o stream
        /// </summary>
        /// <param name="outputStream">Variável do tipo Stream para output</param>
        public void ExportarPdf(Stream outputStream)
        {
            //Relatorio.Prepare();
            //Relatorio.Export(new PDFSimpleExport(), outputStream);
            //outputStream.Position = 0;
        }

		public IList<byte[]> ExportarPdf2ImagePng()
		{
			IList<byte[]> lst = new List<byte[]>();
			if (Relatorio.Prepare())
			{
				for (int i = 0; i < Relatorio.PreparedPages.Count; i++)
				{
					using (MemoryStream ms = new MemoryStream())
					{
						Relatorio.Export(new ImageExport()
						{
							ImageFormat = ImageExportFormat.Png,
							PageRange = PageRange.Current,
							Resolution = 168,
							CurPage = i + 1
						}, ms);
						lst.Add(ms.ToArray());
					}
				}
			}

			return lst;
		}

		public IList<byte[]> ExportarPdf2ImageJpeg()
		{
			IList<byte[]> lst = new List<byte[]>();
			if (Relatorio.Prepare())
			{
				for (int i = 0; i < Relatorio.PreparedPages.Count; i++)
				{
					using (MemoryStream ms = new MemoryStream())
					{
						Relatorio.Export(new ImageExport()
						{
							ImageFormat = ImageExportFormat.Jpeg,
							JpegQuality = 100,
							Resolution = 168,
							PageRange = PageRange.Current,
							CurPage = i + 1
						}, ms);
						lst.Add(ms.ToArray());
					}
				}
			}

			return lst;
		}

        /// <summary>
        /// Converte o DANFE para PDF e salva-o no caminho/arquivo indicado
        /// </summary>
        /// <param name="arquivo">Caminho/arquivo onde deve ser salvo o PDF do DANFE</param>
        /// <param name="exportBase">Instancia do tipo de exportacao do FastReport</param>
        public void ExportarPdf(string arquivo, FastReport.Export.ExportBase exportBase)
        {
            if (exportBase == null)
                throw new NullReferenceException("exportBase deve ter um objeto instanciado, tente 'new PDFExport()'");

            Relatorio.Prepare();
            Relatorio.Export(exportBase, arquivo);
        }

        /// <summary>
        /// Converte o DANFE para PDF e copia para o stream
        /// </summary>
        /// <param name="outputStream">Variável do tipo Stream para output</param>
        /// <param name="exportBase">Instancia do tipo de exportacao do FastReport</param>
        public void ExportarPdf(Stream outputStream, FastReport.Export.ExportBase exportBase)
        {
            if (exportBase == null)
                throw new NullReferenceException("exportBase deve ter um objeto instanciado, tente 'new PDFExport()'");

            Relatorio.Prepare();
            Relatorio.Export(exportBase, outputStream);
            outputStream.Position = 0;
        }
    }
}