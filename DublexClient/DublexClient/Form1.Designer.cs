namespace DublexClient
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
            this.btnProcessReport = new System.Windows.Forms.Button();
            this.tbxProgressStuation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcessReport
            // 
            this.btnProcessReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessReport.Location = new System.Drawing.Point(62, 29);
            this.btnProcessReport.Name = "btnProcessReport";
            this.btnProcessReport.Size = new System.Drawing.Size(300, 71);
            this.btnProcessReport.TabIndex = 0;
            this.btnProcessReport.Text = "Process Report";
            this.btnProcessReport.UseVisualStyleBackColor = true;
            this.btnProcessReport.Click += new System.EventHandler(this.btnProcessReport_Click);
            // 
            // tbxProgressStuation
            // 
            this.tbxProgressStuation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProgressStuation.Location = new System.Drawing.Point(62, 142);
            this.tbxProgressStuation.Name = "tbxProgressStuation";
            this.tbxProgressStuation.Size = new System.Drawing.Size(300, 30);
            this.tbxProgressStuation.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 268);
            this.Controls.Add(this.tbxProgressStuation);
            this.Controls.Add(this.btnProcessReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessReport;
        private System.Windows.Forms.TextBox tbxProgressStuation;
    }
}

