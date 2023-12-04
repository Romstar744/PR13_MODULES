namespace ПР13_1
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
			textBox1 = new TextBox();
			colorDialog1 = new ColorDialog();
			fontDialog1 = new FontDialog();
			menuStrip1 = new MenuStrip();
			видToolStripMenuItem = new ToolStripMenuItem();
			шрифтToolStripMenuItem = new ToolStripMenuItem();
			цветToolStripMenuItem = new ToolStripMenuItem();
			справкаToolStripMenuItem = new ToolStripMenuItem();
			выходToolStripMenuItem = new ToolStripMenuItem();
			openFileDialog1 = new OpenFileDialog();
			saveFileDialog1 = new SaveFileDialog();
			файлToolStripMenuItem = new ToolStripMenuItem();
			открытьToolStripMenuItem = new ToolStripMenuItem();
			сохранитьToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(0, 31);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(480, 360);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// fontDialog1
			// 
			fontDialog1.Apply += fontDialog1_Apply;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem, справкаToolStripMenuItem, выходToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(540, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// видToolStripMenuItem
			// 
			видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { шрифтToolStripMenuItem, цветToolStripMenuItem });
			видToolStripMenuItem.Name = "видToolStripMenuItem";
			видToolStripMenuItem.Size = new Size(39, 20);
			видToolStripMenuItem.Text = "Вид";
			видToolStripMenuItem.Click += видToolStripMenuItem_Click;
			// 
			// шрифтToolStripMenuItem
			// 
			шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
			шрифтToolStripMenuItem.Size = new Size(113, 22);
			шрифтToolStripMenuItem.Text = "Шрифт";
			шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
			// 
			// цветToolStripMenuItem
			// 
			цветToolStripMenuItem.Name = "цветToolStripMenuItem";
			цветToolStripMenuItem.Size = new Size(113, 22);
			цветToolStripMenuItem.Text = "Цвет";
			цветToolStripMenuItem.Click += цветToolStripMenuItem_Click;
			// 
			// справкаToolStripMenuItem
			// 
			справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			справкаToolStripMenuItem.Size = new Size(65, 20);
			справкаToolStripMenuItem.Text = "Справка";
			справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
			// 
			// выходToolStripMenuItem
			// 
			выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			выходToolStripMenuItem.Size = new Size(54, 20);
			выходToolStripMenuItem.Text = "Выход";
			выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.FileOk += openFileDialog1_FileOk;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.FileOk += saveFileDialog1_FileOk;
			// 
			// файлToolStripMenuItem
			// 
			файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
			файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			файлToolStripMenuItem.Size = new Size(48, 20);
			файлToolStripMenuItem.Text = "Файл";
			файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
			// 
			// открытьToolStripMenuItem
			// 
			открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			открытьToolStripMenuItem.Size = new Size(180, 22);
			открытьToolStripMenuItem.Text = "Открыть";
			открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
			// 
			// сохранитьToolStripMenuItem
			// 
			сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			сохранитьToolStripMenuItem.Size = new Size(180, 22);
			сохранитьToolStripMenuItem.Text = "Сохранить";
			сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(540, 507);
			Controls.Add(textBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Текстовый редактор";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private ColorDialog colorDialog1;
		private FontDialog fontDialog1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem видToolStripMenuItem;
		private ToolStripMenuItem справкаToolStripMenuItem;
		private ToolStripMenuItem шрифтToolStripMenuItem;
		private ToolStripMenuItem цветToolStripMenuItem;
		private ToolStripMenuItem выходToolStripMenuItem;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private ToolStripMenuItem файлToolStripMenuItem;
		private ToolStripMenuItem открытьToolStripMenuItem;
		private ToolStripMenuItem сохранитьToolStripMenuItem;
	}
}
