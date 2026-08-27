using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações da devolução de tributos
    /// </summary>
    public class gDevTrib
    {
        private decimal _vDevTrib;

        /// <summary>
        ///     Valor do tributo devolvido (UB25, UB44, UB63) (tamanho 13v2)
        /// </summary>
        public decimal vDevTrib
        {
            get { return _vDevTrib.Arredondar(2); }
            set { _vDevTrib = value.Arredondar(2); }
        }
    }
}
