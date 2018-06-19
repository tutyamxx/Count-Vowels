using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Count_Vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Count_Click(object sender, EventArgs e)
        {
            string TextAreaVowels = txtbox_StringList.Text;

            bool IsInvalidString = TextAreaVowels.Length > 0 && TextAreaVowels.Trim().Length == 0;

            if (TextAreaVowels == null
            || TextAreaVowels == ""
            || IsInvalidString)
            {
                MessageBox.Show("Text area can't be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int iTotal = 0;
            var szVowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            string szSentence = TextAreaVowels.ToLower();

            for (int i = 0; i < szSentence.Length; i++)
            {
                if (szVowels.Contains(szSentence[i]))
                {
                    iTotal++;
                }
            }

            MessageBox.Show("The amount of Vowels in this text are: " + iTotal, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_StringList.Text = "";
        }
    }
}
