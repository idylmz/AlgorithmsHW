using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmsHW.Models;

namespace AlgorithmsHW
{
    public partial class KSP : Form
    {
        public List<Items> itemList = new List<Items>();
        public KSP()
        {
            InitializeComponent();
            Show();
            dgvResult.ColumnCount = 3;
            dgvResult.Columns[0].Name = "Item Name";
            dgvResult.Columns[1].Name = "Weight";
            dgvResult.Columns[2].Name = "Value";
            dgvItemList.ColumnCount = 3;
            dgvItemList.Columns[0].Name = "Item Name";
            dgvItemList.Columns[1].Name = "Weight";
            dgvItemList.Columns[2].Name = "Value";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtValue.Text, out float Value) || !float.TryParse(txtWeight.Text, out float Weight))
            {
                MessageBox.Show("Please make sure that Value and Weight cells include only numeric characters", "Parsing Error");
                return;
            }
            string Name = txtItemName.Text;
            Items newItem = new Items(Name, Weight, Value);
            itemList.Add(newItem);
            dgvResult.Rows.Add(Name, Weight, Value);
        }
        public void KnapsackBasket(int capacity) // Greedy
        {
            float Weight = 0;
            string basketList = "";
            foreach (Items node in itemList.OrderBy(a => a.Ratio))
            {
                if ((node.Weight + Weight <= capacity) && (node.Weight <= capacity) && (node.Value <= itemList.Count * itemList.Count))
                {
                    Weight += node.Weight;
                    dgvItemList.Rows.Add(node.ItemName, node.Weight, node.Value);
                    basketList = basketList + node.ItemName + "\n";
                }
            }
            MessageBox.Show("The best solution is: " + basketList, "Best Solution");
        }
        public void RecKnapsack(int capacity, float totalValue, float basketWeight, int i, string knapsackString)//Brute Force
        {
            if ((i < 0) || (basketWeight > capacity)) // Unless I do not have an item at index i, then I return.
            {
                MessageBox.Show("A solution is: " + knapsackString + "\nThe total weight is: " + basketWeight + "\nThe total value is: " + totalValue , "Solution Found!");
                return;
            }
            if ((itemList[i].Weight <= capacity) && (itemList[i].Value <= itemList.Count * itemList.Count))
            {
                RecKnapsack(capacity, totalValue + itemList[i].Value, basketWeight + itemList[i].Weight, i - 1, knapsackString + itemList[i].ItemName + "\n");
                // I am taking this item and moving to the next one.
                RecKnapsack(capacity, totalValue, basketWeight, i - 1, knapsackString); // I am moving onto the next item without having this item.
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCapacity.Text, out int Capacity))
            {
                MessageBox.Show("Please make sure that capacity cell includes only numeric characters.", "Parsing Error");
                return;
            }
            else if ((Capacity > (itemList.Count * itemList.Count)) || (Capacity < 1))
            {

                MessageBox.Show("Please make sure that capacity is within the range of 1 < C < N^2", "Capacity Error");
                return;
            }
            KnapsackBasket(Capacity); //Greedy

        }

        private void btnBruteCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCapacity.Text, out int Capacity))
            {
                MessageBox.Show("Please make sure that capacity cell includes only numeric characters.", "Parsing Error");
                return;
            }
            else if ((Capacity > (itemList.Count * itemList.Count)) || (Capacity < 1))
            {

                MessageBox.Show("Please make sure that capacity is within the range of 1 < C < N^2", "Capacity Error");
                return;
            }
            string recKnapsackSolution = "";
            RecKnapsack(Capacity, 0, 0, itemList.Count-1, recKnapsackSolution);
        }
    }
}
