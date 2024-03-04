namespace Converter;

/// <summary>
/// Преобразование действ. числа из p-ой в 10-ую с.с.
/// </summary>
class Converter_p_10
{
    /// <summary>
    /// Преобразовать цифру в число
    /// </summary>
    /// <param name="ch"></param>
    /// <returns></returns>
    private static double Char_to_num(char ch)
    {
        const string alphabet = "0123456789ABCDEF";
        return alphabet.IndexOf(ch);
    }

    /// <summary>
    /// Преобразовать строку в число
    /// </summary>
    /// <param name="pNum"></param>
    /// <param name="p"></param>
    /// <param name="dotIndex"></param>
    /// <returns></returns>
    private static double Convert(string pNum, int p, double dotIndex)
    {
        double result = 0;
        for (int i = 0; i < pNum.Length; ++i)
        {
            result += Char_to_num(pNum[i]) * Math.Pow(p, dotIndex - i - 1);//перевод числа из произвольной системы в десятичную
        }
        return result;
    }

    /// <summary>
    /// Преобразовать из с.сч. с основанием р в с.сч. с основанием 10
    /// </summary>
    /// <param name="pNum"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public static double Do(string pNum, int p)
    {
        int dotIndex = pNum.IndexOf('.');
        if (dotIndex == -1) // точка не нашлась
        {
            return Convert(pNum, p, pNum.Length);
        }
        else
        {
            string numWithoutDot = pNum.Remove(dotIndex, 1);//убираем точку
            return Convert(numWithoutDot, p, dotIndex);
        }
    }
}