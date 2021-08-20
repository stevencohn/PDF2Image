
namespace PDF2Image
{
	partial class Form
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
			this.inLabel = new System.Windows.Forms.Label();
			this.outLabel = new System.Windows.Forms.Label();
			this.outBox = new System.Windows.Forms.TextBox();
			this.inBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.browseInButton = new System.Windows.Forms.Button();
			this.browseOutButton = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.statusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inLabel
			// 
			this.inLabel.AutoSize = true;
			this.inLabel.Location = new System.Drawing.Point(18, 26);
			this.inLabel.Name = "inLabel";
			this.inLabel.Size = new System.Drawing.Size(86, 20);
			this.inLabel.TabIndex = 0;
			this.inLabel.Text = "PDF Input:";
			// 
			// outLabel
			// 
			this.outLabel.AutoSize = true;
			this.outLabel.Location = new System.Drawing.Point(18, 73);
			this.outLabel.Name = "outLabel";
			this.outLabel.Size = new System.Drawing.Size(111, 20);
			this.outLabel.TabIndex = 1;
			this.outLabel.Text = "Output Folder:";
			// 
			// outBox
			// 
			this.outBox.Location = new System.Drawing.Point(135, 70);
			this.outBox.Name = "outBox";
			this.outBox.Size = new System.Drawing.Size(509, 26);
			this.outBox.TabIndex = 2;
			this.outBox.TextChanged += new System.EventHandler(this.ValidateInput);
			// 
			// inBox
			// 
			this.inBox.Location = new System.Drawing.Point(135, 23);
			this.inBox.Name = "inBox";
			this.inBox.Size = new System.Drawing.Size(509, 26);
			this.inBox.TabIndex = 3;
			this.inBox.TextChanged += new System.EventHandler(this.ValidateInput);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(585, 186);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 38);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.Cancel);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(479, 186);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(100, 38);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.Convert);
			// 
			// browseInButton
			// 
			this.browseInButton.Location = new System.Drawing.Point(650, 21);
			this.browseInButton.Name = "browseInButton";
			this.browseInButton.Size = new System.Drawing.Size(36, 33);
			this.browseInButton.TabIndex = 6;
			this.browseInButton.Text = "...";
			this.browseInButton.UseVisualStyleBackColor = true;
			this.browseInButton.Click += new System.EventHandler(this.BrowseInput);
			// 
			// browseOutButton
			// 
			this.browseOutButton.Location = new System.Drawing.Point(650, 68);
			this.browseOutButton.Name = "browseOutButton";
			this.browseOutButton.Size = new System.Drawing.Size(36, 33);
			this.browseOutButton.TabIndex = 7;
			this.browseOutButton.Text = "...";
			this.browseOutButton.UseVisualStyleBackColor = true;
			this.browseOutButton.Click += new System.EventHandler(this.BrowseOutput);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(135, 147);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(551, 20);
			this.progressBar.TabIndex = 8;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(133, 124);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(74, 20);
			this.statusLabel.TabIndex = 9;
			this.statusLabel.Text = "Waiting...";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(703, 242);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.browseOutButton);
			this.Controls.Add(this.browseInButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.inBox);
			this.Controls.Add(this.outBox);
			this.Controls.Add(this.outLabel);
			this.Controls.Add(this.inLabel);
			this.Name = "Form";
			this.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
			this.Text = "PDF2Image";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label inLabel;
		private System.Windows.Forms.Label outLabel;
		private System.Windows.Forms.TextBox outBox;
		private System.Windows.Forms.TextBox inBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button browseInButton;
		private System.Windows.Forms.Button browseOutButton;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label statusLabel;
	}
}

