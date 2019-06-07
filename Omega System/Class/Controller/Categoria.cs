using System;
using Omega_System.Class.Model;
using System.Collections.Generic;

namespace Omega_System.Class.Controller
{
	public class Categoria : DBCategoria
	{  
		public int id {get;set;}
		public string descricao {get;set;}

		public int getId(){
			return this.id;
		}
       
		public string getDescricao(){
			return this.descricao;
		}
		
		public void setId(int id){
			this.id = id;
		}
		
        public void setDescricao(string descricao){
			this.descricao = descricao;
		}
		
		public void Cadastrar(){
			DBCategoria.Inserir(this);
		}
		
		public List<Categoria> Listar(){
			return DBCategoria.Buscar();
		}
		
		public void Deletar(){
			
		}
		
		public Categoria()
		{
		}
	}
}
