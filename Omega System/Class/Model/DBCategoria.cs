using System;
using Omega_System.Class.Controller;
using Omega_System.Class.View;
using Npgsql;
using System.Windows.Forms; 
using System.Collections.Generic;

namespace Omega_System.Class.Model
{
	public class DBCategoria : DBConexao
	{
		public static void Inserir(Categoria c){
			DBConexao d1 = new DBConexao();
			NpgsqlConnection conn = d1.Conectar();
			
			string query = "INSERT INTO CATEGORIA (DESCRICAO) VALUES (@c)"; 
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("c", c.getDescricao());
			
			if(cmd.ExecuteNonQuery() == 1){
				frmMain f1 = new frmMain();
				MessageBox.Show("Categoria cadastrada com sucesso");
			}else{
				MessageBox.Show("Erro ao cadastrar categoria");
			}
		}
		
		public static List<Categoria> Buscar(){
			DBConexao d3 = new DBConexao();
			
			NpgsqlConnection conn = d3.Conectar();
			
			string query = "SELECT ID, DESCRICAO FROM CATEGORIA";
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			
			cmd.Connection = conn;
			NpgsqlDataReader reader = cmd.ExecuteReader();
			
			List<Categoria> lista = new List<Categoria>();
			
			while(reader.Read())
			{
				Categoria c = new Categoria();
				c.id = (Convert.ToInt32(reader["id"]));
				c.descricao = (reader["descricao"].ToString());	
				
				lista.Add(c);
			}
			return lista;
		}
		
		public DBCategoria()
		{
		}
	}
}
