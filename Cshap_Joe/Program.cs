
//Console.Write("World!");

//Console.WriteLine("Hello, World!");
//Console.WriteLine("World!");


//Console.WriteLine("JOE {0}", "HelloNaKub");
//Console.WriteLine("JOE {0}", "HelloNaKub",2001-20222);


/*int num1 = 0;
long num2 = 10;

Console.WriteLine("Number : {0} " , num1);
Console.WriteLine("Number : {0}", num2);
Console.WriteLine("$Number : {0}", num1);*/

/*int num1 = 2000;
string text = "asdasd";*/

/*char mychar = '1';
double mydouble = mychar;

Console.WriteLine(mydouble);*/

/*double d1 = 700;
int d2 = Console.ToInt32(d1); */

/*Console.Write("Nmu1:");
int Num1 = int.Parse(Console.ReadLine());

Console.Write("Nmu1:");
int Num2 = int.Parse(Console.ReadLine());


Console.WriteLine("$My Name :{Num1}" ); */ //ไม่ทัน


/*int num1 = 5;
int num2 = 10;

double num3 = 9.3; 

Console.WriteLine(Math.Round(num3)); */



/*int num1 = 5;
int num2 = 10;

double num3 = 9.3;

Console.WriteLine(Math.Round(num3));*/


/*Console.WriteLine("\nNo 1");
Console.Write("name1 : ");
string name1 = Console.ReadLine();
Console.WriteLine("name1 is : {0} ", name1);

Console.Write("weight : ");
double w1 = double.Parse(Console.ReadLine());
Console.WriteLine("Weight is : {0} ",w1);

Console.WriteLine("\nNo 2");
Console.Write("name2 : ");
string name2 = Console.ReadLine();
Console.WriteLine("name2 is : {0} ", name2);

Console.Write("weight : ");
double w2 = double.Parse(Console.ReadLine());
Console.WriteLine("Weight is : {0} ", w2); */


/*
        // รับข้อมูลคนที่ 1
        Console.WriteLine("No.1");
        Console.Write("name: ");
        string name1 = Console.ReadLine();
        Console.Write("weight (kg): ");
        double weight1 = double.Parse(Console.ReadLine());
        Console.Write("height (cm): ");
        double height1 = double.Parse(Console.ReadLine());

        // รับข้อมูลคนที่ 2
        Console.WriteLine("\nNo 2");
        Console.Write("name: ");
        string name2 = Console.ReadLine();
        Console.Write("weight (kg): ");
        double weight2 = double.Parse(Console.ReadLine());
        Console.Write("height (cm): ");
        double height2 = double.Parse(Console.ReadLine());

        // คำนวณค่า BMI สำหรับคนที่ 1
        double heightInMeter1 = height1 / 100; // แปลงเป็นเมตร
        double bmi1 = weight1 / (heightInMeter1 * heightInMeter1);

        // คำนวณค่า BMI สำหรับคนที่ 2
        double heightInMeter2 = height2 / 100; // แปลงเป็นเมตร
        double bmi2 = weight2 / (heightInMeter2 * heightInMeter2);

        // แสดงผลลัพธ์
        Console.WriteLine("\n Result");
        Console.WriteLine("name: " + name1.ToUpper());
        Console.WriteLine("BMI: " + Math.Round(bmi1, 2));

        Console.WriteLine("\nname: " + name2.ToUpper());
        Console.WriteLine("BMI: " + Math.Round(bmi2, 2));

        // ค้นหาค่า BMI ที่มากที่สุด
        double maxBmi = Math.Max(bmi1, bmi2);
        Console.WriteLine("\n Most BMI : " + Math.Round(maxBmi, 2)); */

/*double x = 7;
double y = 3;
Console.WriteLine(x % y); */

/*
float x = 7;
float y = 3;

Console.WriteLine(x / y);
Console.WriteLine(y % x);
float x1 = x++;
float y2 = ++x;

Console.WriteLine(x1);
Console.WriteLine(y2);*/

/*double x = 7;
Console.WriteLine(x=3);
 x = 7;
Console.WriteLine(x+=3);
x = 7;
Console.WriteLine(x -= 3);
x = 7;
Console.WriteLine(x *= 3);
x = 7;
Console.WriteLine(x /= 3);
x = 7;
Console.WriteLine(x %= 3); */


/*
string Role = "Joe";

if(Role == "Joe")
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} */


/*
string Role = "Joe";
switch (Role)
{
    case "Joe":
        Console.WriteLine("Yes");
        break;
    case "kk":
        Console.WriteLine("No");
        break;
    default:
        Console.WriteLine("YY");
        break;
}*/


/*Console.Write("Position: ");
string position = Console.ReadLine();
Console.Write("Salary: ");
float salary = float.Parse(Console.ReadLine());

if (position == "Assistant Developer")
{
    Console.WriteLine("เพิ่มเงินเดือน 5% {0}: " , salary2 = (salary  * 0.05 ));
}
else if(position == "IT Support")
{
    Console.WriteLine("$เพิ่มเงินเดือน 7% {0} : ", salary * 0.07);
}*/



//Console.Write("Your Position : ");
//string posit = Console.ReadLine();

//Console.Write("Your Salary : ");
//float salary = float.Parse(Console.ReadLine());

//if (posit == "Assintant Developer")
//{
//    salary = salary * 1.05f;
//    Console.WriteLine(Math.Round(salary));
//}
//else if (posit == "IT Support")
//{
//    float sal = (float)(salary * 0.1);
//    Console.WriteLine(salary + sal);
//}
//else if (posit == "Senior Developer")
//{
//    float sal = (float)(salary * 0.08);
//    Console.WriteLine(salary + sal);
//}
//else if (posit == "Administrator")
//{
//    float sal = (float)(salary * 0.03);
//    Console.WriteLine(salary + sal);
//}
//else
//{
//    float sal = (float)(salary * 0.03);
//    Console.WriteLine(salary + sal);
//}




/*
// รับข้อมูลตำแหน่งงานและเงินเดือน
Console.Write("Position: ");
string position = Console.ReadLine();
Console.Write("Salary: ");
float salary = float.Parse(Console.ReadLine());

// ตรวจสอบตำแหน่งงานและเพิ่มเงินเดือนตามเงื่อนไข
float increasedSalary = 0;
if (position == "Assistant Developer")
{
    increasedSalary = salary * 0.05f;
}
else if (position == "IT Support")
{
    increasedSalary = salary * 0.07f;
}
else if (position == "Senior Developer")
{
    increasedSalary = salary * 0.1f;
}
else if (position == "Administrator")
{
    increasedSalary = salary * 0.08f;
}
else
{
    increasedSalary = salary * 0.03f;
}

// แสดงผลลัพธ์
Console.WriteLine("Increased Salary: " + increasedSalary); */


/*
string Role = "Joe";

if(Role == "Joe")
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} */


//Loop

//while
//int num = 0;
//while (num <= 5){
//    ++num;
//    Console.WriteLine(num);
//}

//do while

//int num = 0;
//do
//{
//    ++num;
//    Console.WriteLine(num);

//} while (num <= 5);
//Console.WriteLine("Exit Loop");


//for
//int num = 0;
//for (int i = 0; i <= 5; i++)
//{
//    Console.WriteLine(i);
//}

//foreach
//string name = "kitiphop";
//foreach (char character in name)
//{
//    Console.WriteLine(character);
//}

//Array
//string[] cars = new string[] {"ford","toyota","lmbogini" };

//Array.Resize(ref cars, 4);
//cars[3] = "BMW";
//foreach (string car in cars)
//{
//    Console.WriteLine(cars);
//};

//Console.WriteLine("-----------------------------------");
//Array.Reverse(cars);

//foreach(string car in cars)
//{
//    Console.WriteLine(cars);
//};

//string[] cars2 = new string[4];
//Array.Copy(cars, cars2, 3);
//foreach (string car in cars2)
//{
//    Console.WriteLine(car);
//}

//Console.WriteLine("-----------------------------------");
//Console.WriteLine(Array.IndexOf(cars2 , "ford"));

//Console.WriteLine("-----------------------------------");


//List

//Set
//HashSet<int> SetOfNumber1 = new HashSet<int>();
//SetOfNumber1.Add(50);
//SetOfNumber1.Add(100);
//SetOfNumber1.Add(150);

//HashSet<int> SetOfNumber2 = new HashSet<int>();
//SetOfNumber2.Add(50);
//SetOfNumber2.Add(100);
//SetOfNumber2.Add(150);

//foreach (int i in SetOfNumber1)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("-------------------------------");

//foreach (int i in SetOfNumber2)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(SetOfNumber1.Count);
//Console.WriteLine(SetOfNumber2.Count);

//Console.WriteLine("-------------------------------");

//SetOfNumber1.ExceptWith(SetOfNumber2);

//foreach (int i in SetOfNumber1)
//{
//    Console.WriteLine(i);
//}


//Dictionary

//Dictionary<string,int> citiesPopulation = new Dictionary<string,int>();

//citiesPopulation.Add("Bangkok", 1000000);
//citiesPopulation.Add("pattaya", 500000);

////Console.WriteLine(citiesPopulation["Bangkok"]);
//int num = 0;
//if (citiesPopulation.TryGetValue("Bangkok", out num))
//{
//    Console.WriteLine(num);
//}
//else
//{
//    Console.WriteLine(num);
//}

//foreach (KeyValuePair<string,int> number in citiesPopulation)
//{
//    Console.WriteLine(number.Key);
//}


//lap3


//int num = 0;
//while (num <= 1)
//{
//    ++num;
//    //Console.WriteLine(num);
//    //Console.WriteLine("--------------------");
//    Console.WriteLine("Number 0f Student? : 2");

//    Console.WriteLine("--------------------");
//    Console.Write("Student : ");
//    string Student = Console.ReadLine();

//    Console.Write("Score : ");
//    float Score = float.Parse(Console.ReadLine());

//    Console.Write("Student Id : {0} Score is {1}", Student, Score);
//}

//Console.Write("Number 0f Student? :");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("--------------------");

//for (int i = 0; i < num; i++)
//{
//    Console.Write("Student : ");
//    string Student = Console.ReadLine();

//    Console.Write("Score : ");
//    float Score = float.Parse(Console.ReadLine());

//    Console.WriteLine("Student Id : {0} Score is {1}", Student, Score);
//}


//string exitChoice = "";
//while (exitChoice != "Y")
//{
//    if (exitChoice == "y")
//    {

//    }

//}


//Console.Write("Enter the number of students: ");
//int numberOfStudents = int.Parse(Console.ReadLine());

//int maxScore = int.MinValue;  // คะแนนสูงสุด
//int minScore = int.MaxValue;  // คะแนนต่ำสุด

//for (int i = 0; i < numberOfStudents; i++)
//{
//    Console.Write("\nEnter student ID: ");
//    string studentID = Console.ReadLine();

//    Console.Write("Enter student score: ");
//    int studentScore = int.Parse(Console.ReadLine());

//    Console.WriteLine("Student ID: " + studentID);
//    Console.WriteLine("Student Score: " + studentScore);

//    // หาคะแนนสูงสุดและต่ำสุด
//    maxScore = Math.Max(maxScore, studentScore);
//    minScore = Math.Min(minScore, studentScore);
//}

//string exitChoice = "";
//while (exitChoice != "Y")
//{
//    Console.Write("Exit? (Y/N): ");
//    exitChoice = Console.ReadLine().ToUpper();
//}

//Console.WriteLine("Number of Students: " + numberOfStudents);
//Console.WriteLine("Max Score: " + maxScore);
//Console.WriteLine("Min Score: " + minScore);

//int num = 0;
//do
//{
//    ++num;
//    Console.WriteLine(num);

//} while (num <= 5);
//Console.WriteLine("Exit Loop");


////while
//int num = 0;
//while (num <= 5)
//{
//    ++num;
//    Console.WriteLine(num);
//}

//Class
//class person
//{
//    private string name;
//    private int age;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        person P1 = new person();
//        P1.Name = "Jet";
//        P1.Age = 22;

//        Console.WriteLine(P1.Name);
//        Console.WriteLine(P1.Age);

//        Console.WriteLine("------------------");

//        person P2 = new person();
//        P2.Name = "Jojo";
//        P2.Age = 22;

//        Console.WriteLine(P2.Name);
//        Console.WriteLine(P2.Age);
//    }
//}

//class person
//{
//    private string name;
//    private int age;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        person P1 = new person();
//        P1.Name = "Jet";
//        P1.Age = 22;

//        Console.WriteLine(P1.Name);
//        Console.WriteLine(P1.Age);

//        Console.WriteLine("------------------");

//        person P2 = new person();
//        P2.Name = "Jojo";
//        P2.Age = 22;

//        Console.WriteLine(P2.Name);
//        Console.WriteLine(P2.Age);
//    }
//}

//using static Joe;

//class Joe
//{
//    public string name;
//    public int age;

//    public string Name { get { return name; } set { name = value; } }
//    public int Age { get { return age; } set { age = value; } }

//    public class jojo : Joe 
//    {
//       public jojo(string name , int age)
//        {
//            Name = name;
//            Age = age;
//        }
//        public override string ISplayName()
//        {
//                return name;
//            } 
//        }
//    }
//}
//public class Program
//{
//    public static void main()
//    {
//        jojo J = new jojo ("Kitiphop",18);
//    }
//}



class Human
{
    public int age;
    public string name;
    public string nickname;

    public int Age { get { return age; } set { age = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string NickName { get { return nickname; } set { nickname = value; } }
    public virtual int MyAge()
    {
        return age;
    }
    public virtual string MyName()
    {
        return name;
    }
    public virtual string MyNickName()
    {
        return nickname;
    }
}


internal class jojo : Human
{
    public jojo(int age, string name , string nickname)
    {
        Age = age;
        Name = name;
        NickName = nickname;
    }
    public override int MyAge()
    {
        return age;
    }
    public override string MyName()
    {
        return Name;
    }
    public override string MyNickName()
    {
        return NickName;
    }
}

public class Program
{
    public static void Main()
    {
        jojo jojo = new jojo(18, "Kitiphop" , "Joe");

        string name = jojo.Name;
        string nickname = jojo.NickName;
        int age = jojo.age;

        Console.WriteLine($"Name :  { name} ");
        Console.WriteLine($"NickName :  {nickname} ");
        Console.WriteLine($"Age :  {age} ");
    }
}




