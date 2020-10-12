using System;
using System.Text;
namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student("Вася", "Пупкин");
            Console.WriteLine("Метод ToString() : " + st1.ToString());
            Console.WriteLine("Метод Equals(st1) = :" + st2.Equals(st1));
            Console.WriteLine("Метод GetHashCode() = :" + st1.GetHashCode());
            st1.Info();
            st2.Info();

            var AnonimousStudent = new { name = "Иван", surname = "Иванов", dateOfBirth = "04072002", address = "Dormitory", phone = 375448392, faculty = "FIT", course = 2, group = 10 };
            Console.WriteLine(AnonimousStudent.name);
            Console.WriteLine(AnonimousStudent.surname);

            Console.WriteLine("Введите количество студентов: ");
            int countOfSt = Convert.ToInt32(Console.ReadLine());
            Student[] st = new Student[countOfSt];
            for (int i = 0; i < countOfSt; i++)
            {
                Console.WriteLine($"{i + 1}-й студент:");
                st[i] = new Student();
            }

            Console.WriteLine("Список студентов факультета: ");
            string faculty = Console.ReadLine();
            foreach (Student stlist in st)
            {
                if (stlist.Faculty == faculty)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Имя : {stlist.Name}");
                    Console.WriteLine($"Фамилия : {stlist.Surname}");
                    Console.WriteLine($"Дата рождения : {stlist.DateOfBirth}");
                    Console.WriteLine($"Адрес : {stlist.Address}");
                    Console.WriteLine($"Номер телефона : {stlist.Phone}");
                    Console.WriteLine($"Факультет : {stlist.Faculty}");
                    Console.WriteLine($"Номер курса : {stlist.Course}");
                    Console.WriteLine($"Номер группы : {stlist.Group}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Список студентов группы: ");
            int group = Convert.ToInt32(Console.ReadLine());
            foreach (Student stlist in st)
            {
                if (stlist.Group == group)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Имя : {stlist.Name}");
                    Console.WriteLine($"Фамилия : {stlist.Surname}");
                    Console.WriteLine($"Дата рождения : {stlist.DateOfBirth}");
                    Console.WriteLine($"Адрес : {stlist.Address}");
                    Console.WriteLine($"Номер телефона : {stlist.Phone}");
                    Console.WriteLine($"Факультет : {stlist.Faculty}");
                    Console.WriteLine($"Номер курса : {stlist.Course}");
                    Console.WriteLine($"Номер группы : {stlist.Group}");
                }
            }

            Console.WriteLine("Количество студентов: {0}", Student.NumOfStudents);
            Student.InfoAboutClass();
        }
    }
    partial class Student
    {
        static int numOfStudents;
        public readonly int id;
        string name;
        string surname;
        string dateOfBirth;
        string address;
        int phone;
        string faculty;
        int course;
        int group;
        static public int NumOfStudents
        {
            get
            {
                return numOfStudents;
            }
            set
            {
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Пустое имя недопустимо");
                }
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Пустая фамилия недопустима");
                }
                surname = value;
            }
        }
        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Пустая дата рождения недопустима");
                }
                dateOfBirth = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Пустой адрес недопустим");
                }
                address = value;
            }
        }
        public int Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Пустой или отрицательный номер телефона недопустим");
                }
                phone = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Пустое название факультета недопустимо");
                }
                faculty = value;
            }
        }
        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Пустой или отрицательный номер курса недопустим");
                }
                course = value;
            }
        }
        public int Group
        {
            get
            {
                return group;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Пустой или отрицательный номер группы недопустим");
                }
                group = value;
            }
        }
        static Student()
        {
            Console.WriteLine("Статический конструктор выполнился");
        }
        public Student()
        {
            numOfStudents++;
            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения");
            DateOfBirth = Console.ReadLine();
            Console.WriteLine("Введите адрес:");
            Address = Console.ReadLine();
            Console.WriteLine("Введите номер телефона:");
            Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название факультета:");
            Faculty = Console.ReadLine();
            Console.WriteLine("Введите номер курса:");
            Course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер группы:");
            Group = Convert.ToInt32(Console.ReadLine());
            id = Phone + Course + Group;
            if (id < 1)
            {
                throw new ArgumentNullException("Пустой или отрицательный идентификатор недопустим");
            }
        }
        public Student(string nameparam = "Default", string surnameparam = "Default", string dateOfBirthparam = "01012020", string addressparam = "Dormitory", int phoneparam = 1, string facultyparam = "FIT", int courseparam = 2, int groupparam = 10)
        {
            numOfStudents++; 
            Name = nameparam;
            Surname = surnameparam;
            DateOfBirth = dateOfBirthparam;
            Address = addressparam;
            Phone = phoneparam;
            Faculty = facultyparam;
            Course = courseparam;
            Group = groupparam;
            id = Phone + Course + Group;
            if (id < 1)
            {
                throw new ArgumentNullException("Пустой или отрицательный идентификатор недопустим");
            }
        }
        public void Info()
        {
            Console.WriteLine("Идентификатор: {0}", id);
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Фамилия: {0}", Surname);
            Console.WriteLine("Дата рождения: {0}", DateOfBirth);
            Console.WriteLine("Адрес: {0}", Address);
            Console.WriteLine("Номер телефона: {0}", Phone);
            Console.WriteLine("Факультет: {0}", Faculty);
            Console.WriteLine("Номер курса: {0}", Course);
            Console.WriteLine("Номер группы: {0}", Group);
            Console.Write("Возраст: ");
            Age();
        }
        public void Age()
        {
            int year = Convert.ToInt32(DateOfBirth.Substring(4, 4));
            int month = Convert.ToInt32(DateOfBirth.Substring(2, 2));
            int date = Convert.ToInt32(DateOfBirth.Substring(0, 2));
            DateTime bDay = new DateTime(year, month, date);
            DateTime now = DateTime.Today;
            int age = now.Year - bDay.Year;
            if (bDay > now.AddYears(-age))
                age--;
            Console.WriteLine(age);
        }
        static public void InfoAboutClass()
        {
            Console.WriteLine("В этом классе хранится информация о студентах");
        }
    }
}