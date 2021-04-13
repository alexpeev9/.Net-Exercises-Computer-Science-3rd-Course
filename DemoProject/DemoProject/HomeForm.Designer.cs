
namespace DemoProject
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.LblName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BookGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.InputId = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.InputSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(31, 233);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(71, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name: ";
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputName.Location = new System.Drawing.Point(149, 230);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(134, 32);
            this.InputName.TabIndex = 1;
            // 
            // InputDescription
            // 
            this.InputDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputDescription.Location = new System.Drawing.Point(31, 308);
            this.InputDescription.Name = "InputDescription";
            this.InputDescription.Size = new System.Drawing.Size(252, 32);
            this.InputDescription.TabIndex = 3;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescription.Location = new System.Drawing.Point(31, 269);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(112, 25);
            this.LblDescription.TabIndex = 2;
            this.LblDescription.Text = "Description:";
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.Lime;
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(31, 366);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(100, 35);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Create ";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BookGridView
            // 
            this.BookGridView.AllowUserToAddRows = false;
            this.BookGridView.AllowUserToDeleteRows = false;
            this.BookGridView.AllowUserToResizeColumns = false;
            this.BookGridView.AllowUserToResizeRows = false;
            this.BookGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BookGridView.BackgroundColor = System.Drawing.Color.White;
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView.Location = new System.Drawing.Point(377, 76);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.RowTemplate.Height = 25;
            this.BookGridView.Size = new System.Drawing.Size(394, 291);
            this.BookGridView.TabIndex = 5;
            this.BookGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookGridView_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Red;
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemove.Location = new System.Drawing.Point(248, 366);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(96, 35);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "Delete";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputId.Location = new System.Drawing.Point(149, 184);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(134, 32);
            this.InputId.TabIndex = 9;
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtId.Location = new System.Drawing.Point(31, 187);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(32, 25);
            this.TxtId.TabIndex = 8;
            this.TxtId.Text = "Id:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(142, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(389, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(92, 32);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // InputSearch
            // 
            this.InputSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputSearch.Location = new System.Drawing.Point(497, 38);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(274, 32);
            this.InputSearch.TabIndex = 12;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.InputId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BookGridView);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.InputDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.LblName);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DataGridView BookGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox InputSearch;
    }
}