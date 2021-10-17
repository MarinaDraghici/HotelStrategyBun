using System;

namespace HotelStrategy
{
    public class VerifyNonEuropeanDocuments : IVerificationMode
    {
        public void VerifyDocuments(string name, string gender)
        {

            if (gender.ToLower() == "male")
                Console.WriteLine("Verifying passport for mister " + name);
            else
                Console.WriteLine("Verifying passport for miss " + name);

        }
    }
}
