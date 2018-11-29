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

		public string Name { get; }
		public double Resistivity { get; } //(Ом * мм^2)/м
		public Color PixelColor { get; }
		public int PixelCount { get; set; }
	}
}
