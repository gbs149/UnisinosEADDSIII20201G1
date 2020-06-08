using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                      // habilita DataTable
using CE_RCA.Codigo.DTO;                // habilita a comunicação com a claase dto_Equip
using ControleEquipamentos.Code.DAL;    // habilita a comunicação com a classe de acesso ao banco de dados

//Envio de email
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace CE_RCA.Codigo.BLL
{
    class bll_Metodos
    {
        AcessoBancoDados bd;    //Variável global de acesso ao banco de dados

        // Metodo de cadastro de equipamentos
        public void cadEquip(dto_Equip dto)
        {   //ini cadEquip
            AcessoBancoDados bd;    // Declaração de variável para acesso ao banco de dados
            try
            {   //ini try
                string tipo = dto.Tipo.Replace("'", "''");
                string fabricante = dto.Fabricante.Replace("'", "''");
                string modelo = dto.Modelo.Replace("'", "'");
                string sn = dto.SN.Replace("'", "'");
                string contagem = dto.Contagem.Replace("'", "'");
                string potencia = dto.Potencia.Replace("'", "'");
                string polegada = dto.Polegadas.Replace("'", "'");
                string local = "RCA Interno";
                string tecent = "";
                string tecret = "";
                string tecsaid = "";
                string tecinstal = "";
                int status = dto.Status;

                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "INSERT INTO equipamentos(tipo, fabricante, modelo, sn, contagem, potencia, polegada, status, local, tecent, tecret, tecsaid, tecinstal) VALUES('" + tipo + "','" + fabricante + "','" + modelo + "','" + sn + "','" + contagem + "','" + potencia + "','" + polegada + "','" + status + "','" + local + "','" + tecent + "','" + tecret + "','" + tecsaid + "','" + tecinstal + "')";
                bd.ExecutarComandoSQL(comando);
            }   //fim try    
            catch (Exception ex)
            {
                throw new Exception("Erro ao acadastrar o novo equipamento!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }   //fim cadEquip

        //Metodos de exibição dos equipamentos
        //--------------------------------------------------------------------------------------------------
        //Equipamentos internos
        public DataTable exibeEquipInt(dto_Equip dto)
        {   //ini exibe equipamentos internos
            DataTable dt = new DataTable();
            try
            {   //ini excessão
                bd = new AcessoBancoDados();
                bd.conectar();
                int status = 0;
                dt = bd.RetDataTable("SELECT id, tipo, fabricante, modelo, sn, contagem, potencia, polegada, local from equipamentos where status =" + status);

            }   //fim excessão
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar aos equipamentos internos!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
            return dt;  //retorna com os dados dos equipamentos internos
        }   //fim exibe equipamentos internos

        //Equipamentos externos
        public DataTable exibeEquipExt(dto_Equip dto)
        {   //ini exibe equipamentos externos
            DataTable dt = new DataTable();
            try
            {   //ini excessão
                bd = new AcessoBancoDados();
                bd.conectar();
                int status = 1;
                dt = bd.RetDataTable("SELECT id, tipo, fabricante, modelo, sn, contagem, potencia, polegada, local from equipamentos where status =" + status);
            }   //fim excessão
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar aos equipamentos externos!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
            return dt;  //retorna com os dados dos equipamentos internos
        }   //fim exibe equipamentos externos

        //Todos os equipamentos
        public DataTable exibeTodosEquip()
        {   //ini exibe todos os equipamentos
            DataTable dt = new DataTable();
            try
            {   //ini excessão
                bd = new AcessoBancoDados();
                bd.conectar();
                dt = bd.RetDataTable("SELECT id, tipo, fabricante, modelo, sn, contagem, potencia, polegada, status, local, tecent, tecret, tecsaid, tecinstal from equipamentos"); 
            }   //fim excessão
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar ao banco de dados dos equipamentos!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
            return dt;  //retorna com os dados de todos os equipamentos
        }   //fim exibe todos os equipamentos

        /*/Equipamentos por tipo
        public DataTable exibeTipoEquip(dto_Equip dto)
        {   //ini exibe equipamentos externos
            DataTable dt = new DataTable();
            try
            {   //ini excessão
                bd = new AcessoBancoDados();
                bd.conectar();
                if(dto.Tipo == "Impressora")
                dt = bd.RetDataTable("SELECT id, tipo, fabricante, modelo, sn, contagem, local, tecent, tecret, tecsaid, tecinstal from equipamentos where tipo =" + dto.Tipo);
                else if(dto.Tipo == "Nobreak" || dto.Tipo == "Estabilizador")
                    dt = bd.RetDataTable("SELECT id, tipo, fabricante, modelo, sn, potencia, local, tecent, tecret, tecsaid, tecinstal from equipamentos where tipo =" + dto.Tipo);

                else dt = bd.RetDataTable("SELECT id, tipo, fabricante, modelo, sn, local, tecent, tecret, tecsaid, tecinstal from equipamentos where tipo =" + dto.Tipo);
            }   //fim excessão
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar aos equipamentos externos!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
            return dt;  //retorna com os dados dos equipamentos internos
        }   //fim exibe equipamentos externos*/

        //--------------------------------------------------------------------------------------------------

        //Metodo de atualização da contagem de paginas do equipamento
        public void atualCont(dto_Equip dto)
        {
            AcessoBancoDados bd;    // Declaração de variável para acesso ao banco de dados
            try
            {   //ini try
                string cont = dto.Contagem.Replace("'", "''");

                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "UPDATE equipamentos set contagem = '" + cont + "' where id =" + dto.ID;
                bd.ExecutarComandoSQL(comando);
            }   //fim try    
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a contagem de paginas da impressora!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        //Metodo de atualização do status dos equipamentos internos
        public void atualLocalInt(dto_Equip dto)
        {
            AcessoBancoDados bd;    // Declaração de variável para acesso ao banco de dados
            try
            {   //ini try
                string local = "RCA Interno";

                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "UPDATE equipamentos set local = '" + local + "' where id =" + dto.ID;
                bd.ExecutarComandoSQL(comando);
            }   //fim try    
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o status de localização de equipamentos para RCA Interno!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }

        // Metodo para atualizar valor de entrada - status = 0 (equipamento interno)
        public void entEquip(dto_Equip dto)
        {   //ini atualiza entrada
            AcessoBancoDados bd;    // Declaração de variável para acesso ao banco de dados
            try
            {   //ini try
                string local = dto.Local.Replace("'", "''");
                string tecRet = dto.TecRet.Replace("'", "''");
                string tecEnt = dto.TecEnt.Replace("'", "''");
                string tecSaid = "";
                string tecInstal = "";
                int status = 0;     // Variável de atualização de status 1 para 0, ou saída para entrada

                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "UPDATE equipamentos set status = '" + status + "', local = '" + local + "', tecret = '" + tecRet + "', tecent = '" + tecEnt + "', tecsaid = '" + tecSaid + "', tecinstal = '" + tecInstal + "' where id =" + dto.ID;
                bd.ExecutarComandoSQL(comando);

                
            }   //fim try    
            catch (Exception ex)
            {
                throw new Exception("Erro ao dar entrada no equipamento!" + ex.Message);
            }
            try
            {
                sendMail(dto);  //envia email de saída de equipamento
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar o email de entrada de equipamento!" + ex.Message);
            }
            try
            {
                atualCont(dto); // atualiza a contagem de paginas na entrada de equipamentos
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a contagem de paginas do equipamento!" + ex.Message);
            }
            finally
            {
                bd = null;
                dto = null;                
            }
        }   //fim atualiza entrada

        // Metodo para atualizar valor de saída - status = 1 (equipamento externo)
        public void saiEquip(dto_Equip dto)
        {   //ini atualiza entrada
            AcessoBancoDados bd;    // Declaração de variável para acesso ao banco de dados
            try
            {   //ini try
                string local = dto.Local.Replace("'", "''");
                string tecSaid = dto.TecSaid.Replace("'", "''");
                string tecInstal = dto.TecInstal.Replace("'", "''");
                string tecEnt = "";
                string tecRet = "";
                int status = 1;     // Variável de atualização de status 0 para 1, ou entrada para saída

                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "UPDATE equipamentos set status = '" + status + "', local = '" + local + "', tecsaid = '" + tecSaid + "', tecinstal = '" + tecInstal + "', tecent = '" + tecEnt + "', tecret = '" + tecRet + "' where id =" + dto.ID;
                bd.ExecutarComandoSQL(comando);
            }   //fim try    
            catch (Exception ex)
            {
                throw new Exception("Erro ao dar saída no equipamento!" + ex.Message);
            }
            try
            {
                //sendMailSaid(dto);  //envia email de saída de equipamento
                sendMail(dto);  //envia email de saída de equipamento
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar o email de saída de equipamento!" + ex.Message);
            }
            try
            {
                atualCont(dto); // atualiza a contagem de paginas na entrada de equipamentos
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a contagem de paginas do equipamento!" + ex.Message);
            }
            finally
            {
                bd = null;
                dto = null;
            }
        }   //fim atualiza entrada

        //Metodos de envio de e-mail
        //--------------------------------------------------------------------------------------------------
        //Metodo de envio de emails de entrada e saída de equipamentos
        public void sendMail(dto_Equip dto)
        {
            //variáveis globais
            MailMessage Email;
            string sBobdy;
            Stopwatch Stop = new Stopwatch();
            //Funções
            Email = new MailMessage();
            Email.To.Add(new MailAddress("faturamento@rcainformatica.com.br"));   //destinatario
            Email.From = new MailAddress("contequiprca@gmail.com");         //remetente

            //Função verifica operação de entrada e saída e define layout
            if (dto.Status == 0)                                             //status invertido pois no sistema ainda não foi alterado
            {
                Email.Subject = "Entrada de equipamento";                   //Assunto do email
                if (dto.Tipo == "Impressora")
                {
                    sBobdy = "Entrada de equipamentos RCA Informática LTDA<br/><br/>" + "- ID: " + dto.ID + "<br/>" + "- Tipo: " + dto.Tipo + "<br/>" + "- Fabricante: " + dto.Fabricante + "<br/>" + "- Modelo: " + dto.Modelo + "<br/>" + "- Numero de série: " + dto.SN + "<br/>" + "- Contagem de paginas: " + dto.Contagem + "<br/>" + "- Cliente de retirada: " + dto.Local + "<br/>" + "- Técnico de retirada: " + dto.TecRet + "<br/>" + "- Técnico de entrada: " + dto.TecEnt + "<br/><br/>";
                    atualLocalInt(dto);                                     //Chamada da função de atualização da localização do equipamento
                }
                else
                {
                    sBobdy = "Entrada de equipamentos RCA Informática LTDA<br/><br/>" + "- ID: " + dto.ID + "<br/>" + "- Tipo: " + dto.Tipo + "<br/>" + "- Fabricante: " + dto.Fabricante + "<br/>" + "- Modelo: " + dto.Modelo + "<br/>" + "- Numero de série: " + dto.SN + "<br/>" + "- Cliente de retirada: " + dto.Local + "<br/>" + "- Técnico de retirada: " + dto.TecRet + "<br/>" + "- Técnico de entrada: " + dto.TecEnt + "<br/><br/>";
                    atualLocalInt(dto);                                     //Chamada da função de atualização da localização do equipamento 
                }
            }
            else
            {
                Email.Subject = "Saída de equipamento";                     //Assunto do email
                if (dto.Tipo == "Impressora")
                {
                    sBobdy = "Saída de equipamentos RCA Informática LTDA<br/><br/>" + "- ID: " + dto.ID + "<br/>" + "- Tipo: " + dto.Tipo + "<br/>" + "- Fabricante: " + dto.Fabricante + "<br/>" + "- Modelo: " + dto.Modelo + "<br/>" + "- Numero de série: " + dto.SN + "<br/>" + "- Contagem de paginas: " + dto.Contagem + "<br/>" + "- Cliente de locação: " + dto.Local + "<br/>" + "- Técnico de instalação: " + dto.TecInstal + "<br/>" + "- Técnico de saída: " + dto.TecSaid + "<br/><br/>";
                }
                else sBobdy = "Saída de equipamentos RCA Informática LTDA<br/><br/>" + "- ID: " + dto.ID + "<br/>" + "- Tipo: " + dto.Tipo + "<br/>" + "- Fabricante: " + dto.Fabricante + "<br/>" + "- Modelo: " + dto.Modelo + "<br/>" + "- Numero de série: " + dto.SN + "<br/>" + "- Cliente de locação: " + dto.Local + "<br/>" + "- Técnico de instalação: " + dto.TecInstal + "<br/>" + "- Técnico de saída: " + dto.TecSaid + "<br/><br/>";
            }

            Email.IsBodyHtml = true;                                        //Habilita html            
            Email.Body = sBobdy;
            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.Port = 587;       // porta para SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas
                                                    // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential("contequiprca@gmail.com", "Cont12qwaszx!Equip");
                // envia o e-mail
                smtp.Send(Email);
            }
        }

        /*/ Exclusão de Impressoras
        public void excluirImp(string idEquip)
        {   //ini exclui impressoras
            AcessoBancoDados bd;    // Declaração de variável para acesso ao banco de dados
            try
            {   //ini try

                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "DELETE FROM impressoras where id =" + idEquip;
                bd.ExecutarComandoSQL(comando);
            }   //fim try    
            catch (Exception ex)
            {
                throw new Exception("Erro ao Excluir o equipamento" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }   //fim exclui impressoras      

        */

    }
}
