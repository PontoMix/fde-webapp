﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotasFiscaisService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RetornarDadosNotaFiscal", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class RetornarDadosNotaFiscal : object
    {
        
        private System.DateTime DataInclusaoField;
        
        private bool IsSimplesRemessaField;
        
        private string NumeroChaveNotaFiscalField;
        
        private string NumeroChaveNotaFiscalPaiField;
        
        private string NumeroOSOFField;
        
        private string PdfRecidoNFField;
        
        private string ValorTotalField;
        
        private string XmlCaminhoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInclusao
        {
            get
            {
                return this.DataInclusaoField;
            }
            set
            {
                this.DataInclusaoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSimplesRemessa
        {
            get
            {
                return this.IsSimplesRemessaField;
            }
            set
            {
                this.IsSimplesRemessaField = value;
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
        public string NumeroChaveNotaFiscalPai
        {
            get
            {
                return this.NumeroChaveNotaFiscalPaiField;
            }
            set
            {
                this.NumeroChaveNotaFiscalPaiField = value;
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
        public string PdfRecidoNF
        {
            get
            {
                return this.PdfRecidoNFField;
            }
            set
            {
                this.PdfRecidoNFField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ValorTotal
        {
            get
            {
                return this.ValorTotalField;
            }
            set
            {
                this.ValorTotalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlCaminho
        {
            get
            {
                return this.XmlCaminhoField;
            }
            set
            {
                this.XmlCaminhoField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RetornarDadosItensNFE", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class RetornarDadosItensNFE : object
    {
        
        private string MensagemField;
        
        private int Num_QtdPedidoField;
        
        private string NumeroChaveNotaFiscalField;
        
        private int NumeroIdPedidoItemField;
        
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
        public int Num_QtdPedido
        {
            get
            {
                return this.Num_QtdPedidoField;
            }
            set
            {
                this.Num_QtdPedidoField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemNFE", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class ItemNFE : object
    {
        
        private System.DateTime DataInclusaoBaseField;
        
        private string DescricaoProdutoField;
        
        private string DescricaoStatusItensNFEField;
        
        private string JustificativaSituacaoField;
        
        private string MarcaProdutoField;
        
        private string NomeAmigavelProdutoField;
        
        private string NumeroAtaField;
        
        private string NumeroFDEItemField;
        
        private string NumeroItemFornecedorField;
        
        private int NumeroProdutoField;
        
        private int StatusItensNFEField;
        
        private decimal Vl_PrecoUnitarioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInclusaoBase
        {
            get
            {
                return this.DataInclusaoBaseField;
            }
            set
            {
                this.DataInclusaoBaseField = value;
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
        public string DescricaoStatusItensNFE
        {
            get
            {
                return this.DescricaoStatusItensNFEField;
            }
            set
            {
                this.DescricaoStatusItensNFEField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JustificativaSituacao
        {
            get
            {
                return this.JustificativaSituacaoField;
            }
            set
            {
                this.JustificativaSituacaoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MarcaProduto
        {
            get
            {
                return this.MarcaProdutoField;
            }
            set
            {
                this.MarcaProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeAmigavelProduto
        {
            get
            {
                return this.NomeAmigavelProdutoField;
            }
            set
            {
                this.NomeAmigavelProdutoField = value;
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
        public string NumeroItemFornecedor
        {
            get
            {
                return this.NumeroItemFornecedorField;
            }
            set
            {
                this.NumeroItemFornecedorField = value;
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
        public int StatusItensNFE
        {
            get
            {
                return this.StatusItensNFEField;
            }
            set
            {
                this.StatusItensNFEField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Vl_PrecoUnitario
        {
            get
            {
                return this.Vl_PrecoUnitarioField;
            }
            set
            {
                this.Vl_PrecoUnitarioField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DadosNotaFiscal", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class DadosNotaFiscal : object
    {
        
        private NotasFiscaisService.DetalhesPedido[] DetalhesPedidoField;
        
        private bool IsSimplesRemessaField;
        
        private string NumeroChaveNotaFiscalField;
        
        private string NumeroChaveNotaFiscalPaiField;
        
        private string NumeroOFField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NotasFiscaisService.DetalhesPedido[] DetalhesPedido
        {
            get
            {
                return this.DetalhesPedidoField;
            }
            set
            {
                this.DetalhesPedidoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSimplesRemessa
        {
            get
            {
                return this.IsSimplesRemessaField;
            }
            set
            {
                this.IsSimplesRemessaField = value;
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
        public string NumeroChaveNotaFiscalPai
        {
            get
            {
                return this.NumeroChaveNotaFiscalPaiField;
            }
            set
            {
                this.NumeroChaveNotaFiscalPaiField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroOF
        {
            get
            {
                return this.NumeroOFField;
            }
            set
            {
                this.NumeroOFField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalhesPedido", Namespace="http://schemas.datacontract.org/2004/07/WcfRedeSupService.Interfaces")]
    public partial class DetalhesPedido : object
    {
        
        private int Num_QtdPedidoField;
        
        private int NumeroIdPedidoItemField;
        
        private int NumeroPedidoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Num_QtdPedido
        {
            get
            {
                return this.Num_QtdPedidoField;
            }
            set
            {
                this.Num_QtdPedidoField = value;
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NotasFiscaisService.INotaFiscalXml")]
    public interface INotaFiscalXml
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotaFiscalXml/RetornaNotaFiscal", ReplyAction="http://tempuri.org/INotaFiscalXml/RetornaNotaFiscalResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(NotasFiscaisService.RegraExcecao), Action="http://tempuri.org/INotaFiscalXml/RetornaNotaFiscalRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<NotasFiscaisService.RetornarDadosNotaFiscal> RetornaNotaFiscalAsync(string chave1, string chave2, string numeroChaveNf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotaFiscalXml/RetornaItensNotaFiscal", ReplyAction="http://tempuri.org/INotaFiscalXml/RetornaItensNotaFiscalResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(NotasFiscaisService.RegraExcecao), Action="http://tempuri.org/INotaFiscalXml/RetornaItensNotaFiscalRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<NotasFiscaisService.RetornarDadosItensNFE[]> RetornaItensNotaFiscalAsync(string chave1, string chave2, string numeroChaveNf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotaFiscalXml/UploadXmlNfe", ReplyAction="http://tempuri.org/INotaFiscalXml/UploadXmlNfeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(NotasFiscaisService.RegraExcecao), Action="http://tempuri.org/INotaFiscalXml/UploadXmlNfeRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<NotasFiscaisService.Confirmation> UploadXmlNfeAsync(NotasFiscaisService.RemoteFileInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotaFiscalXml/UploadPDFNfe", ReplyAction="http://tempuri.org/INotaFiscalXml/UploadPDFNfeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(NotasFiscaisService.RegraExcecao), Action="http://tempuri.org/INotaFiscalXml/UploadPDFNfeRegraExcecaoFault", Name="RegraExcecao", Namespace="http://schemas.datacontract.org/2004/07/Util.Wcf.Validacao")]
        System.Threading.Tasks.Task<NotasFiscaisService.Confirmation> UploadPDFNfeAsync(NotasFiscaisService.RemoteFileInfo request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoteFileInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RemoteFileInfo
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Chave1;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Chave2;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public NotasFiscaisService.ItemNFE[] ItensNotaFiscal;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public NotasFiscaisService.DadosNotaFiscal NotaFiscal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream Stream;
        
        public RemoteFileInfo()
        {
        }
        
        public RemoteFileInfo(string Chave1, string Chave2, string FileName, NotasFiscaisService.ItemNFE[] ItensNotaFiscal, NotasFiscaisService.DadosNotaFiscal NotaFiscal, System.IO.Stream Stream)
        {
            this.Chave1 = Chave1;
            this.Chave2 = Chave2;
            this.FileName = FileName;
            this.ItensNotaFiscal = ItensNotaFiscal;
            this.NotaFiscal = NotaFiscal;
            this.Stream = Stream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Confirmation", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Confirmation
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool Status;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string SituacaoRetorno;
        
        public Confirmation()
        {
        }
        
        public Confirmation(bool Status, string SituacaoRetorno)
        {
            this.Status = Status;
            this.SituacaoRetorno = SituacaoRetorno;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface INotaFiscalXmlChannel : NotasFiscaisService.INotaFiscalXml, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class NotaFiscalXmlClient : System.ServiceModel.ClientBase<NotasFiscaisService.INotaFiscalXml>, NotasFiscaisService.INotaFiscalXml
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NotaFiscalXmlClient() : 
                base(NotaFiscalXmlClient.GetDefaultBinding(), NotaFiscalXmlClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INotaFiscalXml.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotaFiscalXmlClient(EndpointConfiguration endpointConfiguration) : 
                base(NotaFiscalXmlClient.GetBindingForEndpoint(endpointConfiguration), NotaFiscalXmlClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotaFiscalXmlClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NotaFiscalXmlClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotaFiscalXmlClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NotaFiscalXmlClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NotaFiscalXmlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<NotasFiscaisService.RetornarDadosNotaFiscal> RetornaNotaFiscalAsync(string chave1, string chave2, string numeroChaveNf)
        {
            return base.Channel.RetornaNotaFiscalAsync(chave1, chave2, numeroChaveNf);
        }
        
        public System.Threading.Tasks.Task<NotasFiscaisService.RetornarDadosItensNFE[]> RetornaItensNotaFiscalAsync(string chave1, string chave2, string numeroChaveNf)
        {
            return base.Channel.RetornaItensNotaFiscalAsync(chave1, chave2, numeroChaveNf);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NotasFiscaisService.Confirmation> NotasFiscaisService.INotaFiscalXml.UploadXmlNfeAsync(NotasFiscaisService.RemoteFileInfo request)
        {
            return base.Channel.UploadXmlNfeAsync(request);
        }
        
        public System.Threading.Tasks.Task<NotasFiscaisService.Confirmation> UploadXmlNfeAsync(string Chave1, string Chave2, string FileName, NotasFiscaisService.ItemNFE[] ItensNotaFiscal, NotasFiscaisService.DadosNotaFiscal NotaFiscal, System.IO.Stream Stream)
        {
            NotasFiscaisService.RemoteFileInfo inValue = new NotasFiscaisService.RemoteFileInfo();
            inValue.Chave1 = Chave1;
            inValue.Chave2 = Chave2;
            inValue.FileName = FileName;
            inValue.ItensNotaFiscal = ItensNotaFiscal;
            inValue.NotaFiscal = NotaFiscal;
            inValue.Stream = Stream;
            return ((NotasFiscaisService.INotaFiscalXml)(this)).UploadXmlNfeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NotasFiscaisService.Confirmation> NotasFiscaisService.INotaFiscalXml.UploadPDFNfeAsync(NotasFiscaisService.RemoteFileInfo request)
        {
            return base.Channel.UploadPDFNfeAsync(request);
        }
        
        public System.Threading.Tasks.Task<NotasFiscaisService.Confirmation> UploadPDFNfeAsync(string Chave1, string Chave2, string FileName, NotasFiscaisService.ItemNFE[] ItensNotaFiscal, NotasFiscaisService.DadosNotaFiscal NotaFiscal, System.IO.Stream Stream)
        {
            NotasFiscaisService.RemoteFileInfo inValue = new NotasFiscaisService.RemoteFileInfo();
            inValue.Chave1 = Chave1;
            inValue.Chave2 = Chave2;
            inValue.FileName = FileName;
            inValue.ItensNotaFiscal = ItensNotaFiscal;
            inValue.NotaFiscal = NotaFiscal;
            inValue.Stream = Stream;
            return ((NotasFiscaisService.INotaFiscalXml)(this)).UploadPDFNfeAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INotaFiscalXml))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INotaFiscalXml))
            {
                return new System.ServiceModel.EndpointAddress("http://wsredesuprimentos.fde.sp.gov.br/WcfRedeSupService.NotaFiscalXml.svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return NotaFiscalXmlClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INotaFiscalXml);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return NotaFiscalXmlClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INotaFiscalXml);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INotaFiscalXml,
        }
    }
}
