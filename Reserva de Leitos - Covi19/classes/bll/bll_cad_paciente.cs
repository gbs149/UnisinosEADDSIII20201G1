using ControleEquipamentos.Code.DAL;
using Org.BouncyCastle.Cms;
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
    public static class bll_cad_paciente
    {
        public static bool Incluir(dto_cad_paciente paciente)
        {
            AcessoBancoDados bd;
            bool resultado = false;

            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"INSERT INTO Paciente(NOME, CPF, GENERO, DATA_NASCIMENTO, Cidade_id) VALUES('{paciente.Nome}', '{paciente.CPF}', '{paciente.Genero}', '{paciente.DataNascimento.ToString("yyyy-MM-dd H:mm:ss")}',  {paciente.Cidade})";
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir o cadastro do paciente! \n" +
                Convert.ToString(ex), "Erro na operação de cancelamento!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return resultado;
        }

        public static DataTable CarregarPacientes()
        {
            DataTable pacientes = new DataTable();
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select Nome, CPF from paciente";
                pacientes = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o cadastro do paciente! \n" +
                Convert.ToString(ex), "Erro na operação de cancelamento!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return pacientes;
        }

        /* Exclusão do cadastro do paciente*/
        public static bool Excluir(string cpf)
        {
            AcessoBancoDados bd;
            bool resultado = false;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "delete from Paciente where CPF =" + cpf;
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o cadastro do paciente! \n" +
                Convert.ToString(ex), "Erro na operação de cancelamento!",
                MessageBoxButtons.OK);
            }   // fim catch excluir

            bd = null;
            return resultado;
        }   // fim Excluir

        /* Atualização do cadastro do paciente */
        public static bool Alterar(dto_cad_paciente paciente)
        {
            AcessoBancoDados bd;
            bool resultado = false;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "update paciente set NOME= '" + paciente.Nome + "', CPF= '" + paciente.CPF +
                                 "', GENERO= '" + paciente.Genero + "', DATA_NASCIMENTO = '" + (paciente.DataNascimento).ToString("yyyy-MM-dd H:mm:ss") +
                                 "', Cidade_id = " + paciente.Cidade + " where Id = " + paciente.Codigo;
                bd.ExecutarComandoSQL(comando);
                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o cadastro do paciente! \n" +
                Convert.ToString(ex), "Erro na operação de cancelamento!",
                MessageBoxButtons.OK);
            }   // fim catch excluir

            bd = null;
            return resultado;

        }

        public static dto_cad_paciente Selecionar(string cpf)
        {
            dto_cad_paciente paciente = null;
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select * from Paciente Where CPF = '{cpf}'";
                var dtPaciente =  bd.RetDataTable(comando);
                foreach (DataRow linha in dtPaciente.Rows)
                {
                    paciente = new dto_cad_paciente();
                    paciente.Codigo = Convert.ToInt32(linha["Id"]);
                    paciente.Nome = linha["Nome"].ToString();
                    paciente.CPF = linha["CPF"].ToString();
                    paciente.DataNascimento = Convert.ToDateTime(linha["DATA_NASCIMENTO"].ToString());
                    paciente.Genero = Convert.ToChar(linha["GENERO"].ToString());
                    paciente.Cidade = Convert.ToInt32(linha["Cidade_id"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Selecionar o Paciente!" + ex.Message);
            }

            bd = null;

            return paciente;
        }
    }
}
