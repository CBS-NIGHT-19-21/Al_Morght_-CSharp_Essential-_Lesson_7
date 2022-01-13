using System;

namespace Task3
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass) { myClass.change = "changed."; }

        static void StruktTaker(MyStruct myStruct) { myStruct.change = "changed."; }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct;

            myClass.change = "not changed.";
            myStruct.change = "not changed.";

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            Console.WriteLine(new string('-', 30));

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            /*Анализ:
              1. Отличия классов от структур: создаётся отдельная копия объекта, которая после копирования живёт
                 «своей жизнью» (классы – создаётся ссылка на тот же класс (т. н. instance)).

              2. Передача параметров: как локальные копии переменных 

              Вывод: 
                 Из-за выше перечисленного - структурное поле change не изменяется в классе Main при помощи метода так как в метод StruktTaker попадает копия экземпляра
                 в которой и происходят изменеия которые и остаются в копии находящейся в методе не отражаясь на копии которая была создана в Main.
            */

            Console.ReadKey();
        }
    }
}
