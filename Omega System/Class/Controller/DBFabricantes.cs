using System;
using Npgsql;
using System.Windows.Forms;
using System.Drawing;
using Omega_System.Class.Model;
using Omega_System.Class.View; 
using System.Data;
using System.Collections.Generic;

namespace Omega_System.Class.Controller
{
	public abstract class DBFabricantes : DBConexao
	{
		public DBFabricantes()
		{
		}
		
		public static void Inserir(Fabricantes f){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "INSERT INTO FABRICANTE(NOME) VALUES (@n)"; 
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("n", f.getNome());

			if(cmd.ExecuteNonQuery() == 1){
				frmMain f1 = new frmMain();
				MessageBox.Show("fabricante cadastrado com sucesso");
			}else{
				MessageBox.Show("Erro ao cadastrar fabricante");
			}
		}
	
		public List<Fabricantes> DBBuscar(){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "SELECT ID, NOME FROM FABRICANTE";
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			
			cmd.Connection = conn;
			NpgsqlDataReader reader = cmd.ExecuteReader();
			
			List<Fabricantes> lista = new List<Fabricantes>();
			
			while(reader.Read())
			{
				Fabricantes f = new Fabricantes();
				f.id = (Convert.ToInt32(reader["id"]));
				f.nome = (reader["nome"].ToString());				
				lista.Add(f);
			}
			return lista;
		}
		
		public static void DBEditar(Fabricantes f){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "UPDATE Fabricante SET NOME = @n WHERE ID = @i";
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("i", f.getId());
			cmd.Parameters.Add("n", f.getNome());
			
			if(cmd.ExecuteNonQuery() == 1){
				MessageBox.Show("Fabricante alterado com sucesso", "Sucesso", MessageBoxButtons.OK);
			}else{
				MessageBox.Show("Erro ao alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public static void DBExcluir(Fabricantes f){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "DELETE FROM FABRICANTE WHERE ID = @I";
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("i", f.getId());
			
			if(cmd.ExecuteNonQuery() == 1){
				MessageBox.Show("Excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
			}else{
				MessageBox.Show("Erro ao excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
	}
}
