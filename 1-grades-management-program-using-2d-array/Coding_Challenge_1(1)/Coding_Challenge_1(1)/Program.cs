using System;

namespace Coding_Challenge_1_1_
{
    class Program
    {
        //global variable declaration
        static int sn = 0;
        static double pgrade = 0, mgrade = 0, fgrade = 0, sgrade = 0, dgrade;
        static bool boolean1 = true, boolean2 = true;
        //declaring, instantitating, and storing values in 2D array
        static string[,] record = new string[10, 10]{ {"1", "Jayson Ramos Santos", "BSIT 3-2", "COMP 20032", "90", "60", "85", "79", "2.50", "PASS"},
                { "2", "Mary Santos Ramos", "BSIT 3-2", "COMP 20032", "90", "60", "85", "79", "2.50", "PASS" }, {"3", "John Cruz Nieto\t", "BSIT 3-2", "COMP 20032", "90", "60", "85", "79", "2.50", "PASS"},
                {"4", "Rose Navarro Alvarez", "BSIT 3-2", "COMP 20032", "90", "60", "85", "79", "2.50", "PASS"}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "",
                "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""}, {"", "", "", "", "", "", "", "", "", ""} };
        static string lname = "", fname = "", mname = "", course = "", yr_level = "", section = "", enrolled_subject = "", remark = "";
        static ConsoleKey K = ConsoleKey.Enter;
//_______________________________________________Main Method_______________________________________________________________
        static void Main(string[] args)
        {
            int op, i, j; //local variable declation
            while (boolean1) //loop to repeat the execution of operations
            {
                op = 0; sn = 0; //resetting the value for 2nd and more operation
                while ((op < 1) || (op > 8)) //loop to filter invalid data(eg. -1, 0, 11)
                {
                    Console.Clear();
                    Console.Write("\n\tOperations:\n\n\t[1] Add Student Personal Data and Scholastic Grades\n\t[2] Edit Student Personal Data" +
                        "\n\t[3] Edit Student Scholastic Grades\n\t[4] View Student Personal Data\n\t[5] View Student Scholastic Grades" +
                        "\n\t[6] Delete Student Record\n\t[7] List All Records\n\t[8] Exit\n\n\tEnter operation:    ");
                    op = Convert.ToInt32(Console.ReadLine());
                }
                if (op == 1) //code if user enter operation 1
                {
                    boolean2 = true;
                    while ((sn < 1) || (sn > 10) || (record[sn - 1, 0] != "")) //code to filter invalid data and existing student information
                    {
                        if ((sn < 1) || (sn > 10))
                        {
                            Console.Clear();
                            Console.Write("\n\tModule: Add Student Personal Data and Scholastic Grades\n\n\tEnter student number(1-10):  ");
                            sn = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\tModule: Add Student Personal Data and Scholastic Grades\n\n\tStudent number exists. Try again.\n\n\tEnter student number(1-10):  ");
                            sn = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    PrintPer(); //calling the function to print and read personal data
                    PrintSch(); //calling the function to print and read scholastic data
                    sgrade = GetSG(pgrade, mgrade, fgrade); //calling the function to get the subject grade
                    dgrade = GetDec(sgrade); //calling the function to get the decimal grade
                    remark = GetRem(sgrade); //calling the function to get the remark
                    KeyYR("added"); //calling the function for pressing key to add or to return to the main program
                    StorePer(sn); //calling the function to store personal data
                    StoreSch(sn); //calling the function to store scholastic data
                }
                if (op == 2) //code if user enter operation 2
                {
                    boolean2 = true;
                    Console.Clear(); //clearing the screen
                    //Printing module title and asking for student number
                    Console.Write("\n\tModule: Edit Student Personal Data\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                    //call function to filter invalid data and not existing student number
                    StudentNumber("\n\tModule: Edit Student Personal Data", "Invalid student number. Please try again.", "No record found. Please try again.");
                    PrintPer(); //calling the function to print and read personal data
                    StorePer(sn); //calling the function to store personal data
                    KeyYR("edited"); //calling the function for pressing Y or R key as well as filtering other keys
                }
                if (op == 3) //code if user enter operation 3
                {
                    boolean2 = true;
                    Console.Clear(); //clearing the screen
                    //printing module title and asking for student number
                    Console.Write("\n\tModule: Edit Student Scholastic Grades\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                    //calling the function to filter invalid data and not existing student number
                    StudentNumber("\n\tModule: Edit Student Scholastic Grades", "Invalid student number. Please try again.", "No record found. Please try again.");
                    Console.Write("\n\tStudent Name:    " + record[sn - 1, 1] + "\n"); // printing student name
                    PrintSch(); //printing and reading scholastic data
                    StoreSch(sn); //reading scholastic data
                    record[sn - 1, 7] = GetSG(pgrade, mgrade, fgrade).ToString(); //getting subject grade
                    record[sn - 1, 8] = GetDec(sgrade).ToString(); //getting decimal grade
                    record[sn - 1, 9] = GetRem(sgrade); //getting the remark
                    KeyYR("edited"); //calling the function for pressing Y or R key as well as filtering other keys
                }
                if (op == 4) //code if user enter operation 4
                {
                    boolean2 = true;
                    Console.Clear(); //clear screen
                    //printing module title and asking for student number
                    Console.Write("\n\tModule: View Student Personal Data\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                    //calling the function to filter invalid data and not existing student number
                    StudentNumber("\n\tModule: View Student Personal Data", "Invalid student number. Please try again.", "No record found. Please try again.");
                    //Displaying student personal data
                    Console.Write("\n\n\tStudent name:    " + record[sn - 1, 1] + "\n\tCourse/ Year Level/ Section:  "
                        + record[sn - 1, 2] + "\n\tEnrolled subject code:   " + record[sn - 1, 3]);
                    KeyR(); //pressing key R to return to the main and filtering other keys
                }
                if (op == 5) //code if user enter operation 5
                {
                    boolean2 = true;
                    Console.Clear(); //clear screen
                    //printing module title and asking for student number
                    Console.Write("\n\tModule: View Student Scholastic Data\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                    //calling the function to filter invalid data and not existing student number
                    StudentNumber("\n\tModule: View Student Scholastic Data", "Invalid student number. Please try again.", "No record found record found. Please try again.");
                    //Displaying student scholastic data
                    Console.Write("\n\tStudent Name:    " + record[sn - 1, 1] + "\n\n\tPrelim term grade (30%): " + record[sn - 1, 4] + "%\n\tDecimal equivalent:    "
                         + GetDec(Convert.ToDouble(record[sn - 1, 4])).ToString() + "\n\tRemarks:   " + GetRem(Convert.ToDouble(record[sn - 1, 4]))
                         + "\n\n\tMidterm grade (30%): " + record[sn - 1, 5] + "%\n\tDecimal equivalent:    " + GetDec(Convert.ToDouble(record[sn - 1, 5])).ToString()
                         + "\n\tRemarks:   " + GetRem(Convert.ToDouble(record[sn - 1, 5])) + "\n\n\tFinal term grade (40%): " + record[sn - 1, 6] + "%\n\tDecimal equivalent:    "
                         + GetDec(Convert.ToDouble(record[sn - 1, 6])).ToString() + "\n\tRemarks:   " + GetRem(Convert.ToDouble(record[sn - 1, 6])) + "\n\n\tSubject grade (100%): "
                         + record[sn - 1, 7] + "%\n\tDecimal equivalent:    " + GetDec(Convert.ToDouble(record[sn - 1, 7])).ToString() + "\n\tRemarks:   " + GetRem(Convert.ToDouble(record[sn - 1, 7])));
                    KeyR(); //pressing key R to return to the main and filtering other keys
                }
                if (op == 6) //code if user enter operation 6
                {
                    boolean2 = true;
                    Console.Clear(); //clearing screen
                    //printing module title and asking for student number
                    Console.Write("\n\tModule: Delete Student Record\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                    //calling the function to filter invalid data and not existing student number
                    StudentNumber("\n\tModule: Delete Student Record", "Invalid student number. Please try again.", "No record found record found. Please try again.");
                    Console.Write("\n\tRecord exists! Student Name: " + record[sn - 1, 1]); //printing student name
                    while (boolean2) //loop to filter other keys
                    {
                        Console.Write("\n\n\tPress D key to delete this record. Press R key to return to the main program.");
                        K = Console.ReadKey().Key;
                        if ((K == ConsoleKey.D) || (K == ConsoleKey.R))
                            boolean2 = false;
                        else
                            boolean2 = true;
                    }
                    if (K == ConsoleKey.D) //if user press D
                    {
                        for (i = 0; i < 10; i++) //code to delete
                            record[sn - 1, i] = "";
                        Console.Write("\n\tStudent information was deleted. Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear(); //clear screen 
                        boolean1 = true; //making boolean value true to return to the main
                    }
                    if (K == ConsoleKey.R) //if user press R
                    {
                        Console.Clear(); //clear screen 
                        boolean1 = true; //making boolean value true to return to the main
                    }
                }
                if (op == 7) //code if user enter operation 7
                {
                    boolean2 = true;
                    Console.Clear(); //clear screen 
                    //printing module title
                    Console.WriteLine("\n\tModule: List All Records\n\nSN\tName\t\t\tCourse/Year/Section\tEnrolled Subject Prelim\tMidterm\tFinal   Subject Dec.Grade\tRemarks");
                    for (i = 0; i < record.GetLength(0); i++) //loop to print all records
                    {
                        for (j = 0; j < record.GetLength(1); j++)
                        {
                            if ((j == 2) || (j == 8))
                                Console.Write(record[i, j] + "\t \t");
                            else if ((record[i, 0] != "") && (j >= 4) && (j <= 7))
                                Console.Write(record[i, j] + "%\t");
                            else if (j == 3)
                                Console.Write(record[i, j] + "\t ");
                            else
                                Console.Write(record[i, j] + "\t");
                        }
                        Console.WriteLine("");
                    }
                    KeyR(); //pressing key R to return to the main and filtering other keys
                }
                if (op == 8) //code if user enter operation 8
                {
                    boolean2 = true;
                    Console.Clear(); //clear screen
                    //displaying developer's info
                    Console.WriteLine("\n\tModule: Exit\n\n\tDeveloper's name:    Lester Dela Cruz\n\tEmail Addess:   " +
                        "lester010203@gmail.com\n\tContact number:  09461442578\n");
                    while (boolean2) //loop to filter invalid key and code to exit if E was press
                    {
                        Console.Write("\n\tPress E key to terminate the execution of the program.");
                        K = Console.ReadKey().Key;
                        if (K == ConsoleKey.E)
                            Environment.Exit(0);
                        else
                            boolean2 = true;
                    }
                }
            }
        }
        static void PrintPer() //function to print and read personal data
        {
            Console.Write("\n\tEnter last name:     ");
            lname = Console.ReadLine();
            Console.Write("\n\tEnter first name:    ");
            fname = Console.ReadLine();
            Console.Write("\n\tEnter middle name:   ");
            mname = Console.ReadLine();
            Console.Write("\n\tEnter course:    ");
            course = Console.ReadLine();
            Console.Write("\n\tEnter year level:    ");
            yr_level = Console.ReadLine();
            Console.Write("\n\tEnter section:    ");
            section = Console.ReadLine();
            Console.Write("\n\tEnter enrolled subject:    ");
            enrolled_subject = Console.ReadLine();
        }
        static void PrintSch() //function to print and read scholastic data
        {
            Console.Write("\n\n\tEnter prelim term grade(30%):    ");
            pgrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tEnter midterm grade(30%):    ");
            mgrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\tEnter final term grade(40%):    ");
            fgrade = Convert.ToDouble(Console.ReadLine());
        }
        static void StorePer(int a) //function to store personal data
        {
            record[a - 1, 0] = a.ToString();
            record[a - 1, 1] = fname + " " + mname + " " + lname;
            record[a - 1, 2] = course + " " + yr_level + "-" + section;
            record[a - 1, 3] = enrolled_subject;
        }
        static void StoreSch(int a) //function to store scholastic data
        {
            record[a - 1, 4] = pgrade.ToString();
            record[a - 1, 5] = mgrade.ToString();
            record[a - 1, 6] = fgrade.ToString();
            record[a - 1, 7] = sgrade.ToString();
            record[a - 1, 8] = dgrade.ToString();
            record[a - 1, 9] = remark;
        }
        static double GetSG(double a, double b, double c) //function to get the subject grade
        {
            sgrade = (a * 0.30) + (b * 0.30) + (c * 0.40);
            return sgrade;
        }
        static double GetDec(double a) //function to get the decimal grade
        {
            if ((a >= 0) && (a <= 74))
                dgrade = 5.00;
            if ((a >= 75) && (a <= 77))
                dgrade = 3.00;
            if ((a >= 78) && (a <= 80))
                dgrade = 2.75;
            if ((a >= 81) && (a <= 83))
                dgrade = 2.50;
            if ((a >= 84) && (a <= 86))
                dgrade = 2.25;
            if ((a >= 87) && (a <= 89))
                dgrade = 2.00;
            if ((a >= 90) && (a <= 92))
                dgrade = 1.75;
            if ((a >= 93) && (a <= 94))
                dgrade = 1.50;
            if ((a >= 95) && (a <= 97))
                dgrade = 1.25;
            if ((a >= 98) && (a <= 100))
                dgrade = 1.00;
            return dgrade;
        }
        static string GetRem(double a) //function to get the remark
        {
            string remark = "";
            if (a < 75)
                remark = "FAIL";
            else
                remark = "PASS";
            return remark;
        }
        static void StudentNumber(string a, string b, string c) //function to filter invalid student number
        {
            while ((sn < 1) || (sn > 10) || (record[sn - 1, 0] == ""))
            {
                if ((sn < 1) || (sn > 10))
                {
                    Console.Clear();
                    Console.Write(a + "\n\n\t" + b + "\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Clear();
                    Console.Write(a + "\n\n\t" + c + "\n\n\tEnter student number(1-10):  ");
                    sn = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static bool KeyYR(string a) //function to filter other keys and pressing Y or R to proceed
        {
            while (boolean2)
            {
                Console.Write("\n\tPress Y to save.Press R key to cancel and return to the main program.");
                K = Console.ReadKey().Key;
                if ((K == ConsoleKey.Y) || (K == ConsoleKey.R))
                    boolean2 = false;
                else
                    boolean2 = true;
            }
            if (K == ConsoleKey.Y)
            {
                Console.Write("\n\tStudent information was " + a + ". Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                boolean1 = true;
            }
            if (K == ConsoleKey.R)
            {
                Console.Clear();
                boolean1 = true;
            }
            return boolean1;
        }
        static void KeyR() //function to filter other keys and pressing R to return to the main
        {
            while (boolean2)
            {
                Console.Write("\n\n\tPress R to return to the main program.");
                K = Console.ReadKey().Key;
                if (K == ConsoleKey.R)
                {
                    boolean2 = false;
                    Console.Clear();
                    boolean1 = true;
                }
                else
                    boolean2 = true;
            }
        }
    }
}