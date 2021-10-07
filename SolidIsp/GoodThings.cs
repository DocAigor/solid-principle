using System;

namespace SolidIsp.GoodThings
{
    //se applichiamo invece il principio di segregazione delle interfacce ....
    interface IPrint
    {
        void Print();
    }

    interface IScan
    {
        void Scan();
    }

    interface ICall
    {
        void Call();
    }

    interface ICoffe
    {
        void CoffePlease();
    }

    class AllInOneSuperPrinter : ICall, ICoffe, IPrint, IScan
    {
        public void Call() => Console.WriteLine("TU TU TU TUUUUU");

        public void CoffePlease() => Console.WriteLine("You coffe is ready sir");

        public void Print() => Console.WriteLine("Done");

        public void Scan() => Console.WriteLine(" /_ ");
    }

    class CheapPrinter : IPrint, IScan
    {
        public void Print() => Console.WriteLine("Done");

        public void Scan() => Console.WriteLine(" /_ ");
    }

    class CoffeMachine : ICoffe
    {
        public void CoffePlease() => Console.WriteLine("You coffe is ready sir");
    }


    class Smartphone : ICall
    {
        public void Call() => Console.WriteLine("TU TU TU TUUUUU");
    }
}
