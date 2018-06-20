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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            

            int Total = 0;

            foreach (NewMoney item in MoneyList.Children)
            {
                /*Total += local:NewMoeny.Spend;*/
            }

            string TotalMoney = Total.ToString();
        }

        private void NewBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
                        
            // 產生新的記帳格子
            NewMoney item = new NewMoney();

            // 放到List
            MoneyList.Children.Add(item);

        }
             

        private void Window_Closed(object sender, EventArgs e)
        {
            
            // 新增一個陣列裝每個項目轉成的文字
            List<string> datas = new List<string>();            
            
            // 轉換每一個項目
           
        }
    }
}
