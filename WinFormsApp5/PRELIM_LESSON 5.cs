using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class PRELIM_LESSON_5 : Form
    {
        public PRELIM_LESSON_5()
        {
            InitializeComponent();

            basicIncomeTxtBox.Enabled = false;
            hoIncomeTxtBox.Enabled = false;
            otIncomeTxtBox.Enabled = false;
            grossIncomeTxtBox.Enabled = false;
            netIncomeTxtBox.Enabled = false;
            totalDeductionTxtBox.Enabled = false;
            sssContribTxtBox.Enabled = false;
            philhealthContribTxtBox.Enabled = false;
            pagibigContribTxtBox.Enabled = false;
            incometaxContribTxtBox.Enabled = false;
        }

        private void grossIncomeBtn_Click(object sender, EventArgs e)
        {
            int basic_Hr, ho_Hr, ot_Hr;
            double basic_Ratehr ,  basic_Income , ho_Ratehr ,  ho_income , ot_Rate ,  ot_Income , gross_income ,
                sss_Contrib , incometaxContrib , pagibigContrib = 200.00, philhealthContrib ;

            basic_Ratehr = Convert.ToDouble(basicRatehrTxtBox.Text);
            basic_Hr = Convert.ToInt32(basicHrTxtBox.Text);
            ho_Ratehr = Convert.ToDouble(horateHrsTxtBox.Text);
            ho_Hr = Convert.ToInt32(hoHrsTxtBox.Text);
            ot_Rate = Convert.ToDouble(otRateTxtBox.Text);
            ot_Hr = Convert.ToInt32(otHrsTxtBox.Text);
            ot_Income = Convert.ToDouble(otIncomeTxtBox.Text);
            gross_income = Convert.ToDouble(grossIncomeTxtBox.Text);


            basic_Income = basic_Ratehr * basic_Hr;
            ho_income = ho_Ratehr * ho_Hr;
            ot_Income = ot_Rate * ot_Hr;

            gross_income = basic_Income + ho_income + ot_Income;

            grossIncomeTxtBox.Text = gross_income.ToString("n");
            basicIncomeTxtBox.Text = basic_Income.ToString("n");
            hoIncomeTxtBox.Text = ho_income.ToString("n");
            otIncomeTxtBox.Text = ot_Income.ToString("n");

            // SSS Contribution calculation (no need to read from textbox)
            if (gross_income < 5250)
                sss_Contrib = 510;
            else if (gross_income < 5749.99)
                sss_Contrib = 560;
            else if (gross_income < 6249.99)
                sss_Contrib = 610;
            else if (gross_income < 6749.99)
                sss_Contrib = 660;
            else if (gross_income < 7249.99)
                sss_Contrib = 710;
            else if (gross_income < 7749.99)
                sss_Contrib = 760;
            else if (gross_income < 8249.99)
                sss_Contrib = 810;
            else if (gross_income < 8749.99)
                sss_Contrib = 860;
            else if (gross_income < 9249.99)
                sss_Contrib = 910;
            else if (gross_income < 9749.99)
                sss_Contrib = 960;
            else if (gross_income < 10249.99)
                sss_Contrib = 1010;
            else if (gross_income < 10749.99)
                sss_Contrib = 1060;
            else if (gross_income < 11249.99)
                sss_Contrib = 1110;
            else if (gross_income < 11749.99)
                sss_Contrib = 1160;
            else if (gross_income < 12249.99)
                sss_Contrib = 1210;
            else if (gross_income < 12749.99)
                sss_Contrib = 1260;
            else if (gross_income < 13249.99)
                sss_Contrib = 1310;
            else if (gross_income < 13749.99)
                sss_Contrib = 1360;
            else if (gross_income < 14249.99)
                sss_Contrib = 1410;
            else if (gross_income < 14749.99)
                sss_Contrib = 1460;
            else if (gross_income < 15249.99)
                sss_Contrib = 1530;
            else if (gross_income < 15749.99)
                sss_Contrib = 1580;
            else if (gross_income < 16249.99)
                sss_Contrib = 1630;
            else if (gross_income < 16749.99)
                sss_Contrib = 1680;
            else if (gross_income < 17249.99)
                sss_Contrib = 1730;
            else if (gross_income < 17749.99)
                sss_Contrib = 1780;
            else if (gross_income < 18249.99)
                sss_Contrib = 1830;
            else if (gross_income < 18749.99)
                sss_Contrib = 1880;
            else if (gross_income < 19249.99)
                sss_Contrib = 1930;
            else if (gross_income < 19749.99)
                sss_Contrib = 1980;
            else if (gross_income < 20249.99)
                sss_Contrib = 2030;
            else if (gross_income < 20749.99)
                sss_Contrib = 2080;
            else if (gross_income < 21249.99)
                sss_Contrib = 2130;
            else if (gross_income < 21749.99)
                sss_Contrib = 2180;
            else if (gross_income < 22249.99)
                sss_Contrib = 2230;
            else if (gross_income < 22749.99)
                sss_Contrib = 2280;
            else if (gross_income < 23249.99)
                sss_Contrib = 2330;
            else if (gross_income < 23749.99)
                sss_Contrib = 2380;
            else if (gross_income < 24249.99)
                sss_Contrib = 2430;
            else if (gross_income < 24749.99)
                sss_Contrib = 2480;
            else if (gross_income < 25249.99)
                sss_Contrib = 2530;
            else if (gross_income < 25749.99)
                sss_Contrib = 2580;
            else if (gross_income < 26249.99)
                sss_Contrib = 2630;
            else if (gross_income < 26749.99)
                sss_Contrib = 2680;
            else if (gross_income < 27249.99)
                sss_Contrib = 2730;
            else if (gross_income < 27749.99)
                sss_Contrib = 2780;
            else if (gross_income < 28249.99)
                sss_Contrib = 2830;
            else if (gross_income < 28749.99)
                sss_Contrib = 2880;
            else if (gross_income < 29249.99)
                sss_Contrib = 2930;
            else if (gross_income < 29749.99)
                sss_Contrib = 2980;
            else if (gross_income < 30249.99)
                sss_Contrib = 3030;
            else if (gross_income < 30749.99)
                sss_Contrib = 3080;
            else if (gross_income < 31249.99)
                sss_Contrib = 3130;
            else if (gross_income < 31749.99)
                sss_Contrib = 3180;
            else if (gross_income < 32249.99)
                sss_Contrib = 3230;
            else if (gross_income < 32749.99)
                sss_Contrib = 3280;
            else if (gross_income < 33249.99)
                sss_Contrib = 3330;
            else if (gross_income < 33749.99)
                sss_Contrib = 3380;
            else if (gross_income < 34249.99)
                sss_Contrib = 3430;
            else if (gross_income < 34749.99)
                sss_Contrib = 3480;
            else
            {
                sss_Contrib = 3530;
            }

            // Income tax calculation
            if (gross_income <= 250000)
                incometaxContrib = 0.00;
            else if (gross_income <= 400000)
                incometaxContrib = (gross_income - 250000) * 0.15;
            else if (gross_income <= 800000)
                incometaxContrib = 22500 + ((gross_income - 400000) * 0.20);
            else if (gross_income <= 2000000)
                incometaxContrib = 102500 + ((gross_income - 800000) * 0.25);
            else if (gross_income <= 8000000)
                incometaxContrib = 402500 + ((gross_income - 2000000) * 0.30);
            else
                incometaxContrib = 2202500 + ((gross_income - 8000000) * 0.35);

            if(gross_income <= 10000)
                philhealthContrib = gross_income * 0.05;
            else if (gross_income >10000 && gross_income <=99999.99)
                philhealthContrib = gross_income * 0.05;
            else
            { 
                philhealthContrib = 5000 * 0.05;
            {






            sssContribTxtBox.Text = sss_Contrib.ToString("n");
            philhealthContribTxtBox.Text = philhealthContrib.ToString("n");
            pagibigContribTxtBox.Text = pagibigContrib.ToString("n");
            incometaxContribTxtBox.Text = incometaxContrib.ToString("n");
    }

        private void button1_Click(object sender, EventArgs e)
        {
            double sss_Loan, pagibig_Loan, faculty_Deposit, faculty_Loan, salary_Loan, other_Loan, total_deductions, gross_income, net_income;

            sss_Loan = Convert.ToDouble(sssLoanTxtBox.Text);
            pagibig_Loan = Convert.ToDouble(pagibigLoanTxtBox.Text);
            faculty_Deposit = Convert.ToDouble(facultyDepositTxtBox.Text);
            faculty_Loan = Convert.ToDouble(facultysavingLoanTxtBox.Text);
            salary_Loan = Convert.ToDouble(salaryLoanTxtBox.Text);
            other_Loan = Convert.ToDouble(otherLoanTxtBox.Text);

            total_deductions = Convert.ToDouble(sssContribTxtBox.Text) + Convert.ToDouble(pagibigContribTxtBox.Text) + Convert.ToDouble(philhealthContribTxtBox.Text) +
               Convert.ToDouble(incometaxContribTxtBox.Text) + sss_Loan + pagibig_Loan + faculty_Deposit + faculty_Loan + salary_Loan + other_Loan;
            gross_income = Convert.ToDouble(grossIncomeTxtBox.Text);

            net_income = gross_income - total_deductions;

            totalDeductionTxtBox.Text = total_deductions.ToString("n");
            netIncomeTxtBox.Text = net_income.ToString("n");
        }
    }
}
