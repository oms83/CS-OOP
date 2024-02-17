namespace StaticPropertiesAndStaticClass
{
    internal class Program
    {
        class Settings
        {
            public static int DayNumber
            {
                get
                {
                    return DateTime.Today.Day;
                }
            }

            public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }

            public static string ProjectPath
            {
                get;
                set;
            }
        }
        static void Main(string[] args)
        {

            Settings.ProjectPath = @"C:\\Users\\omerm\\Desktop\\OMS\\PROGRAMING";
            Console.WriteLine(Settings.ProjectPath);
            Console.WriteLine(Settings.DayName);            
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine("Hello, World!");
        }
    }
}