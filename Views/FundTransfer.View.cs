// using System;
// using System.Windows.Forms;

// namespace FundTransfer
// {
//     public partial class MainView : Form
//     {
//         private Form activeForm = null; // Keeps track of the currently active form

//         public MainView()
//         {
//             // InitializeComponent();
//         }
        

//         private void LoadForm(Form childForm)
//         {
//             if (activeForm != null)
//             {
//                 activeForm.Close(); // Close previously opened form
//             }

//             activeForm = childForm; // Set new active form
//             childForm.TopLevel = false;
//             childForm.FormBorderStyle = FormBorderStyle.None;
//             childForm.Dock = DockStyle.Fill;
//             pnlContent.Controls.Clear(); // Clear previous form
//             pnlContent.Controls.Add(childForm);
//             childForm.Show();
//         }

//         private void btnIncome_Click(object sender, EventArgs e)
//         {
//             LoadForm(new IncomeView()); // Load IncomeView inside pnlContent
//         }

//         private void btnExpenses_Click(object sender, EventArgs e)
//         {
//             LoadForm(new ExpensesView()); // Load ExpensesView inside pnlContent
//         }

//         private void btnTransactions_Click(object sender, EventArgs e)
//         {
//             LoadForm(new TransactionsView()); // Load TransactionsView inside pnlContent
//         }
//     }
// }
