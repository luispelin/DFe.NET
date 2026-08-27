using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos
{
    // NT2025.002
    /// <summary>
    /// Grupo de Informações do Diferimento
    /// </summary>
    public class gDif
    {
        private decimal _pDif;
        private decimal _vDif;

        /// <summary>
        ///     Percentual do diferimento (UB22, UB41, UB60) (tamanho 3v2-4)
        /// </summary>
        public decimal pDif
        {
            get { return _pDif; }
            set { _pDif = value.Arredondar(4); }
        }

        /// <summary>
        ///     Valor do Diferimento (UB23, UB42, UB61) (tamanho 13v2)
        /// </summary>
        public decimal vDif
        {
            get { return _vDif.Arredondar(2); }
            set { _vDif = value.Arredondar(2); }
        }

    }
}
