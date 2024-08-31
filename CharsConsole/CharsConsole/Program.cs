using System.Collections;
using System.Data.SqlTypes;
using System.Numerics;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using CharsConsole;
using System.Net.Http.Headers;

internal static class Program
{
    //constant variable on program running: readonly
    //readonly data should be static, the class and the constructor that contains readonly data should also be static
    static readonly double PI;
    static readonly int PRICE3 = PRICE4 * 2;
    static readonly int PRICE4 = 333;

    static Program() {
        PI = 3.14159;
    }


    //delegate class
    public delegate int DelegateClass(int x, int y);
    delegate void DelegateOutput(String s);

    static void namedFunction(string s1)
    { 
        Console.WriteLine(s1);
    }

    private static void Main(string[] args)
    {

        //Console1 - defineAVariable();

        //Console2 - stringObject();

        //===== Console3 - Refence example =====
        //Consume consume = new Consume();
        //consume.Record();
        //Console.Read();

        //===== Console4 - Difference between value type and reference type  =====
        //RefAndValue.Example();
        //Console.Read();


        //========Console5 - Enumeration=======
        //Console.WriteLine(ProgramLang.CS);
        //Console.WriteLine((int)ProgramLang.CS);
        //Console.ReadLine();

        //Console6 - convertType();

        //Console7 - constantTest();

        //Console8 - operators();

        //Console9 - charAndString();

        //stringFormat();

        //cutString();

        //editString();

        //Console10 - changableString();

        //Console11 - skipExpression();

        //Console12 - arrays();

        //arrayListTest();

        //Console13 - hash();

        //====Console14 - attribute======
        //Student student = new Student();
        //student.Age = -2;
        //Console.WriteLine(student.Age);


        //========Console15 - Linq==========
        //use var to create implicit local variable
        //linqVarImplicit();

        //Lambda expression
        //linqLambda();

        //linqQuery();

        //Console15LinqDataSet linqDataSet = new Console15LinqDataSet();
        //linqDataSet.checkScore();

        //Console16 - Exception
        //Console16Exception console16Exception = new Console16Exception();
        //console16Exception.tryCatch();

        //Console.WriteLine("Input 2 numbers: ");
        //String str1 = Console.ReadLine(); 
        //String str2 = Console.ReadLine(); 
        //console16Exception.divideByZero(str1,str2);

        //console16Exception.finallyExpression();


        //Console17 - OOP
        /*DerivedClass derivedClass = new DerivedClass();
        Console17OOP oopClass = derivedClass;
        derivedClass.ID = "01";
        derivedClass.Name = "ZWT";
        derivedClass.DisplayInfo();*/

        /*MyClass myClass = new MyClass();
        IMyInterface myInterface = myClass;
        myInterface.ID = "1";
        myInterface.Name = "ZWT";
        myInterface.DisplayInfo();*/

        /*MultiDerived multiDerived = new MultiDerived();
        ITeaher teacher = multiDerived;
        teacher.Name = "ZWT";
        teacher.Gender = "Female";
        teacher.teach();

        IStudent student = multiDerived;
        student.Name = "HWH";
        student.Gender = "Male";
        student.study();*/

        /*ExplicitImpl explicitImpl = new ExplicitImpl();
        IExplicitImpl1 explicitImpl1 = explicitImpl;
        Console.WriteLine(explicitImpl1.Add());
        IExplicitImpl2 explicitImpl2 = explicitImpl;
        Console.WriteLine(explicitImpl2.Add());
        */

        /*
         SealedClass sealedClass = new SealedClass();
         sealedClass.ID = "1";
         sealedClass.Name = "ZWT";
         sealedClass.displayInfomation();
        */

        //Delegate
        /*
        DelagateTest delagateTest = new DelagateTest();
        DelegateClass delegateClass = delagateTest.Add;
        int sum = delegateClass(1, 1);
        Console.WriteLine(sum.ToString());
        */

        //The reference of delegate point to the anonymous function delegate(string s2)
        /*DelegateOutput delegateOutput = delegate (string s2)
        {
            Console.WriteLine(s2);
        };
        delegateOutput.Invoke("Anonymous function is called");//delegate object call the anonymous function
        delegateOutput("Anonymous function is called in another way");
        delegateOutput = namedFunction;//delegate object is binded to namedFunction
        delegateOutput("nameFunction is called");//delegate object call 
        */

        /*
        SchoolRing schoolRing = new SchoolRing();
        Students students = new Students();
        students.subscribeToRing(schoolRing);
        Console.WriteLine("Ring type: 1. Class begins 2.Class is over");
        students.ringing(Convert.ToInt32(Console.ReadLine()));
        students.cancelSubscribe(schoolRing);
        */

        /*
        Rectangle rectangle = new Rectangle();
        IRectangle iRectangle = rectangle;
        iRectangle.Width = 5;
        iRectangle.Height = 3;
        Console.WriteLine("Area is: "+iRectangle.Area());
        */

        /* 
         Circle circle = new Circle();
         AbsCircle absCircle = circle;
         absCircle.Radius = 2;
         Console.WriteLine("Area is " + absCircle.Area());
        */

        //Generic interface
        //IGenericInterface<System.ComponentModel.IListSource> factory = new Factory<System.Data.DataTable, System.ComponentModel.IListSource>();
        //Console.WriteLine(factory.CreateInstance().GetType().ToString());
        
        //int i = Finder.checkItems<int>(new int[] { 1, 2, 3, 4, 5, 6, 8, 9 }, 1);
        //Console.WriteLine("The index of 1 "+i.ToString());

        //GenericClass1<int> genericClass = new GenericClass1<int>();
        //GenericClass2<int> genericClass2 = new GenericClass2<int>();

        //Chat 
        //Console18ChatClient client = new Console18ChatClient();
        //client.receiveMessage();

        //=======Thread Priority========
        Console19Thread console19Thread = new Console19Thread();
        //console19Thread.setPriority();
        //console19Thread.threadLock();
        //console19Thread.threadLock1();
        //console19Thread.threadLock2();
        console19Thread.startConnection();
        Console.ReadLine();
        console19Thread.insertData();

        //======Functions=========
        void inputOutput()
        {
            Console.WriteLine("Wen Ting Zha");
            Console.ReadLine();
        }

        void defineAVariable()
        {
            int money = 200;
            int money1;
            int money2, money3, money4;

            Console.WriteLine("Welcome to ZhaConsole");
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("User:" + name);
        }

        void objectClass()
        {
            //Reference
            object obj = 1;
            object o1 = "zhawenting";
            Console.WriteLine(obj);
            Console.WriteLine(o1);
        }

        void stringObject()
        {
            //string object is immutable
            string str1 = "C#";
            string str2 = str1;
            Console.WriteLine("str1:" + str1);
            Console.WriteLine("str2:" + str2);
            //The following sentence is trying to create a new object in the memory
            //str1 point to the new object
            //Three objects in the memory actually
            str1 = "ASP.NET";
            Console.WriteLine("str1:" + str1);
            Console.WriteLine("str2:" + str2);
        }

        void convertType() 
        {
            //long l = 30000000000;
            //int i = (int)l;
            //Console.WriteLine(i);
            //int j = Convert.ToInt32(l);
            //Console.WriteLine(j);

            //data boxing: value to reference
            //stack: i=10 obj=i
            //heap: object to int, through implicit convert
            int i = 10;
            object obj = i;
            Console.WriteLine(obj);

            //data unboxing: reference to value, through explicit convert
            int j = (int)obj;

            
        }
        
        void constantTest()
        {
            //constant variable on program building: const

            const int PRICE1 = 111;
            const int PRICE2 = PRICE1 * 2;

            Console.WriteLine("const price1:"+PRICE1);
            Console.WriteLine("const price2:"+PRICE2);
            Console.WriteLine("readonly price3:"+PRICE3);
            Console.WriteLine("readonly price4:"+PRICE4);

            
            const double PI = 3.1415;
            double R;
            Console.WriteLine("Please enter the radius:");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area:"+PI*R*R);
        }


        void operators()
        {
            int age = 35;
            Console.WriteLine("ZWT's age after 5 years: " + (age += 5));

            int num = 368;
            Console.WriteLine(num << 2);
            Console.WriteLine(num >> 2);


            Console.WriteLine(num > 1? "Yes":"No");

            int num1 = 400;
            int num2 = 500;
            int num3 = 600;
            int result = num > num1 ? num2 : num3 > num2 ? num3 : num2;
            Console.WriteLine(result);

            Console.WriteLine("Please enter the password:");
            int pwd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the key:");
            int key = Convert.ToInt32(Console.ReadLine());
            int pwdkey = pwd ^ key;
            Console.WriteLine("encryopted password: "+pwdkey);


        }

        void charAndString()
        {
            char[] ch = { 'C', 'H', 'A', 'R' };
            string str1 = new string(ch);
            string str2 = new string(ch,0,3);
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            Console.WriteLine(string.Compare(str1, str2));
            Console.WriteLine(string.Compare(str2, str1));
            string str3 = "mr";
            string str4 = "MR";
            Console.WriteLine(string.Compare(str3,str4,true));
            Console.WriteLine(str3.CompareTo(str4));
            
            
        }

        void stringFormat()
        {
            Console.WriteLine("Dollars");
            Console.WriteLine(string.Format("HKD: {0:C}", 1));
            Console.WriteLine(string.Format("HKD: {0:C0}", 1));
            Console.WriteLine(string.Format("Scientific: {0:E}", 120000.1));
            Console.WriteLine(string.Format("Divide: {0:N}", 123456789));
            Console.WriteLine(string.Format("Two decimal: {0:F2}", Math.PI));
            Console.WriteLine(string.Format("Dex: {0:X}", 11));
            Console.WriteLine(string.Format("Percentage: {0:P}", 0.1));
            int i = 17;
            Console.WriteLine(i.ToString("C"));

            Console.WriteLine("Date time");
            DateTime strDate = DateTime.Now;
            Console.WriteLine(string.Format("Short date format: {0:d}",strDate));
            Console.WriteLine(string.Format("Long date format: {0:D}",strDate));
            Console.WriteLine(string.Format("Full date format: {0:f}",strDate));
            Console.WriteLine(string.Format("Short time format: {0:t}",strDate));
            Console.WriteLine(string.Format("Long time format: {0:T}", strDate));
            Console.WriteLine(string.Format("Month Day format: {0:M}", strDate));
            Console.WriteLine(string.Format("Year Month format: {0:Y}", strDate));
            Console.WriteLine(strDate.ToString("Y"));

        }
        
        void cutString()
        {
            string fileName = "Program.cs";
            string strName = fileName.Substring(0, fileName.IndexOf('.'));
            string strExtension = fileName.Substring(fileName.IndexOf("."));
            Console.WriteLine($"file22Name: {strName}");
            Console.WriteLine($"Extension: {strExtension}");

            //Example to devide a serial of email addresses
            string ip = "abc@gmail.com;123@yahoo.com;a1@hk.com";
            string[] strs = ip.Split(new char[] { ';' });
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }

        void editString()
        {
            string strOld = "Keep on never give up";
            string strNew = strOld.Insert(8, "going ");
            Console.WriteLine("strNew:" + strNew);

            string str1 = strNew.Remove(7);
            string str2 = strNew.Remove(7, 6);
            Console.WriteLine("str1:"+str1);
            Console.WriteLine("str2:" + str2);

            string str3 = string.Copy(strNew);
            Console.WriteLine("str3:"+str3);

            char[] charString = new char[4];
            strNew.CopyTo(strNew.IndexOf("never"), charString, 0, 4);
            Console.WriteLine(charString);

            string str4 = strOld.Replace("never give","giving");
            Console.WriteLine("str4: "+ str4);
        }
        
        void changableString() 
        {   
            //when you use "+" operator on string, a new string object will be crteated in the heap and stack
            //When you user append on StringBuilder, the same object will be edited.
            //Puzzle: fill the blank
            //namespace: using System.Text;
            StringBuilder stringBuilder = new StringBuilder("(),(),(),8,10,12");
            Console.WriteLine(stringBuilder);
            stringBuilder.Remove(0, 9);
            stringBuilder.Insert(0, "(2),(4),(6),");
            Console.WriteLine(stringBuilder);


            string str = "";
            long startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++) 
            {
                str += i;
            }
            long endTime = DateTime.Now.Millisecond;
            long time = endTime - startTime;
            Console.WriteLine("time of string operation:"+ time);

            StringBuilder stringbuildier = new StringBuilder();
            startTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            { 
                stringBuilder.Append(i);
            }
            endTime = DateTime.Now.Millisecond; 
            time = endTime - startTime;
            Console.WriteLine("time of stringBuilder operation:" + time);
        }

        void foreachExpression() 
        {
            string[] strNames = { "Shoppping management", "Sales management", "Store management", "System management" };
            foreach (string str in strNames) 
            {
                Console.WriteLine(str);
            }
        }

        void skipExpression()
        {
            //Continue
            int i;
            int sum = 0;
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                { 
                    continue;//Skip the following sentences and continue with the next loop
                }
                sum += 1;
            }
            Console.WriteLine(sum);

            //Goto
            int i1 = 0, sum1 = 0;
            label:
                i1++;
                sum1 += i1;
            if (i1 < 100)
            { 
                goto label;
            }
            Console.WriteLine(sum1);
        }


        void arrays()
        {

            //One-dimension array
            int[] arr = new int[12] { 31, 28, 31, 39, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] arr1 = { 1, 2 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("month " + (i + 1) + ": " + arr[i] + " days");
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            //Two-dimension array
            int[,] array = new int[2, 2];
            array[0, 0] = 1;
            array[0, 1] = 1;
            array[1, 0] = 1;
            array[1, 1] = 1;

            int[][] array1 = new int[2][];
            array1[0] = new int[] { 0, 1 };
            array1[1] = new int[] { 1, 2 };

            int[,] array2 = new int[2, 2] { { 12, 0 }, { 1, 15 } };
            int[,] array3 = new int[,] { { 12, 0 }, { 1, 15 } };
            int[,] array4 = { { 12, 0 }, { 1, 15 } };

            for (int i = 0; i < array4.Length; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.Write(array4[i, j] + " ");
                }
                Console.WriteLine();
            }

        }


        void arrayListTest()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            ArrayList arrayList = new ArrayList(arr);
            Console.WriteLine("Original array list:");
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            for (int i = 1; i < 5; i++)
            {
                arrayList.Add(i+arr.Length);
            }
            Console.WriteLine("Add element to array list:");
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            arrayList.Insert(6, 6);
            Console.WriteLine("Insert element to array list:");
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Contains 1? "+arrayList.Contains(1));
        }

        void hash() 
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", "ZWT001");
            hashtable.Add("name", "ZWT");
            hashtable.Add("gender", "Male");
            Console.WriteLine(hashtable.ContainsValue("id"));
        }

        void linqVarImplicit() 
        {
            string[] strWords = { "ZWT", "Programmer", "Teacher" };
            var changeWord = from word in strWords
                             select new { Upper = word.ToUpper(), Lower = word.ToLower() };
            foreach (var cword in changeWord)
            {
                Console.WriteLine("Upper:{0},Lower:{1}", cword.Upper, cword.Lower);
            }
            Console.ReadLine();
        }

        void linqLambda()
        {
            string[] strLists = new string[] { "Technique", "C#", "Java", "CPP" };
            string[] strList = Array.FindAll(strLists, s => (s.IndexOf("C#") >= 0));
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
        }

        void linqQuery()
        {

            string[] strName = new string[] { "Technique", "C#", "Java", "CPP" };
            IEnumerable<string> selectQuery = 
                from Name in strName
                where Name.Length < 7
                select Name;
            foreach (string str in selectQuery)
            {
                Console.WriteLine(str);
            }
        }

    }
    //===== Refence example =====
  

    class Card
    {
        public string Debit { get; set; }
  
    }

    class Consume { 
        public void Record() {
            Console.WriteLine("Visa consume record:");
            //Main Card
            Card pCard = new Card() { Debit = "10000" };
            Console.WriteLine("Total debit:" + pCard.Debit);
            //Secondary Card
            Card sCard = pCard;
            sCard.Debit = "3000";
            Console.WriteLine("Consume record:" + pCard.Debit);


        }
    }

    //===== Difference between value type and reference type  =====

    class VIP
    { 
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static class RefAndValue
    {
        public static void Example()
        {
            VIP vip1 = new VIP() { Name = "ZhaWenTing", Age = 35 };
            VIP vip2 = new VIP() { Name = "GLZ", Age = 57 };
            int age = vip1.Age;
            vip1.Age = 36;

            VIP vip3 = vip2;
            vip2.Name = "GuLZ";

            Console.WriteLine($"Vip1:{vip1.Name} {vip1.Age}");
            Console.WriteLine($"age:{age}");
            Console.WriteLine($"Vip2:{vip2.Name} {vip2.Age}");
            Console.WriteLine($"Vip3:{vip3.Name} {vip3.Age}");
        }
    }

    //========Enumeration=======
    public enum ProgramLang
    { 
        C=1,
        Java=2,
        CS=3
    }

    //=======OOP: Attribute=======
    //If Age has the only function get, this attribute is read only
    //This feature can be used to pretect sensitive data
    class Student
    {
        //destuctor
        ~Student()
        {
            Console.WriteLine("Call the destructor");
        }

        private string name;
        private int age;

        public int Age 
        { 
            get { return age; }    
            
            set 
            {
                if (value > 0 && value < 150)
                    age = value;
                else
                    age = 18;
            }
        }  

    }

 
}