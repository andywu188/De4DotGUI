using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace De4DotGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        public string InputDll { get; set; }

		public MainForm()
		{
		    InitializeComponent();
		}

        public MainForm(string path) : this()
        {
            InputDll = path;
        }
        private void BindData()
        {
            rbt64Bit.Enabled = Environment.Is64BitOperatingSystem;
            FindDe4DotPath();
            
            if (string.IsNullOrWhiteSpace(txtDe4dotPath.Text))
            {
                try
                {
                    var path = Common.GetValue(@"Software\de4dot GUI", "De4dotPath");
                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        txtDe4dotPath.Text = path;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var list = new List<CListItem>();
            list.Add(new CListItem("命名空间", "n"));
            list.Add(new CListItem("类型", "t"));
            list.Add(new CListItem("自动属性", "p"));
            list.Add(new CListItem("事件", "e"));
            list.Add(new CListItem("字段", "f"));
            list.Add(new CListItem("方法", "m"));
            list.Add(new CListItem("参数", "a"));
            list.Add(new CListItem("泛型参数", "g"));
            list.Add(new CListItem("委托字段", "d"));
            checkedListBox1.Items.AddRange(list.ToArray());

            var list2 = new List<CListItem>();
            list2.Add(new CListItem("默认", ""));
            list2.Add(new CListItem("详细", "v"));
            list2.Add(new CListItem("非常详细", "vv"));
            cmbVerbose.Items.AddRange(list2.ToArray());
            cmbVerbose.SelectedIndex = 0;

            var list3 = new List<CListItem>();
            list3.Add(new CListItem("智能识别", ""));
            list3.Add(new CListItem("未知", "un"));
            list3.Add(new CListItem("Agile.NET", "an"));
            list3.Add(new CListItem("Babel .NET", "bl"));
            list3.Add(new CListItem("CodeFort", "cf"));
            list3.Add(new CListItem("CodeVeil", "cv"));
            list3.Add(new CListItem("CodeWall", "cw"));
            list3.Add(new CListItem("Crypto Obfuscator", "co"));
            list3.Add(new CListItem("DeepSea", "ds"));
            list3.Add(new CListItem("Dotfuscator", "df"));
            list3.Add(new CListItem(".NET Reactor 3.X", "dr3"));
            list3.Add(new CListItem(".NET Reactor 4.X", "dr4"));
            list3.Add(new CListItem("Eazfuscator.NET", "ef"));
            list3.Add(new CListItem("Goliath.NET", "go"));
            list3.Add(new CListItem("ILProtector", "il"));
            list3.Add(new CListItem("MaxtoCode", "mc"));
            list3.Add(new CListItem("MPRESS", "mp"));
            list3.Add(new CListItem("Rummage", "rm"));
            list3.Add(new CListItem("Skater .NET", "sk"));
            list3.Add(new CListItem("SmartAssembly", "sa"));
            list3.Add(new CListItem("Spices.Net", "sn"));
            list3.Add(new CListItem("Xenocode", "xc"));
            comboBox2.Items.AddRange(list3.ToArray());
            comboBox2.SelectedIndex = 0;


            var list4 = new List<CListItem>();
            list4.Add(new CListItem("不解密字符串", "none"));
            list4.Add(new CListItem("使用默认字符串Decrypter的类型（通常是静态的）", "default"));
            list4.Add(new CListItem("如果可用，使用静态字符串解密", "static"));
            list4.Add(new CListItem("使用委托调用真正的字符串解密", "delegate"));
            list4.Add(new CListItem("调用真正的字符串解密和模拟某些指令", "emulate"));
            comboBox1.Items.AddRange(list4.ToArray());
            comboBox1.SelectedIndex = 1;

        }

        private void BindEvent(Control control = null)
	    {
	        var nowControl = control;
	        if (nowControl == null)
	        {
	            nowControl = panel1;
	        }

            foreach (Control ctrl in nowControl.Controls)
	        {
	            switch (ctrl.GetType().Name)
	            {
                    case "TextBox":
                        ctrl.TextChanged += ControlOnTextChanged;
                        break;
                    case "CheckBox":
                        (ctrl as CheckBox).CheckedChanged += ControlOnTextChanged;
                        break;
                    case "CheckedListBox":
                        (ctrl as CheckedListBox).ItemCheck += ControlOnTextChanged;
                        break;
                    case "ComboBox":
                        (ctrl as ComboBox).SelectedValueChanged += ControlOnTextChanged;
                        break;
                    case "ListBox":
                        (ctrl as ListBox).TextChanged += ControlOnTextChanged;
                        break;
                    case "Label":
                    case "Button":
                    case "Control":
                        break;
                    default:
	                    BindEvent(ctrl);
                        break;
                }
            }
	    }

	    private void ControlOnTextChanged(object sender, EventArgs eventArgs)
	    {
            new Thread(() =>
            {
                Thread.Sleep(100);
                this.CrossThreadCall(()=> txtAdditional.Text = GetArguments());
            }).Start();
	    }

	    private void MainForm_Load(object sender, EventArgs e)
	    {
            //this.Text += " 吾爱破解专版";
            var ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text +=" V" + ver.ToString() + string.Format(" 发布日期：{0}", ver.ToDateTime().ToDateString());
	        this.Text += " 作者：Andy Wu";
            BindData();
            BindEvent();
	        SetBtnText();


            if (!string.IsNullOrWhiteSpace(InputDll))
	        {
	            if (DirectoryUtil.IsDir(InputDll))
	            {
	                tabControl1.SelectedTab = tabPage3;
	                txtInputDir.Text = InputDll;
	            }
	            else
                {
                    txtInputFile.Text = InputDll;
                }
            }
	    }


        #region 路径控件接受拖入文件
        private void txtDe4dotPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtDe4dotPath_DragDrop(object sender, DragEventArgs e)
        {
            var dragPaths = ((System.Array)e.Data.GetData(DataFormats.FileDrop));
            foreach (string path in dragPaths)
            {
                var isDir = DirectoryUtil.IsDir(path);
                var isDll = false;
                if (!isDir && new string[] { ".exe", ".dll" }.Contains(Path.GetExtension(path), StringComparer.OrdinalIgnoreCase))
                {
                    isDll = true;
                }
                if (sender is TextBox)
                {
                    var txtEdit = (sender as TextBox);

                    //不是目录时，但控件要求是目录，则直接取目录
                    if (!isDir && (txtEdit == txtInputDir || txtEdit == txtOutputDir))
                    {
                        txtEdit.Text = Path.GetDirectoryName(path);
                        return;
                    }

                    //是目录时，但控件要求是文件，则直接取文件
                    if (isDir)
                    {
                        if (txtEdit == txtDe4dotPath)
                        {
                            FindDe4DotPath(path);
                            return;
                        }
                        else if (txtEdit == txtInputFile || txtEdit == txtOutputFile)
                        {
                            MessageBox.Show("文件无效，请选择exe或dll文件！");
                            return;
                        }
                    }

                    txtEdit.Text = path;
                }
                else if (sender is ListBox)
                {
                    var libEdit = (sender as ListBox);
                    //是目录时，但控件要求是文件，则直接取文件
                    if (isDir)
                    {
                        var dirPaths = DirectoryUtil.GetDirectories(path, "*.exe", false).Concat(DirectoryUtil.GetDirectories(path, "*.dll", false)).ToArray();
                        foreach (var dirPath in dirPaths)
                        {
                            if (!libEdit.Items.Contains(dirPath))
                            {
                                libEdit.Items.Add(dirPath);
                            }
                        }
                    }
                    else
                    {
                        if (isDll && !libEdit.Items.Contains(path))
                        {
                            libEdit.Items.Add(path);
                        }
                    }
                    ControlOnTextChanged(null, null);
                }
            }
        }
        #endregion
        
        #region De4dot路径相关
        private void btnOpenDe4dotDir_Click(object sender, EventArgs e)
        {
            var path = FileDialogHelper.Open("选择de4dot软件所在位置", "(de4dot*.exe)|de4dot*.exe|所有文件 (*.*)|*.*", txtDe4dotPath.Text);
            if (!string.IsNullOrEmpty(path))
            {
                txtDe4dotPath.Text = path;
            }
        }
        private void FindDe4DotPath(string dir = null)
        {
            var de4dotPath = string.Empty;
            if (dir != null)
            {
                if (File.Exists(Path.Combine(dir, "de4dot.exe")))
                {
                    de4dotPath = Path.Combine(dir, "de4dot.exe");
                }
                else
                {
                    MessageBox.Show("目录无效，未找到de4dot程序！");
                }
            }
            else
            {
                if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "de4dot.exe")))
                {
                    de4dotPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "de4dot.exe");
                }
                else
                {
                    if (DirectoryUtil.GetSpeicalFolder(Environment.SpecialFolder.DesktopDirectory) == AppDomain.CurrentDomain.BaseDirectory)
                    {
                        return;
                    }
                    if (DirectoryUtil.GetTempPath() == AppDomain.CurrentDomain.BaseDirectory)
                    {
                        return;
                    }
                    //
                    var allDrives = DirectoryUtil.GetAllDrives().Select(n => n.RootDirectory.FullName);
                    if (allDrives.Contains(AppDomain.CurrentDomain.BaseDirectory))
                    {
                        return;
                    }

                    //当前子目录有没有匹配的目录
                    var de4dotPaths = DirectoryUtil.GetDirectories(AppDomain.CurrentDomain.BaseDirectory, "*de4dot*", false);
                    if (de4dotPaths != null && de4dotPaths.Length > 0)
                    {
                        for (int i = 0; i < de4dotPaths.Length; i++)
                        {
                            if (File.Exists(Path.Combine(de4dotPaths[i], "de4dot.exe")))
                            {
                                de4dotPaths[i] = Path.Combine(de4dotPaths[i], "de4dot.exe");
                            }
                            else
                            {
                                de4dotPaths[i] = string.Empty;
                            }
                        }
                        //已经找到的所有de4dot程序
                        de4dotPaths = de4dotPaths.Where(n => !string.IsNullOrEmpty(n)).ToArray();
                        var list = new Dictionary<string, Version>();
                        foreach (var de4DotPath in de4dotPaths)
                        {
                            FileVersionInfo info = FileVersionInfo.GetVersionInfo(de4DotPath);
                            list.Add(de4DotPath, new Version(info.ProductVersion));
                        }
                        //排序
                        list = list.OrderByDescending(i => i.Value).ThenByDescending(i => i.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
                        //取第一个
                        de4dotPath = list.FirstOrDefault().Key;
                    }
                }
            }
            txtDe4dotPath.Text = de4dotPath;
        }

        private void txtDe4dotPath_TextChanged(object sender, EventArgs e)
        {
            if (Path.GetFileNameWithoutExtension(txtDe4dotPath.Text).Contains("x64"))
            {
                rbt64Bit.Checked = true;
            }
            else
            {
                rbt32Bit.Checked = true;
            }
            try
            {
                Common.SaveValue(@"Software\de4dot GUI", "De4dotPath", txtDe4dotPath.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ControlOnTextChanged(null, null);
        }

        private void rbt32Bit_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDe4dotPath.Text))
            {

                if (rbt64Bit.Checked)
                {
                    if (!Path.GetFileNameWithoutExtension(txtDe4dotPath.Text).Contains("x64"))
                    {
                        txtDe4dotPath.Text = Path.Combine(Path.GetDirectoryName(txtDe4dotPath.Text), "de4dot-x64.exe");
                    }
                }
                else
                {
                    if (Path.GetFileNameWithoutExtension(txtDe4dotPath.Text).Contains("x64"))
                    {
                        txtDe4dotPath.Text = Path.Combine(Path.GetDirectoryName(txtDe4dotPath.Text), "de4dot.exe");
                    }
                }
            }
        }
        #endregion


        #region 文件模式

        #region 单文件模式
        private void btnSearchInput_Click(object sender, EventArgs e)
        {
            var path = FileDialogHelper.Open("选择PE文件所在位置", "PE 文件 (*.exe, *.dll)|*.exe;*.dll|所有文件|*.*", txtInputFile.Text);
            if (!string.IsNullOrEmpty(path))
            {
                txtInputFile.Text = path;
            }
        }

        private void btnSearchOutput_Click(object sender, EventArgs e)
        {
            var path = FileDialogHelper.Save("选择PE文件保存位置", "PE 文件 (*.exe, *.dll)|*.exe;*.dll|所有文件|*.*", txtOutputFile.Text);
            if (!string.IsNullOrEmpty(path))
            {
                txtOutputFile.Text = path;
            }
        }

        private void txtInputFile_TextChanged(object sender, EventArgs e)
        {
            if (chkCoverSource.Checked)
            {
                txtOutputFile.Text = txtInputFile.Text;
            }
            else
            {
                var file = Path.GetFileNameWithoutExtension(txtInputFile.Text);
                var ext = Path.GetExtension(txtInputFile.Text);
                var i = 0;
                var sp = file.Split(new string[] { "-cleaned" }, StringSplitOptions.None);
                if (sp.Length == 2)
                {
                    file = sp[0];
                    int.TryParse(sp[1], out i);
                }

                while (true)
                {
                    var newFile = string.Format("{0}\\{1}-cleaned{2}{3}", Path.GetDirectoryName(txtInputFile.Text), file, i == 0 ? "" : i.ToString().PadLeft(2, '0'), ext);
                    if (!File.Exists(newFile))
                    {
                        txtOutputFile.Text = newFile;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        private void chkCoverSource_CheckedChanged(object sender, EventArgs e)
        {
            txtInputFile_TextChanged(null, null);
        }
        #endregion

        #region 多文件模式
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //默认最后一个文件的路径
            var path = FileDialogHelper.Open("选择PE文件所在位置", "PE 文件 (*.exe, *.dll)|*.exe;*.dll|所有文件|*.*", libInputFiles.Items.Count== 0 ? string.Empty : libInputFiles.Items[libInputFiles.Items.Count - 1].ToString());
            if (!string.IsNullOrEmpty(path))
            {
                if (!libInputFiles.Items.Contains(path))
                {
                    libInputFiles.Items.Add(path);
                    ControlOnTextChanged(null, null);
                }
            }
        }

        private void btnDelFile_Click(object sender, EventArgs e)
        {
            if (libInputFiles.SelectedIndex >= 0)
            {
                libInputFiles.Items.RemoveAt(libInputFiles.SelectedIndex);

                ControlOnTextChanged(null, null);
            }
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            libInputFiles.Items.Clear();
            ControlOnTextChanged(null, null);
        }

        #endregion

        #region 目录模式
        private void btnInputDir_Click(object sender, EventArgs e)
        {
            var path = FileDialogHelper.OpenDir(txtInputDir.Text);
            if (!string.IsNullOrEmpty(path))
            {
                txtInputDir.Text = path;
            }
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            var path = FileDialogHelper.OpenDir(txtOutputDir.Text);
            if (!string.IsNullOrEmpty(path))
            {
                txtOutputDir.Text = path;
            }
        }

        private void txtInputDir_TextChanged(object sender, EventArgs e)
        {
            var i = 0;
            while (true)
            {
                var newDir = string.Format("{0}-cleaned{1}", txtInputDir.Text, i == 0 ? "" : i.ToString());
                if (!Directory.Exists(newDir))
                {
                    txtOutputDir.Text = newDir;
                    break;
                }
                else
                {
                    i++;
                }
            }
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Enabled = tabControl1.SelectedIndex < 1;
        }
        #endregion


        #region 执行命令
        private bool CheckInput()
        {
            if (!File.Exists(txtDe4dotPath.Text))
            {
                MessageBox.Show("de4dot文件不存在！", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        if (!File.Exists(txtInputFile.Text))
                        {
                            MessageBox.Show("源文件不存在！", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                    }
                case 1:
                    {
                        if (libInputFiles.Items.Count == 0)
                        {
                            MessageBox.Show("源文件不能为空！", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        foreach (string item in libInputFiles.Items)
                        {
                            if (!File.Exists(item))
                            {
                                MessageBox.Show(string.Format("文件{0}不存在！", item), "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (!Directory.Exists(txtInputDir.Text))
                        {
                            MessageBox.Show("源目录不存在！", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                    }
            }

            return true;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtAdditional.Text))
            {
                ExecCmd(txtAdditional.Text);
                if (tabControl1.SelectedIndex == 0 && checkBox2.Checked)
                {
                    //备份文件
                    var i = 0;
                    while (true)
                    {
                        var newFile = string.Format("{0}{1}.bak", txtInputFile.Text, i == 0 ? "" : i.ToString().PadLeft(2, '0'));
                        if (!File.Exists(newFile))
                        {
                            File.Copy(txtInputFile.Text, newFile);
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    try
                    {
                        File.Delete(txtInputFile.Text);
                        File.Move(txtOutputFile.Text, txtInputFile.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("覆盖原文件失败！原因:" + ex.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("参数为空，请选择参数！", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            if (!File.Exists(txtDe4dotPath.Text))
            {
                MessageBox.Show("de4dot文件不存在！", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExecCmd(" -help");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
        }

        private void aboutMe_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            txtOut.AppendText(String.Format("======================== 开始 ========================{0}{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}QQ：307577947{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}E-mail：andy.wct@126.com{0}", "\r\n"));
            //txtOut.AppendText(String.Format("{0}淘宝小店：https://shop104932048.taobao.com{0}", "\r\n"));
            //txtOut.AppendText(String.Format("{0}说明：承接.net软件开发、破解等业务{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}{0}======================== 结束 ========================{0}{0}", "\r\n"));
        }

        private void btnUpdateLog_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            txtOut.AppendText(String.Format("======================== 开始 ========================{0}{0}", "\r\n"));
            txtOut.AppendText(String.Format("升级日志：{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}1.0版，发布日期：{1}{0}", "\r\n", DateTime.Now.ToDateString()));
            txtOut.AppendText(String.Format("{0}       1、所有文件路径输入框支持文件拖拽。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       2、支持多种模式文件源。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       3、智能处理源文件路径（如源路径需要文件时，但拖拽的是目录，则自动转换为当前目录的所有文件并查找合适的文件，源路径需要目录时，但拖拽的是文件，则自动转换为当前文件的目录）。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       4、自动识别选择的de4dot程序是32位还是64位。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       5、自动保存最后选择的de4dot程序路径到注册表(需要管理员权限)。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       6、支持解密后文件自动覆盖，并自动备份。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       7、支持手工补充或修改参数信息。{0}", "\r\n"));
            txtOut.AppendText(String.Format("{0}       8、支持从命令行启动，并带参数。支持整合到右键菜单，exe、dll、文件夹才会显示菜单项。(需要管理员权限)", "\r\n"));
            txtOut.AppendText(String.Format("{0}{0}======================== 结束 ========================{0}{0}", "\r\n"));
        }

        private void btnContextMenuItem_Click(object sender, EventArgs e)
        {
            if (!Common.IsRegisted(@"directory\shell\用de4dot GUI解密\command"))
            {
                try
                {
                    var loc = string.Format("\"{0}\" \"%1\"", Assembly.GetExecutingAssembly().Location);
                    Common.AddFileContextMenuItem("用de4dot GUI解密", "dllfile", loc);
                    Common.AddFileContextMenuItem("用de4dot GUI解密", "exefile", loc);
                    Common.AddFileContextMenuItem("用de4dot GUI解密", "winmdfile", loc);
                    Common.AddFileContextMenuItem("用de4dot GUI解密", "netmodulefile", loc);
                    Common.AddDirectoryContextMenuItem("用de4dot GUI解密", Assembly.GetExecutingAssembly().Location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("关联右键菜单失败！请确保有权限操作注册表，建议以管理员权限运行重试！\r\n错误原因：" + ex.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Common.DeleteKey(@"dllfile\shell\用de4dot GUI解密");
                    Common.DeleteKey(@"exefile\shell\用de4dot GUI解密");
                    Common.DeleteKey(@"winmdfile\shell\用de4dot GUI解密");
                    Common.DeleteKey(@"netmodulefile\shell\用de4dot GUI解密");
                    Common.DeleteKey(@"directory\shell\用de4dot GUI解密");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("取消关联右键菜单失败！请确保有权限操作注册表，建议以管理员权限运行重试！\r\n错误原因：" + ex.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SetBtnText();
        }

	    private void SetBtnText()
	    {
            if (Common.IsRegisted(@"directory\shell\用de4dot GUI解密\command"))
            {
                btnContextMenuItem.Text = "删除右键菜单";
            }
            else
            {
                btnContextMenuItem.Text = "注册右键菜单";
            }
        }

        #endregion


        #region 获取参数和执行命令

        private string GetArguments()
        {
            var arguments = new StringBuilder();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        arguments.AppendFormat(" -f \"{0}\" -o \"{1}\"", txtInputFile.Text, txtOutputFile.Text);
                        break;
                    }
                case 1:
                    {
                        foreach (string item in libInputFiles.Items)
                        {
                            arguments.AppendFormat(" \"{0}\"", item);
                        }
                        break;
                    }
                case 2:
                    {
                        arguments.AppendFormat(" -r \"{0}\" -ro \"{1}\"", txtInputDir.Text, txtOutputDir.Text);
                        break;
                    }
            }
            //仅检测混淆器
            if (chkOnlyDetectObfuscators.Checked)
            {
                arguments.Append(" -d");
            }
            //不重命名类，方法等
            if (checkBox3.Checked)
            {
                arguments.Append(" --dont-rename");
            }
            //指定混淆类型
            if (comboBox2.SelectedItem != null)
            {
                var item = comboBox2.SelectedItem as CListItem;
                if (item?.Value != null && !string.IsNullOrEmpty(item.Value.ToString()))
                    arguments.Append(" -p " + item.Value);
            }
            //重命名时不创建方法参数
            if (checkBox4.Checked)
            {
                arguments.Append(" --dont-create-params");
            }
            //不重命名列表
            if (checkedListBox1.SelectedItems != null)
            {
                var sb = new StringBuilder();
                var arr = checkedListBox1.CheckedItems;
                foreach (CListItem item in arr)
                {
                    sb.Append(item.Value);
                }
                if (sb.Length > 0)
                {
                    arguments.Append(" --keep-names " + sb);
                }
            }
            //不还原属性/事件
            if (checkBox5.Checked)
            {
                arguments.Append(" --dont-restore-props");
            }
            //保留混淆类型、字段、方法
            if (checkBox8.Checked)
            {
                arguments.Append(" --keep-types");
            }
            //禁止控制流程反混淆（不推荐）
            if (checkBox6.Checked)
            {
                arguments.Append(" --no-cflow-deob");
            }
            //执行程序集加载到一个新的进程
            if (checkBox7.Checked)
            {
                arguments.Append(" --load-new-process");
            }
            //保留重要Token
            if (checkBox9.Checked)
            {
                arguments.Append(" --preserve-tokens");
            }
            //跳过不支持反混淆的文件(目录模式递归找到的文件)
            if (chkSkipRecursively.Checked)
            {
                arguments.Append(" -ru");
            }

            //指定解密类型
            if (comboBox1.SelectedItem != null)
            {
                var item = comboBox1.SelectedItem as CListItem;
                if (item?.Value != null && !string.IsNullOrEmpty(item.Value.ToString()) &&
                    item.Value.ToString() != "none")
                {
                    arguments.AppendFormat(" --{0}strtyp {1}", item.Value.ToString() == "default" ? "default-" : string.Empty, item.Value);

                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        var sp = textBox3.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var s in sp)
                        {
                            arguments.AppendFormat(" --{0}strtok {1}", item.Value.ToString() == "default" ? "default-" : string.Empty, s);
                        }
                    }
                }
            }
            

            //指定混淆类型
            if (cmbVerbose.SelectedItem != null)
            {
                var item = cmbVerbose.SelectedItem as CListItem;
                if (item?.Value != null && !string.IsNullOrEmpty(item.Value.ToString()))
                    arguments.Append(" -" + item.Value);
            }
            return arguments.ToString();
        }

        private static StringBuilder Content = new StringBuilder();
	    private static bool IsStop;
        private static object locker = new Object();
        private Process de4dot = null;
        private void ExecCmd(string arguments)
        {
            Kill();
            de4dot = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = txtDe4dotPath.Text,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            IsStop = false;
            new Thread((() =>
            {
                try
                {
                    var con = string.Empty;
                    while (!IsStop || Content.Length > 0)
                    {
                        lock (locker)
                        {
                            con = Content.ToString();
                        }
                        var len = con.Length;
                        if (len > 0)
                        {
                            lock (locker)
                            {
                                Content.Remove(0, len);
                            }
                            this.CrossThreadCall(() =>
                            {
                                txtOut.AppendText(con);
                                Application.DoEvents();
                            });
                        }
                        Thread.Sleep(500);
                    }
                }
                catch (Exception ex)
                {
                    this.CrossThreadCall(() => MessageBox.Show(ex.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error));
                }
            })).Start();

            new Thread((() =>
            {
                try
                {
                    lock (locker)
                    {
                        Content.Append(String.Format("======================== 开始 ========================{0}{0}命令行: {1}{0}{0}输出:{0}", "\r\n", String.Format("{0} {1}", txtDe4dotPath.Text, arguments)));
                    }
                    de4dot.Start();
                    while (!de4dot.StandardOutput.EndOfStream)
                    {
                        lock (locker)
                        {
                            Content.Append(String.Format("{0}{1}", de4dot.StandardOutput.ReadLine(), "\r\n"));
                        }
                    };
                }
                catch (Exception ex)
                {
                    this.CrossThreadCall(() => MessageBox.Show(ex.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error));
                }
                finally
                {
                    lock (locker)
                    {
                        Content.Append(String.Format("{0}{0}======================== 结束 ========================{0}{0}", "\r\n"));
                    }
                    IsStop = true;
                }
            })).Start();
            
        }


        /// <summary>
        /// 解决WIN10下无法自动退出de4dot进程的问题
        /// </summary>
        private void Kill()
        {
            if (de4dot != null && !de4dot.HasExited)
            {
                de4dot.Kill();
            }
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kill();
        }
    }
}
