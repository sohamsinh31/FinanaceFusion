using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinanceFusion.Helpers
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Validates if the given name contains only letters and spaces.
        /// </summary>
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[A-Za-z\s]+$");
        }

        /// <summary>
        /// Validates if the given email is in a correct format.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) &&
                   Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Validates if the password meets security criteria.
        /// </summary>
        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) &&
                   password.Length >= 8 &&                // Minimum length
                   Regex.IsMatch(password, @"[A-Z]") &&   // At least one uppercase
                   Regex.IsMatch(password, @"[a-z]") &&   // At least one lowercase
                   Regex.IsMatch(password, @"\d") &&      // At least one digit
                   Regex.IsMatch(password, @"[\W_]");     // At least one special character
        }

        public static bool IsValidLoginPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 6;
        }

        /// <summary>
        /// Checks if the password and confirm password match.
        /// </summary>
        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        /// <summary>
        /// Validates if the birthdate is a past date.
        /// </summary>
        public static bool IsValidBirthdate(DateTime birthdate)
        {
            return birthdate < DateTime.Now;
        }

        /// <summary>
        /// Validates if a given phone number is in a valid format.
        /// </summary>
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+?\d{10,15}$");  // Supports optional '+' and 10-15 digits
        }

        /// <summary>
        /// Validates if a given input is a number.
        /// </summary>
        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        /// <summary>
        /// Checks if the input field is empty.
        /// </summary>
        public static bool IsNotEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Displays a validation message box.
        /// </summary>
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}