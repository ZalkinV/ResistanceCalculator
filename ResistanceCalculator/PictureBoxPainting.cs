﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ResistanceCalculator
{
	public class PictureBoxPainting
	{
		WindowMain windowMain; //чтобы получать доступ к публичным объектам на форме

		public PictureBox pictureBox;
		Bitmap bitmapReal;
		Graphics graphicsReal;
		Bitmap bitmapBuf;
		Graphics graphicsBuf;

		//BAD: публичные переменные - очень плохо. Придумать другое решение
		public UInt32 CellSquare { get; set; } //мм^2
		public int CellRowCount { get; set; }
		public int PixelsInCellCount { get; set; }

		public Pen PenCurrent { get; set; }

		public Point MousePreviousPosition { get; set; }
		public Point MouseCurrentPosition { get; set; }

		public static int maxHeight;
		public static int minHeight;

		public static int conductorWidth;

		public PictureBoxPainting(WindowMain windowMain, PictureBox pictureBox)
		{
			this.windowMain = windowMain;

			this.pictureBox = pictureBox;
			this.bitmapReal = new Bitmap(pictureBox.Width, pictureBox.Height);
			this.bitmapBuf = new Bitmap(pictureBox.Width, pictureBox.Height);
			this.graphicsReal = Graphics.FromImage(bitmapReal);
			this.graphicsBuf = Graphics.FromImage(bitmapBuf);

			this.PenCurrent = new Pen(Color.Black, 5);

			maxHeight = -1;
			minHeight = pictureBox.Height + 1;
		}

		//public void PaintOnPicture(Graphics graphicsVisible, ToolStripButton toolStripButtonCurrent)
		//{
		//	//TODO: тут нужно оставить только прорисовку геометрических объектов. Ручка пусть рисует прямо на Bitmap без этого метода
		//	graphicsBuf.Clear(Color.Transparent);

		//	switch (toolStripButtonCurrent.Text)
		//	{
		//		case ("Pencil"):
		//			{
		//				graphicsReal.DrawEllipse(PenCurrent, MouseCurrentPosition.X, MouseCurrentPosition.Y, 5, 5);
		//				break;
		//			}
		//		case ("Line"):
		//			{
		//				graphicsBuf.DrawLine(PenCurrent, MousePreviousPosition, MouseCurrentPosition);
		//				break;
		//			}
		//		case ("Rectangle"):
		//			{
		//				Rectangle rectangle = CreateRectangle(MousePreviousPosition, MouseCurrentPosition);
		//				graphicsBuf.FillRectangle(PenCurrent.Brush, rectangle);
		//				break;
		//			}
		//		case ("Ellipse"):
		//			{
		//				Rectangle rectangle = CreateRectangle(MousePreviousPosition, MouseCurrentPosition);
		//				graphicsBuf.FillEllipse(PenCurrent.Brush, rectangle);
		//				break;
		//			}
		//		case ("Eraser"):
		//			{
		//				graphicsReal.DrawEllipse(new Pen(Color.White, 5), MouseCurrentPosition.X, MouseCurrentPosition.Y, 5, 5);
		//				//graphicsCurrent.DrawImage(bitmapFront, 0, 0); //Переношу на pictureBox, стирая границы
		//				break;
		//			}
		//	}

		//	graphicsVisible.DrawImage(bitmapReal, 0, 0); //Переношу то, что было нарисовано на pictureBox изначально
		//	graphicsVisible.DrawImage(bitmapBuf, 0, 0);
		//}

		public void PictureBoxPaint(PaintEventArgs e)
		{
			e.Graphics.DrawImage(bitmapReal, 0, 0);
			e.Graphics.DrawImage(bitmapBuf, 0, 0);
		}

		public void Visualize()
		{
			graphicsBuf.Clear(Color.Transparent);

			switch (windowMain.toolStripButtonCurrent.Text)
			{
				case ("Pencil"):
					{
						graphicsReal.DrawEllipse(PenCurrent, MouseCurrentPosition.X, MouseCurrentPosition.Y, 5, 5);
						break;
					}
				case ("Line"):
					{
						graphicsBuf.DrawLine(PenCurrent, MousePreviousPosition, MouseCurrentPosition);
						break;
					}
				case ("Rectangle"):
					{
						Rectangle rectangle = CreateRectangle(MousePreviousPosition, MouseCurrentPosition);
						graphicsBuf.FillRectangle(PenCurrent.Brush, rectangle);
						break;
					}
				case ("Ellipse"):
					{
						Rectangle rectangle = CreateRectangle(MousePreviousPosition, MouseCurrentPosition);
						graphicsBuf.FillEllipse(PenCurrent.Brush, rectangle);
						break;
					}
				case ("Eraser"):
					{
						graphicsReal.DrawEllipse(new Pen(Color.White, 5), MouseCurrentPosition.X, MouseCurrentPosition.Y, 5, 5);
						break;
					}
			}
			pictureBox.Invalidate();
		}

		public Bitmap PaintStencil()
		{
			Bitmap bitmapStencil = new Bitmap(pictureBox.Width, pictureBox.Height);
			Graphics graphicsStencil = Graphics.FromImage(bitmapStencil);

			graphicsReal.Clear(Color.Transparent);
			graphicsBuf.Clear(Color.Transparent);

			Color penStencilColor = Color.Black;
			int penStencilWidth = 1;
			Pen penStencil = new Pen(penStencilColor, penStencilWidth);

			int pixelInCellRowCount = Convert.ToInt32(Math.Sqrt(PixelsInCellCount));

			int currentX = -1;
			while (currentX <= pictureBox.Width)
			{
				graphicsStencil.DrawLine(penStencil, currentX, 0, currentX, pictureBox.Height);
				currentX++;
				graphicsStencil.DrawLine(penStencil, currentX, 0, currentX, pictureBox.Height);
				currentX += pixelInCellRowCount - 1;
			}
			int currentY = -1;
			while (currentY <= pictureBox.Height)
			{
				graphicsStencil.DrawLine(penStencil, 0, currentY, pictureBox.Width, currentY);
				currentY++;
				graphicsStencil.DrawLine(penStencil, 0, currentY, pictureBox.Width, currentY);
				currentY += pixelInCellRowCount - 1;
			}

			pictureBox.Image = (Bitmap)bitmapStencil.Clone();

			graphicsStencil.Dispose();
			penStencil.Dispose();

			return bitmapStencil;
		}

		public void PaintHelpLines()
		{
			Bitmap bitmapStencil = PaintStencil();
			Graphics graphicsStencil = Graphics.FromImage(bitmapStencil);
			Pen penLines = new Pen(Color.Red, 1);
			graphicsStencil.DrawLine(penLines, 0, minHeight, pictureBox.Width, minHeight);
			graphicsStencil.DrawLine(penLines, 0, maxHeight, pictureBox.Width, maxHeight);

			graphicsStencil.DrawImage(bitmapReal, 0, 0);
			pictureBox.Image = (Bitmap)bitmapStencil.Clone();

			bitmapStencil.Dispose();
			graphicsStencil.Dispose();
			penLines.Dispose();
		}

		public void Action_MouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.MousePreviousPosition = e.Location;
				this.MouseCurrentPosition = e.Location;

				this.Visualize();
				windowMain.trackBarScale.Enabled = false;
			}
			else if (e.Button == MouseButtons.Right)
			{
				Color currentPixel = bitmapReal.GetPixel(e.X, e.Y);
				if (IsAvailableColor(currentPixel))
				{
					foreach (var material in windowMain.materials)
					{
						if (currentPixel.ToArgb() == material.PixelColor.ToArgb())
						{
							windowMain.comboBoxConductorMaterial.SelectedItem = material.Name;
							break;
						}
					}
				}
			}
		}

		public void Action_MouseMove(MouseEventArgs e)
		{
			MouseCurrentPosition = e.Location;
			if (e.Button == MouseButtons.Left)
			{
				this.Visualize();
			}
		}

		public void Action_MouseUp(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				graphicsReal.DrawImage(bitmapBuf, 0, 0); //Оставшийся в буффере рисунок отображаю на bitmap, а оттуда при перерисовке, на pictureBox;
				graphicsBuf.Clear(Color.Transparent);
			}
		}

		public int CalculatePixelCount(ConductorMaterial material)
		{
			int pixelsCount = 0;
			for (int iWidth = 0; iWidth < bitmapReal.Width; iWidth++)
			{
				for (int jHeight = 0; jHeight < bitmapReal.Height; jHeight++)
				{
					Color currentPixel = bitmapReal.GetPixel(iWidth, jHeight);
					if (IsAvailableColor(currentPixel))
					{
						//TODO: Разобраться с предикатами и заменить это на materials.Find()
						if (material.PixelColor.ToArgb() == currentPixel.ToArgb())
						{
							pixelsCount++;
						}
					}
				}
			}
			return pixelsCount;
		}

		public void CalculateHeights()
		{
			for (int iWidth = 0; iWidth < bitmapReal.Width; iWidth++)
			{
				for (int jHeight = 0; jHeight < bitmapReal.Height; jHeight++)
				{
					Color currentPixel = bitmapReal.GetPixel(iWidth, jHeight);
					if (IsAvailableColor(currentPixel))
					{
						if (jHeight < minHeight)
							minHeight = jHeight;
						if (jHeight > maxHeight)
							maxHeight = jHeight;
					}
				}
			}
		}

		public void PrintPixelCount(ConductorMaterial material, TextBox textBoxToPrint)
		{
			if (material.PixelCount <= 0)
			{
				return;
			}

			textBoxToPrint.Text += material.Name + ": " + material.PixelCount.ToString() + Environment.NewLine;
		}

		public double CalculateSquare()
		{
			double square = 0;
			foreach(var material in windowMain.materials)
			{
				square += CalculateSquare(material);
			}
			return square;
		}

		public double CalculateSquare(ConductorMaterial currentMaterial)
		{
			currentMaterial.PixelCount = CalculatePixelCount(currentMaterial);
			double square = (currentMaterial.PixelCount / ((double)PixelsInCellCount / (double)CellSquare)); //Количество пикселей/количество пикселей в 1 мм^2
			return square;
		}

		public double CalculateLength(ConductorMaterial material)
		{
			double pixelsInLineCount = 0;
			for (int iWidth = 0; iWidth < bitmapReal.Width; iWidth++)
			{
				for (int jHeight = 0; jHeight < bitmapReal.Height; jHeight++)
				{
					Color currentPixel = bitmapReal.GetPixel(iWidth, jHeight);
					if (IsAvailableColor(currentPixel))
					{
						//TODO: Разобраться с предикатами и заменить это на materials.Find()
						if (material.PixelColor.ToArgb() == currentPixel.ToArgb())
						{
							pixelsInLineCount++;
							break;
						}
					}
				}
			}

			double length = pixelsInLineCount / (Math.Sqrt(PixelsInCellCount) / Math.Sqrt(CellSquare));
			return length;
		}

		public double ChangeSideSquare(ConductorMaterial material, double frontSquare)
		{
			double newSquare = 0;
			int frontLineDifference = maxHeight - minHeight;

			int lineCount = 0;
			for (int iWidth = 0; iWidth < bitmapReal.Width; iWidth++)
			{
				int currentLineDiff = 0;
				for (int jHeight = 0; jHeight < bitmapReal.Height; jHeight++)
				{
					Color currentPixel = bitmapReal.GetPixel(iWidth, jHeight);
					if (IsAvailableColor(currentPixel))
					{
						//TODO: Разобраться с предикатами и заменить это на materials.Find()
						if (material.PixelColor.ToArgb() == currentPixel.ToArgb())
						{
							currentLineDiff++;
						}
					}
				}
				if (currentLineDiff != 0)
				{
					lineCount++;
					double ratio = (double)currentLineDiff / frontLineDifference;
					double currentSquare = frontSquare * ratio;
					newSquare += currentSquare;
				}

			}
			newSquare = newSquare / lineCount;
			return newSquare;
		}

		public static bool IsAvailableColor(Color pixelColor)
		{
			return pixelColor.ToArgb() != 0 &&
				pixelColor.ToArgb() != Color.White.ToArgb() &&
				pixelColor.A != 255;
		}

		private Rectangle CreateRectangle(Point previous, Point current)
		{
			int startX = previous.X, startY = previous.Y;
			int endX = current.X, endY = current.Y;

			if (current.X < previous.X)
			{
				startX = current.X;
				endX = previous.X;
			}
			if (current.Y < previous.Y)
			{
				startY = current.Y;
				endY = previous.Y;
			}

			int rectangleWidth = Math.Abs(endX - startX);
			int rectangleHeight = Math.Abs(endY - startY);

			if (Control.ModifierKeys == Keys.Control)
			{
				//if (rectangleWidth >= rectangleHeight)
				//{
				//	rectangleHeight = rectangleWidth;
				//}
				//if (rectangleHeight > rectangleWidth)
				//{
				//	rectangleWidth = rectangleHeight;
				//}
				//if (startX == current.X && startY == current.Y)
				//{
				//	startX = startY;
				//}
			}

			Rectangle result = new Rectangle(startX, startY, rectangleWidth, rectangleHeight);
			return result;
		}
	}
}
