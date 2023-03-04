using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject1
{
    internal class Human
    {
        public string PersonName(string personName)
        {
            return "Person name word count is " + personName.Length;
        }

        public string PersonSurname(string personSurname)
        {
            return "Person surname word count is " + personSurname.Length;
        }

        public string PersonNameValidation(string personName)
        {
            return "Person surname word count is " + personName.Length;
            //for (int i = 0; i <= personName.Length; i++)
            //{
            //    if (!char.IsDigit(personName[i]))
            //    {
            //        return "true";
            //    } else
            //    {
            //        return "false";
            //    }
            //}
        }

        //public void PersonSurnameValidation(string personSurname)
        //{
        //    for (int i = 0; i <= personSurname.Length; i++)
        //    {
        //        //var isNumeric = int.TryParse(personSurname[i], out int n);
        //        var isNumeric = int.TryParse("Grigoryan", out int n);
        //        try
        //        {
        //            if (isNumeric)
        //            {
        //                Console.WriteLine("Nooo");
        //            } else
        //            {
        //                Console.WriteLine("Okkk");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //}
    }
}
