/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 07/05/2019
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmUpdUsu
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.LBL_idi = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.txt_login = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_voltar);
			this.groupBox2.Controls.Add(this.btn_editar);
			this.groupBox2.Location = new System.Drawing.Point(346, 25);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 207);
			this.groupBox2.TabIndex = 7;
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
			// btn_editar
			// 
			this.btn_editar.Location = new System.Drawing.Point(16, 24);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(125, 37);
			this.btn_editar.TabIndex = 3;
			this.btn_editar.Text = "Editar";
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.Btn_editarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_id);
			this.groupBox1.Controls.Add(this.LBL_idi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_senha);
			this.groupBox1.Controls.Add(this.txt_nome);
			this.groupBox1.Controls.Add(this.txt_login);
			this.groupBox1.Location = new System.Drawing.Point(21, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(318, 210);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Cadastrais";
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(49, 29);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(204, 20);
			this.txt_id.TabIndex = 5;
			// 
			// LBL_idi
			// 
			this.LBL_idi.Enabled = false;
			this.LBL_idi.Location = new System.Drawing.Point(7, 32);
			this.LBL_idi.Name = "LBL_idi";
			this.LBL_idi.Size = new System.Drawing.Size(42, 12);
			this.LBL_idi.TabIndex = 4;
			this.LBL_idi.Text = "ID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Senha";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuário";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(49, 142);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.Size = new System.Drawing.Size(204, 20);
			this.txt_senha.TabIndex = 2;
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(49, 62);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(204, 20);
			this.txt_nome.TabIndex = 0;
			// 
			// txt_login
			// 
			this.txt_login.Location = new System.Drawing.Point(49, 103);
			this.txt_login.Name = "txt_login";
			this.txt_login.Size = new System.Drawing.Size(204, 20);
			this.txt_login.TabIndex = 1;
			// 
			// frmUpdUsu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 260);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(554, 298);
			this.MinimumSize = new System.Drawing.Size(554, 298);
			this.Name = "frmUpdUsu";
			this.Text = "frmUpdUsu";
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label LBL_idi;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.TextBox txt_login;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
