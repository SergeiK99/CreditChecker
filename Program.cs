using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CreditChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("Json.json");
            bool isCreditWorthy = CreditCheck.CheckCredit(json);
            Console.WriteLine($"Клиент кредитоспособен: {(isCreditWorthy ? "Да" : "Нет")}");
        }
    }
}
