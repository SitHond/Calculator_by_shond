using System;
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
        public static string math_percent(string r, string t)
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
        public static string plusImg()
        {
            string imgPlus;
            return imgPlus = "https://sithond.ru/img/plus.png";
        }
        public static string minusImg()
        {
            string imgMinus;
            return imgMinus = "https://sithond.ru/img/minus.png";
        }
        public static string multiplyImg()
        {
            string imgMultiply;
            return imgMultiply = "https://sithond.ru/img/circle.png";
        }
        public static string divisionImg()
        {
            string imgDivision;
            return imgDivision = "https://sithond.ru/img/divide.png";
        }
        public static string discountImg()
        {
            string imgDiscount;
            return imgDiscount = "https://sithond.ru/img/discount.png";
        }
    }
}