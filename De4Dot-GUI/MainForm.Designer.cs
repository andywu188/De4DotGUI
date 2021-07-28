namespace De4DotGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnSearchInput = new System.Windows.Forms.Button();
            this.btnSearchOutput = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdditional = new System.Windows.Forms.TextBox();
            this.rbt32Bit = new System.Windows.Forms.RadioButton();
            this.rbt64Bit = new System.Windows.Forms.RadioButton();
            this.btnWork = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearFile = new System.Windows.Forms.Button();
            this.btnDelFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.libInputFiles = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.btnInputDir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.chkOnlyDetectObfuscators = new System.Windows.Forms.CheckBox();
            this.txtDe4dotPath = new System.Windows.Forms.TextBox();
            this.btnOpenDe4dotDir = new System.Windows.Forms.Button();
            this.chkSkipRecursively = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVerbose = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkCoverSource = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.aboutMe = new System.Windows.Forms.Button();
            this.btnUpdateLog = new System.Windows.Forms.Button();
            this.btnContextMenuItem = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "源文件:";
            // 
            // txtInputFile
            // 
            this.txtInputFile.AllowDrop = true;
            this.txtInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFile.Location = new System.Drawing.Point(69, 19);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(257, 21);
            this.txtInputFile.TabIndex = 2;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            this.txtInputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragDrop);
            this.txtInputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragEnter);
            // 
            // btnSearchInput
            // 
            this.btnSearchInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchInput.Location = new System.Drawing.Point(328, 18);
            this.btnSearchInput.Name = "btnSearchInput";
            this.btnSearchInput.Size = new System.Drawing.Size(34, 21);
            this.btnSearchInput.TabIndex = 3;
            this.btnSearchInput.Text = "...";
            this.btnSearchInput.UseVisualStyleBackColor = true;
            this.btnSearchInput.Click += new System.EventHandler(this.btnSearchInput_Click);
            // 
            // btnSearchOutput
            // 
            this.btnSearchOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchOutput.Location = new System.Drawing.Point(328, 56);
            this.btnSearchOutput.Name = "btnSearchOutput";
            this.btnSearchOutput.Size = new System.Drawing.Size(34, 21);
            this.btnSearchOutput.TabIndex = 6;
            this.btnSearchOutput.Text = "...";
            this.btnSearchOutput.UseVisualStyleBackColor = true;
            this.btnSearchOutput.Click += new System.EventHandler(this.btnSearchOutput_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.AllowDrop = true;
            this.txtOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFile.Location = new System.Drawing.Point(69, 57);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(257, 21);
            this.txtOutputFile.TabIndex = 5;
            this.txtOutputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragDrop);
            this.txtOutputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输出文件:";
            // 
            // txtAdditional
            // 
            this.txtAdditional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdditional.Location = new System.Drawing.Point(3, 17);
            this.txtAdditional.Multiline = true;
            this.txtAdditional.Name = "txtAdditional";
            this.txtAdditional.Size = new System.Drawing.Size(499, 128);
            this.txtAdditional.TabIndex = 8;
            // 
            // rbt32Bit
            // 
            this.rbt32Bit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbt32Bit.AutoSize = true;
            this.rbt32Bit.Checked = true;
            this.rbt32Bit.Location = new System.Drawing.Point(274, 17);
            this.rbt32Bit.Name = "rbt32Bit";
            this.rbt32Bit.Size = new System.Drawing.Size(47, 16);
            this.rbt32Bit.TabIndex = 9;
            this.rbt32Bit.TabStop = true;
            this.rbt32Bit.Text = "32位";
            this.rbt32Bit.UseVisualStyleBackColor = true;
            this.rbt32Bit.CheckedChanged += new System.EventHandler(this.rbt32Bit_CheckedChanged);
            // 
            // rbt64Bit
            // 
            this.rbt64Bit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbt64Bit.AutoSize = true;
            this.rbt64Bit.Location = new System.Drawing.Point(328, 17);
            this.rbt64Bit.Name = "rbt64Bit";
            this.rbt64Bit.Size = new System.Drawing.Size(47, 16);
            this.rbt64Bit.TabIndex = 10;
            this.rbt64Bit.Text = "64位";
            this.rbt64Bit.CheckedChanged += new System.EventHandler(this.rbt32Bit_CheckedChanged);
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.Red;
            this.btnWork.ForeColor = System.Drawing.Color.Yellow;
            this.btnWork.Location = new System.Drawing.Point(401, 161);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(82, 27);
            this.btnWork.TabIndex = 11;
            this.btnWork.Text = "Fuck It!";
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // txtOut
            // 
            this.txtOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOut.Location = new System.Drawing.Point(3, 17);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(502, 363);
            this.txtOut.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 120);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtInputFile);
            this.tabPage1.Controls.Add(this.btnSearchInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtOutputFile);
            this.tabPage1.Controls.Add(this.btnSearchOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单文件模式";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearFile);
            this.tabPage2.Controls.Add(this.btnDelFile);
            this.tabPage2.Controls.Add(this.btnAddFile);
            this.tabPage2.Controls.Add(this.libInputFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "多文件模式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearFile
            // 
            this.btnClearFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearFile.Location = new System.Drawing.Point(321, 64);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(42, 23);
            this.btnClearFile.TabIndex = 1;
            this.btnClearFile.Text = "清空";
            this.btnClearFile.UseVisualStyleBackColor = true;
            this.btnClearFile.Click += new System.EventHandler(this.btnClearFile_Click);
            // 
            // btnDelFile
            // 
            this.btnDelFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelFile.Location = new System.Drawing.Point(320, 35);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(42, 23);
            this.btnDelFile.TabIndex = 1;
            this.btnDelFile.Text = "删除";
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFile.Location = new System.Drawing.Point(321, 6);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(42, 23);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "添加";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // libInputFiles
            // 
            this.libInputFiles.AllowDrop = true;
            this.libInputFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.libInputFiles.FormattingEnabled = true;
            this.libInputFiles.ItemHeight = 12;
            this.libInputFiles.Location = new System.Drawing.Point(3, 3);
            this.libInputFiles.Name = "libInputFiles";
            this.libInputFiles.Size = new System.Drawing.Size(311, 88);
            this.libInputFiles.TabIndex = 0;
            this.libInputFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragDrop);
            this.libInputFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragEnter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtInputDir);
            this.tabPage3.Controls.Add(this.btnInputDir);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtOutputDir);
            this.tabPage3.Controls.Add(this.btnOutputDir);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(370, 94);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "目录模式";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "源目录:";
            // 
            // txtInputDir
            // 
            this.txtInputDir.AllowDrop = true;
            this.txtInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputDir.Location = new System.Drawing.Point(69, 19);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.Size = new System.Drawing.Size(257, 21);
            this.txtInputDir.TabIndex = 8;
            this.txtInputDir.TextChanged += new System.EventHandler(this.txtInputDir_TextChanged);
            this.txtInputDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragDrop);
            this.txtInputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragEnter);
            // 
            // btnInputDir
            // 
            this.btnInputDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInputDir.Location = new System.Drawing.Point(328, 18);
            this.btnInputDir.Name = "btnInputDir";
            this.btnInputDir.Size = new System.Drawing.Size(34, 21);
            this.btnInputDir.TabIndex = 9;
            this.btnInputDir.Text = "...";
            this.btnInputDir.UseVisualStyleBackColor = true;
            this.btnInputDir.Click += new System.EventHandler(this.btnInputDir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "输出目录:";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.AllowDrop = true;
            this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDir.Location = new System.Drawing.Point(69, 57);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(257, 21);
            this.txtOutputDir.TabIndex = 11;
            this.txtOutputDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragDrop);
            this.txtOutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragEnter);
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOutputDir.Location = new System.Drawing.Point(328, 56);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(34, 21);
            this.btnOutputDir.TabIndex = 12;
            this.btnOutputDir.Text = "...";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // chkOnlyDetectObfuscators
            // 
            this.chkOnlyDetectObfuscators.AutoSize = true;
            this.chkOnlyDetectObfuscators.Location = new System.Drawing.Point(10, 23);
            this.chkOnlyDetectObfuscators.Name = "chkOnlyDetectObfuscators";
            this.chkOnlyDetectObfuscators.Size = new System.Drawing.Size(96, 16);
            this.chkOnlyDetectObfuscators.TabIndex = 16;
            this.chkOnlyDetectObfuscators.Text = "仅检测混淆器";
            this.toolTip1.SetToolTip(this.chkOnlyDetectObfuscators, "-d\r\nDetect obfuscators and exit");
            this.chkOnlyDetectObfuscators.UseVisualStyleBackColor = true;
            // 
            // txtDe4dotPath
            // 
            this.txtDe4dotPath.AllowDrop = true;
            this.txtDe4dotPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDe4dotPath.Location = new System.Drawing.Point(10, 15);
            this.txtDe4dotPath.Name = "txtDe4dotPath";
            this.txtDe4dotPath.ReadOnly = true;
            this.txtDe4dotPath.Size = new System.Drawing.Size(222, 21);
            this.txtDe4dotPath.TabIndex = 18;
            this.txtDe4dotPath.TextChanged += new System.EventHandler(this.txtDe4dotPath_TextChanged);
            this.txtDe4dotPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragDrop);
            this.txtDe4dotPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDe4dotPath_DragEnter);
            // 
            // btnOpenDe4dotDir
            // 
            this.btnOpenDe4dotDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenDe4dotDir.Location = new System.Drawing.Point(233, 14);
            this.btnOpenDe4dotDir.Name = "btnOpenDe4dotDir";
            this.btnOpenDe4dotDir.Size = new System.Drawing.Size(34, 21);
            this.btnOpenDe4dotDir.TabIndex = 19;
            this.btnOpenDe4dotDir.Text = "...";
            this.btnOpenDe4dotDir.UseVisualStyleBackColor = true;
            this.btnOpenDe4dotDir.Click += new System.EventHandler(this.btnOpenDe4dotDir_Click);
            // 
            // chkSkipRecursively
            // 
            this.chkSkipRecursively.AutoSize = true;
            this.chkSkipRecursively.Location = new System.Drawing.Point(9, 176);
            this.chkSkipRecursively.Name = "chkSkipRecursively";
            this.chkSkipRecursively.Size = new System.Drawing.Size(300, 16);
            this.chkSkipRecursively.TabIndex = 21;
            this.chkSkipRecursively.Text = "跳过不支持反混淆的文件(目录模式递归找到的文件)";
            this.toolTip1.SetToolTip(this.chkSkipRecursively, "-ru\r\nSkip recursively found files with unsupported obfuscator");
            this.chkSkipRecursively.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(207, 46);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 16);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "不重命名类，方法等";
            this.toolTip1.SetToolTip(this.checkBox3, "--dont-rename\r\nDon\'t rename classes, methods, etc.");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(10, 44);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(156, 16);
            this.checkBox4.TabIndex = 23;
            this.checkBox4.Text = "重命名时不创建方法参数";
            this.toolTip1.SetToolTip(this.checkBox4, "--dont-create-params\r\nDon\'t create method params when renaming");
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(10, 66);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(114, 16);
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "不还原属性/事件";
            this.toolTip1.SetToolTip(this.checkBox5, "--dont-restore-props\r\nDon\'t restore properties/events");
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(10, 110);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(192, 16);
            this.checkBox6.TabIndex = 25;
            this.checkBox6.Text = "禁止控制流程反混淆（不推荐）";
            this.toolTip1.SetToolTip(this.checkBox6, "--no-cflow-deob\r\nNo control flow deobfuscation (NOT recommended)");
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(10, 132);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(192, 16);
            this.checkBox7.TabIndex = 26;
            this.checkBox7.Text = "执行程序集加载到一个新的进程";
            this.toolTip1.SetToolTip(this.checkBox7, " --load-new-process\r\nLoad executed assemblies into a new process");
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVerbose);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.chkOnlyDetectObfuscators);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.chkSkipRecursively);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Location = new System.Drawing.Point(7, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 354);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "如有多个解密方法，请使用空格分开";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "混淆类型:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(264, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 20);
            this.comboBox2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "日志详细程度:";
            // 
            // cmbVerbose
            // 
            this.cmbVerbose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVerbose.FormattingEnabled = true;
            this.cmbVerbose.Location = new System.Drawing.Point(97, 324);
            this.cmbVerbose.Name = "cmbVerbose";
            this.cmbVerbose.Size = new System.Drawing.Size(121, 20);
            this.cmbVerbose.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "不重命名列表:";
            this.toolTip1.SetToolTip(this.label3, "--keep-names FLAGS\r\nDon\'t rename n(amespaces), t(ypes), p(rops), e(vents), f(ield" +
        "s), m(ethods), a(rgs), g(enericparams), d(elegate fields). Can be combined, eg.\r" +
        "\nefm");
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 70;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(206, 81);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 84);
            this.checkedListBox1.TabIndex = 32;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(10, 154);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(102, 16);
            this.checkBox9.TabIndex = 31;
            this.checkBox9.Text = "保留重要Token";
            this.toolTip1.SetToolTip(this.checkBox9, "--preserve-tokens\r\nPreserve important tokens, #US, #Blob, extra sig data");
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(10, 88);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(168, 16);
            this.checkBox8.TabIndex = 30;
            this.checkBox8.Text = "保留混淆类型、字段、方法";
            this.toolTip1.SetToolTip(this.checkBox8, "--keep-types\r\nKeep obfuscator types, fields, methods");
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 294);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(359, 21);
            this.textBox3.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "默认字符串解密method的Token或[type::][name][(args,...)]";
            this.toolTip1.SetToolTip(this.label9, "--default-strtok METHOD\r\nDefault string decrypter method token or [type::][name][" +
        "(args,...)]");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "默认字符串解密类型";
            this.toolTip1.SetToolTip(this.label8, "--default-strtyp TYPE\r\nDefault string decrypter type");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 20);
            this.comboBox1.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOut);
            this.groupBox2.Location = new System.Drawing.Point(395, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 383);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出日志";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAdditional);
            this.groupBox3.Location = new System.Drawing.Point(398, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 148);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "命令行参数（可以手工编写）";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDe4dotPath);
            this.groupBox4.Controls.Add(this.rbt32Bit);
            this.groupBox4.Controls.Add(this.btnOpenDe4dotDir);
            this.groupBox4.Controls.Add(this.rbt64Bit);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 44);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "de4dot路径";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 60;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(666, 165);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "显示帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(489, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "清空日志";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(7, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 515);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkCoverSource);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(5, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 24);
            this.panel2.TabIndex = 30;
            // 
            // chkCoverSource
            // 
            this.chkCoverSource.AutoSize = true;
            this.chkCoverSource.Location = new System.Drawing.Point(11, 4);
            this.chkCoverSource.Name = "chkCoverSource";
            this.chkCoverSource.Size = new System.Drawing.Size(84, 16);
            this.chkCoverSource.TabIndex = 28;
            this.chkCoverSource.Text = "覆盖源文件";
            this.chkCoverSource.UseVisualStyleBackColor = true;
            this.chkCoverSource.CheckedChanged += new System.EventHandler(this.chkCoverSource_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = " ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(102, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 16);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "备份源文件";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // aboutMe
            // 
            this.aboutMe.Location = new System.Drawing.Point(747, 165);
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(75, 23);
            this.aboutMe.TabIndex = 31;
            this.aboutMe.Text = "关于作者";
            this.aboutMe.UseVisualStyleBackColor = true;
            this.aboutMe.Click += new System.EventHandler(this.aboutMe_Click);
            // 
            // btnUpdateLog
            // 
            this.btnUpdateLog.Location = new System.Drawing.Point(828, 165);
            this.btnUpdateLog.Name = "btnUpdateLog";
            this.btnUpdateLog.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLog.TabIndex = 31;
            this.btnUpdateLog.Text = "升级日志";
            this.btnUpdateLog.UseVisualStyleBackColor = true;
            this.btnUpdateLog.Click += new System.EventHandler(this.btnUpdateLog_Click);
            // 
            // btnContextMenuItem
            // 
            this.btnContextMenuItem.Location = new System.Drawing.Point(570, 165);
            this.btnContextMenuItem.Name = "btnContextMenuItem";
            this.btnContextMenuItem.Size = new System.Drawing.Size(90, 23);
            this.btnContextMenuItem.TabIndex = 31;
            this.btnContextMenuItem.Text = "注册右键菜单";
            this.btnContextMenuItem.UseVisualStyleBackColor = true;
            this.btnContextMenuItem.Click += new System.EventHandler(this.btnContextMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContextMenuItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateLog);
            this.Controls.Add(this.aboutMe);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "de4dot GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.Button btnWork;
		private System.Windows.Forms.RadioButton rbt64Bit;
		private System.Windows.Forms.RadioButton rbt32Bit;
		private System.Windows.Forms.TextBox txtAdditional;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOutputFile;
		private System.Windows.Forms.Button btnSearchOutput;
		private System.Windows.Forms.Button btnSearchInput;
		private System.Windows.Forms.TextBox txtInputFile;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox libInputFiles;
        private System.Windows.Forms.Button btnClearFile;
        private System.Windows.Forms.Button btnDelFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.CheckBox chkOnlyDetectObfuscators;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.Button btnInputDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Button btnOutputDir;
        private System.Windows.Forms.TextBox txtDe4dotPath;
        private System.Windows.Forms.Button btnOpenDe4dotDir;
        private System.Windows.Forms.CheckBox chkSkipRecursively;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVerbose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutMe;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkCoverSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateLog;
        private System.Windows.Forms.Button btnContextMenuItem;
        private System.Windows.Forms.Label label11;
    }
}
