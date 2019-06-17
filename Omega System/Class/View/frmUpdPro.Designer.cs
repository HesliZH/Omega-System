/*
 * Created by SharpDevelop.
 * User: Zik4Urubu
 * Date: 17/06/2019
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmUpdPro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdPro));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_procucat = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_fabricante = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_qtd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_valor = new System.Windows.Forms.TextBox();
			this.txt_cat = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_descricao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_cadpro = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_procucat);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_fabricante);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_qtd);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_valor);
			this.groupBox1.Controls.Add(this.txt_cat);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_descricao);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(418, 237);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados para cadastro";
			// 
			// btn_procucat
			// 
			this.btn_procucat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_procucat.BackgroundImage")));
			this.btn_procucat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_procucat.Location = new System.Drawing.Point(194, 59);
			this.btn_procucat.Name = "btn_procucat";
			this.btn_procucat.Size = new System.Drawing.Size(63, 46);
			this.btn_procucat.TabIndex = 10;
			this.btn_procucat.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(197, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Fabricante";
			// 
			// txt_fabricante
			// 
			this.txt_fabricante.Enabled = false;
			this.txt_fabricante.Location = new System.Drawing.Point(263, 122);
			this.txt_fabricante.Name = "txt_fabricante";
			this.txt_fabricante.Size = new System.Drawing.Size(100, 20);
			this.txt_fabricante.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Quantidade em estoque";
			// 
			// txt_qtd
			// 
			this.txt_qtd.Location = new System.Drawing.Point(123, 170);
			this.txt_qtd.Name = "txt_qtd";
			this.txt_qtd.Size = new System.Drawing.Size(100, 20);
			this.txt_qtd.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 36);
			this.label3.TabIndex = 5;
			this.label3.Text = "Preço de venda";
			// 
			// txt_valor
			// 
			this.txt_valor.Location = new System.Drawing.Point(68, 122);
			this.txt_valor.Name = "txt_valor";
			this.txt_valor.Size = new System.Drawing.Size(86, 20);
			this.txt_valor.TabIndex = 4;
			// 
			// txt_cat
			// 
			this.txt_cat.Enabled = false;
			this.txt_cat.Location = new System.Drawing.Point(68, 76);
			this.txt_cat.Name = "txt_cat";
			this.txt_cat.Size = new System.Drawing.Size(121, 20);
			this.txt_cat.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Categoria";
			// 
			// txt_descricao
			// 
			this.txt_descricao.Location = new System.Drawing.Point(67, 25);
			this.txt_descricao.Name = "txt_descricao";
			this.txt_descricao.Size = new System.Drawing.Size(251, 20);
			this.txt_descricao.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_voltar);
			this.groupBox2.Controls.Add(this.btn_cadpro);
			this.groupBox2.Location = new System.Drawing.Point(437, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 237);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opções";
			// 
			// btn_voltar
			// 
			this.btn_voltar.Location = new System.Drawing.Point(35, 170);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(135, 53);
			this.btn_voltar.TabIndex = 2;
			this.btn_voltar.Text = "Voltar";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// btn_cadpro
			// 
			this.btn_cadpro.Location = new System.Drawing.Point(35, 28);
			this.btn_cadpro.Name = "btn_cadpro";
			this.btn_cadpro.Size = new System.Drawing.Size(135, 49);
			this.btn_cadpro.TabIndex = 1;
			this.btn_cadpro.Text = "Cadastrar";
			this.btn_cadpro.UseVisualStyleBackColor = true;
			this.btn_cadpro.Click += new System.EventHandler(this.Btn_cadproClick);
			// 
			// frmUpdPro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 261);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "frmUpdPro";
			this.Text = "frmUpdPro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_cadpro;
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_descricao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_cat;
		private System.Windows.Forms.TextBox txt_valor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_qtd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_fabricante;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_procucat;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
