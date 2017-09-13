namespace v2rayN.Forms
{
    partial class OptionSettingForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkmuxEnabled = new System.Windows.Forms.CheckBox();
            this.chkAllowIn2 = new System.Windows.Forms.CheckBox();
            this.chkudpEnabled2 = new System.Windows.Forms.CheckBox();
            this.cmbprotocol2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocalPort2 = new System.Windows.Forms.TextBox();
            this.cmbprotocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkudpEnabled = new System.Windows.Forms.CheckBox();
            this.chklogEnabled = new System.Windows.Forms.CheckBox();
            this.cmbloglevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUseragent = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUserdirect = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtUserblock = new System.Windows.Forms.TextBox();
            this.chkBypassChinasites = new System.Windows.Forms.CheckBox();
            this.chkBypassChinaip = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkKcpcongestion = new System.Windows.Forms.CheckBox();
            this.txtKcpwriteBufferSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKcpreadBufferSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKcpdownlinkCapacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKcpuplinkCapacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKcptti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKcpmtu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txturlGFWList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkAutoSyncTime = new System.Windows.Forms.CheckBox();
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(355, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 496);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Core:基础设置  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkmuxEnabled);
            this.groupBox1.Controls.Add(this.chkAllowIn2);
            this.groupBox1.Controls.Add(this.chkudpEnabled2);
            this.groupBox1.Controls.Add(this.cmbprotocol2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlocalPort2);
            this.groupBox1.Controls.Add(this.cmbprotocol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkudpEnabled);
            this.groupBox1.Controls.Add(this.chklogEnabled);
            this.groupBox1.Controls.Add(this.cmbloglevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtlocalPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 464);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // chkmuxEnabled
            // 
            this.chkmuxEnabled.AutoSize = true;
            this.chkmuxEnabled.Location = new System.Drawing.Point(15, 93);
            this.chkmuxEnabled.Name = "chkmuxEnabled";
            this.chkmuxEnabled.Size = new System.Drawing.Size(174, 16);
            this.chkmuxEnabled.TabIndex = 20;
            this.chkmuxEnabled.Text = "开启Mux多路复用(默认开启)";
            this.chkmuxEnabled.UseVisualStyleBackColor = true;
            // 
            // chkAllowIn2
            // 
            this.chkAllowIn2.AutoSize = true;
            this.chkAllowIn2.Location = new System.Drawing.Point(15, 63);
            this.chkAllowIn2.Name = "chkAllowIn2";
            this.chkAllowIn2.Size = new System.Drawing.Size(102, 16);
            this.chkAllowIn2.TabIndex = 19;
            this.chkAllowIn2.Text = "本地监听端口2";
            this.chkAllowIn2.UseVisualStyleBackColor = true;
            this.chkAllowIn2.Visible = false;
            this.chkAllowIn2.CheckedChanged += new System.EventHandler(this.chkAllowIn2_CheckedChanged);
            // 
            // chkudpEnabled2
            // 
            this.chkudpEnabled2.AutoSize = true;
            this.chkudpEnabled2.Location = new System.Drawing.Point(369, 62);
            this.chkudpEnabled2.Name = "chkudpEnabled2";
            this.chkudpEnabled2.Size = new System.Drawing.Size(66, 16);
            this.chkudpEnabled2.TabIndex = 18;
            this.chkudpEnabled2.Text = "开启UDP";
            this.chkudpEnabled2.UseVisualStyleBackColor = true;
            this.chkudpEnabled2.Visible = false;
            // 
            // cmbprotocol2
            // 
            this.cmbprotocol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprotocol2.FormattingEnabled = true;
            this.cmbprotocol2.Items.AddRange(new object[] {
            "socks",
            "http"});
            this.cmbprotocol2.Location = new System.Drawing.Point(257, 60);
            this.cmbprotocol2.Name = "cmbprotocol2";
            this.cmbprotocol2.Size = new System.Drawing.Size(97, 20);
            this.cmbprotocol2.TabIndex = 17;
            this.cmbprotocol2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "协议";
            this.label3.Visible = false;
            // 
            // txtlocalPort2
            // 
            this.txtlocalPort2.Location = new System.Drawing.Point(124, 60);
            this.txtlocalPort2.Name = "txtlocalPort2";
            this.txtlocalPort2.Size = new System.Drawing.Size(78, 21);
            this.txtlocalPort2.TabIndex = 14;
            this.txtlocalPort2.Visible = false;
            // 
            // cmbprotocol
            // 
            this.cmbprotocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprotocol.Enabled = false;
            this.cmbprotocol.FormattingEnabled = true;
            this.cmbprotocol.Items.AddRange(new object[] {
            "socks",
            "http"});
            this.cmbprotocol.Location = new System.Drawing.Point(257, 25);
            this.cmbprotocol.Name = "cmbprotocol";
            this.cmbprotocol.Size = new System.Drawing.Size(97, 20);
            this.cmbprotocol.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "协议";
            // 
            // chkudpEnabled
            // 
            this.chkudpEnabled.AutoSize = true;
            this.chkudpEnabled.Location = new System.Drawing.Point(369, 27);
            this.chkudpEnabled.Name = "chkudpEnabled";
            this.chkudpEnabled.Size = new System.Drawing.Size(66, 16);
            this.chkudpEnabled.TabIndex = 10;
            this.chkudpEnabled.Text = "开启UDP";
            this.chkudpEnabled.UseVisualStyleBackColor = true;
            // 
            // chklogEnabled
            // 
            this.chklogEnabled.AutoSize = true;
            this.chklogEnabled.Location = new System.Drawing.Point(15, 124);
            this.chklogEnabled.Name = "chklogEnabled";
            this.chklogEnabled.Size = new System.Drawing.Size(156, 16);
            this.chklogEnabled.TabIndex = 9;
            this.chklogEnabled.Text = "记录本地日志(默认关闭)";
            this.chklogEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbloglevel
            // 
            this.cmbloglevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloglevel.FormattingEnabled = true;
            this.cmbloglevel.Items.AddRange(new object[] {
            "debug",
            "info",
            "warning",
            "error",
            "none"});
            this.cmbloglevel.Location = new System.Drawing.Point(257, 122);
            this.cmbloglevel.Name = "cmbloglevel";
            this.cmbloglevel.Size = new System.Drawing.Size(97, 20);
            this.cmbloglevel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "日志等级";
            // 
            // txtlocalPort
            // 
            this.txtlocalPort.Location = new System.Drawing.Point(124, 25);
            this.txtlocalPort.Name = "txtlocalPort";
            this.txtlocalPort.Size = new System.Drawing.Size(78, 21);
            this.txtlocalPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "本地监听端口";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Core:路由设置  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.chkBypassChinasites);
            this.groupBox2.Controls.Add(this.chkBypassChinaip);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 464);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "*设置的网址或IP，用逗号(,)隔开，可以一行多个";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(3, 83);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(508, 378);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUseragent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(500, 352);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "  代理的网址或IP  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUseragent
            // 
            this.txtUseragent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUseragent.Location = new System.Drawing.Point(3, 3);
            this.txtUseragent.Multiline = true;
            this.txtUseragent.Name = "txtUseragent";
            this.txtUseragent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUseragent.Size = new System.Drawing.Size(494, 346);
            this.txtUseragent.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtUserdirect);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(500, 352);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "  直连的网址或IP  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUserdirect
            // 
            this.txtUserdirect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserdirect.Location = new System.Drawing.Point(3, 3);
            this.txtUserdirect.Multiline = true;
            this.txtUserdirect.Name = "txtUserdirect";
            this.txtUserdirect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserdirect.Size = new System.Drawing.Size(494, 346);
            this.txtUserdirect.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtUserblock);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(500, 352);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "  阻止的网址或IP  ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtUserblock
            // 
            this.txtUserblock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserblock.Location = new System.Drawing.Point(3, 3);
            this.txtUserblock.Multiline = true;
            this.txtUserblock.Name = "txtUserblock";
            this.txtUserblock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserblock.Size = new System.Drawing.Size(494, 346);
            this.txtUserblock.TabIndex = 1;
            // 
            // chkBypassChinasites
            // 
            this.chkBypassChinasites.AutoSize = true;
            this.chkBypassChinasites.Location = new System.Drawing.Point(15, 20);
            this.chkBypassChinasites.Name = "chkBypassChinasites";
            this.chkBypassChinasites.Size = new System.Drawing.Size(96, 16);
            this.chkBypassChinasites.TabIndex = 10;
            this.chkBypassChinasites.Text = "绕过大陆地址";
            this.chkBypassChinasites.UseVisualStyleBackColor = true;
            // 
            // chkBypassChinaip
            // 
            this.chkBypassChinaip.AutoSize = true;
            this.chkBypassChinaip.Location = new System.Drawing.Point(15, 42);
            this.chkBypassChinaip.Name = "chkBypassChinaip";
            this.chkBypassChinaip.Size = new System.Drawing.Size(84, 16);
            this.chkBypassChinaip.TabIndex = 11;
            this.chkBypassChinaip.Text = "绕过大陆IP";
            this.chkBypassChinaip.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkKcpcongestion);
            this.tabPage6.Controls.Add(this.txtKcpwriteBufferSize);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.txtKcpreadBufferSize);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txtKcpdownlinkCapacity);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.txtKcpuplinkCapacity);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.txtKcptti);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.txtKcpmtu);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(520, 470);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "  Core:KCP设置  ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chkKcpcongestion
            // 
            this.chkKcpcongestion.AutoSize = true;
            this.chkKcpcongestion.Location = new System.Drawing.Point(20, 143);
            this.chkKcpcongestion.Name = "chkKcpcongestion";
            this.chkKcpcongestion.Size = new System.Drawing.Size(84, 16);
            this.chkKcpcongestion.TabIndex = 20;
            this.chkKcpcongestion.Text = "congestion";
            this.chkKcpcongestion.UseVisualStyleBackColor = true;
            // 
            // txtKcpwriteBufferSize
            // 
            this.txtKcpwriteBufferSize.Location = new System.Drawing.Point(345, 100);
            this.txtKcpwriteBufferSize.Name = "txtKcpwriteBufferSize";
            this.txtKcpwriteBufferSize.Size = new System.Drawing.Size(94, 21);
            this.txtKcpwriteBufferSize.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "writeBufferSize";
            // 
            // txtKcpreadBufferSize
            // 
            this.txtKcpreadBufferSize.Location = new System.Drawing.Point(111, 100);
            this.txtKcpreadBufferSize.Name = "txtKcpreadBufferSize";
            this.txtKcpreadBufferSize.Size = new System.Drawing.Size(94, 21);
            this.txtKcpreadBufferSize.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "readBufferSize";
            // 
            // txtKcpdownlinkCapacity
            // 
            this.txtKcpdownlinkCapacity.Location = new System.Drawing.Point(345, 62);
            this.txtKcpdownlinkCapacity.Name = "txtKcpdownlinkCapacity";
            this.txtKcpdownlinkCapacity.Size = new System.Drawing.Size(94, 21);
            this.txtKcpdownlinkCapacity.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "downlinkCapacity";
            // 
            // txtKcpuplinkCapacity
            // 
            this.txtKcpuplinkCapacity.Location = new System.Drawing.Point(111, 62);
            this.txtKcpuplinkCapacity.Name = "txtKcpuplinkCapacity";
            this.txtKcpuplinkCapacity.Size = new System.Drawing.Size(94, 21);
            this.txtKcpuplinkCapacity.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "uplinkCapacity";
            // 
            // txtKcptti
            // 
            this.txtKcptti.Location = new System.Drawing.Point(345, 24);
            this.txtKcptti.Name = "txtKcptti";
            this.txtKcptti.Size = new System.Drawing.Size(94, 21);
            this.txtKcptti.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "tti";
            // 
            // txtKcpmtu
            // 
            this.txtKcpmtu.Location = new System.Drawing.Point(111, 24);
            this.txtKcpmtu.Name = "txtKcpmtu";
            this.txtKcpmtu.Size = new System.Drawing.Size(94, 21);
            this.txtKcpmtu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "mtu";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.txturlGFWList);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.chkAutoSyncTime);
            this.tabPage7.Controls.Add(this.chkAutoRun);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(520, 470);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "  v2rayN设置  ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // txturlGFWList
            // 
            this.txturlGFWList.Location = new System.Drawing.Point(30, 96);
            this.txturlGFWList.Name = "txturlGFWList";
            this.txturlGFWList.Size = new System.Drawing.Size(468, 21);
            this.txturlGFWList.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "自定义GFWList地址(不需自定义请填空白)";
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(28, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(375, 42);
            this.label12.TabIndex = 25;
            this.label12.Text = "*启用系统代理:\r\n全局模式:端口=socks端口+1\r\nPAC 模式:端口=socks端口+2;优先级PAC > v2ray路由";
            // 
            // chkAutoSyncTime
            // 
            this.chkAutoSyncTime.AutoSize = true;
            this.chkAutoSyncTime.Location = new System.Drawing.Point(15, 43);
            this.chkAutoSyncTime.Name = "chkAutoSyncTime";
            this.chkAutoSyncTime.Size = new System.Drawing.Size(276, 16);
            this.chkAutoSyncTime.TabIndex = 24;
            this.chkAutoSyncTime.Text = "启动时自动从网络同步本地时间(可能会不成功)";
            this.chkAutoSyncTime.UseVisualStyleBackColor = true;
            this.chkAutoSyncTime.Visible = false;
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.Location = new System.Drawing.Point(15, 16);
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.Size = new System.Drawing.Size(180, 16);
            this.chkAutoRun.TabIndex = 23;
            this.chkAutoRun.Text = "开机自动启动(可能会不成功)";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 60);
            this.panel2.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(267, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 10);
            this.panel1.TabIndex = 9;
            // 
            // OptionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(528, 566);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionSettingForm";
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.OptionSettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbloglevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chklogEnabled;
        private System.Windows.Forms.CheckBox chkudpEnabled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkBypassChinasites;
        private System.Windows.Forms.CheckBox chkBypassChinaip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbprotocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbprotocol2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocalPort2;
        private System.Windows.Forms.CheckBox chkudpEnabled2;
        private System.Windows.Forms.CheckBox chkAllowIn2;
        private System.Windows.Forms.CheckBox chkmuxEnabled;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUseragent;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtUserdirect;
        private System.Windows.Forms.TextBox txtUserblock;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtKcpmtu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKcptti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKcpwriteBufferSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKcpreadBufferSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKcpdownlinkCapacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKcpuplinkCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkKcpcongestion;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chkAutoSyncTime;
        private System.Windows.Forms.CheckBox chkAutoRun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txturlGFWList;
    }
}