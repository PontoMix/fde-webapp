﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtasService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AtaDados", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class AtaDados : object
    {
        
        private System.DateTime DataFinalVigenciaField;
        
        private System.DateTime DataInicialVigenciaField;
        
        private string DescricaoAtaField;
        
        private string DescricaoStatusAtaField;
        
        private string MensagemField;
        
        private string NomeAtaField;
        
        private int NumeroAnoField;
        
        private string NumeroAtaField;
        
        private int NumeroPoloField;
        
        private bool StatusField;
        
        private int StatusAtaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataFinalVigencia
        {
            get
            {
                return this.DataFinalVigenciaField;
            }
            set
            {
                this.DataFinalVigenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInicialVigencia
        {
            get
            {
                return this.DataInicialVigenciaField;
            }
            set
            {
                this.DataInicialVigenciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoAta
        {
            get
            {
                return this.DescricaoAtaField;
            }
            set
            {
                this.DescricaoAtaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoStatusAta
        {
            get
            {
                return this.DescricaoStatusAtaField;
            }
            set
            {
                this.DescricaoStatusAtaField = value;
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
        public string NomeAta
        {
            get
            {
                return this.NomeAtaField;
            }
            set
            {
                this.NomeAtaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroAno
        {
            get
            {
                return this.NumeroAnoField;
            }
            set
            {
                this.NumeroAnoField = value;
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
        public int NumeroPolo
        {
            get
            {
                return this.NumeroPoloField;
            }
            set
            {
                this.NumeroPoloField = value;
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
        public int StatusAta
        {
            get
            {
                return this.StatusAtaField;
            }
            set
            {
                this.StatusAtaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemAta", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class ItemAta : object
    {
        
        private string CodProduto_FornecedorField;
        
        private string DescricaoItemField;
        
        private string DescricaoStatusItemField;
        
        private string MensagemField;
        
        private string NomeItemField;
        
        private string NumeroAtaField;
        
        private string NumeroFDEItemField;
        
        private int NumeroItemField;
        
        private bool StatusField;
        
        private int StatusItemField;
        
        private decimal ValorUnitarioItemField;
        
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
        public string DescricaoItem
        {
            get
            {
                return this.DescricaoItemField;
            }
            set
            {
                this.DescricaoItemField = value;
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
        public string NomeItem
        {
            get
            {
                return this.NomeItemField;
            }
            set
            {
                this.NomeItemField = value;
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
        public int NumeroItem
        {
            get
            {
                return this.NumeroItemField;
            }
            set
            {
                this.NumeroItemField = value;
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
        public decimal ValorUnitarioItem
        {
            get
            {
                return this.ValorUnitarioItemField;
            }
            set
            {
                this.ValorUnitarioItemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AtasService.IAta")]
    public interface IAta
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAta/RetornaAtas", ReplyAction="http://tempuri.org/IAta/RetornaAtasResponse")]
        System.Threading.Tasks.Task<AtasService.AtaDados[]> RetornaAtasAsync(string Chave1, string Chave2, string NumeroAta, System.Nullable<int> NumeroAno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAta/RetornaItensAta", ReplyAction="http://tempuri.org/IAta/RetornaItensAtaResponse")]
        System.Threading.Tasks.Task<AtasService.ItemAta[]> RetornaItensAtaAsync(string Chave1, string Chave2, string NumeroAta, System.Nullable<int> NumeroAno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IAtaChannel : AtasService.IAta, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class AtaClient : System.ServiceModel.ClientBase<AtasService.IAta>, AtasService.IAta
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AtaClient() : 
                base(AtaClient.GetDefaultBinding(), AtaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IAta.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtaClient(EndpointConfiguration endpointConfiguration) : 
                base(AtaClient.GetBindingForEndpoint(endpointConfiguration), AtaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AtaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AtaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AtaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<AtasService.AtaDados[]> RetornaAtasAsync(string Chave1, string Chave2, string NumeroAta, System.Nullable<int> NumeroAno)
        {
            return base.Channel.RetornaAtasAsync(Chave1, Chave2, NumeroAta, NumeroAno);
        }
        
        public System.Threading.Tasks.Task<AtasService.ItemAta[]> RetornaItensAtaAsync(string Chave1, string Chave2, string NumeroAta, System.Nullable<int> NumeroAno)
        {
            return base.Channel.RetornaItensAtaAsync(Chave1, Chave2, NumeroAta, NumeroAno);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAta))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAta))
            {
                return new System.ServiceModel.EndpointAddress("http://homologwsrededesup.fde.sp.gov.br/WebserviceRedeSup/WcfRedeSupService.Atas." +
                        "svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AtaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IAta);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AtaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IAta);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IAta,
        }
    }
}