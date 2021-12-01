using System;

namespace ActivationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine(@"Activ8 - by Bruce Tonge and John Cooke

                Gets conformationID from Microsoft Activation. 

                Usage: Activ8.exe <InstalationID> <ExtendedProductID>");
            }
            else
            {
                string InstallationId = args[0];
                string ExtendedProductId = args[1];

                var result = ActivationHelper.CallWebService(1, InstallationId, ExtendedProductId);
                Console.WriteLine(result);          
            }
            
        }
    }
}

