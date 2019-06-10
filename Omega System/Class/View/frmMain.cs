using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Interfaces;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmMain : Form, IFormMain
	{
		IMainController controller;
		public frmMain()
		{
			InitializeComponent();
			controller = new ControleFormularios();
		}
		
		public void Usuarios(){
			frmSearchUsuario f5 = new frmSearchUsuario();
            f5.ShowDialog();
		}
		public void Produtos(){
			frmPro f1 = new frmPro();
            f1.ShowDialog();
		}
		public void Categorias(){
			frmSearchCat f2 = new frmSearchCat();
            f2.ShowDialog();
		}
		public void Fabricantes(){
			frmSearchFab f3 = new frmSearchFab();
            f3.ShowDialog()
		}
		
		void Btn_usuClick(object sender, EventArgs e)
		{
			this.Hide();
			this.controller.Usuarios();
		}
		
		void Btn_cadProdClick(object sender, EventArgs e)
		{
			this.Hide();
			this.controller.Produtos();
		}
		
		void Btn_cadcatClick(object sender, EventArgs e)
		{
			this.Hide();
			this.controller.Categorias();
		}
		
		void Btn_cadfabClick(object sender, EventArgs e)
		{
			this.Hide();
			this.controller.Fabricantes();
		}
	}
}
