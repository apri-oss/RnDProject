using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using RnDProject.Models;
using RnDProject.Views;
using RnDProject.Presenters;

namespace RnDProject.Pages
{
    public partial class PagePost : UserControl, PostLoginView
    {
        public PagePost()
        {
            InitializeComponent();

        }

        public string UsernameText
        {
            get
            {
                return textUsername.Text;
            }
            set
            {
                textUsername.Text = value;
            }
        }
        public string PasswordText
        {
            get
            {
                return textPassword.Text;
            }
            set
            {
                textPassword.Text = value;
            }
        }
        public string UserDataText
        {
            get
            {
                return lbUserData.Text;
            }
            set
            {
                lbUserData.Text = value;

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            PostLoginPresenters presenter = new PostLoginPresenters(this);
            presenter.UserData();

        }
    }
}
