using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kallulater_shond
{
    public static class Math
    {        
        public static string math_plas(string r, string t)
        {
            try
            {
                return (Convert.ToDouble(r) + Convert.ToDouble(t)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
        public static string math_minus(string r, string t)
        {
            try
            {
                return (Convert.ToDouble(r) - Convert.ToDouble(t)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
        public static string math_division(string r, string t)
        {
            try
            {
                return (Convert.ToDouble(r) / Convert.ToDouble(t)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
        public static string math_multiply(string r, string t)
        {
            try
            {
                return (Convert.ToDouble(r) * Convert.ToDouble(t)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
        public static string math_s(string r, string t)
        {
            try
            {
                return (Convert.ToDouble(r) * Convert.ToDouble(t) / 100).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
    }
}
