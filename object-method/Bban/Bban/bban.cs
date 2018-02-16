using System;
using System.Collections.Generic;
using System.Text;

namespace Bban
{
    class bban
    {
        /// <summary>
        /// Changes BBAN account  to machine readable format
        /// </summary>
        /// <param name="accountNum"></param>
        /// <returns>machineformat account</returns>
        public static bool Correctnumber(ref string accountNum)
        {
            accountNum = accountNum.Replace("-", "").Replace(" ", "");
            for (int i = 0; i < accountNum.Length; i++)
            {
                bool isDigit = int.TryParse(accountNum[i].ToString(), out int digit);
                if (!isDigit)
                    return false;
            }

            int positionOfZeros = 0;
            if (accountNum[0] == '1' || accountNum[0] == '2' ||
                accountNum[0] == '6' || accountNum[0] == '8')
            {
                positionOfZeros = 6;
            }
            else if (accountNum[0] == '3')
            {
                if (accountNum[1] == '0' || accountNum[1] == '2' ||
                    accountNum[1] == '5')
                    return false;
                positionOfZeros = 6;
            }
            else if (accountNum[0] == '4' || accountNum[0] == '5')
                positionOfZeros = 7;
            else
            {
                return false;
            }


            for (int i = accountNum.Length; i < 14; i++)
            {
                accountNum = accountNum.Insert(positionOfZeros, "0");
            }
            return true;
        }
        //Method that checks which bank

        public static bool IsValidAccount(string machineFormatAccount)
        {
            int checkNumber = int.Parse(machineFormatAccount[machineFormatAccount.Length - 1].ToString());
            machineFormatAccount = machineFormatAccount.Remove(machineFormatAccount.Length - 1, 1);

            // multiplex on painokertoimen laskuri, % modulo joka laskee jakojäännöksen
            //jonka perusteella katsoo indeksin

            int[] multiplex = new int[2] { 2, 1 };
            int m = 0;
            for (int i = 0; i < machineFormatAccount.Length; i++)
            {
                int n = int.Parse(machineFormatAccount[i].ToString()) * multiplex[i % 2];

                if (n >= 10)
                {
                    m += n / 10 + (n - 10);
                }
                else
                {
                    m += n;
                }
            }

            int calculatedCheckNumber = ((m / 10 + 1) * 10) - m;

            return checkNumber == calculatedCheckNumber;
        }
    }
}

