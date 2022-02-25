
namespace GamingHours
{
    partial class MainForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.showUsernameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.showProfileUrlLabel = new System.Windows.Forms.Label();
            this.showRealNameLabel = new System.Windows.Forms.Label();
            this.showGamesOwnedLabel = new System.Windows.Forms.Label();
            this.instructionLlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(67, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(125, 27);
            this.textBox.TabIndex = 1;
            // 
            // showUsernameLabel
            // 
            this.showUsernameLabel.AutoSize = true;
            this.showUsernameLabel.Location = new System.Drawing.Point(12, 56);
            this.showUsernameLabel.Name = "showUsernameLabel";
            this.showUsernameLabel.Size = new System.Drawing.Size(78, 20);
            this.showUsernameLabel.TabIndex = 2;
            this.showUsernameLabel.Text = "Username:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(198, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showProfileUrlLabel
            // 
            this.showProfileUrlLabel.AutoSize = true;
            this.showProfileUrlLabel.Location = new System.Drawing.Point(12, 85);
            this.showProfileUrlLabel.Name = "showProfileUrlLabel";
            this.showProfileUrlLabel.Size = new System.Drawing.Size(74, 20);
            this.showProfileUrlLabel.TabIndex = 4;
            this.showProfileUrlLabel.Text = "ProfileUrl:";
            // 
            // showRealNameLabel
            // 
            this.showRealNameLabel.AutoSize = true;
            this.showRealNameLabel.Location = new System.Drawing.Point(12, 117);
            this.showRealNameLabel.Name = "showRealNameLabel";
            this.showRealNameLabel.Size = new System.Drawing.Size(81, 20);
            this.showRealNameLabel.TabIndex = 5;
            this.showRealNameLabel.Text = "RealName:";
            // 
            // showGamesOwnedLabel
            // 
            this.showGamesOwnedLabel.AutoSize = true;
            this.showGamesOwnedLabel.Location = new System.Drawing.Point(12, 147);
            this.showGamesOwnedLabel.Name = "showGamesOwnedLabel";
            this.showGamesOwnedLabel.Size = new System.Drawing.Size(108, 20);
            this.showGamesOwnedLabel.TabIndex = 6;
            this.showGamesOwnedLabel.Text = "Games Owned:";
            // 
            // instructionLlabel
            // 
            this.instructionLlabel.AutoSize = true;
            this.instructionLlabel.Location = new System.Drawing.Point(315, 15);
            this.instructionLlabel.Name = "instructionLlabel";
            this.instructionLlabel.Size = new System.Drawing.Size(341, 20);
            this.instructionLlabel.TabIndex = 7;
            this.instructionLlabel.Text = "(Type bij Name: \"zupskaboi\". dat is mijn gametag)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructionLlabel);
            this.Controls.Add(this.showGamesOwnedLabel);
            this.Controls.Add(this.showRealNameLabel);
            this.Controls.Add(this.showProfileUrlLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showUsernameLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label showUsernameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label showProfileUrlLabel;
        private System.Windows.Forms.Label showRealNameLabel;
        private System.Windows.Forms.Label showGamesOwnedLabel;
        private System.Windows.Forms.Label instructionLlabel;
    }
}

