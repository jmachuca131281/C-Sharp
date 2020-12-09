namespace VideoTiendaWF.Views
{
    partial class FrmDominios
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
            this.GbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtVrldominio = new System.Windows.Forms.TextBox();
            this.txtDominioId = new System.Windows.Forms.TextBox();
            this.txtTipoDominio = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblIdDominio = new System.Windows.Forms.Label();
            this.lblVlrDominio = new System.Windows.Forms.Label();
            this.GbxDatos = new System.Windows.Forms.GroupBox();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnElliminar = new System.Windows.Forms.Button();
            this.GbxFiltros.SuspendLayout();
            this.GbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxFiltros
            // 
            this.GbxFiltros.Controls.Add(this.btnBuscar);
            this.GbxFiltros.Controls.Add(this.btnLimpiar);
            this.GbxFiltros.Controls.Add(this.txtVrldominio);
            this.GbxFiltros.Controls.Add(this.txtDominioId);
            this.GbxFiltros.Controls.Add(this.txtTipoDominio);
            this.GbxFiltros.Controls.Add(this.lblid);
            this.GbxFiltros.Controls.Add(this.lblIdDominio);
            this.GbxFiltros.Controls.Add(this.lblVlrDominio);
            this.GbxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxFiltros.Location = new System.Drawing.Point(12, 12);
            this.GbxFiltros.Name = "GbxFiltros";
            this.GbxFiltros.Size = new System.Drawing.Size(559, 118);
            this.GbxFiltros.TabIndex = 0;
            this.GbxFiltros.TabStop = false;
            this.GbxFiltros.Text = "Filtro Bùsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(308, 77);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtVrldominio
            // 
            this.txtVrldominio.Location = new System.Drawing.Point(389, 21);
            this.txtVrldominio.Name = "txtVrldominio";
            this.txtVrldominio.Size = new System.Drawing.Size(100, 21);
            this.txtVrldominio.TabIndex = 1;
            // 
            // txtDominioId
            // 
            this.txtDominioId.Location = new System.Drawing.Point(109, 48);
            this.txtDominioId.Name = "txtDominioId";
            this.txtDominioId.Size = new System.Drawing.Size(100, 21);
            this.txtDominioId.TabIndex = 1;
            // 
            // txtTipoDominio
            // 
            this.txtTipoDominio.Location = new System.Drawing.Point(109, 21);
            this.txtTipoDominio.Name = "txtTipoDominio";
            this.txtTipoDominio.Size = new System.Drawing.Size(100, 21);
            this.txtTipoDominio.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(285, 24);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(98, 15);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Valor Dominio";
            // 
            // lblIdDominio
            // 
            this.lblIdDominio.AutoSize = true;
            this.lblIdDominio.Location = new System.Drawing.Point(9, 48);
            this.lblIdDominio.Name = "lblIdDominio";
            this.lblIdDominio.Size = new System.Drawing.Size(79, 15);
            this.lblIdDominio.TabIndex = 0;
            this.lblIdDominio.Text = "ID Dominio";
            // 
            // lblVlrDominio
            // 
            this.lblVlrDominio.AutoSize = true;
            this.lblVlrDominio.Location = new System.Drawing.Point(8, 21);
            this.lblVlrDominio.Name = "lblVlrDominio";
            this.lblVlrDominio.Size = new System.Drawing.Size(93, 15);
            this.lblVlrDominio.TabIndex = 0;
            this.lblVlrDominio.Text = "Tipo Dominio";
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.DgvDatos);
            this.GbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDatos.Location = new System.Drawing.Point(12, 136);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.Size = new System.Drawing.Size(559, 209);
            this.GbxDatos.TabIndex = 0;
            this.GbxDatos.TabStop = false;
            this.GbxDatos.Text = "Dominios";
            // 
            // DgvDatos
            // 
            this.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDatos.Location = new System.Drawing.Point(3, 17);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.Size = new System.Drawing.Size(553, 189);
            this.DgvDatos.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(14, 353);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(230, 353);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(346, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnElliminar
            // 
            this.btnElliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElliminar.Location = new System.Drawing.Point(467, 351);
            this.btnElliminar.Name = "btnElliminar";
            this.btnElliminar.Size = new System.Drawing.Size(100, 30);
            this.btnElliminar.TabIndex = 4;
            this.btnElliminar.Text = "Eliminar";
            this.btnElliminar.UseVisualStyleBackColor = true;
            // 
            // FrmDominios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 431);
            this.ControlBox = false;
            this.Controls.Add(this.btnElliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.GbxDatos);
            this.Controls.Add(this.GbxFiltros);
            this.Name = "FrmDominios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDeDominios";
            this.Load += new System.EventHandler(this.FrmDominios_Load);
            this.GbxFiltros.ResumeLayout(false);
            this.GbxFiltros.PerformLayout();
            this.GbxDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxFiltros;
        private System.Windows.Forms.GroupBox GbxDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtVrldominio;
        private System.Windows.Forms.TextBox txtDominioId;
        private System.Windows.Forms.TextBox txtTipoDominio;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblIdDominio;
        private System.Windows.Forms.Label lblVlrDominio;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnElliminar;
    }
}