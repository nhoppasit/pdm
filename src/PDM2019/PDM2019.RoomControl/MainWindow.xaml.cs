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
using PDM2019.Office.Class;
using PDM2019.RoomControl.Class;

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

            list.SelectionChanged += List_SelectionChanged;
            mnuDetailRefresh.Click += MnuDetailRefresh_Click;

            DefineSampleData();
        }

        private void MnuDetailRefresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PO_Summary po = (PO_Summary)(this.list.SelectedItem);
                List<PickingDetail> pickings = new List<PickingDetail>();
                Random rnd = new Random();
                for (int i = 0; i < po.PRODUCT_COUNT; i++)
                {
                    PickingDetail pick = new PickingDetail(i + 1, "23058403", "ฟุตลองสไปซี่ (SCB-12)", 445, 20, 16.2m, 36 * (i + 1), rnd.Next(5), rnd.Next(20), DateTime.Now, "นาย ก อ่านบาร์โค้ด");
                    pickings.Add(pick);
                }
                lvDetail.ItemsSource = null;
                lvDetail.ItemsSource = pickings;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                PO_Summary po = (PO_Summary)e.AddedItems[0];
                List<PickingDetail> pickings = new List<PickingDetail>();
                Random rnd = new Random();
                for (int i = 0; i < po.PRODUCT_COUNT; i++)
                {
                    PickingDetail pick = new PickingDetail(i + 1, "23058403", "ฟุตลองสไปซี่ (SCB-12)", 445, 20, 16.2m, 36, rnd.Next(5), rnd.Next(20), DateTime.Now, "นาย ก อ่านบาร์โค้ด");
                    pickings.Add(pick);
                }
                lvDetail.ItemsSource = null;
                lvDetail.ItemsSource = pickings;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DefineSampleData()
        {
            PO_Summary item;
            List<PO_Summary> items = new List<PO_Summary>();

            item = new PO_Summary(lineCode: "NNSS09", poName: "สุวรรณภูมิ ไส้กรอก PO9", productCount: 41, weight: 932, totalTake: 5234, fullFIll: 100, residualBaskets: 30, residual: 800, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ก, ฟุตลองสไปซี่ (SCB-12), 20/36");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS10", poName: "สุวรรณภูมิ ไส้กรอก P10", productCount: 30, weight: 934, totalTake: 2334, fullFIll: 200, residualBaskets: 31, residual: 801, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ข, ฟุตลองสไปซี่ (SCB-12), เสร็จแล้ว");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS11", poName: "สุวรรณภูมิ ไส้กรอก P11", productCount: 33, weight: 935, totalTake: 3434, fullFIll: 300, residualBaskets: 32, residual: 802, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ค, ฟุตลองสไปซี่ (SCB-12), 40/106");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS12", poName: "สุวรรณภูมิ ไส้กรอก P12", productCount: 20, weight: 936, totalTake: 4534, fullFIll: 400, residualBaskets: 33, residual: 804, currentPicks: 1000, lastActDateTime: DateTime.Now, lastActivity: "นาย ง, ฟุตลองสไปซี่ (SCB-12), 60/306");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS13", poName: "สุวรรณภูมิ ไส้กรอก P13", productCount: 40, weight: 937, totalTake: 5634, fullFIll: 500, residualBaskets: 34, residual: 805, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS14", poName: "สุวรรณภูมิ ไส้กรอก P14", productCount: 35, weight: 938, totalTake: 6734, fullFIll: 600, residualBaskets: 35, residual: 806, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS15", poName: "สุวรรณภูมิ ไส้กรอก P15", productCount: 27, weight: 939, totalTake: 7834, fullFIll: 700, residualBaskets: 36, residual: 807, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            items.Add(item);
            item = new PO_Summary(lineCode: "NNSS16", poName: "สุวรรณภูมิ ไส้กรอก P16", productCount: 17, weight: 940, totalTake: 8934, fullFIll: 800, residualBaskets: 37, residual: 808, currentPicks: 1000, lastActDateTime: null, lastActivity: "");
            items.Add(item);

            list.ItemsSource = items;

        }




    }
}
