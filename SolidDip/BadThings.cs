namespace SolidDip.BadThings
{
    /*
     ReportGenerator ad un certo momento richiama il metodo Send() dell’EmailSender per eseguire il compito. 
     Ipotizziamo adesso che domani vogliamo che data venga inviato tramite json .... che si fa? 
     Dovremmo cambiare ReportGenerator ....
   */
    public class ReportGenerator
    {
        public EmailSender EmailSender;

        public ReportGenerator(EmailSender emailSender) => EmailSender = emailSender;

        public void SendReport(object data) => EmailSender.Send(data);
    }

    public class EmailSender
    {
        public void Send(object data)
        {
            
        }
    }
}
