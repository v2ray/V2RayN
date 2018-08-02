﻿using System;
using System.Windows.Forms;
using v2rayN.Handler;
using v2rayN.Mode;

namespace v2rayN.Forms
{
    public partial class AddServerForm : BaseForm
    {
        public int EditIndex { get; set; }

        public AddServerForm()
        {
            InitializeComponent();
        }

        private void AddServerForm_Load(object sender, EventArgs e)
        {
            if (EditIndex >= 0)
            {
                BindingServer();
            }
            else
            {
                NewServer();
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindingServer()
        {
            VmessItem vmessItem = config.vmess[EditIndex];

            txtAddress.Text = vmessItem.address;
            txtPort.Text = vmessItem.port.ToString();
            txtId.Text = vmessItem.id;
            txtAlterId.Text = vmessItem.alterId.ToString();
            cmbSecurity.Text = vmessItem.security;
            cmbNetwork.Text = vmessItem.network;
            txtRemarks.Text = vmessItem.remarks;

            cmbHeaderType.Text = vmessItem.headerType;
            txtRequestHost.Text = vmessItem.requestHost;
            cmbStreamSecurity.Text = vmessItem.streamSecurity;
        }


        /// <summary>
        /// 清除设置
        /// </summary>
        private void NewServer()
        {
            txtAddress.Text = "";
            txtPort.Text = "";
            txtId.Text = "";
            txtAlterId.Text = "0";
            cmbSecurity.Text = Global.DefaultSecurity;
            cmbNetwork.Text = Global.DefaultNetwork;
            txtRemarks.Text = "";

            cmbHeaderType.Text = Global.None;
            txtRequestHost.Text = "";
            cmbStreamSecurity.Text = "";
        }


        private void cmbNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetHeaderType();
        }

        /// <summary>
        /// 设置伪装选项
        /// </summary>
        private void SetHeaderType()
        {
            cmbHeaderType.Items.Clear();

            string network = cmbNetwork.Text;
            if (Utils.IsNullOrEmpty(network))
            {
                cmbHeaderType.Items.Add(Global.None);
                return;
            }

            cmbHeaderType.Items.Add(Global.None);
            if (network.Equals(Global.DefaultNetwork))
            {
                cmbHeaderType.Items.Add(Global.TcpHeaderHttp);
            }
            else if (network.Equals("kcp"))
            {
                cmbHeaderType.Items.Add("srtp");
                cmbHeaderType.Items.Add("utp");
                cmbHeaderType.Items.Add("wechat-video");
            }
            else
            {
            }
            cmbHeaderType.Text = Global.None;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            string port = txtPort.Text;
            string id = txtId.Text;
            string alterId = txtAlterId.Text;
            string security = cmbSecurity.Text;
            string network = cmbNetwork.Text;
            string remarks = txtRemarks.Text;

            string headerType = cmbHeaderType.Text;
            string requestHost = txtRequestHost.Text;
            string streamSecurity = cmbStreamSecurity.Text;

            if (Utils.IsNullOrEmpty(address))
            {
                UI.Show("请填写地址");
                return;
            }
            if (Utils.IsNullOrEmpty(port) || !Utils.IsNumberic(port))
            {
                UI.Show("请填写正确格式端口");
                return;
            }
            if (Utils.IsNullOrEmpty(id))
            {
                UI.Show("请填写用户ID");
                return;
            }
            if (Utils.IsNullOrEmpty(alterId) || !Utils.IsNumberic(alterId))
            {
                UI.Show("请填写正确格式额外ID");
                return;
            }

            VmessItem vmessItem = new VmessItem();
            vmessItem.address = address;
            vmessItem.port = Convert.ToInt32(port);
            vmessItem.id = id;
            vmessItem.alterId = Convert.ToInt32(alterId);
            vmessItem.security = security;
            vmessItem.network = network;
            vmessItem.remarks = remarks;

            vmessItem.headerType = headerType;
            vmessItem.requestHost = requestHost.Replace(" ", "");
            vmessItem.streamSecurity = streamSecurity;

            if (ConfigHandler.AddServer(ref config, vmessItem, EditIndex) == 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                UI.Show("操作失败，请检查重试");
            }
        }

        private void btnGUID_Click(object sender, EventArgs e)
        {
            txtId.Text = Utils.GetGUID();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        #region 导入客户端/服务端配置

        /// <summary>
        /// 导入客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemImportClient_Click(object sender, EventArgs e)
        {
            MenuItemImport(1);
        }

        /// <summary>
        /// 导入服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemImportServer_Click(object sender, EventArgs e)
        {
            MenuItemImport(2);
        }

        private void MenuItemImport(int type)
        {
            NewServer();

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Config|*.json|所有文件|*.*";
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = fileDialog.FileName;
            if (Utils.IsNullOrEmpty(fileName))
            {
                return;
            }
            string msg;
            VmessItem vmessItem;
            if (type.Equals(1))
            {
                vmessItem = V2rayConfigHandler.ImportFromClientConfig(fileName, out msg);
            }
            else
            {
                vmessItem = V2rayConfigHandler.ImportFromServerConfig(fileName, out msg);
            }
            if (vmessItem == null)
            {
                UI.Show(msg);
                return;
            }

            txtAddress.Text = vmessItem.address;
            txtPort.Text = vmessItem.port.ToString();
            txtId.Text = vmessItem.id;
            txtAlterId.Text = vmessItem.alterId.ToString();
            txtRemarks.Text = vmessItem.remarks;
            cmbNetwork.Text = vmessItem.network;
            cmbHeaderType.Text = vmessItem.headerType;
            txtRequestHost.Text = vmessItem.requestHost;
            cmbStreamSecurity.Text = vmessItem.streamSecurity;
        }

        /// <summary>
        /// 从剪贴板导入URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemImportClipboard_Click(object sender, EventArgs e)
        {
            NewServer();

            string msg;
            VmessItem vmessItem = V2rayConfigHandler.ImportFromClipboardConfig(out msg);
            if (vmessItem == null)
            {
                UI.Show(msg);
                return;
            }

            txtAddress.Text = vmessItem.address;
            txtPort.Text = vmessItem.port.ToString();
            txtId.Text = vmessItem.id;
            txtAlterId.Text = vmessItem.alterId.ToString();
            txtRemarks.Text = vmessItem.remarks;
            cmbNetwork.Text = vmessItem.network;
            cmbHeaderType.Text = vmessItem.headerType;
            txtRequestHost.Text = vmessItem.requestHost;
            cmbStreamSecurity.Text = vmessItem.streamSecurity;
        }
        #endregion

    }
}
