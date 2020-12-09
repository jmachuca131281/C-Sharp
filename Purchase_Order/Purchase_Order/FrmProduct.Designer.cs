
namespace Purchase_Order
{
    partial class FrmProduct
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
            this.components = new System.ComponentModel.Container();
            this.cbxIva = new System.Windows.Forms.ComboBox();
            this.cbxProvider = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pURCHASE_ORDERDataSet = new Purchase_Order.PURCHASE_ORDERDataSet();
            this.cATEGORYSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYSTableAdapter = new Purchase_Order.PURCHASE_ORDERDataSetTableAdapters.CATEGORYSTableAdapter();
            this.cATEGORYSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYSBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASE_ORDERDataSet2 = new Purchase_Order.PURCHASE_ORDERDataSet2();
            this.pROVIDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVIDERSTableAdapter = new Purchase_Order.PURCHASE_ORDERDataSet2TableAdapters.PROVIDERSTableAdapter();
            this.pURCHASEORDERDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASE_ORDERDataSet3 = new Purchase_Order.PURCHASE_ORDERDataSet3();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVATableAdapter = new Purchase_Order.PURCHASE_ORDERDataSet3TableAdapters.IVATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASE_ORDERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASE_ORDERDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEORDERDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASE_ORDERDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIva
            // 
            this.cbxIva.DataSource = this.iVABindingSource;
            this.cbxIva.DisplayMember = "percent";
            this.cbxIva.FormattingEnabled = true;
            this.cbxIva.Location = new System.Drawing.Point(136, 121);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Size = new System.Drawing.Size(130, 21);
            this.cbxIva.TabIndex = 4;
            this.cbxIva.ValueMember = "percent";
            // 
            // cbxProvider
            // 
            this.cbxProvider.DataSource = this.pROVIDERSBindingSource;
            this.cbxProvider.DisplayMember = "provider";
            this.cbxProvider.FormattingEnabled = true;
            this.cbxProvider.Location = new System.Drawing.Point(136, 68);
            this.cbxProvider.Name = "cbxProvider";
            this.cbxProvider.Size = new System.Drawing.Size(130, 21);
            this.cbxProvider.TabIndex = 2;
            this.cbxProvider.ValueMember = "provider";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DataSource = this.cATEGORYSBindingSource;
            this.cbxCategory.DisplayMember = "category";
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(136, 44);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(130, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.ValueMember = "category";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(136, 148);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(130, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "IVA";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Provider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Category";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 18);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(130, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Description";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(144, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(25, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pURCHASE_ORDERDataSet
            // 
            this.pURCHASE_ORDERDataSet.DataSetName = "PURCHASE_ORDERDataSet";
            this.pURCHASE_ORDERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYSBindingSource
            // 
            this.cATEGORYSBindingSource.DataMember = "CATEGORYS";
            this.cATEGORYSBindingSource.DataSource = this.pURCHASE_ORDERDataSet;
            // 
            // cATEGORYSTableAdapter
            // 
            this.cATEGORYSTableAdapter.ClearBeforeFill = true;
            // 
            // cATEGORYSBindingSource1
            // 
            this.cATEGORYSBindingSource1.DataMember = "CATEGORYS";
            this.cATEGORYSBindingSource1.DataSource = this.pURCHASE_ORDERDataSet;
            // 
            // cATEGORYSBindingSource2
            // 
            this.cATEGORYSBindingSource2.DataMember = "CATEGORYS";
            this.cATEGORYSBindingSource2.DataSource = this.pURCHASE_ORDERDataSet;
            // 
            // cATEGORYSBindingSource3
            // 
            this.cATEGORYSBindingSource3.DataMember = "CATEGORYS";
            this.cATEGORYSBindingSource3.DataSource = this.pURCHASE_ORDERDataSet;
            // 
            // pURCHASE_ORDERDataSet2
            // 
            this.pURCHASE_ORDERDataSet2.DataSetName = "PURCHASE_ORDERDataSet2";
            this.pURCHASE_ORDERDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVIDERSBindingSource
            // 
            this.pROVIDERSBindingSource.DataMember = "PROVIDERS";
            this.pROVIDERSBindingSource.DataSource = this.pURCHASE_ORDERDataSet2;
            // 
            // pROVIDERSTableAdapter
            // 
            this.pROVIDERSTableAdapter.ClearBeforeFill = true;
            // 
            // pURCHASEORDERDataSet2BindingSource
            // 
            this.pURCHASEORDERDataSet2BindingSource.DataSource = this.pURCHASE_ORDERDataSet2;
            this.pURCHASEORDERDataSet2BindingSource.Position = 0;
            // 
            // pURCHASE_ORDERDataSet3
            // 
            this.pURCHASE_ORDERDataSet3.DataSetName = "PURCHASE_ORDERDataSet3";
            this.pURCHASE_ORDERDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.pURCHASE_ORDERDataSet3;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 245);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxIva);
            this.Controls.Add(this.cbxProvider);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASE_ORDERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYSBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASE_ORDERDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEORDERDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASE_ORDERDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIva;
        private System.Windows.Forms.ComboBox cbxProvider;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private PURCHASE_ORDERDataSet pURCHASE_ORDERDataSet;
        private System.Windows.Forms.BindingSource cATEGORYSBindingSource;
        private PURCHASE_ORDERDataSetTableAdapters.CATEGORYSTableAdapter cATEGORYSTableAdapter;
        private System.Windows.Forms.BindingSource cATEGORYSBindingSource2;
        private System.Windows.Forms.BindingSource cATEGORYSBindingSource1;
        private System.Windows.Forms.BindingSource cATEGORYSBindingSource3;
        private PURCHASE_ORDERDataSet2 pURCHASE_ORDERDataSet2;
        private System.Windows.Forms.BindingSource pROVIDERSBindingSource;
        private PURCHASE_ORDERDataSet2TableAdapters.PROVIDERSTableAdapter pROVIDERSTableAdapter;
        private System.Windows.Forms.BindingSource pURCHASEORDERDataSet2BindingSource;
        private PURCHASE_ORDERDataSet3 pURCHASE_ORDERDataSet3;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private PURCHASE_ORDERDataSet3TableAdapters.IVATableAdapter iVATableAdapter;
    }
}