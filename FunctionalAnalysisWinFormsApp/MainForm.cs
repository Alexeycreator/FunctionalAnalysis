using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FunctionalAnalysisWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<BernstainModel> bernstainsModels = new List<BernstainModel>();
        private Random rnd = new Random();
        private int p;
        private int n;
        private double x;
        private double[] arraySumm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbxVariable.Text = "Введите номер варианта";
            tbxVariable.ForeColor = Color.Gray;
            tbxN.Text = "Введите число итераций (n)";
            tbxN.ForeColor = Color.Gray;
            tbxX.Text = "Введите число x";
            tbxX.ForeColor = Color.Gray;
            btnPrint.Enabled = false;
        }

        private double FunctionFX(double _t)
        {
            return (p * Math.Pow(Math.E, (p * _t))) - (3 * Math.Pow(Math.E, (-p * _t - 2)));
        }

        private double BinomialCoefficient(int _n, int _k) //C из n по k
        {
            if (_k == 0)
            {
                return 1;
            }

            else if (_n == _k)
            {
                return 1;
            }

            else
            {
                return Factorial(_n) / (Factorial(_k) * (Factorial(_n - _k)));
            }
        }

        private double Factorial(int _n)
        {
            if (_n < 0) return 0;
            if (_n == 0 || _n == 1) return 1;

            long result = 1;
            for (int i = 2; i <= _n; i++)
            {
                if (result > long.MaxValue / i)
                {
                    MessageBox.Show($"Переполнение при вычислении факториала {_n}!");
                    return long.MaxValue;
                }

                result *= i;
            }

            return result;
        }

        private void InitValue()
        {
            p = Convert.ToInt32(tbxVariable.Text);
            n = Convert.ToInt32(tbxN.Text);
            x = Convert.ToDouble(tbxX.Text);
        }

        private double BernsteinFormula()
        {
            InitValue();
            arraySumm = new double[n + 1];
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                double t = (double)i / n;
                double functionValue = FunctionFX(t);
                double binomCoeff = BinomialCoefficient(n, i);
                double basis = binomCoeff * Math.Pow(x, i) * Math.Pow(1 - x, n - i);
                sum = functionValue * basis;
                arraySumm[i] = sum;
            }

            return Math.Round(sum, 3);
        }

        private void PrintBernstein()
        {
            BernsteinFormula();
            FillingArraySumm();
            foreach (var item in bernstainsModels)
            {
                rTbxPrintInfo.AppendText($"\n{item.NameB}: {Math.Round(item.SummBernstain, 3)}");
            }
        }

        private void FillingArraySumm()
        {
            double sumArr = 0;
            for (int i = 0; i < arraySumm.Length; i++)
            {
                sumArr += arraySumm[i];
                if (i == arraySumm.Length - 1)
                {
                    FillingModels(sumArr);
                }
            }
        }

        private void FillingModels(double _summArr)
        {
            if (bernstainsModels == null || bernstainsModels.Count == 0)
            {
                bernstainsModels.Add(new BernstainModel
                {
                    NameB = $"B{n}",
                    SummBernstain = _summArr
                });
            }
            else
            {
                bool exists = bernstainsModels.Any(bernstain => bernstain.SummBernstain.Equals(_summArr));
                if (!exists)
                {
                    bernstainsModels.Add(new BernstainModel
                    {
                        NameB = $"B{n}",
                        SummBernstain = _summArr
                    });
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintBernstein();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxVariable.Text = null;
            tbxN.Text = null;
            tbxX.Text = null;
        }

        private bool IsParseInt(string _text)
        {
            return Int32.TryParse(_text, out int value);
        }

        private bool IsParseDouble(string _text)
        {
            return Double.TryParse(_text, out double value);
        }

        #region TbxValiable Handlers

        private void tbxVariable_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxVariable.Text))
            {
                tbxVariable.Text = "Введите номер варианта";
                tbxVariable.ForeColor = Color.Gray;
            }

            if (IsParseInt(tbxVariable.Text))
            {
                btnPrint.Enabled = true;
            }
        }

        private void tbxVariable_Enter(object sender, EventArgs e)
        {
            if (!IsParseInt(tbxVariable.Text))
            {
                tbxVariable.Text = null;
            }

            tbxVariable.ForeColor = Color.Black;
        }

        #endregion

        #region TbxN Handlers

        private void tbxN_Enter(object sender, EventArgs e)
        {
            if (!IsParseInt(tbxN.Text))
            {
                tbxN.Text = null;
            }

            tbxN.ForeColor = Color.Black;
        }

        private void tbxN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxN.Text))
            {
                tbxN.Text = "Введите число итераций (n)";
                tbxN.ForeColor = Color.Gray;
            }

            if (IsParseInt(tbxN.Text))
            {
                btnPrint.Enabled = true;
            }
        }

        #endregion

        #region TbxX Handlers

        private void tbxX_Enter(object sender, EventArgs e)
        {
            if (!IsParseDouble(tbxX.Text))
            {
                tbxX.Text = null;
            }

            tbxX.ForeColor = Color.Black;
        }

        private void tbxX_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxX.Text))
            {
                tbxX.Text = "Введите число x";
                tbxX.ForeColor = Color.Gray;
            }

            if (IsParseDouble(tbxX.Text))
            {
                btnPrint.Enabled = true;
            }
        }

        #endregion
    }
}