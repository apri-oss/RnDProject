using RnDProject.Pages;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RnDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_websocket_Click(object sender, EventArgs e)
        {
            PageWebsocket pageWebscoket = new PageWebsocket();
            addUserControl(pageWebscoket);

        }

        private void btn_menu_post_Click(object sender, EventArgs e)
        {
            PagePost pageLogin = new PagePost();
            addUserControl(pageLogin);
        }

        private void btn_menu_home_Click(object sender, EventArgs e)
        {
            PageHome pageHome = new PageHome();
            addUserControl(pageHome);

        }

        private void btn_menu_get_Click(object sender, EventArgs e)
        {
            PageGet pageGet = new PageGet();
            addUserControl(pageGet);

        }
    }
}