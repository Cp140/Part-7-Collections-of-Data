using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7__Collections_of_Data
{
    public partial class frm : Form
    {

        //Starts Lists for numbers and heros
        List<int> numbers = new List<int>();
        List<string> heros = new List<string>();
        string herosRemove;
        string herosRemoveUpper;
        //Random Generator
        Random generator = new Random();

        public frm()
        {
            InitializeComponent();

        }


        private void frm_Load(object sender, EventArgs e)
        {
            //Generates inital numbers
            newNumber();

            //Adds SuperMan and BatMan
            heros.Add("SUPERMAN");
            heros.Add("BATMAN");
            RefreshListBoxHero();
        }

        //updates numbers
        public void RefreshListBoxNum()
        {
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
        }
        //generates new numbers
        public void newNumber()
        {
            numbers.Clear();

            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
        }

        //list box heros voids
        public void RefreshListBoxHero()
        {
            lstHeros.DataSource = null;
            lstHeros.DataSource = heros;
        }



        //click events
        private void btnNumbersSort_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Status: Numbers list sorted.");
        }

        private void btnNumbersNewList_Click(object sender, EventArgs e)
        {
            RefreshListBoxNum();
            newNumber();
            lblStatus.Text = ("Status: New list generated.");
        }

        private void btnNumbersRemove_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex >= 0)
            {
                int numLstRemove = 0;
                numLstRemove = lstNumbers.SelectedIndex;
                numbers.RemoveAt(numLstRemove);
                RefreshListBoxNum();
                lblStatus.Text = ("Status: Number Removed");
            }
            else
            {
                lblStatus.Text = ("Status: Error list empty");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            RefreshListBoxNum();
        }










        //Resets program
        private void btnReset_Click(object sender, EventArgs e)
        {
            //clears numbers
            numbers.Clear();
            RefreshListBoxNum();
            //clears heros and adds defaults
            heros.Clear();
            RefreshListBoxHero();
            heros.Add("SuperMan");
            heros.Add("BatMan");




            lblStatus.Text = ("Program reset!!!");
        }

        private void btnHerosAdd_Click(object sender, EventArgs e)
        {
            herosRemove = txtHerosRemove.Text;
            herosRemove = herosRemove.Trim();
            herosRemoveUpper = herosRemove.ToUpper();
            heros.Remove(herosRemoveUpper);
            RefreshListBoxHero();
        }

        private void btnHerosRemove_Click(object sender, EventArgs e)
        {
            if (lstHeros.SelectedIndex >= 0)
            {
                int heroLstRemove = 0;
                heroLstRemove = lstHeros.SelectedIndex;
                heros.RemoveAt(heroLstRemove);
                lblStatus.Text = ($"Status: Hero {herosRemove} removed");
                txtHerosRemove.Text = ("");
                RefreshListBoxHero();
            }
            else
            {
                lblStatus.Text = ("Status: Error list empty");
            }

        }

        private void btnHerosSort_Click(object sender, EventArgs e)
        {

        }
    }
}
