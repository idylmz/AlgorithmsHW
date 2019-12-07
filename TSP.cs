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
    public partial class TSP : Form
    {
        public List<string> cityList = new List<string>();
        public List<string> messageList = new List<string>();
        public int[,] distanceList;
        public int cityCount = 0;
        CityString BestRoute = new CityString("", 0);
        public TSP()
        {
            InitializeComponent();
            Show();
        }
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            cityList.Add(txtNewCity.Text.Trim());
            lsCityBox.Items.Add(txtNewCity.Text);
            cityCount++;
            txtNewCity.Clear();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            dgvDistanceList.ColumnCount = cityCount;
            dgvDistanceList.RowCount = cityCount;
            for (int i = 0; i < cityCount; i++)
            {
                dgvDistanceList.Columns[i].Name = cityList[i];
                dgvDistanceList.Rows[i].HeaderCell.Value = cityList[i];
            }
            distanceList = new int[cityCount, cityCount];
        }

        private void dgvDistanceList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                if ((e.RowIndex != e.ColumnIndex) && (dgvDistanceList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null))
                {
                    if (int.TryParse(dgvDistanceList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int cellValue))
                    {
                        distanceList[e.RowIndex, e.ColumnIndex] = cellValue;
                    }
                    else
                    {
                        MessageBox.Show("Please enter only numeric values", "Error on conversion");
                        dgvDistanceList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    }
                }
                else if (e.RowIndex == e.ColumnIndex)
                {
                    MessageBox.Show("You cannot travel to a city which you are already in.", "Travel Error");
                    dgvDistanceList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
                else
                {
                    return;
                }
            }
        }
        public string messageBox = "";
        private void btnTravel_Click(object sender, EventArgs e)
        { // I will assume that the user inputted everything correctly. I won't be bothering with controls anymore.
            //Because it took my nearly 10 hours just for this singular form while it took another 10 for the rest.
            //After all this is homework just to show algorithm, I'm not selling a program to a company.
            //Sooo, the table must be filled correctly before this point.
            //If the table is not filled properly, well, just re-run the program. I don't know what will happen at that point.
            //I didn't want to put the whole methods into a try-catch block either. 
            //So please, don't use the program harsly.
            string[] cityCompleteList = new string[cityCount];
            int i = 0;
            int[] distanceList = new int[cityCount + 1];
            messageBox = "";
            foreach (string item in cityList)
            {
                cityCompleteList[i] = item;
                distanceList[i] = i;
                i++;
                messageBox = messageBox + item + " ";
            }
            i = calculateDistance(distanceList);
            messageList.Add("The whole solutions are as following: ");
            messageList.Add("");
            messageList.Add(messageBox + cityCompleteList[0] + " ");
            messageList.Add("Total Distance is => " + i);
            messageList.Add("");
            BestRoute.Distance = i;
            BestRoute.RouteList = messageBox;
            messageBox = "";
            TravelAll(cityCompleteList, 0);
            new TravelResult(messageList, BestRoute);
        }
        void swapCities(string[] arr, int i, int j)
        {
            string temp;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        void TravelAll(string[] arr, int start)
        {
            if (start == cityCount)
            {
                return;
            }
            TravelAll(arr, start + 1);
            for (int i = start + 1; i < cityCount; i++)
            {
                if (arr[start] == arr[i])
                    continue;
                swapCities(arr, start, i);
                int[] distanceTotal = new int[cityCount + 1];
                int j = 0;
                foreach (string item in arr)
                {
                    distanceTotal[j] = cityList.IndexOf(item);
                    messageBox = messageBox + item + " ";
                    j++;
                }
                j = calculateDistance(distanceTotal);
                messageList.Add(messageBox + arr[0] + " ");
                messageList.Add("Total Distance is => " + j);
                messageList.Add("");
                if (j < BestRoute.Distance)
                {
                    BestRoute.Distance = j;
                    BestRoute.RouteList = messageBox + arr[0];  
                }
                messageBox = "";
                TravelAll(arr, start + 1);
                swapCities(arr, start, i);
            }
        }
        public int calculateDistance(int[] arr)
        {
            int totalDistance = 0;
            for (int i = 0; i < cityCount; i++)
            {
                if (i + 1 == cityCount)
                {
                    totalDistance += distanceList[arr[i], arr[0]];
                }
                else
                    totalDistance += distanceList[arr[i], arr[i + 1]];
            }
            return totalDistance;
        }
    }
}