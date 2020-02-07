namespace LoginScreenReal
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
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(108, 78);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(151, 61);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username:";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(108, 217);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(151, 61);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password:";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(265, 95);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(140, 26);
            this.userInput.TabIndex = 4;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(265, 234);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(140, 26);
            this.passInput.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(593, 322);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(162, 90);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(108, 357);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(304, 20);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "You got the wrong username or password";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

