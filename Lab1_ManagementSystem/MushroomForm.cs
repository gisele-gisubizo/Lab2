using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_ManagementSystem
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbForest.SelectedIndex = -1;
            cmbConvex.SelectedIndex = -1;
            cmbRing.SelectedIndex = -1;
            cmbGills.SelectedIndex = -1;

            lblRing.Visible = false;
            cmbRing.Visible = false;

            lblGills.Visible = false;
            cmbGills.Visible = false;
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            // Check the first two answers
            if (cmbForest.SelectedIndex == -1 ||
                cmbConvex.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please answer the first two questions.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string forest = cmbForest.SelectedItem.ToString();
            string convex = cmbConvex.SelectedItem.ToString();

            // MUSHROOMS THAT DO NOT GROW IN A FOREST
            if (forest == "No")
            {
                if (convex == "Yes")
                {
                    MessageBox.Show(
                        "The identified mushroom is: Agaric Jaunissant",
                        "Mushroom Identification");
                }
                else
                {
                    MessageBox.Show(
                        "The identified mushroom is: Coprin Chevelu",
                        "Mushroom Identification");
                }

                return;
            }

            // MUSHROOMS IN A FOREST WITH A CONVEX CUP
            if (convex == "Yes")
            {
                lblRing.Visible = true;
                cmbRing.Visible = true;

                if (cmbRing.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please answer: Does the mushroom have a ring?",
                        "Question Required");

                    return;
                }

                string ring = cmbRing.SelectedItem.ToString();

                if (ring == "Yes")
                {
                    MessageBox.Show(
                        "The identified mushroom is: Amanite tue-mouches",
                        "Mushroom Identification");
                }
                else
                {
                    MessageBox.Show(
                        "The identified mushroom is: Pied bleu",
                        "Mushroom Identification");
                }
            }

            // MUSHROOMS IN A FOREST WITHOUT A CONVEX CUP
            else
            {
                lblGills.Visible = true;
                cmbGills.Visible = true;

                if (cmbGills.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Please answer: Does the mushroom have gills?",
                        "Question Required");

                    return;
                }

                string gills = cmbGills.SelectedItem.ToString();

                if (gills == "Yes")
                {
                    MessageBox.Show(
                        "The identified mushroom is: Girolle",
                        "Mushroom Identification");
                }
                else
                {
                    MessageBox.Show(
                        "The identified mushroom is: Cepe de Bordeaux",
                        "Mushroom Identification");
                }
            }
        }

        private void MushroomForm_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            cmbForest.SelectedIndex = -1;
            cmbConvex.SelectedIndex = -1;
            cmbRing.SelectedIndex = -1;
            cmbGills.SelectedIndex = -1;

            lblRing.Visible = false;
            cmbRing.Visible = false;

            lblGills.Visible = false;
            cmbGills.Visible = false;
        }
    }
}
