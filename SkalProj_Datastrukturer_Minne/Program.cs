using System;
using System.Collections.Generic;
using System.Threading;


namespace SkalProj_Datastrukturer_Minne
{

    class program
    {

        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {



            while (true)
            {
                Console.WriteLine("Please navigate through the menu by selecting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParenthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            //Svar:
            //2. den ökar när antalet element (listans "count") överstiger listans "capacity", då dubblas kapaciteten, från 4 till 8 initialt

            //3. dubbelt upp

            //4. kapacitet är storleken på listans interna array... startar på värde noll och blir sedan per default 4 vid sin första "add", 

            //5. nope, du måste göra detta manuellt med TrimExcess eller Clear

            //6. om du bara använder en typ av element, t ex bara strings och för att då undvika input av fel typ från en användare, det kan också vara mer minnesbesparande att använda en array jämfört med andra listtyper
            //Sedan går den upp med en faktor av 2 när den behöver mer kapacitet..Minnet som vigs åt listan kopieras upp på ett minimalt sätt och tar därför inte upp minnet direkt jämfört
            //med en array med specifikt antal
            //listans capacity anropar följande rutin:
            //private const int _defaultCapacity = 4;            ...
            //private void EnsureCapacity(int min)
            //{
            //if (_items.Length < min)
            //{
            //   int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;

            //}
            // }

            //Sedan går den upp med en faktor av 2 när den behöver mer kapacitet.. Minnet som vigs åt listan kopieras upp på ett minimalt sätt och tar därför inte upp minnet direkt jämfört
            //med en array med specifikt antal
            //listans capacity anropar följande rutin:

            //private const int _defaultCapacity = 4;            ...
            //private void EnsureCapacity(int min)
            //{
            //if (_items.Length < min)
            //{
            //   int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;

            //}
            // }


            /*
             * Loop this method until the user inputs something to exit to main menu.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or - 
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();

            while (true)
            {

                Console.WriteLine("Menu to add or remove a name from the list, see choices below: \n(1, 2, 0)"
                    + "\n1. Add(+name) or Remove(-name) a name, write plus sign before the specified name"
                    + "\n2. Remove a name, write minus sign before the specified name"

                    + "\n0. Exit the application");
                char nav = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    nav = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                //  List<string> theList = new List<string>();
                //string input = Console.ReadLine();
                //char nav = input[0];
                //string value = input.substring(1);

                //switch(nav){...}

                //Capacity is the number of elements that the List<T> can store before resizing is required,
                //whereas Count is the number of elements that are actually in the List<T>.
                //Capacity is always greater than or equal to Count. If Count exceeds Capacity while adding elements,
                //the capacity is increased by automatically reallocating the internal array before copying the old elements and adding the new elements.
                // a List<T> is initialized with a capacity of 0.When the first item is added, it is reinitialized to a capacity of 4.
                // Subsequently, whenever the capacity is reached, the capacity is doubled.



                //string value = input.substring(1);


                switch (nav)

                {



                    case '1':


                        Console.Clear();
                        Console.WriteLine("add name: ");
                        string input = Console.ReadLine();

                        if (input[0] == '+')
                        {
                            string value = input.Substring(input.IndexOf("+") + 1);
                            theList.Add(value);

                            Console.WriteLine("Name is: " + value);
                            Console.WriteLine("Count Is: " + theList.Count);
                            Console.WriteLine("Capacity Is: " + theList.Capacity);
                        }
                        else
                        {
                            Console.WriteLine("must be plus sign before name, try again!");
                        }
                        break;
                    //List<string> s = new List<string>();
                    //string x = ConsoleReadLine();
                    //s = x.Substring(input.IndexOf("+") + 1);




                    case '2':

                        Console.Clear();
                        Console.WriteLine("remove name: ");
                        string input2 = Console.ReadLine();

                        if (input2[0] == '-')
                        {
                            string value = input2.Substring(input2.IndexOf("-") + 1);
                            theList.Remove(value);

                            Console.WriteLine("Name is: " + value);
                            Console.WriteLine("Count Is: " + theList.Count);
                            Console.WriteLine("Capacity Is: " + theList.Capacity);
                        }
                        else
                        {
                            Console.WriteLine("must be minus sign before name, try again!");
                        }
                        break;

                    // RemoveFromList();
                    //Console.Clear();
                    // Console.WriteLine("Please remove a name with minus sign before the name");
                    // string namerem = Console.ReadLine();
                    // string substring = namerem.Substring(namerem.IndexOf("-") + 1);
                    // Console.WriteLine("name is:" + substring);


                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry. I dunno know that one.");
                        break;

                }
            }
        }
        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        private static void ExamineQueue()
        {

            /*
             * Loop this method untill the user inputs something to exit to main menu.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> icaQueue = new Queue<string>();

            int userInput = -1;


            do

            {



                Console.WriteLine("\nEnter ya input\n\n1 > Push Name\n2 > Pop Name\n3 > Show names in queue\n0 > Quit\n");

                if (!int.TryParse(Console.ReadLine(), out userInput))

                {

                    Console.WriteLine("\nInvalid input. Try again...\n\n");

                    continue;

                }


                switch (userInput)

                {

                    case 1:

                        Console.Write("\nEnter Name: ");

                        icaQueue.Enqueue(Console.ReadLine());

                        break;


                    case 2:

                        if (icaQueue.Count() > 0)

                        {

                            string name = icaQueue.Dequeue();

                            Console.WriteLine("{0} is satisfied & kicked from da queue", name);

                        }

                        else

                        {

                            Console.WriteLine("Queue is empty");

                        }

                        break;


                    case 3:

                        Console.WriteLine();

                        icaQueue.ToList().ForEach(name => Console.WriteLine(name));

                        break;


                    case 0:

                        break;

                }

            }

            while (userInput != 0);


            Console.WriteLine("Press a button to quit");

            Console.ReadKey();

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */


            stack st = new stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nMenu (size -- 30)");
                Console.WriteLine("1. Add name of person");
                Console.WriteLine("2. See the top person on the stack.");
                Console.WriteLine("3. Remove the person on the top.");
                Console.WriteLine("4. Show stack items.");
                Console.WriteLine("5. Reverse stack item.");
                Console.WriteLine("6. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Top element is: {0}", st.Peek());
                        break;

                    case 3:
                        Console.WriteLine("Element removed: {0}", st.Pop());
                        break;

                    case 4:
                        st.Output();
                        break;

                    case 5:
                        static string Reversed(String str)
                        {
                            char[] charArr = str.ToCharArray();
                            int size = charArr.Length;
                            stack st = new stack();
                            int i;
                            for (i = 0; i < size; ++i)
                            {
                                st.Push(charArr[i]);
                            }

                            for (i = 0; i < size; ++i)
                            {
                                charArr[i] = (char)st.Pop();
                            }

                            return String.Join("", charArr);

                        }
                        string str;
                        Console.WriteLine("give me a string to reverse: ");
                        str = Console.ReadLine();

                        Console.WriteLine(str);
                        str = Reversed(str);
                        Console.WriteLine(str);

                        Console.ReadLine();


                        break;

                    case 6:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }



        interface IStackad
        {
            Boolean isEmpty();
            void Push(Object element);
            Object Pop();
            Object Peek();
            void Output();
        }
        class stack : IStackad
        {
            private int StackSize;
            public int StackSizeSet
            {
                get { return StackSize; }
                set { StackSize = value; }
            }
            public int top;
            Object[] item;
            public stack()
            {
                StackSizeSet = 30;
                item = new Object[StackSizeSet];
                top = -1;
            }
            public stack(int capacity)
            {
                StackSizeSet = capacity;
                item = new Object[StackSizeSet];
                top = -1;
            }
            public bool isEmpty()
            {
                if (top == -1) return true;

                return false;
            }
            public void Push(object element)
            {
                if (top == (StackSize - 1))
                {
                    Console.WriteLine("Stack is maxxed!");
                }

                else
                {

                    item[++top] = element;
                    Console.WriteLine("Item pushed");
                }
            }
            public object Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is zero");
                    return "No items";
                }
                else
                {

                    return item[top--];
                }
            }
            public object Peek()
            {
                if (isEmpty())
                {

                    Console.WriteLine("Stack is zero");
                    return "No items";
                }
                else
                {
                    return item[top];
                }
            }


            public void Output()
            {
                for (int i = top; i > -1; i--)
                {

                    Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
                }
            }


        }


        //Svar på fråga 1: I en kö är det logiskt att den förste in i kön blir expedierad först
        //och sedan lämnar kön. Vad gäller stacktypen så byggs kön på höjd och den förste in i kön
        //är den som lämnar kön sist då stacken via pop-metodiken tar bort översta elementet, d v s siste man in,
        //vilket inte är tidseffektivt och inte heller rättvist.
        static void CheckParenthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            string st;
            //char[] exp = { '{', '(', ')', '}', '[', ']' };
            Console.Write("Enter a string: ");
            st = Console.ReadLine();
            char[] exp = st.ToCharArray();
            // anropar balanced-metoden
            if (Balper.Balanced(exp))
                Console.WriteLine("Balanced ");
            else
                Console.WriteLine("Not Balanced ");
            Thread.Sleep(2000);

        }
        public class Balper
        {
            public class stack
            {
                public int smax = -1;
                public char[] stuff = new char[100];

                public void push(char s)
                {
                    if (smax == 99)
                    {
                        Console.WriteLine("Stakka Boo full");
                    }
                    else
                    {
                        stuff[++smax] = s;
                    }
                }

                char pop()
                {
                    if (smax == -1)
                    {
                        Console.WriteLine("För lite stack");
                        return '\0';
                    }
                    else
                    {
                        char element = stuff[smax];
                        smax--;
                        return element;
                    }
                }

            }

            // returnerar sant då character1 och character2
            // matchar höger-vänster-parentestecken */
            static Boolean Matcha(char tekken1,
                                          char tekken2)
            {
                if (tekken1 == '(' && tekken2 == ')')
                    return true;
                else if (tekken1 == '{' && tekken2 == '}')
                    return true;
                else if (tekken1 == '[' && tekken2 == ']')
                    return true;
                else
                    return false;
            }

            // returnera sant om korrekt

            public static Boolean Balanced(char[] exp)
            {
                // stack-skal
                Stack<char> stx = new Stack<char>();

                //kolla matchande innehåll
                for (int i = 0; i < exp.Length; i++)
                {
                    // om exp[i] är öppningstecken
                    //pusha den
                    if (exp[i] == '{' || exp[i] == '('
                        || exp[i] == '[')
                        stx.Push(exp[i]);

                    //  om exp[i] är stängningstecken
                    //  poppa från stacken o kolla om
                    //   den poppade tillhör ett matchande par
                    if (exp[i] == '}' || exp[i] == ')'
                        || exp[i] == ']')
                    {

                        // om stängningstecken utan matchande
                        //  par returnera falskt
                        if (stx.Count == 0)
                        {
                            return false;
                        }

                        // poppa element från stack,
                        // om den inte är ett par av parentesertecken
                        // då matchar det ej. 

                        else if (!Matcha(stx.Pop(),
                                                 exp[i]))
                        {
                            return false;
                        }
                    }
                }

                // om det är ngt kvar 
                // då finns det ett öppningstecken utan ett stängningstecken


                if (stx.Count == 0)
                    return true; // correct
                else
                {
                    // incorrect
                    return false;
                }

            

            }

        }
    }
}
    


