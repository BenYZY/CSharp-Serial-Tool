namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Com = new System.Windows.Forms.ComboBox();
            this.button_OpenCom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Band = new System.Windows.Forms.ComboBox();
            this.comboBox_DataBit = new System.Windows.Forms.ComboBox();
            this.comboBox_StopBit = new System.Windows.Forms.ComboBox();
            this.comboBox_CheckBit = new System.Windows.Forms.ComboBox();
            this.comboBox_Handshake = new System.Windows.Forms.ComboBox();
            this.checkBox_DTR = new System.Windows.Forms.CheckBox();
            this.checkBox_RTS = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_SendTime = new System.Windows.Forms.CheckBox();
            this.textBox_SendTime = new System.Windows.Forms.TextBox();
            this.checkBox_SendHex = new System.Windows.Forms.CheckBox();
            this.checkBox_SendLine = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_SendAfterClear = new System.Windows.Forms.Button();
            this.button_ClearSendData = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            this.button_DisplayLine = new System.Windows.Forms.Button();
            this.button_ClearReceive = new System.Windows.Forms.Button();
            this.checkBox_ReceiveHex = new System.Windows.Forms.CheckBox();
            this.checkBox_LineFeed = new System.Windows.Forms.CheckBox();
            this.button_CopyData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.textBox_File = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_CorrectMessage = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_TestMessage = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Test = new System.Windows.Forms.ListBox();
            this.numericUpDown_Test = new System.Windows.Forms.NumericUpDown();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Send = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Receive = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Com = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_COMname = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Test)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.92079F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.07921F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92899F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07101F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Com, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_OpenCom, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Band, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_DataBit, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_StopBit, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_CheckBit, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Handshake, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_DTR, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_RTS, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 308);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Com
            // 
            this.comboBox_Com.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Com.FormattingEnabled = true;
            this.comboBox_Com.Location = new System.Drawing.Point(83, 9);
            this.comboBox_Com.Name = "comboBox_Com";
            this.comboBox_Com.Size = new System.Drawing.Size(81, 28);
            this.comboBox_Com.TabIndex = 1;
            this.comboBox_Com.SelectedIndexChanged += new System.EventHandler(this.comboBox_Com_SelectedIndexChanged);
            this.comboBox_Com.TextChanged += new System.EventHandler(this.comboBox_Com_TextChanged);
            this.comboBox_Com.Click += new System.EventHandler(this.comboBox_Com_Click);
            // 
            // button_OpenCom
            // 
            this.button_OpenCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenCom.Location = new System.Drawing.Point(3, 41);
            this.button_OpenCom.Name = "button_OpenCom";
            this.button_OpenCom.Size = new System.Drawing.Size(74, 32);
            this.button_OpenCom.TabIndex = 2;
            this.button_OpenCom.Text = "打开串口";
            this.button_OpenCom.UseVisualStyleBackColor = true;
            this.button_OpenCom.Click += new System.EventHandler(this.button_OpenCom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "波特率:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据位:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "停止位:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "校验位:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "流控制:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Band
            // 
            this.comboBox_Band.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Band.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Band.FormattingEnabled = true;
            this.comboBox_Band.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBox_Band.Location = new System.Drawing.Point(83, 85);
            this.comboBox_Band.Name = "comboBox_Band";
            this.comboBox_Band.Size = new System.Drawing.Size(81, 28);
            this.comboBox_Band.TabIndex = 9;
            this.comboBox_Band.SelectedIndexChanged += new System.EventHandler(this.comboBox_Band_SelectedIndexChanged);
            // 
            // comboBox_DataBit
            // 
            this.comboBox_DataBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DataBit.FormattingEnabled = true;
            this.comboBox_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_DataBit.Location = new System.Drawing.Point(83, 123);
            this.comboBox_DataBit.Name = "comboBox_DataBit";
            this.comboBox_DataBit.Size = new System.Drawing.Size(81, 28);
            this.comboBox_DataBit.TabIndex = 10;
            this.comboBox_DataBit.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataBit_SelectedIndexChanged);
            // 
            // comboBox_StopBit
            // 
            this.comboBox_StopBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StopBit.FormattingEnabled = true;
            this.comboBox_StopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox_StopBit.Location = new System.Drawing.Point(83, 161);
            this.comboBox_StopBit.Name = "comboBox_StopBit";
            this.comboBox_StopBit.Size = new System.Drawing.Size(81, 28);
            this.comboBox_StopBit.TabIndex = 11;
            this.comboBox_StopBit.SelectedIndexChanged += new System.EventHandler(this.comboBox_StopBit_SelectedIndexChanged);
            // 
            // comboBox_CheckBit
            // 
            this.comboBox_CheckBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_CheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CheckBit.FormattingEnabled = true;
            this.comboBox_CheckBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mask",
            "Space"});
            this.comboBox_CheckBit.Location = new System.Drawing.Point(83, 199);
            this.comboBox_CheckBit.Name = "comboBox_CheckBit";
            this.comboBox_CheckBit.Size = new System.Drawing.Size(81, 28);
            this.comboBox_CheckBit.TabIndex = 12;
            this.comboBox_CheckBit.SelectedIndexChanged += new System.EventHandler(this.comboBox_CheckBit_SelectedIndexChanged);
            // 
            // comboBox_Handshake
            // 
            this.comboBox_Handshake.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Handshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Handshake.DropDownWidth = 165;
            this.comboBox_Handshake.FormattingEnabled = true;
            this.comboBox_Handshake.Items.AddRange(new object[] {
            "None",
            "XonXoff",
            "RequestToSend",
            "RequestToSendXonXoff"});
            this.comboBox_Handshake.Location = new System.Drawing.Point(83, 237);
            this.comboBox_Handshake.Name = "comboBox_Handshake";
            this.comboBox_Handshake.Size = new System.Drawing.Size(81, 28);
            this.comboBox_Handshake.TabIndex = 13;
            this.comboBox_Handshake.SelectedIndexChanged += new System.EventHandler(this.comboBox_Handshake_SelectedIndexChanged);
            // 
            // checkBox_DTR
            // 
            this.checkBox_DTR.AutoSize = true;
            this.checkBox_DTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_DTR.Location = new System.Drawing.Point(3, 269);
            this.checkBox_DTR.Name = "checkBox_DTR";
            this.checkBox_DTR.Size = new System.Drawing.Size(74, 36);
            this.checkBox_DTR.TabIndex = 14;
            this.checkBox_DTR.Text = "DTR";
            this.checkBox_DTR.UseVisualStyleBackColor = true;
            this.checkBox_DTR.CheckedChanged += new System.EventHandler(this.checkBox_DTR_CheckedChanged);
            // 
            // checkBox_RTS
            // 
            this.checkBox_RTS.AutoSize = true;
            this.checkBox_RTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_RTS.Location = new System.Drawing.Point(83, 269);
            this.checkBox_RTS.Name = "checkBox_RTS";
            this.checkBox_RTS.Size = new System.Drawing.Size(81, 36);
            this.checkBox_RTS.TabIndex = 15;
            this.checkBox_RTS.Text = "RTS";
            this.checkBox_RTS.UseVisualStyleBackColor = true;
            this.checkBox_RTS.CheckedChanged += new System.EventHandler(this.checkBox_RTS_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(83, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 32);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(3, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.375F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.625F));
            this.tableLayoutPanel4.Controls.Add(this.checkBox_SendTime, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox_SendTime, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_SendHex, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_SendLine, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(167, 127);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // checkBox_SendTime
            // 
            this.checkBox_SendTime.AutoSize = true;
            this.checkBox_SendTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_SendTime.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_SendTime.Location = new System.Drawing.Point(3, 3);
            this.checkBox_SendTime.Name = "checkBox_SendTime";
            this.checkBox_SendTime.Size = new System.Drawing.Size(76, 57);
            this.checkBox_SendTime.TabIndex = 0;
            this.checkBox_SendTime.Text = "定时发送(ms)";
            this.checkBox_SendTime.UseVisualStyleBackColor = true;
            this.checkBox_SendTime.Click += new System.EventHandler(this.checkBox_SendTime_Click);
            // 
            // textBox_SendTime
            // 
            this.textBox_SendTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SendTime.Location = new System.Drawing.Point(85, 17);
            this.textBox_SendTime.Name = "textBox_SendTime";
            this.textBox_SendTime.Size = new System.Drawing.Size(79, 29);
            this.textBox_SendTime.TabIndex = 1;
            this.textBox_SendTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SendTime.TextChanged += new System.EventHandler(this.textBox_SendTime_TextChanged);
            this.textBox_SendTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SendTime_KeyDown);
            this.textBox_SendTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SendTime_KeyPress);
            // 
            // checkBox_SendHex
            // 
            this.checkBox_SendHex.AutoSize = true;
            this.checkBox_SendHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_SendHex.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_SendHex.Location = new System.Drawing.Point(3, 66);
            this.checkBox_SendHex.Name = "checkBox_SendHex";
            this.checkBox_SendHex.Size = new System.Drawing.Size(76, 58);
            this.checkBox_SendHex.TabIndex = 2;
            this.checkBox_SendHex.Text = "以Hex发送";
            this.checkBox_SendHex.UseVisualStyleBackColor = true;
            this.checkBox_SendHex.Click += new System.EventHandler(this.checkBox_SendHex_Click);
            // 
            // checkBox_SendLine
            // 
            this.checkBox_SendLine.AutoSize = true;
            this.checkBox_SendLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_SendLine.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_SendLine.Location = new System.Drawing.Point(85, 66);
            this.checkBox_SendLine.Name = "checkBox_SendLine";
            this.checkBox_SendLine.Size = new System.Drawing.Size(79, 58);
            this.checkBox_SendLine.TabIndex = 3;
            this.checkBox_SendLine.Text = "发送新行";
            this.checkBox_SendLine.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(182, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(635, 155);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送区";
            this.groupBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox4_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.19962F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80038F));
            this.tableLayoutPanel5.Controls.Add(this.textBox_Send, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_Send, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_SendAfterClear, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.button_ClearSendData, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(629, 127);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Send.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Send.Location = new System.Drawing.Point(3, 3);
            this.textBox_Send.Multiline = true;
            this.textBox_Send.Name = "textBox_Send";
            this.tableLayoutPanel5.SetRowSpan(this.textBox_Send, 3);
            this.textBox_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Send.Size = new System.Drawing.Size(473, 121);
            this.textBox_Send.TabIndex = 0;
            this.textBox_Send.TextChanged += new System.EventHandler(this.textBox_Send_TextChanged);
            this.textBox_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Send_KeyDown);
            this.textBox_Send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Send_KeyPress);
            // 
            // button_Send
            // 
            this.button_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Send.Location = new System.Drawing.Point(482, 3);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(144, 37);
            this.button_Send.TabIndex = 1;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_SendAfterClear
            // 
            this.button_SendAfterClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SendAfterClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SendAfterClear.Location = new System.Drawing.Point(482, 46);
            this.button_SendAfterClear.Name = "button_SendAfterClear";
            this.button_SendAfterClear.Size = new System.Drawing.Size(144, 37);
            this.button_SendAfterClear.TabIndex = 2;
            this.button_SendAfterClear.Text = "清空接收后发送";
            this.button_SendAfterClear.UseVisualStyleBackColor = true;
            this.button_SendAfterClear.Click += new System.EventHandler(this.button_SendAfterClear_Click);
            // 
            // button_ClearSendData
            // 
            this.button_ClearSendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearSendData.Location = new System.Drawing.Point(482, 89);
            this.button_ClearSendData.Name = "button_ClearSendData";
            this.button_ClearSendData.Size = new System.Drawing.Size(144, 35);
            this.button_ClearSendData.TabIndex = 3;
            this.button_ClearSendData.Text = "清空发送区";
            this.button_ClearSendData.UseVisualStyleBackColor = true;
            this.button_ClearSendData.Click += new System.EventHandler(this.button_ClearSendData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(182, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 333);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "通用串口调试";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_Receive, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_DisplayLine, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_ClearReceive, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_ReceiveHex, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_LineFeed, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_CopyData, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.79245F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(615, 265);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_Receive
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.textBox_Receive, 5);
            this.textBox_Receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Receive.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Receive.Location = new System.Drawing.Point(3, 3);
            this.textBox_Receive.Multiline = true;
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Receive.Size = new System.Drawing.Size(609, 223);
            this.textBox_Receive.TabIndex = 2;
            this.textBox_Receive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Receive_KeyDown);
            this.textBox_Receive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Receive_KeyPress);
            // 
            // button_DisplayLine
            // 
            this.button_DisplayLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DisplayLine.Location = new System.Drawing.Point(3, 232);
            this.button_DisplayLine.Name = "button_DisplayLine";
            this.button_DisplayLine.Size = new System.Drawing.Size(118, 30);
            this.button_DisplayLine.TabIndex = 3;
            this.button_DisplayLine.Text = "接收换行设置";
            this.button_DisplayLine.UseVisualStyleBackColor = true;
            this.button_DisplayLine.Click += new System.EventHandler(this.button_DisplayLine_Click);
            // 
            // button_ClearReceive
            // 
            this.button_ClearReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearReceive.Location = new System.Drawing.Point(367, 232);
            this.button_ClearReceive.Name = "button_ClearReceive";
            this.button_ClearReceive.Size = new System.Drawing.Size(119, 30);
            this.button_ClearReceive.TabIndex = 0;
            this.button_ClearReceive.Text = "接收数据清除";
            this.button_ClearReceive.UseVisualStyleBackColor = true;
            this.button_ClearReceive.Click += new System.EventHandler(this.button_ClearReceive_Click);
            // 
            // checkBox_ReceiveHex
            // 
            this.checkBox_ReceiveHex.AutoSize = true;
            this.checkBox_ReceiveHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_ReceiveHex.Location = new System.Drawing.Point(247, 232);
            this.checkBox_ReceiveHex.Name = "checkBox_ReceiveHex";
            this.checkBox_ReceiveHex.Size = new System.Drawing.Size(114, 30);
            this.checkBox_ReceiveHex.TabIndex = 1;
            this.checkBox_ReceiveHex.Text = "Hex显示";
            this.checkBox_ReceiveHex.UseVisualStyleBackColor = true;
            this.checkBox_ReceiveHex.CheckedChanged += new System.EventHandler(this.checkBox_ReceiveHex_CheckedChanged);
            // 
            // checkBox_LineFeed
            // 
            this.checkBox_LineFeed.AutoSize = true;
            this.checkBox_LineFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_LineFeed.Location = new System.Drawing.Point(127, 232);
            this.checkBox_LineFeed.Name = "checkBox_LineFeed";
            this.checkBox_LineFeed.Size = new System.Drawing.Size(114, 30);
            this.checkBox_LineFeed.TabIndex = 4;
            this.checkBox_LineFeed.Text = "显示换行";
            this.checkBox_LineFeed.UseVisualStyleBackColor = true;
            this.checkBox_LineFeed.Click += new System.EventHandler(this.checkBox_LineFeed_Click);
            // 
            // button_CopyData
            // 
            this.button_CopyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CopyData.Location = new System.Drawing.Point(492, 232);
            this.button_CopyData.Name = "button_CopyData";
            this.button_CopyData.Size = new System.Drawing.Size(120, 30);
            this.button_CopyData.TabIndex = 5;
            this.button_CopyData.Text = "复制内容";
            this.button_CopyData.UseVisualStyleBackColor = true;
            this.button_CopyData.Click += new System.EventHandler(this.button_CopyData_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "通用命令测试";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.52288F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34641F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Controls.Add(this.button_OpenFile, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox_File, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox6, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.groupBox7, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Enabled = false;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.82432F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.2027F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(621, 293);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenFile.Location = new System.Drawing.Point(3, 3);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(90, 28);
            this.button_OpenFile.TabIndex = 0;
            this.button_OpenFile.Text = "选择文件";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // textBox_File
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.textBox_File, 2);
            this.textBox_File.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_File.Location = new System.Drawing.Point(99, 3);
            this.textBox_File.Name = "textBox_File";
            this.textBox_File.Size = new System.Drawing.Size(269, 29);
            this.textBox_File.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "结果：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(99, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 25);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.groupBox5, 3);
            this.groupBox5.Controls.Add(this.textBox_CorrectMessage);
            this.groupBox5.Location = new System.Drawing.Point(0, 34);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 118);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "正确命令";
            this.groupBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox5_Paint);
            // 
            // textBox_CorrectMessage
            // 
            this.textBox_CorrectMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CorrectMessage.Location = new System.Drawing.Point(7, 25);
            this.textBox_CorrectMessage.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_CorrectMessage.Multiline = true;
            this.textBox_CorrectMessage.Name = "textBox_CorrectMessage";
            this.textBox_CorrectMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_CorrectMessage.Size = new System.Drawing.Size(359, 85);
            this.textBox_CorrectMessage.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.groupBox6, 3);
            this.groupBox6.Controls.Add(this.textBox_TestMessage);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 152);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(371, 110);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "返回命令";
            this.groupBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox6_Paint);
            // 
            // textBox_TestMessage
            // 
            this.textBox_TestMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TestMessage.Location = new System.Drawing.Point(7, 25);
            this.textBox_TestMessage.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_TestMessage.Multiline = true;
            this.textBox_TestMessage.Name = "textBox_TestMessage";
            this.textBox_TestMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_TestMessage.Size = new System.Drawing.Size(359, 76);
            this.textBox_TestMessage.TabIndex = 0;
            this.textBox_TestMessage.TextChanged += new System.EventHandler(this.textBox_TestMessage_TextChanged);
            this.textBox_TestMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TestMessage_KeyDown);
            this.textBox_TestMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TestMessage_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel7);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(374, 3);
            this.groupBox7.Name = "groupBox7";
            this.tableLayoutPanel6.SetRowSpan(this.groupBox7, 4);
            this.groupBox7.Size = new System.Drawing.Size(244, 287);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "选择测试项目";
            this.groupBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox7_Paint);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.listBox_Test, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.numericUpDown_Test, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(238, 259);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // listBox_Test
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.listBox_Test, 3);
            this.listBox_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Test.FormattingEnabled = true;
            this.listBox_Test.HorizontalScrollbar = true;
            this.listBox_Test.ItemHeight = 21;
            this.listBox_Test.Location = new System.Drawing.Point(3, 3);
            this.listBox_Test.Name = "listBox_Test";
            this.listBox_Test.ScrollAlwaysVisible = true;
            this.listBox_Test.Size = new System.Drawing.Size(232, 214);
            this.listBox_Test.TabIndex = 0;
            this.listBox_Test.SelectedIndexChanged += new System.EventHandler(this.listBox_Test_SelectedIndexChanged);
            // 
            // numericUpDown_Test
            // 
            this.numericUpDown_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_Test.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_Test.Location = new System.Drawing.Point(50, 223);
            this.numericUpDown_Test.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Test.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Test.Name = "numericUpDown_Test";
            this.numericUpDown_Test.Size = new System.Drawing.Size(136, 34);
            this.numericUpDown_Test.TabIndex = 1;
            this.numericUpDown_Test.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Test.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Test.ValueChanged += new System.EventHandler(this.numericUpDown_Test_ValueChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Send,
            this.toolStripStatusLabel_Receive,
            this.toolStripStatusLabel_Com,
            this.toolStripStatusLabel_COMname});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Send
            // 
            this.toolStripStatusLabel_Send.Name = "toolStripStatusLabel_Send";
            this.toolStripStatusLabel_Send.Size = new System.Drawing.Size(78, 21);
            this.toolStripStatusLabel_Send.Text = "发送字节:";
            // 
            // toolStripStatusLabel_Receive
            // 
            this.toolStripStatusLabel_Receive.Name = "toolStripStatusLabel_Receive";
            this.toolStripStatusLabel_Receive.Size = new System.Drawing.Size(78, 21);
            this.toolStripStatusLabel_Receive.Text = "接收字节:";
            // 
            // toolStripStatusLabel_Com
            // 
            this.toolStripStatusLabel_Com.Name = "toolStripStatusLabel_Com";
            this.toolStripStatusLabel_Com.Size = new System.Drawing.Size(110, 21);
            this.toolStripStatusLabel_Com.Text = "串口状态:关闭";
            // 
            // toolStripStatusLabel_COMname
            // 
            this.toolStripStatusLabel_COMname.Name = "toolStripStatusLabel_COMname";
            this.toolStripStatusLabel_COMname.Size = new System.Drawing.Size(78, 21);
            this.toolStripStatusLabel_COMname.Text = "串口名称:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 500);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试软件（严震宇）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Test)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox_Com;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_OpenCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Band;
        private System.Windows.Forms.ComboBox comboBox_DataBit;
        private System.Windows.Forms.ComboBox comboBox_StopBit;
        private System.Windows.Forms.ComboBox comboBox_CheckBit;
        private System.Windows.Forms.ComboBox comboBox_Handshake;
        private System.Windows.Forms.CheckBox checkBox_DTR;
        private System.Windows.Forms.CheckBox checkBox_RTS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_ClearReceive;
        private System.Windows.Forms.CheckBox checkBox_ReceiveHex;
        private System.Windows.Forms.TextBox textBox_Receive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox checkBox_SendTime;
        private System.Windows.Forms.TextBox textBox_SendTime;
        private System.Windows.Forms.CheckBox checkBox_SendHex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_SendLine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_SendAfterClear;
        private System.Windows.Forms.Button button_ClearSendData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Send;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Receive;
        private System.Windows.Forms.Button button_DisplayLine;
        private System.Windows.Forms.CheckBox checkBox_LineFeed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.TextBox textBox_File;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_CorrectMessage;
        private System.Windows.Forms.TextBox textBox_TestMessage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_CopyData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ListBox listBox_Test;
        private System.Windows.Forms.NumericUpDown numericUpDown_Test;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Com;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_COMname;
    }
}

