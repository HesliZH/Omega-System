using System;
using Npgsql;
using System.Windows.Forms;

namespace Omega_System.Class.Controller
{
	public abstract class DBConexao
	{
		
		public DBConexao()
		{
			//return this.Conectar();
		}
		
		public static NpgsqlConnection Conectar(){
			string strConn = "Server=hard.uniguacu.edu.br; Port=5432; Database=2017101508; User Id=2017101508; Password=1508";
			NpgsqlConnection conn = new NpgsqlConnection(strConn);
			
			try{
				conn.Open();
			}catch(NpgsqlException e){
				MessageBox.Show("Erro ao conectar ao banco de dados " + e);
			}
			return conn;
		}
	}
}
