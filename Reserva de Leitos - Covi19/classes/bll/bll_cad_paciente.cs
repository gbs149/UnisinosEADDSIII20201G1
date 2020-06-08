using ControleEquipamentos.Code.DAL;
using Org.BouncyCastle.Cms;
using Reserva_de_Leitos___Covi19.classes.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string comando = $"INSERT INTO Paciente(Nome,CPF,Sexo,Idade,Cidade,CodigoCidade) VALUES('{paciente.Nome}', '{paciente.CPF}', '{paciente.Sexo}', {paciente.Idade}, '', {paciente.Cidade})";
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }   
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir o novo Paciente!" + ex.Message);
            }

            bd = null;
            return resultado;
        }

        public static bool Alterar(dto_cad_paciente paciente)
        {
            return false;

        }

        public static bool Excluir(string cpf)
        {
            return false;

        }

        public static dto_cad_paciente Selecionar(string cpf)
        {
            dto_cad_paciente paciente = new dto_cad_paciente();
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select * from Paciente Where CPF = '{cpf}'";
                var dtPaciente =  bd.RetDataTable(comando);
                foreach (DataRow linha in dtPaciente.Rows)
                {
                    paciente.Nome = linha["Nome"].ToString();
                    paciente.CPF = linha["CPF"].ToString();
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
