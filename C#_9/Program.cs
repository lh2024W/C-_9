using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Numerics;

namespace C__9
{
    class Student
    {
        public string firstname;//имя
        public string secondname;//отчество
        public string lastname;//фамилия
        public string birthday;//дата рождения
        public string address;//домашний адрес
        public string phone;//телефон
        List<int> Tests;//зачеты
        List<int> TermPapers;//курсовые работы
        List<int> Exams;//экзамены

        public Student() : this(10, 11, 11)
        {
            //Console.WriteLine("C-tor without params");
        }

        public Student(int test, int term, int exam) : this("Иван", "Иванович", "Иванов", "12.01.2003", 
            "г.Одесса ул.Пушкинская 10", "069635422", 12, 12, 12)
        {
            Tests = new List<int>();
            SetTests(test);
            TermPapers = new List<int>();
            SetTermPapers(term);
            Exams = new List<int>();
            SetExams(exam);

            //Console.WriteLine("C-tor with params");
        }

        public Student(string firstname, string secondname, string lastname, string birthday, string address, string phone,
            int test, int term, int exam)//main c-tor
        {
            SetFirstname(firstname);
            SetSecondname(secondname);
            SetLastname(lastname);
            SetBirthday(birthday);
            SetAddress(address);
            SetPhone(phone);
            Tests = new List<int>();
            SetTests(test);
            TermPapers = new List<int>();
            SetTermPapers(term);
            Exams = new List<int>();
            SetExams(exam);

            //Console.WriteLine("Main c-tor");
        }

        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public void SetSecondname(string secondname)
        {
            this.secondname = secondname;
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void SetBirthday(string birthday)
        {
            this.birthday = birthday;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetTests(int test)
        {
            Tests.Add(test);
        }

        public void SetTermPapers(int term)
        {
            TermPapers.Add(term);
        }

        public void SetExams(int exam)
        {
            Exams.Add(exam);
        }

        public string GetFirstname()
        {
            return firstname != null ? firstname : "Не задано";
        }

        public string GetSecondname()
        {
            return secondname != null ? secondname : "Не задано";
        }

        public string GetLastname()
        {
            return lastname != null ? lastname : "Не задано";
        }

        public string GetBirthday()
        {
            return birthday != null ? birthday : "Не задано";
        }

        public string GetAddress()
        {
            return address != null ? address : "Не задано";
        }

        public string GetPhone()
        {
            return phone != null ? phone : "Не задано";
        }

        public List<int> GetTests()
        {
            return Tests;
        }

        public List<int> GetTermPapers()
        {
            return TermPapers;
        }

        public List<int> GetExams()
        {
            return Exams;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Имя: " + GetFirstname());
            Console.WriteLine("Отчество: " + GetSecondname());
            Console.WriteLine("Фамилия: " + GetLastname());
            Console.WriteLine("Дата рождения: " + GetBirthday());
            Console.WriteLine("Адрес проживания: " + GetAddress());
            Console.WriteLine("Телефон: " + GetPhone());
            foreach (int test in Tests)
            {
                Console.WriteLine("Оценки за зачеты: " + test);
            }
            foreach (int term in TermPapers)
            {
                Console.WriteLine("Оценки за зачеты: " + term);
            }
            foreach (int exam in Exams)
            {
                Console.WriteLine("Оценки за зачеты: " + exam);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return firstname + " " + secondname + " " + lastname + " " + birthday + " " + address + " " + phone + " " + 
                Tests + " " +  TermPapers + " " + Exams + " ";
        }

        public virtual void Study()
        {
            Console.WriteLine("Студент: " + firstname + " " + secondname + " " + lastname);
            Console.WriteLine("Учится!");
            Console.WriteLine("Его оценки: ");
            foreach (int test in Tests)
            {
                Console.WriteLine("Оценки за зачеты: " + test);
            }
            foreach (int term in TermPapers)
            {
                Console.WriteLine("Оценки за зачеты: " + term);
            }
            foreach (int exam in Exams)
            {
                Console.WriteLine("Оценки за зачеты: " + exam);
            }            
        }

        public virtual void TakeExam()
        {
            Console.WriteLine("Студент: " + firstname + " " + secondname + " " + lastname);
            Console.WriteLine("Сдал экзамен!");
            Console.WriteLine("Его оценка: ");
            foreach (int exam in Exams)
            {
                Console.WriteLine("Оценки за зачеты: " + exam);
            }
            Console.WriteLine();
        }
    }
    class Aspirant : Student
    {
        public string ThesisTheme { get; set; }// тема дисертации

        public Aspirant() 
        {
            ThesisTheme = "Полиморфизм в ООП";
        }

        public Aspirant(string firstname, string secondname, string lastname, string birthday, string address, string phone, 
            int test, int term, int exam, string theme) : base (firstname, secondname, lastname, birthday, address, phone,
                test, term, exam)
        {
            ThesisTheme = theme;
        }

        void DoEnternship() //пройти стажировку
        {
            Console.WriteLine("Аспирант проходит стажировку!");
        }

        void DefendThesis() // защитить диссертацию
        {
            Console.WriteLine("Аспирант защищает дессертацию!");
        }

        public override void Study()
        {
            Console.WriteLine("Аспирант: ");
            base.Study();
            Console.WriteLine("Тема дисертации: " + ThesisTheme);
            Console.WriteLine("\n\n");
        }

        public override void TakeExam()
        {
            Console.WriteLine("Аспирант: ");
            base.TakeExam();
            Console.WriteLine("Тема дисертации: " + ThesisTheme);
            Console.WriteLine("\n\n");
        }

        public override void GetInfo()
        {
            Console.WriteLine("Аспирант: ");
            base.GetInfo();
            Console.WriteLine("Тема дисертации: " + ThesisTheme);
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student s = new();
            s.GetInfo();
            Student s2 = new Student(9, 9, 9);
            s2.GetInfo();
            Student s3 = new Student("Василий", "Васильевич", "Пупкин", "01.01.1999", "г. Киев", "32536654", 12, 12, 12);
            s3.GetInfo();
            Aspirant a = new ();
            Aspirant b = new ("Василий", "Николаевич","Коваленко", "01.02.2010", "г.Днепропетровск, ул. Травнева 14", "0986355988", 10, 11, 12, "Сети и кибербезопасность" );
            a.GetInfo();
            a.Study();
            a.TakeExam();
            b.GetInfo();
        }
    }
}
