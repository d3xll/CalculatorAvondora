using System.Net;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace CalculatorAvondora
{
    public partial class Avondora : Form
    {
        private Point mouseOffset; // 

        private string currentArithmeticOperation = string.Empty;
        private double number1;
        private bool newNumberStarted, debugMode = false;

        public Avondora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Avondora calculator started!");
            Console.WriteLine("Welcome!");
        }


        // Buttons actions - header
        private void but_closeApp(object sender, EventArgs e) => Application.Exit();
        private void but_minimaze(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;


        // Buttons actions - other
        private void but_number(object sender, EventArgs e)
        {
            Button but = (Button)sender; // получаем sender (типа кнопку от которой произошло событие click)

            if (newNumberStarted)
            {
                newNumberStarted = false;
                tablecalculator.Text = "0";
            }

            if (tablecalculator.Text == "0")
                tablecalculator.Text = but.Text;
            else
                tablecalculator.Text = tablecalculator.Text + but.Text; // добавл€ем число указанное в Button/Text (propit) в табло
        }

        private void but_clear(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string clearOption = but.Tag.ToString();
            debugUpdateValues();

            switch (clearOption)
            {
                case "clearSymbol":
                    tablecalculator.Text = tablecalculator.Text.Substring(0, tablecalculator.Text.Length - 1);
                    if (tablecalculator.Text == "")
                        tablecalculator.Text = "0";
                    break;
                case "clearCurrentNumber":
                    tablecalculator.Text = "0";
                    break;
                default:
                    number1 = 0;
                    tablecalculator.Text = "0";
                    break;
            }
        }

        private void but_arithmeticOperation_WaitNextInput(object sender, EventArgs e) => arithmeticOperation(sender, true);
        private void but_arithmeticOperation_SkipNextInput(object sender, EventArgs e) => arithmeticOperation(sender, false);

        private void but_comma(object sender, EventArgs e)
        {
            if (!tablecalculator.Text.Contains(","))
                tablecalculator.Text = tablecalculator.Text + ",";
        }

        private void but_getResult(object sender, EventArgs e) => tablecalculator.Text = getResult().ToString();

        private void but_debugModeEnable(object sender, EventArgs e)
        {
            if (debugMode)
            {
                debugMode = false;
                but_debug.ForeColor = Color.CornflowerBlue;
                this.Size = new Size(348, 480);
            }
            else
            {
                debugMode = true;
                but_debug.ForeColor = Color.Brown;
                this.Size = new Size(348, 550);
            }
        }

        // Logic calculator
        private void arithmeticOperation(object sender, bool waitToNextInput)
        {
            Button but = (Button)sender; // получаем sender'a тобишь кнопку
            currentArithmeticOperation = but.Tag.ToString(); // какое у нас выоплн€етс€ дейтсвие? (+, - и т.д)
            number1 = Convert.ToDouble(tablecalculator.Text);

            if (waitToNextInput)
                newNumberStarted = true; // после даем знак что началс€ ввод нового числа!
            else
                tablecalculator.Text = getResult().ToString();

        }

        private double getResult()
        {
            double currentNumber;
            currentNumber = Convert.ToDouble(tablecalculator.Text);

            debugUpdateValues();

            switch (currentArithmeticOperation)
            {
                case "+": return number1 + currentNumber;
                case "-": return number1 - currentNumber;
                case "*": return number1 * currentNumber;
                case "/": return number1 / currentNumber;
                case "%": return number1 * currentNumber / 100;
                case "sqrt": return Math.Sqrt(number1);
                case "pow": return Math.Pow(number1, currentNumber);
                case "pow^2": return Math.Pow(number1, 2);
                case "1/x": return 1 / number1;
                default: return 0; // Ќе найдено ничего св€занного с логичексим оператором, возращаем 0
            }
        }

        private void debugUpdateValues()
        {
            label_num1.Text = number1.ToString();
            label_numCurrent.Text = tablecalculator.Text;
            label_currentActive.Text = currentArithmeticOperation;
        }

        // Header (Drag & Drop)
        private void Header_MouseDown(object sender, MouseEventArgs e) => mouseOffset = new Point(-e.X, -e.Y);

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePose;
            }
        }
    }
}
