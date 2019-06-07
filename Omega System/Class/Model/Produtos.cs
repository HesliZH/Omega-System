using System;
using System.Data;
using Omega_System.Class.Controller;

namespace Omega_System.Class.Model
{
	public class Produtos : DBProdutos
	{
		private int codigo{get; set;}
		private string descricao{get; set;}
		private string marca{get; set;}
		private double venda{get; set;}
		private double qtd{get; set;}
		private string categoria{get; set;}
		
		public int getCodigo(){
			return this.codigo;
		}
		
		public string getDescricao(){
			return this.descricao;
		}
		
		public string getMarca(){
			return this.marca;
		}
		
		public double getVenda(){
			return this.venda;
		}
		
		public double getQtd(){
			return this.qtd;
		}
		
		public string getCategoria(){
			return this.categoria;
		}
		
		public void setCodigo(int codigo){
			this.codigo = codigo;
		}
		
		public void setDescricao(string descricao){
			this.descricao = descricao;
		}
		
		public void setMarca(string marca){
			this.marca = marca;
		}
		
		public void setVenda(double venda){
			this.venda = venda;
		}
		
		public void setQtd(double qtd){
			this.qtd = qtd;
		}
		
		public void setCategoria(string categoria){
			this.categoria = categoria;
		}
		
		public void Cadastrar(){
		    DBProdutos.Inserir(this);
		}
		public Produtos()
		{
		}
	}
}
