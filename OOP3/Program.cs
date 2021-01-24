using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şubede internette ekranda görülen krediler
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DateBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DateBaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
