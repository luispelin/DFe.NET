using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Grupo total do IBS do Município
    /// </summary>
    public class gIBSMunTot
    {
        private decimal _vDif;
        private decimal _vDevTrib;
        private decimal _vIBSMun;

        /// <summary>
        ///     W43 - Valor total do diferimento (tamanho 3v2-4)
        /// </summary>
        public decimal vDif
        {
            get { return _vDif.Arredondar(2); }
            set { _vDif = value.Arredondar(2); }
        }

        /// <summary>
        ///     W44 - Valor total de devolução de tributos (tamanho 3v2-4)
        /// </summary>
        public decimal vDevTrib
        {
            get { return _vDevTrib.Arredondar(2); }
            set { _vDevTrib = value.Arredondar(2); }
        }

        /// <summary>
        ///     W46 - Valor total do IBS do Município (tamanho 3v2-4)
        /// </summary>
        public decimal vIBSMun
        {
            get { return _vIBSMun.Arredondar(2); }
            set { _vIBSMun = value.Arredondar(2); }
        }

    }
}
