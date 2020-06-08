using ControleEquipamentos.Code.DAL;
using Reserva_de_Leitos___Covi19.classes.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Leitos___Covi19.classes.bll
{
    public static class bll_cad_cidade
    {
        public static DataTable CarregarCidades()
        {
            DataTable cidades = new DataTable();
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select * from cidade";
                cidades = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Selecionar as Cidades!" + ex.Message);
            }

            bd = null;

            return cidades;
        }

        public static dto_cad_cidade Selecionar(int codCidade)
        {
            dto_cad_cidade cidade = new dto_cad_cidade();
            AcessoBancoDados bd;
            try
            {
                bd = new AcessoBancoDados();
                bd.conectar();
                string comando = $"Select * from cidade Where COdigo = {codCidade}";
                var dtCidade = bd.RetDataTable(comando);
                foreach (DataRow linha in dtCidade.Rows)
                {
                    cidade.Nome = linha["Nome"].ToString();
                    cidade.Codigo = Convert.ToInt32(linha["Codigo"].ToString());
                    cidade.UF = linha["UF"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Selecionar a Cidade!" + ex.Message);
            }

            bd = null;

            return cidade;
        }
    }
}
