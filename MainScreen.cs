using System;
using System.Windows.Forms;

namespace AlgorithmsHW
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            new BubbleSort();
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            new SelectionSort();
        }

        private void btnKmpAlg_Click(object sender, EventArgs e)
        {
            new KMPAlgorithm();
        }

        private void btnLinkedRecSearch_Click(object sender, EventArgs e)
        {
            new LinkedSearch();
        }

        private void btnTSP_Click(object sender, EventArgs e)
        {
            new TSP();
        }

        private void btnKSP_Click(object sender, EventArgs e)
        {
            new KSP();
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            new Bonus();
        }
    }
}
