using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResistanceCalculator
{
	public partial class WindowMaterialSettings : Form
	{
		WindowMain windowMain;
		ConductorMaterial currentMaterial;

		public WindowMaterialSettings(ConductorMaterial materialForChanging)
		{
			InitializeComponent();

			this.currentMaterial = materialForChanging;
			if (materialForChanging != null)
			{
				textBoxName.Text = materialForChanging.Name;
				numericUpDownResistivity.Value = Convert.ToDecimal(materialForChanging.Resistivity);
				panelColor.BackColor = materialForChanging.PixelColor;
			}
		}

		private void WindowMaterialSettings_Load(object sender, EventArgs e)
		{
			//Пытался сделать это при инициализации, но присваивание владельца происходит уже после создания формы в коде основной формы
			windowMain = this.Owner as WindowMain; //для того, чтобы иметь возможность обрщаться к полям формы-владельца
		}

		private void panelColor_Click(object sender, EventArgs e)
		{
			colorDialog.ShowDialog();
			panelColor.BackColor = colorDialog.Color;
		}

		private bool IsColorAvailable(Color color)
		{
			bool result = true;

			result = PictureBoxPainting.IsAvailableColor(color);

			foreach(var material in windowMain.materials)
			{
				if (material.PixelColor == color)
				{
					if (currentMaterial != null && currentMaterial.PixelColor != color)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		private bool IsNameAvailable(string name)
		{
			bool result = true;

			if (textBoxName.Text == "")
				result = false;

			foreach (var material in windowMain.materials)
			{
				if (material.Name == name)
				{
					if (currentMaterial != null && currentMaterial.Name != name)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}

		private void buttonAccept_Click(object sender, EventArgs e)
		{
			if (IsNameAvailable(textBoxName.Text))
			{
				if (IsColorAvailable(colorDialog.Color))
				{
					ConductorMaterial newConductorMaterial = new ConductorMaterial(
						textBoxName.Text,
						panelColor.BackColor,
						Convert.ToDouble(numericUpDownResistivity.Value)
						);

					if (currentMaterial != null)
					{
						windowMain.DeleteMaterial(currentMaterial.Name);
						windowMain.AddNewMaterial(newConductorMaterial);
					}
					else
					{
						windowMain.AddNewMaterial(newConductorMaterial);
					}
					this.Close();
				}
				else
				{
					MessageBox.Show("Нельзя создать материал с таким цветом");
				}
			}
			else
			{
				MessageBox.Show("Нельзя создать материал с таким именем");
			}
		}

		private void WindowMaterialSettings_FormClosed(object sender, FormClosedEventArgs e)
		{
			windowMain.isMaterialSettingsOpened = false;
		}
	}
}
