using System;
using Omega_System.Class.Model;
using Omega_System.Class.View;
using Npgsql;
using System.Windows.Forms; 
using System.Collections.Generic;

namespace Omega_System.Class.Controller
{
	public abstract class DBCategoria : DBConexao
	{
		public static void Inserir(Categoria c){
			
			NpgsqlConnection conn = DBConexao.Conectar();
			
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
			NpgsqlConnection conn = DBConexao.Conectar();
			
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
		
		public static void DBEditar(Categoria c){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "UPDATE Categorias SET descricao = @n WHERE ID = @i";
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("i", c.getId());
			cmd.Parameters.Add("n", c.getDescricao());
			
			if(cmd.ExecuteNonQuery() == 1){
				MessageBox.Show("Categoria alterado com sucesso", "Sucesso", MessageBoxButtons.OK);
			}else{
				MessageBox.Show("Erro ao alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public DBCategoria()
		{
		}
	}
}
