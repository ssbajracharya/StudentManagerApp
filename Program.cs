namespace StudentManagerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Data.Students.Add(new Student()
            {
                StudId = 100,
                FirstName = "Kim",
                LastName = "Clijsters",
                Address = "911 Belgium Way",
                Month = MonthOfAdmission.August,
                Grade = 'A'
            });

            Data.Students.Add(new Student()
            {
                StudId = 101,
                FirstName = "Marat",
                LastName = "Safin",
                Address = "123 Moscow Dr",
                Month = MonthOfAdmission.January,
                Grade = 'B'
            });


            //Application.Run(new Form1());
            Application.Run(new MainForm());
        }
    }
}