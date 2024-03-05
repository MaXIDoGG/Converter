namespace Converter
{
    class Control_
    {
        //Основание системы сч. исходного числа.
        const int pin = 10;
        //Основание системы сч. результата.
        const int pout = 16;
        //Число разрядов в дробной части результата.
        const int accuracy = 10;

        public History his = new History();

        //Объект редактора
        public Editor ed = new Editor();

        public enum State { Edit, Transform };

        public State St { get; set; }

        //Конструктор
        public Control_()
        {
            St = State.Edit;
            Pin = pin;
            Pout = pout;
        }

        //Свойство для чтения и записи основания системы сч. p1.
        public int Pin { get; set; }

        //Свойство для чтения и записи основания системы сч. p2.
        public int Pout { get; set; }

        //Выполнить команду конвертора
        public string Do(int j)
        {
            if (j == 19)
            {
                double r = Converter_p_10.Do(ed.Number, (Int16)Pin);
                string res = Convert_10_p.Do(r, (Int32)Pout, acc());
                St = State.Transform;
                his.AddRecord(Pin, Pout, ed.Number, res);
                return res;
            }
            else
            {
                St = State.Edit;
                return ed.DoEdit(j);
            }
        }

        private int acc()
        {
            return (int)Math.Round(ed.Acc() * Math.Log(Pin) / Math.Log(Pout) + 0.5);
        }
    }
}
