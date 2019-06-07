/*
 * Created by SharpDevelop.
 * User: HesliZH
 * Date: 15/05/2019
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Omega_System.Class.View
{
	partial class frmPesquisaCat
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
			((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_cat
			// 
			this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_cat.Location = new System.Drawing.Point(13, 53);
			this.dgv_cat.MultiSelect = false;
			this.dgv_cat.Name = "dgv_cat";
			this.dgv_cat.ReadOnly = true;
			this.dgv_cat.Size = new System.Drawing.Size(403, 197);
			this.dgv_cat.TabIndex = 0;
			this.dgv_cat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_catCellDoubleClick);
			// 
			// btn_filtrar
			// 
			this.btn_filtrar.Location = new System.Drawing.Point(169, 13);
			this.btn_filtrar.Name = "btn_filtrar";
			this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
			this.btn_filtrar.TabIndex = 1;
			this.btn_filtrar.Text = "Filtrar";
			this.btn_filtrar.UseVisualStyleBackColor = true;
			this.btn_filtrar.Click += new System.EventHandler(this.Btn_filtrarClick);
			// 
			// frmPesquisaCat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 262);
			this.Controls.Add(this.btn_filtrar);
			this.Controls.Add(this.dgv_cat);
			this.MaximumSize = new System.Drawing.Size(444, 300);
			this.MinimumSize = new System.Drawing.Size(444, 300);
			this.Name = "frmPesquisaCat";
			this.Text = "Omega System - Pesquisa de categorias";
			((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_filtrar;
		private System.Windows.Forms.DataGridView dgv_cat;
	}
}
