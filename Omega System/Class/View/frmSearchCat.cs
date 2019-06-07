using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using System.Data;
using System.Collections.Generic;

namespace Omega_System.Class.View
{
	public partial class frmSearchCat : Form
	{
		public frmSearchCat()
		{
			InitializeComponent();
		}
		
		void Btn_filtrarClick(object sender, EventArgs e)
		{
			Categoria c = new Categoria();
			this.dgv_cat.DataSource = c.Listar();
		}
		
		void Btn_incluirClick(object sender, EventArgs e)
		{
			frmCategoria f1 = new frmCategoria();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{

		}
	}
}
