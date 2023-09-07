using System;
using System.Xml.Serialization;
using DFe.Classes.Assinatura;
using DFe.Classes.Flags;
using DFe.Utils;

namespace CTe.Classes.Protocolo
{
    /// <summary>
    ///     PR13 - Envio de mensagem do Fisco para o contribuinte
    /// </summary>
    public class infFisco
    {
        /// <summary>
        ///     PR14 - Código de status da mensagem do fisco 
        /// </summary>
        public int cMsg { get; set; }

        /// <summary>
        ///     PR15 - Mensagem do Fisco para o contribuinte 
        /// </summary>
        public string xMsg { get; set; }
    }
}
