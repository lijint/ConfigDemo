namespace ConfigDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHardware = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPrinter = new System.Windows.Forms.CheckBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGasCardReader = new System.Windows.Forms.CheckBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEsam = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCardReader = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpSystem = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbTransName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbSystemVersion = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTurnoffOrRebootTime = new System.Windows.Forms.TextBox();
            this.lbTurnoffOrRebootTime = new System.Windows.Forms.Label();
            this.rbCloseSwitch = new System.Windows.Forms.RadioButton();
            this.rbReboot = new System.Windows.Forms.RadioButton();
            this.rbTurnoff = new System.Windows.Forms.RadioButton();
            this.tpTerminal = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbIsUseNetwork = new System.Windows.Forms.CheckBox();
            this.tbTPDU = new System.Windows.Forms.TextBox();
            this.tbMerchantNo = new System.Windows.Forms.TextBox();
            this.tbTerminalNo = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpHardware.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpSystem.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpTerminal.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHardware);
            this.tabControl1.Controls.Add(this.tpSystem);
            this.tabControl1.Controls.Add(this.tpTerminal);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 518);
            this.tabControl1.TabIndex = 3;
            // 
            // tpHardware
            // 
            this.tpHardware.Controls.Add(this.groupBox4);
            this.tpHardware.Controls.Add(this.groupBox3);
            this.tpHardware.Controls.Add(this.groupBox2);
            this.tpHardware.Controls.Add(this.groupBox1);
            this.tpHardware.Location = new System.Drawing.Point(4, 22);
            this.tpHardware.Name = "tpHardware";
            this.tpHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tpHardware.Size = new System.Drawing.Size(874, 492);
            this.tpHardware.TabIndex = 0;
            this.tpHardware.Text = "硬件参数配置";
            this.tpHardware.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPrinter);
            this.groupBox4.Controls.Add(this.comboBox7);
            this.groupBox4.Controls.Add(this.comboBox8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(477, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 176);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "凭条打印机";
            // 
            // cbPrinter
            // 
            this.cbPrinter.AutoSize = true;
            this.cbPrinter.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPrinter.Location = new System.Drawing.Point(32, 32);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(82, 18);
            this.cbPrinter.TabIndex = 4;
            this.cbPrinter.Text = "是否启用";
            this.cbPrinter.UseVisualStyleBackColor = true;
            this.cbPrinter.CheckedChanged += new System.EventHandler(this.cbPrinter_CheckedChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comboBox7.Location = new System.Drawing.Point(90, 72);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 20);
            this.comboBox7.TabIndex = 3;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.comboBox8.Location = new System.Drawing.Point(90, 120);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 20);
            this.comboBox8.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "波特率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(26, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "端口号";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGasCardReader);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(169, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "燃气卡读卡器";
            // 
            // cbGasCardReader
            // 
            this.cbGasCardReader.AutoSize = true;
            this.cbGasCardReader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbGasCardReader.Location = new System.Drawing.Point(32, 32);
            this.cbGasCardReader.Name = "cbGasCardReader";
            this.cbGasCardReader.Size = new System.Drawing.Size(82, 18);
            this.cbGasCardReader.TabIndex = 4;
            this.cbGasCardReader.Text = "是否启用";
            this.cbGasCardReader.UseVisualStyleBackColor = true;
            this.cbGasCardReader.CheckedChanged += new System.EventHandler(this.cbGasCardReader_CheckedChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comboBox5.Location = new System.Drawing.Point(90, 72);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.comboBox6.Location = new System.Drawing.Point(90, 120);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "波特率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(26, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEsam);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(477, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "密码键盘";
            // 
            // cbEsam
            // 
            this.cbEsam.AutoSize = true;
            this.cbEsam.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbEsam.Location = new System.Drawing.Point(32, 32);
            this.cbEsam.Name = "cbEsam";
            this.cbEsam.Size = new System.Drawing.Size(82, 18);
            this.cbEsam.TabIndex = 4;
            this.cbEsam.Text = "是否启用";
            this.cbEsam.UseVisualStyleBackColor = true;
            this.cbEsam.CheckedChanged += new System.EventHandler(this.cbEsam_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comboBox3.Location = new System.Drawing.Point(90, 72);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.comboBox4.Location = new System.Drawing.Point(90, 120);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "端口号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCardReader);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(169, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读卡器";
            // 
            // cbCardReader
            // 
            this.cbCardReader.AutoSize = true;
            this.cbCardReader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCardReader.Location = new System.Drawing.Point(32, 32);
            this.cbCardReader.Name = "cbCardReader";
            this.cbCardReader.Size = new System.Drawing.Size(82, 18);
            this.cbCardReader.TabIndex = 4;
            this.cbCardReader.Text = "是否启用";
            this.cbCardReader.UseVisualStyleBackColor = true;
            this.cbCardReader.CheckedChanged += new System.EventHandler(this.cbCardReader_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(90, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comboBox1.Location = new System.Drawing.Point(90, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(26, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "波特率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(26, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "端口号";
            // 
            // tpSystem
            // 
            this.tpSystem.Controls.Add(this.groupBox7);
            this.tpSystem.Controls.Add(this.groupBox6);
            this.tpSystem.Location = new System.Drawing.Point(4, 22);
            this.tpSystem.Name = "tpSystem";
            this.tpSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tpSystem.Size = new System.Drawing.Size(874, 492);
            this.tpSystem.TabIndex = 1;
            this.tpSystem.Text = "系统参数配置";
            this.tpSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbTransName);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.cbAutoRun);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.lbSystemVersion);
            this.groupBox7.Location = new System.Drawing.Point(46, 107);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(323, 183);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "系统配置";
            // 
            // tbTransName
            // 
            this.tbTransName.Location = new System.Drawing.Point(95, 36);
            this.tbTransName.Name = "tbTransName";
            this.tbTransName.ReadOnly = true;
            this.tbTransName.Size = new System.Drawing.Size(182, 21);
            this.tbTransName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "业务名：";
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoRun.Location = new System.Drawing.Point(38, 127);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(107, 20);
            this.cbAutoRun.TabIndex = 2;
            this.cbAutoRun.Text = "开机自启动";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "系统版本：";
            // 
            // lbSystemVersion
            // 
            this.lbSystemVersion.AutoSize = true;
            this.lbSystemVersion.Location = new System.Drawing.Point(107, 87);
            this.lbSystemVersion.Name = "lbSystemVersion";
            this.lbSystemVersion.Size = new System.Drawing.Size(41, 12);
            this.lbSystemVersion.TabIndex = 1;
            this.lbSystemVersion.Text = "V1.5.1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.tbTurnoffOrRebootTime);
            this.groupBox6.Controls.Add(this.lbTurnoffOrRebootTime);
            this.groupBox6.Controls.Add(this.rbCloseSwitch);
            this.groupBox6.Controls.Add(this.rbReboot);
            this.groupBox6.Controls.Add(this.rbTurnoff);
            this.groupBox6.Location = new System.Drawing.Point(478, 107);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 143);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "自动关机/重启";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "时间格式提示： 01：00：00";
            // 
            // tbTurnoffOrRebootTime
            // 
            this.tbTurnoffOrRebootTime.Location = new System.Drawing.Point(101, 78);
            this.tbTurnoffOrRebootTime.Name = "tbTurnoffOrRebootTime";
            this.tbTurnoffOrRebootTime.Size = new System.Drawing.Size(171, 21);
            this.tbTurnoffOrRebootTime.TabIndex = 4;
            // 
            // lbTurnoffOrRebootTime
            // 
            this.lbTurnoffOrRebootTime.AutoSize = true;
            this.lbTurnoffOrRebootTime.Location = new System.Drawing.Point(30, 81);
            this.lbTurnoffOrRebootTime.Name = "lbTurnoffOrRebootTime";
            this.lbTurnoffOrRebootTime.Size = new System.Drawing.Size(65, 12);
            this.lbTurnoffOrRebootTime.TabIndex = 3;
            this.lbTurnoffOrRebootTime.Text = "关机时间：";
            // 
            // rbCloseSwitch
            // 
            this.rbCloseSwitch.AutoSize = true;
            this.rbCloseSwitch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbCloseSwitch.Location = new System.Drawing.Point(213, 39);
            this.rbCloseSwitch.Name = "rbCloseSwitch";
            this.rbCloseSwitch.Size = new System.Drawing.Size(74, 20);
            this.rbCloseSwitch.TabIndex = 2;
            this.rbCloseSwitch.TabStop = true;
            this.rbCloseSwitch.Text = "不启用";
            this.rbCloseSwitch.UseVisualStyleBackColor = true;
            this.rbCloseSwitch.CheckedChanged += new System.EventHandler(this.rbCloseSwitch_CheckedChanged);
            // 
            // rbReboot
            // 
            this.rbReboot.AutoSize = true;
            this.rbReboot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbReboot.Location = new System.Drawing.Point(101, 39);
            this.rbReboot.Name = "rbReboot";
            this.rbReboot.Size = new System.Drawing.Size(58, 20);
            this.rbReboot.TabIndex = 1;
            this.rbReboot.TabStop = true;
            this.rbReboot.Text = "重启";
            this.rbReboot.UseVisualStyleBackColor = true;
            this.rbReboot.CheckedChanged += new System.EventHandler(this.rbReboot_CheckedChanged);
            // 
            // rbTurnoff
            // 
            this.rbTurnoff.AutoSize = true;
            this.rbTurnoff.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbTurnoff.Location = new System.Drawing.Point(32, 39);
            this.rbTurnoff.Name = "rbTurnoff";
            this.rbTurnoff.Size = new System.Drawing.Size(58, 20);
            this.rbTurnoff.TabIndex = 0;
            this.rbTurnoff.TabStop = true;
            this.rbTurnoff.Text = "关机";
            this.rbTurnoff.UseVisualStyleBackColor = true;
            this.rbTurnoff.CheckedChanged += new System.EventHandler(this.rbTurnoff_CheckedChanged);
            // 
            // tpTerminal
            // 
            this.tpTerminal.Controls.Add(this.groupBox5);
            this.tpTerminal.Location = new System.Drawing.Point(4, 22);
            this.tpTerminal.Name = "tpTerminal";
            this.tpTerminal.Size = new System.Drawing.Size(874, 492);
            this.tpTerminal.TabIndex = 2;
            this.tpTerminal.Text = "业务信息配置";
            this.tpTerminal.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbIsUseNetwork);
            this.groupBox5.Controls.Add(this.tbTPDU);
            this.groupBox5.Controls.Add(this.tbMerchantNo);
            this.groupBox5.Controls.Add(this.tbTerminalNo);
            this.groupBox5.Controls.Add(this.tbServerPort);
            this.groupBox5.Controls.Add(this.tbServerIP);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(34, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(792, 173);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "网络参数";
            // 
            // cbIsUseNetwork
            // 
            this.cbIsUseNetwork.AutoSize = true;
            this.cbIsUseNetwork.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIsUseNetwork.Location = new System.Drawing.Point(31, 34);
            this.cbIsUseNetwork.Name = "cbIsUseNetwork";
            this.cbIsUseNetwork.Size = new System.Drawing.Size(91, 20);
            this.cbIsUseNetwork.TabIndex = 9;
            this.cbIsUseNetwork.Text = "是否启用";
            this.cbIsUseNetwork.UseVisualStyleBackColor = true;
            this.cbIsUseNetwork.CheckedChanged += new System.EventHandler(this.cbIsUseNetwork_CheckedChanged);
            // 
            // tbTPDU
            // 
            this.tbTPDU.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTPDU.Location = new System.Drawing.Point(581, 74);
            this.tbTPDU.Name = "tbTPDU";
            this.tbTPDU.Size = new System.Drawing.Size(177, 23);
            this.tbTPDU.TabIndex = 8;
            // 
            // tbMerchantNo
            // 
            this.tbMerchantNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMerchantNo.Location = new System.Drawing.Point(342, 112);
            this.tbMerchantNo.Name = "tbMerchantNo";
            this.tbMerchantNo.Size = new System.Drawing.Size(177, 23);
            this.tbMerchantNo.TabIndex = 7;
            // 
            // tbTerminalNo
            // 
            this.tbTerminalNo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTerminalNo.Location = new System.Drawing.Point(342, 74);
            this.tbTerminalNo.Name = "tbTerminalNo";
            this.tbTerminalNo.Size = new System.Drawing.Size(177, 23);
            this.tbTerminalNo.TabIndex = 6;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbServerPort.Location = new System.Drawing.Point(100, 112);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(177, 23);
            this.tbServerPort.TabIndex = 5;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbServerIP.Location = new System.Drawing.Point(100, 74);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(177, 23);
            this.tbServerIP.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "TPDU：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "终端号：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "商户号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "端口号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "服务器IP：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(713, 567);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(102, 46);
            this.btnReboot.TabIndex = 5;
            this.btnReboot.Text = "重启系统";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(595, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 46);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 643);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "参数配置";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpHardware.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpSystem.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpTerminal.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHardware;
        private System.Windows.Forms.TabPage tpSystem;
        private System.Windows.Forms.TabPage tpTerminal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbCardReader;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbPrinter;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbGasCardReader;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbEsam;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTPDU;
        private System.Windows.Forms.TextBox tbMerchantNo;
        private System.Windows.Forms.TextBox tbTerminalNo;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbSystemVersion;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbCloseSwitch;
        private System.Windows.Forms.RadioButton rbReboot;
        private System.Windows.Forms.RadioButton rbTurnoff;
        private System.Windows.Forms.Label lbTurnoffOrRebootTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTurnoffOrRebootTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTransName;
        private System.Windows.Forms.CheckBox cbIsUseNetwork;
        private System.Windows.Forms.Button btnClose;
    }
}

