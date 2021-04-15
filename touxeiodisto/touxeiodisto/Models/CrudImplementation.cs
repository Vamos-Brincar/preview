using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using touxeiodisto.Models;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace touxeiodisto.Models
{
    public class CrudImplementation
    {
        public List<CrudProp> GetAti()
        {
            List<CrudProp> listaatividade = new List<CrudProp>();
            string mainconn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mysqlconn = new MySqlConnection(mainconn);
            string sqlquery = "select * from atividade";
            MySqlCommand sqlconn = new MySqlCommand(sqlquery, mysqlconn);
            mysqlconn.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(sqlconn);
            DataTable dt = new DataTable();
            mda.Fill(dt);
            mysqlconn.Close();
            foreach(DataRow dr in dt.Rows)
            {
                listaatividade.Add(new CrudProp
                {
                    id_atividade = Convert.ToInt32(dr["id_atividade"]),
                    nome = Convert.ToString(dr["nome"]),
                    data_at = Convert.ToDateTime(dr["data_at"]),
                    descricao = Convert.ToString(dr["descricao"]),
                    avaliacao = Convert.ToInt32(dr["avaliacao"]),
                }
                );
            }

            return listaatividade;
        }
    }
}