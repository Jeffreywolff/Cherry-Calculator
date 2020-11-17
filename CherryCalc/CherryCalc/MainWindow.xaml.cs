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

        Grid Numpad;


        public MainWindow()
        {
            InitializeComponent();
            InitialNumpadButtons();
            SetupNumpad();
        }

        private void SetupNumpad()
        {
            Numpad = new Grid();
            for (int i = 0; i < 5; i++)
            {
                Numpad.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 6; i++)
            {
                Numpad.RowDefinitions.Add(new RowDefinition());
            }

            foreach (var button in cherryModel._numericalBtns)
            {
                Numpad.Children.Add(button);
            }

            SetButtonPosition();            
        }

        public void InitialNumpadButtons()
        {
            Button doubleZero = new Button();
            doubleZero.Content = "00";
            doubleZero.Background = new SolidColorBrush(Color.FromArgb(75, 40, 78, 217));
            cherryModel._numericalBtns.Add(doubleZero);

            for (int i = 0; i < 10; i++)
            {
                Button numButton = new Button();
                numButton.Content = i;
                //numButton.Background = new SolidColorBrush(Color.FromArgb(120, 21, 35, 26));
                cherryModel._numericalBtns.Add(numButton);
            }

            Button pointBtn = new Button();
            pointBtn.Content = ".";
           
            cherryModel._numericalBtns.Insert(2, pointBtn);

        }

        public void SetButtonPosition()
        {
            var buttonIndex = 0;
            for (int i = Numpad.RowDefinitions.Count -1; i > 0 ; i--)
            {
                for (int j = 0; j < Numpad.ColumnDefinitions.Count -1; j++)
                {
                    Grid.SetColumn(Numpad.Children[buttonIndex], j);
                    Grid.SetRow(Numpad.Children[buttonIndex], i);
                    buttonIndex++;
                }
                
            }

            MainGrid.Children.Add(Numpad);
            Grid.SetRow(MainGrid.Children[2], 1);
        }
    }

    public class CherryModel
    {
       public List<Button> _numericalBtns = new List<Button>();
    }
}
