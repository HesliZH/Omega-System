/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 04/05/2019
 * Time: 09:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmUsu
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
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.txt_login = new System.Windows.Forms.TextBox();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(49, 46);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(204, 20);
			this.txt_nome.TabIndex = 0;
			// 
			// txt_login
			// 
			this.txt_login.Location = new System.Drawing.Point(49, 87);
			this.txt_login.Name = "txt_login";
			this.txt_login.Size = new System.Drawing.Size(204, 20);
			this.txt_login.TabIndex = 1;
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(49, 126);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.Size = new System.Drawing.Size(204, 20);
			this.txt_senha.TabIndex = 2;
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(16, 24);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(125, 37);
			this.btn_cadastrar.TabIndex = 3;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_senha);
			this.groupBox1.Controls.Add(this.txt_nome);
			this.groupBox1.Controls.Add(this.txt_login);
			this.groupBox1.Location = new System.Drawing.Point(13, 30);
			this.groupBox1.MaximumSize = new System.Drawing.Size(318, 210);
			this.groupBox1.MinimumSize = new System.Drawing.Size(318, 210);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(318, 210);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Cadastrais";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Senha";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuário";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_voltar);
			this.groupBox2.Controls.Add(this.btn_cadastrar);
			this.groupBox2.Location = new System.Drawing.Point(338, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 207);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opções";
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(16, 127);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(125, 40);
			this.btn_voltar.TabIndex = 4;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// frmUsu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 261);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmUsu";
			this.Text = "Omega System - Cadastro de usuários";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.TextBox txt_login;
		private System.Windows.Forms.TextBox txt_nome;
	}
}
