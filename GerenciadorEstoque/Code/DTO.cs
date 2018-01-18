using System;
using System.IO;
using System.Reflection;

namespace GerenciadorEstoque.Code
{

    public class DTOBase
    {
        private int id;
        private int id_ususario;
        private string nome;
        private string descricao;
        private string obs;
        private int id_unidade;
        private DateTime data_criacao;

        public int Id { get => id; set => id = value; }
        public int Id_ususario { get => id_ususario; set => id_ususario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Obs { get => obs; set => obs = value; }
        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public DateTime Data_criacao { get => data_criacao; set => data_criacao = value; }
    }
    
    public class DTOAssemblyInfo
    {
        public DTOAssemblyInfo()
        {
            Versao = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DataVersao = "17/08/2017";
            ObsVersao = "Versão inicial do sistema.";
        }

        private string versao;
        private string dataVersao;
        private string obsVersao;

        public string Versao { get => versao; set => versao = value; }
        public string DataVersao { get => dataVersao; set => dataVersao = value; }
        public string ObsVersao { get => obsVersao; set => obsVersao = value; }
    }

    public class DTOCaminhos
    {

        public DTOCaminhos()
        {
            try
            {
                if (!Directory.Exists(Rede))

                {
                    Directory.CreateDirectory(Rede);
                }
            }
            catch { }

            try
            {
                if (!Directory.Exists(Pasta))

                {
                    Directory.CreateDirectory(Pasta);
                }
            }
            catch { }

            try
            {
                if (!Directory.Exists(Imagem))

                {
                    Directory.CreateDirectory(Imagem);
                }
            }
            catch { }

            try
            {
                if (!Directory.Exists(Unidades))

                {
                    Directory.CreateDirectory(Unidades);
                }
            }
            catch { }

            try
            {
                if (!Directory.Exists(Produtos))

                {
                    Directory.CreateDirectory(Produtos);
                }
            }
            catch { }            

            try
            {
                if (!Directory.Exists(FT))

                {
                    Directory.CreateDirectory(FT);
                }
            }
            catch { }
        }

        public static string name = System.Environment.MachineName;

        public static string Rede = name == "BINGO" ? "" : @"\\DB-WS33\Users\";

        public string Pasta
        {
            get { return Rede + @"Public\"; }
        }

        public string Updates
        {
            get { return @"http://zware.com.br/testes/zware/"; }
        }
        
        public string Imagem    
        {
            get { return this.Pasta + @"Imagens\"; }
        }

        public string Unidades
        {
            get { return this.Imagem + @"Unidades\"; }

        }

        public string Produtos
        {
            get { return this.Imagem + @"Produtos\"; }

        }

        public string FT
        {
            get { return this.Imagem + @"FT\"; }

        }
    }

    public class DTOOutros
    {

        public string[] DC()
        {

            //Server = tcp:DB-WS33,49172
            string[] dados = new string[] { Properties.Settings.Default.server, Properties.Settings.Default.Database, Properties.Settings.Default.UserDB, Properties.Settings.Default.senhaDB };

            return dados;
        }

        public void SalvaConectionString(string[] cs)
        {

            Properties.Settings.Default.server = cs[0];
            Properties.Settings.Default.db = cs[1];
            Properties.Settings.Default.user = cs[2];
            Properties.Settings.Default.pass = cs[3];
            Properties.Settings.Default.Save();
        }

    }

    public class DTOPermissao
    {
        
        private int id_permissao;
        private int localPermissao;
        private int permissao;
        private int id_usuarios;

        public int Id_permissao { get => id_permissao; set => id_permissao = value; }
        public int LocalPermissao { get => localPermissao; set => localPermissao = value; }
        public int Permissao { get => permissao; set => permissao = value; }
        public int Id_usuarios { get => id_usuarios; set => id_usuarios = value; }
    }

    public class DTOUsuarios
    {
        public DTOUsuarios()
        {
            email = "";
            senhaEmail = "";
            ativo = true;
            telefone = "";
            datacadastro = DateTime.Now;

        }


        private int id_usuario;
        private string nome;
        private string usuario;
        private string senha;
        private string email;
        private string telefone;
        private DateTime datacadastro;
        private bool ativo;
        private string senhaEmail;
        private int idUnidade;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime Datacadastro { get => datacadastro; set => datacadastro = value; }        
        public bool Ativo { get => ativo; set => ativo = value; }
        public string SenhaEmail { get => senhaEmail; set => senhaEmail = value; }
        public int IdUnidade { get => idUnidade; set => idUnidade = value; }
    }

    public class DTOEmpresas
    {
        private int id_empresa;
        private int codigoCIGAM;
        private string nomeCompleto;
        private string fantasia;
        private string tipoPessoa;
        private string foneVendas;
        private string foneFiscal;
        private string foneContabil;
        private string foneFax;
        private string emailFiscal;
        private string emailFinanceiro;
        private string emailVenda;
        private string emailVendaSubst;
        private string cep;
        private string endereco;
        private string numero;
        private string complemento;
        private string bairro;
        private string municipio;
        private string uf;
        private string pais;
        private string cnpj;
        private DateTime aniversario;
        private DateTime ultimoMov;
        private DateTime ultimaCompra;
        private DateTime ultimaAtualizacao;
        private bool ativo;
        private DateTime dataCadastro;        
        private int tipoFrete;
        private double percentualFrete;
        private double valorFixoFrete;
        private int id_cond_pagto;
        private string vendedor;
        private string vendedorSubst;
        private bool subst;

        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int CodigoCIGAM { get => codigoCIGAM; set => codigoCIGAM = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string TipoPessoa { get => tipoPessoa; set => tipoPessoa = value; }
        public string FoneVendas { get => foneVendas; set => foneVendas = value; }
        public string FoneFiscal { get => foneFiscal; set => foneFiscal = value; }
        public string FoneContabil { get => foneContabil; set => foneContabil = value; }
        public string FoneFax { get => foneFax; set => foneFax = value; }
        public string EmailFiscal { get => emailFiscal; set => emailFiscal = value; }
        public string EmailFinanceiro { get => emailFinanceiro; set => emailFinanceiro = value; }
        public string EmailVenda { get => emailVenda; set => emailVenda = value; }
        public string EmailVendaSubst { get => emailVendaSubst; set => emailVendaSubst = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public DateTime Aniversario { get => aniversario; set => aniversario = value; }
        public DateTime UltimoMov { get => ultimoMov; set => ultimoMov = value; }
        public DateTime UltimaCompra { get => ultimaCompra; set => ultimaCompra = value; }
        public DateTime UltimaAtualizacao { get => ultimaAtualizacao; set => ultimaAtualizacao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public int TipoFrete { get => tipoFrete; set => tipoFrete = value; }
        public double PercentualFrete { get => percentualFrete; set => percentualFrete = value; }
        public double ValorFixoFrete { get => valorFixoFrete; set => valorFixoFrete = value; }
        public int Id_cond_pagto { get => id_cond_pagto; set => id_cond_pagto = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public string VendedorSubst { get => vendedorSubst; set => vendedorSubst = value; }
        public bool Subst { get => subst; set => subst = value; }

        public DTOEmpresas()
        {
            UltimaAtualizacao = DateTime.Now;
            Ativo = true;
            Subst = false;
        }



    }

    public class DTOLevantamentos
    {
        private int id;
        private DateTime data;

        //enum entre Aberto, cancelado e concluído
        private string status;



        private int idUsuario;
        private string obs;
        private int id_unidade;

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Status { get => status; set => status = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Obs { get => obs; set => obs = value; }
        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
    }
        
    /// <summary>
    /// Esta tabela será responsável pela matriz de produtos que temos. Ela só será alterada com a clusão de algum item
    /// no CIGAM.
    /// Eventuais personalizações de produto serão feitas através da tabela materiaisDerivados, onde consta o id do material base
    /// e as eventuais alterações (como peso, embalagem, congelado, resfriado, etc..)
    /// </summary>
    /// 

    public class DTOMateriais
    {
        private int id_material;
        private string codigocigam;
        private int subgrupo_id_subgrupo;
        private string descricao;
        private string um;
        private double fc;
        private double conversaoPeso;

        public int Id_material { get => id_material; set => id_material = value; }
        public string CodigoCigam { get => codigocigam; set => codigocigam = value; }
        public int Subgrupo_id_subgrupo { get => subgrupo_id_subgrupo; set => subgrupo_id_subgrupo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Um { get => um; set => um = value; }
        public double Fc { get => fc; set => fc = value; }
        public double ConversaoPeso { get => conversaoPeso; set => conversaoPeso = value; }
    }

    /// <summary>
    /// Especialização do material:
    /// EX: Derivamos do leite condensado para Leite condensado bag 3,5Kg e leite condensado caixa 395g
    /// </summary>

    public class DTOMateriaisDerivados:DTOMateriais
    {
        private int id_materialDerivado;        
        
        public int Id_materialDerivado { get => id_materialDerivado; set => id_materialDerivado = value; }
    }

    public class DTOPlanilhaPedidos
    {
        private int id;
        private string nome;
        private string codigoCigam;
        private int unidade;
        private string unidadeMedida;
        private int id_unidadeOrganizadora;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Unidade { get => unidade; set => unidade = value; }
        public string UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public int Id_unidadeOrganizadora { get => id_unidadeOrganizadora; set => id_unidadeOrganizadora = value; }
        public string CodigoCigam { get => codigoCigam; set => codigoCigam = value; }
    }

    public class DTOUnidadeOrganizadora
    {
        private int id;
        private int nome;

        public int Id { get => id; set => id = value; }
        public int Nome { get => nome; set => nome = value; }
    }

    public class DTOSubgrupo
    {
        private int id_subgrupo;
        private string nome;

        public int Id_subgrupo { get => id_subgrupo; set => id_subgrupo = value; }
        public string Nome { get => nome; set => nome = value; }
    }

    public class DTORegistroOC
    {
        private int id_RegistroOC;
        private int id_oc;
        private int id_material;
        private int id_marcas_aprovadas;
        private float quantidade;
        private int id_empresa;
        private DateTime prazoEntregaSugerido;
        private float valorOfertado;
        private DateTime prazoOfertado;
        private string statusRegistroOc;

        public int Id_RegistroOC { get => id_RegistroOC; set => id_RegistroOC = value; }
        public int Id_oc { get => id_oc; set => id_oc = value; }
        public int Id_material { get => id_material; set => id_material = value; }
        public int Id_item_aprovado { get => id_marcas_aprovadas; set => id_marcas_aprovadas = value; }
        public float Quantidade { get => quantidade; set => quantidade = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public DateTime PrazoEntregaSugerido { get => prazoEntregaSugerido; set => prazoEntregaSugerido = value; }
        public float ValorOfertado { get => valorOfertado; set => valorOfertado = value; }
        public DateTime PrazoOfertado { get => prazoOfertado; set => prazoOfertado = value; }
        public string StatusRegistroOc { get => statusRegistroOc; set => statusRegistroOc = value; }
    }

    public class DTOCondicoesPagto
    {
        private int id_cond_pagto;
        private bool ativo;
        private string descricao;
        private int id_tipo_pagto;

        public int Id_cond_pagto { get => id_cond_pagto; set => id_cond_pagto = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Id_tipo_pagto { get => id_tipo_pagto; set => id_tipo_pagto = value; }
    }

    public class DTOTiposPagto
    {
        private int id_tipo_pagto;
        private int portador;
        private string descricao;
        private bool ativo;

        public int Id_tipo_pagto { get => id_tipo_pagto; set => id_tipo_pagto = value; }
        public int Portador { get => portador; set => portador = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }

    public class DTOStatusFornecedor
    {
        private int id_status;
        private int id_empresa;
        private int id_produto;
        private int id_subgrupo_produto;
        private bool bloqueioGeral; // BLoqueio para todos os itens
        private string status;
        private DateTime dataBloqueio;
        private int tempoBloqueio; //dias
        private string motivoBloqueio;
        private int id_usuario; // Usuário que bloqueou

        public int Id_status { get => id_status; set => id_status = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public int Id_subgrupo_produto { get => id_subgrupo_produto; set => id_subgrupo_produto = value; }
        public bool BloqueioGeral { get => bloqueioGeral; set => bloqueioGeral = value; }
        public string Status { get => status; set => status = value; }
        public DateTime DataBloqueio { get => dataBloqueio; set => dataBloqueio = value; }
        public int TempoBloqueio { get => tempoBloqueio; set => tempoBloqueio = value; }
        public string MotivoBloqueio { get => motivoBloqueio; set => motivoBloqueio = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }

    public class DTOMarcasAprovadas
    {
        public DTOMarcasAprovadas()
        {
            DataAprovacao = DateTime.Now;
            Ativo = true;
        }
        
        private int id_marcas_aprovadas;
        private string codItemBase;
        private string marca;
        private string aprovadoPor;
        private DateTime dataAprovacao;
        private bool ativo;
        private int id_usuario;
        private string obsAprovacao;

        public int Id_marcas_aprovadas { get => id_marcas_aprovadas; set => id_marcas_aprovadas = value; }
        public string CodItemBase { get => codItemBase; set => codItemBase = value; }
        public string Marca { get => marca; set => marca = value; }
        public string AprovadoPor { get => aprovadoPor; set => aprovadoPor = value; }
        public DateTime DataAprovacao { get => dataAprovacao; set => dataAprovacao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string ObsAprovacao { get => obsAprovacao; set => obsAprovacao = value; }
    }

    public class DTOMixForn
    {
        private int id_mix;
        private int id_empresa;
        private int id_marca_aprovada;
        private DateTime dataCadastroMix;
        private int id_usuario;

        public int Id_mix { get => id_mix; set => id_mix = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int Id_marca_aprovada { get => id_marca_aprovada; set => id_marca_aprovada = value; }
        public DateTime DataCadastroMix { get => dataCadastroMix; set => dataCadastroMix = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }

    public class DTOUnidade
    {
        private int id_unidade;
        private int idEmpresa;
        private string email;
        private string fone;
        private bool ativo;
        private string estoquista;
        private string obsEmailUnidade;
        private string nomeReduzido;
        private int codigo_unidade;        

        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Email { get => email; set => email = value; }
        public string Fone { get => fone; set => fone = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Estoquista { get => estoquista; set => estoquista = value; }
        public string ObsEmailUnidade { get => obsEmailUnidade; set => obsEmailUnidade = value; }
        public string NomeReduzido { get => nomeReduzido; set => nomeReduzido = value; }
        public int Codigo_unidade { get => codigo_unidade; set => codigo_unidade = value; }
    }

    public class DTOOrdemCompra
    {
        private int id_oc;
        private string status;
        private DateTime dataStatus;
        private int id_empresa;
        private int id_unidade;
        private int id_usuario;
        private DateTime dataCadastro;

        public int Id_oc { get => id_oc; set => id_oc = value; }
        public string Status { get => status; set => status = value; }
        public DateTime DataStatus { get => dataStatus; set => dataStatus = value; }
        public int Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
    }

    public class DTOOrdemGeral
    {
        private int id_ordem_geral;
        private int id_unidade;
        private DateTime dataCriacao;
        private int id_usuario;

        public int Id_ordem_geral { get => id_ordem_geral; set => id_ordem_geral = value; }
        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }

    public class DTOOrdemGeralCompra
    {
        private int id_ordem_geral_oc;
        private int id_ordem_geral;
        private int is_oc;

        public int Id_ordem_geral_oc { get => id_ordem_geral_oc; set => id_ordem_geral_oc = value; }
        public int Id_ordem_geral { get => id_ordem_geral; set => id_ordem_geral = value; }
        public int Is_oc { get => is_oc; set => is_oc = value; }
    }

    public class DTONegociacaoCompraProduto
    {
        private int id_negociacao;
        private int id_material;
        private int id_marca_aprovada;
        private int id_fornecedor;
        private float valorUnit;
        private DateTime dataLimite;
        private float quantLimite;
        private int id_cond_pagto;
        private DateTime dataCadastro;
        private int id_usuario;

        public int Id_negociacao { get => id_negociacao; set => id_negociacao = value; }
        public int Id_material { get => id_material; set => id_material = value; }
        public int Id_marca_aprovada { get => id_marca_aprovada; set => id_marca_aprovada = value; }
        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public float ValorUnit { get => valorUnit; set => valorUnit = value; }
        public DateTime DataLimite { get => dataLimite; set => dataLimite = value; }
        public float QuantLimite { get => quantLimite; set => quantLimite = value; }
        public int Id_cond_pagto { get => id_cond_pagto; set => id_cond_pagto = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }

    public class DTOConfigEmail
    {
        private int id_config_email;
        private string smtp;
        private bool ssl;       
        private int porta;
        private int usuarios_id_usuario;

        public int Id_config_email { get => id_config_email; set => id_config_email = value; }
        public string Smtp { get => smtp; set => smtp = value; }
        public bool Ssl { get => ssl; set => ssl = value; }        
        public int Porta { get => porta; set => porta = value; }
        public int Usuarios_id_usuario { get => usuarios_id_usuario; set => usuarios_id_usuario = value; }
    }

    public class DTOManterConectado
    {
        private int id_conexao;
        private string ip;
        private string nomePC;
        private int id_usuario;
        private DateTime umtima_conexao;

        public int Id_conexao { get => id_conexao; set => id_conexao = value; }
        public string Ip { get => ip; set => ip = value; }
        public string NomePC { get => nomePC; set => nomePC = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime Umtima_conexao { get => umtima_conexao; set => umtima_conexao = value; }
    }

    public class DTORecuperarSenha
    {
        private int id_usuario;
        private string codigo;
        private DateTime dataLimite;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public DateTime DataLimite { get => dataLimite; set => dataLimite = value; }
    }

    #region Fichas técnicas

    public class DTOPratos
    {
        private int id_prato;

        public int IdPrato
        {
            get { return this.id_prato; }
            set { this.id_prato = value; }
        }

        private string nome_prato;

        public string NomePrato
        {
            get { return this.nome_prato; }
            set { this.nome_prato = value; }
        }

        private int id_setor;

        public int IdSetor
        {
            get { return this.id_setor; }
            set { this.id_setor = value; }
        }

        private int cat;

        public int Cat
        {
            get { return this.cat; }
            set { this.cat = value; }
        }

        private int subcat;

        public int SubCat
        {
            get { return this.subcat; }
            set { this.subcat = value; }
        }

        private double rendimento_prato;

        public double RendimentoPrato
        {
            get { return this.rendimento_prato; }
            set { this.rendimento_prato = value; }
        }

        private string modo_preparo_prato;

        public string ModoPreparoPrato
        {
            get { return this.modo_preparo_prato; }
            set { this.modo_preparo_prato = value; }
        }

        private string desc_prato;

        public string DescPrato
        {
            get { return this.desc_prato; }
            set { this.desc_prato = value; }
        }

        private double peso_prato;

        public double PesoPrato
        {
            get { return this.peso_prato; }
            set { this.peso_prato = value; }
        }

        private int id_usuario;

        public int IdUsuario
        {
            get { return this.id_usuario; }
            set { this.id_usuario = value; }
        }

        private string cod_prato;

        public string CodPrato
        {
            get { return this.cod_prato; }
            set { this.cod_prato = value; }
        }

        public int PessoasAtendidas { get => pessoasAtendidas; set => pessoasAtendidas = value; }
        public int Ativo { get => ativo; set => ativo = value; }

        private int pessoasAtendidas;

        private int ativo;


    }

    public class DTOIngredientes
    {
        private int id_ingrediente;

        public int IdIngrediente
        {
            get { return this.id_ingrediente; }
            set { this.id_ingrediente = value; }
        }

        private string cod_item;

        public string CodItem
        {
            get { return this.cod_item; }
            set { this.cod_item = value; }
        }

        private string cod_prato;

        public string CodPrato
        {
            get { return this.cod_prato; }
            set { this.cod_prato = value; }
        }

        private double quant_ingrediente;

        public double QuantIngrediente
        {
            get { return this.quant_ingrediente; }
            set { this.quant_ingrediente = value; }
        }
    }

    public class DTOBuffet
    {
        private int id_buffet;

        public int IdBuffet
        {
            get { return this.id_buffet; }
            set { this.id_buffet = value; }
        }

        private string nome_buffet;

        public string NomeBuffet
        {
            get { return this.nome_buffet; }
            set { this.nome_buffet = value; }
        }

        private string desc_buffet;

        public string DescBuffet
        {
            get { return this.desc_buffet; }
            set { this.desc_buffet = value; }
        }

    }

    public class DTOCategoria
    {
        private int id_cat;

        public int IdCat
        {
            get { return this.id_cat; }
            set { this.id_cat = value; }
        }

        private string nome_cat;

        public string NomeCat
        {
            get { return this.nome_cat; }
            set { this.nome_cat = value; }
        }

        private string desc_cat;

        public string DescCat
        {
            get { return this.desc_cat; }
            set { this.desc_cat = value; }
        }

    }

    public class DTOSubCategoria
    {
        private int id_scat;

        public int IdSCat
        {
            get { return this.id_scat; }
            set { this.id_scat = value; }
        }

        private string nome_scat;

        public string NomeSCat
        {
            get { return this.nome_scat; }
            set { this.nome_scat = value; }
        }

        private string desc_scat;

        public string DescSCat
        {
            get { return this.desc_scat; }
            set { this.desc_scat = value; }
        }

    }

    public class DTOCusto
    {
        private int id_unidade;

        public int IdUnidade
        {
            get { return this.id_unidade; }
            set { this.id_unidade = value; }
        }

        private int id_usuario;

        public int IdUsuario
        {
            get { return this.id_usuario; }
            set { this.id_usuario = value; }
        }

        private int id_custo;

        public int IdCusto
        {
            get { return this.id_custo; }
            set { this.id_custo = value; }
        }

        private DateTime data_custo;

        public DateTime DataCusto
        {
            get { return this.data_custo; }
            set { this.data_custo = value; }
        }

        private string cod_item_custo;

        public string CodItemCusto
        {
            get { return this.cod_item_custo; }
            set { this.cod_item_custo = value; }
        }

        private string tipo_mov_custo;

        public string TipoMovCusto
        {
            get { return this.tipo_mov_custo; }
            set { this.tipo_mov_custo = value; }
        }

        private double quant_mov_custo;

        public double QuantMovCusto
        {
            get { return this.quant_mov_custo; }
            set { this.quant_mov_custo = value; }
        }

        private double valor_unitario_custo;

        public double ValorUnitarioCusto
        {
            get { return this.valor_unitario_custo; }
            set { this.valor_unitario_custo = value; }
        }

        private string tipo_operacao_custo;

        public string TipoOperacaoCusto
        {
            get { return this.tipo_operacao_custo; }
            set { this.tipo_operacao_custo = value; }
        }

        private string conta_gerencial_custo;

        public string ContaGerencialCusto
        {
            get { return this.conta_gerencial_custo; }
            set { this.conta_gerencial_custo = value; }
        }

        private string tipo_doc_custo;

        public string TipoDocCusto
        {
            get { return this.tipo_doc_custo; }
            set { this.tipo_doc_custo = value; }
        }

        private string documento_custo;

        public string DocumentoCusto
        {
            get { return this.documento_custo; }
            set { this.documento_custo = value; }
        }

        private int movimento_custo;

        public int MovimentoCusto
        {
            get { return this.movimento_custo; }
            set { this.movimento_custo = value; }
        }

        private string grupo;

        public string Grupo
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }

    }

    public class DTOCustoPratos
    {
        private int id_custoPratos;
        private string codigoCigam;
        private int id_unidade;
        private double valorTotal;
        private DateTime dataAtualizacao;

        public int Id_custoPratos { get => id_custoPratos; set => id_custoPratos = value; }
        public int Id_unidade { get => id_unidade; set => id_unidade = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public DateTime DataAtualizacao { get => dataAtualizacao; set => dataAtualizacao = value; }
        public string CodigoCigam { get => codigoCigam; set => codigoCigam = value; }
    }
    
    #endregion

    public class DTOUnidadeMedida
    {
        private int id_um;
        private string um;
        private string desc;

        public int Id_um { get => id_um; set => id_um = value; }
        public string Um { get => um; set => um = value; }
        public string Desc { get => desc; set => desc = value; }

        public DTOUnidadeMedida()
        {
            desc = "";
        }
    }

    public class DTOCotacao :DTOBase
    {
        private DateTime dataInicioVigencia;
        private DateTime dataFimVigencia;
        private int idEmpresa;

        public DateTime DataInicioVigencia { get => dataInicioVigencia; set => dataInicioVigencia = value; }
        public DateTime DataFimVigencia { get => dataFimVigencia; set => dataFimVigencia = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
    }

    public class DTOItensCotacao : DTOBase
    {
        private int idCotacao;
        private string codItem;
        private int idUm;
        private double valor;

        public int IdCotacao { get => idCotacao; set => idCotacao = value; }
        public string CodItem { get => codItem; set => codItem = value; }
        public int IdUm { get => idUm; set => idUm = value; }
        public double Valor { get => valor; set => valor = value; }
    }

    public class DTOOC
    {
        private int id_oc;
        private DateTime dataOc;
        private int id_usuario;
        private int id_fornecedor;
        private string status_oc;

        public int Id_oc { get => id_oc; set => id_oc = value; }
        public DateTime DataOc { get => dataOc; set => dataOc = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public string Status_oc { get => status_oc; set => status_oc = value; }
    }
    
    public class DTOItensPedido
    {
        private int id_item_pedido;
        private string cod_item;
        private int id_um;
        private double quant;
        private string obs;
        private int id_usuario;
        private int id_setor;
        private string obs_setor;
        private bool solicitado;
        private int id_pedido;

        public int Id_item_pedido { get => id_item_pedido; set => id_item_pedido = value; }
        public int Id_oc { get => Id_pedido; set => Id_pedido = value; }
        public string Cod_item { get => cod_item; set => cod_item = value; }
        public double Quant { get => quant; set => quant = value; }
        public int Id_um { get => id_um; set => id_um = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_setor { get => id_setor; set => id_setor = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Obs_setor { get => obs_setor; set => obs_setor = value; }
        public bool Solicitado { get => solicitado; set => solicitado = value; }
        public int Id_pedido { get => id_pedido; set => id_pedido = value; }

        public DTOItensPedido()
        {
            obs = "";
            obs_setor = "";
            solicitado = false;
        }

    }

    public class DTOPedidos : DTOBase
    {
        private DateTime data_entrega;
        private string status;


        public DateTime Data_entrega { get => data_entrega; set => data_entrega = value; }
        public string Status { get => status; set => status = value; }

        public DTOPedidos()
        {
            Obs = "";
            Status = "Aberto";
            Data_criacao = DateTime.Now;
        }

    }

    public class DTOSetores : DTOBase
    {
        public DTOSetores()
        {
            Obs = "";
        }
    }




}
