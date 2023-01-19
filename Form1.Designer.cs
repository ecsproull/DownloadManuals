namespace DownloadManuals
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.urlTextBox = new System.Windows.Forms.TextBox();
			this.localFolderTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.statusTextBox = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL Start";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Local Folder";
			// 
			// urlTextBox
			// 
			this.urlTextBox.Location = new System.Drawing.Point(42, 48);
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.Size = new System.Drawing.Size(512, 20);
			this.urlTextBox.TabIndex = 2;
			this.urlTextBox.Text = "http://revrvdealers.com/manuals/";
			this.urlTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// localFolderTextBox
			// 
			this.localFolderTextBox.Location = new System.Drawing.Point(42, 103);
			this.localFolderTextBox.Name = "localFolderTextBox";
			this.localFolderTextBox.Size = new System.Drawing.Size(512, 20);
			this.localFolderTextBox.TabIndex = 3;
			this.localFolderTextBox.Text = "C:\\Users\\USER\\OneDrive\\DiscoveryDrawings\\";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(42, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Go";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// statusTextBox
			// 
			this.statusTextBox.Location = new System.Drawing.Point(42, 213);
			this.statusTextBox.Name = "statusTextBox";
			this.statusTextBox.Size = new System.Drawing.Size(524, 20);
			this.statusTextBox.TabIndex = 5;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(42, 255);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(524, 186);
			this.listBox1.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.statusTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.localFolderTextBox);
			this.Controls.Add(this.urlTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox urlTextBox;
		private System.Windows.Forms.TextBox localFolderTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox statusTextBox;
		private System.Windows.Forms.ListBox listBox1;
	}
}

