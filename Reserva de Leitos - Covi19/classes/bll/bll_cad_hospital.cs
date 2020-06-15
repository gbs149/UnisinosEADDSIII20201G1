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
    public static class bll_cad_hospital
    {
        public static bool Incluir(dto_cad_hospital hospital)
        {
            AcessoBancoDados bd;
            bool resultado = false;

            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"INSERT INTO hospital(NOME, CNPJ, Cidade_id) VALUES('{hospital.Nome}', '{hospital.CNPJ}', {hospital.Cidade})";
                bd.ExecutarComandoSQL(comando);
                resultado = true;
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir o cadastro do hospital! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return resultado;
        }

        public static DataTable Carregarhospitais()
        {
            DataTable hospitais = new DataTable();
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select Nome, CNPJ from hospital";
                hospitais = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o cadastro do hospital! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return hospitais;
        }

        /* Exclusão do cadastro do hospital*/
        public static bool Excluir(string cnpj)
        {
            AcessoBancoDados bd;
            bool resultado = false;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "delete from hospital where CNPJ =" + cnpj;
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

        /* Atualização do cadastro do hospital */
        public static bool Alterar(dto_cad_hospital hospital)
        {
            AcessoBancoDados bd;
            bool resultado = false;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = "update hospital set NOME= '" + hospital.Nome + "', CNPJ= '" + hospital.CNPJ +
                                 "', Cidade_id= " + hospital.Cidade + " where Id = " + hospital.Codigo;
                bd.ExecutarComandoSQL(comando);
                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o cadastro do hospital! \n" +
                Convert.ToString(ex), "Erro na operação de alteração!",
                MessageBoxButtons.OK);
            }   // fim catch alterar

            bd = null;
            return resultado;
        }

        public static dto_cad_hospital Selecionar(string CNPJ)
        {
            dto_cad_hospital hospital = null;
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select * from hospital Where CNPJ = '{CNPJ}'";
                var dthospital =  bd.RetDataTable(comando);
                foreach (DataRow linha in dthospital.Rows)
                {
                    hospital = new dto_cad_hospital();
                    hospital.Codigo = Convert.ToInt32(linha["Id"]);
                    hospital.Nome = linha["Nome"].ToString();
                    hospital.CNPJ = linha["CNPJ"].ToString();
                    hospital.Cidade = Convert.ToInt32(linha["Cidade_id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o cadastro do hospital! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;

            return hospital;
        }
    }
}
