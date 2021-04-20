
namespace CarsProject2021
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InputId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputModel = new System.Windows.Forms.TextBox();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblBrand = new System.Windows.Forms.Label();
            this.InputBrandId = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.CbHasInsurance = new System.Windows.Forms.CheckBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputId.Location = new System.Drawing.Point(139, 65);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(161, 32);
            this.InputId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // InputModel
            // 
            this.InputModel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputModel.Location = new System.Drawing.Point(139, 108);
            this.InputModel.Name = "InputModel";
            this.InputModel.Size = new System.Drawing.Size(161, 32);
            this.InputModel.TabIndex = 3;
            // 
            // InputYear
            // 
            this.InputYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputYear.Location = new System.Drawing.Point(139, 146);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(161, 32);
            this.InputYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBrand.Location = new System.Drawing.Point(50, 190);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(62, 25);
            this.LblBrand.TabIndex = 6;
            this.LblBrand.Text = "Brand";
            // 
            // InputBrandId
            // 
            this.InputBrandId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputBrandId.FormattingEnabled = true;
            this.InputBrandId.Location = new System.Drawing.Point(139, 187);
            this.InputBrandId.Name = "InputBrandId";
            this.InputBrandId.Size = new System.Drawing.Size(162, 33);
            this.InputBrandId.TabIndex = 7;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(12, 282);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(91, 34);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // CarGridView
            // 
            this.CarGridView.AllowUserToAddRows = false;
            this.CarGridView.AllowUserToDeleteRows = false;
            this.CarGridView.AllowUserToResizeColumns = false;
            this.CarGridView.AllowUserToResizeRows = false;
            this.CarGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Location = new System.Drawing.Point(352, 65);
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowTemplate.Height = 25;
            this.CarGridView.Size = new System.Drawing.Size(837, 251);
            this.CarGridView.TabIndex = 9;
            this.CarGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGridView_RowHeaderMouseClick);
            this.CarGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGridView_RowHeaderMouseDoubleClick);
            // 
            // CbHasInsurance
            // 
            this.CbHasInsurance.AutoSize = true;
            this.CbHasInsurance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbHasInsurance.Location = new System.Drawing.Point(50, 236);
            this.CbHasInsurance.Name = "CbHasInsurance";
            this.CbHasInsurance.Size = new System.Drawing.Size(149, 29);
            this.CbHasInsurance.TabIndex = 10;
            this.CbHasInsurance.Text = "Has Insurance";
            this.CbHasInsurance.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(109, 282);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(91, 34);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "BtnDelete";
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(210, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // HomeForm
            // 
            this.AccessibleDescription = "BtnDelete";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.CbHasInsurance);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.InputBrandId);
            this.Controls.Add(this.LblBrand);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputId);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputModel;
        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.ComboBox InputBrandId;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.CheckBox CbHasInsurance;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button button1;
    }
}

