
namespace APIApp
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
            this.btnGetAll = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnGetByName = new System.Windows.Forms.Button();
            this.tbGetByName = new System.Windows.Forms.TextBox();
            this.btnClearRtb = new System.Windows.Forms.Button();
            this.btnGetByNumber = new System.Windows.Forms.Button();
            this.tbGetByNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(12, 12);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(98, 23);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get all customers";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(372, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(416, 426);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnGetByName
            // 
            this.btnGetByName.Location = new System.Drawing.Point(268, 43);
            this.btnGetByName.Name = "btnGetByName";
            this.btnGetByName.Size = new System.Drawing.Size(98, 20);
            this.btnGetByName.TabIndex = 2;
            this.btnGetByName.Text = "Get by name";
            this.btnGetByName.UseVisualStyleBackColor = true;
            this.btnGetByName.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGetByName
            // 
            this.tbGetByName.Location = new System.Drawing.Point(12, 43);
            this.tbGetByName.Name = "tbGetByName";
            this.tbGetByName.Size = new System.Drawing.Size(250, 20);
            this.tbGetByName.TabIndex = 3;
            // 
            // btnClearRtb
            // 
            this.btnClearRtb.Location = new System.Drawing.Point(291, 415);
            this.btnClearRtb.Name = "btnClearRtb";
            this.btnClearRtb.Size = new System.Drawing.Size(75, 23);
            this.btnClearRtb.TabIndex = 4;
            this.btnClearRtb.Text = "Clear";
            this.btnClearRtb.UseVisualStyleBackColor = true;
            this.btnClearRtb.Click += new System.EventHandler(this.btnClearRtb_Click);
            // 
            // btnGetByNumber
            // 
            this.btnGetByNumber.Location = new System.Drawing.Point(268, 69);
            this.btnGetByNumber.Name = "btnGetByNumber";
            this.btnGetByNumber.Size = new System.Drawing.Size(98, 20);
            this.btnGetByNumber.TabIndex = 6;
            this.btnGetByNumber.Text = "Get by number";
            this.btnGetByNumber.UseVisualStyleBackColor = true;
            this.btnGetByNumber.Click += new System.EventHandler(this.btnGetByNumber_Click);
            // 
            // tbGetByNumber
            // 
            this.tbGetByNumber.Location = new System.Drawing.Point(12, 69);
            this.tbGetByNumber.Name = "tbGetByNumber";
            this.tbGetByNumber.Size = new System.Drawing.Size(250, 20);
            this.tbGetByNumber.TabIndex = 7;
            this.tbGetByNumber.TextChanged += new System.EventHandler(this.tbGetByNumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGetByNumber);
            this.Controls.Add(this.btnGetByNumber);
            this.Controls.Add(this.btnClearRtb);
            this.Controls.Add(this.tbGetByName);
            this.Controls.Add(this.btnGetByName);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnGetAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnGetByName;
        private System.Windows.Forms.Button btnClearRtb;
        private System.Windows.Forms.Button btnGetByNumber;
        private System.Windows.Forms.TextBox tbGetByNumber;
        private System.Windows.Forms.TextBox tbGetByName;
    }
}

