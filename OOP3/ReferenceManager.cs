using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Başvuru Manager
    class ReferenceManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //biz burda hangi tip kredi isteniyorsa onu hesaplarız
            creditManager.Calculate();

            //Tek logger yollamak istediğimizde bu loglama formulu
            //loggerService.Log();
            //liste şeklinde loglama 
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
