using System;
public class Program
{
    public static int ReducePhoneNumber(int phoneNr)
    {
        string total = "";
        string phone_number= "";
        while (phoneNr > 9)
        {
            for (int number = 0; number < phoneNr.ToString().Length; number += 2)
            {
                if (number + 1 < phoneNr.ToString().Length)
                {
                    phone_number = phoneNr.ToString();
                    int digit_1 = int.Parse(phone_number[number].ToString());
                    int digit_2 = int.Parse(phone_number[number + 1].ToString());
                    int digit_sum = digit_1 + digit_2;
                    total += digit_sum.ToString();
                }
                else
                {
                    phone_number = phoneNr.ToString();
                    int final_digit = int.Parse(phone_number[phone_number.Length - 1].ToString());
                    total += final_digit.ToString();
                }
            }
            phoneNr = int.Parse(total);
            total = "";
        }
        return phoneNr;
    }

    public static void Main()
    {
        Console.WriteLine(ReducePhoneNumber(4783926)); 
    }
}