namespace Browser
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
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			textBox1 = new TextBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(12, 12);
			webView21.Name = "webView21";
			webView21.Size = new Size(787, 566);
			webView21.TabIndex = 0;
			webView21.ZoomFactor = 1D;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(822, 12);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(253, 467);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(822, 495);
			button1.Name = "button1";
			button1.Size = new Size(253, 57);
			button1.TabIndex = 2;
			button1.Text = "Execute Script";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_ClickAsync;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1101, 590);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(webView21);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private TextBox textBox1;
		private Button button1;
	}
}