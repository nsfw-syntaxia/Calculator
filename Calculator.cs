using System;

namespace Calculator_Dolera
{
    public partial class Calculator : Form
    {
        private string equation = "";
        private string term = "";
        private static readonly char[] operators = { '+', '-', '×', '÷' };

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnDigits_Click(object sender, EventArgs e)
        {
            Button btnDigit = (Button)sender;

            if (term == "0" && btnDigit.Text == "0")
                return;

            if (term == "0" && btnDigit.Text != "0")
                term = btnDigit.Text;
            else
                term += btnDigit.Text;

            tbxResult.Text = term;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(term) && !term.Contains("."))
                term += ".";
            else if (!string.IsNullOrEmpty(term) && term.Contains("."))
                return;
            else
                term += "0.";

            tbxResult.Text = term;
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(term))
                return;

            if (term.StartsWith("-"))
                term = term.Substring(1);
            else if (term != "0")
                term = "-" + term;

            tbxResult.Text = term;
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;

            if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(equation))
                return;
            else if (string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(equation))
            {
                int index = equation.LastIndexOfAny(operators);
                string previous = "";

                if (index != -1)
                {
                    string last = equation.Remove(equation.Length - 2);
                    int space = last.LastIndexOf(' ');

                    if (space != -1)
                        previous = last.Substring(space + 1);
                    else
                        previous = last;
                }

                equation = equation.Substring(0, equation.Length - 2) + " " + btnOperator.Text;
                tbxResult.Text = previous;
            }

            if (!string.IsNullOrEmpty(term))
            {
                if (term.EndsWith("."))
                    term += "0";

                if (string.IsNullOrEmpty(equation))
                    equation = term + " " + btnOperator.Text;
                else
                    equation += " " + term + " " + btnOperator.Text;

                tbxResult.Text = term;
            }

            tbxEquation.Text = equation;
            term = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(term) && string.IsNullOrEmpty(equation))
                return;
            
            if (!string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(equation))
            {
                if (term.EndsWith("."))
                    term += "0";

                equation += " " + term;
                tbxEquation.Text = equation + " =";
            }

            if (string.IsNullOrEmpty(equation))
            {
                if (term.EndsWith("."))
                    term += "0";

                tbxEquation.Text = term + " =";

                if (double.TryParse(term, out double result))
                {
                    tbxResult.Text = result.ToString();
                    term = result.ToString();
                    equation = "";
                    return;
                }
            }

            string operations = equation.Replace("×", "*").Replace("÷", "/");

            try
            {
                string[] terms = operations.Split(new[] { '+', '-', '*', '/' });

                for (int i = 0; i < terms.Length - 1; i++)
                {
                    if (operations.Contains("/") && operations.Contains("/" + terms[i + 1]) &&
                        double.TryParse(terms[i + 1], out double divisor) && divisor == 0)
                        throw new DivideByZeroException();
                }

                System.Data.DataTable solve = new System.Data.DataTable();
                object result = solve.Compute(operations, string.Empty);

                if (double.TryParse(result.ToString(), out double answer))
                {
                    string format;

                    if (answer % 1 == 0)
                        format = answer.ToString();
                    else
                        format = answer.ToString("F5").TrimEnd('0').TrimEnd('.');

                    tbxResult.Text = format;
                    term = format;
                    equation = "";
                }
                else
                {
                    tbxResult.Text = result.ToString();
                    term = result.ToString();
                    equation = "";
                }
            }
            catch (DivideByZeroException)
            {
                tbxResult.Text = "UNDEFINED";
                term = "";
                equation = "";
            }
            catch
            {
                tbxResult.Text = "ERROR";
                term = "";
                equation = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "0";
            tbxEquation.Text = "";
            term = "";
            equation = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (term.Length > 1)
            {
                term = term.Remove(term.Length - 1);
                tbxResult.Text = term;
            }
            else
            {
                term = "";
                tbxResult.Text = "0";
            }
        }

        private void btnExtensions_Click(object sender, EventArgs e)
        {
            Button btnExtension = (Button)sender;

            if (string.IsNullOrEmpty(term))
                return;

            if (term.EndsWith("."))
                term += "0";

            double result;
            string format;

            switch (btnExtension.Text)
            {
                case "%":
                    if (double.TryParse(term, out result))
                    {
                        result = result / 100;
                        format = result.ToString("F5").TrimEnd('0').TrimEnd('.');
                        tbxResult.Text = format;
                        tbxEquation.Text = $"{term}% =";
                        term = result.ToString();
                        equation = "";
                    }
                    break;

                case "x²":
                    if (double.TryParse(term, out result))
                    {
                        result = result * result;
                        format = result.ToString("F5").TrimEnd('0').TrimEnd('.');
                        tbxResult.Text = format;
                        tbxEquation.Text = $"{term}² =";
                        term = result.ToString();
                        equation = "";
                    }
                    break;

                case "n!":
                    if (double.TryParse(term, out result) && result >= 0 && result == (int)result)
                    {
                        double factorial = 1;
                        for (int i = 1; i <= (int)result; i++)
                            factorial *= i;
                        tbxResult.Text = factorial.ToString();
                        tbxEquation.Text = $"{term}! =";
                        term = factorial.ToString();
                        equation = "";
                    }
                    else
                    {
                        tbxResult.Text = "ERROR";
                        tbxEquation.Text = $"{term}! =";
                        term = "";
                        equation = "";
                    }
                    break;

                case "1/x":
                    if (double.TryParse(term, out result) && result != 0)
                    {
                        result = 1 / result;
                        format = result.ToString("F5").TrimEnd('0').TrimEnd('.');
                        tbxResult.Text = format;
                        tbxEquation.Text = $"1 / {term} =";
                        term = format;
                        equation = "";
                    }
                    else
                    {
                        if (result == 0)
                            tbxResult.Text = "UNDEFINED";

                        tbxEquation.Text = $"1 / {term} =";
                        term = ""; ;
                        equation = "";
                    }
                    break;
            }
        }
    }
}
