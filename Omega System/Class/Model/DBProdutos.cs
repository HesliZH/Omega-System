using System;
using Omega_System.Class.Controller;
using Omega_System.Class.View;
using System.Data;
using System.Collections.Generic;
using Npgsql;
using System.Windows.Forms;

namespace Omega_System.Class.Model
{
	public class DBProdutos : DBConexao
	{
		public static void Inserir(Produtos p){
			DBConexao d1 = new DBConexao();
			NpgsqlConnection conn = d1.Conectar();
			
			string query = "INSERT INTO PRODUTOS(DESCRICAO, CATEGORIA, FABRICANTE, VENDA, QTD_ESTOQUE) VALUES (@d, @c, @m, @v, @q)"; 
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("d", p.getDescricao());
			cmd.Parameters.Add("c", p.getCategoria());
			cmd.Parameters.Add("m", p.getMarca());
			cmd.Parameters.Add("v", p.getVenda());
			cmd.Parameters.Add("q", p.getQtd());
			
			if(cmd.ExecuteNonQuery() == 1){
				frmMain f1 = new frmMain();
				MessageBox.Show("Produto cadastrado com sucesso");
			}else{
				MessageBox.Show("Erro ao cadastrar produto");
			}
		}
		public DBProdutos()
		{
		}
	}
}
