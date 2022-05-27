namespace MethodsForHangman
{
    public static class Validations
    {
        public static bool ValidateInput(string input)
        {
            if (input.All(c => char.IsDigit(c)))
            {
                return false;
            }
            else if (!string.IsNullOrEmpty(input))
            {
                return true;
            }
            return false;
        }
    }
}
