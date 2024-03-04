namespace Converter;

/// <summary>
/// Редактор действительных чисел представленных в системе счисления с основанием р
/// </summary>
internal class Editor
{
    //Поле для хранения редактируемого числа
    private string number = "";
    //Разделитель целой и дробной частей
    const char Delim = '.';
    //Ноль
    const string Zero = "0";
    //Свойствое для чтения редактируемого числа
    public string Number => number;

    /// <summary>
    /// Целое число в символ
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static char IntToChar(int n)
    {
        const string dictionary = "0123456789ABCDEF";
        return dictionary[n];
    }

    /// <summary>
    /// Добавить цифру
    /// </summary>
    /// <param name="n"></param>
    public void AddDigit(char n)
    {
        if (number is Zero or "-0")
            number = n.ToString();
        else
        {
            number += Char.ToUpper(n);
        }
    }

    /// <summary>
    /// Удалить символ справа
    /// </summary>
    public void RemoveDigit()
    {
        number = number.Length > 1 ? number.Substring(0, number.Length - 1) : "";
    }

    /// <summary>
    /// Точность представления результата
    /// </summary>
    /// <returns></returns>
    public int Acc()
    {
        int i = 0;
        if (number.Length > 0)
        {
            while (number[i] != Delim && i < number.Length - 1)
            {
                i++;
            }
            return number.Length - i - 1;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Добавить разделитель
    /// </summary>
    public void AddDelim()
    {
        if (number != "" && number != "-" && !number.Contains(Delim))
        {
            number += Delim;
        }
    }

    /// <summary>
    /// Очистить редактируемое число.
    /// </summary>
    /// <returns></returns>
    public void Clear()
    {
        number = "";
    }

    /// <summary>
    /// Выполнить команду редактирования
    /// </summary>
    /// <param name="j"></param>
    /// <returns></returns>
    public string DoEdit(int j)
    {
        if (j is >= 0 and <= 15) AddDigit(IntToChar(j));
        if (j == 16) AddDelim();
        if (j == 17) RemoveDigit();
        if (j == 18) Clear();
        return number;
    }
}