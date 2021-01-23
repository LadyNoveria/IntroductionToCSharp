using System;

namespace HW2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Для полного закрепления понимания простых типов найдите любой чек, 
            либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
            только за место динамических, по вашему мнению, данных (это может быть дата, 
            название магазина, сумма покупок) подставляйте переменные, которые были заранее 
            заготовлены до вывода на консоль.*/
            string company = "Лента";
            string address = "000000, Московская область, г. Реутов, ул. Строителей, д. 1";
            string dottedLine = "---------------------------------------------";
            DateTime dateTime = new DateTime(2021, 1, 2, 17, 13, 09);
            string product1 = "Лимоны";
            string product2 = "Напиток какао NESQUIK";
            string product3 = "Бананы";
            double productPrice1 = 89.88;
            double productPrice2 = 271.99;
            double productPrice3 = 63.54;
            double productWeight1 = 0.418;
            double productWeight2 = 1;
            double productWeight3 = 1.090;
            double summ = (productPrice1 * productWeight1) + (productPrice2 * productWeight2) + (productPrice3 * productWeight3);
            int cashbox = 0325;
            int pair = 125;
            string buyersCard = "80**********2045";
            int checkNumber = 54;
            string cashierName = "Петров И. В.";

            Console.WriteLine(company.ToUpper());
            Console.WriteLine(address.ToLower());
            Console.WriteLine($"КАССА: {cashbox} КАССИР: {cashierName.ToUpper()}");
            Console.WriteLine(dottedLine);
            Console.WriteLine("Кассовый чек (ПРИХОД)        *ПРОДАЖА ТОВАРА*");
            Console.WriteLine(dottedLine);
            Console.WriteLine($"{product1}    {productPrice1}  *  {productWeight1}    {productPrice1 * productWeight1}");
            Console.WriteLine($"{product2}    {productPrice2}  *  {productWeight2}    {productPrice2 * productWeight2}");
            Console.WriteLine($"{product3}        {productPrice3}  *  {productWeight3}      {productPrice3 * productWeight3}");
            Console.WriteLine(dottedLine);
            Console.WriteLine($"                ИТОГО К ОПЛАТЕ: {summ}");
            Console.WriteLine(dottedLine);
            Console.WriteLine("СПАСИБО ЗА ПОКУПКУ!");
            Console.WriteLine($"В чеке применена карта {buyersCard}");
            Console.WriteLine($"{dateTime}    СМЕНА N {pair}");
            Console.WriteLine($"ЧЕК {checkNumber}      ИТОГ {summ}");
            Console.WriteLine($"МЕСТО РАСЧЕТОВ КАССА N {cashbox}");


            readKey();
        }

        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
