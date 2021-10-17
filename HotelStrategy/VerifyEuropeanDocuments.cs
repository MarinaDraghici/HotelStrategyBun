using System;

namespace HotelStrategy
{
    public class VerifyEuropeanDocuments : IVerificationMode
    {
        public void VerifyDocuments(string name, string gender)
        {

            if (gender.ToLower() == "male")
                Console.WriteLine("Verifying ID card for mister " + name);
            else
                Console.WriteLine("Verifying ID card for miss " + name);

        }
    }
}
