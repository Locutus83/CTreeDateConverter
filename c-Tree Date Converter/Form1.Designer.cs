namespace c_Tree_Date_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tbDateToConvert = new System.Windows.Forms.TextBox();
            this.lblConvertedDate = new System.Windows.Forms.Label();
            this.btnConvertIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(259, 71);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // tbDateToConvert
            // 
            this.tbDateToConvert.Location = new System.Drawing.Point(88, 88);
            this.tbDateToConvert.Name = "tbDateToConvert";
            this.tbDateToConvert.Size = new System.Drawing.Size(100, 20);
            this.tbDateToConvert.TabIndex = 1;
            // 
            // lblConvertedDate
            // 
            this.lblConvertedDate.BackColor = System.Drawing.Color.Silver;
            this.lblConvertedDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConvertedDate.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedDate.Location = new System.Drawing.Point(12, 141);
            this.lblConvertedDate.Name = "lblConvertedDate";
            this.lblConvertedDate.Size = new System.Drawing.Size(260, 82);
            this.lblConvertedDate.TabIndex = 2;
            this.lblConvertedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvertIt
            // 
            this.btnConvertIt.Location = new System.Drawing.Point(99, 115);
            this.btnConvertIt.Name = "btnConvertIt";
            this.btnConvertIt.Size = new System.Drawing.Size(75, 23);
            this.btnConvertIt.TabIndex = 3;
            this.btnConvertIt.Text = "Convert It!!";
            this.btnConvertIt.UseVisualStyleBackColor = true;
            this.btnConvertIt.Click += new System.EventHandler(this.btnConvertIt_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvertIt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.btnConvertIt);
            this.Controls.Add(this.lblConvertedDate);
            this.Controls.Add(this.tbDateToConvert);
            this.Controls.Add(this.lblInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 272);
            this.Name = "Form1";
            this.Text = "C-Tree Date Converter Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox tbDateToConvert;
        private System.Windows.Forms.Label lblConvertedDate;
        private System.Windows.Forms.Button btnConvertIt;
    }
}

