
namespace CarsProject2021
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
            this.LblCar = new System.Windows.Forms.Label();
            this.InputCarName = new System.Windows.Forms.TextBox();
            this.LblExtra = new System.Windows.Forms.Label();
            this.ComboExtraId = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ManyToManyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ManyToManyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCar
            // 
            this.LblCar.AutoSize = true;
            this.LblCar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCar.Location = new System.Drawing.Point(43, 42);
            this.LblCar.Name = "LblCar";
            this.LblCar.Size = new System.Drawing.Size(41, 25);
            this.LblCar.TabIndex = 0;
            this.LblCar.Text = "Car";
            // 
            // InputCarName
            // 
            this.InputCarName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCarName.Location = new System.Drawing.Point(90, 39);
            this.InputCarName.Name = "InputCarName";
            this.InputCarName.ReadOnly = true;
            this.InputCarName.Size = new System.Drawing.Size(160, 32);
            this.InputCarName.TabIndex = 1;
            // 
            // LblExtra
            // 
            this.LblExtra.AutoSize = true;
            this.LblExtra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblExtra.Location = new System.Drawing.Point(293, 42);
            this.LblExtra.Name = "LblExtra";
            this.LblExtra.Size = new System.Drawing.Size(54, 25);
            this.LblExtra.TabIndex = 2;
            this.LblExtra.Text = "Extra";
            // 
            // ComboExtraId
            // 
            this.ComboExtraId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboExtraId.FormattingEnabled = true;
            this.ComboExtraId.Location = new System.Drawing.Point(353, 39);
            this.ComboExtraId.Name = "ComboExtraId";
            this.ComboExtraId.Size = new System.Drawing.Size(160, 33);
            this.ComboExtraId.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(90, 126);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(115, 41);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(320, 126);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(91, 41);
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
            this.ManyToManyGrid.AllowUserToResizeRows = false;
            this.ManyToManyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManyToManyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ManyToManyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManyToManyGrid.Location = new System.Drawing.Point(37, 212);
            this.ManyToManyGrid.Name = "ManyToManyGrid";
            this.ManyToManyGrid.ReadOnly = true;
            this.ManyToManyGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ManyToManyGrid.RowTemplate.Height = 25;
            this.ManyToManyGrid.Size = new System.Drawing.Size(475, 175);
            this.ManyToManyGrid.TabIndex = 6;
            this.ManyToManyGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ManyToManyGrid_RowHeaderMouseClick);
            // 
            // CarExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 420);
            this.Controls.Add(this.ManyToManyGrid);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ComboExtraId);
            this.Controls.Add(this.LblExtra);
            this.Controls.Add(this.InputCarName);
            this.Controls.Add(this.LblCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarExtras";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ManyToManyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCar;
        private System.Windows.Forms.TextBox InputCarName;
        private System.Windows.Forms.Label LblExtra;
        private System.Windows.Forms.ComboBox ComboExtraId;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView ManyToManyGrid;
    }
}