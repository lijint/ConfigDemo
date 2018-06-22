using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iniclass = new INIClass(System.AppDomain.CurrentDomain.BaseDirectory + "FrameWorks.ini");
            if(InitFileMsg()==-1)
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

                //cbCardReader.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue("CardReader", "Use")));
                //comboBox1.SelectedIndex = int.Parse(iniclass.IniReadValue("CardReader", "Port")) - 1;
                //for (int i = 0; i < comboBox2.Items.Count; i++)
                //{
                //    if (comboBox2.Items[i].ToString() == iniclass.IniReadValue("CardReader", "Bps").Trim())
                //    {
                //        comboBox2.SelectedIndex = i;
                //        break;
                //    }
                //}
                //if(cbCardReader.Checked)
                //{
                //    comboBox1.Enabled = true;
                //    comboBox2.Enabled = true;
                //}
                //else
                //{
                //    comboBox1.Enabled = false;
                //    comboBox2.Enabled = false;
                //}

                //cbEsam.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue("Esam", "Use")));
                //comboBox3.SelectedIndex = int.Parse(iniclass.IniReadValue("Esam", "Port")) - 1;
                //for (int i = 0; i < comboBox4.Items.Count; i++)
                //{
                //    if (comboBox4.Items[i].ToString() == iniclass.IniReadValue("Esam", "Bps").Trim())
                //    {
                //        comboBox4.SelectedIndex = i;
                //        break;
                //    }
                //}

                //cbGasCardReader.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue("GasCardReader", "Use")));
                //comboBox5.SelectedIndex = int.Parse(iniclass.IniReadValue("GasCardReader", "Port")) - 1;
                //for (int i = 0; i < comboBox6.Items.Count; i++)
                //{
                //    if (comboBox6.Items[i].ToString() == iniclass.IniReadValue("GasCardReader", "Bps").Trim())
                //    {
                //        comboBox6.SelectedIndex = i;
                //        break;
                //    }
                //}

                //cbPrinter.Checked = Convert.ToBoolean(int.Parse(iniclass.IniReadValue("ReceiptPrinter", "Use")));
                //comboBox7.SelectedIndex = int.Parse(iniclass.IniReadValue("ReceiptPrinter", "Port")) - 1;
                //for (int i = 0; i < comboBox8.Items.Count; i++)
                //{
                //    if (comboBox8.Items[i].ToString() == iniclass.IniReadValue("ReceiptPrinter", "Bps").Trim())
                //    {
                //        comboBox8.SelectedIndex = i;
                //        break;
                //    }
                //}

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

        }

        private void btnReboot_Click(object sender, EventArgs e)
        {

        }

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
                if (checkBox.Checked)
                {
                    comPort.Enabled = true;
                    comBps.Enabled = true;
                }
                else
                {
                    comPort.Enabled = false;
                    comBps.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            return 0;
        }
        private void cbCardReader_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCardReader.Checked)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void cbEsam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEsam.Checked)
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void cbGasCardReader_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGasCardReader.Checked)
            {
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void cbPrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrinter.Checked)
            {
                comboBox7.Enabled = true;
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
            }
        }
    }
}
