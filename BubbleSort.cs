using AlgorithmsHW.Models;
using System;
using System.Windows.Forms;

namespace AlgorithmsHW
{
    public partial class BubbleSort : Form
    {
        public MyLList listQueue = new MyLList();
        public int listCount = 0;
        public BubbleSort()
        {
            InitializeComponent();
            Show();
        }
        public string messageString = "";
        public void toTheQueue(MyLList.Node node)
        {
            if (listQueue.First == null)
            {
                listQueue.First = node;
                listQueue.Last = node;
                listCount++;
            }
            else
            {
                listQueue.Last.Next = node;
                listQueue.Last = node;
                listCount++;
            }
        }
        public void printList(int[] bubble, int N)
        {
            lblSortedNumbers.Text = "Sorted numbers are: ";
            for (int i = 0; i < N; i++)
            {
                lblSortedNumbers.Text = lblSortedNumbers.Text + " " + bubble[i];
            }
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int newNumber;
            if (!int.TryParse(txtNewNumber.Text, out newNumber))
            {
                MessageBox.Show("Please enter only numeric values");
                return;
            }
            MyLList.Node node = new MyLList.Node(newNumber);
            toTheQueue(node);
            lblNumberList.Text = lblNumberList.Text + " " + newNumber;
            txtNewNumber.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            /*
             In every dequeue, queue count will change. So we
             have to obtain queue count without interfering with
             the last state of the queue.
            */
            MyLList.Node node = listQueue.First;
            int[] bubblySort = new int[listCount];
            int i = 0, j;
            while (node != null) // Loop until node is equal to last.next, which is null.
            {
                bubblySort[i] = node.Data;
                for (j = 0; j < i; j++)// To place last added value to its exact location.
                {
                    if (bubblySort[i] < bubblySort[j])
                    {
                        int temp = bubblySort[i];
                        bubblySort[i] = bubblySort[j];
                        bubblySort[j] = temp;
                    }
                }
                i++;
                node = node.Next;
                printList(bubblySort, i);
                messageString = messageString + i + ". iterative " + lblSortedNumbers.Text + "\n";
            }
            MessageBox.Show(messageString, " Result of iterative bubble sort!");
            messageString = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNewNumber.Clear();
            lblNumberList.Text = "Numbers Added: ";
            lblSortedNumbers.Text = "Sorted numbers are: ";
            listQueue = new MyLList();
            listCount = 0;
            messageString = "";
        }

        public void recBubbleSort(int[] a, int N)
        {
            if (N == 0)
                return;
            if (a[N] < a[N - 1])
            {
                int temp = a[N];
                a[N] = a[N - 1];
                a[N - 1] = temp;
            }
            recBubbleSort(a, N - 1);
        }

        private void btnRecSort_Click(object sender, EventArgs e)
        {
            int[] bubblySort = new int[listCount];
            int i = 0;
            MyLList.Node node=listQueue.First;
            while (node != null)
            {
                bubblySort[i] = node.Data;
                recBubbleSort(bubblySort, i);
                i++;
                node = node.Next;
                printList(bubblySort, i);
                messageString = messageString + i + ". iterative " + lblSortedNumbers.Text + "\n";
            }
            MessageBox.Show(messageString, "Result of recursive bubble sort");
            messageString = "";
        }
    }
}
