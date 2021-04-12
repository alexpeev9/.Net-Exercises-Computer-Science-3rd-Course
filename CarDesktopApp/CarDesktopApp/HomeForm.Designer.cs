using System.Windows.Forms;

namespace CarDesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.CarGrid = new System.Windows.Forms.DataGridView();
            this.CarModel = new System.Windows.Forms.Label();
            this.CarYear = new System.Windows.Forms.Label();
            this.CarBrandId = new System.Windows.Forms.Label();
            this.InputModel = new System.Windows.Forms.TextBox();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.InputBrandId = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.InputId = new System.Windows.Forms.TextBox();
            this.CarId = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.InputSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarGrid
            // 
            this.CarGrid.AllowUserToAddRows = false;
            this.CarGrid.AllowUserToDeleteRows = false;
            this.CarGrid.AllowUserToResizeColumns = false;
            this.CarGrid.AllowUserToResizeRows = false;
            this.CarGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGrid.Location = new System.Drawing.Point(310, 68);
            this.CarGrid.Name = "CarGrid";
            this.CarGrid.ReadOnly = true;
            this.CarGrid.Size = new System.Drawing.Size(594, 310);
            this.CarGrid.TabIndex = 1;
            this.CarGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarGrid_RowHeaderMouseClick);
            // 
            // CarModel
            // 
            this.CarModel.AutoSize = true;
            this.CarModel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarModel.Location = new System.Drawing.Point(41, 198);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(66, 25);
            this.CarModel.TabIndex = 3;
            this.CarModel.Text = "Model";
            // 
            // CarYear
            // 
            this.CarYear.AutoSize = true;
            this.CarYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarYear.Location = new System.Drawing.Point(41, 243);
            this.CarYear.Name = "CarYear";
            this.CarYear.Size = new System.Drawing.Size(48, 25);
            this.CarYear.TabIndex = 4;
            this.CarYear.Text = "Year";
            // 
            // CarBrandId
            // 
            this.CarBrandId.AutoSize = true;
            this.CarBrandId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarBrandId.Location = new System.Drawing.Point(41, 294);
            this.CarBrandId.Name = "CarBrandId";
            this.CarBrandId.Size = new System.Drawing.Size(62, 25);
            this.CarBrandId.TabIndex = 5;
            this.CarBrandId.Text = "Brand";
            // 
            // InputModel
            // 
            this.InputModel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputModel.Location = new System.Drawing.Point(113, 198);
            this.InputModel.Name = "InputModel";
            this.InputModel.Size = new System.Drawing.Size(139, 32);
            this.InputModel.TabIndex = 6;
            // 
            // InputYear
            // 
            this.InputYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputYear.Location = new System.Drawing.Point(113, 240);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(139, 32);
            this.InputYear.TabIndex = 7;
            // 
            // InputBrandId
            // 
            this.InputBrandId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputBrandId.FormattingEnabled = true;
            this.InputBrandId.Location = new System.Drawing.Point(113, 291);
            this.InputBrandId.Name = "InputBrandId";
            this.InputBrandId.Size = new System.Drawing.Size(139, 33);
            this.InputBrandId.TabIndex = 8;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CreateButton.Location = new System.Drawing.Point(21, 339);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(86, 39);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Create Car";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnUpdate.Location = new System.Drawing.Point(113, 339);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 39);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update Car";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // InputId
            // 
            this.InputId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.InputId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputId.Location = new System.Drawing.Point(113, 159);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(139, 32);
            this.InputId.TabIndex = 13;
            // 
            // CarId
            // 
            this.CarId.AutoSize = true;
            this.CarId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarId.Location = new System.Drawing.Point(51, 162);
            this.CarId.Name = "CarId";
            this.CarId.Size = new System.Drawing.Size(28, 25);
            this.CarId.TabIndex = 12;
            this.CarId.Text = "Id";
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(205, 339);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(86, 39);
            this.BtnRemove.TabIndex = 14;
            this.BtnRemove.Text = "Remove Car";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(310, 30);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(86, 32);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.Text = "Search Car";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // InputSearch
            // 
            this.InputSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputSearch.Location = new System.Drawing.Point(412, 30);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(492, 32);
            this.InputSearch.TabIndex = 16;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 392);
            this.Controls.Add(this.InputSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.InputId);
            this.Controls.Add(this.CarId);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.InputBrandId);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.InputModel);
            this.Controls.Add(this.CarBrandId);
            this.Controls.Add(this.CarYear);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.CarGrid);
            this.Name = "HomeForm";
            this.Text = "Car Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.CarGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView CarGrid;
        private Label CarModel;
        private Label CarYear;
        private Label CarBrandId;
        private TextBox InputModel;
        private TextBox InputYear;
        private ComboBox InputBrandId;
        private Button CreateButton;
        private PictureBox pictureBox1;
        private Button BtnUpdate;
        private TextBox InputId;
        private Label CarId;
        private Button BtnRemove;
        private Button BtnSearch;
        private TextBox InputSearch;
    }
}

