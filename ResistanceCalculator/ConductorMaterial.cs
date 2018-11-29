using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ResistanceCalculator
{
	public class ConductorMaterial
	{
		public ConductorMaterial(string name, Color pixelColor, double resistivity)
		{
			this.Name = name;
			this.PixelColor = pixelColor;
			this.Resistivity = resistivity;
			this.PixelCount = 0;
		}

		public void PrintSquare(TextBox textBoxToPrint, double square)
		{
			if (square <= 0)
			{
				return;
			}

			string measurementUnit = "мм^2";
			Int64 measurementCoefficient = 1;
			string stringFormat = "n2";

			const int mInSquare = 1000000; //мм^2
			const int cmInSquare = 100; //мм^2

			if (square > mInSquare)
			{
				measurementUnit = "м^2";
				measurementCoefficient = mInSquare;
				stringFormat = "n3";
			}
			else if (square > cmInSquare)
			{
				measurementUnit = "см^2";
				measurementCoefficient = cmInSquare;
				stringFormat = "n3";
			}
			textBoxToPrint.Text += this.Name + ": "
				+ (square / measurementCoefficient).ToString(stringFormat)
				+ " " + measurementUnit
				+ Environment.NewLine;
		}

		public void PrintPixelCount(TextBox textBoxToPrint)
		{
			if (this.PixelCount <= 0)
			{
				return;
			}

			textBoxToPrint.Text += this.Name + ": " + this.PixelCount.ToString() + Environment.NewLine;
		}

		public string Name { get; }
		public double Resistivity { get; } //(Ом * мм^2)/м
		public Color PixelColor { get; }
		public int PixelCount { get; set; }
	}
}
