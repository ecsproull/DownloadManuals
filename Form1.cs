using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DownloadManuals
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void DownloadDocs(string docUrl, string savePath)
		{
			const int bufferSize = 1024 * 512;
			WebClient wc = new WebClient();
			
			if (docUrl.EndsWith(".ini") || docUrl.EndsWith(".db"))
				return;

			Stream sr = wc.OpenRead(docUrl);
			byte[] vs = new byte[bufferSize];
			sr.Read(vs, 0, bufferSize);
			var myString = Encoding.Default.GetString(vs);
			var doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(myString);
			var links = doc.DocumentNode.SelectNodes("//a");
			if (links == null)
				return;

			this.Invoke(new Action(() => statusTextBox.Text = docUrl));  ;
			foreach (var link in links)
			{
				if (link.InnerText == "[To Parent Directory]")
					continue;

				if (link.Attributes[0].Value.ToLower().EndsWith(".pdf"))
				{
					string fileName = Path.GetFileName(link.Attributes[0].Value);
					string fileSavePath;
					if (savePath.EndsWith("\\"))
					{
						fileSavePath = savePath + fileName;
					}
					else
					{
						fileSavePath = savePath + "\\" + fileName;
					}

					if (!File.Exists(fileSavePath))
					{
						string pdfUrl = "http://revrvdealers.com" + link.Attributes[0].Value;
						HttpWebRequest httpRequest = (HttpWebRequest)
							WebRequest.Create(pdfUrl);
						httpRequest.Method = WebRequestMethods.Http.Get;
						httpRequest.ContentType = "application/pdf";
						try
						{
							HttpWebResponse httpResponse
									= (HttpWebResponse)httpRequest.GetResponse();

							int bufferSize2 = 1024 * 512;
							int bytesRead = 0;
							using (FileStream fs = new FileStream(fileSavePath, FileMode.Create))
							using (Stream httpResponseStream = httpResponse.GetResponseStream())
							{
								byte[] buffer = new byte[bufferSize2];
								while ((bytesRead = httpResponseStream.Read(buffer, 0, bufferSize2)) != 0)
								{
									fs.Write(buffer, 0, bytesRead);
									buffer = new byte[bufferSize];
								}
							}
						}
						catch (Exception ex)
						{
							Invoke(new Action(() => listBox1.Items.Add(ex.Message + " " + pdfUrl)));
						}
					}
				}
				else
				{
					string nextPath;
					if (savePath.EndsWith("\\"))
					{
						nextPath = savePath + link.InnerText;
					}
					else
					{
						nextPath = savePath + "\\" + link.InnerText;
					}

					if (!Directory.Exists(nextPath))
					{
						Directory.CreateDirectory(nextPath);
					}

					string url = "http://revrvdealers.com" + link.Attributes[0].Value;
					DownloadDocs(url, nextPath);
				}
			}
			sr.Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			TextBox url = sender as TextBox;
			if (url.Text.ToLower().StartsWith("https"))
			{
				urlTextBox.Text = url.Text.ToLower().Replace("https", "http");
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			statusTextBox.Text = "Starting";
			Task.Run(() => DownloadDocs(urlTextBox.Text, localFolderTextBox.Text));
			statusTextBox.Text = "Done";
		}
	}
}
