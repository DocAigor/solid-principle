using System;

namespace SolidIsp.BadThings
{
    //l'autore di questo file negherà sempre di aver scritto anche una sola riga

    interface IWannaDoAll
    {
        void Print();
        void Scan();
        void Call();
        void CoffePlease();
    }

    //l'interfaccia l'abbiamo creata per questa super stampante ...
    class AllInOneSuperPrinter : IWannaDoAll
    {
        public void Call() => Console.WriteLine("TU TU TU TUUUUU");

        public void CoffePlease() => Console.WriteLine("You coffe is ready sir");

        public void Print() => Console.WriteLine("Done");

        public void Scan() => Console.WriteLine(" /_ ");
    }

    //ma se avessimo altri tipi di dispositivi ? 
    class CheapPrinter : IWannaDoAll
    {
        //questa stampante super economica non ha il telefono 
        public void Call() => throw new NotImplementedException();
        //e nemmeno la macchinetta del caffè ...
        public void CoffePlease() => throw new NotImplementedException();

        public void Print() => Console.WriteLine("Done");

        public void Scan() => Console.WriteLine(" /_ ");
    }

    class CoffeMachine : IWannaDoAll
    {
        //mentre questa macchinetta del caffè sa fare SOLO il caffè 
        public void CoffePlease() => Console.WriteLine("You coffe is ready sir");

        public void Call() => throw new NotImplementedException();
        public void Print() => throw new NotImplementedException();
        public void Scan() => throw new NotImplementedException();
    }


    class Smartphone : IWannaDoAll
    {

        //e questo smartphone solo chiamate ...
        public void Call() => Console.WriteLine("TU TU TU TUUUUU");

        public void CoffePlease() => throw new NotImplementedException();
        public void Print() => throw new NotImplementedException();
        public void Scan() => throw new NotImplementedException();
    }
}
