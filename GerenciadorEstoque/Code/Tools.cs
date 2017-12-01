using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GerenciadorEstoque.Code
{
    public class EnviaEmail
    {
        NetworkCredential login;
        SmtpClient cliente;
        MailMessage msg;

        public void EnviarEmailPara(DTOUsuarios usuarioLogado, string email, string cc, string assunto, string mensagem, bool resposta)
        {

            Formatar form = new Formatar();

            string usuario, senha, smtp, port;
            bool ssl;

            DTOConfigEmail dtoCE = new DTOConfigEmail();

            BLLConfigEmail bllCE = new BLLConfigEmail();

            dtoCE = bllCE.CarregaModelo();

            usuario = usuarioLogado.Email;
            senha = usuarioLogado.SenhaEmail;
            smtp = dtoCE.Smtp;
            port = dtoCE.Porta.ToString();
            ssl = dtoCE.Ssl;

            login = new NetworkCredential(usuario, senha);
            cliente = new SmtpClient(smtp)
            {
                Port = Convert.ToInt32(port),
                EnableSsl = ssl,
                Credentials = login
            };
            msg = new MailMessage { From = new MailAddress(usuario, form.PrimeirasLetrasMaiusculas(usuarioLogado.Nome, true), Encoding.UTF8) };
            msg.To.Add(new MailAddress(email));
            if (!string.IsNullOrEmpty(cc))
                msg.To.Add(new MailAddress(cc));
            msg.Subject = assunto;
            msg.Body = mensagem;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            if (resposta)
            {
                cliente.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            }

            string userstate = "Enviando...";
            cliente.SendAsync(msg, userstate);
        }

        public void EnviarEmailSUporte(DTOUsuarios usuarioLogado, string assunto, string mensagem)
        {

            Formatar form = new Formatar();

            string usuario, senha, smtp, port, texto;
            bool ssl;

            texto = mensagem + $"<p><b>Enviado por:</b> {usuarioLogado.Nome}<p><b>Email:</b> {usuarioLogado.Email}";

            DTOConfigEmail dtoCE = new DTOConfigEmail();

            BLLConfigEmail bllCE = new BLLConfigEmail();

            dtoCE = bllCE.CarregaModelo();

            usuario = "vagner.lenon@dadobier.com.br";
            senha = "shamboga2099";
            smtp = "email-ssl.com.br";
            port = "587";
            ssl = true;

            login = new NetworkCredential(usuario, senha);
            cliente = new SmtpClient(smtp)
            {
                Port = Convert.ToInt32(port),
                EnableSsl = ssl,
                Credentials = login
            };
            msg = new MailMessage { From = new MailAddress(usuario, form.PrimeirasLetrasMaiusculas(usuarioLogado.Nome, true), Encoding.UTF8) };
            msg.To.Add(new MailAddress("vagnerlenon+jzbkkhzf7oqjllrfvgep@boards.trello.com"));            
            msg.Subject = assunto;
            msg.Body = texto;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                       
            cliente.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            
            string userstate = "Enviando...";
            cliente.SendAsync(msg, userstate);
        }

        public void InfoEmail(string email, string cc, string assunto, string mensagem, bool resposta)
        {

            Formatar form = new Formatar();

            string usuario, senha, smtp, port;
            bool ssl;

            DTOConfigEmail dtoCE = new DTOConfigEmail();

            BLLConfigEmail bllCE = new BLLConfigEmail();

            dtoCE = bllCE.CarregaModelo();

            usuario = "vagner.lenon@dadobier.com.br";
            senha = "shamboga2099";
            smtp = dtoCE.Smtp;
            port = dtoCE.Porta.ToString();
            ssl = dtoCE.Ssl;

            login = new NetworkCredential(usuario, senha);
            cliente = new SmtpClient(smtp)
            {
                Port = Convert.ToInt32(port),
                EnableSsl = ssl,
                Credentials = login
            };
            msg = new MailMessage { From = new MailAddress(usuario, "Informação", Encoding.UTF8) };
            msg.To.Add(new MailAddress(email));
            if (!string.IsNullOrEmpty(cc))
                msg.To.Add(new MailAddress(cc));
            msg.Subject = assunto;
            msg.Body = mensagem;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            if (resposta)
            {
                cliente.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            }

            string userstate = "Enviando...";
            cliente.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mensagem enviada com sucesso!!\nEm breve entraremos em contato.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class RecuperaDadosMaquina
    {

        public string RecuperaNome()
        {

            string strHostName = Dns.GetHostName();

            string clientIPAddress = Dns.GetHostAddresses(strHostName).GetValue(1).ToString();

            return strHostName;
        }

        public string RecuperarIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Impossível localizar o ip local desta máquina.");
        }
    }

    public class Formatar
    {
        public string PrimeirasLetrasMaiusculas(string palavra, bool nomeProprio)
        {
            string resultado = "";

            palavra = palavra.Trim().ToUpper();

            string[] P = palavra.Split(' ');

            for (int i = 0; i < P.Length; i++)
            {
                if (nomeProprio)
                {
                    if (P[i] != "DA" && P[i] != "DO" && P[i] != "DE" && P[i] != "DAS" && P[i] != "DOS")
                    {
                        resultado += P[i].Substring(0, 1).ToUpper() + P[i].Substring(1, (P[i].Length - 1)).ToLower() + " ";
                    }
                    else
                    {
                        resultado += P[i].ToLower() + " ";
                    }
                }
                else
                {
                    resultado += P[i].Substring(0, 1).ToUpper() + P[i].Substring(1, (P[i].Length - 1)).ToLower() + " ";
                }
            }

            return resultado.Trim();

        }

        public string TrimToUpper(string s)
        {
            return s.Trim().ToUpper();
        }
    }
    
    public class Diversos
    {

        public enum LocaisPermissoes { Fichas, Pedidos, Cadastros, Usarios };

        public enum StatusOC { Aberta, Pendente, Recebida, Cancelada, Suspensa };

        public enum StatusPedido { Aberto, Solicitado, Cancelado };


    }

    public class FichasTecnicas
    {
        public double CustoIngrediente(string codigo, int unidade)
        {

            BLLPratos bll = new BLLPratos();
            DataTable ListaInsumos = new DataTable();
            DataTable Item = new DataTable();


            double CustoTotal = 0;

            //Se for Prato
            if (codigo.Substring(0, 2) == "20")
            {
                Item = bll.LocalizarPorCod(codigo);
                try
                {
                    CustoTotal += CalculaCustoFicha(codigo, unidade) / Convert.ToDouble(Item.Rows[0][7]); ;
                }
                catch
                {
                    CustoTotal += 0;
                }
            }

            //Se for ingrediente
            else
            {

                CustoTotal += UltimaBaixaItem(codigo, unidade);

            }

            return CustoTotal;
        }

        public double CalculaCustoFicha(string codigo, int unidade)
        {
            double CustoTotal = 0;
            string codItem = "";

            BLLPratos bll = new BLLPratos();

            DataTable tabela = new DataTable();
            DataTable tabela3 = new DataTable();

            tabela = bll.ListarIngredientes(codigo);

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                codItem = tabela.Rows[i][0].ToString();

                //Se for Prato
                if (codItem.Substring(0, 2) == "20")
                {
                    tabela3 = bll.LocalizarPorCod(codItem);
                    try
                    {
                        CustoTotal += ((CalculaCustoFicha(codItem, unidade) / Convert.ToDouble(tabela3.Rows[0][7])) * Convert.ToDouble(tabela.Rows[i][1].ToString()));
                    }
                    catch
                    {
                        CustoTotal += 0;
                    }

                }

                //Se for ingrediente
                else
                {
                    CustoTotal += (UltimaBaixaItem(codItem, unidade) * Convert.ToDouble(tabela.Rows[i][1].ToString()));

                }

            }

            return CustoTotal;
        }

        public void ExcluirPrato(string cod)
        {
            // Exclui prato
            BLLPratos bllp = new BLLPratos();
            try
            {
                bllp.Excluir(cod);
            }
            catch
            {
                throw new Exception("Erro ao excluir Prato!");
            }

            //Exclui ingredientes referentes ao prato
            BLLIngredientes blli = new BLLIngredientes();
            try
            {

                blli.ExcluirPorPrato(cod);
            }
            catch
            {
                throw new Exception("Erro ao excluir Ingrediente!");
            }

            //excluir prato da tabela AEB
            BLLMateriais bllaeb = new BLLMateriais();

            try
            {
                bllaeb.ExcluirPorCodigo(cod);
            }
            catch
            {
                throw new Exception("Erro ao excluir Aeb!");
            }

            //excluir custos da tabela custosPratos
            BLLCustoPrato bllcp = new BLLCustoPrato();

            try
            {
                bllcp.ExcluirCustoPratoPorCod(cod);
            }
            catch
            {
                throw new Exception("Erro ao excluir CustosPratos!");
            }

            //Exclui imagem referente ao prato (se houver)
            IncluiFoto(cod, "del");
        }

        public void IncluiFoto(String cod, string foto)
        {
            DTOCaminhos mc = new DTOCaminhos();

            if (foto != "")
            {
                if (foto == "del")
                {
                    if (File.Exists(mc.FT + cod + ".jpg"))
                    {
                        File.Delete(mc.FT + cod + ".jpg");
                    }
                }
                else
                {
                    try
                    {
                        var path = Path.Combine(mc.FT, Path.GetFileName(foto));

                        if (!Directory.Exists(mc.FT))

                        {
                            Directory.CreateDirectory(mc.FT);

                            File.Copy(foto, mc.FT + cod + Path.GetExtension(foto));
                        }
                        else
                        {
                            if (File.Exists(mc.FT + cod + Path.GetExtension(foto)))
                            {
                                File.Delete(mc.FT + cod + Path.GetExtension(foto));
                            }

                            File.Copy(foto, mc.FT + cod + Path.GetExtension(foto));
                        }
                    }
                    catch { }

                }

            }
        }

        private Double UltimaBaixaItem(string codigo, int unidade)
        {
            double custoMedio = 0;
            BLLIngredientes blli = new BLLIngredientes();
            DataTable tabela = new DataTable();

            tabela = blli.Custo01(codigo, unidade);
            try
            {
                custoMedio = Convert.ToDouble(tabela.Rows[0][1]);
            }
            catch
            {
                custoMedio = 0;
            }

            return custoMedio;

        }

        public void ParaPDF(bool img, string codigoP, string caminho, int unidade)
        {
            BLLPratos bllp = new BLLPratos();
            DataTable tabela = bllp.LocalizarPorCod(codigoP);

            DTOCaminhos dto = new DTOCaminhos();

            string nomePrato, codigo, desc, preparo, imagem, nome_cat, nome_setor, nome_scat;
            double rendimento, peso, total, totalKg, totalPorcao, custoPax;
            int id_setor, id_cat, id_subcat, atendePax;

            // Preenche dados da Ficha
            codigo = codigoP;
            nomePrato = tabela.Rows[0][1].ToString();
            desc = tabela.Rows[0][8].ToString();
            preparo = tabela.Rows[0][6].ToString();
            rendimento = Convert.ToDouble(tabela.Rows[0][5]);
            peso = Convert.ToDouble(tabela.Rows[0][7]);
            id_setor = Convert.ToInt32(tabela.Rows[0][2]);
            id_cat = Convert.ToInt32(tabela.Rows[0][3]);
            id_subcat = Convert.ToInt32(tabela.Rows[0][4]);
            atendePax = Convert.ToInt32(tabela.Rows[0][10]);
            imagem = "";
            nome_setor = "";
            nome_cat = "";
            nome_scat = "";
            total = CalculaCustoFicha(codigoP, unidade);
            totalKg = 0;
            totalPorcao = 0;
            custoPax = 0;


            if (peso > 0)
            {
                totalKg = total / peso;
            }

            if (Convert.ToDouble(atendePax) > 0)
            {
                custoPax = total / Convert.ToDouble(rendimento);
            }

            if (rendimento > 0)
            {
                totalPorcao = total / rendimento;
            }

            if (File.Exists(dto.FT + codigoP + ".jpg") && img)
            {
                imagem = (dto.FT + codigoP + ".jpg");
            }

            //Carrega setor, categoria e subcategoria

            BLLBuffet bllsetor = new BLLBuffet();
            DataTable tabelasetor = bllsetor.LocalizarPorId(id_setor);

            nome_setor = tabelasetor.Rows[0][0].ToString();

            BLLCategoria bllcat = new BLLCategoria();
            DataTable tabelacat = bllcat.LocalizarPorId(id_cat);

            if (tabelacat.Rows.Count > 0)
            {
                nome_cat = tabelacat.Rows[0][0].ToString();
            }


            BLLSubCategoria bllscat = new BLLSubCategoria();
            DataTable tabelascat = bllscat.LocalizarPorId(id_subcat);

            if (tabelascat.Rows.Count > 0)
            {
                nome_scat = tabelascat.Rows[0][0].ToString();
            }


            //Exportar para pdf

           Font Titulo = FontFactory.GetFont("Segoe UI Light", 15, BaseColor.BLACK);
           Font subtitulo = FontFactory.GetFont("Verdana", 8, 1, BaseColor.BLACK);
           Font texto = FontFactory.GetFont("Segoe UI", 8, BaseColor.BLACK);


            Document doc = new Document(PageSize.A4, 5, 5, 20, 20);

            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream($"{caminho}", FileMode.Create));
            doc.Open();

            float larguraTotal = 530;

            float largura1 = larguraTotal * 0.11f;
            float largura2 = larguraTotal * 0.06f;

            BaseColor CSTitulo = BaseColor.GRAY;
            BaseColor linhaAlternada0 = BaseColor.WHITE;
            BaseColor linhaAlternada1 = BaseColor.LIGHT_GRAY;


            PdfPTable table = new PdfPTable(10);

            table.DefaultCell.Phrase = new Phrase() { Font = texto };
            table.TotalWidth = larguraTotal;
            table.PaddingTop = 0;
            table.LockedWidth = true;
            float[] widths = new float[] { largura1, largura1, largura1, largura1, largura1, largura2, largura2, largura1, largura1, largura1 };
            table.SetWidths(widths);

            //Tidulo

            PdfPCell cell = new PdfPCell(new Phrase($"{nomePrato} ({codigoP}) ", new Font(Titulo)))
            {
                Colspan = 10,

                FixedHeight = 40f,
                HorizontalAlignment = 1, //0=esquerda, 1 = centro, 2=direita
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(cell);


            float altura = 15f;

            //Setor TITULO
            PdfPCell tsetor = new PdfPCell(new Phrase("SETOR", new Font(subtitulo)))
            {
                Colspan = 2,

                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tsetor);

            //Categoria TITULO

            PdfPCell tcategoria = new PdfPCell(new Phrase("CATEGORIA", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                Colspan = 2,

                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(tcategoria);

            PdfPCell tscategoria = new PdfPCell(new Phrase("SUBCATEGORIA", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                Colspan = 3,

                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(tscategoria);

            PdfPCell tpeso = new PdfPCell(new Phrase("PESO", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),


                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tpeso);

            PdfPCell trendimento = new PdfPCell(new Phrase("RENDIMENTO", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),


                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(trendimento);

            PdfPCell tAtendePax = new PdfPCell(new Phrase("ATENDE PAX", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),


                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(tAtendePax);

            altura = 15;

            PdfPCell setor = new PdfPCell(new Phrase(nome_setor, texto))
            {
                FixedHeight = altura,

                Colspan = 2,

                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(setor);


            PdfPCell categoria = new PdfPCell(new Phrase(nome_cat, texto))
            {
                FixedHeight = altura,

                Colspan = 2,

                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(categoria);

            PdfPCell scategoria = new PdfPCell(new Phrase(nome_scat, texto))
            {
                FixedHeight = altura,

                Colspan = 3,

                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(scategoria);

            PdfPCell pesopdf = new PdfPCell(new Phrase(peso.ToString("#,0.0000"), texto))
            {
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(pesopdf);

            PdfPCell rendimentoPdf = new PdfPCell(new Phrase(rendimento.ToString("#,0.00"), texto))
            {
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(rendimentoPdf);

            PdfPCell atendePaxPdf = new PdfPCell(new Phrase(atendePax.ToString("#,0"), texto))
            {
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                FixedHeight = altura
            };
            table.AddCell(atendePaxPdf);
            



            altura = 20;

            PdfPCell cod = new PdfPCell(new Phrase("CODIGO", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(cod);

            PdfPCell item = new PdfPCell(new Phrase("ITEM", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                Colspan = 4,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(item);

            PdfPCell fc = new PdfPCell(new Phrase("FC", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(fc);

            PdfPCell um = new PdfPCell(new Phrase("U.M.", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(um);


            PdfPCell quant = new PdfPCell(new Phrase("QUANT.", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(quant);

            PdfPCell unit = new PdfPCell(new Phrase("$UNIT", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(unit);

            PdfPCell totalpdf = new PdfPCell(new Phrase("$TOTAL", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(totalpdf);


            //Produtos

            altura = 15;

            PdfPCell linha = new PdfPCell()
            {
                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_LEFT,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };


            //Linha por linha busca ingrediente com custo
            BLLPratos bll = new BLLPratos();
            DataTable tabelaIngredientes = bll.ListarIngredientes(codigoP);

            
            BLLMateriais bllMateriais = new BLLMateriais();
            DataTable TabelaMateriais;

            string codIngrediente, nomeingrediente, uniMedida;
            double quantidade, custoUnit, custoTotal, correcao;


            if (tabelaIngredientes.Rows.Count > 0)
            {
                for (int i = 0; i < tabelaIngredientes.Rows.Count; i++)
                {                    

                    TabelaMateriais = bllMateriais.LocalizarPorCod(tabelaIngredientes.Rows[i][0].ToString());

                    codIngrediente = tabelaIngredientes.Rows[i][0].ToString();
                    nomeingrediente = TabelaMateriais.Rows[0][0].ToString();
                    uniMedida = TabelaMateriais.Rows[0][1].ToString();

                    
                    if (string.IsNullOrEmpty(TabelaMateriais.Rows[0][2].ToString()))
                    {
                        correcao = 0;
                    }
                    else
                    {
                        correcao = Convert.ToDouble(TabelaMateriais.Rows[0][2]);
                    }
                    

                    quantidade = Convert.ToDouble(tabelaIngredientes.Rows[i][1]);

                    custoUnit = CustoIngrediente(codIngrediente, unidade);
                    custoTotal = custoUnit * quantidade;

                    //add linhas

                    if (i % 2 > 0)
                    {
                        linha.BackgroundColor = (linhaAlternada1);
                    }
                    else
                    {
                        linha.BackgroundColor = (linhaAlternada0);

                    }

                    linha.Phrase = new Phrase(codIngrediente, texto);
                    table.AddCell(linha);

                    linha.Phrase = new Phrase(nomeingrediente, texto);
                    linha.Colspan = 4;
                    table.AddCell(linha);

                    
                    linha.Phrase = new Phrase(correcao.ToString("#,0.00"), texto);
                    linha.Colspan = 1;
                    table.AddCell(linha);
                    

                    linha.Phrase = new Phrase(uniMedida, texto);
                    table.AddCell(linha);

                    linha.Phrase = new Phrase(quantidade.ToString(), texto);
                    table.AddCell(linha);

                    linha.Phrase = new Phrase(custoUnit.ToString("#,0.00"), texto);
                    table.AddCell(linha);

                    linha.Phrase = new Phrase(custoTotal.ToString("#,0.00"), texto);
                    table.AddCell(linha);
                }
            }

            PdfPCell tcpax = new PdfPCell(new Phrase("CUSTO/PAX", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                Colspan = 2,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tcpax);

            PdfPCell tckg = new PdfPCell(new Phrase("CUSTO/Kg", new Font(subtitulo)))
            {
                Colspan = 2,

                BackgroundColor = (CSTitulo),

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tckg);

            PdfPCell tcporcao = new PdfPCell(new Phrase("CUSTO/PORÇÃO", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                Colspan = 4,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tcporcao);

            PdfPCell tctotal = new PdfPCell(new Phrase("CUSTO TOTAL", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),

                Colspan = 3,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tctotal);

            PdfPCell cpax = new PdfPCell(new Phrase(custoPax.ToString("R$ #,0.00"), new Font(texto)))
            {
                Colspan = 2,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(cpax);


            PdfPCell ckg = new PdfPCell(new Phrase(totalKg.ToString("R$ #,0.00"), new Font(texto)))
            {
                Colspan = 2,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(ckg);


            PdfPCell cporcao = new PdfPCell(new Phrase(totalPorcao.ToString("R$ #,0.00"), new Font(texto)))
            {
                FixedHeight = altura,

                Colspan = 4,

                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(cporcao);

            PdfPCell ctotal = new PdfPCell(new Phrase(total.ToString("R$ #,0.00"), new Font(texto)))
            {
                Colspan = 3,

                FixedHeight = altura,
                HorizontalAlignment = PdfPCell.ALIGN_CENTER,
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(ctotal);

            altura = 20f;



            PdfPCell tModoPreparo = new PdfPCell(new Phrase("MODO DE PREPARO", new Font(subtitulo)))
            {
                BackgroundColor = (CSTitulo),
                Colspan = 10,
                FixedHeight = 20f,
                HorizontalAlignment = 1, //0=esquerda, 1 = centro, 2=direita
                VerticalAlignment = PdfPCell.ALIGN_MIDDLE
            };
            table.AddCell(tModoPreparo);

            PdfPCell ModoPreparo = new PdfPCell(new Phrase(preparo, texto))
            {
                Colspan = 10,
                PaddingTop = 10f,
                PaddingBottom = 10f,
                PaddingLeft = 5f,
                PaddingRight = 5f,
                HorizontalAlignment = PdfPCell.ALIGN_JUSTIFIED
            };
            table.AddCell(ModoPreparo);
                      

            if (imagem != "")

            {
                Image pic = Image.GetInstance(dto.FT + codigoP + ".jpg");

                float largura = 300;
                float alturai = 0.0f;
                float alturaNova;
                alturai = pic.Height;
                alturaNova = (largura * alturai) / pic.Width;
                pic.ScaleAbsolute(largura, alturaNova);

                PdfPCell foto = new PdfPCell(pic)
                {
                    Colspan = 10,

                    Padding = 10f,
                    VerticalAlignment = PdfPCell.ALIGN_MIDDLE,
                    HorizontalAlignment = PdfPCell.ALIGN_CENTER
                };
                table.AddCell(foto);
            }

            doc.Add(table);
            doc.Close();
        }

        public void AtualizaTodosOsCustos()
        {
            BLLUnidade bllUni = new BLLUnidade();
            BLLPratos bllPrat = new BLLPratos();
            BLLCustoPrato bllCusto = new BLLCustoPrato();

            //Datatable com unidades
            DataTable unidades = bllUni.Localizar();
            //Datatable com fichas técnicas
            DataTable pratos = bllPrat.ListarCodigos();

            int idUnidade = 0;
            string codPrato = "";

            for (int i = 0; i < unidades.Rows.Count; i++)
            {
                idUnidade = Convert.ToInt32(unidades.Rows[i][0].ToString());

                for (int j = 0; j < pratos.Rows.Count; j++)
                {
                    codPrato = pratos.Rows[j][0].ToString();
                    bllCusto.AtualizarCusto(codPrato, idUnidade);
                }
            }

            //Looping pelas unidades atualizando todas as fichas técnicas

        }

        public void AtualizaCustosFicha(string codigoFicha)
        {
            BLLUnidade bllUni = new BLLUnidade();
            BLLPratos bllPrat = new BLLPratos();
            BLLCustoPrato bllCusto = new BLLCustoPrato();

            //Datatable com unidades
            DataTable unidades = bllUni.Localizar();
            //Datatable com fichas técnicas
            DataTable pratos = bllPrat.ListarCodigos();

            int idUnidade = 0;
            string codPrato = "";

            //Looping pelas unidades atualizando o custo do prato informado
            for (int i = 0; i < unidades.Rows.Count; i++)
            {
                idUnidade = Convert.ToInt32(unidades.Rows[i][0].ToString());
                codPrato = codigoFicha;
                bllCusto.AtualizarCusto(codPrato, idUnidade);
            }

        }

        public bool Redundancia(string CodPrato, string CodInserido)
        {
            bool redundante = false;

            string codItem = "";

            if (CodInserido.Substring(0, 2) == "20")
            {
                if (CodPrato != CodInserido)
                {
                    BLLPratos bll = new BLLPratos();

                    DataTable tabela = new DataTable();
                    DataTable tabela3 = new DataTable();

                    tabela = bll.ListarIngredientes(CodInserido);

                    for (int i = 0; i < tabela.Rows.Count; i++)
                    {
                        codItem = tabela.Rows[i][0].ToString();

                        //Se for Prato
                        if (codItem.Substring(0, 2) == "20")
                        {
                            tabela3 = bll.LocalizarPorCod(codItem);
                            try
                            {
                                if (Redundancia(CodPrato, codItem))
                                {
                                    redundante = true;
                                }
                            }
                            catch
                            { }
                        }

                        //Se for ingrediente
                        else
                        {
                            if (codItem == CodPrato)
                            {
                                redundante = true;
                            }

                        }

                        if (redundante)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    redundante = true;
                }
            }

            return redundante;
        }

    }

    public class SQLServerBackup
    {
        public static ArrayList ObtemBancoDeDadosSQLSever(String ConnString)
        {
            ArrayList lista = new ArrayList();
            //criou a conexao
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand()
            {
                Connection = cn,
                CommandText = "SELECT [name] FROM sysdatabases"
            };
            //criou o datareader
            SqlDataReader dr;
            try
            {
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["name"]);
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
            return lista;
        }

        public static void BackupDataBase(String ConnString, string nomeDB, string backupFile)
        {
            //string backup="";
            //criou a conexao
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand()
            {
                Connection = cn,
                CommandText = "BACKUP DATABASE [" + nomeDB + "] TO DISK = '" + backupFile + "'"
            };
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
            //return backup;

        }

        public static void RestauraDatabase(string nomeDB, string backupFile)
        {

            BLLBackupDataBase bll = new BLLBackupDataBase();
            bll.Restaura(nomeDB, backupFile);
        }
    }

    public class Update
    {
        string NewVersion()
        {
            DTOCaminhos dto = new DTOCaminhos();

            FileStream fs = new FileStream(dto.Updates + "VersionInfo.xml", FileMode.Open, FileAccess.Read);
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;

            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("VersionInfo");

            string str = "";

            for (int i = 0; i < xmlnode.Count; i++)
            {
                str = string.Format(xmlnode[i].ChildNodes.Item(0).InnerText);
                
            }

            fs.Close();
            return str;

        }

        public bool ChecarAtualizacao()
        {
            bool Atualizacao = false;

            DTOCaminhos caminhos = new DTOCaminhos();
            DTOAssemblyInfo assembly = new DTOAssemblyInfo();
            
            int[] VersaoAtual = StringToIntVersion(assembly.Versao);
            int[] NovaVersao = StringToIntVersion(NewVersion());

            for(int i =0; i<VersaoAtual.Length; i++)
            {
                if(NovaVersao[i] > VersaoAtual[i])
                {
                    Atualizacao = true;
                    break;
                }
            }

            return Atualizacao;
        }




        public int[] StringToIntVersion(string v)
        {
            string[] ver = v.Split('.');
            int[] versao = { 0, 0, 0, 0 };

            if (ver.Length == 4)
            {
                for (int i = 0; i < ver.Length; i++)
                {
                    versao[i] = Convert.ToInt32(ver[i]);
                }        
            }

            return versao;
        }
    }


}