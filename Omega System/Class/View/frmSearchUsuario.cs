using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using System.Collections.Generic;
using System.Data;
using Omega_System.Class.Interfaces;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmSearchUsuario : Form, IFormUsuarios
	{
		int id;
		IUsuarioController controller;
		Usuarios u;
		public frmSearchUsuario()
		{
			InitializeComponent();
			u = new Usuarios();
			controller = new UsuariosController();
		}
		
		public void Incluir(){
			this.Hide();
			u.Cadastrar();	
		}
		
		public void Editar(){
			frmUpdUsu f3 = new frmUpdUsu(u);
			this.Hide();
			f3.ShowDialog();
		}
		
		public void Excluir(){
			Usuarios u = new Usuarios();
			u.setId(id);
			u.Deletar();
		}
		
		public void Voltar(){
		
		}
		
		void Btn_pesquisarClick(object sender, EventArgs e)
		{
			Usuarios u = new Usuarios();
			this.dgv_usuarios.DataSource = u.Buscar();	
		}
			
		void FrmSearchUsuarioLoad(object sender, EventArgs e)
		{
		
		}
		
		void Btn_incluirClick(object sender, EventArgs e)
		{
			this.controller.Incluir();
		}
		
		void Dgv_usuariosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			u.setId(Convert.ToInt32(dgv_usuarios.Rows[e.RowIndex].Cells[0].Value));
			u.setNome(Convert.ToString(dgv_usuarios.Rows[e.RowIndex].Cells[1].Value));
			u.setLogin(Convert.ToString(dgv_usuarios.Rows[e.RowIndex].Cells[2].Value));
		}
		
		void Dgv_usuariosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = Convert.ToInt32(dgv_usuarios.Rows[e.RowIndex].Cells[0].Value);
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{
			
		}
	}
}
