namespace webviewtest
{
	partial class Form1
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
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			button1 = new Button();
			menuStrip1 = new MenuStrip();
			aToolStripMenuItem = new ToolStripMenuItem();
			bToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Dock = DockStyle.Fill;
			webView21.Location = new Point(0, 58);
			webView21.Margin = new Padding(3, 30, 3, 3);
			webView21.Name = "webView21";
			webView21.Size = new Size(800, 392);
			webView21.TabIndex = 0;
			webView21.ZoomFactor = 1D;
			webView21.Click += webView21_Click;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.Location = new Point(0, 25);
			button1.Name = "button1";
			button1.Size = new Size(800, 33);
			button1.TabIndex = 1;
			button1.Text = "reload";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 25);
			menuStrip1.TabIndex = 2;
			menuStrip1.Text = "menuStrip1";
			// 
			// aToolStripMenuItem
			// 
			aToolStripMenuItem.Name = "aToolStripMenuItem";
			aToolStripMenuItem.Size = new Size(41, 21);
			aToolStripMenuItem.Text = "urls";
			// 
			// bToolStripMenuItem
			// 
			bToolStripMenuItem.Name = "bToolStripMenuItem";
			bToolStripMenuItem.Size = new Size(54, 21);
			bToolStripMenuItem.Text = "about";
			bToolStripMenuItem.Click += bToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(webView21);
			Controls.Add(button1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "tv 浏览器";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private Button button1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem aToolStripMenuItem;
		private ToolStripMenuItem bToolStripMenuItem;
	}
}