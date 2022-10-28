namespace AtmValidation
{
 public class DebitCard
{
    //private field
    private string _pin;

    //PIN should be either 4 digit or 6 digit number
    public string Pin
    {
        set
        {
            if (value != null && value != "") //if the value is not null or not empty string
            {
                if (value.Length == 4 || value.Length == 6) //if the number of characters value is either 4 or 6
                {
                     int i = 0;
                     Boolean isValid = int.TryParse(value, out i);
                     if (isValid == true)
                        {
                          _pin = value;
                        }
                        
                    else
                        System.Console.WriteLine("PIN contains one or more non-digit characters.");
                }
                else
                    System.Console.WriteLine("PIN should contain either 4 digits or 6 digits");
            }
            else
                System.Console.WriteLine("PIN value can't be blank");
        }
        get
        {
            return _pin;
        }
    }
}
}
