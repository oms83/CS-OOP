namespace PrivateConstructorVSStaticClass
{
    internal class Program
    {
        static class Settings
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
            //Settings settings = new Settings(); Right befor adding private Settings() { }
            //Settings settings = new Settings(); Wrong after adding private Settings() { }
            //Settings settings = new Settings(); Wrong after static class Settings

            Settings.ProjectPath = @"C:\\Users\\omerm\\Desktop\\OMS\\PROGRAMING";
            Console.WriteLine(Settings.ProjectPath);
            Console.WriteLine(Settings.DayName);
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine("Hello, World!");
        }
    }
}

/*
    namespace PrivateConstructorVSStaticClass
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
                private Settings()
                {

                }
            }
            static void Main(string[] args)
            {
                //Settings settings = new Settings(); Right befor adding private Settings() { }
                //Settings settings = new Settings(); Wrong after adding private Settings() { }
                //Settings settings = new Settings(); Wrong after static class Settings

                Settings.ProjectPath = @"C:\\Users\\omerm\\Desktop\\OMS\\PROGRAMING";
                Console.WriteLine(Settings.ProjectPath);
                Console.WriteLine(Settings.DayName);            
                Console.WriteLine(Settings.DayNumber);
                Console.WriteLine("Hello, World!");
            }
        }
    }
*/