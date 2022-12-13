namespace MyException;
internal class Program
{
   private static void Main(string[] args)
   {
      ArgumentException argumentException         = new("The passed argument is incorrect. No I won't tell you how to fix.");
      DivideByZeroException divideByZeroException = new("You're just testing me aren't you?");
      FormatException formatException             = new("Ah right, you're supposed to pass a number btw");
      FileNotFoundException fileNotFoundException = new("Are you sure the file exists? Bc it doesn't");
      WrongWeekDay wrongWeekDay                   = new("Bad weekday. Try running the code tomorrow. May work, but I don't promise anything");
      Exception[] exceptions = {argumentException, divideByZeroException, formatException, fileNotFoundException, wrongWeekDay};
      
      foreach (Exception exception in exceptions) {
         try {
            throw exception;
         } catch (Exception caughtException) {
            Console.WriteLine(caughtException.Message);
         } finally {
            Console.WriteLine("We went though another error!");
         }
      }
   }
}