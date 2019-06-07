using System;
using Omega_System.Class.Model;
using System.Data;
using System.Collections.Generic;


namespace Omega_System.Class.Controller
{
	public class Usuarios : DBUsuario
	{
		public int id{get; set;}
		public string nome{get; set;}
		public string login{get; set;}
		private string senha;
		
		public int getId(){
			return this.id;
		}
		
		public string getNome(){
			return this.nome;
		}
		
		public string getLogin(){
			return this.login;
		}
		
		public string getSenha(){
			return this.senha;
		}
		
		public void setId(int id){
			this.id = id;
		}
		
		public void setNome(string nome){
			this.nome = nome;
		}
		
		public void setLogin(string login){
			this.login = login;
		}
		
		public void setSenha(string senha){
			this.senha = senha;
		}
		
		public void Cadastrar(){
			DBUsuario.Inserir(this);
		}
		
		public bool Entrar(){
			//DBUsuario.Entrar(this);
			if(DBUsuario.Entrar(this) == true){
				return true;
			}else{
				return false;
			}
		}
		
		public List<Usuarios> Buscar(){
			return this.DBBuscar();
		}
		
		public void Editar(){
			DBUsuario.DBEditar(this);
		}
		
		public void Deletar(){
			DBUsuario.DBExcluir(this);
		}
		
		public Usuarios()
		{
		}
	}
}
