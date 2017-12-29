using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linear_Regression
{
    public partial class Form1 : Form
    {
        List<double> xvalues = new List<double>();
        List<double> yvalues = new List<double>();
        int values;
        NumberBox[] d;

        public Form1()
        {
            InitializeComponent();
            values = 1;
            // dynamic data boxes - kinda
            NumberBox [] data = new NumberBox [134];
            int n, r;
            for (n = 0; n < 134; ++n)
                data[n] = new NumberBox();

            for (n = 89; n < 133; ++n)
            {
                double s = (double)n;
                data[n].Enabled = false;
                data[n].Name = "Data " + n.ToString();
                data[n].TabIndex = n - 83;
                data[n].Size = new System.Drawing.Size(94, 20);
                data[n].Location = new System.Drawing.Point((s % 2 == 0 ? 3 : 103), 25 + (27 * (n - 89)));
                data[n].TextChanged += new EventHandler(this.TextChangedEvent);
                data[n].KeyDown += new KeyEventHandler(this.Check);
            }
            n = 89;
            for (r = 1; r < 23; ++r)
            {
                tableLayoutPanel3.Controls.Add(data[n], 0, r);
                tableLayoutPanel3.Controls.Add(data[n + 1], 1, r);
                n += 2;
            }

            n = 45;
            for (r = 1; r < 23; ++r)
            {
                tableLayoutPanel2.Controls.Add(data[n], 0, r);
                tableLayoutPanel2.Controls.Add(data[n + 1], 1, r);
                n += 2;
            }
            for (n = 45; n < 89; ++n)
            {
                double s = (double)n;
                data[n].Enabled = false;
                data[n].Name = "Data " + n.ToString();
                data[n].TabIndex = n - 41;
                data[n].Size = new System.Drawing.Size(94, 20);
                data[n].Location = new System.Drawing.Point((s % 2 == 0 ? 3 : 103), 25 + (27 * (n - 89)));
                data[n].TextChanged += new EventHandler(this.TextChangedEvent);
                data[n].KeyDown += new KeyEventHandler(this.Check);
            }

            n = 1;
            for (r = 1; r < 23; ++r)
            {
                tableLayoutPanel1.Controls.Add(data[n], 0, r);
                tableLayoutPanel1.Controls.Add(data[n + 1], 1, r);
                n += 2;
            }
            for (n = 1; n < 45; ++n)
            {
                double s = (double)n;
                data[n].Enabled = false;
                data[n].Name = "Data " + n.ToString();
                data[n].TabIndex = n;
                data[n].Size = new System.Drawing.Size(94, 20);
                data[n].Location = new System.Drawing.Point((s % 2 == 0 ? 3 : 103), 25 + (27 * (n - 89)));
                data[n].TextChanged += new EventHandler(this.TextChangedEvent);
                data[n].KeyDown += new KeyEventHandler(this.Check);
            }
            data[1].Enabled = true;
            d = data;
        }

        private void TextChangedEvent(object o, EventArgs e)
        {
            if (values > 6)
                regress.Enabled = true;
        }

        private void Check(object o, KeyEventArgs k)
        {
            if (k.KeyCode == Keys.Return || k.KeyCode == Keys.Right)
            {
                values++;
                d[values].Enabled = true;
                d[values].Focus();
            }
        }

        private void grabValues()
        {
            for (int n = 1; n < values; n+=2)
            {
                xvalues.Add(Convert.ToDouble(d[n].Text));
                yvalues.Add(Convert.ToDouble(d[n+1].Text));
            }
        }

        private void clearValues()
        {
            xvalues.Clear();
            yvalues.Clear();
            values = 1;
            for (int m = 0; m < 133; ++m)
                d[m].Text = "0";
            for (int m = 2; m < 133; ++m)
                d[m].Enabled = false;
            ex.Text = ey.Text = n.Text = exy.Text = ex2.Text = ex2brace.Text = mgrad.Text = "0";
            c.Text = xbar.Text = ybar.Text = exxbar.Text = exxbar2.Text = Exxbaryybar.Text = "0";
            eyybar.Text = Eyybar2.Text = stddev.Text = r2.Text = "0";
            regress.Enabled = false;
        }

        private double calcsigmax()
        {
            double sx = xvalues.Sum();
            return sx;
        }

        private double calcsigmay()
        {
            double sy = yvalues.Sum();
            return sy;
        }

        private double calcsigmaxy()
        {
            double sxy = 0;
            int r = 0;
            foreach (double n in xvalues)
            {
                sxy += n * yvalues[r++];
            }
            return sxy;
        }

        private double calcxbar()
        {
            return xvalues.Average();
        }

        private double calcybar()
        {
            return yvalues.Average();
        }

        private double calcxsquarebracket()
        {
            double xsb = 0;
            foreach (double n in xvalues)
                xsb += Math.Pow(n, 2);
            return xsb;
        }

        private double calcxsquare()
        {
            double xs = xvalues.Sum();
            return Math.Pow(xs, 2);
        }

        private double calcm()
        {
            double num = (calcsigmay() * calcsigmax()) - (values * calcsigmaxy());
            double denom = calcxsquarebracket() - (values * calcxsquare());
            return num / denom;
        }

        private double calcc()
        {
            double num = (calcsigmax() * calcsigmaxy()) - (calcsigmay() * calcxsquare());
            double denom = calcxsquarebracket() - (values * calcxsquare());
            return num / denom;
        }

        private double calcstddev()
        {
            double m = calcm();
            double c = calcc();
            double sy = 0;
            int r = 0;
            List<double> ycalc = new List<double>();
            foreach (double n in yvalues)
                ycalc.Add(m * n + c);
            foreach (double s in yvalues)
                sy += Math.Pow(ycalc[r++] - s, 2);
            sy = Math.Pow(sy, 2);
            sy /= values - 2;
            sy = Math.Sqrt(sy);
            return sy;
        }

        private double calcrsqr()
        {
            List<double> xycalc = new List<double>();
            List<double> xcalc = new List<double>();
            List<double> ycalc = new List<double>();
            double xbar = calcxbar();
            double ybar = calcybar();
            double sxbar, sybar;
            double sxybar = 0;
            int r = 0;
            foreach (double x in xvalues)
                xcalc.Add(x - xbar);
            foreach (double y in yvalues)
                ycalc.Add(y - ybar);
            foreach (double y in ycalc)
                sxybar += xcalc[r++] * y;
            sxbar = Math.Pow(xcalc.Sum(), 2);
            sybar = Math.Pow(ycalc.Sum(), 2);
            return sxybar / (Math.Sqrt(sxbar * sybar));
        }

        private double calcExxyybar()
        {
            List<double> xycalc = new List<double>();
            List<double> xcalc = new List<double>();
            List<double> ycalc = new List<double>();
            double xbar = calcxbar();
            double ybar = calcybar();
            double sxybar = 0;
            int r = 0;
            foreach (double x in xvalues)
                xcalc.Add(x - xbar);
            foreach (double y in yvalues)
                ycalc.Add(y - ybar);
            foreach (double y in ycalc)
                sxybar += xcalc[r++] * y;
            return sxybar;
        }

        private double calcexxbar2()
        {
            double res = 0, xbar = calcxbar();
            foreach (double x in xvalues)
                res += Math.Pow(x - xbar, 2);
            return res;
        }

        private double calceyybar2()
        {
            double res = 0, ybar = calcybar();
            foreach (double y in yvalues)
                res += Math.Pow(y - ybar, 2);
            return res;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clearValues();
            tabControl1.SelectedTab = datain;
        }

        private void regress_Click(object sender, EventArgs e)
        {
            int s, t = Math.DivRem(values, 2, out s);
            if (s != 0)
            {
                MessageBox.Show("You have an uneven number of datapoints. Calculation cannot be performed", "Linear Regression Analysis", MessageBoxButtons.OK);
                return;
            }
            tabControl1.SelectedTab = analysis;
            grabValues();
            ex.Text = string.Format("{0:0.####}", calcsigmax());
            ey.Text = string.Format("{0:0.####}", calcsigmay());
            n.Text = (values / 2).ToString();
            mgrad.Text = string.Format("{0:0.####}", calcm());
            exy.Text = string.Format("{0:0.####}", calcsigmaxy());
            ex2brace.Text = string.Format("{0:0.####}", calcxsquarebracket());
            ex2.Text = string.Format("{0:0.####}", calcxsquare());
            c.Text = string.Format("{0:0.####}", calcc());
            xbar.Text = string.Format("{0:0.####}", calcxbar());
            ybar.Text = string.Format("{0:0.####}", calcybar());
            Exxbaryybar.Text = string.Format("{0:0.####}", calcExxyybar());
            exxbar2.Text = string.Format("{0:0.####}", calcexxbar2());
            Eyybar2.Text = string.Format("{0:0.####}", calceyybar2());
            stddev.Text = string.Format("{0:0.####}", calcstddev());
            r2.Text = string.Format("{0:0.####}", calcrsqr());
        }
    }

    class NumberBox : TextBox
    {
        public NumberBox()
        {
            this.CausesValidation = true;
            this.Validating += new CancelEventHandler(TextBox_Validation);
        }

        private void TextBox_Validation(object sender, CancelEventArgs e)
        {
            try
            {
                double value = System.Double.Parse(this.Text);
            }
            catch (System.Exception)
            {
                e.Cancel = true;
            }
        }
    }
}
