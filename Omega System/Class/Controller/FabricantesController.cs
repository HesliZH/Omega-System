using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class FabricantesController : IFabricanteController
	{
		IFormFabricante controller;
		public FabricantesController()
		{
			i = new frmSearchFab();
		}
		
		public void Incluir(){
			this.controller.Incluir();
		}
		public void Editar(){
			this.controller.Editar();
		}
		public void Excluir(){
			this.controller.Excluir();
		}
		public void Filtrar(){
			this.controller.Filtrar();
		}
		public void Voltar(){
			this.controller.Voltar();
		}
	}
}
