using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
		//再试试amend
        List<byte> Receive_Message_list = new List<byte>();  //store receive byte type message
        string Send_Message_string;                     //store string type send message
        string Send_Message_hex;                        //store hex type send message
        int send_Num = 0;                               //number of send message byte 

        bool isLength = false;                          //Is flag of linefeed length of message 
        int LineLength = 0;                             //length of the linefeed
        bool isSymbol = false;                          //Is flag of linefeed a symbol
        byte bSymbol = 0x00;                            //symbol of linefeed
        int mode = 0;                                   //universal test or command tets
        int Command_Num = 0;                            //number of command
        bool isOpenCom = false;                         //flag of open com button
        int displayed_num = 0;                          //已经显示的byte个数
        int undisplay_num = 0;                          //未显示的byte个数

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName
            );

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName
            );

        #region WIN32 API
        /// <summary>
        /// 枚举win32 api
        /// </summary>
        public enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_Com_Click(object sender, EventArgs e)
        {
            comboBox_Com.Items.Clear();
            RegistryKey com = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (com != null)
            {
                string[] sSubKeys = com.GetValueNames();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)com.GetValue(sName);
                    if (sValue != "")
                    {
                        this.comboBox_Com.Items.Add(sValue);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Com.Items.Clear();
            RegistryKey com = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (com != null)
            {
                string[] sSubKeys = com.GetValueNames();
                this.comboBox_Com.Items.Clear();
                foreach (string sName in sSubKeys)
                {
                    string sValue = (string)com.GetValue(sName);
                    this.comboBox_Com.Items.Add(sValue);
                }
            }
            serialPort1.BaudRate = 9600;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = System.IO.Ports.Handshake.None;

            comboBox_Band.SelectedIndex = 6;
            comboBox_StopBit.SelectedIndex = 0;
            comboBox_CheckBit.SelectedIndex = 0;
            comboBox_DataBit.SelectedIndex = 3;
            comboBox_Handshake.SelectedIndex = 0;

            button_Send.Enabled = false;
            button_SendAfterClear.Enabled = false;
            checkBox_SendTime.Enabled = false;
            tabPage2.Parent = null; //隐藏tabpage2
        }

        private void button_OpenCom_Click(object sender, EventArgs e)
        {
            if (!isOpenCom)
            {
                if (comboBox_Com.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择串口");
                    return;
                }
                if (comboBox_Band.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择串口波特率");
                    return;
                }
                if (comboBox_DataBit.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择串口数据位");
                    return;
                }
                if (comboBox_StopBit.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择串口停止位");
                    return;
                }
                if (comboBox_CheckBit.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择串口校验位");
                    return;
                }
                if (comboBox_Handshake.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择串口流控制");
                    return;
                }
                serialPort1.PortName = comboBox_Com.SelectedItem.ToString();
                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        pictureBox1.BackColor = Color.LimeGreen;
                        button_OpenCom.Text = "关闭串口";
                        comboBox_Com.Enabled = false;
                        serialPort1.DiscardInBuffer();
                        serialPort1.DiscardOutBuffer();
                        button_Send.Enabled = true;
                        isOpenCom = true;
                        serialPort1.DataReceived += serialPort1_DataReceived;
                        timer2.Enabled = true;
                        if (mode == 0)
                        {
                            button_SendAfterClear.Enabled = true;
                            checkBox_SendTime.Enabled = true;
                        }
                        else
                        {
                            button_SendAfterClear.Enabled = true;
                            checkBox_SendTime.Enabled = false;
                        }
                        toolStripStatusLabel_Com.Text = "串口状态:打开";
                    }
                }
                catch (Exception ex)
                {
                    ComBack_Origin();
                    timer2.Enabled = false;
                    toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                    return;
                }
            }
            else
            {
                try
                {
                    serialPort1.DataReceived -= serialPort1_DataReceived;
                    timer2.Enabled = false;
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                    serialPort1.Close();
                    if (!serialPort1.IsOpen)
                    {
                        pictureBox1.BackColor = Color.Red;
                        button_OpenCom.Text = "打开串口";
                        button_Send.Enabled = false;
                        button_SendAfterClear.Enabled = false;
                        checkBox_SendTime.Enabled = false;
                        comboBox_Com.Enabled = true;
                        isOpenCom = false;
                        toolStripStatusLabel_Com.Text = "串口状态:关闭";
                    }
                }
                catch (Exception ex)
                {
                    ComBack_Origin();
                    timer2.Enabled = false;
                    toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                    return;
                }
            }
        }

        private void comboBox_Band_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(comboBox_Band.SelectedItem.ToString());
        }

        private void comboBox_DataBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.DataBits = int.Parse(comboBox_DataBit.SelectedItem.ToString());
        }

        private void comboBox_StopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox_StopBit.SelectedIndex)
            {
                case 0:
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case 1:
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
                case 2:
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    break;
            }
            
        }

        private void comboBox_CheckBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_CheckBit.SelectedIndex)
            {
                case 0:
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    break;
                case 1:
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case 2:
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                    break;
                case 3:
                    serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    break;
                case 4:
                    serialPort1.Parity = System.IO.Ports.Parity.Space;
                    break;
            }
        }

        private void comboBox_Handshake_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_Handshake.SelectedIndex)
            {
                case 0:
                    serialPort1.Handshake = System.IO.Ports.Handshake.None;
                    break;
                case 1:
                    serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
                    break;
                case 2:
                    serialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
                    break;
                case 3:
                    serialPort1.Handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serialPort1.Close();
            }
        }

        private void checkBox_DTR_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_DTR.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void checkBox_RTS_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_RTS.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        int buffer_Num_SerialPort = 0;
        byte[] temp_SerialPort;
        //Task Serial_Data_Process = new Task(Display_Receive);

        //串口线程负责接收所有数据，timer function负责显示定时刷新数据，只要刷新率保证人眼无法识别即可
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            buffer_Num_SerialPort = serialPort1.BytesToRead;
            temp_SerialPort = new byte[buffer_Num_SerialPort];
            serialPort1.Read(temp_SerialPort, 0, buffer_Num_SerialPort);
            Receive_Message_list.AddRange(temp_SerialPort);
            //undisplay_num = buffer_Num_SerialPort;
            //Display_Receive();

            //Serial_Data_Process.Start();
        }

        private delegate void myDisplay();


        byte[] byte_to_string;
        StringBuilder strH = new StringBuilder();
        //定时刷新显示数据，只要显示的字节与接收list的字节数不一致，就更新显示，并更新显示字节数
        void Display_Receive()
        {
            if(displayed_num >= Receive_Message_list.Count)
            {
                return;
            }

            undisplay_num = Receive_Message_list.Count - displayed_num;

            textBox_Receive.Invoke(new MethodInvoker(() => {
                if (!checkBox_ReceiveHex.Checked)
                {
                    //ASCII显示
                    byte_to_string = new byte[undisplay_num];
                    Receive_Message_list.CopyTo(displayed_num, byte_to_string, 0, undisplay_num);
                    textBox_Receive.AppendText( System.Text.Encoding.Default.GetString(byte_to_string));
                }
                else
                {
                    if (!checkBox_LineFeed.Checked)
                    {
                        //HEX显示，但不换行
                        strH.Clear();
                        for (int i = 0; i < undisplay_num; i++)
                        {
                            strH.Append(Receive_Message_list[displayed_num + i].ToString("X2"));
                            strH.Append(" ");
                        }
                        textBox_Receive.AppendText( strH.ToString());
                    }
                    else
                    {
                        strH.Clear();
                        if (isLength)
                        {
                            //HEX显示，按长度换行
                            for (int i = 0; i < undisplay_num; i++)
                            {
                                strH.Append(Receive_Message_list[displayed_num + i].ToString("X2"));
                                strH.Append(" ");
                                if ((displayed_num + i + 1) % LineLength == 0)
                                {
                                    strH.Append("\r\n");
                                }
                            }
                            textBox_Receive.AppendText(strH.ToString());
                        }
                        if (isSymbol)
                        {
                            //HEX显示，按某个数值作为终止符换行
                            for (int i = 0; i < undisplay_num; i++)
                            {
                                strH.Append(Receive_Message_list[displayed_num + i].ToString("X2"));
                                strH.Append(" ");
                                if (Receive_Message_list[displayed_num + i] == bSymbol)
                                {
                                    strH.Append("\r\n");
                                }
                            }
                            textBox_Receive.AppendText(strH.ToString());
                        }
                    }
                }

                displayed_num += undisplay_num;
                toolStripStatusLabel_Receive.Text = "接收字节:" + displayed_num;
                
                textBox_Receive.SelectionStart = textBox_Receive.Text.Length;
                textBox_Receive.ScrollToCaret();
            }));
        }

        

        void Display_TestReceive()
        {
            //if (textBox_TestMessage.InvokeRequired)
            //{
            //    myDisplay md = Display_TestReceive;
            //    textBox_Receive.Invoke(md);
            //}
            //else
            //{
                toolStripStatusLabel_Receive.Text = "接收字节:" + Receive_Message_list.Count;
                byte[] receByte = new byte[Receive_Message_list.Count];
                for (int i = 0; i < Receive_Message_list.Count; i++)
                {
                    receByte[i] = Receive_Message_list[i];
                }

                StringBuilder strH = new StringBuilder();
                for (int i = 0; i < receByte.Length; i++)
                {
                    strH.Append(receByte[i].ToString("X2"));
                    strH.Append(" ");
                }
                textBox_TestMessage.Text = strH.ToString();
                textBox_TestMessage.SelectionStart = textBox_TestMessage.Text.Length;
                textBox_TestMessage.ScrollToCaret();
            //}
        }

        private void button_ClearReceive_Click(object sender, EventArgs e)
        {
            textBox_Receive.Text = "";
            displayed_num = 0;
            undisplay_num = 0;
            Receive_Message_list.Clear();
            toolStripStatusLabel_Receive.Text = "接收字节:";
        }

        private void checkBox_ReceiveHex_CheckedChanged(object sender, EventArgs e)
        {
            //displayed_num = Receive_Message_list.Count;
            //toolStripStatusLabel_Receive.Text = "接收字节:" + displayed_num;

            byte[] receByte = new byte[displayed_num];
            Receive_Message_list.CopyTo(0, receByte, 0, displayed_num);

            if (!checkBox_ReceiveHex.Checked)
            {
                textBox_Receive.Text = System.Text.Encoding.Default.GetString(receByte);
            }
            else
            {
                if (!checkBox_LineFeed.Checked)
                {
                    StringBuilder strH = new StringBuilder();
                    for (int i = 0; i < receByte.Length; i++)
                    {
                        strH.Append(receByte[i].ToString("X2"));
                        strH.Append(" ");
                    }
                    textBox_Receive.Text = strH.ToString();
                }
                else
                {
                    if (isLength)
                    {
                        StringBuilder strH = new StringBuilder();
                        for (int i = 0; i < receByte.Length; i++)
                        {
                            strH.Append(receByte[i].ToString("X2"));
                            strH.Append(" ");
                            if ((i + 1) % LineLength == 0)
                            {
                                strH.Append("\r\n");
                            }
                        }
                        textBox_Receive.Text = strH.ToString();
                    }
                    if (isSymbol)
                    {
                        StringBuilder strH = new StringBuilder();
                        for (int i = 0; i < receByte.Length; i++)
                        {
                            strH.Append(receByte[i].ToString("X2"));
                            strH.Append(" ");
                            if (receByte[i] == bSymbol)
                            {
                                strH.Append("\r\n");
                            }
                        }
                        textBox_Receive.Text = strH.ToString();
                    }
                }
            }

           // undisplay_num = displayed_num;
            textBox_Receive.SelectionStart = textBox_Receive.Text.Length;
            textBox_Receive.ScrollToCaret();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedIndex == 0)
            {
                if (!checkBox_SendHex.Checked)
                {
                    if (!checkBox_SendLine.Checked)
                    {
                        try
                        {
                            serialPort1.Write(textBox_Send.Text);
                        }
                        catch (Exception ex)
                        {
                            ComBack_Origin();
                            toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                            return;
                        }
                        byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text);
                        send_Num += temp.Length;
                    }
                    else
                    {
                        try
                        {
                            serialPort1.Write(textBox_Send.Text + "\r\n");
                        }
                        catch (Exception ex)
                        {
                            ComBack_Origin();
                            toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                            return;
                        }
                        byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text + "\r\n");
                        send_Num += temp.Length;
                    }
                }
                else
                {
                    string temp = textBox_Send.Text;
                    while (temp.IndexOf(" ") != -1)
                    {
                        temp = temp.Remove(temp.IndexOf(" "), 1);
                    }
                    if (temp.Length % 2 != 0)
                    {
                        temp += "0";
                    }
                    byte[] sendByte = new byte[temp.Length / 2];
                    for (int i = 0; i < sendByte.Length; i++)
                    {
                        sendByte[i] = Convert.ToByte(temp.Substring(i * 2, 2), 16);
                    }
                    try
                    {
                        serialPort1.Write(sendByte, 0, sendByte.Length);
                    }
                    catch (Exception ex)
                    {
                        ComBack_Origin();
                        toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                        return;
                    }
                    
                    send_Num += sendByte.Length;
                }
            }

            if (tabControl1.SelectedIndex == 1)
            {
                string temp = textBox_Send.Text;
                while (temp.IndexOf(" ") != -1)
                {
                    temp = temp.Remove(temp.IndexOf(" "), 1);
                }
                if (temp.Length % 2 != 0)
                {
                    temp += "0";
                }
                byte[] sendByte = new byte[temp.Length / 2];
                for (int i = 0; i < sendByte.Length; i++)
                {
                    sendByte[i] = Convert.ToByte(temp.Substring(i * 2, 2), 16);
                }
                try
                {
                    serialPort1.Write(sendByte, 0, sendByte.Length);
                }
                catch (Exception ex)
                {
                    ComBack_Origin();
                    toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                    return;
                }
                send_Num += sendByte.Length;
            }

            toolStripStatusLabel_Send.Text = "发送字节:" + send_Num;
        }

        private void button_SendAfterClear_Click(object sender, EventArgs e)
        {
            textBox_Receive.Text = "";
            textBox_TestMessage.Text = "";
            Receive_Message_list.Clear();
            toolStripStatusLabel_Receive.Text = "接收字节:";

            if (tabControl1.SelectedIndex == 0)
            {
                if (!checkBox_SendHex.Checked)
                {
                    if (!checkBox_SendLine.Checked)
                    {
                        try
                        {
                            serialPort1.Write(textBox_Send.Text);
                        }
                        catch (Exception ex)
                        {
                            ComBack_Origin();
                            toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                            return;
                        }
                        
                        byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text);
                        send_Num += temp.Length;
                    }
                    else
                    {
                        try
                        {
                            serialPort1.Write(textBox_Send.Text + "\r\n");
                        }
                        catch (Exception ex)
                        {
                            ComBack_Origin();
                            toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                            return;
                        }
                        
                        byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text + "\r\n");
                        send_Num += temp.Length;
                    }
                }
                else
                {
                    string temp = textBox_Send.Text;
                    while (temp.IndexOf(" ") != -1)
                    {
                        temp = temp.Remove(temp.IndexOf(" "), 1);
                    }
                    if (temp.Length % 2 != 0)
                    {
                        temp += "0";
                    }
                    byte[] sendByte = new byte[temp.Length / 2];
                    for (int i = 0; i < sendByte.Length; i++)
                    {
                        sendByte[i] = Convert.ToByte(temp.Substring(i * 2, 2), 16);
                    }
                    try
                    {
                        serialPort1.Write(sendByte, 0, sendByte.Length);
                    }
                    catch (Exception ex)
                    {
                        ComBack_Origin();
                        toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                        return;
                    }
                    
                    send_Num += sendByte.Length;
                }
            }
            else
            {
                string temp = textBox_Send.Text;
                while (temp.IndexOf(" ") != -1)
                {
                    temp = temp.Remove(temp.IndexOf(" "), 1);
                }
                if (temp.Length % 2 != 0)
                {
                    temp += "0";
                }
                byte[] sendByte = new byte[temp.Length / 2];
                for (int i = 0; i < sendByte.Length; i++)
                {
                    sendByte[i] = Convert.ToByte(temp.Substring(i * 2, 2), 16);
                }
                try
                {
                    serialPort1.Write(sendByte, 0, sendByte.Length);
                }
                catch (Exception ex)
                {
                    ComBack_Origin();
                    toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                    return;
                }
                
                send_Num += sendByte.Length;
            }
            toolStripStatusLabel_Send.Text = "发送字节:" + send_Num;
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!checkBox_SendHex.Checked)
            {
                if (!checkBox_SendLine.Checked)
                {
                    try
                    {
                        serialPort1.Write(textBox_Send.Text);
                    }
                    catch (Exception ex)
                    {
                        timer1.Enabled = false;
                        ComBack_Origin();
                        toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                        return;
                    }
                    
                    byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text);
                    send_Num += temp.Length;
                }
                else
                {
                    try
                    {
                        serialPort1.Write(textBox_Send.Text + "\r\n");
                    }
                    catch (Exception ex)
                    {
                        timer1.Enabled = false;
                        ComBack_Origin();
                        toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                        return;
                    }
                   
                    byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text + "\r\n");
                    send_Num += temp.Length;
                }
            }
            else
            {
                string temp = textBox_Send.Text;
                while (temp.IndexOf(" ") != -1)
                {
                    temp = temp.Remove(temp.IndexOf(" "), 1);
                }
                if (temp.Length % 2 != 0)
                {
                    temp += "0";
                }
                byte[] sendByte = new byte[temp.Length / 2];
                for (int i = 0; i < sendByte.Length; i++)
                {
                    sendByte[i] = Convert.ToByte(temp.Substring(i * 2, 2), 16);
                }
                try
                {
                    serialPort1.Write(sendByte, 0, sendByte.Length);
                }
                catch (Exception ex)
                {
                    timer1.Enabled = false;
                    ComBack_Origin();
                    toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                    return;
                }
                
                send_Num += sendByte.Length;
            }
            toolStripStatusLabel_Send.Text = "发送字节:" + send_Num;
        }



        private void button_ClearSendData_Click(object sender, EventArgs e)
        {
            textBox_Send.Text = "";
            Send_Message_hex = "";
            Send_Message_string = "";
            toolStripStatusLabel_Send.Text = "发送字节:";
            send_Num = 0;
        }

        private void button_DisplayLine_Click(object sender, EventArgs e)
        {
            Form2 mf = new Form2();
            mf.textBox1.Text = LineLength.ToString();
            if (bSymbol == 0x00)
            {
                mf.textBox2.Text = "";
            } 
            else
            {
                mf.textBox2.Text = bSymbol.ToString("X2");
            }
             
            if (isLength)
            {
                mf.checkBox1.Checked = true;
            }
            if (isSymbol)
            {
                mf.checkBox2.Checked = true;
            }

            if (mf.ShowDialog() != DialogResult.No)
            {
                isLength = mf.checkBox1.Checked;
                isSymbol = mf.checkBox2.Checked;
                LineLength = int.Parse(mf.textBox1.Text);
                if (mf.textBox2.Text == "")
                {
                    bSymbol = 0x00;
                } 
                else
                {
                    bSymbol = Convert.ToByte(mf.textBox2.Text, 16);
                }
            }
        }

        private void checkBox_LineFeed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox1.BackColor);
            e.Graphics.DrawString(groupBox1.Text, groupBox1.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox1.Text, groupBox1.Font).Width + 8, 7, groupBox1.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox1.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox1.Height - 2, groupBox1.Width - 2, groupBox1.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox1.Width - 2, 7, groupBox1.Width - 2, groupBox1.Height - 2);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox2.BackColor);
            e.Graphics.DrawString(groupBox2.Text, groupBox2.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox2.Text, groupBox2.Font).Width + 8, 7, groupBox2.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox2.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox2.Height - 2, groupBox2.Width - 2, groupBox2.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox2.Width - 2, 7, groupBox2.Width - 2, groupBox2.Height - 2);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox3.BackColor);
            e.Graphics.DrawString(groupBox3.Text, groupBox3.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox3.Text, groupBox3.Font).Width + 8, 7, groupBox3.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox3.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox3.Height - 2, groupBox3.Width - 2, groupBox3.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox3.Width - 2, 7, groupBox3.Width - 2, groupBox3.Height - 2);
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox4.BackColor);
            e.Graphics.DrawString(groupBox4.Text, groupBox4.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox4.Text, groupBox4.Font).Width + 8, 7, groupBox4.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox4.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox4.Height - 2, groupBox4.Width - 2, groupBox4.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox4.Width - 2, 7, groupBox4.Width - 2, groupBox4.Height - 2);
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox5.BackColor);
            e.Graphics.DrawString(groupBox5.Text, groupBox5.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox5.Text, groupBox5.Font).Width + 8, 7, groupBox5.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox5.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox5.Height - 2, groupBox5.Width - 2, groupBox5.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox5.Width - 2, 7, groupBox5.Width - 2, groupBox5.Height - 2);
        }

        private void groupBox6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox6.BackColor);
            e.Graphics.DrawString(groupBox6.Text, groupBox6.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox6.Text, groupBox6.Font).Width + 8, 7, groupBox6.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox6.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox6.Height - 2, groupBox6.Width - 2, groupBox6.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox6.Width - 2, 7, groupBox6.Width - 2, groupBox6.Height - 2);
        }

        private void groupBox7_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox7.BackColor);
            e.Graphics.DrawString(groupBox7.Text, groupBox7.Font, Brushes.Black, 10, 1);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(groupBox7.Text, groupBox7.Font).Width + 8, 7, groupBox7.Width - 2, 7);
            e.Graphics.DrawLine(Pens.Black, 1, 7, 1, groupBox7.Height - 2);
            e.Graphics.DrawLine(Pens.Black, 1, groupBox7.Height - 2, groupBox7.Width - 2, groupBox7.Height - 2);
            e.Graphics.DrawLine(Pens.Black, groupBox7.Width - 2, 7, groupBox7.Width - 2, groupBox7.Height - 2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = tabControl1.SelectedIndex;
            textBox_Receive.Text = "";
            textBox_Send.Text = "";
            Receive_Message_list.Clear();
            toolStripStatusLabel_Receive.Text = "接收字节:";
            Send_Message_hex = "";
            Send_Message_string = "";
            toolStripStatusLabel_Send.Text = "发送字节:";
            send_Num = 0;

            if (mode == 0)
            {
                checkBox_SendHex.Enabled = true;
                checkBox_SendLine.Enabled = true;
                checkBox_SendTime.Enabled = true;
            }
            else
            {
                checkBox_SendHex.Enabled = false;
                checkBox_SendLine.Enabled = false;
                checkBox_SendTime.Enabled = false;
            }
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "配置文件|*.ini|所有文件|*.*";
            listBox_Test.Items.Clear();
            textBox_CorrectMessage.Text = "";
            textBox_TestMessage.Text = "";
            numericUpDown_Test.Value = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_File.Text = openFileDialog1.FileName;
                StringBuilder ss = new StringBuilder(100);
                GetPrivateProfileString("Summary", "Command Num", "", ss, 100, textBox_File.Text);
                Command_Num = int.Parse(ss.ToString());

                try
                {
                    for (int i = 1; i < Command_Num + 1; i++)
                    {
                        string temp = "Command " + i;
                        GetPrivateProfileString(temp, "Name", "", ss, 100, textBox_File.Text);
                        listBox_Test.Items.Add(ss.ToString());
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                    return;
                }

            }
        }

        private void listBox_Test_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Test.SelectedIndex == -1)
            {
                return;
            }
            if (textBox_File.Text == "")
	        {
		        return;
	        }
            try
            {
                StringBuilder ss = new StringBuilder(100);
                string temp = "Command " + (listBox_Test.SelectedIndex + 1);
                GetPrivateProfileString(temp, "Num", "", ss, 100, textBox_File.Text);
                numericUpDown_Test.Maximum = int.Parse(ss.ToString());
                numericUpDown_Test.Value = 1;

                GetPrivateProfileString(temp, "sm1", "", ss, 100, textBox_File.Text);
                textBox_Send.Text = ss.ToString();

                GetPrivateProfileString(temp, "rm1", "", ss, 100, textBox_File.Text);
                textBox_CorrectMessage.Text = ss.ToString();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                return;
            }

        }

        private void numericUpDown_Test_ValueChanged(object sender, EventArgs e)
        {
            if (listBox_Test.SelectedIndex == -1)
            {
                return;
            }
            if (textBox_File.Text == "")
            {
                return;
            }

            try
            {
                StringBuilder ss = new StringBuilder(100);
                string temp = "Command " + (listBox_Test.SelectedIndex + 1);
                string temp1 = "sm" + numericUpDown_Test.Value;
                string temp2 = "rm" + numericUpDown_Test.Value;
                GetPrivateProfileString(temp, temp1, "", ss, 100, textBox_File.Text);
                textBox_Send.Text = ss.ToString();

                GetPrivateProfileString(temp, temp2, "", ss, 100, textBox_File.Text);
                textBox_CorrectMessage.Text = ss.ToString();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel_Com.Text = "串口状态:" + ex.Message;
                return;
            }
        }



        private void button_CopyData_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox_Receive.Text);
        }



        private void checkBox_SendTime_Click(object sender, EventArgs e)
        {
            if (textBox_SendTime.Text == "")
            {
                MessageBox.Show("请先输入定时时间！");
                checkBox_SendTime.Checked = false;
                return;
            }

            if (!checkBox_SendTime.Checked)
            {
                timer1.Enabled = false;
                button_Send.Enabled = true;
                button_SendAfterClear.Enabled = true;
                button_SendAfterClear.Enabled = true;
            }
            else
            {
                timer1.Interval = int.Parse(textBox_SendTime.Text);
                button_Send.Enabled = false;
                button_SendAfterClear.Enabled = false;
                button_SendAfterClear.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void checkBox_SendHex_Click(object sender, EventArgs e)
        {
            if (!checkBox_SendHex.Checked)
            {
                checkBox_SendLine.Enabled = true;
                Send_Message_hex = textBox_Send.Text;
                textBox_Send.Text = Send_Message_string;
            }
            else
            {
                checkBox_SendLine.Enabled = false;
                Send_Message_string = textBox_Send.Text;
                textBox_Send.Text = Send_Message_hex;
            }
        }

        private void checkBox_LineFeed_Click(object sender, EventArgs e)
        {
            if (checkBox_LineFeed.Checked)
            {
                if (!isLength && !isSymbol)
                {
                    MessageBox.Show("请先选择换行设置！");
                    checkBox_LineFeed.Checked = false;
                    return;
                }
            }

            //displayed_num = Receive_Message_list.Count;
            //toolStripStatusLabel_Receive.Text = "接收字节:" + displayed_num;

            byte[] receByte = new byte[displayed_num];
            Receive_Message_list.CopyTo(0, receByte, 0, displayed_num);

            if (!checkBox_ReceiveHex.Checked)
            {
                textBox_Receive.Text = System.Text.Encoding.Default.GetString(receByte);
            }
            else
            {
                if (!checkBox_LineFeed.Checked)
                {
                    StringBuilder strH = new StringBuilder();
                    for (int i = 0; i < receByte.Length; i++)
                    {
                        strH.Append(receByte[i].ToString("X2"));
                        strH.Append(" ");
                    }
                    textBox_Receive.Text = strH.ToString();
                }
                else
                {
                    if (isLength)
                    {
                        StringBuilder strH = new StringBuilder();
                        for (int i = 0; i < receByte.Length; i++)
                        {
                            strH.Append(receByte[i].ToString("X2"));
                            strH.Append(" ");
                            if ((i + 1) % LineLength == 0)
                            {
                                strH.Append("\r\n");
                            }
                        }
                        textBox_Receive.Text = strH.ToString();
                    }
                    if (isSymbol)
                    {
                        StringBuilder strH = new StringBuilder();
                        for (int i = 0; i < receByte.Length; i++)
                        {
                            strH.Append(receByte[i].ToString("X2"));
                            strH.Append(" ");
                            if (receByte[i] == bSymbol)
                            {
                                strH.Append("\r\n");
                            }
                        }
                        textBox_Receive.Text = strH.ToString();
                    }
                }
            }

            textBox_Receive.SelectionStart = textBox_Receive.Text.Length;
            textBox_Receive.ScrollToCaret();
        }

        bool sendTime_flag = false;
        private void textBox_SendTime_KeyDown(object sender, KeyEventArgs e)
        {
            sendTime_flag = false;
            //组合键
            if (e.KeyData == (Keys.C | Keys.Control) || e.KeyData == (Keys.A | Keys.Control) || e.KeyData == (Keys.V | Keys.Control) || e.KeyData == (Keys.X | Keys.Control))
                return;
            if (!e.Shift && e.KeyValue >= '0' && e.KeyValue <= '9')
                return;
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete || e.KeyData == Keys.Left || e.KeyData == Keys.Right)
                return;
            sendTime_flag = true;
        }

        private void textBox_SendTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sendTime_flag)
            {
                e.Handled = true;
            }
        }
        private void textBox_SendTime_TextChanged(object sender, EventArgs e)
        {
            byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_SendTime.Text);
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 48 || temp[i] >57 )
                {
                    textBox_SendTime.Text = "";
                    MessageBox.Show("请写数字！");
                    return;
                }
            }
        }

        bool textBoxReceive_flag = false;
        private void textBox_Receive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxReceive_flag)
            {
                e.Handled = true;
            }
        }

        private void textBox_Receive_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxReceive_flag = false;
            //组合键
            if (e.KeyData == (Keys.C | Keys.Control) || e.KeyData == (Keys.A | Keys.Control))
                return;
            textBoxReceive_flag = true;
        }

        bool textBoxSend_flag = false;
        private void textBox_Send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxSend_flag)
            {
                e.Handled = true;
            }

        }

        private void textBox_Send_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxSend_flag = false;

            //组合键
            if (e.KeyData == (Keys.C | Keys.Control) || e.KeyData == (Keys.A | Keys.Control) || e.KeyData == (Keys.V | Keys.Control) || e.KeyData == (Keys.X | Keys.Control))
                return;
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete || e.KeyData == Keys.Left || e.KeyData == Keys.Right || e.KeyData == Keys.Space)
                return;

            if (checkBox_SendHex.Checked || tabControl1.SelectedIndex == 1)
            {
                if (!e.Shift && e.KeyValue >= '0' && e.KeyValue <= '9')
                    return;
                if ((e.KeyValue >= 'A' && e.KeyValue <= 'F') || (e.KeyValue >= 'a' && e.KeyValue <= 'f'))
                    return;
            }
            else
            {
                return;
            }

            textBoxSend_flag = true;
        }

        private void textBox_Send_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_SendHex.Checked || tabControl1.SelectedIndex == 1)
            {
                byte[] temp = System.Text.Encoding.Default.GetBytes(textBox_Send.Text);
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i]!=32 && (temp[i] < 48 || temp[i]> 57) && (temp[i] < 65 || temp[i] > 70) && (temp[i] < 97 || temp[i] > 102))
                    {
                        textBox_Send.Text = "";
                        MessageBox.Show("请写16进制数！");
                        return;
                    }
                }
            }
        }

        bool textBoxTestMessage_flag = false;
        private void textBox_TestMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxTestMessage_flag)
            {
                e.Handled = true;
            }
        }

        private void textBox_TestMessage_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox_CorrectMessage.Text;
            while (temp.IndexOf(" ") != -1)
            {
                temp = temp.Remove(temp.IndexOf(" "), 1);
            }

            string temp1 = textBox_TestMessage.Text;
            while (temp1.IndexOf(" ") != -1)
            {
                temp1 = temp1.Remove(temp1.IndexOf(" "), 1);
            }

            if (temp == temp1)
            {
                pictureBox2.BackColor = Color.LimeGreen;

            }
            else
            {
                pictureBox2.BackColor = Color.Red;
            }
        }

        private void textBox_TestMessage_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxTestMessage_flag = false;
            //组合键
            if (e.KeyData == (Keys.C | Keys.Control) || e.KeyData == (Keys.A | Keys.Control))
                return;
            textBoxTestMessage_flag = true;
        }

        private void comboBox_Com_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_PnPEntity where Name like '%(COM%'"))
            //"Select * From Win32_SerialPort"))
            //"root\\CIMV2",
            //  "SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\""))
            {
                if (comboBox_Com.SelectedIndex == -1)
                {
                    return;
                }

                var hardInfos = searcher.Get();
                foreach(var hardInfo in hardInfos)
                {
                    string Com_Name = hardInfo.GetPropertyValue("Name").ToString();
                    int com_index = Com_Name.IndexOf("COM");
                    if(com_index == -1)
                    {
                        break;
                    }

                    int com_no = 1;
                    string com_num = Com_Name.Substring(com_index + com_no + 2, 1);
                     while ((com_num == "0")||
                            (com_num == "1") ||
                            (com_num == "2") ||
                            (com_num == "3") ||
                            (com_num == "4") ||
                            (com_num == "5") ||
                            (com_num == "6") ||
                            (com_num == "7") ||
                            (com_num == "8") ||
                            (com_num == "9") 
                    )
                    {
                        com_no++;
                        com_num = Com_Name.Substring(com_index + com_no + 2, 1);
                    }

                    string Com_Name_s = Com_Name.Substring(com_index, com_no + 2);
                    if (comboBox_Com.SelectedItem.ToString() == Com_Name_s)
                    {
                        toolStripStatusLabel_COMname.Text = "串口名称: " + Com_Name;
                        break;
                    }
                }
                //int i = 0;

                //枚举所有的可用属性
                //foreach (var hardInfos in searcher.Get())//var hardInfo in hardInfos)
                //{
                //    //if (i == comboBox_Com.SelectedIndex)
                //    foreach (PropertyData pd in hardInfos.Properties)
                //    {

                //        if (pd.Value != null)
                //        {
                //            MessageBox.Show(pd.Name + ":" + pd.Value.ToString());
                //        }

                //    }
                //}
                    //MessageBox.Show(hardInfo.GetPropertyValue("Name").ToString() + "+" + hardInfo.GetPropertyValue("Description").ToString());
                    //if(hardInfo.GetPropertyValue("Name").ToString().IndexOf(comboBox_Com.SelectedText) != -1)
                    //{
                    //    toolStripStatusLabel_COMname.Text = "串口名称: " + hardInfo.GetPropertyValue("Name").ToString() + "+" + hardInfo.GetPropertyValue("Description").ToString();
                    //    break;
                    //}
                    //i++;
                    //if(comboBox_Com.SelectedText == hardInfo.Properties["Name"].Value.ToString())
                    //{
                    //    toolStripStatusLabel_COMname.Text = "串口名称: " + hardInfo.Properties["Description"].Value.ToString();
                    //    break;
                    //}
            }
            
            /*
            var search = new ManagementObjectSearcher(@"SELECT * FROM Win32_PnPEntity  WHERE Name LIKE '%COM%'");
            foreach (ManagementObject mo1 in search.Get())
            {
                if (mo1["Name"].ToString() == comboBox_Com.SelectedText)
                {
                    toolStripStatusLabel_COMname.Text = "串口名称: " + Environment.NewLine;
                }

            }
            */
        }

        private void ComBack_Origin()
        {
            pictureBox1.BackColor = Color.Red;
            button_OpenCom.Text = "打开串口";
            button_Send.Enabled = false;
            button_SendAfterClear.Enabled = false;
            checkBox_SendTime.Enabled = false;
            checkBox_SendTime.Checked = false;
            comboBox_Com.Enabled = true;
            toolStripStatusLabel_Com.Text = "串口状态:关闭";
            isOpenCom = false;
        }

        private void comboBox_Com_TextChanged(object sender, EventArgs e)
        {
            if(comboBox_Com.Text == "")
            {
                ComBack_Origin();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Display_Receive();
        }
    }
}
