using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigDemo
{
    public partial class Form1 : Form
    {
        INIClass iniclass;
        private string TransName;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iniclass = new INIClass(System.AppDomain.CurrentDomain.BaseDirectory + "FrameWorks.ini");
            if (string.IsNullOrEmpty(tbTransName.Text))
            {
                tbTransName.Text = "DHRQPayment";
            }

            TransName = tbTransName.Text;
            if (InitFileMsg() == -1)
            {
                tabControl1.Enabled = false;
                MessageBox.Show("目录下无配置文件，请将名为FrameWorks.ini文件拷至当前目录！");
            }

        }

        private int InitFileMsg()
        {
            try
            {
                if (string.IsNullOrEmpty(iniclass.inipath))
                {
                    return -1;
                }

                GetHardware("cbCardReader", "comboBox1", "comboBox2", "CardReader");
                GetHardware("cbEsam", "comboBox3", "comboBox4", "Esam");
                GetHardware("cbGasCardReader", "comboBox5", "comboBox6", "GasCardReader");
                GetHardware("cbPrinter", "comboBox7", "comboBox8", "ReceiptPrinter");

                lbSystemVersion.Text = iniclass.IniReadValue("AppData", "Version");
                cbAutoRun.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue("AppData", "AutoRun")));

                if (int.Parse(iniclass.IniReadValue("AppData", "CloseAcmSwitch")) == 0)
                {
                    rbCloseSwitch.Checked = true;
                    tbTurnoffOrRebootTime.Enabled = false;
                }
                else
                {
                    if (int.Parse(iniclass.IniReadValue("AppData", "CloseAcmType")) == 0)
                    {
                        //关机
                        rbTurnoff.Checked = true;
                        lbTurnoffOrRebootTime.Text = "关机时间：";
                    }
                    else
                    {
                        //重启
                        rbReboot.Checked = true;
                        lbTurnoffOrRebootTime.Text = "重启时间：";
                    }
                }
                tbTurnoffOrRebootTime.Text = iniclass.IniReadValue("AppData", "CloseAcmTime");


                cbIsUseNetwork.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue(TransName, "Use")));
                tbServerIP.Text = iniclass.IniReadValue(TransName, "ServerIP");
                tbTerminalNo.Text = iniclass.IniReadValue(TransName, "TerminalNo");
                tbTPDU.Text = iniclass.IniReadValue(TransName, "TPDU");
                tbServerPort.Text = iniclass.IniReadValue(TransName, "ServerPort");
                tbMerchantNo.Text = iniclass.IniReadValue(TransName, "MerchantNo");
                tbServerIP.Enabled = cbIsUseNetwork.Checked;
                tbTerminalNo.Enabled = cbIsUseNetwork.Checked;
                tbTPDU.Enabled = cbIsUseNetwork.Checked;
                tbServerPort.Enabled = cbIsUseNetwork.Checked;
                tbMerchantNo.Enabled = cbIsUseNetwork.Checked;

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                iniclass.IniWriteValue("AppData", "AutoRun", (Convert.ToInt32(cbAutoRun.Checked)).ToString());
                if(rbCloseSwitch.Checked)
                {
                    iniclass.IniWriteValue("AppData", "CloseAcmSwitch", "0");
                }
                else
                {
                    if(rbTurnoff.Checked)
                    {
                        iniclass.IniWriteValue("AppData", "CloseAcmType", "0");
                    }
                    else
                    {
                        iniclass.IniWriteValue("AppData", "CloseAcmType", "1");
                    }
                    iniclass.IniWriteValue("AppData", "CloseAcmTime", tbTurnoffOrRebootTime.Text);
                }

                SetHardware("cbCardReader", "comboBox1", "comboBox2", "CardReader");
                SetHardware("cbEsam", "comboBox3", "comboBox4", "Esam");
                SetHardware("cbGasCardReader", "comboBox5", "comboBox6", "GasCardReader");
                SetHardware("cbPrinter", "comboBox7", "comboBox8", "ReceiptPrinter");

                if(cbIsUseNetwork.Checked)
                {
                    iniclass.IniWriteValue(TransName, "Use", "1");
                    iniclass.IniWriteValue(TransName, "ServerIP", tbServerIP.Text);
                    iniclass.IniWriteValue(TransName, "ServerPort", tbServerPort.Text);
                    iniclass.IniWriteValue(TransName, "MerchantNo", tbMerchantNo.Text);
                    iniclass.IniWriteValue(TransName, "TerminalNo", tbTerminalNo.Text);
                    iniclass.IniWriteValue(TransName, "TPDU", tbTPDU.Text);
                }
                else
                {
                    iniclass.IniWriteValue(TransName, "Use", "0");
                }
                MessageBox.Show("保存成功！");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定要重启计算机？", "", MessageBoxButtons.OKCancel))
            {
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                myProcess.StandardInput.WriteLine("shutdown -r -t 5\r\n");//5秒后重启
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        #region Hardware
        private int GetHardware(string checkBoxName, string comPortName, string comBpsName, string sectionName)
        {
            try
            {
                CheckBox checkBox = (CheckBox)Controls.Find(checkBoxName, true)[0];
                ComboBox comPort = (ComboBox)Controls.Find(comPortName, true)[0];
                ComboBox comBps = (ComboBox)Controls.Find(comBpsName, true)[0];

                checkBox.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue(sectionName, "Use")));
                comPort.SelectedIndex = int.Parse(iniclass.IniReadValue(sectionName, "Port")) - 1;
                for (int i = 0; i < comBps.Items.Count; i++)
                {
                    if (comBps.Items[i].ToString() == iniclass.IniReadValue(sectionName, "Bps").Trim())
                    {
                        comBps.SelectedIndex = i;
                        break;
                    }
                }
                comPort.Enabled = checkBox.Checked;
                comBps.Enabled = checkBox.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            return 0;
        }

        private int SetHardware(string checkBoxName, string comPortName, string comBpsName, string sectionName)
        {
            try
            {
                CheckBox checkBox = (CheckBox)Controls.Find(checkBoxName, true)[0];
                ComboBox comPort = (ComboBox)Controls.Find(comPortName, true)[0];
                ComboBox comBps = (ComboBox)Controls.Find(comBpsName, true)[0];

                if(checkBox.Checked)
                {
                    iniclass.IniWriteValue(sectionName, "Use", "1");
                    iniclass.IniWriteValue(sectionName, "Port", comPort.Text.Substring(3));
                    iniclass.IniWriteValue(sectionName, "Bps", comBps.Text);
                }
                else
                {
                    iniclass.IniWriteValue(sectionName, "Use", "0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }
            return 0;
        }
        #endregion

        private void cbCardReader_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = cbCardReader.Checked;
            comboBox2.Enabled = cbCardReader.Checked;
        }

        private void cbEsam_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = cbEsam.Checked;
            comboBox4.Enabled = cbEsam.Checked;
        }

        private void cbGasCardReader_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Enabled = cbGasCardReader.Checked;
            comboBox6.Enabled = cbGasCardReader.Checked;
        }

        private void cbPrinter_CheckedChanged(object sender, EventArgs e)
        {
            comboBox7.Enabled = cbPrinter.Checked;
            comboBox8.Enabled = cbPrinter.Checked;
        }

        private void rbTurnoff_CheckedChanged(object sender, EventArgs e)
        {
            //tbTurnoffOrRebootTime.Enabled = rbTurnoff.Checked;
            if (rbTurnoff.Checked)
            lbTurnoffOrRebootTime.Text = "关机时间：";

        }

        private void rbReboot_CheckedChanged(object sender, EventArgs e)
        {
            //tbTurnoffOrRebootTime.Enabled = rbReboot.Checked;
            if (rbReboot.Checked)
                lbTurnoffOrRebootTime.Text = "重启时间：";
        }

        private void rbCloseSwitch_CheckedChanged(object sender, EventArgs e)
        {
            tbTurnoffOrRebootTime.Enabled = !rbCloseSwitch.Checked;
        }

        private void cbIsUseNetwork_CheckedChanged(object sender, EventArgs e)
        {
            tbServerIP.Enabled = cbIsUseNetwork.Checked;
            tbTerminalNo.Enabled = cbIsUseNetwork.Checked;
            tbTPDU.Enabled = cbIsUseNetwork.Checked;
            tbServerPort.Enabled = cbIsUseNetwork.Checked;
            tbMerchantNo.Enabled = cbIsUseNetwork.Checked;
        }

    }
}
