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
	public partial class frmSearchUsuario : Form
	{
		IFormUsuarios i;
		int id;
		public frmSearchUsuario()
		{
			InitializeComponent();
			i = new ControleFormUsuarios();
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
			this.Hide();
			i.IncluiUsuario();
		}
		
		void Dgv_usuariosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Usuarios u = new Usuarios();
			u.setId(Convert.ToInt32(dgv_usuarios.Rows[e.RowIndex].Cells[0].Value));
			u.setNome(Convert.ToString(dgv_usuarios.Rows[e.RowIndex].Cells[1].Value));
			u.setLogin(Convert.ToString(dgv_usuarios.Rows[e.RowIndex].Cells[2].Value));
			
			frmUpdUsu f3 = new frmUpdUsu(u);
			this.Hide();
			f3.ShowDialog();
		}
		
		void Dgv_usuariosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = Convert.ToInt32(dgv_usuarios.Rows[e.RowIndex].Cells[0].Value);
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{
			Usuarios u = new Usuarios();
			u.setId(id);
			u.Deletar();
		}
	}
}
