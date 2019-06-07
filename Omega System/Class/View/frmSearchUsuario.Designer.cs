/*
 * Created by SharpDevelop.
 * User: Zik4Urubu
 * Date: 06/05/2019
 * Time: 13:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmSearchUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv_usuarios = new System.Windows.Forms.DataGridView();
			this.txt_pesquisa = new System.Windows.Forms.TextBox();
			this.btn_pesquisar = new System.Windows.Forms.Button();
			this.btn_incluir = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_usuarios
			// 
			this.dgv_usuarios.AllowUserToAddRows = false;
			this.dgv_usuarios.AllowUserToDeleteRows = false;
			this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_usuarios.Location = new System.Drawing.Point(12, 79);
			this.dgv_usuarios.MultiSelect = false;
			this.dgv_usuarios.Name = "dgv_usuarios";
			this.dgv_usuarios.ReadOnly = true;
			this.dgv_usuarios.Size = new System.Drawing.Size(504, 239);
			this.dgv_usuarios.TabIndex = 0;
			this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuariosCellClick);
			this.dgv_usuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuariosCellContentDoubleClick);
			// 
			// txt_pesquisa
			// 
			this.txt_pesquisa.Location = new System.Drawing.Point(12, 53);
			this.txt_pesquisa.Name = "txt_pesquisa";
			this.txt_pesquisa.Size = new System.Drawing.Size(398, 20);
			this.txt_pesquisa.TabIndex = 1;
			// 
			// btn_pesquisar
			// 
			this.btn_pesquisar.Location = new System.Drawing.Point(417, 50);
			this.btn_pesquisar.Name = "btn_pesquisar";
			this.btn_pesquisar.Size = new System.Drawing.Size(99, 23);
			this.btn_pesquisar.TabIndex = 2;
			this.btn_pesquisar.Text = "Pesquisar";
			this.btn_pesquisar.UseVisualStyleBackColor = true;
			this.btn_pesquisar.Click += new System.EventHandler(this.Btn_pesquisarClick);
			// 
			// btn_incluir
			// 
			this.btn_incluir.Location = new System.Drawing.Point(13, 12);
			this.btn_incluir.Name = "btn_incluir";
			this.btn_incluir.Size = new System.Drawing.Size(83, 35);
			this.btn_incluir.TabIndex = 3;
			this.btn_incluir.Text = "Incluir";
			this.btn_incluir.UseVisualStyleBackColor = true;
			this.btn_incluir.Click += new System.EventHandler(this.Btn_incluirClick);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(103, 12);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(91, 35);
			this.btn_excluir.TabIndex = 4;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.Btn_excluirClick);
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(201, 12);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(93, 35);
			this.btn_voltar.TabIndex = 5;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			// 
			// frmSearchUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 330);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_incluir);
			this.Controls.Add(this.btn_pesquisar);
			this.Controls.Add(this.txt_pesquisa);
			this.Controls.Add(this.dgv_usuarios);
			this.MaximumSize = new System.Drawing.Size(550, 368);
			this.MinimumSize = new System.Drawing.Size(550, 368);
			this.Name = "frmSearchUsuario";
			this.Text = "Omega System - Listagem de usuários";
			this.Load += new System.EventHandler(this.FrmSearchUsuarioLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_incluir;
		private System.Windows.Forms.Button btn_pesquisar;
		private System.Windows.Forms.TextBox txt_pesquisa;
		private System.Windows.Forms.DataGridView dgv_usuarios;
	}
}
