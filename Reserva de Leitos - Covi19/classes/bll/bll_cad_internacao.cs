using ControleEquipamentos.Code.DAL;
using Reserva_de_Leitos___Covi19.classes.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_de_Leitos___Covi19.classes.bll
{
    class bll_cad_internacao
    {
        public static bool Incluir(dto_cad_internacao internacao)
        {
            AcessoBancoDados bd;
            bool resultado = false;

            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar(); 
                string comando = $@"insert into internacao (Data_Inicio, Situacao , Paciente_id , Leito_id)
                                    values ('{internacao.Data_Inicio.ToString("yyyy-MM-dd H:mm:ss")}', '{internacao.Situacao}', {internacao.Paciente_Id}, {internacao.Leito_Id});";
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir o cadastro da internação! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return resultado;
        }

        public static bool Alterar(dto_cad_internacao internacao)
        {
            AcessoBancoDados bd;
            bool resultado = false;

            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $@"Update internacao Set Data_Inicio = '{internacao.Data_Inicio.ToString("yyyy-MM-dd H:mm:ss")}', 
                                                          Data_Fim = '{internacao.Data_Fim.ToString("yyyy-MM-dd H:mm:ss")}',
                                                          Situacao = '{internacao.Situacao}',
                                                          Paciente_id = {internacao.Paciente_Id},
                                                          Leito_id = {internacao.Leito_Id}
                                    Where Id = {internacao.Id};";
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o cadastro da internação! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return resultado;
        }

        public static dto_cad_internacao SelecionarInternacaoPaciente(dto_cad_paciente paciente)
        {
            dto_cad_internacao internacao = null;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $@"select i.*, h.Cidade_id from internacao i
                                     inner join leito l on l.Id = i.Leito_id 
                                     inner join hospital h on h.Id = l.Hospital_id
                                     Where i.Paciente_Id = {paciente.Codigo}
                                       and i.Situacao = 'I'
                                     Order By Id desc Limit 1";
                var dtInternacao = bd.RetDataTable(comando);
                foreach (DataRow linha in dtInternacao.Rows)
                {
                    internacao = new dto_cad_internacao();
                    internacao.Id = Convert.ToInt32(linha["Id"]);
                    internacao.Data_Inicio = Convert.IsDBNull(linha["Data_Inicio"]) ? new DateTime() : Convert.ToDateTime(linha["Data_Inicio"]);
                    internacao.Situacao = Convert.ToChar(linha["Situacao"]);
                    internacao.Paciente_Id = Convert.ToInt32(linha["Paciente_Id"]);
                    internacao.Leito_Id = Convert.ToInt32(linha["Leito_Id"]);
                    internacao.Cidade_Id = Convert.ToInt32(linha["Cidade_id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a internacao do paciente! \n" +
                Convert.ToString(ex), "Erro na operação de seleção!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return internacao;
        }

        public static bool SelecionarObito(dto_cad_paciente paciente)
        {
            var resultado = false;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $@"Select * from internacao 
                                     Where Paciente_Id = {paciente.Codigo}
                                       and Situacao = 'O'
                                     Order By Id desc Limit 1";
                var dtInternacao = bd.RetDataTable(comando);
                resultado = dtInternacao.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a internacao do paciente! \n" +
                Convert.ToString(ex), "Erro na operação de seleção!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return resultado;
        }
    }
}
