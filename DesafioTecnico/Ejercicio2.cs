namespace DesafioTecnico
{
    public static class Ejercicio2
    {

        public static bool ValidName(string name)
        {
            var (first, middle, last) = SplitName(name);
            if (string.IsNullOrEmpty(last))
            {
                return false;
            }
            return ValidateSingleName(last) && ValidateFirstAndMiddleName(first, middle);
        }

        private static (string, string, string) SplitName(string name)
        {
            var names = name.Split(" ");
            if (names.Length == 3)
            {
                return (names[0], names[1], names[2]);
            }
            if (names.Length == 2)
            {
                return (names[0], string.Empty, names[1]);
            }
            else
            {
                return (string.Empty, string.Empty, string.Empty);
            }
        }

        private static bool ValidateFirstAndMiddleName(string first, string middle)
        {
            if (IsInitial(first) && !IsInitial(middle))
            {
                return false;
            }
            return ValidateSingleName(first) && ValidateSingleName(middle);
        }

        private static bool ValidateSingleName(string name)
        {
            if (IsInitial(name))
            {
                return char.IsUpper(name[0]) && name.EndsWith(".");
            }
            else
            {
                return char.IsUpper(name[0]) && !name.EndsWith(".") && name.Length >= 2;
            }
        }

        private static bool IsInitial(string name)
        {
            return name.Length == 2 && name.EndsWith(".");
        }
    }
}
