using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace GerenciadorEstoque.Code
{
    public class DALDadosConexao
    {
        /// <summary>
        /// String da conexão: Concatena as informações retiradas do cofig para gerar a conexão com o banco de dados
        /// </summary>
        
        public static string StringDaConexao = $"Data Source={Properties.Settings.Default.server};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=True;User ID={Properties.Settings.Default.UserDB};Password={Properties.Settings.Default.senhaDB}";
    }

    public class DALConexao
    {
        private string _stringConexao;
        private SqlConnection _conexao;

        public DALConexao(string dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;

        }
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {         
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }   

    public class DALMateriais
    {
        string folder = @"Imagens\Materiais\";

        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALMateriais(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOMateriais modelo, string foto)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into materiais (codigocigam, subgrupo_id_subgrupo, descricao, um, fc, conversaoPeso) " +
                              "values (@codigo, @subgrupo, @nome, @um, @fc, @conversao); select @@IDENTITY;"
            };

            string codigo;
            if(modelo.CodigoCigam != "")
            {
                codigo = modelo.CodigoCigam;
            }
            else
            {
                codigo = CodigoItem(modelo);
            }

            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@subgrupo", modelo.Subgrupo_id_subgrupo);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@um", modelo.Um);
            cmd.Parameters.AddWithValue("@fc", modelo.Fc);
            cmd.Parameters.AddWithValue("@conversao", modelo.ConversaoPeso);

            conexao.Conectar();
            modelo.Id_material = Convert.ToInt32(cmd.ExecuteScalar());

            if (foto != "")
            {
                try
                {
                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.Id_material.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.Id_material.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.Id_material.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.Id_material.ToString() + Path.GetExtension(foto));
                    }
                }
                catch { }
            }

            conexao.Desconectar();
        }

        internal DataTable Localizar(string valor, int idSubgrupo, bool somenteEstoque)
        {
            string somenteE = "";

            if (somenteEstoque)
            {
                somenteE = "01.";
            }

            if (idSubgrupo > 0)
            {

                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select m.id_material, m.codigocigam, m.descricao, m.um, s.nome from materiais m " +
                    "join subgrupo s on m.subgrupo_id_subgrupo = s.id_subgrupo " +
                    $" where m.descricao like '%{valor}%' and m.subgrupo_id_subgrupo = {idSubgrupo} and codigoCigam like '{somenteE}%';", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            else
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(@"select m.id_material, (m.codigocigam) as cod, m.descricao, m.um, s.nome from materiais m " +
                   "join subgrupo s on m.subgrupo_id_subgrupo = s.id_subgrupo " +
                   $" where m.descricao like '%{valor}%' and codigoCigam like '{somenteE}%';", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
        }

        public void Alterar(DTOMateriais modelo, string foto)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update materiais set codigocigam = (@codigo), subgrupo_id_subgrupo = (@subgrupo), descricao = (@nome), um = (@um), fc = (@fc), conversaoPeso = (@conversao) WHERE id_material = (@id);"
            };
            cmd.Parameters.AddWithValue("@codigo", modelo.CodigoCigam);
            cmd.Parameters.AddWithValue("@subgrupo", modelo.Subgrupo_id_subgrupo);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@um", modelo.Um);
            cmd.Parameters.AddWithValue("@id", modelo.Id_material);
            cmd.Parameters.AddWithValue("@fc", modelo.Fc);
            cmd.Parameters.AddWithValue("@conversao", modelo.ConversaoPeso);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            if (foto != "")
            {
                try
                {
                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.Id_material.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.Id_material.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.Id_material.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.Id_material.ToString() + Path.GetExtension(foto));
                    }
                }

                catch { }
            }
            conexao.Desconectar();
        }

        public void CriarValorExterno(string cod, double valor)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update materiais set valorExterno = (@valor) WHERE codigocigam = (@codigo);"
            };
            cmd.Parameters.AddWithValue("@codigo", cod);
            cmd.Parameters.AddWithValue("@valor", valor);            

            conexao.Conectar();
            cmd.ExecuteNonQuery();            
            conexao.Desconectar();
        }

        public void DeletarValorExternoPorCod(string cod)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update materiais set valorExterno = (@valor) WHERE codigocigam = (@codigo);"
            };
            cmd.Parameters.AddWithValue("@codigo", cod);
            cmd.Parameters.AddWithValue("@valor", 0);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from materiais where id_material = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void ExcluirPorCodigo(string codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from materiais where codigocigam = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        private string CodigoItem(DTOMateriais dto)
        {
            string codigo = "00.00.0000";

            
            string meio = "";
            //Verificar se o item é um produto, uma variação de um produto do cigam ou  uma ficha tecnica
            //Caso seja um produto novo, o codigo comeca com '02'.

            // Recuperamos o grupo do item
            meio = dto.Subgrupo_id_subgrupo.ToString("00");

            //Listamos os codigos referentes ao grupo e subgrupo referentes ao item, exemplo, item novo de hortifruti, listamos '02.01.%'


            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select RIGHT(codigocigam, 4)as codigo from materiais where codigocigam like '02.{meio}.%' order by codigo", conexao.StringConexao);
            da.Fill(tabela);

            //Faz um for para verifricar a primeira posição vazia

            int numero = 0;
            for(int i=0;i<tabela.Rows.Count; i++)
            {
                if(i+1 != Convert.ToInt32(tabela.Rows[i][0].ToString()))
                {
                    numero = (i+1);
                    break;
                }                
            }

            if(numero == 0)
            {
                numero = tabela.Rows.Count + 1;
            }

            codigo = $"02.{meio}.{numero.ToString("0000")}";

            return codigo;
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_material, codigocigam, descricao, um, subgrupo_id_subgrupo, um, fc, conversaoPeso from materiais", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }

        public DataTable LocalizarPorCod(string cod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT descricao, um, fc FROM materiais where codigocigam = '{cod}';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }

        // Localiza por nome       

        public double ValorExterno(String codigo)
        {
            DTOMateriais modelo = new DTOMateriais();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select valorExterno from materiais where codigocigam = '{codigo}';"
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            double retorno = 0;

            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToDouble(registro["valorExterno"]);
            }
            conexao.Desconectar();
            return retorno;

        }

        public DataTable Localizar(String valor, int idSubgrupo)
        {
            if (idSubgrupo > 0)
            {

                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select m.id_material, m.codigocigam, m.descricao, m.um, s.nome from materiais m " +
                    "join subgrupo s on m.subgrupo_id_subgrupo = s.id_subgrupo " +
                    $" where m.descricao like '%{valor}%' and m.subgrupo_id_subgrupo = {idSubgrupo};", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            else
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(@"select m.id_material, (m.codigocigam) as cod, m.descricao, m.um, s.nome from materiais m " +
                   "join subgrupo s on m.subgrupo_id_subgrupo = s.id_subgrupo " +
                   $" where m.descricao like '%{valor}%';", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }

        }

        public DataTable ListarProdutos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"select m.id_material, (m.codigocigam) as cod, m.descricao, m.um, COUNT(a.id_marcas_aprovadas) as quant from materiais m  " +
"left join marcasaprovadas a on a.materiais_id_material = m.id_material " +
$"where descricao like '%{valor}%' group by m.id_material, m.descricao, m.codigocigam, m.um;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }

        public string NomePeloCodigo(String codigo)
        {
            DTOMateriais modelo = new DTOMateriais();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select descricao from materiais where codigocigam = '{codigo}';"
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            string retorno = "";

            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToString(registro["descricao"]);
            }
            conexao.Desconectar();
            return retorno;

        }

        public bool ExisteCodigo(string codigo)
        {
            DTOMateriais modelo = new DTOMateriais();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_material from materiais where codigocigam = '{codigo}';"
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            bool retorno = false;

            if (registro.HasRows)
            {
                retorno = true;
            }
            conexao.Desconectar();
            return retorno;
            
        }

        public DTOMateriais CarregaModeloMateriais(int codigo)
        {
            DTOMateriais modelo = new DTOMateriais();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select id_material, codigocigam, descricao, um, subgrupo_id_subgrupo from materiais where id_material =" + codigo.ToString()
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_material = Convert.ToInt32(registro["id_material"]);
                modelo.CodigoCigam = Convert.ToString(registro["codigocigam"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.Um = Convert.ToString(registro["um"]);
                modelo.Subgrupo_id_subgrupo = Convert.ToInt32(registro["subgrupo_id_subgrupo"]);


            }
            conexao.Desconectar();
            return modelo;

        }

        public DTOMateriais CarregaModeloMateriais(string codigo)
        {
            DTOMateriais modelo = new DTOMateriais();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_material, codigocigam, descricao, um, subgrupo_id_subgrupo from materiais where codigocigam = '{codigo.ToString()}';"
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_material = Convert.ToInt32(registro["id_material"]);
                modelo.CodigoCigam = Convert.ToString(registro["codigocigam"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.Um = Convert.ToString(registro["um"]);
                modelo.Subgrupo_id_subgrupo = Convert.ToInt32(registro["subgrupo_id_subgrupo"]);


            }
            conexao.Desconectar();
            return modelo;

        }

    }

    public class DALMateriaisDerivados
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALMateriaisDerivados(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOMateriaisDerivados modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into materiaisDerivados (codMaterialBase, descricao, um) " +
                              "values (@codigo, @nome, @um); select @@IDENTITY;"
            };                      

            cmd.Parameters.AddWithValue("@codigo", modelo.CodigoCigam);            
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            cmd.Parameters.AddWithValue("@um", modelo.Um);            

            conexao.Conectar();
            modelo.Id_material = Convert.ToInt32(cmd.ExecuteScalar());
            
            conexao.Desconectar();
        }

        public void Alterar(DTOMateriais modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update materiaisDerivados set codMaterialBase = (@codigo), descricao = (@nome), um = (@um) WHERE id_materialDerivado = (@id);"
            };
            cmd.Parameters.AddWithValue("@codigo", modelo.CodigoCigam);           
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);            
            cmd.Parameters.AddWithValue("@id", modelo.Id_material);            

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from materiaisDerivados where id_materialDerivado = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(string codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from materiaisDerivados where codMaterialBase = @codigo;"
            };
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Listar(string codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_materialDerivado, codMaterialBase, descricao, um from materiaisDerivados where codMaterialBase = '{codigo}' order by descricao asc;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }

        public bool ExisteNome(string nome)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select count(id_materialDerivado) as quant from materiaisDerivados where descricao = '{nome}';"
            };

            bool result = false;

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            registro.Read();
            if (Convert.ToInt32(registro["quant"]) > 0)
            {
                result = true;
            }            

            conexao.Desconectar();

            return result;
        }



    }

    public class DALPlanilhaPedidos
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALPlanilhaPedidos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOPlanilhaPedidos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into planbilhaPedidos (id_unidade, codItem, nomeItem, unidadeMedia, id_unidadeOrganizadora) " +
                              "values (@unidade, @codigo, @nome, @um, @unidadeOrganizadora); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@unidade", modelo.Unidade);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CodigoCigam);
            cmd.Parameters.AddWithValue("@um", modelo.UnidadeMedida);
            cmd.Parameters.AddWithValue("@unidadeOrganizadora", modelo.Id_unidadeOrganizadora);
            
            conexao.Conectar();
            cmd.ExecuteNonQuery ();
            conexao.Desconectar();
        }

        public void Alterar(DTOPlanilhaPedidos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update planbilhaPedidos set id_unidade = (@unidade), codItem = (@codigo) " +
                ", nomeItem = (@nome), unidadeMedia = (@um), id_unidadeOrganizadora = (@org);"
            };
            cmd.Parameters.AddWithValue("@unidade", modelo.Unidade);
            cmd.Parameters.AddWithValue("@codigo", modelo.CodigoCigam);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@um", modelo.UnidadeMedida);
            cmd.Parameters.AddWithValue("@org", modelo.Id_unidadeOrganizadora);
            
            conexao.Conectar();
            cmd.ExecuteNonQuery();            
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from materiais where id_material = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void ExcluirPorCodigo(string codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from materiais where codigocigam = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

    }

    public class DALUsuarios
    {
        string folder = @"Imagens\Usuarios\";

        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALUsuarios(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOUsuarios modelo, string foto)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into usuarios (nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade) " +
                              "values (@nome, @usuario, @senha, @email, @telefone, @datacadastro, @ativo, @senhaEmail, @unidade); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@usuario", modelo.Usuario);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.Datacadastro);
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);
            cmd.Parameters.AddWithValue("@senhaEmail", modelo.SenhaEmail);
            cmd.Parameters.AddWithValue("@unidade", modelo.IdUnidade);

            conexao.Conectar();
            modelo.Id_usuario = Convert.ToInt32(cmd.ExecuteScalar());

            if (foto != "")
            {
                try
                {
                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto));
                    }
                }
                catch { }
            }

            conexao.Desconectar();
        }

        public void Alterar(DTOUsuarios modelo, string foto)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update usuarios set nome = (@nome), usuario = (@usuario), senha = (@senha), " +
                "email = (@email), telefone = (@telefone), datacadastro = (@datacadastro), ativo = (@ativo), senhaEmail = (@senhaEmail), id_unidade = (@unidade) WHERE id_usuario = (@id);"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@usuario", modelo.Usuario);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.Datacadastro);           
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);
            cmd.Parameters.AddWithValue("@id", modelo.Id_usuario);
            cmd.Parameters.AddWithValue("@senhaEmail", modelo.SenhaEmail);
            cmd.Parameters.AddWithValue("@unidade", modelo.IdUnidade);

            conexao.Conectar();
            cmd.ExecuteNonQuery();

            if (foto != "")
            {
                try
                {

                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.Id_usuario.ToString() + Path.GetExtension(foto));
                    }
                }

                catch { }
            }

            conexao.Desconectar();
        }

        public void DesativarUsuario(int id)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update usuarios set ativo = (@ativo) WHERE id_usuario = (@id);"
            };
            
            cmd.Parameters.AddWithValue("@ativo", 0);
            cmd.Parameters.AddWithValue("@id", id);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void AlterarSenha(DTOUsuarios modelo, string senhaN)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"update usuarios set senha = '{senhaN}' WHERE id_usuario = (@id);"
            };

            cmd.Parameters.AddWithValue("@id", modelo.Id_usuario);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from usuarios where id_usuario = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        //Consulta por nome e login
        public DataTable Consulta(String nome, String usuario)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select u.id_usuario, u.ativo, u.nome, u.usuario, un.nomeReduzido from usuarios u join unidade un on u.id_unidade = un.id_unidade where u.nome like '%" + nome + "%' and u.usuario like '%" + usuario + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Consulta por nome, login e senha
        public DataTable Consulta(String nome, String usuario, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select u.id_usuario, u.ativo, u.nome, u.usuario, un.nomeReduzido from usuarios u join unidade un on u.id_unidade = un.id_unidade where u.nome like '%" + nome + "%' and u.usuario like '%" + usuario + "%' and u.id_unidade = "+unidade+";", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Consulta por nome e login
        public DataTable Consulta(String nome, String usuario, bool a)
        {
            int ativo = 0;
            if (a)
            {
                ativo = 1;
            }

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select u.id_usuario, u.ativo, u.nome, u.usuario, un.nomeReduzido from usuarios u join unidade un on u.id_unidade = un.id_unidade where u.nome like '%" + nome + "%' and u.usuario like '%" + usuario + "%' and u.ativo = "+ativo+";", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Consulta por nome, login e senha
        public DataTable Consulta(String nome, String usuario, int unidade, bool a)
        {
            int ativo = 0;
            if (a)
            {
                ativo = 1;
            }

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select u.id_usuario, u.ativo, u.nome, u.usuario, un.nomeReduzido from usuarios u join unidade un on u.id_unidade = un.id_unidade where u.nome like '%" + nome + "%' and u.usuario like '%" + usuario + "%' and u.id_unidade = " + unidade + " and u.ativo = "+ativo+";", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Listar todos os usuarios
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // Localiza por nome
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios where nome like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Localizar por nome e unidade
        public DataTable Localizar(String valor, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios where nome like '%" + valor + "%' and id_unidade = "+unidade+";", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Localizar por nome e unidade
        public DataTable Localizar(String nome, String usuario, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios where nome like '%" + nome + "%' and usuario like '%" + usuario + "%' and id_unidade = " + unidade + ";", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Localizar por nome e login
        public DataTable Localizar(String nome, String usuario)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios where nome like '%" + nome + "%' and usuario like '%" + usuario + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        // Localiza por id
        public DataTable Localizar(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios where id_usuario = {id};", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }        
        

        // Localiza por usuario e senha
        public DataTable Listar(string usuario, string senha)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select COUNT(id_usuario) AS quant, nome, usuario, senha, email, telefone, " +
                "datacadastro, ativo, senhaEmail, id_unidade from usuarios where usuario = '" + usuario + "' and senha = '" + senha + "' group by id_usuario, nome, usuario, " +
                "senha, acesso, email, telefone, datacadastro, ativo;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int IdPorUser(string user)
        {
            int idretorno = 0;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_usuario from usuarios where usuario = '{user}';"
            };

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                idretorno = Convert.ToInt32(registro["id_usuario"]);
            }
            conexao.Desconectar();
            return idretorno;

        }

        public DTOUsuarios CarregaModeloUsuarios(string usuario, string senha)
        {
            DTOUsuarios modelo = new DTOUsuarios();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select id_usuario, nome, usuario, senha, email, telefone, " +
                "datacadastro, ativo, senhaEmail, id_unidade from usuarios where usuario = '" + usuario + "' and senha = '" + senha + "' and ativo = 1;"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_usuario = Convert.ToInt32(registro["id_usuario"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Usuario = Convert.ToString(registro["usuario"]);
                modelo.Senha = Convert.ToString(registro["senha"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Datacadastro = Convert.ToDateTime(registro["datacadastro"]);
                modelo.Ativo = Convert.ToBoolean(registro["ativo"]);
                modelo.SenhaEmail = Convert.ToString(registro["senhaEmail"]);
                modelo.IdUnidade = Convert.ToInt32(registro["id_unidade"]);
            }

            conexao.Desconectar();

            return modelo;
        }

        public DTOUsuarios CarregaModeloUsuarios(int id)
        {
            DTOUsuarios modelo = new DTOUsuarios();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_usuario, nome, usuario, senha, email, telefone, datacadastro, ativo, senhaEmail, id_unidade from usuarios where id_usuario = {id};"
            };

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_usuario = Convert.ToInt32(registro["id_usuario"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Usuario = Convert.ToString(registro["usuario"]);
                modelo.Senha = Convert.ToString(registro["senha"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Datacadastro = Convert.ToDateTime(registro["datacadastro"]);
                modelo.Ativo = Convert.ToBoolean(registro["ativo"]);
                modelo.SenhaEmail = Convert.ToString(registro["senhaEmail"]);
                modelo.IdUnidade = Convert.ToInt32(registro["id_unidade"]);
            }

            conexao.Desconectar();

            return modelo;

        }
    }

    public class DALPermissao
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALPermissao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOPermissao modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into permissoes (localPermissao, permissao, id_usuarios) " +
                              "values (@local, @permissao, @usuario); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@local", modelo.LocalPermissao);
            cmd.Parameters.AddWithValue("@permissao", modelo.Permissao);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_usuarios);

            conexao.Conectar();
            modelo.Id_permissao = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void Alterar(DTOPermissao modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update permissoes set permissao = (@permissao)  WHERE id_usuarios = (@usuario) and localPermissao = (@local);"
            };
            cmd.Parameters.AddWithValue("@local", modelo.LocalPermissao);
            cmd.Parameters.AddWithValue("@permissao", modelo.Permissao);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_usuarios);
            

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from permissoes where id_usuarios = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }


        public int PermissaoPorLocal(Diversos.LocaisPermissoes local, DTOUsuarios dto)
        {
            int permissao = 0;

            DTOPermissao modelo = new DTOPermissao();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_permissao, localPermissao, permissao from permissoes where id_usuarios = {dto.Id_usuario} and localPermissao = {(int)local};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                permissao = Convert.ToInt32(registro["permissao"]);
            }

            conexao.Desconectar();

            return permissao;
        }
    }

    public class DALManterConectado
    {
        private DALConexao conexao;

        //Conecta
        public DALManterConectado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOManterConectado modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into manterConectado (ip, nomePC, id_usuario, ultima_conexao) " +
                              "values (@ip, @nomePC, @usuario, @ultimaConexao); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@ip", modelo.Ip);
            cmd.Parameters.AddWithValue("@nomePC", modelo.NomePC);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_usuario);
            cmd.Parameters.AddWithValue("@ultimaConexao", modelo.Umtima_conexao);

            conexao.Conectar();
            modelo.Id_usuario = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();

        }

        public void AtualizarData()
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update manterConectado set ultima_conexao = (@ultimaConexao) WHERE ip = (@ip);"
            };

            RecuperaDadosMaquina dados = new RecuperaDadosMaquina();

            cmd.Parameters.AddWithValue("@ultimaConexao", DateTime.Now);
            cmd.Parameters.AddWithValue("@ip", dados.RecuperarIp());

            conexao.Conectar();
            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from manterConectado where id_conexao = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_conexao, ip, nomePC, id_usuario, ultima_conexao from manterConectado", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Localizar por id de usuário
        public DataTable Localizar(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_conexao, ip, nomePC, id_usuario, ultima_conexao from manterConectado where id_usuario = " + 1, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOManterConectado CarregaModeloConexao(string ip)
        {
            DTOManterConectado modelo = new DTOManterConectado();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_conexao, ip, nomePC, id_usuario, ultima_conexao from manterConectado where ip = '{ip}';"
            };

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_conexao = Convert.ToInt32(registro["id_conexao"]);
                modelo.Ip = Convert.ToString(registro["ip"]);
                modelo.NomePC = Convert.ToString(registro["nomePC"]);
                modelo.Id_usuario = Convert.ToInt32(registro["id_usuario"]);
                modelo.Umtima_conexao = Convert.ToDateTime(registro["ultima_conexao"]);
            }

            conexao.Desconectar();

            return modelo;

        }
    }

    public class DALConfigEmail
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALConfigEmail(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOConfigEmail modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into configemail (smtp, ssl, porta, usuarios_id_usuario) " +
                              "values (@smtp, @ssl, @porta, @usuario); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@smtp", modelo.Smtp);
            cmd.Parameters.AddWithValue("@ssl", modelo.Ssl);
            cmd.Parameters.AddWithValue("@porta", modelo.Porta);
            cmd.Parameters.AddWithValue("@usuario", modelo.Usuarios_id_usuario);

            conexao.Conectar();
            modelo.Id_config_email = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }

        public void Alterar(DTOConfigEmail modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update configemail set smtp = (@smtp), ssl = (@ssl), porta = (@porta), usuarios_id_usuario = (@usuario);"
            };

            cmd.Parameters.AddWithValue("@smtp", modelo.Smtp);
            cmd.Parameters.AddWithValue("@ssl", modelo.Ssl);
            cmd.Parameters.AddWithValue("@porta", modelo.Porta);
            cmd.Parameters.AddWithValue("@usuario", modelo.Usuarios_id_usuario);

            conexao.Conectar();
            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public void Excluir()
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from configemail;"
            };

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DTOConfigEmail CarregaModelo()
        {
            DTOConfigEmail modelo = new DTOConfigEmail();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select smtp, ssl, porta, usuarios_id_usuario from configemail;"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Smtp = Convert.ToString(registro["smtp"]);
                modelo.Ssl = Convert.ToBoolean(registro["ssl"]);
                modelo.Porta = Convert.ToInt32(registro["porta"]);
                modelo.Usuarios_id_usuario = Convert.ToInt32(registro["usuarios_id_usuario"]);
            }

            conexao.Desconectar();

            return modelo;
        }

        public bool TemRegistro()
        {
            bool tem = false;

            DTOConfigEmail modelo = new DTOConfigEmail();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select smtp, ssl, porta, usuarios_id_usuario from configemail;"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                tem = true;
            }

            conexao.Desconectar();

            return tem;
        }
    }

    public class DALRecuperaSenha
    {
        private DALConexao conexao;

        //Conecta
        public DALRecuperaSenha(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Criar(int id)
        {

            Excluir(id);

            string codigo = "";

            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                codigo += r.Next(0, 9).ToString();
            }

            DateTime data = DateTime.Now;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into recuperarSenha (id_usuario, codigo, data_limite) " +
                              $"values ({id}, '{codigo}', '{data}'); select @@IDENTITY;"
            };

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

            EnviaEmail em = new EnviaEmail();

            DTOUsuarios dto = new DTOUsuarios();
            BLLUSuarios bll = new BLLUSuarios();

            dto = bll.CarregaModeloUsuarios(id);

            em.InfoEmail(dto.Email, "", "Recuperação de senha", "" +
                "Este email está sendo enviado porque foi solicitada a recuperação de senha no Sistema de Estoques.\nCaso você não tenha solicitado esta recuperação, favor ignorar este email.\n" +
                $"Caso você tenha solicitado a recuperação, digite o código <h3>{codigo}</h3> na recuperação de senha do sistema.", false);
        }

        public void DeletarPorData()
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE recuperarSenha WHERE data_limite < DATEADD(day, -1, GETDATE()); "
            };

            conexao.Conectar();
            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from recuperarSenha where id_usuario = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public bool VerificaCodigo(int id, string cod)
        {
            bool resultado = false;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_usuario from recuperarSenha where id_usuario = {id} and codigo = '{cod}';"
            };

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                resultado = true;
            }
            conexao.Desconectar();
            return resultado;

        }

    }

    public class DALEmpresas
    {
        string folder = @"Imagens\Empresas\";

        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALEmpresas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOEmpresas modelo, string foto)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO empresa " +

                "(codigocigam, " +
                "nomecompleto, " +
                "fantasia, " +
                "tipopessoa, " +
                "fonevendas, " +
                "fonecontabil, " +
                "fonefiscal, " +
                "fonefax, " +
                "emailfiscal, " +
                "emailfinanceiro, " +
                "emailvenda, " +
                "emailvendasubst, " +
                "cep, " +
                "endereco, " +
                "numero, " +
                "complemento, " +
                "bairro, " +
                "municipio, " +
                "uf, " +
                "pais, " +
                "cnpj, " +
                "aniversario, " +
                "ultimomov, " +
                "ultimacompra, " +
                "ultimaatualizacao, " +
                "ativo, " +
                "datacadastro, " +
                "tipofrete, " +
                "percentualfrete, " +
                "valorfixofrete, " +
                "id_cond_pagto, " +
                "vendedor, " +
                "vendedorsubst, " +
                "subst) VALUES" +

                "(@codigocigam, " +
                "@nomecompleto, " +
                "@fantasia, " +
                "@tipopessoa, " +
                "@fonevendas, " +
                "@fonecontabil, " +
                "@fonefiscal, " +
                "@fonefax, " +
                "@emailfiscal, " +
                "@emailfinanceiro, " +
                "@emailvenda, " +
                "@emailvendasubst, " +
                "@cep, " +
                "@endereco, " +
                "@numero, " +
                "@complemento, " +
                "@bairro, " +
                "@municipio, " +
                "@uf, " +
                "@pais, " +
                "@cnpj, " +
                "@aniversario, " +
                "@ultimomov, " +
                "@ultimacompra, " +
                "@ultimaatualizacao, " +
                "@ativo, " +
                "@datacadastro, " +
                "@tipofrete, " +
                "@percentualfrete, " +
                "@valorfixofrete, " +
                "@id_cond_pagto, " +
                "@vendedor, " +
                "@vendedorsubst, " +
                "@subst); " +
                "select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@codigocigam", modelo.CodigoCIGAM);
            cmd.Parameters.AddWithValue("@nomecompleto", modelo.NomeCompleto);
            cmd.Parameters.AddWithValue("@fantasia", modelo.Fantasia);
            cmd.Parameters.AddWithValue("@tipopessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@fonevendas", modelo.FoneVendas);
            cmd.Parameters.AddWithValue("@fonecontabil", modelo.FoneContabil);
            cmd.Parameters.AddWithValue("@fonefiscal", modelo.FoneFiscal);
            cmd.Parameters.AddWithValue("@fonefax", modelo.FoneFax);
            cmd.Parameters.AddWithValue("@emailfiscal", modelo.EmailFiscal);
            cmd.Parameters.AddWithValue("@emailfinanceiro", modelo.EmailFinanceiro);
            cmd.Parameters.AddWithValue("@emailvenda", modelo.EmailVenda);
            cmd.Parameters.AddWithValue("@emailvendasubst", modelo.EmailVendaSubst);
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@numero", modelo.Numero);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@municipio", modelo.Municipio);
            cmd.Parameters.AddWithValue("@uf", modelo.Uf);
            cmd.Parameters.AddWithValue("@pais", modelo.Pais);
            cmd.Parameters.AddWithValue("@cnpj", modelo.Cnpj);
            cmd.Parameters.AddWithValue("@aniversario", modelo.Aniversario);
            cmd.Parameters.AddWithValue("@ultimomov", modelo.UltimoMov);
            cmd.Parameters.AddWithValue("@ultimacompra", modelo.UltimaCompra);
            cmd.Parameters.AddWithValue("@ultimaatualizacao", modelo.UltimaAtualizacao);
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@tipofrete", modelo.TipoFrete);
            cmd.Parameters.AddWithValue("@percentualfrete", modelo.PercentualFrete);
            cmd.Parameters.AddWithValue("@valorfixofrete", modelo.ValorFixoFrete);
            cmd.Parameters.AddWithValue("@id_cond_pagto", modelo.Id_cond_pagto);
            cmd.Parameters.AddWithValue("@vendedor", modelo.Vendedor);
            cmd.Parameters.AddWithValue("@vendedorsubst", modelo.VendedorSubst);
            cmd.Parameters.AddWithValue("@subst", modelo.Subst);


            conexao.Conectar();
            modelo.Id_empresa = Convert.ToInt32(cmd.ExecuteScalar());

            if (foto != "")
            {
                try
                {
                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto));
                    }
                }
                catch { }
            }

            conexao.Desconectar();

        }

        public void Alterar(DTOEmpresas modelo, string foto)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update empresa set " +
                "[codigocigam] = (@codigocigam), " +
                "[nomecompleto] = (@nomecompleto), " +
                "[fantasia] = (@fantasia), " +
                "[tipopessoa] = (@tipopessoa), " +
                "[fonevendas] = (@fonevendas), " +
                "[fonecontabil] = (@fonecontabil), " +
                "[fonefiscal] = (@fonefiscal), " +
                "[fonefax] = (@fonefax), " +
                "[emailfiscal] = (@emailfiscal), " +
                "[emailfinanceiro] = (@emailfinanceiro), " +
                "[emailvenda] = (@emailvenda), " +
                "[emailvendasubst] = (@emailvendasubst), " +
                "[cep] = (@cep), " +
                "[endereco] = (@endereco), " +
                "[numero] = (@numero), " +
                "[complemento] = (@complemento), " +
                "[bairro] = (@bairro), " +
                "[municipio] = (@municipio), " +
                "[uf] = (@uf), " +
                "[pais] = (@pais), " +
                "[cnpj] = (@cnpj), " +
                "[aniversario] = (@aniversario), " +
                "[ultimomov] = (@ultimomov), " +
                "[ultimacompra] = (@ultimacompra), " +
                "[ultimaatualizacao] = (@ultimaatualizacao), " +
                "[ativo] = (@ativo), " +
                "[datacadastro] = (@datacadastro), " +
                "[tipofrete] = (@tipofrete), " +
                "[percentualfrete] = (@percentualfrete), " +
                "[valorfixofrete] = (@valorfixofrete), " +
                "[condicoespagto_id_cond_pagto] = (@condicoespagto_id_cond_pagto), " +
                "[vendedor] = (@vendedor), " +
                "[vendedorsubst] = (@vendedorsubst), " +
                "[subst] = (@subst), " +
           "WHERE id_empresa = (@id)"
            };

            cmd.Parameters.AddWithValue("@codigocigam", modelo.CodigoCIGAM);
            cmd.Parameters.AddWithValue("@nomecompleto", modelo.NomeCompleto);
            cmd.Parameters.AddWithValue("@fantasia", modelo.Fantasia);
            cmd.Parameters.AddWithValue("@tipopessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@fonevendas", modelo.FoneVendas);
            cmd.Parameters.AddWithValue("@fonecontabil", modelo.FoneContabil);
            cmd.Parameters.AddWithValue("@fonefiscal", modelo.FoneFiscal);
            cmd.Parameters.AddWithValue("@fonefax", modelo.FoneFax);
            cmd.Parameters.AddWithValue("@emailfiscal", modelo.EmailFiscal);
            cmd.Parameters.AddWithValue("@emailfinanceiro", modelo.EmailFinanceiro);
            cmd.Parameters.AddWithValue("@emailvenda", modelo.EmailVenda);
            cmd.Parameters.AddWithValue("@emailvendasubst", modelo.EmailVendaSubst);
            cmd.Parameters.AddWithValue("@cep", modelo.Cep);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@numero", modelo.Numero);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@municipio", modelo.Municipio);
            cmd.Parameters.AddWithValue("@uf", modelo.Uf);
            cmd.Parameters.AddWithValue("@pais", modelo.Pais);
            cmd.Parameters.AddWithValue("@cnpj", modelo.Cnpj);
            cmd.Parameters.AddWithValue("@aniversario", modelo.Aniversario);
            cmd.Parameters.AddWithValue("@ultimomov", modelo.UltimoMov);
            cmd.Parameters.AddWithValue("@ultimacompra", modelo.UltimaCompra);
            cmd.Parameters.AddWithValue("@ultimaatualizacao", modelo.UltimaAtualizacao);
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@tipofrete", modelo.TipoFrete);
            cmd.Parameters.AddWithValue("@percentualfrete", modelo.PercentualFrete);
            cmd.Parameters.AddWithValue("@valorfixofrete", modelo.ValorFixoFrete);
            cmd.Parameters.AddWithValue("@condicoespagto_id_cond_pagto", modelo.Id_cond_pagto);
            cmd.Parameters.AddWithValue("@vendedor", modelo.Vendedor);
            cmd.Parameters.AddWithValue("@vendedorsubst", modelo.VendedorSubst);
            cmd.Parameters.AddWithValue("@subst", modelo.Subst);
            cmd.Parameters.AddWithValue("@id", modelo.Id_empresa);

            conexao.Conectar();
            cmd.ExecuteNonQuery();

            if (foto != "")
            {
                try
                {

                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.Id_empresa.ToString() + Path.GetExtension(foto));
                    }
                }

                catch { }
            }

            conexao.Desconectar();
        }
           

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from empresa where id_empresa = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select " +

                "[codigocigam], " +
                "[nomecompleto], " +
                "[fantasia], " +
                "[tipopessoa], " +
                "[fonevendas], " +
                "[fonecontabil], " +
                "[fonefiscal], " +
                "[fonefax], " +
                "[emailfiscal], " +
                "[emailfinanceiro], " +
                "[emailvenda], " +
                "[emailvendasubst], " +
                "[cep], " +
                "[endereco], " +
                "[numero], " +
                "[complemento], " +
                "[bairro], " +
                "[municipio], " +
                "[uf], " +
                "[pais], " +
                "[cnpj], " +
                "[aniversario], " +
                "[ultimomov], " +
                "[ultimacompra], " +
                "[ultimaatualizacao], " +
                "[ativo], " +
                "[datacadastro], " +
                "[tipofrete], " +
                "[percentualfrete], " +
                "[valorfixofrete], " +
                "[condicoespagto_id_cond_pagto], " +
                "[vendedor], " +
                "[vendedorsubst], " +
                "[subst] " +

                "from empresa;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }

        // select por fantasia
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select " +

                "[codigocigam], " +
                "[nomecompleto], " +
                "[fantasia], " +
                "[tipopessoa], " +
                "[fonevendas], " +
                "[fonecontabil], " +
                "[fonefiscal], " +
                "[fonefax], " +
                "[emailfiscal], " +
                "[emailfinanceiro], " +
                "[emailvenda], " +
                "[emailvendasubst], " +
                "[cep], " +
                "[endereco], " +
                "[numero], " +
                "[complemento], " +
                "[bairro], " +
                "[municipio], " +
                "[uf], " +
                "[pais], " +
                "[cnpj], " +
                "[aniversario], " +
                "[ultimomov], " +
                "[ultimacompra], " +
                "[ultimaatualizacao], " +
                "[ativo], " +
                "[datacadastro], " +
                "[tipofrete], " +
                "[percentualfrete], " +
                "[valorfixofrete], " +
                "[condicoespagto_id_cond_pagto], " +
                "[vendedor], " +
                "[vendedorsubst], " +
                "[subst] " +

                "from empresa where fantasia like '%" + valor + "%';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(String valor, String cnpj)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_empresa, FORMAT(codigocigam, '000000')as CodigoCigam, nomecompleto, fantasia, (SUBSTRING(cnpj ,1 , 2) + '.' + SUBSTRING(cnpj ,3 , 3) + '.' + SUBSTRING(cnpj , 6, 3) + '/' + SUBSTRING(cnpj ,9 , 4) + '-' + SUBSTRING(cnpj ,13 , 2))as CNPJ from empresa where " +
                "(fantasia like '%" + valor + "%' or nomecompleto like '%" + valor + "%') and cnpj like '%" + cnpj + "%' ;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOEmpresas CarregaModelo(int codigo)
        {
            DTOEmpresas modelo = new DTOEmpresas();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_empresa, codigocigam, nomecompleto, fantasia, tipopessoa, fonevendas, fonecontabil, fonefiscal, fonefax, emailfiscal, emailfinanceiro, emailvenda, emailvendasubst, cep, endereco, numero, complemento, bairro, municipio, uf, pais, cnpj, aniversario, ultimomov, ultimacompra, ultimaatualizacao, ativo, datacadastro, tipofrete, percentualfrete, valorfixofrete, id_cond_pagto, vendedor, vendedorsubst, subst from empresa where id_empresa = {codigo};"
            };
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_empresa = Convert.ToInt32(registro["id_empresa"]);
                modelo.CodigoCIGAM = Convert.ToInt32(registro["codigocigam"]);
                modelo.NomeCompleto = Convert.ToString(registro["nomecompleto"]);
                modelo.Fantasia = Convert.ToString(registro["fantasia"]);
                modelo.TipoPessoa = Convert.ToString(registro["tipopessoa"]);
                modelo.FoneVendas = Convert.ToString(registro["foneVendas"]);
                modelo.FoneContabil = Convert.ToString(registro["foneContabil"]);
                modelo.FoneFiscal = Convert.ToString(registro["fonefiscal"]);
                modelo.EmailFinanceiro = Convert.ToString(registro["emailfinanceiro"]);
                modelo.FoneFax = Convert.ToString(registro["fonefax"]);
                modelo.EmailVenda = Convert.ToString(registro["emailvenda"]);
                modelo.EmailVendaSubst = Convert.ToString(registro["emailvendasubst"]);
                modelo.Cep = Convert.ToString(registro["cep"]);
                modelo.Endereco = Convert.ToString(registro["endereco"]);
                modelo.Numero = Convert.ToString(registro["numero"]);
                modelo.Complemento = Convert.ToString(registro["complemento"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Municipio = Convert.ToString(registro["municipio"]);
                modelo.Uf = Convert.ToString(registro["uf"]);
                modelo.Pais = Convert.ToString(registro["pais"]);
                modelo.Cnpj = Convert.ToString(registro["cnpj"]);
                modelo.Aniversario = Convert.ToDateTime(registro["aniversario"]);
                modelo.UltimoMov = Convert.ToDateTime(registro["ultimomov"]);
                modelo.UltimaCompra = Convert.ToDateTime(registro["ultimacompra"]);
                modelo.UltimaAtualizacao = Convert.ToDateTime(registro["ultimaatualizacao"]);
                modelo.Ativo = Convert.ToBoolean(registro["ativo"]);
                modelo.DataCadastro = Convert.ToDateTime(registro["datacadastro"]);
                modelo.TipoFrete = Convert.ToInt32(registro["tipofrete"]);
                modelo.PercentualFrete = Convert.ToDouble(registro["percentualfrete"]);
                modelo.ValorFixoFrete = Convert.ToDouble(registro["valorfixofrete"]);

            }

            conexao.Desconectar();
            return modelo;

        }

        internal bool ExisteEmpresa(int id)
        {
            bool result = false;

            DTOEmpresas modelo = new DTOEmpresas();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_empresa from empresa where id_empresa = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                result = true;
            }

            conexao.Desconectar();

            return result;
        }
    }

    public class DALUnidades
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALUnidades(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOUnidade modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into unidade (email, fone, ativo, estoquista, obsemailunidade, idEmpresa, nomeReduzido) " +
                              "values (@email, @fone, @ativo, @estoquista, @obs, @idEmpresa, @reduzido); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@fone", modelo.Fone);
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);
            cmd.Parameters.AddWithValue("@estoquista", modelo.Estoquista);
            cmd.Parameters.AddWithValue("@obs", modelo.ObsEmailUnidade);
            cmd.Parameters.AddWithValue("@idEmpresa", modelo.IdEmpresa);
            cmd.Parameters.AddWithValue("@nomeReduzido", modelo.NomeReduzido);

            conexao.Conectar();
            modelo.Id_unidade = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }

        public void Alterar(DTOUnidade modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update unidade set email = (@email), fone = (@fone, ativo = (@ativo), estoquista = (@estoquista), obsemailunidade = (@obs), idEmpresa = (@idEmpresa), nomeReduzido = (@reduzido) where id_unidade = (@id_unidade);"
            };

            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@fone", modelo.Fone);
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);
            cmd.Parameters.AddWithValue("@estoquista", modelo.Estoquista);
            cmd.Parameters.AddWithValue("@obs", modelo.ObsEmailUnidade);
            cmd.Parameters.AddWithValue("@idEmpresa", modelo.IdEmpresa);
            cmd.Parameters.AddWithValue("@id_unidade", modelo.Id_unidade);
            cmd.Parameters.AddWithValue("@reduzido", modelo.NomeReduzido);


            conexao.Conectar();
            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"delete from unidade where id_unidade = {id};"
            };

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DTOUnidade CarregaModelo()
        {
            DTOUnidade modelo = new DTOUnidade();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select id_unidade, email, fone, ativo, estoquista, obsemailunidade, idEmpresa, nomeReduzido from unidade;"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_unidade = Convert.ToInt32(registro["id_unidade"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Fone = Convert.ToString(registro["fone"]);
                modelo.Ativo = Convert.ToBoolean(registro["ativo"]);
                modelo.Estoquista = Convert.ToString(registro["estoquista"]);
                modelo.ObsEmailUnidade = Convert.ToString(registro["obsemailunidade"]);
                modelo.IdEmpresa = Convert.ToInt32(registro["idEmpresa"]);
            }

            conexao.Desconectar();

            return modelo;
        }

        public DTOUnidade CarregaModelo(int id)
        {
            DTOUnidade modelo = new DTOUnidade();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_unidade, email, fone, ativo, estoquista, obsemailunidade, idEmpresa, nomeReduzido from unidade where id_unidade = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_unidade = Convert.ToInt32(registro["id_unidade"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Fone = Convert.ToString(registro["fone"]);
                modelo.Ativo = Convert.ToBoolean(registro["ativo"]);
                modelo.Estoquista = Convert.ToString(registro["estoquista"]);
                modelo.ObsEmailUnidade = Convert.ToString(registro["obsemailunidade"]);
                modelo.IdEmpresa = Convert.ToInt32(registro["idEmpresa"]);
                modelo.NomeReduzido = Convert.ToString(registro["nomeReduzido"]);
            }

            conexao.Desconectar();

            return modelo;
        }

        public string RetornaNomeUnidade(int id)
        {
            String unidade = "";

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select nomeReduzido from unidade where id_unidade = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                
                unidade = Convert.ToString(registro["nomeReduzido"]);
            }

            conexao.Desconectar();

            return unidade;
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_unidade, email, fone, ativo, estoquista, obsemailunidade, idEmpresa, nomeReduzido, codigo_unidade from unidade", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }


    }

    public class DALMarcasAprovadas
    {
        

    }

    public class DALSubgrupos
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALSubgrupos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOSubgrupo modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into subgrupo (nome) " +
                              "values (@nome); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@nome", modelo.Nome);

            conexao.Conectar();
            modelo.Id_subgrupo = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();

        }

        public void Alterar(DTOSubgrupo modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update subgrupo set nome = (@nome) WHERE id_subgrupo = (@id);"
            };

            cmd.Parameters.AddWithValue("@id", modelo.Id_subgrupo);
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from subgrupo where id_subgrupo = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_subgrupo, nome from subgrupo order by nome asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOSubgrupo Carregar(int id)
        {
            DTOSubgrupo modelo = new DTOSubgrupo();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_subgrupo, nome from subgrupo where id_subgrupo = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_subgrupo = Convert.ToInt32(registro["id_subgrupo"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
            }

            conexao.Desconectar();

            return modelo;

        }

    }

    public class DALBackupDataBase
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALBackupDataBase(DALConexao cx)
        {
            this.conexao = cx;
        }
                
        public void RestauraDB(string NomeDB, string arquivo)
        {
            SqlConnection.ClearAllPools();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = " USE master; "+
                                
                                $" RESTORE DATABASE [{NomeDB}] FROM DISK = '{arquivo}'  WITH REPLACE"
            };

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

    }

    #region FichasTécnicas
    
    public class DALPratos
    {
        private DALConexao conexao;

        public DALPratos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOPratos modelo, string foto = "")
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "EXECUTE CriaPrato @nome, @setor, @cat, @subcat, @rendimento, @preparo, @peso, @desc, @usuario, @cod, @pax;"
            };

            cmd.Parameters.AddWithValue("@nome", modelo.NomePrato);
            cmd.Parameters.AddWithValue("@setor", modelo.IdSetor);
            cmd.Parameters.AddWithValue("@cat", modelo.Cat);
            cmd.Parameters.AddWithValue("@subcat", modelo.SubCat);
            cmd.Parameters.AddWithValue("@rendimento", modelo.RendimentoPrato);
            cmd.Parameters.AddWithValue("@preparo", modelo.ModoPreparoPrato);
            cmd.Parameters.AddWithValue("@peso", modelo.PesoPrato);
            cmd.Parameters.AddWithValue("@usuario", modelo.IdUsuario);
            cmd.Parameters.AddWithValue("@desc", modelo.DescPrato);
            cmd.Parameters.AddWithValue("@cod", modelo.CodPrato);
            cmd.Parameters.AddWithValue("@pax", modelo.PessoasAtendidas);

            conexao.Conectar();
            modelo.IdPrato = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();


            DTOCaminhos dto = new DTOCaminhos();

            string folder = dto.FT;

            if (foto != "")
            {
                try
                {
                    var path = Path.Combine(folder, Path.GetFileName(foto));

                    if (!Directory.Exists(folder))

                    {
                        Directory.CreateDirectory(folder);

                        File.Copy(foto, folder + modelo.CodPrato.ToString() + Path.GetExtension(foto));
                    }
                    else
                    {
                        if (File.Exists(folder + modelo.CodPrato.ToString() + Path.GetExtension(foto)))
                        {
                            File.Delete(folder + modelo.CodPrato.ToString() + Path.GetExtension(foto));
                        }

                        File.Copy(foto, folder + modelo.CodPrato.ToString() + Path.GetExtension(foto));
                    }
                }
                catch { }
            }

        }

        public void AddModPreparo(DTOPratos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update prato set modo_preparo_prato = (@preparo), desc_prato = (@desc) WHERE id_prato = (@id);"
            };
            cmd.Parameters.AddWithValue("@preparo", modelo.ModoPreparoPrato);
            cmd.Parameters.AddWithValue("@desc", modelo.DescPrato);
            cmd.Parameters.AddWithValue("@id", modelo.IdPrato);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Alterar(DTOPratos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "EXECUTE AlterarPrato @nome, @setor, @cat, @subcat, @rendimento, @preparo, @peso, @desc, @usuario, @cod, @pax, @ativo;"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomePrato);
            cmd.Parameters.AddWithValue("@setor", modelo.IdSetor);
            cmd.Parameters.AddWithValue("@cat", modelo.Cat);
            cmd.Parameters.AddWithValue("@subcat", modelo.SubCat);
            cmd.Parameters.AddWithValue("@rendimento", modelo.RendimentoPrato);
            cmd.Parameters.AddWithValue("@preparo", modelo.ModoPreparoPrato);
            cmd.Parameters.AddWithValue("@peso", modelo.PesoPrato);
            cmd.Parameters.AddWithValue("@desc", modelo.DescPrato);
            cmd.Parameters.AddWithValue("@usuario", modelo.IdUsuario);
            cmd.Parameters.AddWithValue("@cod", modelo.CodPrato);
            cmd.Parameters.AddWithValue("@pax", modelo.PessoasAtendidas);
            cmd.Parameters.AddWithValue("@ativo", modelo.Ativo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            
        }

        public void Excluir(string codigo)
        {

            if (quantIngredientes(codigo) > 0)
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "EXECUTE InativaPrato @cod;"
                };
                cmd.Parameters.AddWithValue("@cod", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            else
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "EXECUTE DeletaPrato @cod;"
                };
                cmd.Parameters.AddWithValue("@cod", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
        }

        int quantIngredientes(string cod)
        {
            int quant = 1;

            conexao.Conectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select count(cod_item) as quantidade from ingredientes where cod_item = '{cod}';"
            };


            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                quant = Convert.ToInt32(registro["quantidade"]);
            }

            conexao.Desconectar();

            return quant;

        }

        public DataTable LocalizarNome(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select cod_prato from prato where nome_prato = '{valor}';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarNome2(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_prato, nome_prato, id_setor, cat, subcat, rendimento_prato, modo_preparo_prato, peso_prato, pessoasAtendidas from prato where nome_prato like '%{valor}%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCod(String cod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_prato, nome_prato, id_setor, cat, subcat, rendimento_prato, modo_preparo_prato, peso_prato, desc_prato, id_usuario, pessoasAtendidas, ativo from prato where cod_prato = '{cod}';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable ListaCodigos()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select cod_prato from prato order by cod_prato;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable BuscaFichas(string busca)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"{busca};", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable ListarIngredientes(string codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select cod_item, quant_ingrediente from ingredientes where cod_prato = '{codigo}';", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable CustoIngrediente(string codigo, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select top 1 valor_unitario_custo from custo where id_unidade = {unidade} and cod_item_custo = '{codigo}' order by movimento_custo desc;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOPratos CarregaModelo(string codigo)
        {
            DTOPratos modelo = new DTOPratos();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_prato, nome_prato, id_setor, cat, subcat, rendimento_prato, modo_preparo_prato, peso_prato, desc_prato, id_usuario, pessoasAtendidas from prato where cod_prato = '{codigo}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdPrato = Convert.ToInt32(registro["id_prato"]);
                modelo.NomePrato = Convert.ToString(registro["nome_prato"]);
                modelo.IdSetor = Convert.ToInt32(registro["id_setor"]);
                modelo.Cat = Convert.ToInt32(registro["cat"]);
                modelo.SubCat = Convert.ToInt32(registro["subcat"]);
                modelo.RendimentoPrato = Convert.ToDouble(registro["rendimento_prato"]);
                modelo.PesoPrato = Convert.ToDouble(registro["peso_prato"]);
                modelo.ModoPreparoPrato = Convert.ToString(registro["modo_preparo_prato"]);
                modelo.DescPrato = Convert.ToString(registro["desc_prato"]);
                modelo.IdUsuario = Convert.ToInt32(registro["id_usuario"]);
                modelo.PessoasAtendidas = Convert.ToInt32(registro["pessoasAtendidas"]);
            }

            conexao.Desconectar();

            return modelo;
        }

    }

    public class DALIngredientes
    {
        private DALConexao conexao;

        public DALIngredientes(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOIngredientes modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into ingredientes(cod_item, cod_prato, quant_ingrediente) values " +
                "(@item, @prato, @quant); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@item", modelo.CodItem);
            cmd.Parameters.AddWithValue("@prato", modelo.CodPrato);
            cmd.Parameters.AddWithValue("@quant", modelo.QuantIngrediente);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(DTOIngredientes modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update ingredientes set cod_item = (@item), cod_prato = (@prato)," +
                "quant_ingrediente = (@quant) WHERE id_ingrediente = (@id);"
            };
            cmd.Parameters.AddWithValue("@item", modelo.CodItem);
            cmd.Parameters.AddWithValue("@prato", modelo.CodPrato);
            cmd.Parameters.AddWithValue("@quant", modelo.QuantIngrediente);
            cmd.Parameters.AddWithValue("@id", modelo.IdIngrediente);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void ExcluirPorPrato(string codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from ingredientes where cod_prato = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from ingredientes where id_ingrediente = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable CustoItem01(string cod, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT TOP 1 id_custo, valor_unitario_custo FROM custo where cod_item_custo = '{cod}' and id_unidade = {unidade} and valor_unitario_custo > 0 ORDER BY id_custo DESC; ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable CustoItemGeral(string cod, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT TOP 1 id_custo, valor_unitario_custo FROM custo where cod_item_custo = '{cod}' " +
                $"and id_unidade = {unidade} ORDER BY id_custo DESC; ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

    }

    public class DALBuffet
    {
        private DALConexao conexao;

        public DALBuffet(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOBuffet modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into buffet(nome_buffet) values " +
                "(@nome); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomeBuffet);

            conexao.Conectar();
            modelo.IdBuffet = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(DTOBuffet modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update buffet set nome_bffet = (@nome) WHERE id_bufet = (@id);"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomeBuffet);
            cmd.Parameters.AddWithValue("@id", modelo.IdBuffet);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from buffet where id_buffet = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_buffet, nome_buffet from buffet;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorId(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select nome_buffet from buffet where id_buffet = {id};", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        private int RetornaIdDoNome(string Nome)
        {
            int id = 0;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_buffet, nome_buffet from buffet where nome_buffet = '{Nome}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                id = Convert.ToInt32(registro["id_buffet"]);
            }

            conexao.Desconectar();

            return id;
        }

        public int CadastrarSeNaoExiste(string Nome)
        {
            int id = 0;

            DALBuffet DALLobj = new DALBuffet(conexao);

            id = DALLobj.RetornaIdDoNome(Nome);

            if (id == 0)
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "insert into buffet(nome_buffet) values " +
                    "(@nome); select @@IDENTITY;"
                };
                cmd.Parameters.AddWithValue("@nome", Nome);

                conexao.Conectar();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }            

            return id;
        }
    }

    public class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into categoria(nome_cat) values (@nome); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCat);

            conexao.Conectar();
            modelo.IdCat = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(DTOCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update categoria set nome_cat = (@nome) WHERE id_cat = (@id);"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCat);
            cmd.Parameters.AddWithValue("@id", modelo.IdCat);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from categoria where id_cat = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarPorId(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select nome_cat from categoria where id_cat = {id};", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_cat, nome_cat from categoria;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        private int RetornaIdDoNome(string Nome)
        {
            int id = 0;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_cat, nome_cat from categoria where nome_cat = '{Nome}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                id = Convert.ToInt32(registro["id_cat"]);
            }

            conexao.Desconectar();

            return id;
        }

        public int CadastrarSeNaoExiste(string Nome)
        {
            int id = 0;

            DALCategoria DALLobj = new DALCategoria(conexao);

            id = DALLobj.RetornaIdDoNome(Nome);

            if (id == 0)
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "insert into categoria (nome_cat) values " +
                    "(@nome); select @@IDENTITY;"
                };
                cmd.Parameters.AddWithValue("@nome", Nome);

                conexao.Conectar();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }

            return id;
        }

    }

    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOSubCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into subcategoria(nome_scat) values (@nome); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomeSCat);

            conexao.Conectar();
            modelo.IdSCat = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(DTOSubCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update subcategoria set nome_scat = (@nome) WHERE id_scat = (@id);"
            };
            cmd.Parameters.AddWithValue("@nome", modelo.NomeSCat);
            cmd.Parameters.AddWithValue("@desc", modelo.DescSCat);
            cmd.Parameters.AddWithValue("@id", modelo.IdSCat);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from subcategoria where id_scat = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable LocalizarPorId(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select nome_scat from subcategoria where id_scat = {id};", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id_scat, nome_scat from subcategoria;", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        private int RetornaIdDoNome(string Nome)
        {
            int id = 0;
                        
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_scat, nome_scat from subcategoria where nome_scat = '{Nome}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                id = Convert.ToInt32(registro["id_scat"]);
            }

            conexao.Desconectar();

            return id;
        }

        public int CadastrarSeNaoExiste(string Nome)
        {
            int id = 0;

            DALSubCategoria DALLobj = new DALSubCategoria(conexao);

            id = DALLobj.RetornaIdDoNome(Nome);

            if (id == 0)
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "insert into subcategoria (nome_scat) values " +
                    "(@nome); select @@IDENTITY;"
                };
                cmd.Parameters.AddWithValue("@nome", Nome);

                conexao.Conectar();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }

            return id;
        }

    }

    public class DALCusto
    {

        private DALConexao conexao;

        public DALCusto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void IncluirCusto(DTOCusto modelo)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into custo (data_custo, cod_item_custo, tipo_mov_custo, quant_mov_custo, valor_unitario_custo, " +
                "tipo_operacao_custo, conta_gerencial_custo, tipo_doc_custo, documento_custo, movimento_custo, id_unidade, id_usuario, grupo) " +
                "values (@data, @cod, @tipo, @quant, @valor, @operacao, @conta, @tipodoc, @doc, @movimento, @unidade, @usuario, @grupo " +
                "); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@data", modelo.DataCusto);
            cmd.Parameters.AddWithValue("@cod", modelo.CodItemCusto);
            cmd.Parameters.AddWithValue("@tipo", modelo.TipoMovCusto);
            cmd.Parameters.AddWithValue("@quant", modelo.QuantMovCusto);
            cmd.Parameters.AddWithValue("@valor", modelo.ValorUnitarioCusto);
            cmd.Parameters.AddWithValue("@operacao", modelo.TipoOperacaoCusto);
            cmd.Parameters.AddWithValue("@conta", modelo.ContaGerencialCusto);
            cmd.Parameters.AddWithValue("@tipodoc", modelo.TipoDocCusto);
            cmd.Parameters.AddWithValue("@doc", modelo.DocumentoCusto);
            cmd.Parameters.AddWithValue("@movimento", modelo.MovimentoCusto);
            cmd.Parameters.AddWithValue("@unidade", modelo.IdUnidade);
            cmd.Parameters.AddWithValue("@usuario", modelo.IdUsuario);
            cmd.Parameters.AddWithValue("@grupo", modelo.Grupo);

            conexao.Conectar();
            modelo.IdCusto = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void ExcluirCusto(DateTime datai, DateTime dataf, int unidade)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from custo where data_custo >= @datai and data_custo <= @dataf and id_unidade = @unidade;"
            };
            cmd.Parameters.AddWithValue("@datai", datai.ToString("d"));
            cmd.Parameters.AddWithValue("@dataf", dataf.ToString("d"));
            cmd.Parameters.AddWithValue("@unidade", unidade);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void ExcluirCusto(DateTime data, int unidade)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from custo where data_custo = @data and id_unidade = @unidade;"
            };
            cmd.Parameters.AddWithValue("@data", data.ToString("d"));           
            cmd.Parameters.AddWithValue("@unidade", unidade);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable LocalizarCusto(DateTime data, int unidade)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT sum(valor_venda) as total FROM venda where data_venda = " + data.ToString("d") + " and id_unidade = " + unidade, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }
        
    }

    public class DALCustoPratos
    {
        private DALConexao conexao;

        public void AtualizarCusto(string codPrato, int idUnidade)
        {
            FichasTecnicas ft = new FichasTecnicas();

            double valorTotal = ft.CalculaCustoFicha(codPrato, idUnidade);

            if (ExisteCusto(codPrato, idUnidade))
            {
                Alterar(codPrato, idUnidade, valorTotal);
            }
            else
            {
                Incluir(codPrato, idUnidade, valorTotal);
            }
        }

        public DALCustoPratos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOCustoPratos modelo)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into custosPratos (codigocigam, id_unidade, valorTotal, dataAtualizacao) " +
                "values (@prato, @unidade, @valor, @data); select @@IDENTITY;"
            };
            cmd.Parameters.AddWithValue("@prato", modelo.CodigoCigam);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);
            cmd.Parameters.AddWithValue("@valor", modelo.ValorTotal);
            cmd.Parameters.AddWithValue("@data", modelo.DataAtualizacao);            

            conexao.Conectar();
            modelo.Id_custoPratos = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void Incluir(string codPrato, int idUnidade, double valor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "insert into custosPratos (codigocigam, id_unidade, valorTotal, dataAtualizacao) " +
                    "values (@prato, @unidade, @valor, @data); select @@IDENTITY;"
                };
                cmd.Parameters.AddWithValue("@prato", codPrato);
                cmd.Parameters.AddWithValue("@unidade", idUnidade);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
            conexao.Desconectar();
            }

        }

        public void ExcluirCustoPrato(int id)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from custosPratos where id_prato = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id);
            
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void ExcluirCustoPratoPorCod(string cod)
        {
            conexao.Desconectar();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from custosPratos where codigocigam = @codigo;"
            };
            cmd.Parameters.AddWithValue("@codigo", cod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Alterar(string codPrato, int idUnidade, double valor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "update custosPratos set valorTotal = (@valor), dataAtualizacao = (@data) WHERE codigocigam = (@prato) and id_unidade = (@unidade);"
                };
                cmd.Parameters.AddWithValue("@prato", codPrato);
                cmd.Parameters.AddWithValue("@unidade", idUnidade);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public double RetornarCustoPrato(string prato, int unidade)
        {
            DTOCustoPratos dto = new DTOCustoPratos();

            double custo = 0;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select valorTotal from custosPratos where id_unidade = {unidade} and codigocigam = {prato};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                custo = Convert.ToInt32(registro["valorTotal"]);               
            }

            conexao.Desconectar();

            return custo;

        }

        public bool ExisteCusto(string prato, int unidade)
        {
            bool existe = false;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select valorTotal from custosPratos where id_unidade = {unidade} and codigocigam = '{prato}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                existe = true;
            }

            conexao.Desconectar();

            return existe;

        }
    }

    #endregion

    public class DALUnidademedida
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALUnidademedida(DALConexao cx)
        {
            this.conexao = cx;            
        }

        public void Incluir(DTOUnidadeMedida modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into unidadeMedida (um, descricao) " +
                              "values (@um, @desc); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@um", modelo.Um);
            cmd.Parameters.AddWithValue("@desc", modelo.Desc);

            conexao.Conectar();
            modelo.Id_um = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }

        public int Incluir(string um)
        {
            int idCadastrado = 0;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into unidadeMedida (um, descricao) " +
                              $"values ('{um}', ''); select @@IDENTITY;"
            };

            conexao.Conectar();
            idCadastrado = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return idCadastrado;
        }


        public void Alterar(DTOUnidadeMedida modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update subgrupo set um = (@um), descricao = (@desc) WHERE id_um = (@id);"
            };

            cmd.Parameters.AddWithValue("@id", modelo.Id_um);
            cmd.Parameters.AddWithValue("@um", modelo.Um);
            cmd.Parameters.AddWithValue("@desc", modelo.Desc);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from unidadeMedida where id_um = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id_um, um, descricao from unidadeMedida order by um asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOUnidadeMedida Carregar(int id)
        {
            DTOUnidadeMedida modelo = new DTOUnidadeMedida();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_um, um, descricao from unidadeMedida where id_um = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_um = Convert.ToInt32(registro["id_um"]);
                modelo.Um = Convert.ToString(registro["um"]);
                modelo.Desc = Convert.ToString(registro["descricao"]);
            }

            conexao.Desconectar();

            return modelo;

        }

        public bool ExisteUm(string buscaUm)
        {
            bool existeRegistro = false;

            DTOUnidadeMedida modelo = new DTOUnidadeMedida();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id_um, um, descricao from unidadeMedida where um = '{buscaUm}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                existeRegistro = true;
            }

            conexao.Desconectar();

            return existeRegistro;

        }


    }

    public class DALSetores
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALSetores(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOSetores modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into setores (nome, obs, id_usuario) " +
                              "values (@nome, @obs, @usuario); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_ususario);
            
            conexao.Conectar();
            modelo.Id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }
        
        public void Alterar(DTOSetores modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update setores set nome = (@nome), obs = (@obs), id_usuario = (@usuario) WHERE id = (@id);"
            };

            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_ususario);
            cmd.Parameters.AddWithValue("@id", modelo.Id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from setores where id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, nome, obs, id_usuario from setores order by nome asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOSetores Carregar(int id)
        {
            DTOSetores modelo = new DTOSetores();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id, nome, obs, id_usuario from setores where id = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Obs = Convert.ToString(registro["obs"]);
                modelo.Id_ususario = Convert.ToInt32(registro["id_usuario"]);
            }

            conexao.Desconectar();

            return modelo;

        }

        public string NomeSetor(int id)
        {
            string nome = "";

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select nome from setores where id = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                
                nome = Convert.ToString(registro["nome"]);
                
            }

            conexao.Desconectar();

            return nome;

        }


        public bool ExisteSetor(string setor)
        {
            bool existeRegistro = false;

            DTOSetores modelo = new DTOSetores();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id, nome, obs from setores where nome = '{setor}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                existeRegistro = true;
            }

            conexao.Desconectar();

            return existeRegistro;

        }

        
    }

    public class DALPedidos
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALPedidos(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOPedidos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into pedidos (data, data_entrega, id_unidade, id_usuario, obs, status) " +
                              "values (@data, @data_entrega, @unidade, @usuario, @obs, @status); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@data", modelo.Data_criacao);
            cmd.Parameters.AddWithValue("@data_entrega", modelo.Data_entrega);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_ususario);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@status", modelo.Status);

            conexao.Conectar();
            modelo.Id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }

        public void Alterar(DTOPedidos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update pedidos set data = (@data), data_entrega = (@entrega), id_usuario = (@usuario), id_unidade = (@unidade), obs = (@obs) WHERE id = (@id);"
            };

            cmd.Parameters.AddWithValue("@data", modelo.Data_criacao);
            cmd.Parameters.AddWithValue("@entrega", modelo.Data_entrega);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_ususario);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@id", modelo.Id);


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from pedidos where id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, data, data_entrega, id_usuario, id_unidade, obs, status from pedidos order by data asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Listar(string A, string S, string C)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select p.id, p.data, p.data_entrega, p.id_unidade, u.usuario, p.obs, p.status from pedidos p  join usuarios u on p.id_usuario = u.id_usuario where status like '%{A}%' or status like '%{S}%' or status like '%{C}%' order by data asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Listar(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id, data, data_entrega, id_usuario, id_unidade, obs, status from pedidos where id = {id} order by data asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOPedidos Carregar(int id)
        {
            DTOPedidos modelo = new DTOPedidos();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id, data, data_entrega, id_usuario, id_unidade, obs, status from pedidos where id = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id = Convert.ToInt32(registro["id"]);
                modelo.Data_criacao = Convert.ToDateTime(registro["data"]);
                modelo.Data_entrega = Convert.ToDateTime(registro["data_entrega"]);
                modelo.Obs = Convert.ToString(registro["obs"]);
                modelo.Id_ususario = Convert.ToInt32(registro["id_usuario"]);
                modelo.Id_unidade = Convert.ToInt32(registro["id_unidade"]);
            }

            conexao.Desconectar();

            return modelo;

        }


    }

    public class DALItensPedido
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALItensPedido(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOItensPedido modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into itens_pedido (cod_item, id_um, quant, obs, id_usuario, id_setor, obs_setor, solicitado, id_pedido) " +
                              "values (@item, @um, @quant, @obs, @usuario, @setor, @obsSetor, @solicitado, @pedido); select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@item", modelo.Cod_item);
            cmd.Parameters.AddWithValue("@um", modelo.Id_um);
            cmd.Parameters.AddWithValue("@quant", modelo.Quant);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_usuario);
            cmd.Parameters.AddWithValue("@setor", modelo.Id_setor);
            cmd.Parameters.AddWithValue("@obsSetor", modelo.Obs_setor);
            cmd.Parameters.AddWithValue("@solicitado", modelo.Solicitado);
            cmd.Parameters.AddWithValue("@pedido", modelo.Id_pedido);

            conexao.Conectar();
            modelo.Id_item_pedido = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }

        public void Alterar(DTOItensPedido modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update itens_pedido set cod_item = (@item), id_um = (@um), quant = (@quant), obs = (@obs), id_usuario = (@usuario), id_setor = (@setor), obs_setor = (@obsSetor), solicitado = (@solicitado), id_pedido = (@pedido)  WHERE id = (@id);"
            };

            cmd.Parameters.AddWithValue("@item", modelo.Cod_item);
            cmd.Parameters.AddWithValue("@um", modelo.Id_um);
            cmd.Parameters.AddWithValue("@quant", modelo.Quant);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_usuario);
            cmd.Parameters.AddWithValue("@setor", modelo.Id_setor);
            cmd.Parameters.AddWithValue("@obsSetor", modelo.Obs_setor);
            cmd.Parameters.AddWithValue("@solicitado", modelo.Solicitado);
            cmd.Parameters.AddWithValue("@pedido", modelo.Id_pedido);
            cmd.Parameters.AddWithValue("@id", modelo.Id_item_pedido);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from itens_pedido where id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int id, string obs, int pedido)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from itens_pedido where id_setor = @id and obs_setor = @obs and id_pedido = @pedido;"
            };
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@obs", obs);
            cmd.Parameters.AddWithValue("@pedido", pedido);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }


        //TODO Implementar os sistemas de consulta de acordo com a necessidade
        public DataTable Listar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, data, data_entrega, id_usuario, id_unidade from pedidos order by data asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable AgruparPedidosSetores(int id)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select i.id_setor, s.nome, i.obs_setor, count(i.id) from itens_pedido i  join setores s on i.id_setor = s.id  where id_pedido = {id}  group by i.id_setor, s.id, i.obs_setor, s.nome  order by s.nome asc; ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DTOItensPedido Carregar(int id)
        {
            DTOItensPedido modelo = new DTOItensPedido();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id, cod_item, id_um, quant, obs, id_usuario, id_setor, obs_setor, solicitado, id_pedido from itens_pedido where id = {id};"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.Id_item_pedido = Convert.ToInt32(registro["id"]);
                modelo.Cod_item = Convert.ToString(registro["cod_item"]);
                modelo.Id_um = Convert.ToInt32(registro["id_um"]);
                modelo.Quant = Convert.ToDouble(registro["quant"]);
                modelo.Obs = Convert.ToString(registro["obs"]);
                modelo.Id_usuario = Convert.ToInt32(registro["id_usuario"]);
                modelo.Id_setor = Convert.ToInt32(registro["id_setor"]);
                modelo.Obs_setor = Convert.ToString(registro["obs_setor"]);
                modelo.Solicitado = Convert.ToBoolean(registro["solicitado"]);
                modelo.Id_pedido = Convert.ToInt32(registro["id_pedido"]);                
            }

            conexao.Desconectar();

            return modelo;

        }

        internal DataTable ListarItensSetor(int id_setor, string obs)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select i.id, m.id_material, i.cod_item, m.descricao, i.id_um, u.um, i.quant, i.obs  from itens_pedido i " +
                "join materiais m on m.codigocigam = i.cod_item " +
                "join unidadeMedida u on u.id_um = i.id_um " +
                $"where id_setor = {id_setor} and obs_setor = '{obs}'; ", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }
    }

    public class DALCotacao
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALCotacao(DALConexao cx)
        {
            this.conexao = cx;
        }

        //Função que inclui uma cotação nova
        public void Incluir(DTOCotacao modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into cotacao (data, dataInicioVigencia, dataFimVigencia, idUsuario, idUnidade, idEmpresa) " +
                              "values (@data, @dataInicio, @dataFim, @usuario, @unidade, @empresa); " +
                              "select @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@data", modelo.Data_criacao);
            cmd.Parameters.AddWithValue("@dataInicio", modelo.DataInicioVigencia);
            cmd.Parameters.AddWithValue("@dataFim", modelo.DataFimVigencia);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_ususario);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);
            cmd.Parameters.AddWithValue("@empresa", modelo.IdEmpresa);

            conexao.Conectar();
            modelo.Id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }

        public void Alterar(DTOCotacao modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update cotacao set data = (@data), dataPedido = (@dataInicio), dataEntrega = (@dataFim), idUsuario = (@usuario), idUnidade = (@unidade), idEmpresa = (@empresa)  WHERE id = (@id);"
            };

            cmd.Parameters.AddWithValue("@data", modelo.Data_criacao);
            cmd.Parameters.AddWithValue("@dataInicio", modelo.DataInicioVigencia);
            cmd.Parameters.AddWithValue("@dataFim", modelo.DataFimVigencia);
            cmd.Parameters.AddWithValue("@usuario", modelo.Id_ususario);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);
            cmd.Parameters.AddWithValue("@empresa", modelo.IdEmpresa);
            cmd.Parameters.AddWithValue("@id", modelo.Id);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from cotacao where id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        //Função que verifica se existe o id da cotação informada.
        public bool ExisteCotacao(int id)
        {
            bool existeRegistro = false;

            DTOSetores modelo = new DTOSetores();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"select id from cotacao where id = '{id}';"
            };

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                existeRegistro = true;
            }

            conexao.Desconectar();

            return existeRegistro;
        }
    }

    public class DALItensCotacao
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALItensCotacao(DALConexao cx)
        {
            this.conexao = cx;
        }





    }

    public class DALLevantamento
    {
        //Instancia o objeto conexão
        private DALConexao conexao;

        //Conecta
        public DALLevantamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(DTOLevantamentos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "EXECUTE CriaLevantamento @usuario, @obs, @unidade;"
            };

            cmd.Parameters.AddWithValue("@usuario", modelo.IdUsuario);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);

            conexao.Conectar();
            modelo.Id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(DTOLevantamentos modelo)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "EXECUTE AlteraLevantamento @usuario, @status, @obs, @unidade;"
            };

            cmd.Parameters.AddWithValue("@usuario", modelo.IdUsuario);
            cmd.Parameters.AddWithValue("@status", modelo.Status);
            cmd.Parameters.AddWithValue("@obs", modelo.Obs);
            cmd.Parameters.AddWithValue("@unidade", modelo.Id_unidade);

            conexao.Conectar();
            modelo.Id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.ObjetoConexao,
                CommandText = $"delete from levantamentos where id = {id};"
            };

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
                
    }

}
