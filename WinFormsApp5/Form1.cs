namespace WinFormsApp5
{
    public partial class Prelim_exam_lesson5 : Form
    {
        public int rate_per_hour = 0, num_hour = 0;
        public Prelim_exam_lesson5()
        {
            InitializeComponent();
            basicIncomeTxtBox.Enabled = false;
            hoIncomeTxtBox.Enabled = false;
            otIncomeTxtBox.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basic_Ratehr, basic_Hr, basic_Income, ho_Ratehr, ho_Hr, ho_income, ot_Rate, ot_Hr, ot_Income, gross_income;
            basic_Ratehr = Convert.ToInt32(basicRatehrTxtBox.Text);
            basic_Hr = Convert.ToInt32(basicHrTxtBox.Text);
            ho_Ratehr = Convert.ToInt32(horateHrsTxtBox.Text);
            ho_Hr = Convert.ToInt32(hoHrsTxtBox.Text);
            ot_Rate = Convert.ToInt32(otRateTxtBox.Text);
            ot_Hr = Convert.ToInt32(otHrsTxtBox.Text);

            basic_Income = basic_Ratehr * basic_Hr;
            ho_income = ho_Ratehr * ho_Hr;
            ot_Income = ot_Rate * ot_Hr;

            gross_income = basic_Income + ho_income + ot_Income;

            grossIncomeTxtBox.Text = gross_income.ToString("n");
            basicIncomeTxtBox.Text = basic_Income.ToString("n");
            hoIncomeTxtBox.Text = ho_income.ToString("n");
            otIncomeTxtBox.Text = ot_Income.ToString("n");

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sss_contrib, philhealth_contrib, pagibig_contrib, income_Tax_contrib, total_deduction, sss_Loan, pagibig_Loan, faculty_Deposit, faculty_Loan, salary_Loan, other_Loan, total_deductions,net_income, gross_income;

            sss_contrib = Convert.ToInt32(sssContribTxtBox.Text);
            philhealth_contrib = Convert.ToInt32(philhealthContribTxtBox.Text);
            pagibig_contrib = Convert.ToInt32(pagibigContribTxtBox.Text);
            income_Tax_contrib = Convert.ToInt32(incometaxContribTxtBox.Text);
            sss_Loan = Convert.ToInt32(sssLoanTxtBox.Text);
            pagibig_Loan = Convert.ToInt32(pagibigLoanTxtBox.Text);
            
            faculty_Deposit = Convert.ToInt32(facultysavingDepositTxtBox.Text);
            faculty_Loan = Convert.ToInt32(facultysavingLoanTxtBox.Text);
            salary_Loan = Convert.ToInt32(salryLoanTxtBox.Text);
            other_Loan = Convert.ToInt32(otherLoanTxtBox.Text);
            gross_income = Convert.ToInt32(grossIncomeTxtBox.Text);

            total_deduction = sss_contrib + philhealth_contrib + pagibig_contrib + income_Tax_contrib + sss_Loan + faculty_Deposit + faculty_Loan + salary_Loan + other_Loan;
            net_income = gross_income - total_deduction;

            totalDeductionTxtBox.Text = total_deduction.ToString("n");
            netIncomeTxtBox.Text = net_income.ToString("n");
        }
    }
}

