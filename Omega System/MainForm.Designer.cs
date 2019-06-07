/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 04/05/2019
 * Time: 08:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System
{
	partial class MainForm
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
			this.btn_logar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_login = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_logar
			// 
			this.btn_logar.Location = new System.Drawing.Point(55, 196);
			this.btn_logar.Name = "btn_logar";
			this.btn_logar.Size = new System.Drawing.Size(116, 32);
			this.btn_logar.TabIndex = 0;
			this.btn_logar.Text = "Logar";
			this.btn_logar.UseVisualStyleBackColor = true;
			this.btn_logar.Click += new System.EventHandler(this.Btn_logarClick);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Location = new System.Drawing.Point(224, 196);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(127, 32);
			this.btn_cancelar.TabIndex = 1;
			this.btn_cancelar.Text = "Sair";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 33);
			this.label1.TabIndex = 2;
			this.label1.Text = "LOGIN";
			// 
			// txt_login
			// 
			this.txt_login.Location = new System.Drawing.Point(158, 82);
			this.txt_login.Name = "txt_login";
			this.txt_login.Size = new System.Drawing.Size(193, 20);
			this.txt_login.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Usuario:";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(158, 119);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.Size = new System.Drawing.Size(193, 20);
			this.txt_senha.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(55, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Senha:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 313);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_senha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_login);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_logar);
			this.Name = "MainForm";
			this.Text = "Omega System";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_login;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_logar;
	}
}
