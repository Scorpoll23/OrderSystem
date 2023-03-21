using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronHelmOrderSystem.Presenters;

namespace IronHelmOrderSystem.Views
{
    public partial class MainMenuUI : Form
    {
        MainMenuPresenter presenter { get; set; }

        public MainMenuUI()
        {
            InitializeComponent();
        }

        public void Register(MainMenuPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void btnNewEnquiry_Click(object sender, EventArgs e)
        {
            presenter.ShowNewEnquiry();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            presenter.ShowOrderList();
        }
        
        private void ClientMenuUI_FormClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Closing app");
            Application.Exit();
        }
    }
}
