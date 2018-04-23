using System.Collections.Generic;
using System.Windows.Controls;

namespace DXGridDescendant {
    public partial class MainPage : UserControl {
        List<ContactItem> coll;
        public MainPage() {
            InitializeComponent();
            coll = new List<ContactItem>();

            ContactItem f1 = new ContactItem();
            f1.Name = "A";
            f1.Salary = 200;
            coll.Add(f1);
            ContactItem f2 = new ContactItem();
            f2.Name = "B";
            f2.Salary = 100;
            coll.Add(f2);

            gridControl1.ItemsSource = coll;
        }
    }
}
