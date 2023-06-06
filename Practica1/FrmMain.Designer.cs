namespace Practica1
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNouBloc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNouBloc
            // 
            this.btnNouBloc.BackColor = System.Drawing.Color.Yellow;
            this.btnNouBloc.Location = new System.Drawing.Point(13, 13);
            this.btnNouBloc.Name = "btnNouBloc";
            this.btnNouBloc.Size = new System.Drawing.Size(89, 34);
            this.btnNouBloc.TabIndex = 0;
            this.btnNouBloc.Text = "Nou Bloc";
            this.btnNouBloc.UseVisualStyleBackColor = false;
            this.btnNouBloc.Click += new System.EventHandler(this.btnNouBloc_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 525);
            this.Controls.Add(this.btnNouBloc);
            this.Name = "FrmMain";
            this.Text = "Pagina Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNouBloc;
    }
}

