using System;

namespace Converter;

/// <summary>
/// Структура для хранения чисел и их систем счисления
/// </summary>
public struct Record
{
    int p1;
    int p2;
    string number1;
    string number2;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <param name="number1"></param>
    /// <param name="number2"></param>
    public Record(int p1, int p2, string number1, string number2)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.number1 = number1;
        this.number2 = number2;
    }

    /// <summary>
    /// Преобразование значений в формат строки
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{number1} ({p1} с.сч.) = {number2} ({p2} с.сч.)\r\n";
    }
}

/// <summary>
/// Класс отвечает за документирование
/// выполнения пользователем переводов чисел
/// </summary>
internal class History
{
    private List<Record> L { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public History()
    {
        L = new List<Record>();
    }

    /// <summary>
    /// Извлечь запись по её номеру из списка L
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Record this[int i]
    {
        get
        {
            if (i < 0 || i >= L.Count)
            {
                throw new Exception("Index out of range.");
            }

            return L[i];
        }

    }

    /// <summary>
    /// Добавить новую запись
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <param name="n1"></param>
    /// <param name="n2"></param>
    public void AddRecord(int p1, int p2, string n1, string n2)
    {
        L.Add(new Record(p1, p2, n1, n2));
    }

    /// <summary>
    /// Очистить историю
    /// </summary>
    public void Clear()
    {
        L.Clear();
    }

    /// <summary>
    /// Текущий размер списка в числе записей 
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return L.Count;
    }
}