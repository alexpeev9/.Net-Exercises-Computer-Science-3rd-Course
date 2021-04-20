
namespace CarProject
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
            this.InputId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.InputModel = new System.Windows.Forms.TextBox();
            this.LblYear = new System.Windows.Forms.Label();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.LblBrand = new System.Windows.Forms.Label();
            this.InputBrandId = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputId.Location = new System.Drawing.Point(145, 33);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(161, 32);
            this.InputId.TabIndex = 0;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblId.Location = new System.Drawing.Point(77, 40);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(28, 25);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(73, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 25);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            // 
            // InputModel
            // 
            this.InputModel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputModel.Location = new System.Drawing.Point(145, 81);
            this.InputModel.Name = "InputModel";
            this.InputModel.Size = new System.Drawing.Size(161, 32);
            this.InputModel.TabIndex = 2;
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblYear.Location = new System.Drawing.Point(77, 128);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(48, 25);
            this.LblYear.TabIndex = 5;
            this.LblYear.Text = "Year";
            // 
            // InputYear
            // 
            this.InputYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputYear.Location = new System.Drawing.Point(145, 125);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(161, 32);
            this.InputYear.TabIndex = 4;
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBrand.Location = new System.Drawing.Point(73, 178);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(62, 25);
            this.LblBrand.TabIndex = 6;
            this.LblBrand.Text = "Brand";
            // 
            // InputBrandId
            // 
            this.InputBrandId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputBrandId.FormattingEnabled = true;
            this.InputBrandId.Location = new System.Drawing.Point(145, 175);
            this.InputBrandId.Name = "InputBrandId";
            this.InputBrandId.Size = new System.Drawing.Size(161, 33);
            this.InputBrandId.TabIndex = 7;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(58, 232);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(101, 42);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(165, 232);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(101, 42);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(272, 232);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(101, 42);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.CarGridView.Location = new System.Drawing.Point(409, 33);
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowTemplate.Height = 25;
            this.CarGridView.Size = new System.Drawing.Size(723, 367);
            this.CarGridView.TabIndex = 11;
            this.CarGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGridView_RowHeaderMouseClick);
            this.CarGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGridView_RowHeaderMouseDoubleClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.InputBrandId);
            this.Controls.Add(this.LblBrand);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.InputModel);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.InputId);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox InputModel;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.ComboBox InputBrandId;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView CarGridView;
    }
}

