﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OcorrenciasService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OcorrenciaItem", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class OcorrenciaItem : object
    {
        
        private System.DateTime DataAberturaOcorrenciaField;
        
        private string DescricaoOcorrenciaField;
        
        private string DescricaoProdutoField;
        
        private string DescricaoStatusOcorrenciaField;
        
        private string DescricaoTipoOcorrenciaField;
        
        private string MensagemField;
        
        private string NumeroAtaField;
        
        private string NumeroChaveNotaFiscalField;
        
        private string NumeroFDEItemField;
        
        private int NumeroOcorrenciaField;
        
        private int NumeroPedidoField;
        
        private int NumeroProdutoField;
        
        private int QuantidadeItemField;
        
        private bool StatusField;
        
        private int StatusOcorrenciaField;
        
        private int TipoOcorrenciaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAberturaOcorrencia
        {
            get
            {
                return this.DataAberturaOcorrenciaField;
            }
            set
            {
                this.DataAberturaOcorrenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoOcorrencia
        {
            get
            {
                return this.DescricaoOcorrenciaField;
            }
            set
            {
                this.DescricaoOcorrenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoProduto
        {
            get
            {
                return this.DescricaoProdutoField;
            }
            set
            {
                this.DescricaoProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoStatusOcorrencia
        {
            get
            {
                return this.DescricaoStatusOcorrenciaField;
            }
            set
            {
                this.DescricaoStatusOcorrenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoTipoOcorrencia
        {
            get
            {
                return this.DescricaoTipoOcorrenciaField;
            }
            set
            {
                this.DescricaoTipoOcorrenciaField = value;
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
        public string NumeroChaveNotaFiscal
        {
            get
            {
                return this.NumeroChaveNotaFiscalField;
            }
            set
            {
                this.NumeroChaveNotaFiscalField = value;
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
        public int NumeroOcorrencia
        {
            get
            {
                return this.NumeroOcorrenciaField;
            }
            set
            {
                this.NumeroOcorrenciaField = value;
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
        public int QuantidadeItem
        {
            get
            {
                return this.QuantidadeItemField;
            }
            set
            {
                this.QuantidadeItemField = value;
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
        public int StatusOcorrencia
        {
            get
            {
                return this.StatusOcorrenciaField;
            }
            set
            {
                this.StatusOcorrenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TipoOcorrencia
        {
            get
            {
                return this.TipoOcorrenciaField;
            }
            set
            {
                this.TipoOcorrenciaField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusOcorrencia", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public enum StatusOcorrencia : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Default = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Resolvido = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pendente = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConfirmacaoOcorrencia", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class ConfirmacaoOcorrencia : object
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OcorrenciasService.IOcorrencia")]
    public interface IOcorrencia
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOcorrencia/RetornaOcorrencias", ReplyAction="http://tempuri.org/IOcorrencia/RetornaOcorrenciasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OcorrenciasService.RegraExcecao), Action="http://tempuri.org/IOcorrencia/RetornaOcorrenciasRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<OcorrenciasService.OcorrenciaItem[]> RetornaOcorrenciasAsync(string Chave1, string Chave2, System.Nullable<int> NumeroPedido, string NumeroOSOF);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOcorrencia/AtualizaOcorrencias", ReplyAction="http://tempuri.org/IOcorrencia/AtualizaOcorrenciasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OcorrenciasService.RegraExcecao), Action="http://tempuri.org/IOcorrencia/AtualizaOcorrenciasRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<OcorrenciasService.ConfirmacaoOcorrencia> AtualizaOcorrenciasAsync(string Chave1, string Chave2, int NumeroOcorrencia, OcorrenciasService.StatusOcorrencia StatusOcorrencia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IOcorrenciaChannel : OcorrenciasService.IOcorrencia, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class OcorrenciaClient : System.ServiceModel.ClientBase<OcorrenciasService.IOcorrencia>, OcorrenciasService.IOcorrencia
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public OcorrenciaClient() : 
                base(OcorrenciaClient.GetDefaultBinding(), OcorrenciaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IOcorrencia.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OcorrenciaClient(EndpointConfiguration endpointConfiguration) : 
                base(OcorrenciaClient.GetBindingForEndpoint(endpointConfiguration), OcorrenciaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OcorrenciaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(OcorrenciaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OcorrenciaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(OcorrenciaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OcorrenciaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<OcorrenciasService.OcorrenciaItem[]> RetornaOcorrenciasAsync(string Chave1, string Chave2, System.Nullable<int> NumeroPedido, string NumeroOSOF)
        {
            return base.Channel.RetornaOcorrenciasAsync(Chave1, Chave2, NumeroPedido, NumeroOSOF);
        }
        
        public System.Threading.Tasks.Task<OcorrenciasService.ConfirmacaoOcorrencia> AtualizaOcorrenciasAsync(string Chave1, string Chave2, int NumeroOcorrencia, OcorrenciasService.StatusOcorrencia StatusOcorrencia)
        {
            return base.Channel.AtualizaOcorrenciasAsync(Chave1, Chave2, NumeroOcorrencia, StatusOcorrencia);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOcorrencia))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOcorrencia))
            {
                return new System.ServiceModel.EndpointAddress("http://wsredesuprimentos.fde.sp.gov.br/WcfRedeSupService.Ocorrencias.svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return OcorrenciaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IOcorrencia);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return OcorrenciaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IOcorrencia);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IOcorrencia,
        }
    }
}
