namespace NinjaTraderExample
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
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnRunTransaction = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(36, 91);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(728, 342);
            this.lstResult.TabIndex = 3;
            // 
            // btnRunTransaction
            // 
            this.btnRunTransaction.Location = new System.Drawing.Point(36, 17);
            this.btnRunTransaction.Name = "btnRunTransaction";
            this.btnRunTransaction.Size = new System.Drawing.Size(160, 59);
            this.btnRunTransaction.TabIndex = 2;
            this.btnRunTransaction.Text = "Perform Transaction";
            this.btnRunTransaction.UseVisualStyleBackColor = true;
            this.btnRunTransaction.Click += new System.EventHandler(this.btnRunTransaction_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(626, 56);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(104, 29);
            this.btnPosition.TabIndex = 4;
            this.btnPosition.Text = "Market Pos";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(626, 17);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnRunTransaction);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnRunTransaction;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.TextBox txtPosition;
    }
}

