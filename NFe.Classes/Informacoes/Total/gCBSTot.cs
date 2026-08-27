using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Grupo total da CBS
    /// </summary>
    public class gCBSTot
    {
        private decimal _vDif;
        private decimal _vDevTrib;
        private decimal _vCBS;
        private decimal _vCredPres;
        private decimal _vCredPresCondSus;

        /// <summary>
        ///     W53 - Valor total do diferimento (tamanho 13v2)
        /// </summary>
        public decimal vDif
        {
            get { return _vDif.Arredondar(2); }
            set { _vDif = value.Arredondar(2); }
        }

        /// <summary>
        ///     W54 - Valor total de devolução de tributos (tamanho 13v2)
        /// </summary>
        public decimal vDevTrib
        {
            get { return _vDevTrib.Arredondar(2); }
            set { _vDevTrib = value.Arredondar(2); }
        }

        /// <summary>
        ///     W56 - Valor total da CBS (tamanho 13v2)
        /// </summary>
        public decimal vCBS
        {
            get { return _vCBS.Arredondar(2); }
            set { _vCBS = value.Arredondar(2); }
        }

        /// <summary>
        ///     W56a - Valor total do crédito presumido (tamanho 13v2) 
        /// </summary>
        public decimal vCredPres
        {
            get { return _vCredPres.Arredondar(2); }
            set { _vCredPres = value.Arredondar(2); }
        }

        /// <summary>
        ///     W56b - Valor total do crédito presumido em condição suspensiva (tamanho 13v2)
        /// </summary>
        public decimal vCredPresCondSus
        {
            get { return _vCredPresCondSus.Arredondar(2); }
            set { _vCredPresCondSus = value.Arredondar(2); }
        }

    }
}
