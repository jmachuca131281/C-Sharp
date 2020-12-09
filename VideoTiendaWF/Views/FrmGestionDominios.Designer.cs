namespace VideoTiendaWF.Views
{
    partial class PnlDominios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoDominio = new System.Windows.Forms.Label();
            this.lblIdDominio = new System.Windows.Forms.Label();
            this.lblVlrDominio = new System.Windows.Forms.Label();
            this.txtTipoDominio = new System.Windows.Forms.TextBox();
            this.txtIdDominio = new System.Windows.Forms.TextBox();
            this.txtvlrDomino = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtvlrDomino);
            this.panel1.Controls.Add(this.txtIdDominio);
            this.panel1.Controls.Add(this.txtTipoDominio);
            this.panel1.Controls.Add(this.lblVlrDominio);
            this.panel1.Controls.Add(this.lblIdDominio);
            this.panel1.Controls.Add(this.lblTipoDominio);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 167);
            this.panel1.TabIndex = 0;
            // 
            // lblTipoDominio
            // 
            this.lblTipoDominio.AutoSize = true;
            this.lblTipoDominio.Location = new System.Drawing.Point(17, 15);
            this.lblTipoDominio.Name = "lblTipoDominio";
            this.lblTipoDominio.Size = new System.Drawing.Size(97, 15);
            this.lblTipoDominio.TabIndex = 0;
            this.lblTipoDominio.Text = "Topo Dominio";
            // 
            // lblIdDominio
            // 
            this.lblIdDominio.AutoSize = true;
            this.lblIdDominio.Location = new System.Drawing.Point(17, 46);
            this.lblIdDominio.Name = "lblIdDominio";
            this.lblIdDominio.Size = new System.Drawing.Size(77, 15);
            this.lblIdDominio.TabIndex = 0;
            this.lblIdDominio.Text = "Id Dominio";
            // 
            // lblVlrDominio
            // 
            this.lblVlrDominio.AutoSize = true;
            this.lblVlrDominio.Location = new System.Drawing.Point(17, 83);
            this.lblVlrDominio.Name = "lblVlrDominio";
            this.lblVlrDominio.Size = new System.Drawing.Size(98, 15);
            this.lblVlrDominio.TabIndex = 0;
            this.lblVlrDominio.Text = "Valor Dominio";
            // 
            // txtTipoDominio
            // 
            this.txtTipoDominio.Location = new System.Drawing.Point(166, 15);
            this.txtTipoDominio.Name = "txtTipoDominio";
            this.txtTipoDominio.Size = new System.Drawing.Size(200, 21);
            this.txtTipoDominio.TabIndex = 1;
            // 
            // txtIdDominio
            // 
            this.txtIdDominio.Location = new System.Drawing.Point(166, 46);
            this.txtIdDominio.Name = "txtIdDominio";
            this.txtIdDominio.Size = new System.Drawing.Size(200, 21);
            this.txtIdDominio.TabIndex = 2;
            // 
            // txtvlrDomino
            // 
            this.txtvlrDomino.Location = new System.Drawing.Point(166, 75);
            this.txtvlrDomino.Name = "txtvlrDomino";
            this.txtvlrDomino.Size = new System.Drawing.Size(200, 21);
            this.txtvlrDomino.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(85, 125);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // PnlDominios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 199);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "PnlDominios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Dominios";
            this.Load += new System.EventHandler(this.PnlDominios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtvlrDomino;
        private System.Windows.Forms.TextBox txtIdDominio;
        private System.Windows.Forms.TextBox txtTipoDominio;
        private System.Windows.Forms.Label lblVlrDominio;
        private System.Windows.Forms.Label lblIdDominio;
        private System.Windows.Forms.Label lblTipoDominio;
    }
}