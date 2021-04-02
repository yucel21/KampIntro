using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consumercreditmanager yerine ICreditManager yazsakta aynı sonucu alırız
            //interfacelerde onu implemente eden class ın referans numarasını tutabilir
            ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            MortgageManager mortgageManager = new MortgageManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ReferenceManager referenceManager = new ReferenceManager();
            //referenceManager.BasvuruYap(vehicleCreditManager);
            //parantez içine hesaplamak istediğimiz krediyi yazarız
            referenceManager.BasvuruYap(consumerCreditManager, new List<ILoggerService>{databaseLoggerService,fileLoggerService});

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager,vehicleCreditManager };

            //referenceManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
