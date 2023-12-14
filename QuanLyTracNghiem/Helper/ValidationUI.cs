using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTracNghiem.Helper
{
    public class ValidationUI
    {
        public ValidationUI() { }
        public void CheckEmptyTextBox(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if(textBox.Text == string.Empty)
                {
                    throw new Exception("Invalid value!");
                }
            }
        }
        public void CheckLengthTextBox(List<TextBox> textBoxes, int min, int max)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Length < min || textBox.Text.Length > max)
                {
                    throw new Exception("Invalid value!");
                }
            }
        }
    }
}
