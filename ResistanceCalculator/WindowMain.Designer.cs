namespace ResistanceCalculator
{
    partial class WindowMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
			this.tabControlField = new System.Windows.Forms.TabControl();
			this.tabPageFront = new System.Windows.Forms.TabPage();
			this.pictureBoxFront = new System.Windows.Forms.PictureBox();
			this.tabPageSide = new System.Windows.Forms.TabPage();
			this.pictureBoxSide = new System.Windows.Forms.PictureBox();
			this.trackBarScale = new System.Windows.Forms.TrackBar();
			this.labelScale = new System.Windows.Forms.Label();
			this.pictureBoxScale = new System.Windows.Forms.PictureBox();
			this.labelScaleMin = new System.Windows.Forms.Label();
			this.labelScaleMax = new System.Windows.Forms.Label();
			this.buttonCalculateResistance = new System.Windows.Forms.Button();
			this.labelMaterial = new System.Windows.Forms.Label();
			this.labelСonductorLenght = new System.Windows.Forms.Label();
			this.comboBoxConductorMaterial = new System.Windows.Forms.ComboBox();
			this.labelResistivity = new System.Windows.Forms.Label();
			this.textBoxPixelsCount = new System.Windows.Forms.TextBox();
			this.numericConductorLength = new System.Windows.Forms.NumericUpDown();
			this.labelResistance = new System.Windows.Forms.Label();
			this.buttonClearField = new System.Windows.Forms.Button();
			this.groupBoxConductor = new System.Windows.Forms.GroupBox();
			this.textBoxSquares = new System.Windows.Forms.TextBox();
			this.labelSquare = new System.Windows.Forms.Label();
			this.panelColor = new System.Windows.Forms.Panel();
			this.labelTrackbarMin = new System.Windows.Forms.Label();
			this.labelTrackbarMax = new System.Windows.Forms.Label();
			this.labelPixelCount = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonPencil = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownConductor = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemChange = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControlField.SuspendLayout();
			this.tabPageFront.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).BeginInit();
			this.tabPageSide.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSide)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericConductorLength)).BeginInit();
			this.groupBoxConductor.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlField
			// 
			this.tabControlField.Controls.Add(this.tabPageFront);
			this.tabControlField.Controls.Add(this.tabPageSide);
			this.tabControlField.ItemSize = new System.Drawing.Size(202, 18);
			this.tabControlField.Location = new System.Drawing.Point(12, 39);
			this.tabControlField.Name = "tabControlField";
			this.tabControlField.SelectedIndex = 0;
			this.tabControlField.Size = new System.Drawing.Size(408, 426);
			this.tabControlField.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControlField.TabIndex = 0;
			// 
			// tabPageFront
			// 
			this.tabPageFront.Controls.Add(this.pictureBoxFront);
			this.tabPageFront.Location = new System.Drawing.Point(4, 22);
			this.tabPageFront.Name = "tabPageFront";
			this.tabPageFront.Size = new System.Drawing.Size(400, 400);
			this.tabPageFront.TabIndex = 0;
			this.tabPageFront.Text = "Поперёк";
			this.tabPageFront.UseVisualStyleBackColor = true;
			// 
			// pictureBoxFront
			// 
			this.pictureBoxFront.BackColor = System.Drawing.Color.White;
			this.pictureBoxFront.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxFront.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxFront.Name = "pictureBoxFront";
			this.pictureBoxFront.Size = new System.Drawing.Size(400, 400);
			this.pictureBoxFront.TabIndex = 1;
			this.pictureBoxFront.TabStop = false;
			this.pictureBoxFront.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFront_Paint);
			this.pictureBoxFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFront_MouseDown);
			this.pictureBoxFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFront_MouseMove);
			this.pictureBoxFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFront_MouseUp);
			// 
			// tabPageSide
			// 
			this.tabPageSide.Controls.Add(this.pictureBoxSide);
			this.tabPageSide.Location = new System.Drawing.Point(4, 22);
			this.tabPageSide.Name = "tabPageSide";
			this.tabPageSide.Size = new System.Drawing.Size(400, 400);
			this.tabPageSide.TabIndex = 1;
			this.tabPageSide.Text = "Вдоль";
			this.tabPageSide.UseVisualStyleBackColor = true;
			// 
			// pictureBoxSide
			// 
			this.pictureBoxSide.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxSide.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxSide.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxSide.Name = "pictureBoxSide";
			this.pictureBoxSide.Size = new System.Drawing.Size(400, 400);
			this.pictureBoxSide.TabIndex = 0;
			this.pictureBoxSide.TabStop = false;
			this.pictureBoxSide.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSide_Paint);
			this.pictureBoxSide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSide_MouseDown);
			this.pictureBoxSide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSide_MouseMove);
			this.pictureBoxSide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSide_MouseUp);
			// 
			// trackBarScale
			// 
			this.trackBarScale.LargeChange = 2;
			this.trackBarScale.Location = new System.Drawing.Point(93, 515);
			this.trackBarScale.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
			this.trackBarScale.Maximum = 4;
			this.trackBarScale.Name = "trackBarScale";
			this.trackBarScale.Size = new System.Drawing.Size(200, 45);
			this.trackBarScale.TabIndex = 2;
			this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
			// 
			// labelScale
			// 
			this.labelScale.AutoSize = true;
			this.labelScale.Location = new System.Drawing.Point(13, 515);
			this.labelScale.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
			this.labelScale.Name = "labelScale";
			this.labelScale.Size = new System.Drawing.Size(78, 13);
			this.labelScale.TabIndex = 3;
			this.labelScale.Text = "Масштаб, мм:";
			// 
			// pictureBoxScale
			// 
			this.pictureBoxScale.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxScale.Location = new System.Drawing.Point(16, 467);
			this.pictureBoxScale.Name = "pictureBoxScale";
			this.pictureBoxScale.Size = new System.Drawing.Size(50, 15);
			this.pictureBoxScale.TabIndex = 2;
			this.pictureBoxScale.TabStop = false;
			this.pictureBoxScale.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxScale_Paint);
			// 
			// labelScaleMin
			// 
			this.labelScaleMin.AutoSize = true;
			this.labelScaleMin.Location = new System.Drawing.Point(13, 485);
			this.labelScaleMin.Name = "labelScaleMin";
			this.labelScaleMin.Size = new System.Drawing.Size(13, 13);
			this.labelScaleMin.TabIndex = 4;
			this.labelScaleMin.Text = "0";
			// 
			// labelScaleMax
			// 
			this.labelScaleMax.AutoSize = true;
			this.labelScaleMax.Location = new System.Drawing.Point(54, 485);
			this.labelScaleMax.Name = "labelScaleMax";
			this.labelScaleMax.Size = new System.Drawing.Size(32, 13);
			this.labelScaleMax.TabIndex = 5;
			this.labelScaleMax.Text = "1 мм";
			// 
			// buttonCalculateResistance
			// 
			this.buttonCalculateResistance.Location = new System.Drawing.Point(426, 330);
			this.buttonCalculateResistance.Name = "buttonCalculateResistance";
			this.buttonCalculateResistance.Size = new System.Drawing.Size(154, 23);
			this.buttonCalculateResistance.TabIndex = 6;
			this.buttonCalculateResistance.Text = "Рассчитать сопротивление";
			this.buttonCalculateResistance.UseVisualStyleBackColor = true;
			this.buttonCalculateResistance.Click += new System.EventHandler(this.buttonCalculateResistance_Click);
			// 
			// labelMaterial
			// 
			this.labelMaterial.AutoSize = true;
			this.labelMaterial.Location = new System.Drawing.Point(6, 23);
			this.labelMaterial.Name = "labelMaterial";
			this.labelMaterial.Size = new System.Drawing.Size(120, 13);
			this.labelMaterial.TabIndex = 8;
			this.labelMaterial.Text = "Материал проводника";
			// 
			// labelСonductorLenght
			// 
			this.labelСonductorLenght.AutoSize = true;
			this.labelСonductorLenght.Location = new System.Drawing.Point(6, 91);
			this.labelСonductorLenght.Name = "labelСonductorLenght";
			this.labelСonductorLenght.Size = new System.Drawing.Size(117, 13);
			this.labelСonductorLenght.TabIndex = 9;
			this.labelСonductorLenght.Text = "Длина проводника, м";
			// 
			// comboBoxConductorMaterial
			// 
			this.comboBoxConductorMaterial.FormattingEnabled = true;
			this.comboBoxConductorMaterial.Location = new System.Drawing.Point(6, 39);
			this.comboBoxConductorMaterial.Name = "comboBoxConductorMaterial";
			this.comboBoxConductorMaterial.Size = new System.Drawing.Size(121, 21);
			this.comboBoxConductorMaterial.TabIndex = 10;
			this.comboBoxConductorMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxConductorMaterial_SelectedIndexChanged);
			// 
			// labelResistivity
			// 
			this.labelResistivity.AutoSize = true;
			this.labelResistivity.Location = new System.Drawing.Point(6, 63);
			this.labelResistivity.Name = "labelResistivity";
			this.labelResistivity.Size = new System.Drawing.Size(150, 13);
			this.labelResistivity.TabIndex = 11;
			this.labelResistivity.Text = "Удельное R = 0 Ом*мм^2/м";
			// 
			// textBoxPixelsCount
			// 
			this.textBoxPixelsCount.AcceptsReturn = true;
			this.textBoxPixelsCount.Location = new System.Drawing.Point(432, 384);
			this.textBoxPixelsCount.Multiline = true;
			this.textBoxPixelsCount.Name = "textBoxPixelsCount";
			this.textBoxPixelsCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxPixelsCount.Size = new System.Drawing.Size(222, 77);
			this.textBoxPixelsCount.TabIndex = 13;
			// 
			// numericConductorLength
			// 
			this.numericConductorLength.DecimalPlaces = 3;
			this.numericConductorLength.Location = new System.Drawing.Point(6, 107);
			this.numericConductorLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericConductorLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.numericConductorLength.Name = "numericConductorLength";
			this.numericConductorLength.Size = new System.Drawing.Size(120, 20);
			this.numericConductorLength.TabIndex = 14;
			this.numericConductorLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelResistance
			// 
			this.labelResistance.AutoSize = true;
			this.labelResistance.Location = new System.Drawing.Point(6, 244);
			this.labelResistance.Name = "labelResistance";
			this.labelResistance.Size = new System.Drawing.Size(97, 13);
			this.labelResistance.TabIndex = 15;
			this.labelResistance.Text = "Сопротивление = ";
			// 
			// buttonClearField
			// 
			this.buttonClearField.Location = new System.Drawing.Point(322, 471);
			this.buttonClearField.Name = "buttonClearField";
			this.buttonClearField.Size = new System.Drawing.Size(98, 23);
			this.buttonClearField.TabIndex = 16;
			this.buttonClearField.Text = "Очистить поле";
			this.buttonClearField.UseVisualStyleBackColor = true;
			this.buttonClearField.Click += new System.EventHandler(this.buttonClearField_Click);
			// 
			// groupBoxConductor
			// 
			this.groupBoxConductor.Controls.Add(this.textBoxSquares);
			this.groupBoxConductor.Controls.Add(this.labelSquare);
			this.groupBoxConductor.Controls.Add(this.panelColor);
			this.groupBoxConductor.Controls.Add(this.labelMaterial);
			this.groupBoxConductor.Controls.Add(this.comboBoxConductorMaterial);
			this.groupBoxConductor.Controls.Add(this.labelResistance);
			this.groupBoxConductor.Controls.Add(this.labelResistivity);
			this.groupBoxConductor.Controls.Add(this.numericConductorLength);
			this.groupBoxConductor.Controls.Add(this.labelСonductorLenght);
			this.groupBoxConductor.Location = new System.Drawing.Point(426, 57);
			this.groupBoxConductor.Name = "groupBoxConductor";
			this.groupBoxConductor.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.groupBoxConductor.Size = new System.Drawing.Size(246, 267);
			this.groupBoxConductor.TabIndex = 17;
			this.groupBoxConductor.TabStop = false;
			this.groupBoxConductor.Text = "Характеристики проводника";
			// 
			// textBoxSquares
			// 
			this.textBoxSquares.AcceptsReturn = true;
			this.textBoxSquares.Location = new System.Drawing.Point(6, 163);
			this.textBoxSquares.Multiline = true;
			this.textBoxSquares.Name = "textBoxSquares";
			this.textBoxSquares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxSquares.Size = new System.Drawing.Size(216, 64);
			this.textBoxSquares.TabIndex = 17;
			// 
			// labelSquare
			// 
			this.labelSquare.AutoSize = true;
			this.labelSquare.Location = new System.Drawing.Point(6, 147);
			this.labelSquare.Name = "labelSquare";
			this.labelSquare.Size = new System.Drawing.Size(117, 13);
			this.labelSquare.TabIndex = 16;
			this.labelSquare.Text = "Площадь проводника";
			// 
			// panelColor
			// 
			this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColor.Location = new System.Drawing.Point(133, 39);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(21, 21);
			this.panelColor.TabIndex = 15;
			// 
			// labelTrackbarMin
			// 
			this.labelTrackbarMin.AutoSize = true;
			this.labelTrackbarMin.Location = new System.Drawing.Point(100, 547);
			this.labelTrackbarMin.Name = "labelTrackbarMin";
			this.labelTrackbarMin.Size = new System.Drawing.Size(13, 13);
			this.labelTrackbarMin.TabIndex = 18;
			this.labelTrackbarMin.Text = "1";
			// 
			// labelTrackbarMax
			// 
			this.labelTrackbarMax.AutoSize = true;
			this.labelTrackbarMax.Location = new System.Drawing.Point(266, 547);
			this.labelTrackbarMax.Name = "labelTrackbarMax";
			this.labelTrackbarMax.Size = new System.Drawing.Size(31, 13);
			this.labelTrackbarMax.TabIndex = 19;
			this.labelTrackbarMax.Text = "4096";
			// 
			// labelPixelCount
			// 
			this.labelPixelCount.AutoSize = true;
			this.labelPixelCount.Location = new System.Drawing.Point(432, 368);
			this.labelPixelCount.Name = "labelPixelCount";
			this.labelPixelCount.Size = new System.Drawing.Size(117, 13);
			this.labelPixelCount.TabIndex = 20;
			this.labelPixelCount.Text = "Количество пикселей";
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPencil,
            this.toolStripButtonLine,
            this.toolStripButtonRectangle,
            this.toolStripButtonEllipse,
            this.toolStripButtonEraser,
            this.toolStripSeparator1,
            this.toolStripDropDownConductor});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(684, 31);
			this.toolStrip.TabIndex = 21;
			this.toolStrip.Text = "toolStrip1";
			this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
			// 
			// toolStripButtonPencil
			// 
			this.toolStripButtonPencil.Checked = true;
			this.toolStripButtonPencil.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPencil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPencil.Image")));
			this.toolStripButtonPencil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonPencil.Name = "toolStripButtonPencil";
			this.toolStripButtonPencil.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonPencil.Text = "Pencil";
			this.toolStripButtonPencil.ToolTipText = "Карандаш";
			// 
			// toolStripButtonLine
			// 
			this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
			this.toolStripButtonLine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonLine.Name = "toolStripButtonLine";
			this.toolStripButtonLine.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonLine.Text = "Line";
			this.toolStripButtonLine.ToolTipText = "Прямая";
			// 
			// toolStripButtonRectangle
			// 
			this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRectangle.Image")));
			this.toolStripButtonRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
			this.toolStripButtonRectangle.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonRectangle.Text = "Rectangle";
			this.toolStripButtonRectangle.ToolTipText = "Прямоугольник";
			// 
			// toolStripButtonEllipse
			// 
			this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
			this.toolStripButtonEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
			this.toolStripButtonEllipse.Size = new System.Drawing.Size(28, 28);
			this.toolStripButtonEllipse.Text = "Ellipse";
			this.toolStripButtonEllipse.ToolTipText = "Эллипс";
			// 
			// toolStripButtonEraser
			// 
			this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEraser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEraser.Image")));
			this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEraser.Name = "toolStripButtonEraser";
			this.toolStripButtonEraser.Size = new System.Drawing.Size(23, 28);
			this.toolStripButtonEraser.Text = "Eraser";
			this.toolStripButtonEraser.ToolTipText = "Ластик";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// toolStripDropDownConductor
			// 
			this.toolStripDropDownConductor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownConductor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemChange});
			this.toolStripDropDownConductor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownConductor.Image")));
			this.toolStripDropDownConductor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownConductor.Name = "toolStripDropDownConductor";
			this.toolStripDropDownConductor.Size = new System.Drawing.Size(75, 28);
			this.toolStripDropDownConductor.Text = "Материал";
			// 
			// toolStripMenuItemAdd
			// 
			this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
			this.toolStripMenuItemAdd.Size = new System.Drawing.Size(179, 22);
			this.toolStripMenuItemAdd.Text = "Добавить";
			this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
			// 
			// toolStripMenuItemChange
			// 
			this.toolStripMenuItemChange.Name = "toolStripMenuItemChange";
			this.toolStripMenuItemChange.Size = new System.Drawing.Size(179, 22);
			this.toolStripMenuItemChange.Text = "Изменить текущий";
			this.toolStripMenuItemChange.Click += new System.EventHandler(this.toolStripMenuItemChange_Click);
			// 
			// WindowMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 576);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.pictureBoxScale);
			this.Controls.Add(this.labelPixelCount);
			this.Controls.Add(this.labelTrackbarMax);
			this.Controls.Add(this.labelTrackbarMin);
			this.Controls.Add(this.groupBoxConductor);
			this.Controls.Add(this.buttonClearField);
			this.Controls.Add(this.textBoxPixelsCount);
			this.Controls.Add(this.buttonCalculateResistance);
			this.Controls.Add(this.labelScaleMax);
			this.Controls.Add(this.labelScaleMin);
			this.Controls.Add(this.labelScale);
			this.Controls.Add(this.trackBarScale);
			this.Controls.Add(this.tabControlField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WindowMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Калькулятор сопротивления";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainWindow_HelpButtonClicked);
			this.Shown += new System.EventHandler(this.WindowMain_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowMain_KeyDown);
			this.tabControlField.ResumeLayout(false);
			this.tabPageFront.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).EndInit();
			this.tabPageSide.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSide)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericConductorLength)).EndInit();
			this.groupBoxConductor.ResumeLayout(false);
			this.groupBoxConductor.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlField;
        private System.Windows.Forms.TabPage tabPageSide;
		private System.Windows.Forms.TabPage tabPageFront;
		private System.Windows.Forms.PictureBox pictureBoxFront;
		private System.Windows.Forms.PictureBox pictureBoxSide;
		private System.Windows.Forms.Label labelScale;
		private System.Windows.Forms.PictureBox pictureBoxScale;
		private System.Windows.Forms.Label labelScaleMin;
		private System.Windows.Forms.Label labelScaleMax;
		private System.Windows.Forms.Button buttonCalculateResistance;
		private System.Windows.Forms.Label labelMaterial;
		private System.Windows.Forms.Label labelСonductorLenght;
		private System.Windows.Forms.Label labelResistivity;
		private System.Windows.Forms.TextBox textBoxPixelsCount;
		private System.Windows.Forms.NumericUpDown numericConductorLength;
		private System.Windows.Forms.Label labelResistance;
		private System.Windows.Forms.Button buttonClearField;
		private System.Windows.Forms.GroupBox groupBoxConductor;
		private System.Windows.Forms.Panel panelColor;
		private System.Windows.Forms.TextBox textBoxSquares;
		private System.Windows.Forms.Label labelSquare;
		private System.Windows.Forms.Label labelTrackbarMin;
		private System.Windows.Forms.Label labelTrackbarMax;
		private System.Windows.Forms.Label labelPixelCount;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonPencil;
		private System.Windows.Forms.ToolStripButton toolStripButtonLine;
		private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
		private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
		private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownConductor;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChange;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.ComboBox comboBoxConductorMaterial;
		public System.Windows.Forms.TrackBar trackBarScale;
	}
}

