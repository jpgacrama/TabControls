
namespace TabControls
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
            this.partyTabs = new System.Windows.Forms.TabControl();
            this.DinnerParty = new System.Windows.Forms.TabPage();
            this.BirthdayParty = new System.Windows.Forms.TabPage();
            this.partyTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // partyTabs
            // 
            this.partyTabs.Controls.Add(this.DinnerParty);
            this.partyTabs.Controls.Add(this.BirthdayParty);
            this.partyTabs.Location = new System.Drawing.Point(12, 12);
            this.partyTabs.Name = "partyTabs";
            this.partyTabs.SelectedIndex = 0;
            this.partyTabs.Size = new System.Drawing.Size(299, 189);
            this.partyTabs.TabIndex = 0;
            // 
            // DinnerParty
            // 
            this.DinnerParty.Location = new System.Drawing.Point(4, 25);
            this.DinnerParty.Name = "DinnerParty";
            this.DinnerParty.Padding = new System.Windows.Forms.Padding(3);
            this.DinnerParty.Size = new System.Drawing.Size(192, 71);
            this.DinnerParty.TabIndex = 0;
            this.DinnerParty.Text = "DinnerParty";
            this.DinnerParty.UseVisualStyleBackColor = true;
            // 
            // BirthdayParty
            // 
            this.BirthdayParty.Location = new System.Drawing.Point(4, 25);
            this.BirthdayParty.Name = "BirthdayParty";
            this.BirthdayParty.Padding = new System.Windows.Forms.Padding(3);
            this.BirthdayParty.Size = new System.Drawing.Size(291, 160);
            this.BirthdayParty.TabIndex = 1;
            this.BirthdayParty.Text = "BirthdayParty";
            this.BirthdayParty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 243);
            this.Controls.Add(this.partyTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.partyTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage DinnerParty;
        private System.Windows.Forms.TabPage BirthdayParty;
        private System.Windows.Forms.TabControl partyTabs;
    }
}

