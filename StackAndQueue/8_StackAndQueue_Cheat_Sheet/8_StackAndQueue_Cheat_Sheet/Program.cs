using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_StackAndQueue_Cheat_Sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Общее в "Stack" и "Queue": 1) метод Peek() позволяет выделять 1-ый элемент (обрабатывает первый элемент), не удаляя его;
            //                            2) метод Clear() удаляет все объекты;

            // И в "Stack" и в "Queue" отсутствует доступ к средним элементам.

            /// Queue ("очередь")- дополнительный тип коллекций.      

            /*
            //  Объекты добавляются в очередь с помощью "enqueue".
            //  Объекты удаляются из неё с помощью "dequeue".

            Queue<string> myQueue = new Queue<string>();

            // We'll add 4 components to the Queue.
            myQueue.Enqueue("first in line");
            myQueue.Enqueue("second in line");
            myQueue.Enqueue("third in line");
            myQueue.Enqueue("last in line");


            // Метод Peek() позволяет выделить первый элемент в очереди, не удаляя его.
            string takeALook = myQueue.Peek();

            string getFirst = myQueue.Dequeue();
            string getNext = myQueue.Dequeue();
            int howMany = myQueue.Count;

            // Метод Clear() удаляет из очереди все объекты.
            myQueue.Clear();

            Console.WriteLine("Peek() returned: " + takeALook + "\n"
                + "The first Dequeue() returned: " + getFirst + "\n"
                + "The second Dequeue() returned: " + getNext + "\n"
                + "Count before Clear() was " + howMany + "\n"
                + "Count after Clear() is now " + myQueue.Count);
            Console.ReadKey();
            */

            /// Stack ("стек") - дополнительный тип коллекций.

            // Помещаемый в стек элемент сдвигает все прочие элементы на единицу вниз и оказывается на самом верху.
            Stack<string> myStack = new Stack<string>();
            myStack.Push("first in line");
            myStack.Push("second in line");
            myStack.Push("third in line");
            myStack.Push("last in line");
            myStack.Pop();

            // Метод Peek() позволяет выделить первый элемент в стеке, не удаляя его.
            string takeALook = myStack.Peek();

            // Метод Pop() удаляет из стека последний добавленный туда элемент.
            string getFirst = myStack.Pop();
            string getNext = myStack.Pop();
            int howMany = myStack.Count;
            // Метод Clear() удаляет из cтека все объекты.
            myStack.Clear();

            Console.WriteLine("Peek() returned: " + takeALook + "\n"
                + "The first Pop() returned: " + getFirst + "\n"
                + "The second Pop() returned: " + getNext + "\n"
                + "Count before Clear() was " + howMany + "\n"
                + "Count after Clear() is now " + myStack.Count);
            Console.ReadKey();
        }
    }
}
