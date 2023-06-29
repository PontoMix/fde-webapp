using AtasService;
using ClientProxyWebServiceFDE_MVC.Models;
using EntidadesService;
using OcorrenciasService;
using Microsoft.AspNetCore.Mvc;
using PedidosService;
using System.Diagnostics;
using System.Threading.Tasks;
using OrdensFornecimentoService;
using ProdutosService;
using NotasFiscaisService;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Principal;

namespace ClientProxyWebServiceFDE_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAta _ataService;
        private readonly IPedido _pedidoService;
        private readonly IEntidade _entidadeService;
        private readonly IOcorrencia _ocorrenciaService;
        private readonly IOrdemFornecimento _ordemFornecimentoService;
        private readonly IProdutos _produtoService;
        private readonly INotaFiscalXml _notaFiscalService;

        public string? Chave1 { get; set; }
        public string? Chave2 { get; set; }



        public HomeController(ILogger<HomeController> logger,
            IAta ataService,
            IPedido pedidoService,
            IEntidade entidadeService,
            IOcorrencia ocorrenciaService,
            IOrdemFornecimento ordemFornecimentoService,
            IProdutos produtoService,
            INotaFiscalXml notaFiscalService)
        {
            _logger = logger;
            _ataService = ataService;
            _pedidoService = pedidoService;
            _entidadeService = entidadeService;
            _ocorrenciaService = ocorrenciaService;
            _ordemFornecimentoService = ordemFornecimentoService;
            _produtoService = produtoService;
            _notaFiscalService = notaFiscalService;

            // Defina as chaves aqui ou carregue-as de alguma outra fonte
            Chave1 = "7B27D5BD2E5819F2E8EDD6C7D02153D0E312672F71B16F36FA57154C04F23073C2E070BAA397AE147CFD58F0674496C090C716328963AB2795499D7B6F3DD156";
            Chave2 = "5F1BE5CF6AA872808A9CEBEEF7E5EAD3C709094E6AAD285CEFC43D885E53492A2F127E54A4E78489CE05A8A3A2F9380F54C75E592C329E2C476604323386A0A8";
        }


        public IActionResult Index()
        {
            return RedirectToAction("Get");
        }

        [HttpGet]

        public IActionResult Get()
        {
            return View("Index");
        }



        //****************************************   PESQUISA DE PEDIDOS   ****************************************


        public IActionResult showSearchPedidos()
        {
            return View("Pedidos/SearchPedidosPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarPesquisaPedidos(string numeroAta, DateTime DtInicial, DateTime DtFinal, PedidosService.ConsultarSituacaoPedido SituacaoPedido, string NumeroPedido, string NumeroOSOF)
        {
            ViewBag.NumeroAta = numeroAta;
            ViewBag.NumeroPedido = NumeroPedido;
            ViewBag.DataInicial = DtInicial;
            ViewBag.DataFinal = DtFinal;
            ViewBag.SituacaoPedido = SituacaoPedido;
            ViewBag.NumeroOSOF = NumeroOSOF;

            // Adicione um ponto de depuração aqui
            System.Diagnostics.Debugger.Break();

            // Verificar se o campo Número do Pedido está vazio
            //int? numeroPedido = string.IsNullOrEmpty(NumeroPedido) ? null : int.Parse(NumeroPedido);
            int? numeroPedido = int.TryParse(NumeroPedido, out int parsedNumeroPedido) ? parsedNumeroPedido : null;

            int parsedNumeroPedidoValue = numeroPedido.HasValue ? numeroPedido.Value : 0;


            // Verificar se os campos Data Inicial e Data Final estão vazios
            if (DtInicial == default && DtFinal == default)
            {
                // Caso estejam vazios, definir Data Inicial como a data atual e Data Final como 365 dias a partir da data atual
                DtInicial = DateTime.Now;
                DtFinal = DtInicial.AddDays(365);
            }

            // Verificar se o campo Número da Ordem de Fornecimento está vazio
            string numeroOSOF = string.IsNullOrEmpty(NumeroOSOF) ? string.Empty : NumeroOSOF;

            // Verificar o valor selecionado no campo Código Entidade Pai
            ConsultarSituacaoPedido statusPedido;
            switch (SituacaoPedido)
            {
                case PedidosService.ConsultarSituacaoPedido.Default:
                    statusPedido = ConsultarSituacaoPedido.Default;
                    break;
                case PedidosService.ConsultarSituacaoPedido.Ativo:
                    statusPedido = ConsultarSituacaoPedido.Ativo;
                    break;
                case PedidosService.ConsultarSituacaoPedido.Cancelado:
                    statusPedido = ConsultarSituacaoPedido.Cancelado;
                    break;
                case PedidosService.ConsultarSituacaoPedido.EntregaAutorizada:
                    statusPedido = ConsultarSituacaoPedido.EntregaAutorizada;
                    break;
                case PedidosService.ConsultarSituacaoPedido.SaiuParaEntrega:
                    statusPedido = ConsultarSituacaoPedido.SaiuParaEntrega;
                    break;
                case PedidosService.ConsultarSituacaoPedido.Entregue:
                    statusPedido = ConsultarSituacaoPedido.Entregue;
                    break;
                default:
                    statusPedido = ConsultarSituacaoPedido.Default;
                    break;
            }


            string codEntidadePai = "";

            // Chame o método RetornaPedidosAsync do web service
            PedidosService.Pedido[] pedidos = await _pedidoService.RetornaPedidosAsync(Chave1, Chave2, numeroAta, DtInicial, DtFinal, statusPedido, parsedNumeroPedidoValue, NumeroOSOF, codEntidadePai);

            // Agora você tem a lista de pedidos como resultado (variável 'pedidos') e pode usá-la como desejar

            return View("Pedidos/PedidosResult", pedidos); // Redireciona para uma visualização "PedidosResult" com os resultados da pesquisa de pedidos
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarItensPedidos(string NumeroAta, int NumeroPedido, string NumeroOSOF, string CodEntidadePai, PedidosService.ConsultarSituacaoPedido SituacaoPedido, DateTime DtInicial, DateTime DtFinal)
        {
            ViewBag.NumeroAta = NumeroAta;
            ViewBag.NumeroPedido = NumeroPedido;
            ViewBag.NumeroOSOF = NumeroOSOF;
            ViewBag.DtInicial = DtInicial;
            ViewBag.DtFinal = DtFinal;
            ViewBag.SituacaoPedido = SituacaoPedido;
            ViewBag.CodEntidadePai = CodEntidadePai;

            if (string.IsNullOrEmpty(NumeroAta) || NumeroPedido == 0)
            {
                ModelState.AddModelError("", "Os campos Número da Ata e Número do Pedido devem ser preenchidos.");
                return View("Pedidos/ItensPedidosResult");
            }

            Pedido[] itensPedido = await _pedidoService.RetornaPedidosItensAsync(Chave1, Chave2, NumeroAta, DtInicial, DtFinal, SituacaoPedido, NumeroPedido, NumeroOSOF, CodEntidadePai);
            return View("Pedidos/ItensPedidosResult", itensPedido);
        }



        /*******************************************************   PESQUISA DE ATAS  *******************************************************/


        public IActionResult showSearchAtas()
        {
            return View("Atas/SearchAtasPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarSearchAtas(string numeroAta, int numeroAno)
        {

            // Chame o método RetornaAtasAsync do web service
            AtaDados[] atas = await _ataService.RetornaAtasAsync(Chave1, Chave2, numeroAta, numeroAno);

            // Agora você tem a lista de atas como resultado (variável 'atas') e pode usá-la como desejar

            ViewBag.NumeroAta = numeroAta;
            ViewBag.NumeroAno = numeroAno;

            return View("Atas/AtasResult", atas); // Redireciona para a página inicial (Index) com os resultados da pesquisa
        }


        [HttpPost]
        public async Task<IActionResult> PesquisarItensAta(string numeroAta, int numeroAno)
        {
            ViewBag.NumeroAta = numeroAta;
            ViewBag.NumeroAno = numeroAno;

            if (string.IsNullOrEmpty(numeroAta) || numeroAno == 0)
            {
                ModelState.AddModelError("", "Os campos Número da Ata e Número do Ano devem ser preenchidos.");
                return View("Atas/ItensAtasResult");
            }

            ItemAta[] itensAta = await _ataService.RetornaItensAtaAsync(Chave1, Chave2, numeroAta, numeroAno);

            return View("Atas/ItensAtasResult", itensAta);
        }


        /************************************************   PESQUISA DE ENTIDADES  ************************************************/

        [HttpPost]
        public IActionResult showSearchEntidades()
        {
            return View("Entidades/SearchEntidades");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarPesquisaEntidades(string codigoEntidade, int numeroPolo, int ano)
        {
            Entidade[] entidades = await _entidadeService.RetornaEntidadesAsync(Chave1, Chave2, codigoEntidade, numeroPolo, ano);

            return View("Entidades/EntidadesResult", entidades);
        }



        /*******************************************************  PESQUISA DE POLOS  *******************************************************/

        [HttpPost]
        public IActionResult showSearchPolos()
        {
            return View("Polos/SearchPolos");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarPesquisaPolos(string numeroAta, int numeroPolo, int ano)
        {
            Entidade[] polos = await _entidadeService.RetornaPolosAsync(Chave1, Chave2, numeroAta, numeroPolo, ano);

            return View("Polos/PolosResult", polos);
        }



        /***********************************************   PESQUISA DE ITENS  ***********************************************/

        [HttpPost]

        public IActionResult showSearchItens()
        {
            return View("Itens/SearchItens");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarPesquisaItens(int numeroPedido)
        {
            PedidoItem[] itensPedidos = await _pedidoService.RetornaItensAsync(Chave1, Chave2, numeroPedido);

            return View("Itens/ItensResult", itensPedidos);
        }



        /***********************************************   ATUALIZAÇÃO DE PEDIDO  ***********************************************/

        public IActionResult showUpdatePedido()

        {
            return View("StatusPedidos/UpdatePedidos");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarUpdatePedido(int numeroPedido, AlterarSituacaoPedido SituacaoPedido) {


            AlterarSituacaoPedido statusPedido;
            switch (SituacaoPedido)
            {
                case PedidosService.AlterarSituacaoPedido.Default:
                    statusPedido = AlterarSituacaoPedido.Default;
                    break;
                case PedidosService.AlterarSituacaoPedido.EntregaAutorizada:
                    statusPedido = AlterarSituacaoPedido.EntregaAutorizada;
                    break;
                case PedidosService.AlterarSituacaoPedido.SaiuParaEntrega:
                    statusPedido = AlterarSituacaoPedido.SaiuParaEntrega;
                    break;
                case PedidosService.AlterarSituacaoPedido.Entregue:
                    statusPedido = AlterarSituacaoPedido.Entregue;
                    break;
                default:
                    statusPedido = AlterarSituacaoPedido.Default; // atribuir um valor padrão
                    break;
            }

            Confirmations confirmations = await _pedidoService.AtualizaStatusPedidoAsync(Chave1, Chave2, numeroPedido, statusPedido);
            return View("StatusPedidos/UpdatedPedidoStatusResult", confirmations);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarUpdatePedidoDetalhado(int numeroPedido, int numeroPedidoDetalhado, AlterarSituacaoPedido SituacaoPedido)
        {

            AlterarSituacaoPedido statusPedido;
            switch (SituacaoPedido)
            {
                case PedidosService.AlterarSituacaoPedido.Default:
                    statusPedido = AlterarSituacaoPedido.Default;
                    break;
                case PedidosService.AlterarSituacaoPedido.EntregaAutorizada:
                    statusPedido = AlterarSituacaoPedido.EntregaAutorizada;
                    break;
                case PedidosService.AlterarSituacaoPedido.SaiuParaEntrega:
                    statusPedido = AlterarSituacaoPedido.SaiuParaEntrega;
                    break;
                case PedidosService.AlterarSituacaoPedido.Entregue:
                    statusPedido = AlterarSituacaoPedido.Entregue;
                    break;
                default:
                    statusPedido = AlterarSituacaoPedido.Default; // atribuir um valor padrão
                    break;
            }

            Confirmations confirmations = await _pedidoService.AtualizaStatusPedidoDetalheAsync(Chave1, Chave2, numeroPedido, numeroPedidoDetalhado, statusPedido);

            return View("StatusPedidos/UpdatedDetailedPedidoStatusResult", confirmations);
        }



        /***********************************************   ATUALIZAÇÃO PROPOSTA PRODUTO  ***********************************************/

        public IActionResult showAtualizarPropostaProduto()
        {
            return View("Produtos/AtualizarPropostaProdutoPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarNovaPropostaProduto(ProdutoItem NovoProduto)
        {
            ConfirmaProduto confirmaProdutos = await _produtoService.AtualizaProdutoAsync(Chave1, Chave2, NovoProduto);
            return View("Produtos/PropostaProdutoAtualizadoResult", confirmaProdutos);
        }



        /*****************************************   PESQUISA E ATUALIZAÇÃO DE OCORRÊNCIA  *****************************************/

        public IActionResult showOcorrencias()

        {
            return View("Ocorrencias/OcorrenciasPage");
        }

        [HttpPost]
        public async Task<IActionResult> RetornarOcorrencias(int NumeroPedido, string NumeroOSOF)
        {
            OcorrenciaItem[] returnOcorrencias = await _ocorrenciaService.RetornaOcorrenciasAsync(Chave1, Chave2, NumeroPedido, NumeroOSOF);
            return View("Ocorrencias/ReturnOcorrenciasResult", returnOcorrencias);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarUpdateOcorrencias(int NumeroOcorrencia, StatusOcorrencia statusOcorrencia)
        {

            StatusOcorrencia statusOcorrenciaOpt;
            switch (statusOcorrencia)
            {
                case OcorrenciasService.StatusOcorrencia.Default:
                    statusOcorrenciaOpt = StatusOcorrencia.Default;
                    break;
                case OcorrenciasService.StatusOcorrencia.Resolvido:
                    statusOcorrenciaOpt = StatusOcorrencia.Resolvido;
                    break;
                case OcorrenciasService.StatusOcorrencia.Pendente:
                    statusOcorrenciaOpt = StatusOcorrencia.Pendente;
                    break;
                default:
                    statusOcorrenciaOpt = StatusOcorrencia.Default; // atribuir um valor padrão
                    break;
            }

            ConfirmacaoOcorrencia updateOcorrencias = await _ocorrenciaService.AtualizaOcorrenciasAsync(Chave1, Chave2, NumeroOcorrencia, statusOcorrenciaOpt);
            return View("Ocorrencias/UpdatedOcorrenciasResult", updateOcorrencias);
        }



        /***********************************************   PESQUISA ORDEM DE FORNECIMENTO  ***********************************************/

        public IActionResult showOrdemFornecimento()
        {
            return View("OrdensFornecimento/OrdensFornecimentoPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarPesquisaOrdemFornecimento(string NumeroOSOF, DateTime DtInicial, DateTime DtFinal)
        {
            OrdemFornecimento[] ordemFornecimentos = await _ordemFornecimentoService.RetornaOrdemFornecimentosAsync(Chave1, Chave2, NumeroOSOF, DtFinal, DtInicial);
            return View("OrdensFornecimento/OrdensFornecimentoResult", ordemFornecimentos);
        }



        /***********************************************   PESQUISA DE PRODUTOS PROPOSTOS  ***********************************************/

        public IActionResult showProdutosPropostos()
        {
            return View("Produtos/SearchProdutosPropostosPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarProdutosPropostos(string NumeroAta, int NumeroProduto, StatusProdutoItem SituacaoProduto)
        {

            StatusProdutoItem SituacaoProdutoOpt;
            switch (SituacaoProduto)
            {
                case ProdutosService.StatusProdutoItem.Default:
                    SituacaoProdutoOpt = StatusProdutoItem.Default;
                    break;
                case ProdutosService.StatusProdutoItem.PendenteDeAprovacao:
                    SituacaoProdutoOpt = StatusProdutoItem.PendenteDeAprovacao;
                    break;
                case ProdutosService.StatusProdutoItem.Aprovado:
                    SituacaoProdutoOpt = StatusProdutoItem.Aprovado;
                    break;
                case ProdutosService.StatusProdutoItem.Negado:
                    SituacaoProdutoOpt = StatusProdutoItem.Negado;
                    break;
                case ProdutosService.StatusProdutoItem.Ativo:
                    SituacaoProdutoOpt = StatusProdutoItem.Ativo;
                    break;
                case ProdutosService.StatusProdutoItem.Inativo:
                    SituacaoProdutoOpt = StatusProdutoItem.Inativo;
                    break;
                default:
                    SituacaoProdutoOpt = StatusProdutoItem.Default; // atribuir um valor padrão
                    break;
            }

            ProdutoItem[] produtosPropostos = await _produtoService.RetornaProdutosPropostosAsync(Chave1, Chave2, NumeroAta, NumeroProduto, SituacaoProdutoOpt);
            return View("Produtos/ProdutosPropostosResult");
        }



        /***********************************************   PESQUISA DE PRODUTOS PROPOSTOS LOJA  ***********************************************/

        [HttpPost]
        public async Task<IActionResult> ProcessarProdutosLoja(string NumeroAta, int NumeroPedido, StatusProduto StatusProduto)
        {

            StatusProduto StatusProdutoOpt;
            switch (StatusProduto)
            {
                case ProdutosService.StatusProduto.Default:
                    StatusProdutoOpt = StatusProduto.Default;
                    break;
                case ProdutosService.StatusProduto.Inativo:
                    StatusProdutoOpt = StatusProduto.Inativo;
                    break;
                case ProdutosService.StatusProduto.Ativo:
                    StatusProdutoOpt = StatusProduto.Ativo;
                    break;
                default:
                    StatusProdutoOpt = StatusProduto.Default; // atribuir um valor padrão
                    break;
            }

            ProdutoItem[] produtosLojaPropostos = await _produtoService.RetornaProdutosLojaAsync(Chave1, Chave2, NumeroAta, NumeroPedido, StatusProdutoOpt);
            return View("Produtos/ProdutosPropostosLojaResult", produtosLojaPropostos);
        }



        /******************************************   PESQUISAR NOTAS FISCAIS E SEUS ITENS  ******************************************/

        public IActionResult showNotasFiscais()
        {
            return View("NotasFiscais/NotasFiscaisPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarRetornoNotasFiscais(string numeroChaveNf)
        {

            RetornarDadosNotaFiscal resultadonotasFiscais = await _notaFiscalService.RetornaNotaFiscalAsync(Chave1, Chave2, numeroChaveNf);
            return View("NotasFiscais/NotasFiscaisResult", resultadonotasFiscais);
        }


        public async Task<IActionResult> ProcessarRetornoNotasFiscaisDetalhado(string numeroChaveNf)
        {
            RetornarDadosItensNFE[] resultadonotasFiscaisDetalhadas = await _notaFiscalService.RetornaItensNotaFiscalAsync(Chave1, Chave2, numeroChaveNf);
            return View("NotasFiscais/ItensNotasFiscaisResult", resultadonotasFiscaisDetalhadas);
        }



        /******************************************   UPLOAD IMAGEM PRODUTO  ******************************************/

        public IActionResult showUploadImagemProduto()
        {
            return View("UploadImagens/showUploadImagemProdutoPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarUploadImagemProduto(string NumeroAta, string NumeroFDEItem, string NumeroItemFornecedor, string DescricaoImagem, IFormFile ImagemProduto, int FlPrincipal, int NumeroOrdem)
        {
            // Verifique se um arquivo foi enviado
            if (ImagemProduto != null && ImagemProduto.Length > 0)
            {
                // Configure o tamanho máximo permitido para o arquivo (350 KB)
                const int maxSize = 350 * 1024;

                // Verifique o tamanho do arquivo
                if (ImagemProduto.Length > maxSize)
                {
                    // Retorne uma mensagem de erro se o tamanho do arquivo exceder o limite
                    ModelState.AddModelError("ImagemProduto", "O tamanho máximo do arquivo é de 350 KB.");
                    return View("UploadImagens/showUploadImagemProdutoPage");
                }

                // Verifique o formato do arquivo
                if (ImagemProduto.ContentType != "image/jpeg" && ImagemProduto.ContentType != "image/jpg" && ImagemProduto.ContentType != "image/png")
                {
                    // Retorne uma mensagem de erro se o formato do arquivo não for suportado
                    ModelState.AddModelError("ImagemProduto", "Formato de arquivo não suportado. Apenas arquivos JPG e PNG são permitidos.");
                    return View("UploadImagens/showUploadImagemProdutoPage");
                }

                // Crie um objeto de dados de imagem do produto
                ProdutosService.DadosImagemProduto dadosImagemProduto = new ProdutosService.DadosImagemProduto
                {
                    NumeroAta = NumeroAta,
                    NumeroFDEItem = NumeroFDEItem,
                    NumeroItemFornecedor = NumeroItemFornecedor,
                    DescricaoImagem = DescricaoImagem,
                    Fl_Principal = FlPrincipal,
                    NumeroOrdem = NumeroOrdem
                };

                // Crie um objeto RemoteFileInfoProduto e preencha-o com os valores necessários
                ProdutosService.RemoteFileInfoProduto fileInfo = new ProdutosService.RemoteFileInfoProduto
                {
                    Chave1 = Chave1,
                    Chave2 = Chave2,
                    DadosProdutoImagem = dadosImagemProduto,
                    FileName = ImagemProduto.FileName,
                    Stream = ImagemProduto.OpenReadStream()
                };

                // Chame o método de serviço para fazer upload da imagem
                var confirmation = await _produtoService.UploadImagemProdutoAsync(fileInfo);

                // Retorne a view de resultados com a confirmação
                return View("UploadImagens/showUploadImagemProdutoResult", confirmation);
            }

            return View("UploadImagens/showUploadImagemProdutoPage");
        }



        /**********************************   UPLOAD NFe ou SIMPLES REMESSA (XML)  **********************************/

        public IActionResult showUploadXmlNFe()
        {
            return View("UploadNFeorSR_XMLorPDF/showUploadXML_NForSRPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarUploadNFeorSR(IFormFile ArquivoXml)
        {
            if (ArquivoXml != null && ArquivoXml.Length > 0)
            {
                // Verifique o tamanho do arquivo (2MB)
                const int maxSize = 2 * 1024 * 1024;
                if (ArquivoXml.Length > maxSize)
                {
                    ModelState.AddModelError("ArquivoXml", "O tamanho máximo do arquivo é de 2MB.");
                    return View("UploadNFeorSR_XMLorPDF/showUploadXML_NForSRPage");
                }

                // Verifique o formato do arquivo
                if (ArquivoXml.ContentType != "text/xml")
                {
                    ModelState.AddModelError("ArquivoXml", "Formato de arquivo não suportado. Apenas arquivos XML são permitidos.");
                    return View("UploadNFeorSR_XMLorPDF/showUploadXML_NForSRPage");
                }

                // Leitura do arquivo
                using (var stream = new MemoryStream())
                {
                    await ArquivoXml.CopyToAsync(stream);
                    stream.Position = 0;

                    // Preencha os parâmetros para chamada do serviço
                    var dadosNotaFiscal = new NotasFiscaisService.DadosNotaFiscal();
                    // Preencha os outros parâmetros conforme necessário

                    var itemNfe = new NotasFiscaisService.ItemNFE();
                    // Preencha os outros parâmetros conforme necessário

                    var fileInfo = new NotasFiscaisService.RemoteFileInfo
                    {
                        Chave1 = Chave1,
                        Chave2 = Chave2,
                        FileName = ArquivoXml.FileName,
                        NotaFiscal = dadosNotaFiscal,
                        ItensNotaFiscal = new[] { itemNfe },
                        Stream = stream
                    };

                    // Chame o método de serviço para fazer o upload
                    var confirmation = await _notaFiscalService.UploadXmlNfeAsync(fileInfo);

                    // Faça o processamento adicional conforme necessário

                    return View("UploadNFeorSR_XMLorPDF/UploadedXML_NForSRResult");
                }
            }

            ModelState.AddModelError("ArquivoXml", "É necessário selecionar um arquivo.");
            return View("UploadNFeorSR_XMLorPDF/showUploadXML_NForSRPage");
        }



        /**********************************   UPLOAD NFe ou SIMPLES REMESSA (PDF)  **********************************/

        public IActionResult showUploadPDFNFeorSR()
        {
            return View("UploadNFeorSR_XMLorPDF/showUploadPDF_NForSRPage");
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarUploadPDFNFeorSRPage(IFormFile pdfFile)
        {
            // Verificar se o arquivo foi fornecido
            if (pdfFile != null && pdfFile.Length > 0)
            {
                // Verificar o tamanho do arquivo
                if (pdfFile.Length > 1048576) // 1MB em bytes
                {
                    ModelState.AddModelError("pdfFile", "O arquivo deve ter no máximo 1MB.");
                    return View("UploadNFeorSR_XMLorPDF/showUploadPDF_NForSRPage");
                }

                // Verificar o formato do arquivo
                if (pdfFile.ContentType != "application/pdf")
                {
                    ModelState.AddModelError("pdfFile", "O arquivo deve estar no formato PDF.");
                    return View("UploadNFeorSR_XMLorPDF/showUploadPDF_NForSRPage");
                }

                // Leitura do arquivo
                using (var stream = new MemoryStream())
                {
                    await pdfFile.CopyToAsync(stream);
                    stream.Position = 0;

                    // Preencha os parâmetros para chamada do serviço
                    var dadosNotaFiscal = new NotasFiscaisService.DadosNotaFiscal();
                    // Preencha os outros parâmetros conforme necessário
                    var itemNfe = new NotasFiscaisService.ItemNFE();

                    // Preencha os outros parâmetros conforme necessário

                    var fileInfo = new NotasFiscaisService.RemoteFileInfo
                    {
                        Chave1 = Chave1,
                        Chave2 = Chave2,
                        FileName = pdfFile.FileName,
                        NotaFiscal = dadosNotaFiscal,
                        ItensNotaFiscal = new[] { itemNfe },
                        Stream = stream
                    };

                    // Chame o método de serviço para fazer o upload
                    var confirmation = await _notaFiscalService.UploadPDFNfeAsync(fileInfo);

                    // Faça o processamento adicional conforme necessário

                    return View("UploadNFeorSR_XMLorPDF/UploadedPDF_NForSRResult");
                }
            }

            ModelState.AddModelError("ArquivoXml", "É necessário selecionar um arquivo.");
            return View("UploadNFeorSR_XMLorPDF/showUploadPDF_NForSRPage");

        }
    


        //*************************************************************************************************************
        //*************************************************************************************************************
        //*************************************************************************************************************
       

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}