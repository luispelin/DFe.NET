using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.BensServicos.Tipos
{
    // NT2025.002
    /// <summary>
    ///     <para>000 - Tributação integral</para>
    ///     <para>010 - Tributação com alíquotas uniformes</para>
    ///     <para>011 - Tributação com alíquotas uniformes reduzidas</para>
    ///     <para>200 - Alíquota reduzida</para>
    ///     <para>210 - Redução de alíquota com redutor de base de cálculo</para>
    ///     <para>220 - Alíquota fixa</para>
    ///     <para>221 - Alíquota fixa proporcional</para>
    ///     <para>222 - Redução de base de cálculo</para>
    ///     <para>400 - Isenção</para>
    ///     <para>410 - Imunidade e não incidência</para>
    ///     <para>510 - Diferimento</para>
    ///     <para>515 - Diferimento com redução de alíquota</para>
    ///     <para>550 - Suspensão</para>
    ///     <para>620 - Tributação monofásica</para>
    ///     <para>800 - Transferência de crédito</para>
    ///     <para>810 - Ajuste de IBS na ZFM</para>
    ///     <para>811 - Ajustes</para>
    ///     <para>820 - Tributação em documento específico</para>
    ///     <para>830 - Exclusão de base de cálculo</para>
    /// </summary>
    public enum CstIBSCBS
    {
        /// <summary>
        /// 000 - Tributação integral
        /// </summary>
        [Description("Tributação integral")]
        [XmlEnum("000")]
        Cst000 = 000,

        /// <summary>
        /// 010 - Tributação com alíquotas uniformes
        /// </summary>
        [Description("Tributação com alíquotas uniformes")]
        [XmlEnum("010")]
        Cst010 = 010,

        /// <summary>
        /// 011 - Tributação com alíquotas uniformes reduzidas
        /// </summary>
        [Description("Tributação com alíquotas uniformes reduzidas")]
        [XmlEnum("011")]
        Cst011 = 011,

        /// <summary>
        /// 200 - Alíquota reduzida
        /// </summary>
        [Description("Alíquota reduzida")]
        [XmlEnum("200")]
        Cst200 = 200,

        /// <summary>
        /// 210 - Redução de alíquota com redutor de base de cálculo
        /// </summary>
        [Description("Redução de alíquota com redutor de base de cálculo")]
        [XmlEnum("210")]
        Cst210 = 210,

        /// <summary>
        /// 220 - Alíquota fixa
        /// </summary>
        [Description("Alíquota fixa")]
        [XmlEnum("220")]
        Cst220 = 220,

        /// <summary>
        /// 221 - Alíquota fixa proporcional
        /// </summary>
        [Description("Alíquota fixa proporcional")]
        [XmlEnum("221")]
        Cst221 = 221,

        /// <summary>
        /// 222 - Redução de base de cálculo
        /// </summary>
        [Description("Redução de base de cálculo")]
        [XmlEnum("222")]
        Cst222 = 222,

        /// <summary>
        /// 400 - Isenção
        /// </summary>
        [Description("Isenção")]
        [XmlEnum("400")]
        Cst400 = 400,

        /// <summary>
        /// 410 - Imunidade e não incidência
        /// </summary>
        [Description("Imunidade e não incidência")]
        [XmlEnum("410")]
        Cst410 = 410,

        /// <summary>
        /// 510 - Diferimento
        /// </summary>
        [Description("Diferimento")]
        [XmlEnum("510")]
        Cst510 = 510,

        /// <summary>
        /// 515 - Diferimento com redução de alíquota
        /// </summary>
        [Description("Diferimento com redução de alíquota")]
        [XmlEnum("515")]
        Cst515 = 515,

        /// <summary>
        /// 550 - Suspensão
        /// </summary>
        [Description("Suspensão")]
        [XmlEnum("550")]
        Cst550 = 550,

        /// <summary>
        /// 620 - Tributação monofásica
        /// </summary>
        [Description("Tributação monofásica")]
        [XmlEnum("620")]
        Cst620 = 620,

        /// <summary>
        /// 800 - Transferência de crédito
        /// </summary>
        [Description("Transferência de crédito")]
        [XmlEnum("800")]
        Cst800 = 800,

        /// <summary>
        /// 810 - Ajuste de IBS na ZFM
        /// </summary>
        [Description("Ajuste de IBS na ZFM")]
        [XmlEnum("810")]
        Cst810 = 810,

        /// <summary>
        /// 811 - Ajustes
        /// </summary>
        [Description("Ajustes")]
        [XmlEnum("811")]
        Cst811 = 811,

        /// <summary>
        /// 820 - Tributação em documento específico
        /// </summary>
        [Description("Tributação em documento específico")]
        [XmlEnum("820")]
        Cst820 = 820,

        /// <summary>
        /// 830 - Exclusão de base de cálculo
        /// </summary>
        [Description("Exclusão de base de cálculo")]
        [XmlEnum("830")]
        Cst830 = 830,

    }

    // NT2025.002
    /// <summary>
    ///     <para>000001 - Situações tributadas integralmente pelo IBS e CBS.</para>
    ///     <para>000002 - Exploração de via</para>
    ///     <para>000003 - Regime automotivo - projetos incentivados(art. 311)</para>
    ///     <para>000004 - Regime automotivo - projetos incentivados(art. 312)</para>
    ///     <para>010001 - Operações do FGTS não realizadas pela Caixa Econômica Federal</para>
    ///     <para>010002 - Operações do serviço financeiro</para>
    ///     <para>011001 - Planos de assistência funerária.</para>
    ///     <para>011002 - Planos de assistência à saúde</para>
    ///     <para>011003 - Intermediação de planos de assistência à saúde</para>
    ///     <para>011004 - Concursos e prognósticos</para>
    ///     <para>011005 - Planos de assistência à saúde de animais domésticos</para>
    ///     <para>200001 - Serviços de transporte de bens até as zonas de processamento de exportação e bens exportados a partir das zonas de processamento de exportação</para>
    ///     <para>200002 - Fornecimento ou importação para produtor rural não contribuinte ou TAC</para>
    ///     <para>200003 - Vendas de produtos destinados à alimentação humana (Anexo I)</para>
    ///     <para>200004 - Fornecimento de dispositivos médicos (Anexo XII)</para>
    ///     <para>200005 - Fornecimento de dispositivos médicos para órgãos da administração pública e entidades de saúde imunes (Anexo IV)</para>
    ///     <para>200006 - Situação de emergência de saúde pública reconhecida pelo Poder público (Anexo XII)</para>
    ///     <para>200007 - Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência (Anexo XIII)</para>
    ///     <para>200008 - Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência adquiridos por órgãos da administração pública (Anexo V)</para>
    ///     <para>200009 - Fornecimento dos medicamentos registrados na Anvisa</para>
    ///     <para>200010 - Fornecimento dos medicamentos registrados na Anvisa, adquiridos por órgãos da administração pública</para>
    ///     <para>200011 - Fornecimento das composições para nutrição enteral e parenteral quando adquiridas por órgãos da administração pública (Anexo VI)</para>
    ///     <para>200012 - Situação de emergência de saúde pública reconhecida pelo Poder público</para>
    ///     <para>200013 - Fornecimento de tampões higiênicos, absorventes higiênicos internos ou externos</para>
    ///     <para>200014 - Fornecimento dos produtos hortícolas, frutas e ovos (Anexo XV) </para>
    ///     <para>200015 - Venda de automóveis de passageiros de fabricação nacional adquiridos por motoristas profissionais ou pessoas com deficiência</para>
    ///     <para>200016 - Prestação de serviços de pesquisa e desenvolvimento por Instituição Científica, Tecnológica e de Inovação (ICT)</para>
    ///     <para>200017 - Operações relacionadas ao FGTS</para>
    ///     <para>200018 - Operações de resseguro e retrocessão</para>
    ///     <para>200019 - Importador dos serviços financeiros contribuinte</para>
    ///     <para>200020 - Operação praticada por sociedades cooperativas optantes por regime específico do IBS e CBS</para>
    ///     <para>200021 - Serviços de transporte público coletivo de passageiros ferroviário e hidroviário</para>
    ///     <para>200022 - Operação originada fora da ZFM que destine bem material industrializado a contribuinte estabelecido na ZFM</para>
    ///     <para>200023 - Operação realizada por indústria incentivada que destine bem material intermediário para outra indústria incentivada na ZFM</para>
    ///     <para>200024 - Operação originada fora das Áreas de Livre Comércio destinadas a contribuinte estabelecido nas Áreas de Livre Comércio</para>
    ///     <para>200025 - Fornecimento dos serviços de educação relacionados ao Programa Universidade para Todos (Prouni)</para>
    ///     <para>200026 - Locação de imóveis localizados nas zonas reabilitadas</para>
    ///     <para>200027 - Operações de locação, cessão onerosa e arrendamento de bens imóveis</para>
    ///     <para>200028 - Fornecimento dos serviços de educação (Anexo II)</para>
    ///     <para>200029 - Fornecimento dos serviços de saúde humana (Anexo III)</para>
    ///     <para>200030 - Venda dos dispositivos médicos  (Anexo IV)</para>
    ///     <para>200031 - Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência (Anexo V) </para>
    ///     <para>200032 - Fornecimento dos medicamentos registrados na Anvisa ou produzidos por farmácias de manipulação, ressalvados os medicamentos sujeitos à alíquota zero</para>
    ///     <para>200033 - Fornecimento das composições para nutrição enteral e parenteral (Anexo VI)</para>
    ///     <para>200034 - Fornecimento dos alimentos destinados ao consumo humano (Anexo VII)</para>
    ///     <para>200035 - Fornecimento dos produtos de higiene pessoal e limpeza (Anexo VIII)</para>
    ///     <para>200036 - Fornecimento de produtos agropecuários, aquícolas, pesqueiros, florestais e extrativistas vegetais in natura</para>
    ///     <para>200037 - Fornecimento de serviços ambientais de conservação ou recuperação da vegetação nativa</para>
    ///     <para>200038 - Fornecimento dos insumos agropecuários e aquícolas (Anexo IX)</para>
    ///     <para>200039 - Fornecimento dos bens e serviços relacionados com produções nacionais artísticas, culturais, de eventos, jornalísticas e audiovisuais (Anexo X)</para>
    ///     <para>200040 - Fornecimento de serviços de comunicação institucional à administração pública</para>
    ///     <para>200041 - Fornecimento de serviço de educação desportiva (art. 141. I)</para>
    ///     <para>200042 - Fornecimento de serviço de gestão e exploração do desporto (art. 141. II)</para>
    ///     <para>200043 - Fornecimento à administração pública dos serviços e dos bens relativos à soberania(Anexo XI)</para>
    ///     <para>200044 - Operações e prestações de serviços de segurança da informação e segurança cibernética desenvolvidos por sociedade que tenha sócio brasileiro(Anexo XI)</para>
    ///     <para>200045 - Operações relacionadas a projetos de reabilitação urbana de zonas históricas e de áreas críticas de recuperação e reconversão urbanística</para>
    ///     <para>200046 - Operações com bens imóveis</para>
    ///     <para>200047 - Bares e Restaurantes</para>
    ///     <para>200048 - Hotelaria, Parques de Diversão e Parques Temáticos</para>
    ///     <para>200049 - Transporte coletivo de passageiros rodoviário, ferroviário e hidroviário</para>
    ///     <para>200050 - Serviços de transporte aéreo regional coletivo de passageiros ou de carga</para>
    ///     <para>200051 - Agências de Turismo</para>
    ///     <para>200052 - Prestação de serviços de profissões intelectuais</para>
	///     <para>200053 - Fornecimento de medicamentos registrados na Anvisa, quando  classificados como soros ou vacinas</para>
    ///     <para>210001 - Redutor social aplicado uma única vez na alienação de bem imóvel residencial novo</para>
    ///     <para>210002 - Redutor social aplicado uma única vez na alienação de lote residencial</para>
    ///     <para>210003 - Redutor social em operações de locação, cessão onerosa e arrendamento de bens imóveis de uso residencial</para>
    ///     <para>220001 - Incorporação imobiliária submetida ao regime especial de tributação</para>
    ///     <para>220002 - Incorporação imobiliária submetida ao regime especial de tributação</para>
    ///     <para>220003 - Alienação de imóvel decorrente de parcelamento do solo</para>
    ///     <para>221001 - Locação, cessão onerosa ou arrendamento de bem imóvel com alíquota sobre a receita bruta</para>
    ///     <para>222001 - Transporte internacional de passageiros, caso os trechos de ida e volta sejam vendidos em conjunto</para>
    ///     <para>400001 - Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário</para>
    ///     <para>400002 - Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário com medição por quilômetro rodado</para>
    ///     <para>410001 - Fornecimento de bonificações quando constem no documento fiscal e que não dependam de evento posterior</para>
    ///     <para>410002 - Transferências entre estabelecimentos pertencentes ao mesmo contribuinte</para>
    ///     <para>410003 - Doações sem contraprestação em benefício do doador</para>
    ///     <para>410004 - Exportações de bens e serviços</para>
    ///     <para>410005 - Fornecimentos realizados pela União, pelos Estados, pelo Distrito Federal e pelos Municípios</para>
    ///     <para>410006 - Fornecimentos realizados por entidades religiosas e templos de qualquer culto</para>
    ///     <para>410007 - Fornecimentos realizados por partidos políticos, entidades sindicais e instituições de educação e de assistência social</para>
    ///     <para>410008 - Fornecimentos de livros, jornais, periódicos e do papel destinado a sua impressão</para>
    ///     <para>410009 - Fornecimentos de fonogramas e videofonogramas musicais produzidos no Brasil</para>
    ///     <para>410010 - Fornecimentos de serviço de comunicação nas modalidades de radiodifusão sonora e de sons e imagens de recepção livre e gratuita</para>
    ///     <para>410011 - Fornecimentos de ouro, quando definido em lei como ativo financeiro ou instrumento cambial</para>
    ///     <para>410012 - Fornecimento de condomínio edilício não optante pelo regime regular</para>
    ///     <para>410013 - Exportações de combustíveis</para>
    ///     <para>410014 - Fornecimento de produtor rural não contribuinte</para>
    ///     <para>410015 - Fornecimento por transportador autônomo não contribuinte</para>
    ///     <para>410016 - Fornecimento ou aquisição de resíduos sólidos</para>
    ///     <para>410017 - Aquisição de bem móvel com crédito presumido sob condição de revenda realizada</para>
    ///     <para>410018 - Operações relacionadas aos fundos garantidores e executores de políticas públicas</para>
    ///     <para>410019 - Exclusão da gorjeta na base de cálculo no fornecimento de alimentação</para>
    ///     <para>410020 - Exclusão do valor de intermediação na base de cálculo no fornecimento de alimentação</para>
    ///     <para>410021 - Contribuição de que trata o art. 149-A da Constituição Federal</para>
    ///     <para>410022 - Consolidação da propriedade do bem pelo credor</para>
    ///     <para>410023 - Alienação de bens móveis ou imóveis que tenham sido objeto de garantia em que o prestador da garantia não seja contribuinte</para>
    ///     <para>410024 - Consolidação da propriedade do bem pelo grupo de consórcio</para>
    ///     <para>410025 - Alienação de bem que tenha sido objeto de garantia em que o prestador da garantia não seja contribuinte</para>
    ///     <para>410026 - Doação com anulação de crédito</para>
    ///     <para>410027 - Exportação de serviço ou de bem imaterial</para>
    ///     <para>410028 - Operações com bens imóveis realizadas por pessoas físicas não consideradas contribuintes</para>
    ///     <para>410029 - Operações acobertadas somente pelo ICMS</para>
    ///     <para>410030 - Estorno de crédito por perecimento, deteriorização, roubo, furto ou extravio.</para>
    ///     <para>410031 - Fornecimento em período anterior ao início de vigência de incidências de CBS e IBS</para>
    ///     <para>410032 - Tributos incidentes na operação que não integram a base de cálculo do IBS e da CBS</para>
    ///     <para>410033 - Operações de Fundos de Investimento Imobiliário (FII) e Fundos de Investimento nas Cadeias Produtivas do Agronegócio (Fiagro)</para>
    ///     <para>410034 - Operações de fundos de investimento</para>
    ///     <para>410035 - Fornecimento realizado por nanoempreendedor</para>
    ///     <para>410999 - Operações não onerosas sem previsão de tributação, não especificadas anteriormente</para>
    ///     <para>510001 - Operações, sujeitas a diferimento, com energia elétrica, relativas à importação, geração, comercialização, distribuição e transmissão</para>
    ///     <para>515001 - Operações, sujeitas a diferimento, com insumos agropecuários e aquícolas (Anexo IX)</para>
    ///     <para>550001 - Exportações de bens materiais</para>
    ///     <para>550002 - Regime de Trânsito</para>
    ///     <para>550003 - Regimes de Depósito  (art. 85)</para>
    ///     <para>550004 - Regimes de Depósito(art. 87)</para>
    ///     <para>550005 - Regimes de Depósito(art. 87, Parágrafo único)</para>
    ///     <para>550006 - Regimes de Permanência Temporária</para>
    ///     <para>550007 - Regimes de Aperfeiçoamento</para>
    ///     <para>550008 - Importação de bens para o Regime de Repetro-Temporário</para>
    ///     <para>550009 - GNL-Temporário</para>
    ///     <para>550010 - Repetro-Permanente</para>
    ///     <para>550011 - Repetro-Industrialização</para>
    ///     <para>550012 - Repetro-Nacional</para>
    ///     <para>550013 - Repetro-Entreposto</para>
    ///     <para>550014 - Zona de Processamento de Exportação</para>
    ///     <para>550015 - Regime Tributário para Incentivo à Modernização e à Ampliação da Estrutura Portuária</para>
    ///     <para>550016 - Regime Especial de Incentivos para o Desenvolvimento da Infraestrutura</para>
    ///     <para>550017 - Regime Tributário para Incentivo à Atividade Econômica Naval</para>
    ///     <para>550018 - Desoneração da aquisição de bens de capital</para>
    ///     <para>550019 - Importação de bem material por indústria incentivada para utilização na ZFM</para>
    ///     <para>550020 - Áreas de livre comércio</para>
    ///     <para>550021 - Industrialização destinada a exportações</para>
    ///     <para>550022 - Regime Especial de Incentivos para a Produção de Hidrogênio de Baixa Emissão de Carbono (Rehidro)</para>
    ///     <para>550023 - Operações com hidrocarbonetos líquidos derivados de petróleo não combustíveis ou de gás natural, inclusive nafta</para>
    ///     <para>620001 - Tributação monofásica sobre combustíveis</para>
    ///     <para>620002 - Tributação monofásica com responsabilidade pela retenção sobre combustíveis</para>
    ///     <para>620003 - Tributação monofásica com tributos retidos por responsabilidade sobre combustíveis</para>
    ///     <para>620004 - Tributação monofásica sobre mistura de EAC com gasolina A em percentual superior ao obrigatório</para>
    ///     <para>620005 - Tributação monofásica sobre mistura de EAC com gasolina A em percentual inferior ao obrigatório</para>
    ///     <para>620006 - Tributação monofásica sobre combustíveis cobrada anteriormente</para>
    ///     <para>800001 - Fusão, cisão ou incorporação</para>
    ///     <para>800002 - Transferência de crédito do associado, inclusive as cooperativas singulares</para>
    ///     <para>810001 - Crédito presumido sobre o valor apurado nos fornecimentos a partir da ZFM</para>
	///     <para>811001 - Anulação de Crédito por Saídas Imunes/Isentas</para>
	///     <para>811002 - Débitos de notas fiscais não processadas na apuração</para>
	///     <para>811003 - Desenquadramento do Simples Nacional</para>
    ///     <para>820001 - Documento com informações de fornecimento de serviços de planos de assistência à saúde</para>
    ///     <para>820002 - Documento com informações de fornecimento de serviços de planos de assistência funerária</para>
    ///     <para>820003 - Documento com informações de fornecimento de serviços de planos de assistência à saúde de animais domésticos</para>
    ///     <para>820004 - Documento com informações de prestação de serviços de consursos de prognósticos</para>
    ///     <para>820005 - Documento com informações de alienação de bens imóveis</para>
    ///     <para>820006 - Documento com informações de fornecimento de serviços de exploração de via</para>
	///     <para>820007 - Documento com informações de fornecimento de serviços financeiros</para>
	///     <para>820008 - Documento com informações de fornecimento, mas com tributação realizada em fatura anterior</para>
	///     <para>820009 - Cobrança relativa a fornecimentos declarados em outro documento</para>
    ///     <para>830001 - Documento com exclusão da BC da CBS e do IBS de energia elétrica fornecida pela distribuidora à UC</para>
    /// </summary>
    public enum cClassTribIBSCBS
    {
        /// <summary>
        /// 000000 - Não informado
        /// Não é um valor oficial, mas está presente para evitar erro de serialização caso alguma nota envie este valor inadvertidamente.
        /// </summary>
        [Description("Não informado")]
        [XmlEnum("000000")]
        CCTrib000000 = 000000,

        /// <summary>
        /// 000001 - Situações tributadas integralmente pelo IBS e CBS.
        /// Situações tributadas integralmente pelo IBS e CBS.
        /// </summary>
        [Description("Situações tributadas integralmente pelo IBS e CBS.")]
        [XmlEnum("000001")]
        CCTrib000001 = 000001,

        /// <summary>
        /// 000002 - Exploração de via
        /// Exploração de via, observado o art. 11 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exploração de via")]
        [XmlEnum("000002")]
        CCTrib000002 = 000002,

        /// <summary>
        /// 000003 - Regime automotivo - projetos incentivados (art. 311)
        /// Regime automotivo - projetos incentivados, observado o art. 311 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime automotivo - projetos incentivados (art. 311)")]
        [XmlEnum("000003")]
        CCTrib000003 = 000003,

        /// <summary>
        /// 000004 - Regime automotivo - projetos incentivados (art. 312)
        /// Regime automotivo - projetos incentivados, observado o art. 312 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime automotivo - projetos incentivados (art. 312)")]
        [XmlEnum("000004")]
        CCTrib000004 = 000004,

        /// <summary>
        /// 010001 - Operações do FGTS não realizadas pela Caixa Econômica Federal
        /// Operações do FGTS não realizadas pela Caixa Econômica Federal, observado o art. 212 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações do FGTS não realizadas pela Caixa Econômica Federal")]
        [XmlEnum("010001")]
        CCTrib010001 = 010001,

        /// <summary>
        /// 010002 - Operações do serviço financeiro
        /// Operações do serviço financeiro
        /// </summary>
        [Description("Operações do serviço financeiro")]
        [XmlEnum("010002")]
        CCTrib010002 = 010002,

        /// <summary>
        /// 011001 - Planos de assistência funerária.
        /// Planos de assistência funerária, observado o art. 236 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Planos de assistência funerária.")]
        [XmlEnum("011001")]
        CCTrib011001 = 011001,

        /// <summary>
        /// 011002 - Planos de assistência à saúde
        /// Planos de assistência à saúde, observado o art. 237 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Planos de assistência à saúde")]
        [XmlEnum("011002")]
        CCTrib011002 = 011002,

        /// <summary>
        /// 011003 - Intermediação de planos de assistência à saúde
        /// Intermediação de planos de assistência à saúde, observado o art. 240 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Intermediação de planos de assistência à saúde")]
        [XmlEnum("011003")]
        CCTrib011003 = 011003,

        /// <summary>
        /// 011004 - Concursos e prognósticos
        /// Concursos e prognósticos, observado o art. 246 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Concursos e prognósticos")]
        [XmlEnum("011004")]
        CCTrib011004 = 011004,

        /// <summary>
        /// 011005 - Planos de assistência à saúde de animais domésticos
        /// Planos de assistência à saúde de animais domésticos, observado o art. 243 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Planos de assistência à saúde de animais domésticos")]
        [XmlEnum("011005")]
        CCTrib011005 = 011005,

        /// <summary>
        /// 200001 - Serviços de transporte de bens até as zonas de processamento de exportação e bens exportados a partir das zonas de processamento de exportação
        /// Serviços de transporte de bens até as zonas de processamento de exportação e bens exportados a partir das zonas de processamento de exportação, observado o art. 103 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Serviços de transporte de bens até as zonas de processamento de exportação e bens exportados a partir das zonas de processamento de exportação")]
        [XmlEnum("200001")]
        CCTrib200001 = 200001,

        /// <summary>
        /// 200002 - Fornecimento ou importação para produtor rural não contribuinte ou TAC
        /// Fornecimento ou importação de tratores, máquinas e implementos agrícolas, destinados a produtor rural não contribuinte, e de veículos de transporte de carga destinados a transportador autônomo de carga pessoa física não contribuinte, observado o art. 110 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento ou importação para produtor rural não contribuinte ou TAC")]
        [XmlEnum("200002")]
        CCTrib200002 = 200002,

        /// <summary>
        /// 200003 - Vendas de produtos destinados à alimentação humana (Anexo I)
        /// Vendas de produtos destinados à alimentação humana relacionados no Anexo I da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, que compõem a Cesta Básica Nacional de Alimentos, criada nos termos do art. 8º da Emenda Constitucional nº 132, de 20 de dezembro de 2023, observado o art. 125 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Vendas de produtos destinados à alimentação humana (Anexo I)")]
        [XmlEnum("200003")]
        CCTrib200003 = 200003,

        /// <summary>
        /// 200004 - Fornecimento de dispositivos médicos (Anexo XII)
        /// Fornecimento de dispositivos médicos com a especificação das respectivas classificações da NCM/SH previstas no Anexo XII da Lei Complementar nº 214, de 2025, observado o art. 144 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de dispositivos médicos (Anexo XII)")]
        [XmlEnum("200004")]
        CCTrib200004 = 200004,

        /// <summary>
        /// 200005 - Fornecimento de dispositivos médicos para órgãos da administração pública e entidades de saúde imunes (Anexo IV)
        /// Fornecimento de dispositivos médicos com a especificação das respectivas classificações da NCM/SH previstas no Anexo IV da Lei Complementar nº 214, de 2025, quando adquiridos por órgãos da administração pública direta, autarquias, fundações públicas e entidades de saúde imunes, observado o art. 144 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de dispositivos médicos para órgãos da administração pública e entidades de saúde imunes (Anexo IV)")]
        [XmlEnum("200005")]
        CCTrib200005 = 200005,

        /// <summary>
        /// 200006 - Situação de emergência de saúde pública reconhecida pelo Poder público (Anexo XII)
        /// Situação de emergência de saúde pública reconhecida pelo Poder Legislativo federal, estadual, distrital ou municipal competente, ato conjunto do Ministro da Fazenda e do Comitê Gestor do IBS poderá ser editado, a qualquer momento, para incluir dispositivos não listados no Anexo XII da Lei Complementar nº 214, de 2025, limitada a vigência do benefício ao período e à localidade da emergência de saúde pública, observado o art. 144 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Situação de emergência de saúde pública reconhecida pelo Poder público (Anexo XII)")]
        [XmlEnum("200006")]
        CCTrib200006 = 200006,

        /// <summary>
        /// 200007 - Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência (Anexo XIII)
        /// Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência relacionados no Anexo XIII da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, observado o art. 145 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência (Anexo XIII)")]
        [XmlEnum("200007")]
        CCTrib200007 = 200007,

        /// <summary>
        /// 200008 - Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência adquiridos por órgãos da administração pública (Anexo V)
        /// Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência relacionados no Anexo V da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, quando adquiridos por órgãos da administração pública direta, autarquias, fundações públicas e entidades imunes, observado o art. 145 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência adquiridos por órgãos da administração pública (Anexo V)")]
        [XmlEnum("200008")]
        CCTrib200008 = 200008,

        /// <summary>
        /// 200009 - Fornecimento dos medicamentos registrados na Anvisa
        /// Fornecimento dos medicamentos registrados na Anvisa, observado o art. 146 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos medicamentos registrados na Anvisa")]
        [XmlEnum("200009")]
        CCTrib200009 = 200009,

        /// <summary>
        /// 200010 - Fornecimento dos medicamentos registrados na Anvisa, adquiridos por órgãos da administração pública
        /// Fornecimento dos medicamentos registrados na Anvisa, quando adquiridos por órgãos da administração pública direta, autarquias, fundações públicas e entidades imunes, observado o art. 146 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos medicamentos registrados na Anvisa, adquiridos por órgãos da administração pública")]
        [XmlEnum("200010")]
        CCTrib200010 = 200010,

        /// <summary>
        /// 200011 - Fornecimento das composições para nutrição enteral e parenteral quando adquiridas por órgãos da administração pública (Anexo VI)
        /// Fornecimento das composições para nutrição enteral e parenteral, composições especiais e fórmulas nutricionais destinadas às pessoas com erros inatos do metabolismo relacionadas no Anexo VI da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, quando adquiridas por órgãos da administração pública direta, autarquias e fundações públicas, observado o art. 146 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento das composições para nutrição enteral e parenteral quando adquiridas por órgãos da administração pública (Anexo VI)")]
        [XmlEnum("200011")]
        CCTrib200011 = 200011,

        /// <summary>
        /// 200012 - Situação de emergência de saúde pública reconhecida pelo Poder público
        /// Situação de emergência de saúde pública reconhecida pelo Poder Legislativo federal, estadual, distrital ou municipal competente, ato conjunto do Ministro da Fazenda e do Comitê Gestor do IBS poderá ser editado, a qualquer momento, limitada a vigência do benefício ao período e à localidade da emergência de saúde pública, observado o art. 146 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Situação de emergência de saúde pública reconhecida pelo Poder público")]
        [XmlEnum("200012")]
        CCTrib200012 = 200012,

        /// <summary>
        /// 200013 - Fornecimento de tampões higiênicos, absorventes higiênicos internos ou externos
        /// Fornecimento de tampões higiênicos, absorventes higiênicos internos ou externos, descartáveis ou reutilizáveis, calcinhas absorventes e coletores menstruais, observado o art. 147 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de tampões higiênicos, absorventes higiênicos internos ou externos")]
        [XmlEnum("200013")]
        CCTrib200013 = 200013,

        /// <summary>
        /// 200014 - Fornecimento dos produtos hortícolas, frutas e ovos (Anexo XV) 
        /// Fornecimento dos produtos hortícolas, frutas e ovos, relacionados no Anexo XV da Lei Complementar nº 214 , de 2025, com a especificação das respectivas classificações da NCM/SH e desde que não cozidos, observado o art. 148 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos produtos hortícolas, frutas e ovos (Anexo XV) ")]
        [XmlEnum("200014")]
        CCTrib200014 = 200014,

        /// <summary>
        /// 200015 - Venda de automóveis de passageiros de fabricação nacional adquiridos por motoristas profissionais ou pessoas com deficiência
        /// Venda de automóveis de passageiros de fabricação nacional de, no mínimo, 4 (quatro) portas, inclusive a de acesso ao bagageiro, quando adquiridos por motoristas profissionais que exerçam, comprovadamente, em automóvel de sua propriedade, atividade de condutor autônomo de passageiros, na condição de titular de autorização, permissão ou concessão do poder público, e que destinem o automóvel à utilização na categoria de aluguel (táxi), ou por pessoas com deficiência física, visual, auditiva, deficiência mental severa ou profunda, transtorno do espectro autista, com prejuízos na   comunicação social e em padrões restritos ou repetitivos de comportamento de nível moderado ou grave, nos termos da legislação relativa à matéria, observado o disposto no art. 149 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Venda de automóveis de passageiros de fabricação nacional adquiridos por motoristas profissionais ou pessoas com deficiência")]
        [XmlEnum("200015")]
        CCTrib200015 = 200015,

        /// <summary>
        /// 200016 - Prestação de serviços de pesquisa e desenvolvimento por Instituição Científica, Tecnológica e de Inovação (ICT)
        /// Prestação de serviços de pesquisa e desenvolvimento por Instituição Científica, Tecnológica e de Inovação (ICT) sem fins lucrativos para a administração pública direta, autarquias e fundações públicas ou para o contribuinte sujeito ao regime regular do IBS e da CBS, observado o disposto no art. 156  da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Prestação de serviços de pesquisa e desenvolvimento por Instituição Científica, Tecnológica e de Inovação (ICT)")]
        [XmlEnum("200016")]
        CCTrib200016 = 200016,

        /// <summary>
        /// 200017 - Operações relacionadas ao FGTS
        /// Operações relacionadas ao FGTS, considerando aquelas necessárias à aplicação da Lei nº 8.036, de 1990, realizadas pelo Conselho Curador ou Secretaria Executiva do FGTS, observado o art. 212 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações relacionadas ao FGTS")]
        [XmlEnum("200017")]
        CCTrib200017 = 200017,

        /// <summary>
        /// 200018 - Operações de resseguro e retrocessão
        /// Operações de resseguro e retrocessão ficam sujeitas à incidência à alíquota zero, inclusive quando os prêmios de resseguro e retrocessão forem cedidos ao exterior, observado o art. 223 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações de resseguro e retrocessão")]
        [XmlEnum("200018")]
        CCTrib200018 = 200018,

        /// <summary>
        /// 200019 - Importador dos serviços financeiros contribuinte
        /// Importador dos serviços financeiros que seja contribuinte e tenha direito de apropriação de créditos na aquisição do mesmo serviço financeiro no País, observado o art. 231 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Importador dos serviços financeiros contribuinte")]
        [XmlEnum("200019")]
        CCTrib200019 = 200019,

        /// <summary>
        /// 200020 - Operação praticada por sociedades cooperativas optantes por regime específico do IBS e CBS
        /// Operação praticada por sociedades cooperativas optantes por regime específico do IBS e CBS, quando o associado destinar bem ou serviço à cooperativa de que participa, e a cooperativa fornecer bem ou serviço ao associado sujeito ao regime regular do IBS e da CBS, observado o art. 271 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operação praticada por sociedades cooperativas optantes por regime específico do IBS e CBS")]
        [XmlEnum("200020")]
        CCTrib200020 = 200020,

        /// <summary>
        /// 200021 - Serviços de transporte público coletivo de passageiros ferroviário e hidroviário
        /// Serviços de transporte público coletivo de passageiros ferroviário e hidroviário urbanos, semiurbanos e metropolitanos, observado o art. 285 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Serviços de transporte público coletivo de passageiros ferroviário e hidroviário")]
        [XmlEnum("200021")]
        CCTrib200021 = 200021,

        /// <summary>
        /// 200022 - Operação originada fora da ZFM que destine bem material industrializado a contribuinte estabelecido na ZFM
        /// Operação originada fora da Zona Franca de Manaus que destine bem material industrializado de origem nacional a contribuinte estabelecido na Zona Franca de Manaus que seja habilitado nos termos do art. 442 da Lei Complementar nº 214, de 2025, e sujeito ao regime regular do IBS e da CBS ou optante pelo regime do Simples Nacional de que trata o art. 12 da Lei Complementar nº 123, de 2006, observado o art. 445 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operação originada fora da ZFM que destine bem material industrializado a contribuinte estabelecido na ZFM")]
        [XmlEnum("200022")]
        CCTrib200022 = 200022,

        /// <summary>
        /// 200023 - Operação realizada por indústria incentivada que destine bem material intermediário para outra indústria incentivada na ZFM
        /// Operação realizada por indústria incentivada que destine bem material intermediário para outra indústria incentivada na Zona Franca de Manaus, desde que a entrega ou disponibilização dos bens ocorra dentro da referida área, observado o art. 448 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operação realizada por indústria incentivada que destine bem material intermediário para outra indústria incentivada na ZFM")]
        [XmlEnum("200023")]
        CCTrib200023 = 200023,

        /// <summary>
        /// 200024 - Operação originada fora das Áreas de Livre Comércio destinadas a contribuinte estabelecido nas Áreas de Livre Comércio
        /// Operação originada fora das Áreas de Livre Comércio que destine bem material industrializado de origem nacional a contribuinte estabelecido nas Áreas de Livre Comércio que seja habilitado nos termos do art. 456 da Lei Complementar nº 214, de 2025, e sujeito ao regime regular do IBS e da CBS ou optante pelo regime do Simples Nacional de que trata o art. 12 da Lei Complementar nº 123, de 2006, observado o art. 463 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operação originada fora das Áreas de Livre Comércio destinadas a contribuinte estabelecido nas Áreas de Livre Comércio")]
        [XmlEnum("200024")]
        CCTrib200024 = 200024,

        /// <summary>
        /// 200025 - Fornecimento dos serviços de educação relacionados ao Programa Universidade para Todos (Prouni)
        /// Fornecimento dos serviços de educação relacionados ao Programa Universidade para Todos (Prouni), instituído pela Lei nº 11.096, de 13 de janeiro de 2005, observado o art. 308 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos serviços de educação relacionados ao Programa Universidade para Todos (Prouni)")]
        [XmlEnum("200025")]
        CCTrib200025 = 200025,

        /// <summary>
        /// 200026 - Locação de imóveis localizados nas zonas reabilitadas
        /// Locação de imóveis localizados nas zonas reabilitadas, pelo prazo de 5 (cinco) anos, contado da data de expedição do habite-se, e relacionados a projetos de reabilitação urbana de zonas históricas e de áreas críticas de recuperação e reconversão urbanística dos Municípios ou do Distrito Federal, a serem delimitadas por lei municipal ou distrital, observado o art. 158 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Locação de imóveis localizados nas zonas reabilitadas")]
        [XmlEnum("200026")]
        CCTrib200026 = 200026,

        /// <summary>
        /// 200027 - Operações de locação, cessão onerosa e arrendamento de bens imóveis
        /// Operações de locação, cessão onerosa e arrendamento de bens imóveis, observado o art. 261 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações de locação, cessão onerosa e arrendamento de bens imóveis")]
        [XmlEnum("200027")]
        CCTrib200027 = 200027,

        /// <summary>
        /// 200028 - Fornecimento dos serviços de educação (Anexo II)
        /// Fornecimento dos serviços de educação relacionados no Anexo II da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da Nomenclatura Brasileira de Serviços, Intangíveis e Outras Operações que Produzam Variações no Patrimônio (NBS), observado o art. 129 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos serviços de educação (Anexo II)")]
        [XmlEnum("200028")]
        CCTrib200028 = 200028,

        /// <summary>
        /// 200029 - Fornecimento dos serviços de saúde humana (Anexo III)
        /// Fornecimento dos serviços de saúde humana relacionados no Anexo III da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NBS, observado o art. 130 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos serviços de saúde humana (Anexo III)")]
        [XmlEnum("200029")]
        CCTrib200029 = 200029,

        /// <summary>
        /// 200030 - Venda dos dispositivos médicos  (Anexo IV)
        /// Venda dos dispositivos médicos relacionados no Anexo IV da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, observado o art. 131 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Venda dos dispositivos médicos  (Anexo IV)")]
        [XmlEnum("200030")]
        CCTrib200030 = 200030,

        /// <summary>
        /// 200031 - Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência (Anexo V) 
        /// Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência relacionados no Anexo V da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, observado o art. 132 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos dispositivos de acessibilidade próprios para pessoas com deficiência (Anexo V) ")]
        [XmlEnum("200031")]
        CCTrib200031 = 200031,

        /// <summary>
        /// 200032 - Fornecimento dos medicamentos registrados na Anvisa ou produzidos por farmácias de manipulação, ressalvados os medicamentos sujeitos à alíquota zero
        /// Fornecimento dos medicamentos registrados na Anvisa ou produzidos por farmácias de manipulação, ressalvados os medicamentos sujeitos à alíquota zero de que trata o art. 146 da Lei Complementar nº 214, de 2025, observado o art. 133 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos medicamentos registrados na Anvisa ou produzidos por farmácias de manipulação, ressalvados os medicamentos sujeitos à alíquota zero")]
        [XmlEnum("200032")]
        CCTrib200032 = 200032,

        /// <summary>
        /// 200033 - Fornecimento das composições para nutrição enteral e parenteral (Anexo VI)
        /// Fornecimento das composições para nutrição enteral e parenteral, composições especiais e fórmulas nutricionais destinadas às pessoas com erros inatos do metabolismo relacionadas no Anexo VI da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, observado o art. 133 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento das composições para nutrição enteral e parenteral (Anexo VI)")]
        [XmlEnum("200033")]
        CCTrib200033 = 200033,

        /// <summary>
        /// 200034 - Fornecimento dos alimentos destinados ao consumo humano (Anexo VII)
        /// Fornecimento dos alimentos destinados ao consumo humano relacionados no Anexo VII da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, observado o art. 135 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos alimentos destinados ao consumo humano (Anexo VII)")]
        [XmlEnum("200034")]
        CCTrib200034 = 200034,

        /// <summary>
        /// 200035 - Fornecimento dos produtos de higiene pessoal e limpeza (Anexo VIII)
        /// Fornecimento dos produtos de higiene pessoal e limpeza relacionados no Anexo VIII da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH, observado o art. 136 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos produtos de higiene pessoal e limpeza (Anexo VIII)")]
        [XmlEnum("200035")]
        CCTrib200035 = 200035,

        /// <summary>
        /// 200036 - Fornecimento de produtos agropecuários, aquícolas, pesqueiros, florestais e extrativistas vegetais in natura
        /// Fornecimento de produtos agropecuários, aquícolas, pesqueiros, florestais e extrativistas vegetais in natura, observado o art. 137 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de produtos agropecuários, aquícolas, pesqueiros, florestais e extrativistas vegetais in natura")]
        [XmlEnum("200036")]
        CCTrib200036 = 200036,

        /// <summary>
        /// 200037 - Fornecimento de serviços ambientais de conservação ou recuperação da vegetação nativa
        /// Fornecimento de serviços ambientais de conservação ou recuperação da vegetação nativa, mesmo que fornecidos sob a forma de manejo sustentável de sistemas agrícolas, agroflorestais e agrossilvopastoris, em conformidade com as definições e requisitos da legislação específica, observado o art. 137 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de serviços ambientais de conservação ou recuperação da vegetação nativa")]
        [XmlEnum("200037")]
        CCTrib200037 = 200037,

        /// <summary>
        /// 200038 - Fornecimento dos insumos agropecuários e aquícolas (Anexo IX)
        /// Fornecimento dos insumos agropecuários e aquícolas relacionados no Anexo IX da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH e da NBS, observado o art. 138 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos insumos agropecuários e aquícolas (Anexo IX)")]
        [XmlEnum("200038")]
        CCTrib200038 = 200038,

        /// <summary>
        /// 200039 - Fornecimento dos bens e serviços relacionados com produções nacionais artísticas, culturais, de eventos, jornalísticas e audiovisuais (Anexo X)
        /// Fornecimento dos bens e serviços listados no Anexo X da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NCM/SH e NBS, nos casos relacionados com produções nacionais artísticas, culturais, de eventos, jornalísticas e audiovisuais, observado o art. 139 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento dos bens e serviços relacionados com produções nacionais artísticas, culturais, de eventos, jornalísticas e audiovisuais (Anexo X)")]
        [XmlEnum("200039")]
        CCTrib200039 = 200039,

        /// <summary>
        /// 200040 - Fornecimento de serviços de comunicação institucional à administração pública
        /// Fornecimento dos seguintes serviços de comunicação institucional à administração pública direta, autarquias e fundações públicas: serviços direcionados ao planejamento, criação, programação e manutenção de páginas eletrônicas da administração pública, ao monitoramento e gestão de suas redes sociais e à otimização de páginas e canais digitais para mecanismos de buscas e produção de mensagens, infográficos, painéis interativos e conteúdo institucional, serviços de relações com a imprensa, que reúnem estratégias organizacionais para promover e reforçar a comunicação dos órgãos e das entidades contratantes com seus públicos de interesse, por meio da interação com profissionais da imprensa, e serviços de relações públicas, que compreendem o esforço de comunicação planejado, coeso e contínuo que tem por objetivo estabelecer adequada percepção da atuação e dos objetivos institucionais, a partir do estímulo à compreensão mútua e da manutenção de padrões de relacionamento e fluxos de informação entre os órgãos e as entidades contratantes e seus públicos de interesse, no País e no exterior, observado o art. 140 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de serviços de comunicação institucional à administração pública")]
        [XmlEnum("200040")]
        CCTrib200040 = 200040,

        /// <summary>
        /// 200041 - Fornecimento de serviço de educação desportiva (art. 141. I)
        /// Operações relacionadas às seguintes atividades desportivas: fornecimento de serviço de educação desportiva, classificado no código 1.2205.12.00 da NBS, e gestão e exploração do desporto por associações e clubes esportivos filiados ao órgão estadual ou federal responsável pela coordenação dos desportos, inclusive por meio de venda de ingressos para eventos desportivos, fornecimento oneroso ou não de bens e serviços, inclusive ingressos, por meio de programas de sócio-torcedor, cessão dos direitos desportivos dos atletas e transferência de atletas para outra entidade desportiva ou seu retorno à atividade em outra entidade desportiva, observado o art. 141 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de serviço de educação desportiva (art. 141. I)")]
        [XmlEnum("200041")]
        CCTrib200041 = 200041,

        /// <summary>
        /// 200042 - Fornecimento de serviço de gestão e exploração do desporto (art. 141. II)
        /// Operações relacionadas às seguintes atividades desportivas: gestão e exploração do desporto por associações e clubes esportivos filiados ao órgão estadual ou federal responsável pela coordenação dos desportos, observado o art. 141 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de serviço de gestão e exploração do desporto (art. 141. II)")]
        [XmlEnum("200042")]
        CCTrib200042 = 200042,

        /// <summary>
        /// 200043 - Fornecimento à administração pública dos serviços e dos bens relativos à soberania (Anexo XI)
        /// Fornecimento à administração pública direta, autarquias e fundações púbicas dos serviços e dos bens relativos à soberania e à segurança nacional, à segurança da informação e à segurança cibernética relacionados no Anexo XI da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NBS e da NCM/SH, observado o art. 142 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento à administração pública dos serviços e dos bens relativos à soberania (Anexo XI)")]
        [XmlEnum("200043")]
        CCTrib200043 = 200043,

        /// <summary>
        /// 200044 - Operações e prestações de serviços de segurança da informação e segurança cibernética desenvolvidos por sociedade que tenha sócio brasileiro (Anexo XI)
        /// Operações e prestações de serviços de segurança da informação e segurança cibernética desenvolvidos por sociedade que tenha sócio brasileiro com o mínimo de 20% (vinte por cento) do seu capital social, relacionados no Anexo XI da Lei Complementar nº 214, de 2025, com a especificação das respectivas classificações da NBS e da NCM/SH, observado o art. 142 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações e prestações de serviços de segurança da informação e segurança cibernética desenvolvidos por sociedade que tenha sócio brasileiro (Anexo XI)")]
        [XmlEnum("200044")]
        CCTrib200044 = 200044,

        /// <summary>
        /// 200045 - Operações relacionadas a projetos de reabilitação urbana de zonas históricas e de áreas críticas de recuperação e reconversão urbanística
        /// Operações relacionadas a projetos de reabilitação urbana de zonas históricas e de áreas críticas de recuperação e reconversão urbanística dos Municípios ou do Distrito Federal, a serem delimitadas por lei municipal ou distrital, observado o art. 158 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações relacionadas a projetos de reabilitação urbana de zonas históricas e de áreas críticas de recuperação e reconversão urbanística")]
        [XmlEnum("200045")]
        CCTrib200045 = 200045,

        /// <summary>
        /// 200046 - Operações com bens imóveis
        /// Operações com bens imóveis, observado o art. 261 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações com bens imóveis")]
        [XmlEnum("200046")]
        CCTrib200046 = 200046,

        /// <summary>
        /// 200047 - Bares e Restaurantes
        /// Bares e Restaurantes, observado o art. 275 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Bares e Restaurantes")]
        [XmlEnum("200047")]
        CCTrib200047 = 200047,

        /// <summary>
        /// 200048 - Hotelaria, Parques de Diversão e Parques Temáticos
        /// Hotelaria, Parques de Diversão e Parques Temáticos, observado o art. 281 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Hotelaria, Parques de Diversão e Parques Temáticos")]
        [XmlEnum("200048")]
        CCTrib200048 = 200048,

        /// <summary>
        /// 200049 - Transporte coletivo de passageiros rodoviário, ferroviário e hidroviário
        /// Transporte coletivo de passageiros rodoviário, ferroviário e hidroviário intermunicipais e interestaduais, observado o art. 286 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Transporte coletivo de passageiros rodoviário, ferroviário e hidroviário")]
        [XmlEnum("200049")]
        CCTrib200049 = 200049,

        /// <summary>
        /// 200450 - Serviços de transporte aéreo regional coletivo de passageiros ou de carga
        /// Serviços de transporte aéreo regional coletivo de passageiros ou de carga, observado o art. 287 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Serviços de transporte aéreo regional coletivo de passageiros ou de carga")]
        [XmlEnum("200050")]
        CCTrib200050 = 200050,

        /// <summary>
        /// 200051 - Agências de Turismo
        /// Agências de Turismo, observado o art. 289 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Agências de Turismo")]
        [XmlEnum("200051")]
        CCTrib200051 = 200051,

        /// <summary>
        /// 200052 - Prestação de serviços de profissões intelectuais
        /// Prestação de serviços das seguintes profissões intelectuais de natureza científica, literária ou artística, submetidas à fiscalização por conselho profissional: administradores, advogados, arquitetos e urbanistas, assistentes sociais, bibliotecários, biólogos, contabilistas, economistas, economistas domésticos, profissionais de educação física, engenheiros e agrônomos, estatísticos, médicos veterinários e zootecnistas, museólogos, químicos, profissionais de relações públicas, técnicos industriais e técnicos agrícolas, observado o art. 127 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Prestação de serviços de profissões intelectuais")]
        [XmlEnum("200052")]
        CCTrib200052 = 200052,

        /// <summary>
        /// 200053 - Fornecimento de medicamentos registrados na Anvisa, quando  classificados como soros ou vacinas
        /// Fornecimento de medicamentos registrados na Anvisa, quando  classificados como soros ou vacinas, observado o art. 146 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de medicamentos registrados na Anvisa, quando  classificados como soros ou vacinas")]
        [XmlEnum("200053")]
        CCTrib200053 = 200053,

        /// <summary>
        /// 210001 - Redutor social aplicado uma única vez na alienação de bem imóvel residencial novo
        /// Redutor social aplicado uma única vez na alienação de bem imóvel residencial novo, observado o art. 259 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Redutor social aplicado uma única vez na alienação de bem imóvel residencial novo")]
        [XmlEnum("210001")]
        CCTrib210001 = 210001,

        /// <summary>
        /// 210002 - Redutor social aplicado uma única vez na alienação de lote residencial
        /// Redutor social aplicado uma única vez na alienação de lote residencial, observado o art. 259 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Redutor social aplicado uma única vez na alienação de lote residencial")]
        [XmlEnum("210002")]
        CCTrib210002 = 210002,

        /// <summary>
        /// 210003 - Redutor social em operações de locação, cessão onerosa e arrendamento de bens imóveis de uso residencial
        /// Redutor social em operações de locação, cessão onerosa e arrendamento de bens imóveis de uso residencial, observado o art. 260 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Redutor social em operações de locação, cessão onerosa e arrendamento de bens imóveis de uso residencial")]
        [XmlEnum("210003")]
        CCTrib210003 = 210003,

        /// <summary>
        /// 220001 - Incorporação imobiliária submetida ao regime especial de tributação
        /// Incorporação imobiliária submetida ao regime especial de tributação, observado o art. 485 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Incorporação imobiliária submetida ao regime especial de tributação")]
        [XmlEnum("220001")]
        CCTrib220001 = 220001,

        /// <summary>
        /// 220002 - Incorporação imobiliária submetida ao regime especial de tributação
        /// Incorporação imobiliária submetida ao regime especial de tributação, observado o art. 485 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Incorporação imobiliária submetida ao regime especial de tributação")]
        [XmlEnum("220002")]
        CCTrib220002 = 220002,

        /// <summary>
        /// 220003 - Alienação de imóvel decorrente de parcelamento do solo
        /// Alienação de imóvel decorrente de parcelamento do solo, observado o art. 486 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Alienação de imóvel decorrente de parcelamento do solo")]
        [XmlEnum("220003")]
        CCTrib220003 = 220003,

        /// <summary>
        /// 221001 - Locação, cessão onerosa ou arrendamento de bem imóvel com alíquota sobre a receita bruta
        /// Locação, cessão onerosa ou arrendamento de bem imóvel com alíquota sobre a receita bruta, observado o art. 487 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Locação, cessão onerosa ou arrendamento de bem imóvel com alíquota sobre a receita bruta")]
        [XmlEnum("221001")]
        CCTrib221001 = 221001,

        /// <summary>
        /// 222001 - Transporte internacional de passageiros, caso os trechos de ida e volta sejam vendidos em conjunto
        /// Transporte internacional de passageiros, caso os trechos de ida e volta sejam vendidos em conjunto, a base de cálculo será a metade do valor cobrado, observado o Art. 12 § 8º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Transporte internacional de passageiros, caso os trechos de ida e volta sejam vendidos em conjunto")]
        [XmlEnum("222001")]
        CCTrib222001 = 222001,

        /// <summary>
        /// 400001 - Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário
        /// Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário de caráter urbano, semiurbano e metropolitano, sob regime de autorização, permissão ou concessão pública, observado o art. 157 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário")]
        [XmlEnum("400001")]
        CCTrib400001 = 400001,

        /// <summary>
        /// 400002 - Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário com medição por quilômetro rodado
        /// Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário de caráter urbano, semiurbano e metropolitano, sob regime de autorização, permissão ou concessão pública, com medição por quilômetro rodado, observado o art. 157 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de serviços de transporte público coletivo de passageiros rodoviário e metroviário com medição por quilômetro rodado")]
        [XmlEnum("400002")]
        CCTrib400002 = 400002,

        /// <summary>
        /// 410001 - Fornecimento de bonificações quando constem no documento fiscal e que não dependam de evento posterior
        /// Fornecimento de bonificações quando constem do respectivo documento fiscal e que não dependam de evento posterior, observado o art. 5º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de bonificações quando constem no documento fiscal e que não dependam de evento posterior")]
        [XmlEnum("410001")]
        CCTrib410001 = 410001,

        /// <summary>
        /// 410002 - Transferências entre estabelecimentos pertencentes ao mesmo contribuinte
        /// Transferências entre estabelecimentos pertencentes ao mesmo contribuinte, observado o art. 6º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Transferências entre estabelecimentos pertencentes ao mesmo contribuinte")]
        [XmlEnum("410002")]
        CCTrib410002 = 410002,

        /// <summary>
        /// 410003 - Doações sem contraprestação em benefício do doador
        /// Doações, observado o art. 6º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Doações sem contraprestação em benefício do doador")]
        [XmlEnum("410003")]
        CCTrib410003 = 410003,

        /// <summary>
        /// 410004 - Exportações de bens e serviços
        /// Exportações de bens e serviços, observado o art. 8º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exportações de bens e serviços")]
        [XmlEnum("410004")]
        CCTrib410004 = 410004,

        /// <summary>
        /// 410005 - Fornecimentos realizados pela União, pelos Estados, pelo Distrito Federal e pelos Municípios
        /// Fornecimentos realizados pela União, pelos Estados, pelo Distrito Federal e pelos Municípios, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos realizados pela União, pelos Estados, pelo Distrito Federal e pelos Municípios")]
        [XmlEnum("410005")]
        CCTrib410005 = 410005,

        /// <summary>
        /// 410006 - Fornecimentos realizados por entidades religiosas e templos de qualquer culto
        /// Fornecimentos realizados por entidades religiosas e templos de qualquer culto, inclusive suas organizações assistenciais e beneficentes, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos realizados por entidades religiosas e templos de qualquer culto")]
        [XmlEnum("410006")]
        CCTrib410006 = 410006,

        /// <summary>
        /// 410007 - Fornecimentos realizados por partidos políticos
        /// Fornecimentos realizados por partidos políticos, inclusive suas fundações, entidades sindicais dos trabalhadores e instituições de educação e de assistência social, sem fins lucrativos, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos realizados por partidos políticos")]
        [XmlEnum("410007")]
        CCTrib410007 = 410007,

        /// <summary>
        /// 410008 - Fornecimentos de livros, jornais, periódicos e do papel destinado a sua impressão
        /// Fornecimentos de livros, jornais, periódicos e do papel destinado a sua impressão, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos de livros, jornais, periódicos e do papel destinado a sua impressão")]
        [XmlEnum("410008")]
        CCTrib410008 = 410008,

        /// <summary>
        /// 410009 - Fornecimentos de fonogramas e videofonogramas musicais produzidos no Brasil
        /// Fornecimentos de fonogramas e videofonogramas musicais produzidos no Brasil contendo obras musicais ou literomusicais de autores brasileiros e/ou obras em geral interpretadas por artistas brasileiros, bem como os suportes materiais ou arquivos digitais que os contenham, salvo na etapa de replicação industrial de mídias ópticas de leitura a laser, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos de fonogramas e videofonogramas musicais produzidos no Brasil")]
        [XmlEnum("410009")]
        CCTrib410009 = 410009,

        /// <summary>
        /// 410010 - Fornecimentos de serviço de comunicação nas modalidades de radiodifusão sonora e de sons e imagens de recepção livre e gratuita
        /// Fornecimentos de serviço de comunicação nas modalidades de radiodifusão sonora e de sons e imagens de recepção livre e  gratuita, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos de serviço de comunicação nas modalidades de radiodifusão sonora e de sons e imagens de recepção livre e gratuita")]
        [XmlEnum("410010")]
        CCTrib410010 = 410010,

        /// <summary>
        /// 410011 - Fornecimentos de ouro, quando definido em lei como ativo financeiro ou instrumento cambial
        /// Fornecimentos de ouro, quando definido em lei como ativo financeiro ou instrumento cambial, observado o art. 9º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimentos de ouro, quando definido em lei como ativo financeiro ou instrumento cambial")]
        [XmlEnum("410011")]
        CCTrib410011 = 410011,

        /// <summary>
        /// 410012 - Fornecimento de condomínio edilício não optante pelo regime regular
        /// Fornecimento de condomínio edilício não optante pelo regime regular, observado o art. 26 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de condomínio edilício não optante pelo regime regular")]
        [XmlEnum("410012")]
        CCTrib410012 = 410012,

        /// <summary>
        /// 410013 - Exportações de combustíveis
        /// Exportações de combustíveis, observado o art. 98 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exportações de combustíveis")]
        [XmlEnum("410013")]
        CCTrib410013 = 410013,

        /// <summary>
        /// 410014 - Fornecimento de produtor rural não contribuinte
        /// Fornecimento de produtor rural não contribuinte, observado o art. 164 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento de produtor rural não contribuinte")]
        [XmlEnum("410014")]
        CCTrib410014 = 410014,

        /// <summary>
        /// 410015 - Fornecimento por transportador autônomo não contribuinte
        /// Fornecimento por transportador autônomo não contribuinte, observado o art. 169 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento por transportador autônomo não contribuinte")]
        [XmlEnum("410015")]
        CCTrib410015 = 410015,

        /// <summary>
        /// 410016 - Fornecimento ou aquisição de resíduos sólidos
        /// Fornecimento ou aquisição de resíduos sólidos, observado o art. 170 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento ou aquisição de resíduos sólidos")]
        [XmlEnum("410016")]
        CCTrib410016 = 410016,

        /// <summary>
        /// 410017 - Aquisição de bem móvel com crédito presumido sob condição de revenda realizada
        /// Aquisição de bem móvel com crédito presumido sob condição de revenda realizada, observado o art. 171 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Aquisição de bem móvel com crédito presumido sob condição de revenda realizada")]
        [XmlEnum("410017")]
        CCTrib410017 = 410017,

        /// <summary>
        /// 410018 - Operações relacionadas aos fundos garantidores e executores de políticas públicas
        /// Operações relacionadas aos fundos garantidores e executores de políticas públicas, inclusive de habitação, previstos em lei, assim entendidas os serviços prestados ao fundo pelo seu agente operador e por entidade encarregada da sua administração, observado o art. 213 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações relacionadas aos fundos garantidores e executores de políticas públicas")]
        [XmlEnum("410018")]
        CCTrib410018 = 410018,

        /// <summary>
        /// 410019 - Exclusão da gorjeta na base de cálculo no fornecimento de alimentação
        /// Exclusão da gorjeta na base de cálculo no fornecimento de alimentação, observado o art. 274 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exclusão da gorjeta na base de cálculo no fornecimento de alimentação")]
        [XmlEnum("410019")]
        CCTrib410019 = 410019,

        /// <summary>
        /// 410020 - Exclusão do valor de intermediação na base de cálculo no fornecimento de alimentação
        /// Exclusão do valor de intermediação na base de cálculo no fornecimento de alimentação, observado o art. 274 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exclusão do valor de intermediação na base de cálculo no fornecimento de alimentação")]
        [XmlEnum("410020")]
        CCTrib410020 = 410020,

        /// <summary>
        /// 410021 - Contribuição de que trata o art. 149-A da Constituição Federal
        /// Contribuição de que trata o art. 149-A da Constituição Federal, observado o art. 12 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Contribuição de que trata o art. 149-A da Constituição Federal")]
        [XmlEnum("410021")]
        CCTrib410021 = 410021,

        /// <summary>
        /// 410022 - Consolidação da propriedade do bem pelo credor
        /// Consolidação da propriedade do bem pelo credor
        /// </summary>
        [Description("Consolidação da propriedade do bem pelo credor")]
        [XmlEnum("410022")]
        CCTrib410022 = 410022,

        /// <summary>
        /// 410023 - Alienação de bens móveis ou imóveis que tenham sido objeto de garantia em que o prestador da garantia não seja contribuinte
        /// Alienação de bens móveis ou imóveis que tenham sido objeto de garantia em que o prestador da garantia não seja contribuinte
        /// </summary>
        [Description("Alienação de bens móveis ou imóveis que tenham sido objeto de garantia em que o prestador da garantia não seja contribuinte")]
        [XmlEnum("410023")]
        CCTrib410023 = 410023,

        /// <summary>
        /// 410024 - Consolidação da propriedade do bem pelo grupo de consórcio
        /// Consolidação da propriedade do bem pelo grupo de consórcio
        /// </summary>
        [Description("Consolidação da propriedade do bem pelo grupo de consórcio")]
        [XmlEnum("410024")]
        CCTrib410024 = 410024,

        /// <summary>
        /// 410025 - Alienação de bem que tenha sido objeto de garantia em que o prestador da garantia não seja contribuinte
        /// Alienação de bem que tenha sido objeto de garantia em que o prestador da garantia não seja contribuinte
        /// </summary>
        [Description("Alienação de bem que tenha sido objeto de garantia em que o prestador da garantia não seja contribuinte")]
        [XmlEnum("410025")]
        CCTrib410025 = 410025,

        /// <summary>
        /// 410026 - Doação com anulação de crédito
        /// Doação com anulação de crédito
        /// </summary>
        [Description("Doação com anulação de crédito")]
        [XmlEnum("410026")]
        CCTrib410026 = 410026,

        /// <summary>
        /// 410027 - Exportação de serviço ou de bem imaterial
        /// Fornecimento de bens e serviços, desde que vinculados direta e exclusivamente à exportação de bens materiais ou associados à entrega no exterior de bens materiais, observado o art. 6º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exportação de serviço ou de bem imaterial")]
        [XmlEnum("410027")]
        CCTrib410027 = 410027,

        /// <summary>
        /// 410028 - Operações com bens imóveis realizadas por pessoas físicas não consideradas contribuintes
        /// Operações com bens imóveis realizadas por pessoas físicas não consideradas contribuintes
        /// </summary>
        [Description("Operações com bens imóveis realizadas por pessoas físicas não consideradas contribuintes")]
        [XmlEnum("410028")]
        CCTrib410028 = 410028,

        /// <summary>
        /// 410029 - Operações acobertadas somente pelo ICMS
        /// Operações acobertadas somente pelo ICMS
        /// </summary>
        [Description("Operações acobertadas somente pelo ICMS")]
        [XmlEnum("410029")]
        CCTrib410029 = 410029,

        /// <summary>
        /// 410030 - Estorno de crédito por perecimento, deteriorização, roubo, furto ou extravio.
        /// Estorno de crédito por perecimento, deteriorização, roubo, furto ou extravio.
        /// </summary>
        [Description("Estorno de crédito por perecimento, deteriorização, roubo, furto ou extravio.")]
        [XmlEnum("410030")]
        CCTrib410030 = 410030,

        /// <summary>
        /// 410031 - Fornecimento em período anterior ao início de vigência de incidências de CBS e IBS
        /// Fornecimento em período anterior ao início de vigência de incidências de CBS e IBS
        /// </summary>
        [Description("Fornecimento em período anterior ao início de vigência de incidências de CBS e IBS")]
        [XmlEnum("410031")]
        CCTrib410031 = 410031,

        /// <summary>
        /// 410032 - Tributos incidentes na operação que não integram a base de cálculo do IBS e da CBS
        /// Tributos incidentes na operação que não integram a base de cálculo do IBS e da CBS, observado o art. 12 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributos incidentes na operação que não integram a base de cálculo do IBS e da CBS")]
        [XmlEnum("410032")]
        CCTrib410032 = 410032,

        /// <summary>
        /// 410033 - Operações de Fundos de Investimento Imobiliário (FII) e Fundos de Investimento nas Cadeias Produtivas do Agronegócio (Fiagro)
        /// Operações com bens imóveis, inclusive operações com direitos reais sobre bens imóveis, realizadas por Fundos de Investimento Imobiliário (FII) e Fundos de Investimento nas Cadeias Produtivas do Agronegócio (Fiagro), observado o art. 26 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações de Fundos de Investimento Imobiliário (FII) e Fundos de Investimento nas Cadeias Produtivas do Agronegócio (Fiagro)")]
        [XmlEnum("410033")]
        CCTrib410033 = 410033,

        /// <summary>
        /// 410034 - Operações de fundos de investimento
        /// Fundos de investimento cujo patrimônio seja constituído exclusivamente por aplicações em participações societárias, certificados, direitos, títulos, valores mobiliários e demais ativos financeiros permitidos pela Comissão de Valores Mobiliários, observado o art. 26 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações de fundos de investimento")]
        [XmlEnum("410034")]
        CCTrib410034 = 410034,

        /// <summary>
        /// 410035 - Fornecimento realizado por nanoempreendedor
        /// Fornecimento realizado por nanoempreendedor, observado o art. 226 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fornecimento realizado por nanoempreendedor")]
        [XmlEnum("410035")]
        CCTrib410035 = 410035,

        /// <summary>
        /// 410999 - Operações não onerosas sem previsão de tributação, não especificadas anteriormente
        /// Operações não onerosas sem previsão de tributação, não especificadas anteriormente, observado o art. 4º da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações não onerosas sem previsão de tributação, não especificadas anteriormente")]
        [XmlEnum("410999")]
        CCTrib410999 = 410999,

        /// <summary>
        /// 510001 - Operações, sujeitas a diferimento, com energia elétrica, relativas à geração, comercialização, distribuição e transmissão
        /// Operações, sujeitas a diferimento, com energia elétrica ou com direitos a ela relacionados, relativas à importação, geração, comercialização, distribuição e transmissão, observado o art. 28 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações, sujeitas a diferimento, com energia elétrica, relativas à geração, comercialização, distribuição e transmissão")]
        [XmlEnum("510001")]
        CCTrib510001 = 510001,

        /// <summary>
        /// 515001 - Operações, sujeitas a diferimento, com insumos agropecuários e aquícolas (Anexo IX)
        /// Operações, sujeitas a diferimento, com insumos agropecuários e aquícolas (Anexo IX)
        /// </summary>
        [Description("Operações, sujeitas a diferimento, com insumos agropecuários e aquícolas (Anexo IX)")]
        [XmlEnum("515001")]
        CCTrib515001 = 515001,

        /// <summary>
        /// 550001 - Exportações de bens materiais
        /// Exportações de bens materiais, observado o art. 82 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Exportações de bens materiais")]
        [XmlEnum("550001")]
        CCTrib550001 = 550001,

        /// <summary>
        /// 550002 - Regime de Trânsito
        /// Regime de Trânsito, observado o art. 84 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime de Trânsito")]
        [XmlEnum("550002")]
        CCTrib550002 = 550002,

        /// <summary>
        /// 550003 - Regimes de Depósito  (art. 85)
        /// Regimes de Depósito, observado o art. 85 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regimes de Depósito  (art. 85)")]
        [XmlEnum("550003")]
        CCTrib550003 = 550003,

        /// <summary>
        /// 550004 - Regimes de Depósito (art. 87)
        /// Regimes de Depósito, observado o art. 87 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regimes de Depósito (art. 87)")]
        [XmlEnum("550004")]
        CCTrib550004 = 550004,

        /// <summary>
        /// 550005 - Regimes de Depósito (art. 87, Parágrafo único)
        /// Regimes de Depósito, observado o art. 87 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regimes de Depósito (art. 87, Parágrafo único)")]
        [XmlEnum("550005")]
        CCTrib550005 = 550005,

        /// <summary>
        /// 550006 - Regimes de Permanência Temporária
        /// Regimes de Permanência Temporária, observado o art. 88 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regimes de Permanência Temporária")]
        [XmlEnum("550006")]
        CCTrib550006 = 550006,

        /// <summary>
        /// 550007 - Regimes de Aperfeiçoamento
        /// Regimes de Aperfeiçoamento, observado o art. 90 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regimes de Aperfeiçoamento")]
        [XmlEnum("550007")]
        CCTrib550007 = 550007,

        /// <summary>
        /// 550008 - Importação de bens para o Regime de Repetro-Temporário
        /// Importação de bens para o Regime de Repetro-Temporário, de que tratam o inciso I do art. 93 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Importação de bens para o Regime de Repetro-Temporário")]
        [XmlEnum("550008")]
        CCTrib550008 = 550008,

        /// <summary>
        /// 550009 - GNL-Temporário
        /// GNL-Temporário, de que trata o inciso II do art. 93 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("GNL-Temporário")]
        [XmlEnum("550009")]
        CCTrib550009 = 550009,

        /// <summary>
        /// 550010 - Repetro-Permanente
        /// Repetro-Permanente, de que trata o inciso III do art. 93 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Repetro-Permanente")]
        [XmlEnum("550010")]
        CCTrib550010 = 550010,

        /// <summary>
        /// 550011 - Repetro-Industrialização
        /// Repetro-Industrialização, de que trata o inciso IV do art. 93 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Repetro-Industrialização")]
        [XmlEnum("550011")]
        CCTrib550011 = 550011,

        /// <summary>
        /// 550012 - Repetro-Nacional
        /// Repetro-Nacional, de que trata o inciso V do art. 93 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Repetro-Nacional")]
        [XmlEnum("550012")]
        CCTrib550012 = 550012,

        /// <summary>
        /// 550013 - Repetro-Entreposto
        /// Repetro-Entreposto, de que trata o inciso VI do art. 93 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Repetro-Entreposto")]
        [XmlEnum("550013")]
        CCTrib550013 = 550013,

        /// <summary>
        /// 550014 - Zona de Processamento de Exportação
        /// Zona de Processamento de Exportação, observado os arts. 99, 100 e 102 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Zona de Processamento de Exportação")]
        [XmlEnum("550014")]
        CCTrib550014 = 550014,

        /// <summary>
        /// 550015 - Regime Tributário para Incentivo à Modernização e à Ampliação da Estrutura Portuária
        /// Regime Tributário para Incentivo à Modernização e à Ampliação da Estrutura Portuária - Reporto, observado o art. 105 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime Tributário para Incentivo à Modernização e à Ampliação da Estrutura Portuária")]
        [XmlEnum("550015")]
        CCTrib550015 = 550015,

        /// <summary>
        /// 550016 - Regime Especial de Incentivos para o Desenvolvimento da Infraestrutura
        /// Regime Especial de Incentivos para o Desenvolvimento da Infraestrutura - Reidi, observado o art. 106 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime Especial de Incentivos para o Desenvolvimento da Infraestrutura")]
        [XmlEnum("550016")]
        CCTrib550016 = 550016,

        /// <summary>
        /// 550017 - Regime Tributário para Incentivo à Atividade Econômica Naval
        /// Regime Tributário para Incentivo à Atividade Econômica Naval – Renaval, observado o art. 107 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime Tributário para Incentivo à Atividade Econômica Naval")]
        [XmlEnum("550017")]
        CCTrib550017 = 550017,

        /// <summary>
        /// 550018 - Desoneração da aquisição de bens de capital
        /// Desoneração da aquisição de bens de capital, observado o art. 109 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Desoneração da aquisição de bens de capital")]
        [XmlEnum("550018")]
        CCTrib550018 = 550018,

        /// <summary>
        /// 550019 - Importação de bem material por indústria incentivada para utilização na ZFM
        /// Importação de bem material por indústria incentivada para utilização na Zona Franca de Manaus, observado o art. 443 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Importação de bem material por indústria incentivada para utilização na ZFM")]
        [XmlEnum("550019")]
        CCTrib550019 = 550019,

        /// <summary>
        /// 550020 - Áreas de livre comércio
        /// Áreas de livre comércio, observado o art. 461 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Áreas de livre comércio")]
        [XmlEnum("550020")]
        CCTrib550020 = 550020,

        /// <summary>
        /// 550021 - Industrialização destinada a exportações
        /// Industrialização destinada a exportações
        /// </summary>
        [Description("Industrialização destinada a exportações")]
        [XmlEnum("550021")]
        CCTrib550021 = 550021,

        /// <summary>
        /// 550022 - Regime Especial de Incentivos para a Produção de Hidrogênio de Baixa Emissão de Carbono (Rehidro)
        /// Regime Especial de Incentivos para a Produção de Hidrogênio de Baixa Emissão de Carbono (Rehidro),  observado o art. 106 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Regime Especial de Incentivos para a Produção de Hidrogênio de Baixa Emissão de Carbono (Rehidro)")]
        [XmlEnum("550022")]
        CCTrib550022 = 550022,

        /// <summary>
        /// 550023 - Operações com hidrocarbonetos líquidos derivados de petróleo não combustíveis ou de gás natural, inclusive nafta
        /// Operações com hidrocarbonetos líquidos derivados de petróleo não combustíveis ou de gás natural, inclusive nafta, observado o art. 172 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Operações com hidrocarbonetos líquidos derivados de petróleo não combustíveis ou de gás natural, inclusive nafta")]
        [XmlEnum("550023")]
        CCTrib550023 = 550023,

        /// <summary>
        /// 620001 - Tributação monofásica sobre combustíveis
        /// Tributação monofásica sobre combustíveis, observados os art. 172 e   art. 179 I da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributação monofásica sobre combustíveis")]
        [XmlEnum("620001")]
        CCTrib620001 = 620001,

        /// <summary>
        /// 620002 - Tributação monofásica com responsabilidade pela retenção sobre combustíveis
        /// Tributação monofásica com responsabilidade pela retenção sobre combustíveis, observado o art. 178 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributação monofásica com responsabilidade pela retenção sobre combustíveis")]
        [XmlEnum("620002")]
        CCTrib620002 = 620002,

        /// <summary>
        /// 620003 - Tributação monofásica com tributos retidos por responsabilidade sobre combustíveis
        /// Tributação monofásica com tributos retidos por responsabilidade sobre combustíveis, observado o art. 178 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributação monofásica com tributos retidos por responsabilidade sobre combustíveis")]
        [XmlEnum("620003")]
        CCTrib620003 = 620003,

        /// <summary>
        /// 620004 - Tributação monofásica sobre mistura de EAC com gasolina A em percentual superior ao obrigatório
        /// Tributação monofásica sobre mistura de EAC com gasolina A em percentual superior ou inferior ao obrigatório, observado o art. 179 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributação monofásica sobre mistura de EAC com gasolina A em percentual superior ao obrigatório")]
        [XmlEnum("620004")]
        CCTrib620004 = 620004,

        /// <summary>
        /// 620005 - Tributação monofásica sobre mistura de EAC com gasolina A em percentual inferior ao obrigatório
        /// Tributação monofásica sobre mistura de EAC com gasolina A em percentual superior ou inferior ao obrigatório, observado o art. 179 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributação monofásica sobre mistura de EAC com gasolina A em percentual inferior ao obrigatório")]
        [XmlEnum("620005")]
        CCTrib620005 = 620005,

        /// <summary>
        /// 620006 - Tributação monofásica sobre combustíveis cobrada anteriormente
        /// Tributação monofásica sobre combustíveis cobrada anteriormente, observador o art. 180 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Tributação monofásica sobre combustíveis cobrada anteriormente")]
        [XmlEnum("620006")]
        CCTrib620006 = 620006,

        /// <summary>
        /// 800001 - Fusão, cisão ou incorporação
        /// Fusão, cisão ou incorporação, observado o art. 55 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Fusão, cisão ou incorporação")]
        [XmlEnum("800001")]
        CCTrib800001 = 800001,

        /// <summary>
        /// 800002 - Transferência de crédito do associado, inclusive as cooperativas singulares
        /// Transferência de crédito do associado, inclusive as cooperativas singulares, para cooperativa de que participa das operações antecedentes às operações em que fornece bens e serviços e os créditos presumidos, observado o art. 272 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Transferência de crédito do associado, inclusive as cooperativas singulares")]
        [XmlEnum("800002")]
        CCTrib800002 = 800002,

        /// <summary>
        /// 810001 - Crédito presumido sobre o valor apurado nos fornecimentos a partir da ZFM
        /// Crédito presumido sobre o valor apurado nos fornecimentos a partir da Zona Franca de Manaus, observado o art. 450 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido sobre o valor apurado nos fornecimentos a partir da ZFM")]
        [XmlEnum("810001")]
        CCTrib810001 = 810001,

        /// <summary>
        /// 811001 - Anulação de Crédito por Saídas Imunes/Isentas
        /// Anulação de Crédito por Saídas Imunes/Isentas
        /// </summary>
        [Description("Anulação de Crédito por Saídas Imunes/Isentas")]
        [XmlEnum("811001")]
        CCTrib811001 = 811001,

        /// <summary>
        /// 811002 - Débitos de notas fiscais não processadas na apuração
        /// Débitos de notas fiscais não processadas na apuração
        /// </summary>
        [Description("Débitos de notas fiscais não processadas na apuração")]
        [XmlEnum("811002")]
        CCTrib811002 = 811002,

        /// <summary>
        /// 811003 - Desenquadramento do Simples Nacional
        /// Desenquadramento do Simples Nacional
        /// </summary>
        [Description("Desenquadramento do Simples Nacional")]
        [XmlEnum("811003")]
        CCTrib811003 = 811003,

        /// <summary>
        /// 820001 - Documento com informações de fornecimento de serviços de planos de assistência à saúde
        /// Documento com informações de fornecimento de serviços de planos de assinstência à saúde, mas com tributação realizada por outro meio, observado o art. 235 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Documento com informações de fornecimento de serviços de planos de assistência à saúde")]
        [XmlEnum("820001")]
        CCTrib820001 = 820001,

        /// <summary>
        /// 820002 - Documento com informações de fornecimento de serviços de planos de assistência funerária
        /// Documento com informações de fornecimento de serviços de planos de assinstência funerária, mas com tributação realizada por outro meio, observado o art. 236 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Documento com informações de fornecimento de serviços de planos de assistência funerária")]
        [XmlEnum("820002")]
        CCTrib820002 = 820002,

        /// <summary>
        /// 820003 - Documento com informações de fornecimento de serviços de planos de assistência à saúde de animais domésticos
        /// Documento com informações de fornecimento de serviços de planos de assinstência à saúde de animais domésticos, mas com tributação realizada por outro meio, observado o art. 243 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Documento com informações de fornecimento de serviços de planos de assistência à saúde de animais domésticos")]
        [XmlEnum("820003")]
        CCTrib820003 = 820003,

        /// <summary>
        /// 820004 - Documento com informações de prestação de serviços de consursos de prognósticos
        /// Documento com informações de prestação de serviços de consursos de prognósticos, mas com tributação realizada por outro meio, observado o art. 248 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Documento com informações de prestação de serviços de consursos de prognósticos")]
        [XmlEnum("820004")]
        CCTrib820004 = 820004,

        /// <summary>
        /// 820005 - Documento com informações de alienação de bens imóveis
        /// Documento com informações de alienação de bens imóveis, mas com tributação realizada por outro meio,, observado o art. 254 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Documento com informações de alienação de bens imóveis")]
        [XmlEnum("820005")]
        CCTrib820005 = 820005,

        /// <summary>
        /// 820006 - Documento com informações de fornecimento de serviços de exploração de via
        /// Documento com informações de fornecimento de serviços de exploração de via, mas com tributação realizada por outro meio, observado o art. 11 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Documento com informações de fornecimento de serviços de exploração de via")]
        [XmlEnum("820006")]
        CCTrib820006 = 820006,

        /// <summary>
        /// 820007 - Documento com informações de fornecimento de serviços financeiros
        /// Documento com informações de fornecimento de serviços financeiros
        /// </summary>
        [Description("Documento com informações de fornecimento de serviços financeiros")]
        [XmlEnum("820007")]
        CCTrib820007 = 820007,

        /// <summary>
        /// 820008 - Documento com informações de fornecimento, mas com tributação realizada em fatura anterior
        /// Documento com informações de fornecimento, mas com tributação realizada em fatura anterior
        /// </summary>
        [Description("Documento com informações de fornecimento, mas com tributação realizada em fatura anterior")]
        [XmlEnum("820008")]
        CCTrib820008 = 820008,

        /// <summary>
        /// 820009 - Cobrança relativa a fornecimentos declarados em outro documento
        /// Cobrança relativa a fornecimentos declarados em outro documento, observado o art. xxx da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Cobrança relativa a fornecimentos declarados em outro documento")]
        [XmlEnum("820009")]
        CCTrib820009 = 820009,

        /// <summary>
        /// 830001 - Documento com exclusão da BC da CBS e do IBS de energia elétrica fornecida pela distribuidora à UC
        /// Documento com  exclusão da base de cálculo da CBS e do IBS refrente à energia elétrica fornecida pela distribuidora à unidade consumidora, conforme  Art 28, parágrafos 3° e 4°.
        /// </summary>
        [Description("Documento com exclusão da BC da CBS e do IBS de energia elétrica fornecida pela distribuidora à UC")]
        [XmlEnum("830001")]
        CCTrib830001 = 830001,

    }

    // NT2025.002
    /// <summary>
    ///     <para>1 - Crédito presumido da aquisição de bens e serviços de produtor rural e produtor rural integrado não contribuinte, observado o art. 168 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>2 - Crédito presumido da aquisição de serviço de transportador autônomo de carga pessoa física não contribuinte, observado o art. 169 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>3 - Crédito presumido da aquisição de resíduos e demais materiais destinados à reciclagem, reutilização ou logística reversa adquiridos de pessoa física, cooperativa ou outra forma de organização popular, observado o art. 170 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>4 - Crédito presumido da aquisição de bens móveis usados de pessoa física não contribuinte para revenda, observado o art. 171 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>5 - Crédito presumido no regime automotivo, observado o art. 310 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>6 - Crédito presumido no regime automotivo, observado o art. 311 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>7 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 444 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>8 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 447 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>9 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 447 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>10 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 450 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>11 - Crédito presumido na aquisição por contribuinte na Área de Livre Comércio, observado o art. 462 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>12 - Crédito presumido na aquisição por contribuinte na Área de Livre Comércio, observado o art. 465 da Lei Complementar nº 214, de 2025.</para>
    ///     <para>13 - Crédito presumido na aquisição pela indústria na Área de Livre Comércio, observado o art. 467 da Lei Complementar nº 214, de 2025.</para>
    /// </summary>
    public enum cClassPresIBSCBS
    {
        /// <summary>
        /// 1 - Crédito presumido da aquisição de bens e serviços de produtor rural e produtor rural integrado não contribuinte, observado o art. 168 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido da aquisição de bens e serviços de produtor rural e produtor rural integrado não contribuinte, observado o art. 168 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("01")]
        CCPres1 = 1,

        /// <summary>
        /// 2 - Crédito presumido da aquisição de serviço de transportador autônomo de carga pessoa física não contribuinte, observado o art. 169 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido da aquisição de serviço de transportador autônomo de carga pessoa física não contribuinte, observado o art. 169 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("02")]
        CCPres2 = 2,

        /// <summary>
        /// 3 - Crédito presumido da aquisição de resíduos e demais materiais destinados à reciclagem, reutilização ou logística reversa adquiridos de pessoa física, cooperativa ou outra forma de organização popular, observado o art. 170 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido da aquisição de resíduos e demais materiais destinados à reciclagem, reutilização ou logística reversa adquiridos de pessoa física, cooperativa ou outra forma de organização popular, observado o art. 170 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("03")]
        CCPres3 = 3,

        /// <summary>
        /// 4 - Crédito presumido da aquisição de bens móveis usados de pessoa física não contribuinte para revenda, observado o art. 171 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido da aquisição de bens móveis usados de pessoa física não contribuinte para revenda, observado o art. 171 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("04")]
        CCPres4 = 4,

        /// <summary>
        /// 5 - Crédito presumido no regime automotivo, observado o art. 310 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido no regime automotivo, observado o art. 310 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("05")]
        CCPres5 = 5,

        /// <summary>
        /// 6 - Crédito presumido no regime automotivo, observado o art. 311 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido no regime automotivo, observado o art. 311 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("06")]
        CCPres6 = 6,

        /// <summary>
        /// 7 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 444 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 444 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("07")]
        CCPres7 = 7,

        /// <summary>
        /// 8 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 447 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 447 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("08")]
        CCPres8 = 8,

        /// <summary>
        /// 9 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 447 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 447 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("09")]
        CCPres9 = 9,

        /// <summary>
        /// 10 - Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 450 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição por contribuinte na Zona Franca de Manaus, observado o art. 450 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("10")]
        CCPres10 = 10,

        /// <summary>
        /// 11 - Crédito presumido na aquisição por contribuinte na Área de Livre Comércio, observado o art. 462 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição por contribuinte na Área de Livre Comércio, observado o art. 462 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("11")]
        CCPres11 = 11,

        /// <summary>
        /// 12 - Crédito presumido na aquisição por contribuinte na Área de Livre Comércio, observado o art. 465 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição por contribuinte na Área de Livre Comércio, observado o art. 465 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("12")]
        CCPres12 = 12,

        /// <summary>
        /// 13 - Crédito presumido na aquisição pela indústria na Área de Livre Comércio, observado o art. 467 da Lei Complementar nº 214, de 2025.
        /// </summary>
        [Description("Crédito presumido na aquisição pela indústria na Área de Livre Comércio, observado o art. 467 da Lei Complementar nº 214, de 2025.")]
        [XmlEnum("13")]
        CCPres13 = 13,

    }

    // NT2025.002
    /// <summary>
    ///     <para>0 - Sem Crédito Presumido</para>
    ///     <para>1 - Bens de consumo final (55%)</para>
    ///     <para>2 - Bens de capital (75%)</para>
    ///     <para>3 - Bens intermediários (90,25%)</para> 
    ///     <para>4 - Bens de informática e outros definidos em legislação (100%)</para>
    /// </summary>
    public enum TipoCredPresIBSZFM
    {
        /// <summary>
        ///	0 - Sem Crédito Presumido 
        /// </summary>
        [Description("Sem Crédito Presumido")]
        [XmlEnum("0")]
        tcpZFM0 = 0,

        /// <summary>
        /// 1 - Bens de consumo final (55%) 
        /// </summary>
        [Description("Bens de consumo final (55%)")]
        [XmlEnum("1")]
        tcpZFM1 = 1,

        /// <summary>
        /// 2 - Bens de capital (75%) 
        /// </summary>
        [Description("Bens de capital (75%)")]
        [XmlEnum("2")]
        tcpZFM2 = 2,

        /// <summary>
        /// 3 - Bens intermediários (90,25%) 
        /// </summary>
        [Description("Bens intermediários (90,25%)")]
        [XmlEnum("3")]
        tcpZFM3 = 3,

        /// <summary>
        /// 4 - Bens de informática e outros definidos em legislação (100%) 
        /// </summary>
        [Description("Bens de informática e outros definidos em legislação (100%)")]
        [XmlEnum("4")]
        tcpZFM4 = 4,

    }
}
