namespace LoginScreenReal
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.passInput = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(96, 388);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(304, 20);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "You got the wrong username or password";
            this.errorLabel.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(581, 353);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(162, 90);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(253, 265);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(140, 26);
            this.passInput.TabIndex = 11;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(253, 126);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(140, 26);
            this.userInput.TabIndex = 10;
            // 
            // passLabel
            // 
            this.passLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(96, 248);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(151, 61);
            this.passLabel.TabIndex = 9;
            this.passLabel.Text = "Password:";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userLabel
            // 
            this.userLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(96, 109);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(151, 61);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "Username:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(838, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
    }
}
