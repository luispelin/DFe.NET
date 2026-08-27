using NFe.Classes.Informacoes.Identificacao.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Identificacao
{
    // NT2025.002
    /// <summary>
    ///     B31 - Grupo de Compra Governamental
    /// </summary>
    public class gCompraGov
    {
        private decimal _pRedutor;

        /// <summary>
        ///     B32 - Tipo de ente governamental
        /// </summary>
        public TipoEnteGov tpEnteGov { get; set; }

        /// <summary>
        ///     B33 - Percentual de redução de alíquota em compra governamental (tamanho 3v2-4)
        /// </summary>
        public decimal pRedutor
        {
            get { return _pRedutor; }
            set { _pRedutor = value.Arredondar(4); }
        }

        /// <summary>
        ///     B34 - Tipo de operação com o ente governamental 
        /// </summary>
        public TipoOperEnteGov tpOperGov { get; set; }
    }
}
