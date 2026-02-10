using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class ClickerGame : Form
    {
        int coins = 0;
        int upgrade = 5;
        int clickAmount = 1;
        public ClickerGame()
        {
            InitializeComponent();
        }

        private void lblCoinsAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnClickForCash_Click(object sender, EventArgs e)
        {
            coins = coins + clickAmount;

            lblCoinsAmount.Text = string.Format("Coins: {0}", coins);
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (coins == upgrade || coins > upgrade)
            {
                coins = coins - upgrade;
                clickAmount = clickAmount * 2;

                btnClickForCash.Text = string.Format("Coins Per Click: {0}", clickAmount);

                upgrade = upgrade * 3;

                btnUpgrade.Text = string.Format("Upgrade Cost: {0}", upgrade);
                lblCoinsAmount.Text = string.Format("Coins: {0}", coins);
            }
            else
            {

            }
        }
    }
}
