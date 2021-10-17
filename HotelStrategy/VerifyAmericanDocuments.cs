using System;

namespace HotelStrategy
{
    public class VerifyAmericanDocuments : IVerificationMode
    {
        public void VerifyDocuments(string name, string gender)
        {

            if (gender.ToLower() == "male")
                Console.WriteLine("Verifying visa for mister " + name);
            else
                Console.WriteLine("Verifying visa for miss " + name);

        }
    }
}
