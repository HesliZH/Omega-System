/*
 * Created by SharpDevelop.
 * User: Zik4Urubu
 * Date: 17/06/2019
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmSearchProdutos
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
			this.btn_incluir = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.dgv_produtos = new System.Windows.Forms.DataGridView();
			this.btn_voltar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_incluir
			// 
			this.btn_incluir.Location = new System.Drawing.Point(13, 13);
			this.btn_incluir.Name = "btn_incluir";
			this.btn_incluir.Size = new System.Drawing.Size(75, 23);
			this.btn_incluir.TabIndex = 0;
			this.btn_incluir.Text = "Incluir";
			this.btn_incluir.UseVisualStyleBackColor = true;
			this.btn_incluir.Click += new System.EventHandler(this.Btn_incluirClick);
			// 
			// btn_editar
			// 
			this.btn_editar.Location = new System.Drawing.Point(95, 13);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(75, 23);
			this.btn_editar.TabIndex = 1;
			this.btn_editar.Text = "Editar";
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.Btn_editarClick);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(177, 13);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(75, 23);
			this.btn_excluir.TabIndex = 2;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.Btn_excluirClick);
			// 
			// dgv_produtos
			// 
			this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_produtos.Location = new System.Drawing.Point(13, 65);
			this.dgv_produtos.Name = "dgv_produtos";
			this.dgv_produtos.Size = new System.Drawing.Size(419, 185);
			this.dgv_produtos.TabIndex = 3;
			this.dgv_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(259, 13);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(75, 23);
			this.btn_voltar.TabIndex = 4;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// frmSearchProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 262);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.dgv_produtos);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_editar);
			this.Controls.Add(this.btn_incluir);
			this.Name = "frmSearchProdutos";
			this.Text = "frmSearchProdutos";
			((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.DataGridView dgv_produtos;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_incluir;
	}
}
