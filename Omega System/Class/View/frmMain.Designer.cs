/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 04/05/2019
 * Time: 09:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmMain
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
			this.btn_usu = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_cadcat = new System.Windows.Forms.Button();
			this.btn_cadProd = new System.Windows.Forms.Button();
			this.btn_cadfab = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_usu
			// 
			this.btn_usu.Location = new System.Drawing.Point(6, 19);
			this.btn_usu.Name = "btn_usu";
			this.btn_usu.Size = new System.Drawing.Size(115, 67);
			this.btn_usu.TabIndex = 0;
			this.btn_usu.Text = "Cadastro de usuários";
			this.btn_usu.UseVisualStyleBackColor = true;
			this.btn_usu.Click += new System.EventHandler(this.Btn_usuClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_usu);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(619, 92);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pessoas";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_cadfab);
			this.groupBox2.Controls.Add(this.btn_cadcat);
			this.groupBox2.Controls.Add(this.btn_cadProd);
			this.groupBox2.Location = new System.Drawing.Point(12, 126);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(613, 100);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Produtos";
			// 
			// btn_cadcat
			// 
			this.btn_cadcat.Location = new System.Drawing.Point(121, 29);
			this.btn_cadcat.Name = "btn_cadcat";
			this.btn_cadcat.Size = new System.Drawing.Size(112, 65);
			this.btn_cadcat.TabIndex = 1;
			this.btn_cadcat.Text = "Cadastro de categorias de produtos";
			this.btn_cadcat.UseVisualStyleBackColor = true;
			this.btn_cadcat.Click += new System.EventHandler(this.Btn_cadcatClick);
			// 
			// btn_cadProd
			// 
			this.btn_cadProd.Location = new System.Drawing.Point(7, 29);
			this.btn_cadProd.Name = "btn_cadProd";
			this.btn_cadProd.Size = new System.Drawing.Size(108, 65);
			this.btn_cadProd.TabIndex = 0;
			this.btn_cadProd.Text = "Cadastro de Produtos";
			this.btn_cadProd.UseVisualStyleBackColor = true;
			this.btn_cadProd.Click += new System.EventHandler(this.Btn_cadProdClick);
			// 
			// btn_cadfab
			// 
			this.btn_cadfab.Location = new System.Drawing.Point(240, 29);
			this.btn_cadfab.Name = "btn_cadfab";
			this.btn_cadfab.Size = new System.Drawing.Size(112, 65);
			this.btn_cadfab.TabIndex = 2;
			this.btn_cadfab.Text = "Cadastro de fabricantes";
			this.btn_cadfab.UseVisualStyleBackColor = true;
			this.btn_cadfab.Click += new System.EventHandler(this.Btn_cadfabClick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 304);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(660, 342);
			this.MinimumSize = new System.Drawing.Size(660, 342);
			this.Name = "frmMain";
			this.Text = "Omega System";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_cadfab;
		private System.Windows.Forms.Button btn_cadcat;
		private System.Windows.Forms.Button btn_cadProd;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_usu;
	}
}
