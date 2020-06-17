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
                bd = AcessoBancoDados.GetInstance;
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
                bd = AcessoBancoDados.GetInstance;
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
        public static bool Excluir(dto_cad_hospital hospital)
        {
            AcessoBancoDados bd;
            bool resultado = false;
            try
            {
                var existeLeito = bll_cad_leitos.VerificarLeitoHospital(hospital.Codigo);
                if (existeLeito)
                {
                    MessageBox.Show("Não foi possível excluir o cadastro do hospital.\nExiste um leito alocado para este Hospital!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resultado = false;
                }
                else
                {
                    bd = AcessoBancoDados.GetInstance;
                    bd.conectar();
                    string comando = "delete from hospital where CNPJ =" + hospital.CNPJ;
                    bd.ExecutarComandoSQL(comando);
                    resultado = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o cadastro do hospital! \n" +
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
                bd = AcessoBancoDados.GetInstance;
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
                bd = AcessoBancoDados.GetInstance;
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

        public static DataTable CarregarLeitosDisponiveis(int cidade)
        {
            DataTable dtHospitaisLeitos = null;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $@"select h.Nome Hospital, (select count(*) from leito l
				                                              where l.Tipo = 'N' 
                                                                and l.Situacao = 'D'
                                                                and h.Id = l.Hospital_id) as 'LeitosNormais',
			                                                (select count(*) from leito l
				                                              where l.Tipo = 'U' 
                                                                and l.Situacao = 'D'
                                                                and h.Id = l.Hospital_id) as 'LeitosUTI',
                                    h.Id Hospital_Id, h.CNPJ
                                    From hospital h  
                                    where h.Cidade_id = {cidade}";
                dtHospitaisLeitos = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o cadastro do hospital! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return dtHospitaisLeitos;
        }

        internal static DataTable CarregarLeitoInternacao(int leito_Id)
        {
            DataTable dtHospitaisLeitos = null;
            AcessoBancoDados bd;
            try
            {
                bd = AcessoBancoDados.GetInstance;
                bd.conectar();
                string comando = $@"select h.Nome Hospital, (select count(*) from leito l1
                                                              where l1.Tipo = 'N' 
                                                                and l1.Situacao = 'D'
                                                                and h.Id = l1.Hospital_id) as 'LeitosNormais',
                                                            (select count(*) from leito l2
                                                              where l2.Tipo = 'U' 
                                                                and l2.Situacao = 'D'
                                                                and h.Id = l2.Hospital_id) as 'LeitosUTI',
		                                    h.Id Hospital_Id, h.CNPJ
                                    From hospital h
                                    inner join leito l on l.Hospital_id = h.Id and l.Id = {leito_Id}";
                dtHospitaisLeitos = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o cadastro do hospital! \n" +
                Convert.ToString(ex), "Erro na operação de cadastro!",
                MessageBoxButtons.OK);
            }

            bd = null;
            return dtHospitaisLeitos;
        }
    }
}
