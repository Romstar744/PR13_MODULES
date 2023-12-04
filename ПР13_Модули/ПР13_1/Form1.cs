using System;
using System.IO;

namespace ПР13_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void fontDialog1_Apply(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void видToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 newForm = new Form2();
			newForm.Show();
			string message = "Текстовый редактор " +
				"разработал: студент группы ИП-21-3 " +
				"Старостин Роман Александрович";

			// Второй параметр - заголовок окна
			MessageBox.Show(message, "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fontDialog1.ShowDialog();
			textBox1.Font = fontDialog1.Font;
		}

		private void цветToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			textBox1.ForeColor = colorDialog1.Color;
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("завершить работу?", "предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes)
				Application.Exit();
		}

		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void файлToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = string.Empty;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog1.FileName; this.Text = "файл открыт " + fileName;
				try
				{
					StreamReader streamReader = new StreamReader(fileName);
					textBox1.Text = streamReader.ReadToEnd();
					streamReader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ошибка чтения \n" + ex.ToString());
				}
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog()== DialogResult.OK)
			{
				string fileName = saveFileDialog1.FileName;
				this.Text = "файл сохранен " + fileName;
				if (fileName != string.Empty)
				{
					FileInfo fileInfo = new FileInfo(fileName);
					try
					{
						StreamWriter streamWriter = fileInfo.CreateText();
						streamWriter.Write(textBox1.Text);
						streamWriter.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Ошибка чтения \n" + ex.ToString());
					}
				}
			}
		}
	}
}
