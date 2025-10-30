using System;
public class Program
{
    public static void Main()
    {
        LoginSystem system = new LoginSystem();

        while (true)
        {
            try
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                bool success = system.Login(username, password);

                if (success)
                    break;
            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine("Here are existing users:");
                system.ShowUsers();
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine("WARNING: " + ex.Message);
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine("CRITICAL: " + ex.Message + " Please contact admin.");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
            }

            Console.WriteLine(); // boş sətir üçün
        }
    }
}
