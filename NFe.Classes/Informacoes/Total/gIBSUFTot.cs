using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Grupo total do IBS da UF
    /// </summary>
    public class gIBSUFTot
    {
        private decimal _vDif;
        private decimal _vDevTrib;
        private decimal _vIBSUF;

        /// <summary>
        ///     W38 - Valor total do diferimento (tamanho 13v2)
        /// </summary>
        public decimal vDif
        {
            get { return _vDif.Arredondar(2); }
            set { _vDif = value.Arredondar(2); }
        }

        /// <summary>
        ///     W39 - Valor total de devolução de tributos (tamanho 13v2)
        /// </summary>
        public decimal vDevTrib
        {
            get { return _vDevTrib.Arredondar(2); }
            set { _vDevTrib = value.Arredondar(2); }
        }

        /// <summary>
        ///     W40 - Valor total do IBS da UF (tamanho 13v2)
        /// </summary>
        public decimal vIBSUF
        {
            get { return _vIBSUF.Arredondar(2); }
            set { _vIBSUF = value.Arredondar(2); }
        }

    }
}
