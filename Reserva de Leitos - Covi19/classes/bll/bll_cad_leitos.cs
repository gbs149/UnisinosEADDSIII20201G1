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
    static class bll_cad_leitos
    {
        public static bool Atualizar(dto_cad_leito leito)
        {
            AcessoBancoDados bd;
            bool resultado = false;

            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $"Update Leito Set Tipo = '{leito.Tipo}', Situacao = '{leito.Situacao}', Hospital_Id = {leito.Hospital_Id} Where Id = {leito.Id}";
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o cadastro do leito! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return resultado;
        }


        public static dto_cad_leito Selecionar(int Leito_id)
        {
            dto_cad_leito leito = null;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $"Select * from leito Where Id = {Leito_id}";
                var dtLeito = bd.RetDataTable(comando);
                foreach (DataRow linha in dtLeito.Rows)
                {
                    leito = new dto_cad_leito();
                    leito.Id = Convert.ToInt32(linha["Id"]);
                    leito.Tipo = Convert.ToChar(linha["Tipo"]);
                    leito.Situacao = Convert.ToChar(linha["Situacao"]);
                    leito.Hospital_Id = Convert.ToInt32(linha["Hospital_Id"]);
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o cadastro do leito! \n" +
                Convert.ToString(ex), "Erro na operação de seleção!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return leito;
        }

        public static dto_cad_leito SelecionarLeitoDisponivel(char tipo, int hospital)
        {
            dto_cad_leito leito = null;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $"Select * from leito Where tipo = '{tipo}' and Hospital_id = {hospital} and Situacao = 'D'";
                var dtLeito = bd.RetDataTable(comando);
                foreach (DataRow linha in dtLeito.Rows)
                {
                    leito = new dto_cad_leito();
                    leito.Id = Convert.ToInt32(linha["Id"]);
                    leito.Tipo = Convert.ToChar(linha["Tipo"]);
                    leito.Situacao = Convert.ToChar(linha["Situacao"]);
                    leito.Hospital_Id = Convert.ToInt32(linha["Hospital_Id"]);
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar os leitos disponíveis! \n" +
                Convert.ToString(ex), "Erro na operação de seleção!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return leito;
        }

        public static bool VerificarLeitoHospital(int hospital)
        {
            bool resultado = false;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $"Select * from leito Where Hospital_id = {hospital}";
                var dtLeito = bd.RetDataTable(comando);
                resultado = dtLeito.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar os leitos disponíveis! \n" +
                Convert.ToString(ex), "Erro na operação de seleção!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return resultado;
        }
    }
}
