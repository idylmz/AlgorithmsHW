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
    public partial class Bonus : Form
    {
        public BonusLList FirstNode = null;
        public BonusLList LastNode = new BonusLList();
        public Bonus()
        {
            InitializeComponent();
            Show();
        }

        public void insertion(BonusLList node)
        {
            if (FirstNode == null)
            {
                FirstNode = node;
                LastNode = node;
                LastNode.Next = null;
                FirstNode.Next = null;
            }
            else
            {
                LastNode.Next = node;
                LastNode = node;
                LastNode.Next = null;
            }
            txtMultiplier.Clear();
            txtPower.Clear();
            txtBase.Clear();
        }
        public void RecMergeNodes(BonusLList node, BonusLList traveler)
        {
            /*
             * This note is for me in case if my brain stops working during presentation.
             * The reason I am going with traveler.Next is in case if my next node is similar
             * to the other one called "node" and then I have to let it go from the list, 
             * to do so, I need to know my previous node. Because in case of a match, I need to
             * reconnect my previous node to the next one by skipping similar node. I could have done it with *previous
             * property in the BonusLList class and I think it would be easier to code. But I tried to keep props at minimal.
             */
            if ((node.Base == traveler.Next.Base) && (node.Power == traveler.Next.Power))
            {
                node.Multiplier = traveler.Next.Multiplier + node.Multiplier;
                node.CalculatedValue = node.CalculatedValue + traveler.CalculatedValue;
                if (traveler.Next.Next != null)
                {
                    traveler.Next = traveler.Next.Next;
                    RecMergeNodes(node, traveler);
                }
                else if (node.Next.Next != null)
                {
                    traveler.Next = null;
                    RecMergeNodes(node.Next, node.Next);
                }
                else
                    traveler.Next = null;
            }
            else if (traveler.Next.Next != null)
            {
                RecMergeNodes(node, traveler.Next);
            }
            else if (node.Next.Next != null)
            {
                RecMergeNodes(node.Next, node.Next);
            }
            /*
             * It is similar to sorting algorithms. I am just keeping the first node as one parameter. Then starting my traveler node from the first.next
             * I am traveling through the list. Until my last.next is empty. If my last.next is empty than I start constant node from first.next
             * since I have already checked my first node if there are any similar nodes on the list. So it is absolutely true that there is no matching
             * node to the first element. There is no need to check. So I jump onto the first.next then I go and go.
             */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMultiplier.Text, out int multVal) || !int.TryParse(txtBase.Text, out int baseVal) || !int.TryParse(txtPower.Text, out int powVal))
            {
                MessageBox.Show("Please make sure you have entered only numeric values.", "Error on conversion");
                return;
            }
            BonusLList node = new BonusLList(multVal, baseVal, powVal);
            insertion(node);
            lblNodeList.Text = lblNodeList.Text + node.Multiplier + "x" + node.Base + "^" + node.Power + "\n";
        }

        private void btnMinify_Click(object sender, EventArgs e)
        {
            if (FirstNode.Next != null)
            {
                BonusLList TravelerNode = FirstNode;
                RecMergeNodes(TravelerNode, TravelerNode);
            }
            string nodeString = "";
            BonusLList Node = FirstNode;
            while (Node != null)
            {
                nodeString = nodeString + Node.Multiplier + "x" + Node.Base + "^" + Node.Power + "\n";
                Node = Node.Next;
            }
            MessageBox.Show("The list is derived as:\n" + nodeString, "Node List");
        }

        private void btnTotalCalculation_Click(object sender, EventArgs e)
        {
            BonusLList Node = FirstNode;
            int totalValue=0;
            string wholeValues = "";
            while (Node != null)
            {
                totalValue = totalValue + Node.CalculatedValue;
                wholeValues = wholeValues + Node.CalculatedValue + "\n";
                Node = Node.Next;
            }
            MessageBox.Show("The list of numbers are: " + wholeValues + "\n" + "The total value is: " + totalValue, "Total Values");
        }
    }
}
