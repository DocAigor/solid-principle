namespace SolidDip.GoodThings
{
    /*
     ....Per ovviare a questo problema, 
     la migliore soluzione consiste semplicemente nel modificare il ReportSender invertendo la dipendenza 
     con un’interfaccia Sender e specializzare le singole classi sulla "modalità di invio":         
    */
    public class ReportGenerator
    {
        public ISender Sender;

        public ReportGenerator(ISender sender)=> Sender = sender;

        public void SendReport(object data) => Sender.Send(data);
    }

    public interface ISender
    {
        void Send(object data);
    }

    public class EmailSender : ISender
    {
        public void Send(object data) { }
    }

    public class JsonSender : ISender
    {
        public void Send(object data) { }
    }
}
