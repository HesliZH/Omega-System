using System;
using Omega_System.Class.Controller;
using System.Collections.Generic;

namespace Omega_System.Class.Model
{
	public class Fabricantes : DBFabricantes
	{	
		public int id{get; set;}
		public string nome{get; set;}
		
		public int getId(){
			return this.id;
		}
		
		public string getNome(){
			return this.nome;
		}
		
		
		public void setId(int id){
			this.id = id;
		}
		
		public void setNome(string nome){
			this.nome = nome;
		}
		
		
		public void Cadastrar(){
			DBFabricantes.Inserir(this);
		}
		
		public List<Fabricantes> Buscar(){
			return this.DBBuscar();
		}
		
		public void Editar(){
			DBFabricantes.DBEditar(this);
		}
		
		public void Deletar(){
			DBFabricantes.DBExcluir(this);
		}
		public Fabricantes()
		{
		}
	}
}
