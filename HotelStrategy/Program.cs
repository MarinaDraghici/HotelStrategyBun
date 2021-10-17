namespace HotelStrategy
{
    class Program
    {

        static void Main()
        {
            Client client = new ClientData().DataInput();


            switch (client.Origin)
            {
                case "0":
                    VerifyAmericanDocuments verificareAmericani = new();
                    verificareAmericani.VerifyDocuments(client.Name, client.Gender);
                    break;
                case "1":
                    VerifyEuropeanDocuments verificareEuropeni = new();
                    verificareEuropeni.VerifyDocuments(client.Name, client.Gender);
                    break;
                case "2":
                    VerifyNonEuropeanDocuments verificareNonEU = new();
                    verificareNonEU.VerifyDocuments(client.Name, client.Gender);
                    break;
            }
        }
    }
}
