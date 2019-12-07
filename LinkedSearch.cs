using AlgorithmsHW.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsHW
{
    public partial class LinkedSearch : Form
    {
        public MyLList someList = new MyLList();
        public string dividedSpecs = "";
        public LinkedSearch()
        {
            InitializeComponent();
            Show();
        }
        public void divideThemAll()
        {
            MyLList.Node node = someList.First;
            while (node!=null)
            {
                dividedSpecs = dividedSpecs + "Exact dividers of " + node.Data + " are: ";
                for (int i = 1; i <= node.Data; i++)
                {
                    if (node.Data % i == 0)
                        dividedSpecs = dividedSpecs + i + " ";
                }
                dividedSpecs = dividedSpecs + "\n";
                node = node.Next;
            }
            MessageBox.Show(dividedSpecs, "Result of linear search");
        }
        public void insertion(MyLList.Node node)
        {
            if (someList.First != null)
            {
                someList.Last.Next = node;
                node.Previous = someList.Last;
                node.Next = null;
                someList.Last = node;
            }
            else
            {
                someList.First = node;
                someList.Last = node;
                someList.First.Previous = null; //Just to make sure that no one is connected after or before my first and last nodes.
                someList.Last.Next = null;
            }
        }
        public void recLinearSearch(MyLList.Node node, int key)
        {
            if (node == null)
            {
                dividedSpecs = "Sorry but the key you're looking for is not in the list. \n";
                MessageBox.Show(dividedSpecs, "Search result");
            }
            else
            {
                if (node.Data == key)
                {
                    dividedSpecs= "Conguratulations! This key is in the list!\n";
                    divideThemAll();
                    return;
                }
                else
                    recLinearSearch(node.Next, key);
            }
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int newNumber;
            if(!int.TryParse(txtNewNumber.Text, out newNumber))
            {
                MessageBox.Show("Please make sure that you have entered numeric value!", "Error on conversion");
                return;
            }

            MyLList.Node node = new MyLList.Node(newNumber);
            insertion(node);
            lblNumberList.Text = lblNumberList.Text + " " + newNumber;
            txtNewNumber.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(txtKey.Text, out key))
            {
                MessageBox.Show("Please make sure that you have entered numeric value!", "Error on conversion");
                return;
            }
            recLinearSearch(someList.First, key);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            someList = new MyLList();
            txtKey.Clear();
            txtNewNumber.Clear();
            lblNumberList.Text = "Numbers added: ";
        }
    }
}