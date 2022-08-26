using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    //класс Калькулятор
    public class Calc
    {
        //первый операнд
        public int value;
        
        //конструктор
        public Calc (int value)
        {
            this.value = value;
        }

        //обнуление первого операнда
        public void Reset ()
        {
            this.value = 0;
        }

        //установление первому операнду нового значения
        public void Set(int val)
        {
            this.value = val;
        }

        //суммирование числа с первым операндом
        public int Sum(int val)
        {
            return this.value = this.value + val;
        }
        
        //вычитание из первого операнда числа
        public int Minus(int val)
        {
            return this.value = this.value - val;
        }
        
        //деление первого операнда на число
        public int Divide(int val)
        {
            return this.value = this.value / val;
        }

        //умножение
        public int Multiply(int val)
        {
            return this.value = this.value * val;
        }

        //модуль числа
        public int Abs(int val)
        {
            if (val > 0) return val;
            else return -val;
        }
    }
}
