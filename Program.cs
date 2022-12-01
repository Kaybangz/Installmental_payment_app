namespace Installmental_payment_app
{
    public class Program
    {
        static void Main()
        {
            ProcessPaymentPlan pp = new ProcessPaymentPlan();
            
            pp.RunInstallmentProcess();
        }
    }
}