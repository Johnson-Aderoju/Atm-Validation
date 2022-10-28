using AtmValidation;
class AssignmentPINValidation
{
    static void Main()
    {
        DebitCard debitCard = new DebitCard();
        debitCard.Pin = "123455"; 
        System.Console.WriteLine(debitCard.Pin); 
        // System.Console.ReadKey();
    }
}
