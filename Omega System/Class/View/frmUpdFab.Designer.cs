﻿/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 17/05/2019
 * Time: 20:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmUpdFab
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_editar = new System.Windows.Forms.Button();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_voltar);
			this.groupBox1.Controls.Add(this.btn_editar);
			this.groupBox1.Location = new System.Drawing.Point(44, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 86);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opções";
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(246, 29);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(120, 35);
			this.btn_voltar.TabIndex = 1;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// btn_editar
			// 
			this.btn_editar.Location = new System.Drawing.Point(6, 29);
			this.btn_editar.Name = "btn_editar";
			this.btn_editar.Size = new System.Drawing.Size(120, 35);
			this.btn_editar.TabIndex = 0;
			this.btn_editar.Text = "Editar";
			this.btn_editar.UseVisualStyleBackColor = true;
			this.btn_editar.Click += new System.EventHandler(this.Btn_editarClick);
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(44, 31);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(390, 20);
			this.txt_nome.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 14);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "ID";
			// 
			// txt_id
			// 
			this.txt_id.Enabled = false;
			this.txt_id.Location = new System.Drawing.Point(44, 5);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(100, 20);
			this.txt_id.TabIndex = 7;
			// 
			// frmUpdFab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 155);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txt_nome);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(486, 193);
			this.MinimumSize = new System.Drawing.Size(486, 193);
			this.Name = "frmUpdFab";
			this.Text = "Omega System - Cadastro de fabricante";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.Button btn_editar;
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
