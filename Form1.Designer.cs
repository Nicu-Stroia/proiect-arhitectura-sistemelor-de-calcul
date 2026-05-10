namespace proiect_arhitectura_sistemelor_de_calcul
{
    partial class CPUViewerForm
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            generalRegistersGroup = new GroupBox();
            registersTableLayoutPanel = new TableLayoutPanel();
            r15Value = new TextBox();
            r14Value = new TextBox();
            r13Value = new TextBox();
            r12Value = new TextBox();
            r11Value = new TextBox();
            r10Value = new TextBox();
            r9Value = new TextBox();
            r8Value = new TextBox();
            r7Value = new TextBox();
            r6Value = new TextBox();
            r5Value = new TextBox();
            r4Value = new TextBox();
            r3Value = new TextBox();
            r2Value = new TextBox();
            r1Value = new TextBox();
            generalRegistersTableColumn3Label = new Label();
            generalRegistersTableColumn1Label = new Label();
            generalRegistersTableColumn0Label = new Label();
            r1Label = new Label();
            generalRegistersTableColumn2Label = new Label();
            r0Label = new Label();
            r2Label = new Label();
            r3Label = new Label();
            r4Label = new Label();
            r5Label = new Label();
            r6Label = new Label();
            r7Label = new Label();
            r8Label = new Label();
            r9Label = new Label();
            r10Label = new Label();
            r11Label = new Label();
            r12Label = new Label();
            r13Label = new Label();
            r14Label = new Label();
            r15Label = new Label();
            r0Value = new TextBox();
            controlAndStatusregistersGroup = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            spValue = new TextBox();
            flagValue = new TextBox();
            irValue = new TextBox();
            controlAndStatusRegistersTableColumn1Label = new Label();
            controlAndStatusRegistersTableColumn0Label = new Label();
            pcLabel = new Label();
            irLabel = new Label();
            flagLabel = new Label();
            spLabel = new Label();
            pcValue = new TextBox();
            menuStrip.SuspendLayout();
            generalRegistersGroup.SuspendLayout();
            registersTableLayoutPanel.SuspendLayout();
            controlAndStatusregistersGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, runToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1241, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(137, 26);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(48, 24);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "|*.asm";
            // 
            // generalRegistersGroup
            // 
            generalRegistersGroup.Controls.Add(registersTableLayoutPanel);
            generalRegistersGroup.Location = new Point(12, 44);
            generalRegistersGroup.Name = "generalRegistersGroup";
            generalRegistersGroup.Size = new Size(232, 326);
            generalRegistersGroup.TabIndex = 1;
            generalRegistersGroup.TabStop = false;
            generalRegistersGroup.Text = "General Registers";
            // 
            // registersTableLayoutPanel
            // 
            registersTableLayoutPanel.ColumnCount = 4;
            registersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            registersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            registersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            registersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            registersTableLayoutPanel.Controls.Add(r15Value, 3, 8);
            registersTableLayoutPanel.Controls.Add(r14Value, 1, 8);
            registersTableLayoutPanel.Controls.Add(r13Value, 3, 7);
            registersTableLayoutPanel.Controls.Add(r12Value, 1, 7);
            registersTableLayoutPanel.Controls.Add(r11Value, 3, 6);
            registersTableLayoutPanel.Controls.Add(r10Value, 1, 6);
            registersTableLayoutPanel.Controls.Add(r9Value, 3, 5);
            registersTableLayoutPanel.Controls.Add(r8Value, 1, 5);
            registersTableLayoutPanel.Controls.Add(r7Value, 3, 4);
            registersTableLayoutPanel.Controls.Add(r6Value, 1, 4);
            registersTableLayoutPanel.Controls.Add(r5Value, 3, 3);
            registersTableLayoutPanel.Controls.Add(r4Value, 1, 3);
            registersTableLayoutPanel.Controls.Add(r3Value, 3, 2);
            registersTableLayoutPanel.Controls.Add(r2Value, 1, 2);
            registersTableLayoutPanel.Controls.Add(r1Value, 3, 1);
            registersTableLayoutPanel.Controls.Add(generalRegistersTableColumn3Label, 3, 0);
            registersTableLayoutPanel.Controls.Add(generalRegistersTableColumn1Label, 1, 0);
            registersTableLayoutPanel.Controls.Add(generalRegistersTableColumn0Label, 0, 0);
            registersTableLayoutPanel.Controls.Add(r1Label, 2, 1);
            registersTableLayoutPanel.Controls.Add(generalRegistersTableColumn2Label, 2, 0);
            registersTableLayoutPanel.Controls.Add(r0Label, 0, 1);
            registersTableLayoutPanel.Controls.Add(r2Label, 0, 2);
            registersTableLayoutPanel.Controls.Add(r3Label, 2, 2);
            registersTableLayoutPanel.Controls.Add(r4Label, 0, 3);
            registersTableLayoutPanel.Controls.Add(r5Label, 2, 3);
            registersTableLayoutPanel.Controls.Add(r6Label, 0, 4);
            registersTableLayoutPanel.Controls.Add(r7Label, 2, 4);
            registersTableLayoutPanel.Controls.Add(r8Label, 0, 5);
            registersTableLayoutPanel.Controls.Add(r9Label, 2, 5);
            registersTableLayoutPanel.Controls.Add(r10Label, 0, 6);
            registersTableLayoutPanel.Controls.Add(r11Label, 2, 6);
            registersTableLayoutPanel.Controls.Add(r12Label, 0, 7);
            registersTableLayoutPanel.Controls.Add(r13Label, 2, 7);
            registersTableLayoutPanel.Controls.Add(r14Label, 0, 8);
            registersTableLayoutPanel.Controls.Add(r15Label, 2, 8);
            registersTableLayoutPanel.Controls.Add(r0Value, 1, 1);
            registersTableLayoutPanel.Dock = DockStyle.Fill;
            registersTableLayoutPanel.Location = new Point(3, 23);
            registersTableLayoutPanel.Name = "registersTableLayoutPanel";
            registersTableLayoutPanel.RowCount = 9;
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            registersTableLayoutPanel.Size = new Size(226, 300);
            registersTableLayoutPanel.TabIndex = 2;
            // 
            // r15Value
            // 
            r15Value.Location = new Point(171, 267);
            r15Value.Name = "r15Value";
            r15Value.ReadOnly = true;
            r15Value.Size = new Size(50, 27);
            r15Value.TabIndex = 35;
            r15Value.Text = "0x0";
            // 
            // r14Value
            // 
            r14Value.Location = new Point(59, 267);
            r14Value.Name = "r14Value";
            r14Value.ReadOnly = true;
            r14Value.Size = new Size(50, 27);
            r14Value.TabIndex = 34;
            r14Value.Text = "0x0";
            // 
            // r13Value
            // 
            r13Value.Location = new Point(171, 234);
            r13Value.Name = "r13Value";
            r13Value.ReadOnly = true;
            r13Value.Size = new Size(50, 27);
            r13Value.TabIndex = 33;
            r13Value.Text = "0x0";
            // 
            // r12Value
            // 
            r12Value.Location = new Point(59, 234);
            r12Value.Name = "r12Value";
            r12Value.ReadOnly = true;
            r12Value.Size = new Size(50, 27);
            r12Value.TabIndex = 32;
            r12Value.Text = "0x0";
            // 
            // r11Value
            // 
            r11Value.Location = new Point(171, 201);
            r11Value.Name = "r11Value";
            r11Value.ReadOnly = true;
            r11Value.Size = new Size(50, 27);
            r11Value.TabIndex = 31;
            r11Value.Text = "0x0";
            // 
            // r10Value
            // 
            r10Value.Location = new Point(59, 201);
            r10Value.Name = "r10Value";
            r10Value.ReadOnly = true;
            r10Value.Size = new Size(50, 27);
            r10Value.TabIndex = 30;
            r10Value.Text = "0x0";
            // 
            // r9Value
            // 
            r9Value.Location = new Point(171, 168);
            r9Value.Name = "r9Value";
            r9Value.ReadOnly = true;
            r9Value.Size = new Size(50, 27);
            r9Value.TabIndex = 29;
            r9Value.Text = "0x0";
            // 
            // r8Value
            // 
            r8Value.Location = new Point(59, 168);
            r8Value.Name = "r8Value";
            r8Value.ReadOnly = true;
            r8Value.Size = new Size(50, 27);
            r8Value.TabIndex = 28;
            r8Value.Text = "0x0";
            // 
            // r7Value
            // 
            r7Value.Location = new Point(171, 135);
            r7Value.Name = "r7Value";
            r7Value.ReadOnly = true;
            r7Value.Size = new Size(50, 27);
            r7Value.TabIndex = 27;
            r7Value.Text = "0x0";
            // 
            // r6Value
            // 
            r6Value.Location = new Point(59, 135);
            r6Value.Name = "r6Value";
            r6Value.ReadOnly = true;
            r6Value.Size = new Size(50, 27);
            r6Value.TabIndex = 26;
            r6Value.Text = "0x0";
            // 
            // r5Value
            // 
            r5Value.Location = new Point(171, 102);
            r5Value.Name = "r5Value";
            r5Value.ReadOnly = true;
            r5Value.Size = new Size(50, 27);
            r5Value.TabIndex = 25;
            r5Value.Text = "0x0";
            // 
            // r4Value
            // 
            r4Value.Location = new Point(59, 102);
            r4Value.Name = "r4Value";
            r4Value.ReadOnly = true;
            r4Value.Size = new Size(50, 27);
            r4Value.TabIndex = 24;
            r4Value.Text = "0x0";
            // 
            // r3Value
            // 
            r3Value.Location = new Point(171, 69);
            r3Value.Name = "r3Value";
            r3Value.ReadOnly = true;
            r3Value.Size = new Size(50, 27);
            r3Value.TabIndex = 23;
            r3Value.Text = "0x0";
            // 
            // r2Value
            // 
            r2Value.Location = new Point(59, 69);
            r2Value.Name = "r2Value";
            r2Value.ReadOnly = true;
            r2Value.Size = new Size(50, 27);
            r2Value.TabIndex = 22;
            r2Value.Text = "0x0";
            // 
            // r1Value
            // 
            r1Value.Location = new Point(171, 36);
            r1Value.Name = "r1Value";
            r1Value.ReadOnly = true;
            r1Value.Size = new Size(50, 27);
            r1Value.TabIndex = 21;
            r1Value.Text = "0x0";
            // 
            // generalRegistersTableColumn3Label
            // 
            generalRegistersTableColumn3Label.AutoSize = true;
            generalRegistersTableColumn3Label.Location = new Point(171, 0);
            generalRegistersTableColumn3Label.Name = "generalRegistersTableColumn3Label";
            generalRegistersTableColumn3Label.Size = new Size(45, 20);
            generalRegistersTableColumn3Label.TabIndex = 5;
            generalRegistersTableColumn3Label.Text = "Value";
            // 
            // generalRegistersTableColumn1Label
            // 
            generalRegistersTableColumn1Label.AutoSize = true;
            generalRegistersTableColumn1Label.Location = new Point(59, 0);
            generalRegistersTableColumn1Label.Name = "generalRegistersTableColumn1Label";
            generalRegistersTableColumn1Label.Size = new Size(45, 20);
            generalRegistersTableColumn1Label.TabIndex = 4;
            generalRegistersTableColumn1Label.Text = "Value";
            // 
            // generalRegistersTableColumn0Label
            // 
            generalRegistersTableColumn0Label.AutoSize = true;
            generalRegistersTableColumn0Label.Location = new Point(3, 0);
            generalRegistersTableColumn0Label.Name = "generalRegistersTableColumn0Label";
            generalRegistersTableColumn0Label.Size = new Size(49, 20);
            generalRegistersTableColumn0Label.TabIndex = 2;
            generalRegistersTableColumn0Label.Text = "Name";
            // 
            // r1Label
            // 
            r1Label.AutoSize = true;
            r1Label.Location = new Point(115, 33);
            r1Label.Name = "r1Label";
            r1Label.Size = new Size(26, 20);
            r1Label.TabIndex = 1;
            r1Label.Text = "R1";
            // 
            // generalRegistersTableColumn2Label
            // 
            generalRegistersTableColumn2Label.AutoSize = true;
            generalRegistersTableColumn2Label.Location = new Point(115, 0);
            generalRegistersTableColumn2Label.Name = "generalRegistersTableColumn2Label";
            generalRegistersTableColumn2Label.Size = new Size(49, 20);
            generalRegistersTableColumn2Label.TabIndex = 3;
            generalRegistersTableColumn2Label.Text = "Name";
            // 
            // r0Label
            // 
            r0Label.AutoSize = true;
            r0Label.Location = new Point(3, 33);
            r0Label.Name = "r0Label";
            r0Label.Size = new Size(26, 20);
            r0Label.TabIndex = 0;
            r0Label.Text = "R0";
            // 
            // r2Label
            // 
            r2Label.AutoSize = true;
            r2Label.Location = new Point(3, 66);
            r2Label.Name = "r2Label";
            r2Label.Size = new Size(26, 20);
            r2Label.TabIndex = 6;
            r2Label.Text = "R2";
            // 
            // r3Label
            // 
            r3Label.AutoSize = true;
            r3Label.Location = new Point(115, 66);
            r3Label.Name = "r3Label";
            r3Label.Size = new Size(26, 20);
            r3Label.TabIndex = 7;
            r3Label.Text = "R3";
            // 
            // r4Label
            // 
            r4Label.AutoSize = true;
            r4Label.Location = new Point(3, 99);
            r4Label.Name = "r4Label";
            r4Label.Size = new Size(26, 20);
            r4Label.TabIndex = 8;
            r4Label.Text = "R4";
            // 
            // r5Label
            // 
            r5Label.AutoSize = true;
            r5Label.Location = new Point(115, 99);
            r5Label.Name = "r5Label";
            r5Label.Size = new Size(26, 20);
            r5Label.TabIndex = 9;
            r5Label.Text = "R5";
            // 
            // r6Label
            // 
            r6Label.AutoSize = true;
            r6Label.Location = new Point(3, 132);
            r6Label.Name = "r6Label";
            r6Label.Size = new Size(26, 20);
            r6Label.TabIndex = 10;
            r6Label.Text = "R6";
            // 
            // r7Label
            // 
            r7Label.AutoSize = true;
            r7Label.Location = new Point(115, 132);
            r7Label.Name = "r7Label";
            r7Label.Size = new Size(26, 20);
            r7Label.TabIndex = 11;
            r7Label.Text = "R7";
            // 
            // r8Label
            // 
            r8Label.AutoSize = true;
            r8Label.Location = new Point(3, 165);
            r8Label.Name = "r8Label";
            r8Label.Size = new Size(26, 20);
            r8Label.TabIndex = 12;
            r8Label.Text = "R8";
            // 
            // r9Label
            // 
            r9Label.AutoSize = true;
            r9Label.Location = new Point(115, 165);
            r9Label.Name = "r9Label";
            r9Label.Size = new Size(26, 20);
            r9Label.TabIndex = 13;
            r9Label.Text = "R9";
            // 
            // r10Label
            // 
            r10Label.AutoSize = true;
            r10Label.Location = new Point(3, 198);
            r10Label.Name = "r10Label";
            r10Label.Size = new Size(34, 20);
            r10Label.TabIndex = 14;
            r10Label.Text = "R10";
            // 
            // r11Label
            // 
            r11Label.AutoSize = true;
            r11Label.Location = new Point(115, 198);
            r11Label.Name = "r11Label";
            r11Label.Size = new Size(34, 20);
            r11Label.TabIndex = 15;
            r11Label.Text = "R11";
            // 
            // r12Label
            // 
            r12Label.AutoSize = true;
            r12Label.Location = new Point(3, 231);
            r12Label.Name = "r12Label";
            r12Label.Size = new Size(34, 20);
            r12Label.TabIndex = 16;
            r12Label.Text = "R12";
            // 
            // r13Label
            // 
            r13Label.AutoSize = true;
            r13Label.Location = new Point(115, 231);
            r13Label.Name = "r13Label";
            r13Label.Size = new Size(34, 20);
            r13Label.TabIndex = 17;
            r13Label.Text = "R13";
            // 
            // r14Label
            // 
            r14Label.AutoSize = true;
            r14Label.Location = new Point(3, 264);
            r14Label.Name = "r14Label";
            r14Label.Size = new Size(34, 20);
            r14Label.TabIndex = 18;
            r14Label.Text = "R14";
            // 
            // r15Label
            // 
            r15Label.AutoSize = true;
            r15Label.Location = new Point(115, 264);
            r15Label.Name = "r15Label";
            r15Label.Size = new Size(34, 20);
            r15Label.TabIndex = 19;
            r15Label.Text = "R15";
            // 
            // r0Value
            // 
            r0Value.Location = new Point(59, 36);
            r0Value.Name = "r0Value";
            r0Value.ReadOnly = true;
            r0Value.Size = new Size(50, 27);
            r0Value.TabIndex = 20;
            r0Value.Text = "0x0";
            // 
            // controlAndStatusregistersGroup
            // 
            controlAndStatusregistersGroup.Controls.Add(tableLayoutPanel1);
            controlAndStatusregistersGroup.Location = new Point(335, 44);
            controlAndStatusregistersGroup.Name = "controlAndStatusregistersGroup";
            controlAndStatusregistersGroup.Size = new Size(232, 326);
            controlAndStatusregistersGroup.TabIndex = 2;
            controlAndStatusregistersGroup.TabStop = false;
            controlAndStatusregistersGroup.Text = "Constorl and Status";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(spValue, 1, 4);
            tableLayoutPanel1.Controls.Add(flagValue, 1, 3);
            tableLayoutPanel1.Controls.Add(irValue, 1, 2);
            tableLayoutPanel1.Controls.Add(controlAndStatusRegistersTableColumn1Label, 1, 0);
            tableLayoutPanel1.Controls.Add(controlAndStatusRegistersTableColumn0Label, 0, 0);
            tableLayoutPanel1.Controls.Add(pcLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(irLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(flagLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(spLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(pcValue, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(226, 300);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // spValue
            // 
            spValue.Location = new Point(116, 243);
            spValue.Name = "spValue";
            spValue.ReadOnly = true;
            spValue.Size = new Size(50, 27);
            spValue.TabIndex = 26;
            spValue.Text = "0x0";
            // 
            // flagValue
            // 
            flagValue.Location = new Point(116, 183);
            flagValue.Name = "flagValue";
            flagValue.ReadOnly = true;
            flagValue.Size = new Size(50, 27);
            flagValue.TabIndex = 24;
            flagValue.Text = "0x0";
            // 
            // irValue
            // 
            irValue.Location = new Point(116, 123);
            irValue.Name = "irValue";
            irValue.ReadOnly = true;
            irValue.Size = new Size(50, 27);
            irValue.TabIndex = 22;
            irValue.Text = "0x0";
            // 
            // controlAndStatusRegistersTableColumn1Label
            // 
            controlAndStatusRegistersTableColumn1Label.AutoSize = true;
            controlAndStatusRegistersTableColumn1Label.Location = new Point(116, 0);
            controlAndStatusRegistersTableColumn1Label.Name = "controlAndStatusRegistersTableColumn1Label";
            controlAndStatusRegistersTableColumn1Label.Size = new Size(45, 20);
            controlAndStatusRegistersTableColumn1Label.TabIndex = 4;
            controlAndStatusRegistersTableColumn1Label.Text = "Value";
            // 
            // controlAndStatusRegistersTableColumn0Label
            // 
            controlAndStatusRegistersTableColumn0Label.AutoSize = true;
            controlAndStatusRegistersTableColumn0Label.Location = new Point(3, 0);
            controlAndStatusRegistersTableColumn0Label.Name = "controlAndStatusRegistersTableColumn0Label";
            controlAndStatusRegistersTableColumn0Label.Size = new Size(49, 20);
            controlAndStatusRegistersTableColumn0Label.TabIndex = 2;
            controlAndStatusRegistersTableColumn0Label.Text = "Name";
            // 
            // pcLabel
            // 
            pcLabel.AutoSize = true;
            pcLabel.Location = new Point(3, 60);
            pcLabel.Name = "pcLabel";
            pcLabel.Size = new Size(26, 20);
            pcLabel.TabIndex = 0;
            pcLabel.Text = "PC";
            // 
            // irLabel
            // 
            irLabel.AutoSize = true;
            irLabel.Location = new Point(3, 120);
            irLabel.Name = "irLabel";
            irLabel.Size = new Size(22, 20);
            irLabel.TabIndex = 6;
            irLabel.Text = "IR";
            // 
            // flagLabel
            // 
            flagLabel.AutoSize = true;
            flagLabel.Location = new Point(3, 180);
            flagLabel.Name = "flagLabel";
            flagLabel.Size = new Size(43, 20);
            flagLabel.TabIndex = 8;
            flagLabel.Text = "FLAG";
            // 
            // spLabel
            // 
            spLabel.AutoSize = true;
            spLabel.Location = new Point(3, 240);
            spLabel.Name = "spLabel";
            spLabel.Size = new Size(25, 20);
            spLabel.TabIndex = 10;
            spLabel.Text = "SP";
            // 
            // pcValue
            // 
            pcValue.Location = new Point(116, 63);
            pcValue.Name = "pcValue";
            pcValue.ReadOnly = true;
            pcValue.Size = new Size(50, 27);
            pcValue.TabIndex = 20;
            pcValue.Text = "0x0";
            // 
            // CPUViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 606);
            Controls.Add(controlAndStatusregistersGroup);
            Controls.Add(generalRegistersGroup);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "CPUViewerForm";
            Text = "CPUViewer";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            generalRegistersGroup.ResumeLayout(false);
            registersTableLayoutPanel.ResumeLayout(false);
            registersTableLayoutPanel.PerformLayout();
            controlAndStatusregistersGroup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem runToolStripMenuItem;
        private GroupBox generalRegistersGroup;
        private TableLayoutPanel registersTableLayoutPanel;
        private Label r1Label;
        private Label r0Label;
        private Label generalRegistersTableColumn0Label;
        private Label generalRegistersTableColumn1Label;
        private Label generalRegistersTableColumn2Label;
        private Label generalRegistersTableColumn3Label;
        private Label r2Label;
        private Label r13Label;
        private Label r3Label;
        private Label r4Label;
        private Label r5Label;
        private Label r6Label;
        private Label r7Label;
        private Label r8Label;
        private Label r9Label;
        private Label r10Label;
        private Label r11Label;
        private Label r12Label;
        private Label r15Label;
        private Label r14Label;
        private TextBox r0Value;
        private TextBox r15Value;
        private TextBox r14Value;
        private TextBox r13Value;
        private TextBox r12Value;
        private TextBox r11Value;
        private TextBox r10Value;
        private TextBox r9Value;
        private TextBox r8Value;
        private TextBox r7Value;
        private TextBox r6Value;
        private TextBox r5Value;
        private TextBox r4Value;
        private TextBox r3Value;
        private TextBox r2Value;
        private TextBox r1Value;
        private GroupBox controlAndStatusregistersGroup;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox spValue;
        private TextBox flagValue;
        private TextBox irValue;
        private Label controlAndStatusRegistersTableColumn1Label;
        private Label controlAndStatusRegistersTableColumn0Label;
        private Label pcLabel;
        private Label irLabel;
        private Label flagLabel;
        private Label spLabel;
        private TextBox pcValue;
    }
}
