namespace TestPlugin
{
    public class BrutusMod
    {
        private static int i = 20;

        private static string SendLogin(string userpass)
        {
            i += i * 43;
            if (i % 3 == 0)
            {
                return "CORRECT_" + i++;
            }
            return null;
        }
    }
}