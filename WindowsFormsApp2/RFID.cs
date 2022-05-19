using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RFID : Form
    {

        int port = 0;
        string strIP = "";
        readonly MR6100Api.MR6100Api api = new MR6100Api.MR6100Api();
        byte v1 = 0;
        byte v2 = 0;
        int tagCount = 0;
        byte[,] tagData = null;
        int status = 0;

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        public RFID()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int status = 1;
            string strTemp = "";
            try
            {
                port = int.Parse(tbPort.Text.Trim());
                strIP = tbIP.Text.Trim();
            }
            catch (Exception)
            {
                libInfo.Items.Add("Please input the ip address and port !");
                return;
            }
            if (!api.isNetWorkConnect(strIP))
            {
                libInfo.Items.Add("The input ip is not exist.");
                return;
            }
            status = api.TcpConnectReader(strIP, port);
            if (status != MR6100Api.MR6100Api.SUCCESS_RETURN)
            {
                libInfo.Items.Add("Connect Reader Failed!  ");
                return;
            }
            status = api.GetFirmwareVersion(255, ref v1, ref v2);
            if (status != MR6100Api.MR6100Api.SUCCESS_RETURN)
            {
                libInfo.Items.Add("Can not connect with the reader!  ");
                return;
            }
            libInfo.Items.Add("Connect the reader success! ");
            strTemp = string.Format("Firmware version :V{0:d2}.{1:d2}   ", v1, v2);
            libInfo.Items.Add(strTemp);
            btnConnect.Enabled = false;
            btnConnect.BackColor = System.Drawing.Color.LightPink;
            btnDisconnect.Enabled = true;
            btnDisconnect.BackColor = System.Drawing.Color.Aquamarine;
            btnGetFirmVersion_Click(sender, e);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            timerRate.Enabled = false;
            if (timerGen2Identify.Enabled)
                timerGen2Identify.Enabled = false;
            api.TcpCloseConnect();
            stopwatch.Reset();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnConnect.BackColor = System.Drawing.Color.Aquamarine;
            btnDisconnect.BackColor = System.Drawing.Color.LightPink;
        }
        private void btnGetFirmVersion_Click(object sender, EventArgs e)
        {
            lbFirmVersion.Text = "";
            if (api.GetFirmwareVersion(255, ref v1, ref v2) == MR6100Api.MR6100Api.SUCCESS_RETURN)
            {
                lbFirmVersion.Text = string.Format("V{0:d2}.{1:d2}", v1, v2);
                libInfo.Items.Add("Get Firmware Version success.");
                return;
            }
            libInfo.Items.Add("Get Firmware Version fail.");
        }


      
        private void btnIdentify_Click(object sender, EventArgs e)
        {
            if (btnIdentify.Text == "Identify")
            {
                libInfo.Items.Add("Start Gen2 EPC Identify...");
                tagData = new byte[500, 14];
                ClearLabel();
                livGen2Identify.Items.Clear();
                btnIdentify.Text = "Stop";
                idList.Clear();
                timerGen2Identify.Enabled = true;
                timerReconnect.Enabled = true;
                timerRate.Enabled = true;
                stopwatch.Start();
            }
            else
            {
                libInfo.Items.Add("Stop Gen2 EPC Identify.");
                btnIdentify.Text = "Identify";
                stopwatch.Reset();
                timerReconnect.Enabled = false;
                timerGen2Identify.Enabled = false;
                timerRate.Enabled = false;
            }
        }

        private List<string> idList = new List<string>();
        private void timerInventory_Tick(object sender, EventArgs e)
        {
            lbTestDuration.Text = stopwatch.Elapsed.Days.ToString() + "d " + stopwatch.Elapsed.Hours.ToString() + ":" + stopwatch.Elapsed.Minutes.ToString() + ":" + stopwatch.Elapsed.Seconds.ToString();// +"." + ((stopwatch.Elapsed.Milliseconds) / 10).ToString();
            byte tag_flag = 0;
            tagCount = 0;
            status = api.EpcMultiTagIdentify(255, ref tagData, ref tagCount, ref tag_flag);
            if (status == MR6100Api.MR6100Api.SUCCESS_RETURN)
            {
                string strAnteNo = "", strID = "", strTemp = "";
                for (int i = 0; i < tagCount; i++)
                {
                    int j = 0;
                    strID = "";
                    strAnteNo = string.Format("{0:X2}", tagData[i, 1]);
                    for (j = 2; j < 14; j++) // update: 0->2, 12->14
                    {
                        strTemp = string.Format("{0:X2}", tagData[i, j]);
                        strID += strTemp;
                    }
                    if (strID == "000000000000000000000000")
                    {
                        //libInfo.Items.Add("000");
                        continue;
                    }
                    if (!idList.Contains(strID))
                    {
                        idList.Add(strID);
                        ListViewItem nItem = new ListViewItem();
                        nItem.SubItems[0].Text = (livGen2Identify.Items.Count + 1).ToString();
                        try
                        {
                            nItem.SubItems.Add((int.Parse(strAnteNo) + 1).ToString());
                        }
                        catch { nItem.SubItems.Add("1"); }
                        nItem.SubItems.Add(strID);
                        nItem.SubItems.Add("1");
                        livGen2Identify.Items.Add(nItem);
                    }
                    else
                    {
                        for (j = 0; j < livGen2Identify.Items.Count; j++)
                        {
                            if (strID == livGen2Identify.Items[j].SubItems[2].Text)
                            {
                                try
                                {
                                    livGen2Identify.Items[j].SubItems[1].Text = (int.Parse(strAnteNo) + 1).ToString();
                                    livGen2Identify.Items[j].SubItems[3].Text = (int.Parse(livGen2Identify.Items[j].SubItems[3].Text) + 1).ToString();
                                }
                                catch { break; }
                            }
                        }
                    }
                }
                try
                {
                    lbUniqueTags.Text = (livGen2Identify.Items.Count).ToString();
                    lbReadTimes.Text = (int.Parse(lbReadTimes.Text) + 1).ToString();
                    lbTotalReads.Text = (int.Parse(lbTotalReads.Text) + tagCount).ToString();
                }
                catch { };
            }
            if (stopwatch.ElapsedMilliseconds / 1000 > 0)
                lbAverageRate.Text = (int.Parse(lbTotalReads.Text) / (stopwatch.ElapsedMilliseconds / 1000)).ToString();
        }

        private void ClearLabel()
        {
            lbUniqueTags.Text = "0";
            lbTotalReads.Text = "0";
            lbPeakRate.Text = "0";
            lbAverageRate.Text = "0";
            lbReadTimes.Text = "0";
            lbTestDuration.Text = "0";
            readSeconds = 0;
        }

        int readSeconds = 0, rate = 0, peakRate = 0, totalReads = 0, lastTotalReads = 0;


        private void timerRate_Tick(object sender, EventArgs e)
        {
            readSeconds++;
            totalReads = int.Parse(lbTotalReads.Text);
            if (readSeconds <= 0)
                return;
            //rate =totalReads / readSeconds;
            if ((totalReads - lastTotalReads) > peakRate)
                peakRate = totalReads - lastTotalReads;
            lbPeakRate.Text = peakRate.ToString();
            //lbAverageRate.Text = rate.ToString();
            lastTotalReads = totalReads;
        }

        int iReconnect = 0;
        private void timerReconnect_Tick(object sender, EventArgs e)
        {
            if (status == 2009)
            {
                libInfo.Items.Add("Disconnect at: " + DateTime.Now.ToString() + "." + DateTime.Now.Second + "." + DateTime.Now.Millisecond);
                if (MR6100Api.MR6100Api.PortType == 1)
                {
                    if (api.isNetWorkConnect(strIP))
                    {
                        status = api.TcpConnectReader(strIP, port);
                        if (status == MR6100Api.MR6100Api.SUCCESS_RETURN)
                        {
                            iReconnect = 0;
                            libInfo.Items.Add("Reconnect the reader success.");
                            libInfo.Items.Add(DateTime.Now.ToString() + "." + DateTime.Now.Second + "." + DateTime.Now.Millisecond);
                        }
                        else
                        {
                            iReconnect++;
                            libInfo.Items.Add("Aren't able to send command to the reader.");
                        }
                    }
                    else
                    {
                        iReconnect++;
                        libInfo.Items.Add("Can't find the reader ip,reader disconnect.");
                    }
                }
            }
            if (iReconnect > 25)
            {
                if (btnIdentify.Text == "Stop")
                    btnIdentify_Click(sender, e);
                timerReconnect.Enabled = false;
                btnDisconnect_Click(sender, e);
                libInfo.Items.Add("Can't find the ip in the network,please check your reader.");
                iReconnect = 0;
            }
        }
    }
}
