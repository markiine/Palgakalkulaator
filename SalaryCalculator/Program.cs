using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your bruto salary: ");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());  //variant ka Double.Parse(Console.ReadLine()


            if (brutoSalary <= 1200 ) //&& brutoSalary >= 500)
            {
                if (brutoSalary <= 500)
                {
                    SalaryIsLessThan500(brutoSalary);
                }
                else
                {
                    SalaryIsLessThan1200(brutoSalary);
                }
                
            }

            if (brutoSalary <= 2099 && brutoSalary >= 1201)
            {
                SalaryIsBetween1201And2099(brutoSalary);
            }

            if (brutoSalary >= 2100)
            {
                SalaryIsMoreThan2100(brutoSalary);
            }

        }


        // ERAND
        public static void SalaryIsLessThan500(double brutoSalary)
        {
            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;

            double netIncome = brutoSalary - unemploymentTax - pensionFond;

            Console.WriteLine($"Your neto salary is: {netIncome}");
        }



        public static void SalaryIsLessThan1200(double brutoSalary)
        {
            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;
            double incomeTax = (brutoSalary - 500 - unemploymentTax - pensionFond) * 0.2;
            double netIncome = brutoSalary - unemploymentTax - pensionFond -incomeTax;

            Console.WriteLine($"Your neto salary is: {netIncome}");
        }

        public static void SalaryIsBetween1201And2099(double brutoSalary)
        {
            double coefficient = 0.55556;
            double deductibleIncome = brutoSalary - 1200;
            // võib panna juurde, eelmised ka välja defineeritud lihtsalt 
            //double monthlyMaxTaxSumMinusDeductibleIncome = coefficient * deductibleIncome

            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;
            double taxFreeIncome = 500 - coefficient * deductibleIncome;
            double incomeTax = (brutoSalary - unemploymentTax - pensionFond - taxFreeIncome) * 0.2;
            double netIncome = brutoSalary - unemploymentTax - pensionFond - incomeTax;

            Console.WriteLine($"Your neto salary is: {netIncome}");
        }

        public static void SalaryIsMoreThan2100(double brutoSalary)
        {
            double unemploymentTax = brutoSalary * 0.016;
            double pensionFond = brutoSalary * 0.02;
            double incomeTax = (brutoSalary - unemploymentTax - pensionFond) * 0.2;
            double netIncome = brutoSalary - unemploymentTax - pensionFond - incomeTax;

            Console.WriteLine($"Your neto salary is: {netIncome}");
        }





        /* MUU VARIANT
        static void Main(string[] args)
        {
            // kood 
            int brutoSalary = 0;

            Console.WriteLine("Please enter your bruto salary: ");
            brutoSalary = Convert.ToInt32(Console.ReadLine());

            if (brutoSalary <= 1200 && brutoSalary >= 500)
            {
                Calc1(brutoSalary);
            }

            if (brutoSalary <= 2099 && brutoSalary >= 1201)
            {
                Calc2(brutoSalary);
            }

            if (brutoSalary >= 2100)
            {
                Calc3(brutoSalary);
            }


        }


        static void Calc1(double brutoSalary)
        {
            double pensionFond = brutoSalary * 0.02;

            double Insurance = brutoSalary * 0.016;

            double Tax = (brutoSalary - 500 - pensionFond - Insurance) * 0.2;

            double Calc1 = brutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your neto salary is = " + Calc1);
        }

        static void Calc2(double brutoSalary)
        {
            double pensionFond = brutoSalary * 0.02;

            double Insurance = brutoSalary * 0.016;

            double TaxFreeInCome = 500 - 0.55556 * (brutoSalary - 1200);

            double Tax = (brutoSalary - pensionFond - Insurance - TaxFreeInCome) * 0.2;

            double Calc2 = brutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your neto salary is = " + Calc2);
        }

        static void Calc3(double brutoSalary)
        {
            double pensionFond = brutoSalary * 0.02;

            double Insurance = brutoSalary * 0.016;

            double Tax = (brutoSalary - pensionFond - Insurance) * 0.2;

            double Calc3 = brutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your neto salary is = " + Calc3);
        }
        */


    }

}









//Palga kalkulaator Test 
//1. Sina sisestad brutotasu ja valem arvutab välja netotasu.
//2. Kokku peab olema kolm erinevat meetodit. Enne kui meetod algab, siis peab olema kontroll, et millist meetodi hakatakse kasutama ja sisestatud palgasumma peab minema edasi järgmisse meetodi.
//3. Netotasu peab arvutama selliselt välja, et sina ei peaks tuludeklaratsiooni ajal juurde maksma ega saa pärast riigilt raha juurde kuna oled rohkem maksnud.
//4. Kood peab olema inglisekeelne.
//Palgakalkulaator:
//https://www.kalkulaator.ee/et/palgakalkulaator
//Palga arvutamise valem:
//https://www.emta.ee/et/maksuvaba-tulu

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier

// https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/