namespace PalindromeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phrase = textBox1.Text;
            bool containsInt = phrase.Any(char.IsDigit);
            char[] arr = phrase.Trim().ToLower().ToCharArray();
            if (string.IsNullOrWhiteSpace(phrase)) {
                label2.ForeColor = Color.Red;
                label2.Text = "You must insert at least a character.";
            } else if (containsInt) {
                label2.ForeColor = Color.Red;
                label2.Text = "Numbers are not allowed.";
            } else {
                bool isPalindrome = true;
                for (int i = 0; i < arr.Length; i++) { 
                    if (arr[i] != arr[arr.Length - (i+1)]) {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome) {
                    label2.ForeColor = Color.Green;
                    label2.Text = "Congratulations! " + phrase + " is a palindrome!";
                } else {
                    label2.ForeColor = Color.Orange;
                    label2.Text = "Sorry, that's not a palindrome...";
                }
            }
            textBox1.Text = "";
        }
    }
}
