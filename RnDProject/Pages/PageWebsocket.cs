using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RnDProject.Views;
using RnDProject.Models;
using RnDProject.Presenters;

namespace RnDProject.Pages
{
    public partial class PageWebsocket : UserControl, WebsocketView
    {
        public PageWebsocket()
        {
            InitializeComponent();
        }

        public string DataWebsocketText
        {
            get
            {
                return lblDataWebsocket.Text;
            }
            set
            {
                this.lblDataWebsocket.Invoke((MethodInvoker)(() => lblDataWebsocket.Text = value));

            }
        }

        private void btn_try_websocket_Click(object sender, EventArgs e)
        {
            WebsocketPresenters presenter = new WebsocketPresenters(this);
            presenter.ConnectToSocket();
        }
    }
}
