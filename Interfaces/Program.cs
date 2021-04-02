using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class PersonManager
    {
        //implemented operation : Tamamlanmış operasyon, içi doldurulmuş implementasyon
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
    }
    //interface new'lenemez
    interface IPersonManager
    {
        //default public tir. o yüzden void önüne public yazmayız
        //unimplemented operation 
        void Add();
    }

    //inherits - class --------------------- implements - interface
    class CustomerManager:PersonManager
    {

    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }
    }
}
