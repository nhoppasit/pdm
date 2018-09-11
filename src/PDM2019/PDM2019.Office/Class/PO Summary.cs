using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDM2019.Office.Class
{
    public class PO_Summary
    {

        //<GridViewColumn Header = "Line code" Width="120" DisplayMemberBinding="{Binding LINE_CODE}" />
        //                        <GridViewColumn Header = "PO" Width="150" DisplayMemberBinding="{Binding PO_NAME}" />
        //                        <GridViewColumn Header = "Product Count" Width="100" DisplayMemberBinding="{Binding PRODUCT_COUNT}" />
        //                        <GridViewColumn Header = "Weight" Width="70" DisplayMemberBinding="{Binding WEIGHT}" />
        //                        <GridViewColumn Header = "Total Take" Width="100" DisplayMemberBinding="{Binding TOTAL_TAKE}" />
        //                        <GridViewColumn Header = "Full Fill" Width="100" DisplayMemberBinding="{Binding FULL_FILL}" />
        //                        <GridViewColumn Header = "Residual" Width="70" DisplayMemberBinding="{Binding RESIDUAL}" />
        //                        <GridViewColumn Header = "Current Pick" Width="100" DisplayMemberBinding="{Binding CURRENT_PICK}" />
        //                        <GridViewColumn Header = "Progress" Width="100">
        //                            <GridViewColumn.CellTemplate>
        //                                <DataTemplate>
        //                                    <ProgressBar Maximum = "100" Value="{Binding PICK_PERCENTS}"/>
        //                                </DataTemplate>
        //                            </GridViewColumn.CellTemplate>
        //                        </GridViewColumn>
        //                        <GridViewColumn Header = "Pick Percents" Width="100" DisplayMemberBinding="{Binding PICK_PERCENTS}" />
        //                    </GridView>
        public PO_Summary(string lineCode, string poName, int productCount, decimal weight, int totalTake, int fullFIll, int residualBaskets, int residual, int currentPicks, DateTime? lastActDateTime, string lastActivity)
        {
            this.LINE_CODE = lineCode;
            this.PO_NAME = poName;
            this.PRODUCT_COUNT = productCount;
            this.WEIGHT = weight;
            this.TOTAL_TAKES = totalTake;
            this.FULL_FILLS = fullFIll;
            this.RESIDUAL_BASKETS = residualBaskets;
            this.RESIDUAL = residual;
            this.CURRENT_PICKS = currentPicks;
            this.LAST_ACTIVITY_DATETIME = lastActDateTime;
            this.LAST_ACTIVITY = lastActivity;

            this.BASKETS = this.FULL_FILLS + this.RESIDUAL_BASKETS;
            try { this.PICK_PERCENTS = (int)((double)this.CURRENT_PICKS / (double)(this.TOTAL_TAKES) * 100); } catch { }
        }

        public string LINE_CODE { get; set; }
        public string PO_NAME { get; set; }
        public int PRODUCT_COUNT { get; set; }
        public decimal WEIGHT { get; set; }
        public int TOTAL_TAKES { get; set; }
        public int FULL_FILLS { get; set; }
        public int RESIDUAL_BASKETS { get; set; }
        public int RESIDUAL { get; set; }
        public int BASKETS { get; private set; }
        public int CURRENT_PICKS { get; set; }
        public int PICK_PERCENTS { get; set; }
        public string LAST_ACTIVITY { get; set; }
        public DateTime? LAST_ACTIVITY_DATETIME { get; set; }
    }
}
