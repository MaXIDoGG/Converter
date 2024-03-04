namespace Converter;

/// <summary>
/// Преобразование действ. числа из 10-ой в p-ую с.с.
/// </summary>
class Convert_10_p
{
    /// <summary>
    /// Преобразовать целое число в символ
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static char int_to_Char(int n)
    {
        const string alphabet = "0123456789ABCDEF";
        return alphabet[n];
    }

    /// <summary>
    /// Преобразовать десятичное целое в с.сч. с основанием р
    /// </summary>
    /// <param name="n"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public static string int_to_P(int n, int p)
    {
        string result = "";
        while (n > p)
        {
            int remainder = n % p; // остаток от деления на основание с.с.
            result.Insert(0, int_to_Char(remainder).ToString()); // запись в обратном порядке
            n = n / p;
        }
        return result;
    }

    /// <summary>
    /// Преобразовать десятичную дробь в с.сч. с основанием р
    /// </summary>
    /// <param name="n"></param>
    /// <param name="p"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static string flt_to_P(double n, int p, int c)
    {
        string result = "";
        for (int i = 0; i < c; i++) // цикл до треб. точности
        {
            n = n * p; // умножение на основание с.с.
            result += int_to_Char((int)n).ToString(); // запись целой части
            n = n - (int)n; // отбрасывание целой части

            if (n == 0) // если дробная часть == 0
            {
                break;
            }
        }
        return result;
    }

    /// <summary>
    /// Преобразовать десятичное действительное число в с.сч. с осн. р
    /// </summary>
    /// <param name="n"></param>
    /// <param name="p"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static string Do(double n, int p, int c)
    {
        int int_n = (int)n; // целая часть
        double flt_n = n - int_n; // дробная часть

        if (flt_n == 0) // если нет дробной части
        {
            return int_to_P(int_n, p);
        }
        else
        {
            return int_to_P(int_n, p) + '.' + flt_to_P(flt_n, p, c);
        }
    }


}