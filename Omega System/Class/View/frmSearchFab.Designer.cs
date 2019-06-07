/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 17/05/2019
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmSearchFab
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
			this.dgv_fab = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_excluir = new System.Windows.Forms.Button();
			this.btn_incluir = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_filtrar = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_fab)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_fab
			// 
			this.dgv_fab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_fab.Location = new System.Drawing.Point(12, 115);
			this.dgv_fab.MultiSelect = false;
			this.dgv_fab.Name = "dgv_fab";
			this.dgv_fab.ReadOnly = true;
			this.dgv_fab.Size = new System.Drawing.Size(509, 226);
			this.dgv_fab.TabIndex = 0;
			this.dgv_fab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_fabCellClick);
			this.dgv_fab.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_fabCellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_voltar);
			this.groupBox1.Controls.Add(this.btn_excluir);
			this.groupBox1.Controls.Add(this.btn_incluir);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(508, 49);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opções";
			// 
			// btn_excluir
			// 
			this.btn_excluir.Location = new System.Drawing.Point(105, 20);
			this.btn_excluir.Name = "btn_excluir";
			this.btn_excluir.Size = new System.Drawing.Size(75, 23);
			this.btn_excluir.TabIndex = 1;
			this.btn_excluir.Text = "Excluir";
			this.btn_excluir.UseVisualStyleBackColor = true;
			this.btn_excluir.Click += new System.EventHandler(this.Btn_excluirClick);
			// 
			// btn_incluir
			// 
			this.btn_incluir.Location = new System.Drawing.Point(15, 20);
			this.btn_incluir.Name = "btn_incluir";
			this.btn_incluir.Size = new System.Drawing.Size(75, 23);
			this.btn_incluir.TabIndex = 0;
			this.btn_incluir.Text = "Incluir";
			this.btn_incluir.UseVisualStyleBackColor = true;
			this.btn_incluir.Click += new System.EventHandler(this.Btn_incluirClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 79);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(410, 20);
			this.textBox1.TabIndex = 2;
			// 
			// btn_filtrar
			// 
			this.btn_filtrar.Location = new System.Drawing.Point(446, 76);
			this.btn_filtrar.Name = "btn_filtrar";
			this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
			this.btn_filtrar.TabIndex = 3;
			this.btn_filtrar.Text = "Filtrar";
			this.btn_filtrar.UseVisualStyleBackColor = true;
			this.btn_filtrar.Click += new System.EventHandler(this.Btn_filtrarClick);
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(197, 20);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(75, 23);
			this.btn_voltar.TabIndex = 2;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// frmSearchFab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 353);
			this.Controls.Add(this.btn_filtrar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgv_fab);
			this.Name = "frmSearchFab";
			this.Text = "Omega System - Cadastro de fabricantes";
			((System.ComponentModel.ISupportInitialize)(this.dgv_fab)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.Button btn_excluir;
		private System.Windows.Forms.Button btn_incluir;
		private System.Windows.Forms.Button btn_filtrar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgv_fab;
	}
}
