using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Classes.Informacoes.Total
{
    // NT2025.002
    /// <summary>
    /// Grupo total do imposto seletivo 
    /// O grupo de valores totais da NF-e deve ser informado com o somatório do campo correspondente dos itens.
    /// O IS é “por fora”, por isso seu valor deve ser adicionado ao valor total da NF.
    /// </summary>
    public class ISTot
    {
        private decimal _vIS;

        /// <summary>
        ///     W33 - Total do imposto seletivo (tamanho 13v2)
        /// </summary>
        public decimal vIS
        {
            get { return _vIS.Arredondar(2); }
            set { _vIS = value.Arredondar(2); }
        }
    }
}
