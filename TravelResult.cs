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
    public partial class TravelResult : Form
    {
        public TravelResult(List<string> messageList, CityString best)
        {
            InitializeComponent();
            Show();
            lstTravelResult.Items.Add("The best route according to the distance is:");
            lstTravelResult.Items.Add(best.RouteList);
            lstTravelResult.Items.Add("Total Distance is => " + best.Distance);
            lstTravelResult.Items.Add("");
            foreach (string item in messageList)
            {
                lstTravelResult.Items.Add(item);
            }
        }
    }
}
