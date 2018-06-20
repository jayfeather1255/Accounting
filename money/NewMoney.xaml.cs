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

namespace money
{
    /// <summary>
    /// NewMoney.xaml 的互動邏輯
    /// </summary>
    public partial class NewMoney : UserControl
    {        

        /*// 封裝屬性：日期
        public string Days
        {
            get
            {
                return Day.Text;
            }
        }*/

        // 封裝屬性：購買物品文字
        public string BuyThings
        {
            get
            {
                return BuyText.Text;
            }
        }

        /* // 封裝屬性：金額
        public int Money
        {
            get
            {
                int SpendMoney = int.Parse(Spend.Text);
                return SpendMoney;
            }
            
        }*/
        
        public NewMoney()
        {
            InitializeComponent();
        }             
    }
}
