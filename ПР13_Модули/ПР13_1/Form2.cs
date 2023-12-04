using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ПР13_1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
		private void ShowMessageBoxButton_Click(object sender, EventArgs e)
		{
			string message = "Текстовый редактор " +
				"разработал: студент группы ИП-21-3" +
				"Старостин Роман Александрович";

			// Второй параметр - заголовок окна
			MessageBox.Show(message, "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
		
	}
}
