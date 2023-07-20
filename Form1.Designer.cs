
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
            this.btnUpdateByNameToggle = new System.Windows.Forms.Button();
            this.btnUpdateByNumberToggle = new System.Windows.Forms.Button();
            this.btnAddNewToggle = new System.Windows.Forms.Button();
            this.btnDeleteToggle = new System.Windows.Forms.Button();
            this.txtToggledName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtToggledPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtToggledAge = new System.Windows.Forms.TextBox();
            this.lblFavoritePizza = new System.Windows.Forms.Label();
            this.txtToggledFavoritePizza = new System.Windows.Forms.TextBox();
            this.btnToggledUpdateByName = new System.Windows.Forms.Button();
            this.lblToggledUpdateByName = new System.Windows.Forms.Label();
            this.txtToggledUpdateByName = new System.Windows.Forms.TextBox();
            this.txtToggledUpdateByNumber = new System.Windows.Forms.TextBox();
            this.lblToggledUpdateByNumber = new System.Windows.Forms.Label();
            this.btnToggledAdd = new System.Windows.Forms.Button();
            this.btnToggledUpdateByNumber = new System.Windows.Forms.Button();
            this.lblToggledDelete = new System.Windows.Forms.Label();
            this.txtToggledDelete = new System.Windows.Forms.TextBox();
            this.btnToggledDelete = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnLoginTwo = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
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
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_ClickAsync);
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
            this.tbGetByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGetByName_KeyPress);
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
            this.tbGetByNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGetByNumber_KeyPress);
            // 
            // btnUpdateByNameToggle
            // 
            this.btnUpdateByNameToggle.Location = new System.Drawing.Point(12, 107);
            this.btnUpdateByNameToggle.Name = "btnUpdateByNameToggle";
            this.btnUpdateByNameToggle.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateByNameToggle.TabIndex = 8;
            this.btnUpdateByNameToggle.Text = "Update by name";
            this.btnUpdateByNameToggle.UseVisualStyleBackColor = true;
            this.btnUpdateByNameToggle.Visible = false;
            this.btnUpdateByNameToggle.Click += new System.EventHandler(this.btnUpdateByNameToggle_Click);
            // 
            // btnUpdateByNumberToggle
            // 
            this.btnUpdateByNumberToggle.Location = new System.Drawing.Point(115, 107);
            this.btnUpdateByNumberToggle.Name = "btnUpdateByNumberToggle";
            this.btnUpdateByNumberToggle.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateByNumberToggle.TabIndex = 9;
            this.btnUpdateByNumberToggle.Text = "Update by number";
            this.btnUpdateByNumberToggle.UseVisualStyleBackColor = true;
            this.btnUpdateByNumberToggle.Visible = false;
            this.btnUpdateByNumberToggle.Click += new System.EventHandler(this.btnUpdateByNumberToggle_Click);
            // 
            // btnAddNewToggle
            // 
            this.btnAddNewToggle.Location = new System.Drawing.Point(226, 107);
            this.btnAddNewToggle.Name = "btnAddNewToggle";
            this.btnAddNewToggle.Size = new System.Drawing.Size(65, 23);
            this.btnAddNewToggle.TabIndex = 10;
            this.btnAddNewToggle.Text = "Add new";
            this.btnAddNewToggle.UseVisualStyleBackColor = true;
            this.btnAddNewToggle.Visible = false;
            this.btnAddNewToggle.Click += new System.EventHandler(this.btnAddNewToggle_Click);
            // 
            // btnDeleteToggle
            // 
            this.btnDeleteToggle.Location = new System.Drawing.Point(297, 107);
            this.btnDeleteToggle.Name = "btnDeleteToggle";
            this.btnDeleteToggle.Size = new System.Drawing.Size(69, 23);
            this.btnDeleteToggle.TabIndex = 11;
            this.btnDeleteToggle.Text = "Delete";
            this.btnDeleteToggle.UseVisualStyleBackColor = true;
            this.btnDeleteToggle.Visible = false;
            this.btnDeleteToggle.Click += new System.EventHandler(this.btnDeleteToggle_Click);
            // 
            // txtToggledName
            // 
            this.txtToggledName.Location = new System.Drawing.Point(88, 309);
            this.txtToggledName.Name = "txtToggledName";
            this.txtToggledName.Size = new System.Drawing.Size(100, 20);
            this.txtToggledName.TabIndex = 12;
            this.txtToggledName.Visible = false;
            this.txtToggledName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 312);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(9, 340);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Visible = false;
            // 
            // txtToggledPhoneNumber
            // 
            this.txtToggledPhoneNumber.Location = new System.Drawing.Point(88, 336);
            this.txtToggledPhoneNumber.Name = "txtToggledPhoneNumber";
            this.txtToggledPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtToggledPhoneNumber.TabIndex = 15;
            this.txtToggledPhoneNumber.Visible = false;
            this.txtToggledPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledPhoneNumber_KeyPress);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 362);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Age";
            this.lblAge.Visible = false;
            // 
            // txtToggledAge
            // 
            this.txtToggledAge.Location = new System.Drawing.Point(88, 362);
            this.txtToggledAge.Name = "txtToggledAge";
            this.txtToggledAge.Size = new System.Drawing.Size(100, 20);
            this.txtToggledAge.TabIndex = 17;
            this.txtToggledAge.Visible = false;
            this.txtToggledAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledAge_KeyPress);
            // 
            // lblFavoritePizza
            // 
            this.lblFavoritePizza.AutoSize = true;
            this.lblFavoritePizza.Location = new System.Drawing.Point(9, 390);
            this.lblFavoritePizza.Name = "lblFavoritePizza";
            this.lblFavoritePizza.Size = new System.Drawing.Size(73, 13);
            this.lblFavoritePizza.TabIndex = 18;
            this.lblFavoritePizza.Text = "Favorite Pizza";
            this.lblFavoritePizza.Visible = false;
            // 
            // txtToggledFavoritePizza
            // 
            this.txtToggledFavoritePizza.Location = new System.Drawing.Point(88, 387);
            this.txtToggledFavoritePizza.Name = "txtToggledFavoritePizza";
            this.txtToggledFavoritePizza.Size = new System.Drawing.Size(100, 20);
            this.txtToggledFavoritePizza.TabIndex = 19;
            this.txtToggledFavoritePizza.Visible = false;
            this.txtToggledFavoritePizza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledFavoritePizza_KeyPress);
            // 
            // btnToggledUpdateByName
            // 
            this.btnToggledUpdateByName.Location = new System.Drawing.Point(99, 413);
            this.btnToggledUpdateByName.Name = "btnToggledUpdateByName";
            this.btnToggledUpdateByName.Size = new System.Drawing.Size(75, 23);
            this.btnToggledUpdateByName.TabIndex = 20;
            this.btnToggledUpdateByName.Text = "Update";
            this.btnToggledUpdateByName.UseVisualStyleBackColor = true;
            this.btnToggledUpdateByName.Visible = false;
            this.btnToggledUpdateByName.Click += new System.EventHandler(this.btnToggledUpdateByName_Click);
            // 
            // lblToggledUpdateByName
            // 
            this.lblToggledUpdateByName.AutoSize = true;
            this.lblToggledUpdateByName.Location = new System.Drawing.Point(9, 161);
            this.lblToggledUpdateByName.Name = "lblToggledUpdateByName";
            this.lblToggledUpdateByName.Size = new System.Drawing.Size(83, 13);
            this.lblToggledUpdateByName.TabIndex = 21;
            this.lblToggledUpdateByName.Text = "Name to update";
            this.lblToggledUpdateByName.Visible = false;
            // 
            // txtToggledUpdateByName
            // 
            this.txtToggledUpdateByName.Location = new System.Drawing.Point(98, 158);
            this.txtToggledUpdateByName.Name = "txtToggledUpdateByName";
            this.txtToggledUpdateByName.Size = new System.Drawing.Size(192, 20);
            this.txtToggledUpdateByName.TabIndex = 22;
            this.txtToggledUpdateByName.Visible = false;
            this.txtToggledUpdateByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledUpdateByName_KeyPress);
            // 
            // txtToggledUpdateByNumber
            // 
            this.txtToggledUpdateByNumber.Location = new System.Drawing.Point(107, 158);
            this.txtToggledUpdateByNumber.Name = "txtToggledUpdateByNumber";
            this.txtToggledUpdateByNumber.Size = new System.Drawing.Size(193, 20);
            this.txtToggledUpdateByNumber.TabIndex = 23;
            this.txtToggledUpdateByNumber.Visible = false;
            this.txtToggledUpdateByNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledUpdateByNumber_KeyPress);
            // 
            // lblToggledUpdateByNumber
            // 
            this.lblToggledUpdateByNumber.AutoSize = true;
            this.lblToggledUpdateByNumber.Location = new System.Drawing.Point(9, 161);
            this.lblToggledUpdateByNumber.Name = "lblToggledUpdateByNumber";
            this.lblToggledUpdateByNumber.Size = new System.Drawing.Size(92, 13);
            this.lblToggledUpdateByNumber.TabIndex = 24;
            this.lblToggledUpdateByNumber.Text = "Number to update";
            this.lblToggledUpdateByNumber.Visible = false;
            // 
            // btnToggledAdd
            // 
            this.btnToggledAdd.Location = new System.Drawing.Point(99, 413);
            this.btnToggledAdd.Name = "btnToggledAdd";
            this.btnToggledAdd.Size = new System.Drawing.Size(75, 23);
            this.btnToggledAdd.TabIndex = 25;
            this.btnToggledAdd.Text = "Add";
            this.btnToggledAdd.UseVisualStyleBackColor = true;
            this.btnToggledAdd.Visible = false;
            this.btnToggledAdd.Click += new System.EventHandler(this.btnToggledAdd_Click);
            // 
            // btnToggledUpdateByNumber
            // 
            this.btnToggledUpdateByNumber.Location = new System.Drawing.Point(99, 413);
            this.btnToggledUpdateByNumber.Name = "btnToggledUpdateByNumber";
            this.btnToggledUpdateByNumber.Size = new System.Drawing.Size(75, 23);
            this.btnToggledUpdateByNumber.TabIndex = 26;
            this.btnToggledUpdateByNumber.Text = "Update";
            this.btnToggledUpdateByNumber.UseVisualStyleBackColor = true;
            this.btnToggledUpdateByNumber.Visible = false;
            this.btnToggledUpdateByNumber.Click += new System.EventHandler(this.btnToggledUpdateByNumber_Click);
            // 
            // lblToggledDelete
            // 
            this.lblToggledDelete.AutoSize = true;
            this.lblToggledDelete.Location = new System.Drawing.Point(9, 214);
            this.lblToggledDelete.Name = "lblToggledDelete";
            this.lblToggledDelete.Size = new System.Drawing.Size(79, 13);
            this.lblToggledDelete.TabIndex = 27;
            this.lblToggledDelete.Text = "Name to delete";
            this.lblToggledDelete.Visible = false;
            // 
            // txtToggledDelete
            // 
            this.txtToggledDelete.Location = new System.Drawing.Point(94, 211);
            this.txtToggledDelete.Name = "txtToggledDelete";
            this.txtToggledDelete.Size = new System.Drawing.Size(206, 20);
            this.txtToggledDelete.TabIndex = 28;
            this.txtToggledDelete.Visible = false;
            this.txtToggledDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToggledDelete_KeyPress);
            // 
            // btnToggledDelete
            // 
            this.btnToggledDelete.Location = new System.Drawing.Point(145, 237);
            this.btnToggledDelete.Name = "btnToggledDelete";
            this.btnToggledDelete.Size = new System.Drawing.Size(88, 23);
            this.btnToggledDelete.TabIndex = 29;
            this.btnToggledDelete.Text = "Delete (serious)";
            this.btnToggledDelete.UseVisualStyleBackColor = true;
            this.btnToggledDelete.Visible = false;
            this.btnToggledDelete.Click += new System.EventHandler(this.btnToggledDelete_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(268, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 161);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 13);
            this.lblLogin.TabIndex = 31;
            this.lblLogin.Text = "Login ID";
            this.lblLogin.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(98, 158);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(201, 20);
            this.txtLogin.TabIndex = 32;
            this.txtLogin.Visible = false;
            // 
            // btnLoginTwo
            // 
            this.btnLoginTwo.Location = new System.Drawing.Point(145, 182);
            this.btnLoginTwo.Name = "btnLoginTwo";
            this.btnLoginTwo.Size = new System.Drawing.Size(88, 23);
            this.btnLoginTwo.TabIndex = 33;
            this.btnLoginTwo.Text = "Log in";
            this.btnLoginTwo.UseVisualStyleBackColor = true;
            this.btnLoginTwo.Visible = false;
            this.btnLoginTwo.Click += new System.EventHandler(this.btnLoginTwo_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(291, 384);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 34;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(291, 352);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 35;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoginTwo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnToggledDelete);
            this.Controls.Add(this.txtToggledDelete);
            this.Controls.Add(this.lblToggledDelete);
            this.Controls.Add(this.btnToggledUpdateByNumber);
            this.Controls.Add(this.btnToggledAdd);
            this.Controls.Add(this.lblToggledUpdateByNumber);
            this.Controls.Add(this.txtToggledUpdateByNumber);
            this.Controls.Add(this.txtToggledUpdateByName);
            this.Controls.Add(this.lblToggledUpdateByName);
            this.Controls.Add(this.btnToggledUpdateByName);
            this.Controls.Add(this.txtToggledFavoritePizza);
            this.Controls.Add(this.lblFavoritePizza);
            this.Controls.Add(this.txtToggledAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtToggledPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtToggledName);
            this.Controls.Add(this.btnDeleteToggle);
            this.Controls.Add(this.btnAddNewToggle);
            this.Controls.Add(this.btnUpdateByNumberToggle);
            this.Controls.Add(this.btnUpdateByNameToggle);
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
        private System.Windows.Forms.Button btnUpdateByNameToggle;
        private System.Windows.Forms.Button btnUpdateByNumberToggle;
        private System.Windows.Forms.Button btnAddNewToggle;
        private System.Windows.Forms.Button btnDeleteToggle;
        private System.Windows.Forms.TextBox txtToggledName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtToggledPhoneNumber;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtToggledAge;
        private System.Windows.Forms.Label lblFavoritePizza;
        private System.Windows.Forms.TextBox txtToggledFavoritePizza;
        private System.Windows.Forms.Button btnToggledUpdateByName;
        private System.Windows.Forms.Label lblToggledUpdateByName;
        private System.Windows.Forms.TextBox txtToggledUpdateByName;
        private System.Windows.Forms.TextBox txtToggledUpdateByNumber;
        private System.Windows.Forms.Label lblToggledUpdateByNumber;
        private System.Windows.Forms.Button btnToggledAdd;
        private System.Windows.Forms.Button btnToggledUpdateByNumber;
        private System.Windows.Forms.Label lblToggledDelete;
        private System.Windows.Forms.TextBox txtToggledDelete;
        private System.Windows.Forms.Button btnToggledDelete;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnLoginTwo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}

