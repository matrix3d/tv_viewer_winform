using Microsoft.Web.WebView2.WinForms;
using System;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace webviewtest
{
	public partial class Form1 : Form
	{
		MyInteropObject ooo;
		public Form1()
		{
			InitializeComponent();

			myinit();
		}

		void myinit()
		{
			webView21.CoreWebView2InitializationCompleted += (a,b) => {
				ooo = new MyInteropObject();
				ooo.webView2 = webView21;
				webView21.CoreWebView2.AddHostObjectToScript("Android",ooo );
			};

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
			"https://www.yangshipin.cn/?a=1#/tv/home?pid=600002309",
			"https://www.yangshipin.cn/?a=2#/tv/home?pid=600002521",
			"https://www.yangshipin.cn/?a=3#/tv/home?pid=600002483",
			"https://www.yangshipin.cn/?a=4#/tv/home?pid=600002520",
			"https://www.yangshipin.cn/?a=5#/tv/home?pid=600002475",
			"https://www.yangshipin.cn/?a=6#/tv/home?pid=600002508",
			"https://www.yangshipin.cn/?a=7#/tv/home?pid=600002485",
			"https://www.yangshipin.cn/?a=8#/tv/home?pid=600002509",
			"https://www.yangshipin.cn/?a=9#/tv/home?pid=600002498",
			"https://www.yangshipin.cn/?a=10#/tv/home?pid=600002506",
			"https://www.yangshipin.cn/?a=11#/tv/home?pid=600002531",
			"https://www.yangshipin.cn/?a=12#/tv/home?pid=600002481",
			"https://www.yangshipin.cn/?a=13#/tv/home?pid=600002516",
			"https://www.yangshipin.cn/?a=14#/tv/home?pid=600002525",
			"https://www.yangshipin.cn/?a=15#/tv/home?pid=600002484",
			"https://www.yangshipin.cn/?a=16#/tv/home?pid=600002490",
			"https://www.yangshipin.cn/?a=17#/tv/home?pid=600002503",
			"https://www.yangshipin.cn/?a=18#/tv/home?pid=600002505",
			"https://www.yangshipin.cn/?a=19#/tv/home?pid=600002532",
			"https://www.yangshipin.cn/?a=20#/tv/home?pid=600002493",
			"https://www.yangshipin.cn/?a=21#/tv/home?pid=600002513",
			"https://www.bilibili.com/video/BV1NP411u7br/?spm_id_from=333.999.0.0&vd_source=14579d0fcae623fe6f711a6a0345a160",
			"https://www.gdtv.cn/tvChannelDetail/51",
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
					ooo.waitReload=false;
					if (url.StartsWith("https://www.yangshipin.cn"))
					{
						ooo.waitReload = true;
						//webView21.Reload();
					}
					webView21.CoreWebView2.Navigate(url);
				};
			}
			
			webView21.NavigationCompleted += (a, b) =>
			{
				//webView21.CoreWebView2.ExecuteScriptAsync(" document.querySelector('video').play();document.querySelector('video').requestFullscreen();");
				webView21.CoreWebView2.ExecuteScriptAsync(@"
					function af(){ 
                                         var fullscreenBtn = document.querySelector('#player_pagefullscreen_yes_player')||document.querySelector('.videoFull')||document.querySelector('.vjs-fullscreen-control');
                                         if(fullscreenBtn!=null){
                                            //alert(fullscreenBtn)
											fullscreenBtn.click();
											var v=document.querySelector('video');
											v.volume=1;
											v.requestFullscreen();
											if(document.querySelector('.vjs-fullscreen-control')!=null){

												v.style.position = 'fixed';
												v.style.top = '0';
												v.style.left = '0';
												v.style.width = '50%';
												v.style.height = '100%';
												v.style.zIndex = '9999';
												v.style.objectFit= 'contain'; /* 保持宽高比，视频铺满容器 */
												const aspectRatio = v.videoWidth / v.videoHeight;
												const screenRatio = window.innerWidth / window.innerHeight;
												//alert(v.videoWidth +"",""+ v.videoHeight+window.innerWidth +"",""+ window.innerHeight);
											}
											// alert(window.location.href+window.chrome.webview.hostObjects.Android.reload);
											window.chrome.webview.hostObjects.Android.reload(""Hello from WebView!"")
                                         }else{
                                             setTimeout(
                                                ()=>{ af();}
                                            ,16); 
                                         }
                                     }
                                af()

					//var a= document.querySelector('video');
					//alert(a+document)
					//window.addEventListener('load', function() {
						//alert(document.querySelector('video').requestFullscreen());	
					//	document.querySelector('video').requestFullscreen();
					//});
					"
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

public class MyInteropObject
{
	public bool waitReload;
	public WebView2 webView2;
	// 在这里定义供 JavaScript 调用的方法
	public void reload(string message)
	{
		if (waitReload)
		{
			//MessageBox.Show("C# method called from JavaScript with message: " + message);
			//webView2.CoreWebView2.Reload();
			waitReload = false;

			//MessageBox.Show("C# method called from JavaScript with message:2 " + message);
		}
	}
}