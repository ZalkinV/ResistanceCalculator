namespace ResistanceCalculator
{
	partial class WindowMaterialSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelResistivity = new System.Windows.Forms.Label();
			this.labelColor = new System.Windows.Forms.Label();
			this.panelColor = new System.Windows.Forms.Panel();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.numericUpDownResistivity = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownResistivity)).BeginInit();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(13, 13);
			this.labelName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 13);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(118, 13);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Название материала:";
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(137, 10);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(173, 20);
			this.textBoxName.TabIndex = 1;
			// 
			// labelResistivity
			// 
			this.labelResistivity.AutoSize = true;
			this.labelResistivity.Location = new System.Drawing.Point(12, 39);
			this.labelResistivity.Margin = new System.Windows.Forms.Padding(3, 0, 3, 13);
			this.labelResistivity.Name = "labelResistivity";
			this.labelResistivity.Size = new System.Drawing.Size(207, 13);
			this.labelResistivity.TabIndex = 2;
			this.labelResistivity.Text = "Удельное сопротивление, Ом*мм^2/м:";
			// 
			// labelColor
			// 
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new System.Drawing.Point(13, 65);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(35, 13);
			this.labelColor.TabIndex = 4;
			this.labelColor.Text = "Цвет:";
			// 
			// panelColor
			// 
			this.panelColor.BackColor = System.Drawing.Color.Transparent;
			this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColor.Location = new System.Drawing.Point(51, 62);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(21, 21);
			this.panelColor.TabIndex = 5;
			this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
			// 
			// buttonAccept
			// 
			this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAccept.Location = new System.Drawing.Point(12, 92);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(75, 23);
			this.buttonAccept.TabIndex = 6;
			this.buttonAccept.Text = "Применить";
			this.buttonAccept.UseVisualStyleBackColor = true;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// numericUpDownResistivity
			// 
			this.numericUpDownResistivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownResistivity.DecimalPlaces = 3;
			this.numericUpDownResistivity.Location = new System.Drawing.Point(226, 37);
			this.numericUpDownResistivity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDownResistivity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.numericUpDownResistivity.Name = "numericUpDownResistivity";
			this.numericUpDownResistivity.Size = new System.Drawing.Size(84, 20);
			this.numericUpDownResistivity.TabIndex = 7;
			this.numericUpDownResistivity.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			// 
			// WindowMaterialSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 127);
			this.Controls.Add(this.numericUpDownResistivity);
			this.Controls.Add(this.buttonAccept);
			this.Controls.Add(this.panelColor);
			this.Controls.Add(this.labelColor);
			this.Controls.Add(this.labelResistivity);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "WindowMaterialSettings";
			this.Text = "Настройки материала";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowMaterialSettings_FormClosed);
			this.Load += new System.EventHandler(this.WindowMaterialSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownResistivity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelResistivity;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Button buttonAccept;
		public System.Windows.Forms.TextBox textBoxName;
		public System.Windows.Forms.Panel panelColor;
		public System.Windows.Forms.NumericUpDown numericUpDownResistivity;
	}
}