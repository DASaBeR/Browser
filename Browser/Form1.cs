using Microsoft.Web.WebView2.Core;
using System.Diagnostics;

namespace Browser
{
	public partial class Form1 : Form
	{
		private bool isPageLoaded = false;
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{

			await webView21.EnsureCoreWebView2Async(null);
			webView21.CoreWebView2.Navigate("https://twitter.com/login");
			webView21.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;

		}

		private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
		{
			// Check if WebView2 initialization is successful
			if (e.IsSuccess)
			{
				var currentUrl = webView21.CoreWebView2.Source;
				if (currentUrl != null && currentUrl.Contains("https://twitter.com/login"))
				{
					webView21.Enabled = true;
					//webView21.MouseClick += WebView21_MouseClick;
				}
				else
				{
					webView21.Enabled = false;
				}
				isPageLoaded = true;
				//await webView21.CoreWebView2.ExecuteScriptAsync("console.log('Hello World')");
				//Debug.WriteLine("WebView_CoreWebView2InitializationCompleted");
			}
			else
			{
				// Handle initialization failure
				MessageBox.Show("WebView2 initialization failed!");
			}
		}
		private async void button1_ClickAsync(object sender, EventArgs e)
		{
			if (isPageLoaded)
			{
				await webView21.CoreWebView2.ExecuteScriptAsync(textBox1.Text);

				var currentUrl = webView21.CoreWebView2.Source;

				await webView21.CoreWebView2.ExecuteScriptAsync($"console.log(\"{currentUrl}\")");
			}
		}
	}
}