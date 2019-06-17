using System;
using Omega_System.Class.View;
using Omega_System.Class.Model;

namespace Omega_System.Class.Controller
{
	public interface IProdutosController
	{
		void Incluir();
		void Editar(Produtos p);
		void Excluir();
		void Voltar();		
	}
}
