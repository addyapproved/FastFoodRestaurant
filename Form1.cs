using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form

    {
        const double Price_BottleWater = 1.9;
        const double Price_Fries = 2.3;
        const double Price_CheeseSandwich = 2.1;
        const double Price_ChickenSalad = 3.8;
        const double Price_ChickenSandwich = 4.8;
        const double Price_ChocolateMilkShake = 2.3;
        const double Price_ChocolateMuffiin = 2.3;
        const double Price_Coffee = 1.5;
        const double Price_Cola = 1.3;
        const double Price_FishSandwich = 2.9;
        const double Price_Hamburger = 2.5;
        const double Price_HashBrown = 1.0;
        const double Price_OnionRings = 3.5;
        const double Price_Orange = 1.2;
        const double Price_PancakesSyrup = 1.2;
        const double Price_PinneappleStick = 1.6;
        const double Price_Salad = 1.2;
        const double Price_Tea = 1.1;
        const double Price_ToastedBagel = 1.3;
        const double Price_VanillaCone = 1.7;
        const double Price_VanillaShake = 1.5;

        const double Tax_Rate = 3.9;
        double iTax, iSubTotal, iTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit The System", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes )
            {
                Application.Exit();
            }

        }
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";

                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;

                    else
                        func(control.Controls);
            };
            func(Controls);

     
        }
        //EnableTextBoxes
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;

                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.Items.Add(" ");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Master Card");
            cmbPaymentMethod.Items.Add(" Visa Card");
            cmbPaymentMethod.Items.Add("Debit Card");

            EnableTextBoxes();

        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked == true)

            {

                txtFries.Enabled = true;
                txtFries.Text = "";
                txtFries.Focus();
            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalad.Checked == true)

            {

                txtSalad.Enabled = true;
                txtSalad.Text = "";
                txtSalad.Focus();
            }
            else
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void chkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHamburger.Checked == true)

            {

                txtHamburger.Enabled = true;
                txtHamburger.Text = "";
                txtHamburger.Focus();
            }
            else
            {
                txtHamburger.Enabled = false;
                txtHamburger.Text = "0";
            }
        }

        private void chkOnionRings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnionRings.Checked == true)

            {

                txtOnionRings.Enabled = true;
                txtOnionRings.Text = "";
                txtOnionRings.Focus();
            }
            else
            {
                txtOnionRings.Enabled = false;
                txtOnionRings.Text = "0";
            }
        }

        private void chkChickenSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenSalad.Checked == true)

            {

                txtChickenSalad.Enabled = true;
                txtChickenSalad.Text = "";
                txtChickenSalad.Focus();
            }
            else
            {
                txtChickenSalad.Enabled = false;
                txtChickenSalad.Text = "0";
            }
        }

        private void chkFishSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFishSandwich.Checked == true)

            {

                txtFishSandwich.Enabled = true;
                txtFishSandwich.Text = "";
                txtFishSandwich.Focus();
            }
            else
            {
                txtFishSandwich.Enabled = false;
                txtFishSandwich.Text = "0";
            }
        }

        private void chkCheeseSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseSandwich.Checked == true)

            {

                txtCheeseSandwich.Enabled = true;
                txtCheeseSandwich.Text = "";
                txtCheeseSandwich.Focus();
            }
            else
            {
                txtCheeseSandwich.Enabled = false;
                txtCheeseSandwich.Text = "0";
            }
        }

        private void chkChickenSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenSandwich.Checked == true)

            {

                txtChickenSandwich.Enabled = true;
                txtChickenSandwich.Text = "";
                txtChickenSandwich.Focus();
            }
            else
            {
                txtChickenSandwich.Enabled = false;
                txtChickenSandwich.Text = "0";
            }
        }

        private void chkHashBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHashBrown.Checked == true)

            {

                txtHashBrown.Enabled = true;
                txtHashBrown.Text = "";
                txtHashBrown.Focus();
            }
            else
            {
                txtHashBrown.Enabled = false;
                txtHashBrown.Text = "0";
            }
        }

        private void chkToastedBagel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToastedBagel.Checked == true)

            {

                txtToastedBagel.Enabled = true;
                txtToastedBagel.Text = "";
                txtToastedBagel.Focus();
            }
            else
            {
                txtToastedBagel.Enabled = false;
                txtToastedBagel.Text = "0";
            }
        }

        private void chkPinneappleStick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPinneappleStick.Checked == true)

            {

                txtPinneappleStick.Enabled = true;
                txtPinneappleStick.Text = "";
                txtPinneappleStick.Focus();
            }
            else
            {
                txtPinneappleStick.Enabled = false;
                txtPinneappleStick.Text = "0";
            }
        }

        private void chkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTea.Checked == true)

            {

                txtTea.Enabled = true;
                txtTea.Text = "";
                txtTea.Focus();
            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked == true)

            {

                txtCola.Enabled = true;
                txtCola.Text = "";
                txtCola.Focus();
            }
            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)

            {

                txtCoffee.Enabled = true;
                txtCoffee.Text = "";
                txtCoffee.Focus();
            }
            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void chkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrange.Checked == true)

            {

                txtOrange.Enabled = true;
                txtOrange.Text = "";
                txtOrange.Focus();
            }
            else
            {
                txtOrange.Enabled = false;
                txtOrange.Text = "0";
            }
        }

        private void chkBottleWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBottleWater.Checked == true)

            {

                txtBottleWater.Enabled = true;
                txtBottleWater.Text = "";
                txtBottleWater.Focus();
            }
            else
            {
                txtBottleWater.Enabled = false;
                txtBottleWater.Text = "0";
            }
        }

        private void chkVanillaCone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVanillaCone.Checked == true)

            {

                txtVanillaCone.Enabled = true;
                txtVanillaCone.Text = "";
                txtVanillaCone.Focus();
            }
            else
            {
                txtVanillaCone.Enabled = false;
                txtVanillaCone.Text = "0";
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.Text == "Cash")

            {
                txtPaymentMethod.Enabled = true;
                txtPaymentMethod.Text = "";
                txtPaymentMethod.Focus();

            }
            else
            {
                txtPaymentMethod.Enabled = false;
                txtPaymentMethod.Text = "0";

                { 
}
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[21];
            itemcost[0] = Convert.ToDouble(txtFries.Text) * Price_Fries;
            itemcost[1] = Convert.ToDouble(txtHamburger.Text) * Price_Hamburger;
            itemcost[2] = Convert.ToDouble(txtOnionRings.Text) * Price_OnionRings;
            itemcost[3] = Convert.ToDouble(txtChickenSalad.Text) * Price_ChickenSalad;
            itemcost[4] = Convert.ToDouble(txtFishSandwich.Text) * Price_FishSandwich;
            itemcost[5] = Convert.ToDouble(txtCheeseSandwich.Text) * Price_CheeseSandwich;
            itemcost[6] = Convert.ToDouble(txtChickenSandwich.Text) * Price_ChickenSandwich;
            itemcost[7] = Convert.ToDouble(txtHashBrown.Text) * Price_HashBrown;
            itemcost[8] = Convert.ToDouble(txtToastedBagel.Text) * Price_ToastedBagel;
            itemcost[9] = Convert.ToDouble(txtPinneappleStick.Text) * Price_PinneappleStick;
            itemcost[10] = Convert.ToDouble(txtChocolateMuffiin.Text) * Price_ChocolateMuffiin;
            itemcost[11] = Convert.ToDouble(txtPancakesSyrup.Text) * Price_PancakesSyrup;
            itemcost[12] = Convert.ToDouble(txtTea.Text) * Price_Tea;
            itemcost[13] = Convert.ToDouble(txtCola.Text) * Price_Cola;
            itemcost[14] = Convert.ToDouble(txtCoffee.Text) * Price_Coffee;
            itemcost[15] = Convert.ToDouble(txtOrange.Text) * Price_Orange;
            itemcost[16] = Convert.ToDouble(txtBottleWater.Text) * Price_BottleWater;
            itemcost[17] = Convert.ToDouble(txtVanillaCone.Text) * Price_VanillaCone;
            itemcost[18] = Convert.ToDouble(txtVanilaShake.Text) * Price_VanillaShake;
            itemcost[19] = Convert.ToDouble(txtCoffee.Text) * Price_Coffee;
            itemcost[20] = Convert.ToDouble(txtChocolateMilkshake.Text) * Price_ChocolateMilkShake;

            double cost, ichange;

            if (cmbPaymentMethod.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] +
                    itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] +
                    itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20];


                txtSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                txtTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);

                ichange = Convert.ToDouble(txtPaymentMethod.Text);
                cost = ichange - (iTax + iTotal);
                lblChange.Text = Convert.ToString(cost);

                lblChange.Text = String.Format("{0:C}", cost);
                lblTax.Text = String.Format("{0:C}", iTax);
                lblSubTotal.Text = String.Format("{0:C}", iSubTotal);
                lblTotal.Text = String.Format("{0:C}", iTotal);
            }
            else

            { 
             iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] +
                    itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] +
                    itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20];


                txtSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                txtTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);

                
                lblTax.Text = String.Format("{0:C}", iTax);
                lblSubTotal.Text = String.Format("{0:C}", iSubTotal);
                lblTotal.Text = String.Format("{0:C}", iTotal);



            }

        }

        private void chkVanillaShake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVanillaShake.Checked == true)

            {

                txtVanilaShake.Enabled = true;
                txtVanilaShake.Text = "";
                txtVanilaShake.Focus();
            }
            else
            {
                txtVanilaShake.Enabled = false;
                txtVanilaShake.Text = "0";
            }
        }

        private void chkChocolateMilkshake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolateMilkshake.Checked == true)

            {

                txtChocolateMilkshake.Enabled = true;
                txtChocolateMilkshake.Text = "";
                txtChocolateMilkshake.Focus();
            }
            else
            {
                txtChocolateMilkshake.Enabled = false;
                txtChocolateMilkshake.Text = "0";
            }
        }
    }

}
