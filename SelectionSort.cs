using AlgorithmsHW.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgorithmsHW
{
    public partial class SelectionSort : Form
    {
        public MyLList stackList = new MyLList();
        public int stackCount = 0;
        public string messageString = "";
        public SelectionSort()
        {
            InitializeComponent();
            Show();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int newNumber;
            if (!int.TryParse(txtNewNumber.Text, out newNumber))
            {
                MessageBox.Show("Please enter only numeric values.", "Error!");
                return;
            }

            MyLList.Node node = new MyLList.Node(newNumber);
            toTheStack(node);
            lblStack.Text = lblStack.Text + " " + newNumber;
            txtNewNumber.Clear();
        }
        public void toTheStack(MyLList.Node node)
        {
            if (stackList.First == null)
            {
                stackList.First = node;
                stackList.Last = node;
                stackCount++;
            }
            else
            {
                stackList.Last.Next = node;
                node.Previous = stackList.Last;
                stackList.Last = node;
                stackCount++;
            }
        }
        public void printList(int[] a, int N)
        {
            lblSortedNumbers.Text = "Sorted numbers are: ";
            for (int i = 0; i < N; i++)
            {
                lblSortedNumbers.Text = lblSortedNumbers.Text + a[i] + " ";
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] selSort = new int[stackCount];
            int i = 0, j, k, minVal, temp;
            MyLList.Node node = stackList.Last; // First in last out. Our last node is our Top of Stack. So we start from the end and go back.
            while (node != null)
            {
                selSort[i] = node.Data;
                for (j = 0; j < i; j++)
                {
                    minVal = j;
                    for (k = j + 1; k <= i; k++)
                    {
                        if (selSort[k] < selSort[j])
                            minVal = k;
                    }
                    temp = selSort[minVal];
                    selSort[minVal] = selSort[j];
                    selSort[j] = temp;
                }
                i++;
                node = node.Previous;
                printList(selSort, i);
                messageString = messageString + i + ". iterative " + lblSortedNumbers.Text + "\n";
            }
            MessageBox.Show(messageString, "Result of iterative selection sort");
            messageString = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtNewNumber.Clear();
            lblStack.Text = "Stack (Bottom to Top): ";
            lblSortedNumbers.Text = "Sorted numbers are: ";
            stackList = new MyLList();
            stackCount = 0;
        }

        private void btnRecSort_Click(object sender, EventArgs e)
        {
            int i = 0;
            int[] selSort = new int[stackCount];
            MyLList.Node node = stackList.Last;
            while (node != null)
            {
                selSort[i] = node.Data;
                recSelSort(selSort, i);
                i++;
                node = node.Previous;
                printList(selSort, i);
                messageString = messageString + i + ". iterative " + lblSortedNumbers.Text + "\n";
            }
            MessageBox.Show(messageString, "Result of recursive selection sort");
            messageString = "";
        }

        public void recSelSort(int[] a, int N)
        {
            if (N == 0)
                return;
            int maxVal = N, i, temp;
            /*
             * In iterative form, I knew the total number of elements in the array after popping the stack completely. 
             * To reduce the number of parameters in recursive, I don't go from 0 to total # of elements (which will require another parameter),
             * I go to the opposite direction, from N to 0. (I already take N as parameter and as my stopping condition)
             * So, in conclusion it is still selection sort.
            */
            for (i = N; i >= 0; i--)
            {
                if (a[i] > a[maxVal])
                    maxVal = i;
            }
            temp = a[maxVal];
            a[maxVal] = a[N];
            a[N] = temp;
            recSelSort(a, N - 1);
        }
    }
}
