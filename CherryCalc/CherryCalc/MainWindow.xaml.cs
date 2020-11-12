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

namespace CherryCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CherryModel cherryModel = new CherryModel();

        public MainWindow()
        {
            InitializeComponent();
            InitialButtons();
        }

        public void InitialButtons()
        {
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                cherryModel._numericalBtns.Add(button);
            }
            
            
        }
    }

    public class CherryModel
    {
       public static List<Button> _numericalBtns = new List<Button>();
    }
}
