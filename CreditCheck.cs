using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CreditChecker
{
    public class CreditCheck
    {
        public static bool CheckCredit(string json)
        {
            var clientData = JsonSerializer.Deserialize<ClientData>(json);

            if (AgeCheck(clientData.birthDate) == false)
            {
                Console.WriteLine("Отказ: Клиент не достиг минимального возраста.");
                return false;
            }

            if (PassportCheck(clientData.birthDate, clientData.passport) == false)
            {
                Console.WriteLine("Отказ: Проверка паспорта не пройдена.");
                return false;
            }

            if (CreditHistoryCheck(clientData.creditHistory) == false)
            {
                Console.WriteLine("Отказ: Проверка кредитной истории не пройдена.");
                return false;
            }
            return true;
        }

        private static bool AgeCheck(DateTime birthDate)
        {
            var age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age))
            {
                age--;
            }
            return age >= 20;
        }

        private static bool PassportCheck(DateTime birthDate, Passport passport)
        {
            var age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            if (age > 20 && passport.issuedAt < birthDate.AddYears(20))
            {
                return false;
            }

            if (age > 45 && passport.issuedAt < birthDate.AddYears(45))
            {
                return false;
            }

            return true;
        }

        private static bool CreditHistoryCheck(CreditHistory[] creditHistory)
        {
            foreach (var credit in creditHistory)
            {
                if (credit.type == "Кредитная карта")
                {
                    // Проверка для кредитной карты
                    if (credit.currentOverdueDebt > 0 ||
                        credit.numberOfDaysOnOverdue > 30)
                    {
                        return false;
                    }
                }
                else
                {
                    // Проверка для других типов кредитов
                    if (credit.currentOverdueDebt > 0 ||
                        credit.numberOfDaysOnOverdue > 60 ||
                        credit.remainingDebt > 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
