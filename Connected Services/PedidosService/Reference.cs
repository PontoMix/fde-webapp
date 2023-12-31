﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosService
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarSituacaoPedido", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public enum ConsultarSituacaoPedido : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Default = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ativo = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cancelado = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EntregaAutorizada = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SaiuParaEntrega = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Entregue = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pedido", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class Pedido : object
    {
        
        private string CodEntidadeField;
        
        private string CodEntidadePaiField;
        
        private string CodProduto_FornecedorField;
        
        private int CodTipoEntidadeField;
        
        private int CodTipoEntidadePaiField;
        
        private System.DateTime DataAberturaPedidoField;
        
        private string DescricaoStatusField;
        
        private string EntidadeBairroField;
        
        private string EntidadeCEPField;
        
        private string EntidadeContatoPrimarioField;
        
        private string EntidadeContatoSecundarioField;
        
        private string EntidadeLogradouroField;
        
        private string EntidadeMunicipioField;
        
        private string EntidadeNumeroLogradouroField;
        
        private string EntidadeTelefoneField;
        
        private PedidosService.PedidoItem[] ListaItemPedidoField;
        
        private string MensagemField;
        
        private string NomeEntidadeField;
        
        private string NomeEntidadePaiField;
        
        private string NomeTipoEntidadeField;
        
        private string NomeTipoEntidadePaiField;
        
        private string NumeroAtaField;
        
        private int NumeroPedidoField;
        
        private bool StatusField;
        
        private int StatusPedidoField;
        
        private decimal ValorTotalPedidoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodEntidade
        {
            get
            {
                return this.CodEntidadeField;
            }
            set
            {
                this.CodEntidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodEntidadePai
        {
            get
            {
                return this.CodEntidadePaiField;
            }
            set
            {
                this.CodEntidadePaiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodProduto_Fornecedor
        {
            get
            {
                return this.CodProduto_FornecedorField;
            }
            set
            {
                this.CodProduto_FornecedorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodTipoEntidade
        {
            get
            {
                return this.CodTipoEntidadeField;
            }
            set
            {
                this.CodTipoEntidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodTipoEntidadePai
        {
            get
            {
                return this.CodTipoEntidadePaiField;
            }
            set
            {
                this.CodTipoEntidadePaiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAberturaPedido
        {
            get
            {
                return this.DataAberturaPedidoField;
            }
            set
            {
                this.DataAberturaPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoStatus
        {
            get
            {
                return this.DescricaoStatusField;
            }
            set
            {
                this.DescricaoStatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeBairro
        {
            get
            {
                return this.EntidadeBairroField;
            }
            set
            {
                this.EntidadeBairroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeCEP
        {
            get
            {
                return this.EntidadeCEPField;
            }
            set
            {
                this.EntidadeCEPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeContatoPrimario
        {
            get
            {
                return this.EntidadeContatoPrimarioField;
            }
            set
            {
                this.EntidadeContatoPrimarioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeContatoSecundario
        {
            get
            {
                return this.EntidadeContatoSecundarioField;
            }
            set
            {
                this.EntidadeContatoSecundarioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeLogradouro
        {
            get
            {
                return this.EntidadeLogradouroField;
            }
            set
            {
                this.EntidadeLogradouroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeMunicipio
        {
            get
            {
                return this.EntidadeMunicipioField;
            }
            set
            {
                this.EntidadeMunicipioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeNumeroLogradouro
        {
            get
            {
                return this.EntidadeNumeroLogradouroField;
            }
            set
            {
                this.EntidadeNumeroLogradouroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntidadeTelefone
        {
            get
            {
                return this.EntidadeTelefoneField;
            }
            set
            {
                this.EntidadeTelefoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PedidosService.PedidoItem[] ListaItemPedido
        {
            get
            {
                return this.ListaItemPedidoField;
            }
            set
            {
                this.ListaItemPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                this.MensagemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeEntidade
        {
            get
            {
                return this.NomeEntidadeField;
            }
            set
            {
                this.NomeEntidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeEntidadePai
        {
            get
            {
                return this.NomeEntidadePaiField;
            }
            set
            {
                this.NomeEntidadePaiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeTipoEntidade
        {
            get
            {
                return this.NomeTipoEntidadeField;
            }
            set
            {
                this.NomeTipoEntidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeTipoEntidadePai
        {
            get
            {
                return this.NomeTipoEntidadePaiField;
            }
            set
            {
                this.NomeTipoEntidadePaiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroAta
        {
            get
            {
                return this.NumeroAtaField;
            }
            set
            {
                this.NumeroAtaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroPedido
        {
            get
            {
                return this.NumeroPedidoField;
            }
            set
            {
                this.NumeroPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StatusPedido
        {
            get
            {
                return this.StatusPedidoField;
            }
            set
            {
                this.StatusPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ValorTotalPedido
        {
            get
            {
                return this.ValorTotalPedidoField;
            }
            set
            {
                this.ValorTotalPedidoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PedidoItem", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class PedidoItem : object
    {
        
        private string CodEntidadeField;
        
        private string CodProduto_FornecedorField;
        
        private string DescricaoStatusItemField;
        
        private string MensagemField;
        
        private string NaturezaDespesaField;
        
        private string NumeroFDEItemField;
        
        private int NumeroFDEOSOFField;
        
        private int NumeroIdPedidoItemField;
        
        private string NumeroOSOFField;
        
        private int NumeroPedidoField;
        
        private int NumeroProdutoField;
        
        private bool PossuiOcorrenciaField;
        
        private int QuantidadeItemPedidoField;
        
        private bool StatusField;
        
        private int StatusItemField;
        
        private string TipoEmbalagemField;
        
        private string UnidadeFornecimentoField;
        
        private System.Nullable<decimal> ValorUnitarioItemPedidoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodEntidade
        {
            get
            {
                return this.CodEntidadeField;
            }
            set
            {
                this.CodEntidadeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodProduto_Fornecedor
        {
            get
            {
                return this.CodProduto_FornecedorField;
            }
            set
            {
                this.CodProduto_FornecedorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoStatusItem
        {
            get
            {
                return this.DescricaoStatusItemField;
            }
            set
            {
                this.DescricaoStatusItemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                this.MensagemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NaturezaDespesa
        {
            get
            {
                return this.NaturezaDespesaField;
            }
            set
            {
                this.NaturezaDespesaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroFDEItem
        {
            get
            {
                return this.NumeroFDEItemField;
            }
            set
            {
                this.NumeroFDEItemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroFDEOSOF
        {
            get
            {
                return this.NumeroFDEOSOFField;
            }
            set
            {
                this.NumeroFDEOSOFField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroIdPedidoItem
        {
            get
            {
                return this.NumeroIdPedidoItemField;
            }
            set
            {
                this.NumeroIdPedidoItemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroOSOF
        {
            get
            {
                return this.NumeroOSOFField;
            }
            set
            {
                this.NumeroOSOFField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroPedido
        {
            get
            {
                return this.NumeroPedidoField;
            }
            set
            {
                this.NumeroPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroProduto
        {
            get
            {
                return this.NumeroProdutoField;
            }
            set
            {
                this.NumeroProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PossuiOcorrencia
        {
            get
            {
                return this.PossuiOcorrenciaField;
            }
            set
            {
                this.PossuiOcorrenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuantidadeItemPedido
        {
            get
            {
                return this.QuantidadeItemPedidoField;
            }
            set
            {
                this.QuantidadeItemPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StatusItem
        {
            get
            {
                return this.StatusItemField;
            }
            set
            {
                this.StatusItemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoEmbalagem
        {
            get
            {
                return this.TipoEmbalagemField;
            }
            set
            {
                this.TipoEmbalagemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UnidadeFornecimento
        {
            get
            {
                return this.UnidadeFornecimentoField;
            }
            set
            {
                this.UnidadeFornecimentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ValorUnitarioItemPedido
        {
            get
            {
                return this.ValorUnitarioItemPedidoField;
            }
            set
            {
                this.ValorUnitarioItemPedidoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
    public partial class RegraExcecao : object
    {
        
        private string MensagemField;
        
        private bool StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                this.MensagemField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AlterarSituacaoPedido", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public enum AlterarSituacaoPedido : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Default = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EntregaAutorizada = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SaiuParaEntrega = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Entregue = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Confirmations", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class Confirmations : object
    {
        
        private string SituacaoRetornoField;
        
        private bool StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SituacaoRetorno
        {
            get
            {
                return this.SituacaoRetornoField;
            }
            set
            {
                this.SituacaoRetornoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PedidosService.IPedido")]
    public interface IPedido
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedido/RetornaPedidos", ReplyAction="http://tempuri.org/IPedido/RetornaPedidosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PedidosService.RegraExcecao), Action="http://tempuri.org/IPedido/RetornaPedidosRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<PedidosService.Pedido[]> RetornaPedidosAsync(string Chave1, string Chave2, string NumeroAta, System.DateTime DtInicial, System.DateTime DtFinal, PedidosService.ConsultarSituacaoPedido SituacaoPedido, System.Nullable<int> NumeroPedido, string NumeroOSOF, string CodEntidadePai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedido/RetornaPedidosItens", ReplyAction="http://tempuri.org/IPedido/RetornaPedidosItensResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PedidosService.RegraExcecao), Action="http://tempuri.org/IPedido/RetornaPedidosItensRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<PedidosService.Pedido[]> RetornaPedidosItensAsync(string Chave1, string Chave2, string NumeroAta, System.DateTime DtInicial, System.DateTime DtFinal, PedidosService.ConsultarSituacaoPedido SituacaoPedido, System.Nullable<int> NumeroPedido, string NumeroOSOF, string CodEntidadePai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedido/RetornaItens", ReplyAction="http://tempuri.org/IPedido/RetornaItensResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PedidosService.RegraExcecao), Action="http://tempuri.org/IPedido/RetornaItensRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<PedidosService.PedidoItem[]> RetornaItensAsync(string Chave1, string Chave2, int NumeroPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedido/AtualizaStatusPedido", ReplyAction="http://tempuri.org/IPedido/AtualizaStatusPedidoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PedidosService.RegraExcecao), Action="http://tempuri.org/IPedido/AtualizaStatusPedidoRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<PedidosService.Confirmations> AtualizaStatusPedidoAsync(string chave1, string chave2, int numeroPedido, PedidosService.AlterarSituacaoPedido SituacaoPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedido/AtualizaStatusPedidoDetalhe", ReplyAction="http://tempuri.org/IPedido/AtualizaStatusPedidoDetalheResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PedidosService.RegraExcecao), Action="http://tempuri.org/IPedido/AtualizaStatusPedidoDetalheRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<PedidosService.Confirmations> AtualizaStatusPedidoDetalheAsync(string chave1, string chave2, int numeroPedido, int numeroPedidoDetalhe, PedidosService.AlterarSituacaoPedido SituacaoPedido);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IPedidoChannel : PedidosService.IPedido, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class PedidoClient : System.ServiceModel.ClientBase<PedidosService.IPedido>, PedidosService.IPedido
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PedidoClient() : 
                base(PedidoClient.GetDefaultBinding(), PedidoClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPedido.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidoClient(EndpointConfiguration endpointConfiguration) : 
                base(PedidoClient.GetBindingForEndpoint(endpointConfiguration), PedidoClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidoClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PedidoClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidoClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PedidoClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PedidoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<PedidosService.Pedido[]> RetornaPedidosAsync(string Chave1, string Chave2, string NumeroAta, System.DateTime DtInicial, System.DateTime DtFinal, PedidosService.ConsultarSituacaoPedido SituacaoPedido, System.Nullable<int> NumeroPedido, string NumeroOSOF, string CodEntidadePai)
        {
            return base.Channel.RetornaPedidosAsync(Chave1, Chave2, NumeroAta, DtInicial, DtFinal, SituacaoPedido, NumeroPedido, NumeroOSOF, CodEntidadePai);
        }
        
        public System.Threading.Tasks.Task<PedidosService.Pedido[]> RetornaPedidosItensAsync(string Chave1, string Chave2, string NumeroAta, System.DateTime DtInicial, System.DateTime DtFinal, PedidosService.ConsultarSituacaoPedido SituacaoPedido, System.Nullable<int> NumeroPedido, string NumeroOSOF, string CodEntidadePai)
        {
            return base.Channel.RetornaPedidosItensAsync(Chave1, Chave2, NumeroAta, DtInicial, DtFinal, SituacaoPedido, NumeroPedido, NumeroOSOF, CodEntidadePai);
        }
        
        public System.Threading.Tasks.Task<PedidosService.PedidoItem[]> RetornaItensAsync(string Chave1, string Chave2, int NumeroPedido)
        {
            return base.Channel.RetornaItensAsync(Chave1, Chave2, NumeroPedido);
        }
        
        public System.Threading.Tasks.Task<PedidosService.Confirmations> AtualizaStatusPedidoAsync(string chave1, string chave2, int numeroPedido, PedidosService.AlterarSituacaoPedido SituacaoPedido)
        {
            return base.Channel.AtualizaStatusPedidoAsync(chave1, chave2, numeroPedido, SituacaoPedido);
        }
        
        public System.Threading.Tasks.Task<PedidosService.Confirmations> AtualizaStatusPedidoDetalheAsync(string chave1, string chave2, int numeroPedido, int numeroPedidoDetalhe, PedidosService.AlterarSituacaoPedido SituacaoPedido)
        {
            return base.Channel.AtualizaStatusPedidoDetalheAsync(chave1, chave2, numeroPedido, numeroPedidoDetalhe, SituacaoPedido);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPedido))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPedido))
            {
                return new System.ServiceModel.EndpointAddress("http://wsredesuprimentos.fde.sp.gov.br/WcfRedeSupService.Pedidos.svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PedidoClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPedido);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PedidoClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPedido);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPedido,
        }
    }
}
