#region Usings

using System;
using System.Data;

#endregion

namespace GerenciadorEstoque.Code
{

    #region Bases

    public class BLLMateriais
    {
        private DALConexao conexao;

        public BLLMateriais()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOMateriais modelo, string foto)
        {
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do material é obrigatório.");
            }

            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("A unidade de medida do material é obrigatória.");
            }

            if (modelo.Subgrupo_id_subgrupo == 0)
            {
                throw new Exception("O subgrupo do material deve ser definido.");
            }

            //Tratamento das informações

            modelo.Descricao = modelo.Descricao.ToUpper().Trim();
            modelo.Um = modelo.Um.ToUpper().Trim();

            DALMateriais DALobj = new DALMateriais(conexao);
            DALobj.Incluir(modelo, foto);
        }

        public void Excluir(int codigo)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            DALobj.Excluir(codigo);
        }

        public void ExcluirPorCodigo(string codigo)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            DALobj.ExcluirPorCodigo(codigo);
        }


        public void Alterar(DTOMateriais modelo, string foto)
        {
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do material é obrigatório.");
            }

            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("A unidade de medida do material é obrigatória.");
            }

            if (modelo.Subgrupo_id_subgrupo == 0)
            {
                throw new Exception("O subgrupo do material deve ser definido.");
            }

            //Tratamento das informações

            modelo.Descricao = modelo.Descricao.ToUpper().Trim();
            modelo.Um = modelo.Um.ToUpper().Trim();


            DALMateriais DALobj = new DALMateriais(conexao);
            DALobj.Alterar(modelo, foto);
        }

        public DataTable Localizar()
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            return DALobj.Localizar();
        }

        public DataTable ListarProdutos(string valor)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            return DALobj.ListarProdutos(valor);
        }

        public DataTable Localizar(string valor, int id)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            return DALobj.Localizar(valor, id);
        }

        public DTOMateriais CarregaModeloMateriais(int codigo)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            return DALobj.CarregaModeloMateriais(codigo);
        }

        public DTOMateriais CarregaModeloMateriais(string codigo)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            return DALobj.CarregaModeloMateriais(codigo);
        }

        public DataTable LocalizarPorCod(string cod)
        {
            DALMateriais DALobj = new DALMateriais(conexao);
            return DALobj.LocalizarPorCod(cod);
        }
    }

    public class BLLMateriaisDerivados
    {
        private DALConexao conexao;

        public BLLMateriaisDerivados()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOMateriaisDerivados modelo, string foto)
        {
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do material é obrigatório.");
            }

            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("A unidade de medida do material é obrigatória.");
            }            

            //Tratamento das informações

            modelo.Descricao = modelo.Descricao.ToUpper().Trim();
            modelo.Um = modelo.Um.ToUpper().Trim();

            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            DALobj.Excluir(codigo);
        }
        
        public void Alterar(DTOMateriaisDerivados modelo)
        {
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do material é obrigatório.");
            }

            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("A unidade de medida do material é obrigatória.");
            }
                        
            //Tratamento das informações

            modelo.Descricao = modelo.Descricao.ToUpper().Trim();
            modelo.Um = modelo.Um.ToUpper().Trim();


            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            DALobj.Alterar(modelo);
        }

        public DataTable Localizar()
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.Localizar();
        }

        public DataTable ListarProdutos(string valor)
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.ListarProdutos(valor);
        }

        public DataTable Localizar(string valor, int id)
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.Localizar(valor, id);
        }

        public DataTable LocalizarMateriaisEDerivados(string valor)
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.LocalizarMateriaisEDerivados(valor);
        }

        public DataTable LocalizarMateriaisEDerivados(string valor, int subgrupo)
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.LocalizarMateriaisEDerivados(valor, subgrupo);
        }

        public DataTable ListarMateriaisEDerivados()
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.ListarMateriaisEDerivados();
        }

        public DTOMateriaisDerivados CarregaModeloMateriais(int codigo)
        {
            DALMateriaisDerivados DALobj = new DALMateriaisDerivados(conexao);
            return DALobj.CarregaModeloMateriais(codigo);
        }
                        
    }

    public class BLLUSuarios
    {
        private DALConexao conexao;

        public BLLUSuarios()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOUsuarios modelo, string foto)
        {
            if (modelo.Usuario.Trim().Length == 0)
            {
                throw new Exception("O usuário é obrigatório.");
            }

            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }

            //Tratamento das informações

            modelo.Nome = modelo.Nome.ToUpper().Trim();
            modelo.Usuario = modelo.Usuario.ToUpper().Trim();

            DALUsuarios DALobj = new DALUsuarios(conexao);
            DALobj.Incluir(modelo, foto);
        }

        public void Excluir(int codigo)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(DTOUsuarios modelo, string foto)
        {
            if (modelo.Usuario.Trim().Length == 0)
            {
                throw new Exception("O usuário é obrigatório.");
            }

            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }

            //Tratamento das informações

            modelo.Nome = modelo.Nome.ToUpper().Trim();
            modelo.Usuario = modelo.Usuario.ToUpper().Trim();

            DALUsuarios DALobj = new DALUsuarios(conexao);
            DALobj.Alterar(modelo, foto);
        }

        public void DesativarUsuario(int id)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            DALobj.DesativarUsuario(id);
        }

        public void AlterarSenha(DTOUsuarios modelo, string senha)
        {
            if (senha.Trim().Length < 4)
            {
                throw new Exception("você deve definir uma senha com pelo menos 4 caracteres.");
            }

            DALUsuarios DALobj = new DALUsuarios(conexao);
            DALobj.AlterarSenha(modelo, senha);
        }

        public DataTable Localizar()
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Localizar();
        }

        public DataTable Localizar(String valor)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable Localizar(String valor, int unidade)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Localizar(valor, unidade);
        }

        public DataTable Consulta(String nome, String usuario)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Consulta(nome, usuario);
        }

        public DataTable Consulta(String nome, String usuario, int unidade)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Consulta(nome, usuario, unidade);
        }

        public DataTable Consulta(String nome, String usuario, bool ativo)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Consulta(nome, usuario, ativo);
        }

        public DataTable Consulta(String nome, String usuario, int unidade, bool ativo)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Consulta(nome, usuario, unidade, ativo);
        }

        public DataTable Localizar(String nome, String usuario, int unidade)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Localizar(nome, usuario, unidade);
        }

        public DataTable Localizar(string nome, string usuario)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Localizar(nome, usuario);
        }

        public DTOUsuarios CarregaModeloUsuarios(int codigo)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.CarregaModeloUsuarios(codigo);
        }

        public DTOUsuarios CarregaModeloUsuarios(string usuario, string senha)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.CarregaModeloUsuarios(usuario, senha);
        }

        public int IdPorUser(string user)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.IdPorUser(user);
        }

    }

    public class BLLPermissoes
    {
        private DALConexao conexao;

        public BLLPermissoes()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOPermissao perm)
        {
            DALPermissao DALobj = new DALPermissao(conexao);
            DALobj.Incluir(perm);
        }

        public void Excluir(int id)
        {
            DALPermissao DALobj = new DALPermissao(conexao);
            DALobj.Excluir(id);
        }


        public void Alterar(DTOPermissao perm)
        {
            DALPermissao DALobj = new DALPermissao(conexao);
            DALobj.Alterar(perm);
        }

        public int PermissaoPorLocal(Diversos.LocaisPermissoes local, DTOUsuarios dto)
        {
            DALPermissao DALobj = new DALPermissao(conexao);
            return DALobj.PermissaoPorLocal(local, dto);
        }
    }

    public class BLLManterConectado
    {
        private DALConexao conexao;

        public BLLManterConectado()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOManterConectado modelo)
        {
            //Tratamento das informações

            DALManterConectado DALobj = new DALManterConectado(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int id)
        {
            DALManterConectado DALobj = new DALManterConectado(conexao);
            DALobj.Excluir(id);
        }

        public void AtualizarData()
        {
            DALManterConectado DALobj = new DALManterConectado(conexao);
            DALobj.AtualizarData();
        }

        public DataTable Localizar()
        {
            DALManterConectado DALobj = new DALManterConectado(conexao);
            return DALobj.Localizar();
        }

        public DataTable Localizar(int usuario)
        {
            DALManterConectado DALobj = new DALManterConectado(conexao);
            return DALobj.Localizar(usuario);
        }

        public DTOManterConectado CarregaModeloConexao(string ip)
        {
            DALManterConectado DALobj = new DALManterConectado(conexao);
            return DALobj.CarregaModeloConexao(ip);
        }
    }

    public class BLLConfigEmail
    {
        private DALConexao conexao;

        public BLLConfigEmail()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOConfigEmail modelo)
        {

            if (modelo.Porta <= 0)
            {
                throw new Exception("A porta deve ser preenchida.");
            }

            if (modelo.Smtp.Trim().Length == 0)
            {
                throw new Exception("O SMTP deve ser preenchido.");
            }

            DALConfigEmail DALobj = new DALConfigEmail(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALConfigEmail DALobj = new DALConfigEmail(conexao);
            DALobj.Excluir();
        }

        public void Alterar(DTOConfigEmail modelo)
        {
            DALConfigEmail DALobj = new DALConfigEmail(conexao);
            DALobj.Alterar(modelo);
        }

        public DTOConfigEmail CarregaModelo()
        {
            DALConfigEmail DALobj = new DALConfigEmail(conexao);
            return DALobj.CarregaModelo();
        }

        public bool TemRegistro()
        {
            DALConfigEmail DALobj = new DALConfigEmail(conexao);
            return DALobj.TemRegistro();
        }
    }

    public class BLLRecuperarSenha
    {
        private DALConexao conexao;

        public BLLRecuperarSenha()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Criar(int id)
        {
            //Tratamento das informações

            DALRecuperaSenha DALobj = new DALRecuperaSenha(conexao);
            DALobj.Criar(id);
        }

        public void Excluir(int id)
        {
            DALRecuperaSenha DALobj = new DALRecuperaSenha(conexao);
            DALobj.Excluir(id);
        }

        public void DeletarPorData()
        {
            DALRecuperaSenha DALobj = new DALRecuperaSenha(conexao);
            DALobj.DeletarPorData();
        }

        public bool VerificaCodigo(int id, string cod)
        {
            DALRecuperaSenha DALobj = new DALRecuperaSenha(conexao);

            return DALobj.VerificaCodigo(id, cod);
        }

    }

    public class BLLUnidade
    {
        private DALConexao conexao;

        public BLLUnidade()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Criar(DTOUnidade dto)
        {
            //Tratamento das informações

            DALUnidades DALobj = new DALUnidades(conexao);
            DALobj.Incluir(dto);
        }

        public void Excluir(int id)
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            DALobj.Excluir(id);
        }

        public DTOUnidade CarregaModelo(int id)
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            return DALobj.CarregaModelo(id);
        }

        public string RetornaNomeUnidade(int id)
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            return DALobj.RetornaNomeUnidade(id);
        }

        public DTOUnidade CarregaModelo()
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            return DALobj.CarregaModelo();
        }

        public DataTable Localizar()
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            return DALobj.Localizar();
        }
    }

    public class BLLEmpresa
    {
        private DALConexao conexao;

        public BLLEmpresa()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Criar(DTOEmpresas dto)
        {
            //Tratamento das informações

            DALEmpresas DALobj = new DALEmpresas(conexao);
            DALobj.Incluir(dto, "");
        }

        public void Excluir(int id)
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            DALobj.Excluir(id);
        }

        public DataTable Localizar()
        {
            DALEmpresas DALobj = new DALEmpresas(conexao);
            return DALobj.Localizar();
        }

        public DataTable Localizar(string valor, string cnpj)
        {
            DALEmpresas DALobj = new DALEmpresas(conexao);
            return DALobj.Localizar(valor, cnpj);
        }

        public DTOEmpresas CarregaModelo(int id)
        {
            DALEmpresas DALobj = new DALEmpresas(conexao);
            return DALobj.CarregaModelo(id);
        }

        public DTOUnidade CarregaModelo()
        {
            DALUnidades DALobj = new DALUnidades(conexao);
            return DALobj.CarregaModelo();
        }
                
    }

    public class BLLMarcasAprovadas
    {
        private DALConexao conexao;

        public BLLMarcasAprovadas()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOMarcasAprovadas modelo)
        {
            if (modelo.Marca.Trim().Length == 0)
            {
                throw new Exception("O Nome da marca é obrigatório.");
            }

            if (modelo.AprovadoPor.Trim().Length == 0)
            {
                throw new Exception("O nome de quem autorizou a marca é obrigatório.");
            }

            //Tratamento das informações

            modelo.Marca = modelo.Marca.ToUpper().Trim();
            modelo.AprovadoPor = modelo.AprovadoPor.ToUpper().Trim();

            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(DTOMarcasAprovadas modelo)
        {
            if (modelo.Marca.Trim().ToUpper().Length == 0)
            {
                throw new Exception("O nome da marca é obrigatório.");
            }

            if (modelo.AprovadoPor.Trim().Length == 0)
            {
                throw new Exception("O nome de quem liberou a marca é obrigatório.");
            }

            //Tratamento das informações

            modelo.Marca = modelo.Marca.ToUpper().Trim();
            modelo.AprovadoPor = modelo.AprovadoPor.ToUpper().Trim();


            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            DALobj.Alterar(modelo);
        }

        public DataTable Localizar(Int32 valor)
        {
            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            return DALobj.Localizar(valor);
        }

        public int ContarMarcas(Int32 valor)
        {
            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            return DALobj.ContarMarcas(valor);
        }

        public DataTable ListarNomes()
        {
            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            return DALobj.ListarNomes();
        }

        public DTOMarcasAprovadas CarregaMarca(int id)
        {
            DALMarcasAprovadas DALobj = new DALMarcasAprovadas(conexao);
            return DALobj.CarregaModelo(id);
        }

    }

    public class BLLSubgrupo
    {
        private DALConexao conexao;

        public BLLSubgrupo()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOSubgrupo modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O Nome do subgrupo é obrigatório.");
            }


            //Tratamento das informações

            modelo.Nome = modelo.Nome.ToUpper().Trim();

            DALSubgrupos DALobj = new DALSubgrupos(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSubgrupos DALobj = new DALSubgrupos(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(DTOSubgrupo modelo)
        {
            if (modelo.Nome.Trim().ToUpper().Length == 0)
            {
                throw new Exception("O nome do subgrupo é obrigatório.");
            }

            //Tratamento das informações

            modelo.Nome = modelo.Nome.ToUpper().Trim();

            DALSubgrupos DALobj = new DALSubgrupos(conexao);
            DALobj.Alterar(modelo);
        }

        public DataTable Listar()
        {
            DALSubgrupos DALobj = new DALSubgrupos(conexao);
            return DALobj.Listar();
        }

        public DTOSubgrupo Carrega(int codigo)
        {
            DALSubgrupos DALobj = new DALSubgrupos(conexao);
            return DALobj.Carregar(codigo);
        }

    }

    public class BLLBackupDataBase
    {
        private DALConexao conexao;

        public BLLBackupDataBase()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Restaura(string DB, string arquivo)
        {
            DALBackupDataBase DALobj = new DALBackupDataBase(conexao);
            DALobj.RestauraDB(DB, arquivo);
        }


    }

    #endregion

    #region Fichas técnicas

    public class BLLPratos
    {
        private DALConexao conexao;

        public BLLPratos()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOPratos modelo)
        {
            //verifica o preenchimento do código da unidade
            if (modelo.NomePrato.Trim().Length == 0)
            {
                throw new Exception("O nome do prato não pode ficar em branco.");
            }
            //verifica o preenchimento do nome do grupo
            if (modelo.IdSetor <= 0)
            {
                throw new Exception("Escolha um buffet para atribuir este prato.");
            }


            //Tratamento dos dados
            modelo.NomePrato = modelo.NomePrato.Replace("\'", "");
            modelo.NomePrato = modelo.NomePrato.Replace("\\", "-");
            modelo.NomePrato = modelo.NomePrato.Replace("\"", "");
            modelo.NomePrato = modelo.NomePrato.Replace("/", "-");

            modelo.NomePrato = modelo.NomePrato.Trim().ToUpper();
            modelo.ModoPreparoPrato = modelo.ModoPreparoPrato.Trim();
            modelo.DescPrato = modelo.DescPrato.Trim();

            DALPratos DALobj = new DALPratos(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(DTOPratos modelo)
        {

            //verifica o preenchimento do código da unidade
            if (modelo.NomePrato.Trim().Length == 0)
            {
                throw new Exception("O nome do prato não pode ficar em branco.");
            }
            //verifica o preenchimento do nome do grupo
            if (modelo.IdSetor.ToString() == "")
            {
                throw new Exception("Escolha um buffet para atribuir este prato.");
            }

            if (modelo.Cat.ToString() == "")
            {
                throw new Exception("Escolha uma categoria para atribuir este prato.");
            }

            //Tratamento dos dados

            modelo.NomePrato = modelo.NomePrato.Replace("\'", "");
            modelo.NomePrato = modelo.NomePrato.Replace("\\", "-");
            modelo.NomePrato = modelo.NomePrato.Replace("\"", "");
            modelo.NomePrato = modelo.NomePrato.Replace("/", "-");

            modelo.NomePrato = modelo.NomePrato.Trim().ToUpper();
            modelo.ModoPreparoPrato = modelo.ModoPreparoPrato.Trim();
            modelo.DescPrato = modelo.DescPrato.Trim();

            DALPratos DALobj = new DALPratos(conexao);
            DALobj.Alterar(modelo);
        }

        public void AddModoPreparo(DTOPratos modelo)
        {
            modelo.ModoPreparoPrato = modelo.ModoPreparoPrato.Trim();
            modelo.DescPrato = modelo.DescPrato.Trim();

            DALPratos DALobj = new DALPratos(conexao);
            DALobj.AddModPreparo(modelo);
        }

        public void Excluir(string codigo)
        {
            DALPratos DALobj = new DALPratos(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable LocalizarNome(String valor)
        {
            DALPratos DALobj = new DALPratos(conexao);
            return DALobj.LocalizarNome(valor);
        }

        public DataTable LocalizarPorCod(String cod)
        {
            DALPratos DALobj = new DALPratos(conexao);
            return DALobj.LocalizarPorCod(cod);
        }

        public DataTable BuscaFichas(String busca)
        {
            DALPratos DALobj = new DALPratos(conexao);
            return DALobj.BuscaFichas(busca);
        }

        public DataTable ListarCodigos()
        {
            DALPratos DALobj = new DALPratos(conexao);
            return DALobj.ListaCodigos();
        }

        public DataTable ListarIngredientes(string codigo)
        {
            DALPratos DALobj = new DALPratos(conexao);
            return DALobj.ListarIngredientes(codigo);
        }

        public DataTable CustoIngrediente(string codigo, int unidade)
        {
            DALPratos DALobj = new DALPratos(conexao);
            return DALobj.CustoIngrediente(codigo, unidade);
        }
    }

    public class BLLIngredientes
    {
        private DALConexao conexao;

        public BLLIngredientes()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOIngredientes modelo)
        {

            //verifica o preenchimento do PRATO
            if (modelo.CodPrato == "")
            {
                throw new Exception("O nome do prato não pode ficar em branco.");
            }
            //verifica o preenchimento da quantidade
            if (modelo.QuantIngrediente <= 0)
            {
                throw new Exception("Q quantidade do ingrediente nao pode ficar zero.");
            }

            DALIngredientes DALobj = new DALIngredientes(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOIngredientes modelo)
        {


            //verifica o preenchimento do PRATO
            if (modelo.CodPrato == "")
            {
                throw new Exception("O nome do prato não pode ficar em branco.");
            }
            //verifica o preenchimento da quantidade
            if (modelo.QuantIngrediente <= 0)
            {
                throw new Exception("Q quantidade do ingrediente nao pode ficar zero.");
            }

            DALIngredientes DALobj = new DALIngredientes(conexao);
            DALobj.Alterar(modelo);

        }

        public void Excluir(int codigo)
        {
            DALIngredientes DALobj = new DALIngredientes(conexao);
            DALobj.Excluir(codigo);
        }

        public void ExcluirPorPrato(string codigo)
        {
            DALIngredientes DALobj = new DALIngredientes(conexao);
            DALobj.ExcluirPorPrato(codigo);
        }

        public DataTable Custo01(string cod, int unidade)
        {
            DALIngredientes DALobj = new DALIngredientes(conexao);
            return DALobj.CustoItem01(cod, unidade);
        }

        public DataTable CustoGeral(string cod, int unidade)
        {
            DALIngredientes DALobj = new DALIngredientes(conexao);
            return DALobj.CustoItemGeral(cod, unidade);
        }

    }

    public class BLLBuffet
    {
        private DALConexao conexao;

        public BLLBuffet()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOBuffet modelo)
        {

            //verifica o preenchimento do ingrediente
            if (modelo.NomeBuffet.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para o buffet.");
            }

            //Trata os dados
            modelo.NomeBuffet = modelo.NomeBuffet.Trim().ToUpper();
            if (modelo.DescBuffet != "")
            {
                modelo.DescBuffet = modelo.DescBuffet.Trim();
            }

            DALBuffet DALobj = new DALBuffet(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOBuffet modelo)
        {

            //verifica o preenchimento do ingrediente
            if (modelo.NomeBuffet.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para o buffet.");
            }

            //Trata os dados
            modelo.NomeBuffet = modelo.NomeBuffet.Trim().ToUpper();
            if (modelo.DescBuffet != "")
            {
                modelo.DescBuffet = modelo.DescBuffet.Trim();
            }

            DALBuffet DALobj = new DALBuffet(conexao);
            DALobj.Alterar(modelo);

        }

        public void Excluir(int codigo)
        {
            DALBuffet DALobj = new DALBuffet(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Listar()
        {
            DALBuffet DALobj = new DALBuffet(conexao);
            return DALobj.Listar();
        }

        public DataTable LocalizarPorId(int id)
        {
            DALBuffet DALobj = new DALBuffet(conexao);
            return DALobj.LocalizarPorId(id);
        }

        public int CadastrarSeNaoExiste(string n)
        {
            string Nome = n.Trim().ToUpper();
            DALBuffet DALobj = new DALBuffet(conexao);
            return DALobj.CadastrarSeNaoExiste(Nome);
        }

    }

    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOCategoria modelo)
        {

            //verifica o preenchimento do ingrediente
            if (modelo.NomeCat.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para a categoria.");
            }

            //Trata os dados
            modelo.NomeCat = modelo.NomeCat.Trim().ToUpper();
            if (modelo.DescCat != "")
            {
                modelo.DescCat = modelo.DescCat.Trim();
            }

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOCategoria modelo)
        {

            //verifica o preenchimento do ingrediente
            if (modelo.NomeCat.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para a categoria.");
            }

            //Trata os dados
            modelo.NomeCat = modelo.NomeCat.Trim().ToUpper();
            if (modelo.DescCat != "")
            {
                modelo.DescCat = modelo.DescCat.Trim();
            }

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable LocalizarPorId(int id)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.LocalizarPorId(id);
        }

        public DataTable Listar()
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Listar();

        }

        public int CadastrarSeNaoExiste(string n)
        {
            string Nome = n.Trim().ToUpper();
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CadastrarSeNaoExiste(Nome);
        }


    }

    public class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOSubCategoria modelo)
        {

            //verifica o preenchimento do ingrediente
            if (modelo.NomeSCat.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para a categoria.");
            }

            //Trata os dados
            modelo.NomeSCat = modelo.NomeSCat.Trim().ToUpper();
            if (modelo.DescSCat != "")
            {
                modelo.DescSCat = modelo.DescSCat.Trim();
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOSubCategoria modelo)
        {

            //verifica o preenchimento do ingrediente
            if (modelo.NomeSCat.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para a categoria.");
            }

            //Trata os dados
            modelo.NomeSCat = modelo.NomeSCat.Trim().ToUpper();
            if (modelo.DescSCat != "")
            {
                modelo.DescSCat = modelo.DescSCat.Trim();
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable LocalizarPorId(int id)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorId(id);
        }

        public DataTable Listar()
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.Listar();

        }

        public int CadastrarSeNaoExiste(string n)
        {
            string Nome = n.Trim().ToUpper();
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CadastrarSeNaoExiste(Nome);
        }

    }

    public class BLLCusto
    {
        private DALConexao conexao;

        public BLLCusto()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void IncluirCusto(DTOCusto modelo)
        {
            modelo.QuantMovCusto = Math.Round(modelo.QuantMovCusto, 4);
            modelo.ValorUnitarioCusto = Math.Round(modelo.ValorUnitarioCusto, 2);

            DALCusto DALobj = new DALCusto(conexao);
            DALobj.IncluirCusto(modelo);
        }

        public void ExcluirCusto(DateTime datai, DateTime dataf, int unidade)
        {
            DALCusto DALobj = new DALCusto(conexao);
            DALobj.ExcluirCusto(datai, dataf, unidade);
        }

        public void ExcluirCusto(DateTime data, int unidade)
        {
            DALCusto DALobj = new DALCusto(conexao);
            DALobj.ExcluirCusto(data, unidade);
        }

        public DataTable LocalizarCusto(DateTime data, int unidade)
        {
            DALCusto DALobj = new DALCusto(conexao);
            return DALobj.LocalizarCusto(data, unidade);
        }
    }

    public class BLLCustoPrato
    {
        private DALConexao conexao;

        public BLLCustoPrato()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOCustoPratos modelo)
        {
            modelo.DataAtualizacao = DateTime.Now;

            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            DALobj.Incluir(modelo);

        }

        public void ExcluirCustoPrato(int id)
        {
            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            DALobj.ExcluirCustoPrato(id);

        }

        public void ExcluirCustoPratoPorCod(string codigo)
        {
            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            DALobj.ExcluirCustoPratoPorCod(codigo);

        }


        public void Incluir(string codPrato, int idUnidade, double valor)
        {
            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            DALobj.Incluir(codPrato, idUnidade, valor);
        }

        public void Alterar(string codPrato, int idUnidade, double valor)
        {
            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            DALobj.Alterar(codPrato, idUnidade, valor);

        }

        public double AlterarCustoPrato(string prato, int unidade)
        {
            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            return DALobj.RetornarCustoPrato(prato, unidade);
        }

        public void AtualizarCusto(string codPrato, int idUnidade)
        {
            DALCustoPratos DALobj = new DALCustoPratos(conexao);
            DALobj.AtualizarCusto(codPrato, idUnidade);
        }
    }

    #endregion

    #region Pedidos    

    public class BLLUnidadeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeMedida()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOUnidadeMedida modelo)
        {

            //verifica o preenchimento da sigla
            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("Escolha uma sigla para a unidade de medida.");
            }

            //verifica o preenchimento da descrição
            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("Escreva por extenso a unidade de medida.");
            }

            //Trata os dados
            modelo.Um = modelo.Um.Trim().ToUpper();
            modelo.Desc = modelo.Desc.Trim().ToUpper();


            DALUnidademedida DALobj = new DALUnidademedida(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOUnidadeMedida modelo)
        {
            //verifica o preenchimento da sigla
            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("Escolha uma sigla para a unidade de medida.");
            }

            //verifica o preenchimento da descrição
            if (modelo.Um.Trim().Length == 0)
            {
                throw new Exception("Escreva por extenso a unidade de medida.");
            }

            //Trata os dados
            modelo.Um = modelo.Um.Trim().ToUpper();
            modelo.Desc = modelo.Desc.Trim().ToUpper();

            DALUnidademedida DALobj = new DALUnidademedida(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidademedida DALobj = new DALUnidademedida(conexao);
            DALobj.Excluir(codigo);
        }
               
        public DataTable Listar()
        {
            DALUnidademedida DALobj = new DALUnidademedida(conexao);
            return DALobj.Listar();

        }

        public int Incluir(string n)
        {
            int ret = 0;

            string Nome = n.Trim().ToUpper();

            if (!String.IsNullOrEmpty(Nome) || Nome == " ")
            {
                
                DALUnidademedida DALobj = new DALUnidademedida(conexao);
                ret = DALobj.Incluir(Nome);
            }

            return ret;
        }

        public bool ExisteUm(string um)
        {            
            DALUnidademedida DALobj = new DALUnidademedida(conexao);
            return DALobj.ExisteUm(um.Trim().ToUpper());
        }
    }

    public class BLLSetores
    {
        private DALConexao conexao;

        public BLLSetores()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOSetores modelo)
        {

            //verifica o preenchimento do nome do setor
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para o setor.");
            }
            
            //Trata os dados
            modelo.Nome = modelo.Nome.Trim().ToUpper();


            try
            {
                modelo.Obs = modelo.Obs.Trim().ToUpper();

            }
            catch
            {

            }
            
            

            DALSetores DALobj = new DALSetores(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOSetores modelo)
        {
            //verifica o preenchimento do nome do setor
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("Escolha um nome para o setor.");
            }

            //Trata os dados
            modelo.Nome = modelo.Nome.Trim().ToUpper();
            modelo.Obs = modelo.Obs.Trim().ToUpper();
                        
            DALSetores DALobj = new DALSetores(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSetores DALobj = new DALSetores(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Listar()
        {
            DALSetores DALobj = new DALSetores(conexao);
            return DALobj.Listar();
        }
        
        public bool ExisteSetor(string setor)
        {
            DALSetores DALobj = new DALSetores(conexao);
            return DALobj.ExisteSetor(setor.Trim().ToUpper());
        }

        public string NomeSetor(int id)
        {
            DALSetores DALobj = new DALSetores(conexao);
            return DALobj.NomeSetor(id);
        }

    }

    public class BLLPedidos
    {
        private DALConexao conexao;

        public BLLPedidos()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOPedidos modelo)
        {
            modelo.Data_criacao = DateTime.Today;

            //verifica o preenchimento do nome do setor
            if(modelo.Data_entrega < modelo.Data_criacao)
            {
                throw new Exception("A data de entrega deve ser posterior ao dia de hoje!");
            }
            
            DALPedidos DALobj = new DALPedidos(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOPedidos modelo)
        {
            //verifica o preenchimento do nome do setor
            modelo.Data_criacao = DateTime.Today;

            //verifica o preenchimento do nome do setor
            if (modelo.Data_entrega < modelo.Data_criacao)
            {
                throw new Exception("A data de entrega deve ser posterior ao dia de hoje!");
            }

            DALPedidos DALobj = new DALPedidos(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALPedidos DALobj = new DALPedidos(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Listar()
        {
            DALPedidos DALobj = new DALPedidos(conexao);
            return DALobj.Listar();
        }

        public DataTable Listar(bool a, bool s, bool c)
        {
            string aberto, solicitado, cancelado;
            aberto = " ";
            solicitado = " ";
            cancelado = " ";

            if (a) { aberto = "Aberto"; }
            if (s) { solicitado = "Solicitado"; }
            if (c) { cancelado = "Cancelado"; }

            DALPedidos DALobj = new DALPedidos(conexao);
            return DALobj.Listar(aberto, solicitado, cancelado);
        }
        
        public DataTable Listar(int id)
        {
            DALPedidos DALobj = new DALPedidos(conexao);
            return DALobj.Listar(id);
        }

        public DTOPedidos Carregar(int id)
        {
            DALPedidos DALobj = new DALPedidos(conexao);
            return DALobj.Carregar(id);
        }


    }

    public class BLLItensPedido
    {
        private DALConexao conexao;

        public BLLItensPedido()
        {
            DALConexao cx = new DALConexao(DALDadosConexao.StringDaConexao);

            this.conexao = cx;
        }

        public void Incluir(DTOItensPedido modelo)
        {
            //verifica o preenchimento do nome do setor
            modelo.Obs = modelo.Obs.Trim().ToUpper();
            modelo.Obs_setor = modelo.Obs_setor.Trim().ToUpper();

            DALItensPedido DALobj = new DALItensPedido(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(DTOItensPedido modelo)
        {
            //verifica o preenchimento do nome do setor
            modelo.Obs = modelo.Obs.Trim().ToUpper();
            modelo.Obs_setor = modelo.Obs_setor.Trim().ToUpper();

            DALItensPedido DALobj = new DALItensPedido(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALItensPedido DALobj = new DALItensPedido(conexao);
            DALobj.Excluir(codigo);
        }

        public void Excluir(int id, string obs, int pedido)
        {
            DALItensPedido DALobj = new DALItensPedido(conexao);
            DALobj.Excluir(id, obs, pedido);
        }


        //TODO criar de acordo com a necessidade
        public DataTable ListarItensSetor(int id_setor, string obs)
        {
            DALItensPedido DALobj = new DALItensPedido(conexao);
            return DALobj.ListarItensSetor(id_setor, obs);
        }

        public DataTable AgruparPedidosSetores(int id)
        {
            DALItensPedido DALobj = new DALItensPedido(conexao);
            return DALobj.AgruparPedidosSetores(id);
        }


        public DTOItensPedido CarregaItensPedido(int id)
        {
            DALItensPedido DALobj = new DALItensPedido(conexao);
            return DALobj.Carregar(id);
        }
    }

    #endregion

}







