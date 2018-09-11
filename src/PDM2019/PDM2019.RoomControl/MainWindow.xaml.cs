using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Ribbon;

namespace PDM2019.RoomControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DefineSampleData()
        {
            //PO_Summary item;
            //List<PO_Summary> items = new List<PO_Summary>();

            //item = new PO_Summary(lineCode: "NNSS09", poName: "สุวรรณภูมิ ไส้กรอก PO9", productCount: 41, weight: 932, totalTake: 5234, fullFIll: 100, residualBaskets: 30, residual: 800, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ก, ฟุตลองสไปซี่ (SCB-12), 20/36");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(18.796143, 98.979263), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS10", poName: "สุวรรณภูมิ ไส้กรอก P10", productCount: 41, weight: 934, totalTake: 2334, fullFIll: 200, residualBaskets: 31, residual: 801, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ข, ฟุตลองสไปซี่ (SCB-12), เสร็จแล้ว");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(13.69269, 100.750465), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS11", poName: "สุวรรณภูมิ ไส้กรอก P11", productCount: 41, weight: 935, totalTake: 3434, fullFIll: 300, residualBaskets: 32, residual: 802, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ค, ฟุตลองสไปซี่ (SCB-12), 40/106");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(9.14011, 99.33311), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS12", poName: "สุวรรณภูมิ ไส้กรอก P12", productCount: 41, weight: 936, totalTake: 4534, fullFIll: 400, residualBaskets: 33, residual: 804, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ง, ฟุตลองสไปซี่ (SCB-12), 60/306");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(7.900544, 98.985268), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS13", poName: "สุวรรณภูมิ ไส้กรอก P13", productCount: 41, weight: 937, totalTake: 5634, fullFIll: 500, residualBaskets: 34, residual: 805, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(13.03887, 101.490104), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS14", poName: "สุวรรณภูมิ ไส้กรอก P14", productCount: 41, weight: 938, totalTake: 6734, fullFIll: 600, residualBaskets: 35, residual: 806, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(13.922104600, 101.577931500), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS15", poName: "สุวรรณภูมิ ไส้กรอก P15", productCount: 41, weight: 939, totalTake: 7834, fullFIll: 700, residualBaskets: 36, residual: 807, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(10.72167, 99.26259), Colors.Green);
            //item = new PO_Summary(lineCode: "NNSS16", poName: "สุวรรณภูมิ ไส้กรอก P16", productCount: 41, weight: 940, totalTake: 8934, fullFIll: 800, residualBaskets: 37, residual: 808, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            //items.Add(item);
            //PlaceProgressBar(MyMap, item.PICK_PERCENTS, new Location(12.671163982, 101.273998904), Colors.Green);

            //list.ItemsSource = items;

            //Location textLocation = MyMap.Center;
            //string text = "70%";
            //PlaceText(MyMap, text, textLocation, Colors.Yellow, 16.0);
        }
    }
}
