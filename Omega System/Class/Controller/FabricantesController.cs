using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class FabricantesController : IFabricanteController
	{
		IFormFabricante view;
		public FabricantesController()
		{
			view = new frmSearchFab();
		}
		
		public void Incluir(){
			this.view.Incluir();
		}
		public void Editar(){
			this.view.Editar();
		}
		public void Excluir(){
			this.view.Excluir();
		}
		public void Filtrar(){
			this.view.Filtrar();
		}
		public void Voltar(){
			this.view.Voltar();
		}
	}
}
