using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace ResistanceCalculator
{
	public partial class WindowMain : Form
	{
		Bitmap bitmapStencil; // Здесь отображается то, что видит пользователь на экране. Эта картинка присваивается при отрисовке pictureBox в pictureBox.Image
		
		PictureBoxPainting pictureFront;
		PictureBoxPainting pictureSide;

		Pen penEraser;

		//Надо поменять static
		public List<ConductorMaterial> materials;

		//Меняются в классе PictureBoxPainting при вызовов методов Action_Mouse...
		Point mousePreviousPosition; 
		Point mouseCurrentPosition;

		public ToolStripButton toolStripButtonCurrent;

		public bool isMaterialSettingsOpened = false;

		public WindowMain()
		{
			InitializeComponent();

			InitializeVariables();

			pictureFront.PaintStencil();
			pictureSide.PaintStencil();
		}

		public void InitializeVariables()
		{
			bitmapStencil = new Bitmap(pictureBoxFront.Width, pictureBoxFront.Height);

			pictureFront = new PictureBoxPainting(this, pictureBoxFront);
			pictureSide = new PictureBoxPainting(this, pictureBoxSide);
			pictureFront.MouseCurrentPosition = mouseCurrentPosition;
			pictureFront.MousePreviousPosition = mousePreviousPosition;

			penEraser = new Pen(Color.White, 5);

			AddStandartMaterials();
			//Так работать с comboBox намного удобнее, чем было до этого, когда я циклом проходио по всем его значениям и сравнивал с названиями из materials
			comboBoxConductorMaterial.DataSource = materials; //Связываю comboBox и List с материалами
			comboBoxConductorMaterial.DisplayMember = "Name"; //Выбираю поле для отображения у класса, из элементов которого составлен List
			comboBoxConductorMaterial.ValueMember = "Resistivity"; //Выбираю поле для значения у класса, из элементов которого составлен List
			
			pictureFront.CellSquare = trackBarScale.Value == 0 ? 1 : Convert.ToUInt32(trackBarScale.Value);
			pictureSide.CellSquare = pictureFront.CellSquare;
			pictureFront.CellRowCount = Convert.ToInt32(pictureBoxFront.Width / pictureBoxScale.Width);
			pictureSide.CellRowCount = pictureFront.CellRowCount;
			pictureFront.PixelInCellCount = Convert.ToInt32(Math.Pow(pictureBoxFront.Width / pictureFront.CellRowCount, 2));
			pictureSide.PixelInCellCount = pictureFront.PixelInCellCount;

			toolStripButtonCurrent = toolStripButtonPencil;
		}

		private void pictureBoxFront_Paint(object sender, PaintEventArgs e)
		{
			pictureFront.PictureBoxPaint(e);
		}

		private void pictureBoxSide_Paint(object sender, PaintEventArgs e)
		{
			pictureSide.PictureBoxPaint(e);
		}

		private void pictureBoxFront_MouseDown(object sender, MouseEventArgs e)
		{
			pictureFront.Action_MouseDown(e);
		}

		private void pictureBoxSide_MouseDown(object sender, MouseEventArgs e)
		{
			pictureSide.Action_MouseDown(e);
		}

		private void pictureBoxFront_MouseMove(object sender, MouseEventArgs e)
		{
			 
			pictureFront.Action_MouseMove(e);
		}

		private void pictureBoxSide_MouseMove(object sender, MouseEventArgs e)
		{
			pictureSide.Action_MouseMove(e);
		}

		private void pictureBoxFront_MouseUp(object sender, MouseEventArgs e)
		{
			pictureFront.Action_MouseUp(e); 
		}

		private void pictureBoxSide_MouseUp(object sender, MouseEventArgs e)
		{
			pictureSide.Action_MouseUp(e);
		}

		private void buttonClearField_Click(object sender, EventArgs e)
		{
			//BAD: Думаю, что можно лучше написать
			if (tabControlField.SelectedIndex == 0)
			{
				pictureFront.PaintStencil();
			}
			else if (tabControlField.SelectedIndex == 1)
			{
				pictureSide.PaintStencil();
			}
		}

		private void buttonCalculateResistance_Click(object sender, EventArgs e)
		{
			CalculateResistance();
		}

		private void WindowMain_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.Control)
			//{
			//	penFront.Color = Color.Aqua;
			//}
			//else if (e.Alt)
			//{
			//	penFront.Color = Color.Black;
			//}
			//else
			//{
			//	penFront.Color = Color.Red;
			//}
			e.Handled = true;
		}

		private void comboBoxConductorMaterial_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelResistivity.Text = "Удельное R = ";

			//TODO: Разобраться с компараторами с сделать сортировку элементов materials по значению удельного сопротивления (от меньшего к большему)
			panelColor.BackColor = ((ConductorMaterial)comboBoxConductorMaterial.SelectedItem).PixelColor;
			pictureFront.PenCurrent = new Pen(panelColor.BackColor, 5);
			pictureSide.PenCurrent = new Pen(panelColor.BackColor, 5);
			//NOTE: Мог использовать SelectedValue, но в этом случае при инициализации comboBox значениями из List это значение не равно Resisiivity. При смене значения всё становится хорошо. 
			labelResistivity.Text += ((ConductorMaterial)comboBoxConductorMaterial.SelectedItem).Resistivity;

			labelResistivity.Text += " Ом*мм^2/м";
		}

		private void trackBarScale_Scroll(object sender, EventArgs e)
		{
			if (trackBarScale.Value != 0)
				pictureFront.CellSquare = Convert.ToUInt32(Math.Pow(Math.Pow(pictureFront.CellRowCount,2), trackBarScale.Value));
			else
				pictureFront.CellSquare = 1;

			pictureSide.CellSquare = pictureFront.CellSquare;

			labelScaleMax.Text = Convert.ToInt32(Math.Sqrt(pictureFront.CellSquare)).ToString() + " мм";
		}

		private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			//Если элемент, на который нажали является кнопкой, то is вернёт true. Ещё есть as, который присваивает в переменную null, если нельзя привести к типу
			if (e.ClickedItem is ToolStripButton)
			{
				foreach (var toolStripElement in toolStrip.Items)
				{
					if (toolStripElement is ToolStripButton)
					{
						((ToolStripButton)toolStripElement).Checked = false;
					}

				}
				toolStripButtonCurrent = (ToolStripButton)e.ClickedItem;
				toolStripButtonCurrent.Checked = true;
			}
		}

		private void CalculateResistance()
		{
			pictureFront.CalculatePixelCount();

			textBoxPixelsCount.Text = "";
			textBoxSquares.Text = "";

			double resistance = 0;
			foreach (var material in materials)
			{
				double square = (material.PixelCount / ((double)pictureFront.PixelInCellCount / (double)pictureFront.CellSquare)); //Количество пикселей/количество пикселей в 1 мм^2
				if (square > 0)
					resistance += (material.Resistivity * (double)numericConductorLength.Value) / square;

				material.PrintSquare(textBoxSquares, square);
				material.PrintPixelCount(textBoxPixelsCount);
			}

			PrintResistance(resistance);

			foreach (var material in materials)
			{
				material.PixelCount = 0;
			}
		}

		private void PrintResistance(double resistance)
		{
			string measurementUnit = "Ом";
			double measurementCoefficient = 1;
			string stringFormat = "n3";

			const int kOm = 1000;
			const double mOm = 0.001;

			if (resistance >= kOm)
			{
				measurementUnit = "кОм";
				measurementCoefficient = kOm;
			}
			else if (resistance < 1)
			{
				measurementUnit = "мОм";
				measurementCoefficient = mOm;
				stringFormat = "n0";
			}
			labelResistance.Text = "Сопротивление = "
				+ (resistance / measurementCoefficient).ToString(stringFormat)
				+ " " + measurementUnit;
		}

		private void AddStandartMaterials()
		{
			materials = new List<ConductorMaterial>
			{
				new ConductorMaterial("Серебро", Color.Silver, 0.016),
				new ConductorMaterial("Медь", Color.Orange, 0.017),
				new ConductorMaterial("Золото", Color.Gold, 0.024),
				new ConductorMaterial("Алюминий", Color.LightGray, 0.028),
				new ConductorMaterial("Вольфрам", Color.Gray, 0.055),
				new ConductorMaterial("Железо", Color.DarkSlateGray, 0.1)
			};
		}

		public void AddNewMaterial(ConductorMaterial newMaterial)
		{
			materials.Add(newMaterial);
			ComboBoxRefresh();
		}

		public void DeleteMaterial(string materialName)
		{
			//TODO: Переделать на нормальный поиск удаляемого значения
			//TODO: ComboBox не обновляется автоматически при вставке и удалении данных
			int indexInList = 0;
			foreach (var material in materials)
			{
				if (material.Name == materialName)
				{
					materials.RemoveAt(indexInList);
					break;
				}
				indexInList++;
			}
			ComboBoxRefresh();
		}

		private void ComboBoxRefresh()
		{
			//Для обновления comboBox. Возможно можно сделать по-другому
			string previousDisplayMember = comboBoxConductorMaterial.DisplayMember;
			comboBoxConductorMaterial.DisplayMember = "";
			comboBoxConductorMaterial.DisplayMember = previousDisplayMember;
			comboBoxConductorMaterial.SelectedIndex = comboBoxConductorMaterial.Items.Count-1;
		}

		private void MainWindow_HelpButtonClicked(object sender, CancelEventArgs e)
		{
			WindowAbout windowAbout = new WindowAbout();
			windowAbout.Show();
			e.Cancel = true;
		}

		private void pictureBoxScale_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Black, 1);
			e.Graphics.DrawLine(pen, 0, 0, 0, pictureBoxScale.Height);
			e.Graphics.DrawLine(pen, 0, pictureBoxScale.Height / 2, pictureBoxScale.Width, pictureBoxScale.Height / 2);
			e.Graphics.DrawLine(pen, pictureBoxScale.Width - 1, 0, pictureBoxScale.Width - 1, pictureBoxScale.Height);
		}

		//BAD: Переделать взаимодействие окон. Сейчас оно ужасно
		private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
		{
			OpenWindowMaterialSettings(null);
		}

		private void toolStripMenuItemChange_Click(object sender, EventArgs e)
		{
			string materialName = ((ConductorMaterial)comboBoxConductorMaterial.SelectedItem).Name;

			foreach (var currentMaterial in materials)
			{
				if (currentMaterial.Name == materialName)
				{
					OpenWindowMaterialSettings(currentMaterial);
				}
			}
		}

		private void OpenWindowMaterialSettings(ConductorMaterial materialForChanging)
		{
			if (!isMaterialSettingsOpened)
			{
				WindowMaterialSettings windowMaterialSettings = new WindowMaterialSettings(materialForChanging);
				windowMaterialSettings.Owner = this;
				windowMaterialSettings.Show();
				isMaterialSettingsOpened = true;
			}
		}
	}
}
