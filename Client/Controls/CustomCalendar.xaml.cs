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

namespace Client.Controls
{
    /// <summary>
    /// Interaction logic for Calendar.xaml
    /// </summary>
    public partial class CustomCalendar : UserControl
    {
        public CustomCalendar()
        {
            InitializeComponent();
        }

        private DateTime CurrentDateTime;

        private void Set()
        {
            int year, month, day;
            Int32.TryParse(this.YearCtrl.Text, out year);
            Int32.TryParse(this.MonthCtrl.Text, out month);
            Int32.TryParse(this.DateCtrl.Text, out day);
            this.CurrentDateTime = new DateTime(year, month, day);
        }
    }
}
