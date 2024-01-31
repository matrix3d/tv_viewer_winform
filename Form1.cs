using System;
using System.Security.Policy;

namespace webviewtest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			myinit();
		}

		void myinit()
		{

			button1.Click += (a, b) =>
			{
				webView21.CoreWebView2.Reload();// .Navigate("https://tv.cctv.com/live/cctv2/");
												//MessageBox.Show("aaa");
			};

			string[] liveUrls = {
			"https://tv.cctv.com/live/cctv1/",
			"https://tv.cctv.com/live/cctv2/",
			"https://tv.cctv.com/live/cctv3/",
			"https://tv.cctv.com/live/cctv4/",
			"https://tv.cctv.com/live/cctv5/",
			"https://tv.cctv.com/live/cctv6/",
			"https://tv.cctv.com/live/cctv7/",
			"https://tv.cctv.com/live/cctv8/",
			"https://tv.cctv.com/live/cctvjilu",
			"https://tv.cctv.com/live/cctv10/",
			"https://tv.cctv.com/live/cctv11/",
			"https://tv.cctv.com/live/cctv12/",
			"https://tv.cctv.com/live/cctv13/",
			"https://tv.cctv.com/live/cctvchild",
			"https://tv.cctv.com/live/cctv15/",
			"https://tv.cctv.com/live/cctv16/",
			"https://tv.cctv.com/live/cctv17/",
			"https://tv.cctv.com/live/cctv5plus/",
			"https://tv.cctv.com/live/cctveurope",
			"https://tv.cctv.com/live/cctvamerica/",
			"https://www.yangshipin.cn/#/tv/home?pid=600002309",
			"https://www.yangshipin.cn/#/tv/home?pid=600002521",
			"https://www.yangshipin.cn/#/tv/home?pid=600002483",
			"https://www.yangshipin.cn/#/tv/home?pid=600002520",
			"https://www.yangshipin.cn/#/tv/home?pid=600002475",
			"https://www.yangshipin.cn/#/tv/home?pid=600002508",
			"https://www.yangshipin.cn/#/tv/home?pid=600002485",
			"https://www.yangshipin.cn/#/tv/home?pid=600002509",
			"https://www.yangshipin.cn/#/tv/home?pid=600002498",
			"https://www.yangshipin.cn/#/tv/home?pid=600002506",
			"https://www.yangshipin.cn/#/tv/home?pid=600002531",
			"https://www.yangshipin.cn/#/tv/home?pid=600002481",
			"https://www.yangshipin.cn/#/tv/home?pid=600002516",
			"https://www.yangshipin.cn/#/tv/home?pid=600002525",
			"https://www.yangshipin.cn/#/tv/home?pid=600002484",
			"https://www.yangshipin.cn/#/tv/home?pid=600002490",
			"https://www.yangshipin.cn/#/tv/home?pid=600002503",
			"https://www.yangshipin.cn/#/tv/home?pid=600002505",
			"https://www.yangshipin.cn/#/tv/home?pid=600002532",
			"https://www.yangshipin.cn/#/tv/home?pid=600002493",
			"https://www.yangshipin.cn/#/tv/home?pid=600002513",
			"https://www.bilibili.com/video/BV1NP411u7br/?spm_id_from=333.999.0.0&vd_source=14579d0fcae623fe6f711a6a0345a160",
	};
			webView21.Source = new Uri(liveUrls[6]);
			for (var i=0;i< liveUrls.Length;i++)
			{
				var url = liveUrls[i];
				var eitem = new ToolStripMenuItem();
				eitem.Name = url;
				eitem.Size = new Size(27, 21);
				eitem.Text = url;
				aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eitem });
				eitem.Click += (a, b) =>
				{

					foreach (var item in aToolStripMenuItem.DropDownItems)
					{
						var item2 = item as ToolStripMenuItem;
						if (item2 != null)
						{
							item2.Checked = false;
						}
					}
					eitem.Checked = true;
					webView21.CoreWebView2.Navigate(url);
				};
			}

			webView21.NavigationStarting += (a, b) =>
			{
				//webView21.CoreWebView2.ExecuteScriptAsync(" document.querySelector('video').play();document.querySelector('video').requestFullscreen();");
				webView21.CoreWebView2.ExecuteScriptAsync("" +
					"var a= document.querySelector('video');" +
					//"alert(a+document)"+
					"window.addEventListener('load', function() {" +
					"document.querySelector('video').requestFullscreen();" +
					"});"
					);
				//webView21.CoreWebView2.ExecuteScriptAsync("fullscreen");
				//.this.webView.InvokeScriptAsync("fullscreen", new string[] { }); .CoreWebView2.ExecuteScriptAsync($"alert('{b.Uri} is not safe, try an https link')");
				//MessageBox.Show(b.Uri);
			};
		}

		private void webView21_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void dToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void bToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}