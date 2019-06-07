/*
 * Created by SharpDevelop.
 * User: Zik4Urubu
 * Date: 15/05/2019
 * Time: 13:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmCategoria
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
			this.txt_descricao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_descricao
			// 
			this.txt_descricao.Location = new System.Drawing.Point(12, 38);
			this.txt_descricao.Name = "txt_descricao";
			this.txt_descricao.Size = new System.Drawing.Size(268, 20);
			this.txt_descricao.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Descrição";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "Categorias são agrupadores de produtos para facilitar a filtragem";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_voltar);
			this.groupBox1.Controls.Add(this.btn_cadastrar);
			this.groupBox1.Location = new System.Drawing.Point(328, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 128);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opções";
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(28, 86);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(140, 23);
			this.btn_voltar.TabIndex = 1;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(28, 19);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(140, 23);
			this.btn_cadastrar.TabIndex = 0;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrarClick);
			// 
			// frmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 153);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_descricao);
			this.MaximumSize = new System.Drawing.Size(554, 191);
			this.MinimumSize = new System.Drawing.Size(554, 191);
			this.Name = "frmCategoria";
			this.Text = "Omega System - Cadastro de categoria";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_descricao;
	}
}
