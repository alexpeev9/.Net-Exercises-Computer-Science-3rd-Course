
namespace ServiceProjectExample
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.NaneLbl = new System.Windows.Forms.Label();
            this.DescrLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputDescription = new System.Windows.Forms.TextBox();
            this.InputYear = new System.Windows.Forms.NumericUpDown();
            this.ErrorInputName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorInputDescription = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InputYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInputName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInputDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.CreateBtn.Location = new System.Drawing.Point(108, 173);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(103, 44);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // NaneLbl
            // 
            this.NaneLbl.AutoSize = true;
            this.NaneLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NaneLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NaneLbl.Location = new System.Drawing.Point(12, 40);
            this.NaneLbl.Name = "NaneLbl";
            this.NaneLbl.Size = new System.Drawing.Size(62, 25);
            this.NaneLbl.TabIndex = 3;
            this.NaneLbl.Text = "Name";
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescrLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescrLbl.Location = new System.Drawing.Point(12, 85);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(108, 25);
            this.DescrLbl.TabIndex = 4;
            this.DescrLbl.Text = "Description";
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YearLbl.Location = new System.Drawing.Point(12, 136);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(48, 25);
            this.YearLbl.TabIndex = 5;
            this.YearLbl.Text = "Year";
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputName.Location = new System.Drawing.Point(120, 40);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(186, 32);
            this.InputName.TabIndex = 6;
            this.InputName.Validating += new System.ComponentModel.CancelEventHandler(this.InputName_Validating);
            // 
            // InputDescription
            // 
            this.InputDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputDescription.Location = new System.Drawing.Point(120, 82);
            this.InputDescription.Name = "InputDescription";
            this.InputDescription.Size = new System.Drawing.Size(186, 32);
            this.InputDescription.TabIndex = 7;
            this.InputDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ErrorForDescription);
            // 
            // InputYear
            // 
            this.InputYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputYear.Location = new System.Drawing.Point(120, 129);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(186, 32);
            this.InputYear.TabIndex = 9;
            // 
            // ErrorInputName
            // 
            this.ErrorInputName.ContainerControl = this;
            // 
            // ErrorInputDescription
            // 
            this.ErrorInputDescription.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 228);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.InputDescription);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.DescrLbl);
            this.Controls.Add(this.NaneLbl);
            this.Controls.Add(this.CreateBtn);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "BookForm";
            this.Text = "Book Form";
            ((System.ComponentModel.ISupportInitialize)(this.InputYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInputName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorInputDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label NaneLbl;
        private System.Windows.Forms.Label DescrLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputDescription;
        private System.Windows.Forms.NumericUpDown InputYear;
        private System.Windows.Forms.ErrorProvider ErrorInputName;
        private System.Windows.Forms.ErrorProvider ErrorInputDescription;
    }
}

