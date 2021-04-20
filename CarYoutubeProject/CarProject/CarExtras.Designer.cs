
namespace CarProject
{
    partial class CarExtras
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
            this.lblCarName = new System.Windows.Forms.Label();
            this.InputCarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboExtraId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ManyToManyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ManyToManyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarName.Location = new System.Drawing.Point(25, 103);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(41, 25);
            this.lblCarName.TabIndex = 0;
            this.lblCarName.Text = "Car";
            // 
            // InputCarName
            // 
            this.InputCarName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCarName.Location = new System.Drawing.Point(83, 98);
            this.InputCarName.Name = "InputCarName";
            this.InputCarName.ReadOnly = true;
            this.InputCarName.Size = new System.Drawing.Size(119, 32);
            this.InputCarName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extras";
            // 
            // ComboExtraId
            // 
            this.ComboExtraId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboExtraId.FormattingEnabled = true;
            this.ComboExtraId.Location = new System.Drawing.Point(334, 100);
            this.ComboExtraId.Name = "ComboExtraId";
            this.ComboExtraId.Size = new System.Drawing.Size(142, 33);
            this.ComboExtraId.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(130, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(246, 168);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 41);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ManyToManyGrid
            // 
            this.ManyToManyGrid.AllowUserToAddRows = false;
            this.ManyToManyGrid.AllowUserToDeleteRows = false;
            this.ManyToManyGrid.AllowUserToResizeColumns = false;
            this.ManyToManyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManyToManyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManyToManyGrid.Location = new System.Drawing.Point(24, 252);
            this.ManyToManyGrid.Name = "ManyToManyGrid";
            this.ManyToManyGrid.ReadOnly = true;
            this.ManyToManyGrid.RowTemplate.Height = 25;
            this.ManyToManyGrid.Size = new System.Drawing.Size(482, 330);
            this.ManyToManyGrid.TabIndex = 6;
            // 
            // CarExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 631);
            this.Controls.Add(this.ManyToManyGrid);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ComboExtraId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputCarName);
            this.Controls.Add(this.lblCarName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarExtras";
            this.Text = "CarExtras";
            ((System.ComponentModel.ISupportInitialize)(this.ManyToManyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.TextBox InputCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboExtraId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView ManyToManyGrid;
    }
}