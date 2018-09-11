using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDM2019.RoomControl.Class
{
    public class PickingDetail
    {
        //GridViewColumn Header = "ลำดับที่" Width="120" DisplayMemberBinding="{Binding NO}" />
        //<GridViewColumn Header = "รหัสสินค้า" Width="150" DisplayMemberBinding="{Binding ITEM_CODE}" />
        //<GridViewColumn Header = "รายการ" Width="100" DisplayMemberBinding="{Binding ITEM_LABEL}" />
        //<GridViewColumn Header = "ขนาด" Width="70" DisplayMemberBinding="{Binding ITEM_SIZE}" />
        //<GridViewColumn Header = "บรรจุ" Width="100" DisplayMemberBinding="{Binding PACKAGES_IN_BASKET}" />
        //<GridViewColumn Header = "น้ำหนักรวม" Width="100" DisplayMemberBinding="{Binding WEIGHT}" />
        //<GridViewColumn Header = "จำนวนเบิก" Width="70" DisplayMemberBinding="{Binding TAKE_COUNT}" />
        //<GridViewColumn Header = "ตระกร้าเต็ม" Width="70" DisplayMemberBinding="{Binding FULL_FILLS}" />
        //<GridViewColumn Header = "เศษ" Width="100" DisplayMemberBinding="{Binding RESIDUAL}" />
        //<GridViewColumn Header = "จัดตะกร้าเต็ม" Width="100" DisplayMemberBinding="{Binding FULL_FILL_PICKS}" />
        //<GridViewColumn Header = "จัดตะกร้าเศษ" Width="100" DisplayMemberBinding="{Binding RESIDUAL_PICKS}" />
        //<GridViewColumn Header = "Progress" Width="100">
        //    <GridViewColumn.CellTemplate>
        //        <DataTemplate>
        //            <ProgressBar Width = "180" Height="20" Margin="0" Minimum="0" Maximum="100" Foreground="Red" Value="{Binding PICK_PERCENTS}"/>
        //        </DataTemplate>
        //    </GridViewColumn.CellTemplate>
        //</GridViewColumn>
        //<GridViewColumn Header = "%" Width="30" DisplayMemberBinding="{Binding PICK_PERCENTS}" />
        //<GridViewColumn Header = "Date-time" Width="100" DisplayMemberBinding="{Binding LAST_ACTIVITY_DATETIME}" />
        //<GridViewColumn Header = "Activity" Width="200" DisplayMemberBinding="{Binding LAST_ACTIVITY}" />

        public int NO { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_LABEL { get; set; }
        public int ITEM_SIZE { get; set; }
        public int PACKAGES_IN_BASKET { get; set; }
        public decimal WEIGHT { get; set; }
        public int TAKE_COUNT { get; set; }
        public int FULL_FILLS { get; set; }
        public int RESIDUAL { get; set; }
        public int FULL_FILL_PICKS { get; set; }
        public int RESIDUAL_PICKS { get; set; }
        public int PICK_PERCENTS { get; set; }
        public DateTime? LAST_ACTIVITY_DATETIME { get; set; }
        public string LAST_ACTIVITY { get; set; }

        public PickingDetail(int no, string code, string label, int size, int packagesInBasket, decimal weight, int take, int pickFull, int pickResidual, DateTime? actDateTime, string activity)
        {
            this.NO = no;
            this.ITEM_CODE = code;
            this.ITEM_LABEL = label;
            this.ITEM_SIZE = size;
            this.PACKAGES_IN_BASKET = packagesInBasket;
            this.WEIGHT = weight;
            this.TAKE_COUNT = take;
            this.FULL_FILL_PICKS = pickFull;
            this.RESIDUAL_PICKS = pickResidual;
            this.LAST_ACTIVITY_DATETIME = actDateTime;
            this.LAST_ACTIVITY = activity;

            this.RESIDUAL = (int)((double)take % (double)packagesInBasket);
            this.FULL_FILLS = (int)((double)(take - this.RESIDUAL) / (double)packagesInBasket);
            this.PICK_PERCENTS = (int)(((double)this.FULL_FILL_PICKS * (double)this.PACKAGES_IN_BASKET + (double)this.RESIDUAL_PICKS) / (double)this.TAKE_COUNT * 100);
        }

    }
}
