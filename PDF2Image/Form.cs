//************************************************************************************************
// Copyright © 2021 Steven M Cohn.  All rights reserved.
//************************************************************************************************

#pragma warning disable S1172 // Unused method parameters should be removed

namespace PDF2Image
{
	using System;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Windows.Forms;
	using Windows.Data.Pdf;
	using Windows.Storage;
	using Windows.Storage.Streams;


	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}


		private void BrowseInput(object sender, EventArgs e)
		{
			using (var dialog = 
				new OpenFileDialog()
				{
					AddExtension = true,
					CheckFileExists = true,
					DefaultExt = ".pdf",
					Filter = "PDF Files (*.pdf)|*.pdf",
					Multiselect = false,
					ReadOnlyChecked = true,
					ShowReadOnly = false,
					//InitialDirectory = 
					Title = "Select PDF input file"
				})
			{
				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					inBox.Text = dialog.FileName;
				}
			}
		}


		private void BrowseOutput(object sender, EventArgs e)
		{

			using (var dialog =
				new FolderBrowserDialog()
				{
					Description = "Select output path",
					ShowNewFolderButton = true
				})
			{
				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					outBox.Text = dialog.SelectedPath;
				}
			}
		}


		private void ValidateInput(object sender, EventArgs e)
		{
			if (sender == inBox && outBox.Text.Trim().Length == 0 && File.Exists(inBox.Text))
			{
				outBox.Text = Path.GetDirectoryName(inBox.Text);
			}

			okButton.Enabled =
				inBox.Text.Trim().Length > 0 && File.Exists(inBox.Text) &&
				outBox.Text.Trim().Length > 0 && Directory.Exists(outBox.Text);
		}


		private void Cancel(object sender, EventArgs e)
		{
			Close();
		}


		private async void Convert(object sender, EventArgs e)
		{
			var basename = Path.Combine(
				outBox.Text, Path.GetFileNameWithoutExtension(inBox.Text));

			statusLabel.Text = $"Loading {inBox.Text}";
			var file = await StorageFile.GetFileFromPathAsync(inBox.Text);
			var doc = await PdfDocument.LoadFromFileAsync(file);

			progressBar.Maximum = (int)doc.PageCount;
			progressBar.Value = 0;

			for (int i = 0; i < doc.PageCount; i++)
			{
				statusLabel.Text = $"Processing page {i} of {doc.PageCount}";
				var page = doc.GetPage((uint)i);

				using (var stream = new InMemoryRandomAccessStream())
				{
					await page.RenderToStreamAsync(stream);

					using (var image = new Bitmap(stream.AsStream()))
					{
						var outpath = $"{basename}-{i}.png";
						image.Save(outpath, ImageFormat.Jpeg);
					}
				}

				progressBar.Increment(1);
			}

			statusLabel.Text = $"Completed writing images to {outBox.Text}";
		}
	}
}
