using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace _60_Parsecs_Sprite_Generator
{
	public partial class GenForm : Form
	{
		private StateKeeper stateKeeper = new StateKeeper(); //объект для хранения последних изменений статов
		private String currentStats; // строка текущих сохраненных статов
		public GenForm()
		{
			InitializeComponent();
		}
		private String GetCurrentStats() //получить текущее выбранное имя персонажа и сохраненные rb и cb
		{
			return NamesList.SelectedItem.ToString() + currentStats;
		}
		private String SaveCurrentStats() //сохранить и получить строку-ключ текущих статов
		{
			String cState = "";
			// перебираем все элементы управления типа RadioButton и CheckBox и добавляем в cState по порядку

			foreach (RadioButton butt in this.groupGStats.Controls) //в группе General Status
			{
				if (butt.Checked) //если имеется особый статус
				{
					//добавляем этот статус в lastState
					cState += butt.Text.ToString();
					break;
				}
			}

			if (this.groupHair.Enabled) //если главный статус не Communist
			{
				foreach (RadioButton butt in this.groupHair.Controls) //в группе Hair Progress
				{
					if (butt.Checked) //если имеется особый статус
					{
						//добавляем этот статус в lastState
						cState += butt.Text.ToString();
						break;
					}
				}
			}
			if (this.groupMor.Enabled) //если главный статус не Traitor, Dead или Insane
			{
				foreach (RadioButton butt in this.groupMor.Controls) //в группе Morale
				{
					if (butt.Checked) //если имеется особый статус
					{
						//добавляем этот статус в lastState
						cState += butt.Text.ToString();
						break;
					}
				}
			}

			if (this.groupOStats.Enabled) //если главный статус не Traitor, Dead или Insane
			{
				foreach (CheckBox chck in this.groupOStats.Controls) //CheckBox в группе Other Stats
				{
					if (chck.Checked) //если имеется особый статус
					{
						//добавляем этот статус в lastState
						cState += chck.Text.ToString();
					}
				}
			}
			return cState;
		}
		private void NamesListCharactChanged(object sender, EventArgs e) {
			//если пользователь выбрал персонажа из списка
			//открываем доступ к настройкам спрайтов
			if (NamesList.SelectedIndex == 0 || NamesList.SelectedIndex == 2)
			{
				if (!this.groupGStats.Enabled) this.groupGStats.Enabled = true;
				if (!this.groupHair.Enabled) this.groupHair.Enabled = true;
				if (!this.groupMor.Enabled) this.groupMor.Enabled = true;
				if (!this.groupOStats.Enabled) this.groupOStats.Enabled = true;
			}
			else
			{
				if (this.groupGStats.Enabled) this.groupGStats.Enabled = false;
				if (this.groupHair.Enabled) this.groupHair.Enabled = false;
				if (this.groupMor.Enabled) this.groupMor.Enabled = false;
				if (this.groupOStats.Enabled) this.groupOStats.Enabled = false;
			}
		}
		//метод, возникающий после изменения какого-либо из параметров статусов
		private void changedEvent(object sender, EventArgs e)
		{
			//убираем ненужные статы для конкретного статуса
			this.groupMor.Enabled = (IsCheckedSpecStats() || this.checkIns.Checked) ? false : true;
			this.groupOStats.Enabled = (IsCheckedSpecStats()) ? false : true;
			this.groupHair.Enabled = (this.buttComm.Checked) ? false : true;

			currentStats = SaveCurrentStats(); //сохраняем значения активных элементов формы

			//если новые текущие статы отличаются от сохраненных в StateKeeper
			if (stateKeeper.GetLastStates() != this.GetCurrentStats()) 
			{
				//если изменение произошло
				//MessageBox.Show(NamesList.Text.ToString() + '\n' + currstats, "", MessageBoxButtons.OK);

				//изменяем картинку отображения нового спрайта
				SpriteDegenerate();

				stateKeeper.SaveNewStates(currentStats); //сохраняем новые значения статов в класс Keeper
			};
		}
		//функция проверки какого-либо из включенных особых статусов (Traitors or Dead)
		private Boolean IsCheckedSpecStats() 
		{
			return this.buttAlien.Checked || this.buttAndr.Checked || this.buttComm.Checked || this.buttDead.Checked; 
		}

		//метод генерации конечного спрайта
		private void SpriteDegenerate() 
		{
			Bitmap finalsprite;
			if (CharacterStatuses.statuses.ContainsKey(currentStats)) //если присутствует ключ статов в словаре
			{
				finalsprite = getSprite(); //генерируем спрайт
				if(finalsprite != null) this.PBoxSprite.Image = finalsprite; //и помещаем в PictureBox
			}
		}

		//функция генерации конечного спрайта
		private Bitmap getSprite() 
		{
			//формируем конечное изображение из слоёв получившихся спрайтов

			List<Bitmap> sprites = new List<Bitmap>();
			Bitmap finalSprite = new Bitmap(1200, 1800); //создаём конечный спрайт с параметрами

			//перебираем список всех имён файлов спрайтов
			for (int i = 0; i < CharacterStatuses.statuses[currentStats].Count; ++i)
			{
				Bitmap bitmap;
				switch (NamesList.SelectedIndex)
				{
					case 0:
						bitmap = (Bitmap)Properties.April.ResourceManager.GetObject(CharacterStatuses.statuses[currentStats][i]);
						if (bitmap != null) sprites.Add(bitmap);
						break;
					//case 1:
					//	break;
					case 2:
						bitmap = (Bitmap)Properties.Deedee.ResourceManager.GetObject(CharacterStatuses.statuses[currentStats][i]);
						if (bitmap != null) sprites.Add(bitmap);
						break;
					//case 3:
					//	break;
					//case 4:
					//	break;
					//case 5:
					//	break;
					default:
						break;
				}
			};
			if (sprites.Count == 0) return null;
			using (Graphics g = Graphics.FromImage(finalSprite))
			{
				//set background color
				g.Clear(Color.Transparent);

				//go through each image and draw it on the final image (Notice the offset; since I want to overlay the images i won't have any offset between the images in the finalImage)
				int offset = 0;
				foreach (Bitmap s in sprites)
				{
					g.DrawImage(s, new Rectangle(offset, 0, s.Width, s.Height));
				}
			}
			//Draw the final image in the pictureBox
			//In my case I clear the List because i run this in a cycle and the number of layers is not fixed 
			//this.PBoxSprite.Image = finalSprite;
			sprites.Clear();
			return finalSprite;
		}
		private Bitmap GetFinalSprite(Bitmap img, Bitmap backimg) //получить конечное изображения для сохранения
		{
			Bitmap[] imags = new Bitmap[2]{ backimg, img };

			Bitmap finalImage = new Bitmap(1200, 1800); //создаём конечный спрайт с параметрами

			using (Graphics g = Graphics.FromImage(finalImage))
			{
				//set background color
				g.Clear(Color.Transparent);

				//go through each image and draw it on the final image (Notice the offset; since I want to overlay the images i won't have any offset between the images in the finalImage)
				int offset = 0;
				foreach (Bitmap s in imags)
				{
					if (s != null)
					{
						g.DrawImage(s, new Rectangle(offset, 0, s.Width, s.Height));
					}
				}
			}

			Array.Clear(imags, 0, 2); //очищаем память массива

			return finalImage;
		}
		private void saveSpriteAsToolStripMenuItem_Click(object sender, EventArgs e) //сохранить полученный спрайт как png
		{
			//задаём имя сохраняемого файла
			String fileName = currentStats;

			//сохраняем полученное изображение по пользовательскому пути
			CommonOpenFileDialog OFDialog = new CommonOpenFileDialog();
			OFDialog.IsFolderPicker = true;

			if ((Bitmap)this.PBoxSprite.Image != null) //если спрайт был сгенерирован
			{
				if (OFDialog.ShowDialog() == CommonFileDialogResult.Ok)
				{
						//компануем backImg и Image с PictureBox в один png-файл
						Bitmap fImage = GetFinalSprite((Bitmap)this.PBoxSprite.Image, (Bitmap)this.PBoxSprite.BackgroundImage); //если пользователь выбрал директорию,
																																//формируем конечное сохраняемое изображение

						//для удобства поиска пользователем сохраненного файла, создадим дополнительно папку с именем персонажа
						//в выбранном пользователем каталоге

						String savingPath = $@"{OFDialog.FileName}{Path.DirectorySeparatorChar}{NamesList.SelectedItem.ToString()}";
						//проверяем, создана ли уже директория
						if (!Directory.Exists(savingPath))
						{
							//если нет, то создаём
							Directory.CreateDirectory(savingPath);
						}
						//сохраняем полученное изображение по выбранному измененному пути
						fImage.Save($@"{savingPath}{Path.DirectorySeparatorChar}{fileName}.png", ImageFormat.Png);

						System.Diagnostics.Process.Start("explorer.exe", savingPath); //открываем пользователю каталог
																					  //сохраненного файла
				}
			}
			else { MessageBox.Show("Sprite hadn't been generated yet!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			//MessageBox.Show(OFDialog.FileName, "", MessageBoxButtons.OK);
		}
		private void DarkThemeSelect(object sender, EventArgs e) //процедура включения дневной темы
		{
			darkToolStripMenuItem.Checked = true;
			lightToolStripMenuItem.Checked = !darkToolStripMenuItem.Checked; //убираем включение светлой темы

			//изменяем цветовую палитру окна ... V

			//изменяем цветовую палитру меню
			menuStrip1.BackColor = Color.FromArgb(20, 20, 20);
			fileToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
			viewToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;

			saveSpriteAssItem.BackColor = SystemColors.ControlDarkDark;
			saveSpriteAssItem.ForeColor = SystemColors.ButtonHighlight;

			quitToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
			quitToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;

			changeThemeToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
			changeThemeToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
			darkToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
			darkToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
			lightToolStripMenuItem.BackColor= SystemColors.ControlDarkDark;
			lightToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;

			//изменяем цветовую палитру главного окна и элементов в нём
			label1.ForeColor = SystemColors.ButtonHighlight;
			NamesList.BackColor = SystemColors.WindowFrame;
			NamesList.ForeColor = SystemColors.ButtonHighlight;

			groupGStats.ForeColor = SystemColors.ButtonHighlight;
			groupHair.ForeColor = SystemColors.ButtonHighlight;
			groupMor.ForeColor = SystemColors.ButtonHighlight;
			groupOStats.ForeColor = SystemColors.ButtonHighlight;
			groupBSprite.ForeColor = SystemColors.ButtonHighlight;

			label2.ForeColor = SystemColors.ButtonHighlight;
			verLabel.ForeColor = SystemColors.ButtonHighlight;

			PBoxSprite.BackColor = Color.FromArgb(30, 30, 30);

			//изменяем цвет главного окна
			this.BackColor = Color.FromArgb(40, 40, 40);
		}

		private void LightThemeSelect(object sender, EventArgs e) //процедура включения ночной темы
		{
			lightToolStripMenuItem.Checked = true;
			darkToolStripMenuItem.Checked = !lightToolStripMenuItem.Checked; //убираем включение тёмной темы

			//изменяем цветовую палитру окна ... V

			//изменяем цветовую палитру меню
			menuStrip1.BackColor = Color.LightGray;
			fileToolStripMenuItem.ForeColor = SystemColors.ControlText;
			viewToolStripMenuItem.ForeColor = SystemColors.ControlText;

			saveSpriteAssItem.BackColor = SystemColors.Control;
			saveSpriteAssItem.ForeColor = SystemColors.ControlText;

			quitToolStripMenuItem.BackColor = SystemColors.Control;
			quitToolStripMenuItem.ForeColor = SystemColors.ControlText;

			changeThemeToolStripMenuItem.BackColor = SystemColors.Control;
			changeThemeToolStripMenuItem.ForeColor = SystemColors.ControlText;
			darkToolStripMenuItem.BackColor = SystemColors.Control;
			darkToolStripMenuItem.ForeColor = SystemColors.ControlText;
			lightToolStripMenuItem.BackColor = SystemColors.Control;
			lightToolStripMenuItem.ForeColor = SystemColors.ControlText;

			//изменяем цветовую палитру главного окна и элементов в нём
			label1.ForeColor = SystemColors.ControlText;
			NamesList.BackColor = SystemColors.Window;
			NamesList.ForeColor = SystemColors.ControlText;

			groupGStats.ForeColor = SystemColors.ControlText;
			groupHair.ForeColor = SystemColors.ControlText;
			groupMor.ForeColor = SystemColors.ControlText;
			groupOStats.ForeColor = SystemColors.ControlText;
			groupBSprite.ForeColor = SystemColors.ControlText;

			label2.ForeColor = SystemColors.ControlText;
			verLabel.ForeColor = SystemColors.ControlText;

			PBoxSprite.BackColor = Color.DarkGray;

			//изменяем цвет главного окна
			this.BackColor = SystemColors.Control;
		}
		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
