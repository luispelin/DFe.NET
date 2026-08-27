using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Grupo total do IBS
    /// </summary>
    public class gIBSTot
    {
        private decimal _vIBS;
        private decimal _vCredPres;
        private decimal _vCredPresCondSus;

        // NT2025.002
        /// <summary>
        ///     W37 - Grupo total do IBS da UF
        /// </summary>
        public gIBSUFTot gIBSUF { get; set; }

        // NT2025.002
        /// <summary>
        ///     W42 - Grupo total do IBS do Município
        /// </summary>
        public gIBSMunTot gIBSMun { get; set; }

        // NT2025.002
        /// <summary>
        ///     W47 - Valor total do IBS (tamanho 13v2)
        /// </summary>
        public decimal vIBS
        {
            get { return _vIBS.Arredondar(2); }
            set { _vIBS = value.Arredondar(2); }
        }

        // NT2025.002
        /// <summary>
        ///     W48 - Valor total do crédito presumido (tamanho 13v2)
        /// </summary>
        public decimal vCredPres
        {
            get { return _vCredPres.Arredondar(2); }
            set { _vCredPres = value.Arredondar(2); }
        }

        // NT2025.002
        /// <summary>
        ///     W49 - Valor total do crédito presumido em condição suspensiva (tamanho 13v2)
        /// </summary>
        public decimal vCredPresCondSus
        {
            get { return _vCredPresCondSus.Arredondar(2); }
            set { _vCredPresCondSus = value.Arredondar(2); }
        }

    }
}
