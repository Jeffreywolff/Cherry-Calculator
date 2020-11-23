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
            InitializeNumpadButtons();
            InitializeOperatorButtons();
            SetOnButtonClick(cherryModel._numericalBtns);
            SetupNumpad();
        }

        private void SetOnButtonClick(List<Button> list)
        {
            foreach (var button in list)
            {
                button.Click += Button_Click;
            }
        }

        private void SetupNumpad()
        {
            Numpad = new Grid();
            for (int i = 0; i < 4; i++)
            {
                Numpad.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 5; i++)
            {
                Numpad.RowDefinitions.Add(new RowDefinition());
            }

            
            foreach (var button in cherryModel._numericalBtns)
            {
                Numpad.Children.Add(button);
            }

            SetButtonPosition();            
        }

        public void InitializeNumpadButtons()
        {
            Button doubleZero = new Button();
            doubleZero.Content = "00";
            cherryModel._numericalBtns.Add(doubleZero);

            for (int i = 0; i < 10; i++)
            {
                Button numBtn = new Button();
                numBtn.Content = "" + i;
                cherryModel._numericalBtns.Add(numBtn);

            }

            Button pointBtn = new Button();
            pointBtn.Content = ".";
            cherryModel._numericalBtns.Insert(2, pointBtn);

        }

        public void InitializeOperatorButtons()
        {
            var plusBtn = new Button();
            var minusBtn = new Button();
            var multiplyBtn = new Button();
            var divideBtn = new Button();
            var sqrtBtn = new Button();
            var clearBtn = new Button();
            var toThePowerBtn = new Button();
            var deleteBtn = new Button();

            // Plus sign button properties
            plusBtn.Content = "+";
            // Minus sign button properties
            minusBtn.Content = "-";
            // Multiply sign button properties
            multiplyBtn.Content = "x";
            // Divíde sign button properties
            divideBtn.Content = "÷";
            // Squareroot sign button properties
            sqrtBtn.Content = "√";
            //Clear button sign button properties
            clearBtn.Content = "C";
            // To the power of sign button properties
            toThePowerBtn.Content = "xⁿ";
            // Percentage sign button properties
            deleteBtn.Content = "Del";


            cherryModel._numericalBtns.Insert(3, plusBtn);
            cherryModel._numericalBtns.Insert(7, minusBtn);
            cherryModel._numericalBtns.Insert(11, multiplyBtn);
            cherryModel._numericalBtns.Insert(15, divideBtn);
            cherryModel._numericalBtns.Insert(16, clearBtn);
            cherryModel._numericalBtns.Insert(17, toThePowerBtn);
            cherryModel._numericalBtns.Insert(18, sqrtBtn);
            cherryModel._numericalBtns.Insert(19, deleteBtn);

        }

        public void SetButtonPosition()
        {
            var buttonIndex = 0;
            for (int i = Numpad.RowDefinitions.Count -1; i >= 0; i--)
            {
                for (int j = 0; j < Numpad.ColumnDefinitions.Count; j++)
                {
                    Grid.SetColumn(Numpad.Children[buttonIndex], j);
                    Grid.SetRow(Numpad.Children[buttonIndex], i);
                    buttonIndex++;
                }
                

            }

            MainGrid.Children.Add(Numpad);
            Grid.SetRow(MainGrid.Children[2], 1);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (e.Source is Button btn)
            {


                switch (btn.Content)
                {
                    case "00":
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "+":
                    case "-":
                    case "x":
                    case "÷":
                    case "√":
                    case ".":
                        InOutField.Text += btn.Content;
                        break;
                    case "Execute":
                        if (InOutField.Text.Contains("+"))
                        {
                            string[] numParameters = InOutField.Text.Split('+');
                            double[] doubleParam = Array.ConvertAll(numParameters, double.Parse);
                            double sum = doubleParam.Sum();
                            string sumView = sum.ToString();
                            InOutField.Text = sumView;
                        }

                        else if (InOutField.Text.Contains("-"))
                        {
                            string[] numParameters = InOutField.Text.Split('-');
                            double[] doubleParam = Array.ConvertAll(numParameters, double.Parse);
                            double sum = doubleParam[0] - doubleParam[1];
                            string sumView = sum.ToString();
                            InOutField.Text = sumView;
                        }

                        else if (InOutField.Text.Contains("x"))
                        {
                            string[] numParameters = InOutField.Text.Split('x');
                            double[] doubleParam = Array.ConvertAll(numParameters, double.Parse);
                            double product = doubleParam[0] * doubleParam[1];
                            string productView = product.ToString();
                            InOutField.Text = productView;
                        }

                        else if (InOutField.Text.Contains("÷"))
                        {
                            string[] numParameters = InOutField.Text.Split('÷');
                            double[] doubleParam = Array.ConvertAll(numParameters, double.Parse);
                            double quotient = doubleParam[0] / doubleParam[1];
                            string quotientView = quotient.ToString();
                            InOutField.Text = quotientView;
                        }

                        else if (InOutField.Text.Contains("^"))
                        {
                            string[] numParameters = InOutField.Text.Split('^');
                            double[] doubleParam = Array.ConvertAll(numParameters, double.Parse);
                            double product = Math.Pow(doubleParam[0], doubleParam[1]);
                            string productView = product.ToString();
                            InOutField.Text = productView;
                        }

                        break;
                    case "C":
                        InOutField.Text = "";
                        break;
                    case "Del":
                        if (InOutField.Text.Length < 1)
                        {
                            break;
                        }
                        else
                        {
                            InOutField.Text = InOutField.Text.Remove(InOutField.Text.Length - 1);
                            break;
                        }
                    case "xⁿ":
                        InOutField.Text += "^";
                        break;

                    default:
                        break;
                }





            }
        }
    }

    public class CherryModel
    {
       public List<Button> _numericalBtns = new List<Button>();
    }
}
