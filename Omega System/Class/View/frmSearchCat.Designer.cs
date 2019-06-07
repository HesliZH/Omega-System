/*
 * Created by SharpDevelop.
 * User: Zik4Urubu
 * Date: 15/05/2019
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmSearchCat
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
			this.dgv_cat = new System.Windows.Forms.DataGridView();
			this.btn_filtrar = new System.Windows.Forms.Button();
			this.txt_busca = new System.Windows.Forms.TextBox();
			this.btn_incluir = new System.Windows.Forms.Button();
			this.btn_excluir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_cat
			// 
			this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_cat.Location = new System.Drawing.Point(12, 69);
			this.dgv_cat.MultiSelect = false;
			this.dgv_cat.Name = "dgv_cat";
			this.dgv_cat.ReadOnly = true;
			this.dgv_cat.Size = new System.Drawing.Size(364, 181);
			this.dgv_cat.TabIndex = 0;
			// 
			// btn_filtrar
			// 
			this.btn_filtrar.Location = new System.Drawing.Point(301, 40);
			this.btn_filtrar.Name = "btn_filtrar";
			this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
			this.btn_filtrar.TabIndex = 1;
			this.btn_filtrar.Text = "Filtrar";
			this.btn_filtrar.UseVisualStyleBackColor = true;
			this.btn_filtrar.Click += new System.EventHandler(this.Btn_filtrarClick);
			// 
			// txt_busca
			// 
			this.txt_busca.Location = new System.Drawing.Point(12, 40);
			this.txt_busca.Name = "txt_busca";
			this.txt_busca.Size = new System.Drawing.Size(283, 20);
			this.txt_busca.TabIndex = 2;
			// 
			// btn_incluir
			// 
			this.btn_incluir.Location = new System.Drawing.Point(12, 11);
			this.btn_incluir.Name = "btn_incluir";
			this.btn_incluir.Size = new System.Drawing.Size(75, 23);
			this.btn_incluir.TabIndex = 3;
			this.btn_incluir.Text = "Incluir";
			this.btn_incluir.UseVisualStyleBackColor = true;
			this.btn_incluir.Click += new System.EventHandler(this.Btn_incluirClick);
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(94, 11);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(75, 23);
			this.btn_excluir.TabIndex = 4;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.Btn_excluirClick);
			// 
			// frmSearchCat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 262);
			this.Controls.Add(this.btn_excluir);
			this.Controls.Add(this.btn_incluir);
			this.Controls.Add(this.txt_busca);
			this.Controls.Add(this.btn_filtrar);
			this.Controls.Add(this.dgv_cat);
			this.MaximumSize = new System.Drawing.Size(403, 300);
			this.MinimumSize = new System.Drawing.Size(403, 300);
			this.Name = "frmSearchCat";
			this.Text = "Omega System - Cadastro de categorias";
			((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_incluir;
		private System.Windows.Forms.TextBox txt_busca;
		private System.Windows.Forms.Button btn_filtrar;
		private System.Windows.Forms.DataGridView dgv_cat;
	}
}
