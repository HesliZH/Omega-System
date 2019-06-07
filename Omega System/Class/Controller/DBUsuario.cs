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
	public abstract class DBUsuario : DBConexao
	{
		public DBUsuario()
		{
		}
		
		public static void Inserir(Usuarios u){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "INSERT INTO USUARIOS(NOME, LOGIN, SENHA) VALUES (@n, @l, @s)"; 
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("n", u.getNome());
			cmd.Parameters.Add("l", u.getLogin());
			cmd.Parameters.Add("s", u.getSenha());
			
			if(cmd.ExecuteNonQuery() == 1){
				frmMain f1 = new frmMain();
				MessageBox.Show("Usuário cadastrado com sucesso");
			}else{
				MessageBox.Show("Erro ao cadastrar usuario");
			}
		}
		
		public static bool Entrar(Usuarios u){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "SELECT LOGIN, SENHA FROM USUARIOS WHERE LOGIN = @u AND SENHA = @s";
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("u", u.getLogin());
			cmd.Parameters.Add("s", u.getSenha());
			NpgsqlDataReader dr = cmd.ExecuteReader();
			
			if(dr.Read()){
				MessageBox.Show("Usuário localizado com sucesso!","Bem Vindo", MessageBoxButtons.OK);
				return true;
			}else{
				MessageBox.Show("Erro ao localizar o usuário","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		
		public List<Usuarios> DBBuscar(){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "SELECT ID, NOME, LOGIN FROM USUARIOS ORDER BY ID ASC";
			
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			
			cmd.Connection = conn;
			NpgsqlDataReader reader = cmd.ExecuteReader();
			
			List<Usuarios> lista = new List<Usuarios>();
			
			while(reader.Read())
			{
				Usuarios u = new Usuarios();
				u.id = (Convert.ToInt32(reader["id"]));
				u.nome = (reader["nome"].ToString());
				u.login = (reader["login"].ToString());
				
				lista.Add(u);
			}
			return lista;
		}
		
		public static void DBEditar(Usuarios u){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "UPDATE USUARIOS SET NOME = @n, LOGIN = @l, SENHA = @s WHERE ID = @i";
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("i", u.getId());
			cmd.Parameters.Add("n", u.getNome());
			cmd.Parameters.Add("l", u.getLogin());
			cmd.Parameters.Add("s", u.getSenha());
			
			if(cmd.ExecuteNonQuery() == 1){
				MessageBox.Show("Usuário alterado com sucesso", "Sucesso", MessageBoxButtons.OK);
			}else{
				MessageBox.Show("Erro ao alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public static void DBExcluir(Usuarios u){
			NpgsqlConnection conn = DBConexao.Conectar();
			
			string query = "DELETE FROM USUARIOS WHERE ID = @I";
			NpgsqlCommand cmd = new NpgsqlCommand(query);
			cmd.Connection = conn;
			cmd.Parameters.Add("i", u.getId());
			
			if(cmd.ExecuteNonQuery() == 1){
				MessageBox.Show("Excluído com sucesso!", "Sucesso", MessageBoxButtons.OK);
			}else{
				MessageBox.Show("Erro ao excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
	}
}
