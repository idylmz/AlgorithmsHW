using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgorithmsHW
{
    public partial class KMPAlgorithm : Form
    {
        public KMPAlgorithm()
        {
            InitializeComponent();
            Show();
        }

        private void btnFindKey_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result: ";
            txtDisabledResult.Clear();
            string wholeString = txtWholeString.Text;
            int wholeStringLength = txtWholeString.Text.Length;
            string key = txtSearchKey.Text;
            int keyLength = txtSearchKey.Text.Length;
            List<int> occuranceIndex = new List<int>();
            int i, j;

            for (i = 0; i <= wholeStringLength-keyLength; i++)
            {
                if (wholeString[i] == key[0]) //if some index in the string matches with the first element of our key
                {
                    for (j = 0; j < keyLength; j++)
                    {
                        if (wholeString[i + j] != key[j])
                            break; //If it is a miss, we exit from the loop and continue our search
                        else if (j == keyLength - 1 && wholeString[i + j] == key[j])
                            occuranceIndex.Add(i); //We save the index.
                    }
                }
            }
            if (occuranceIndex == null)
                lblResult.Text = lblResult.Text + " Sorry but there is no occurance.";
            else
                lblResult.Text = lblResult.Text + " There have been " + occuranceIndex.Count + " occurances.";
            foreach(int item in occuranceIndex)
            {
                txtDisabledResult.Text = txtDisabledResult.Text + " " + item + " ";
            }
        }
    }
}
