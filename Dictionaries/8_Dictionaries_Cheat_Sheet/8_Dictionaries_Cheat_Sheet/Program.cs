using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Dictionaries_Cheat_Sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Структура "Dictionary <TKey, TValue>" позволяет взять некий ключ (key) и связать его со значением (value).
            /// Каждый ключ при этом появляется только один раз.

            Dictionary<string, string> wordDefinition = new Dictionary<string, string>();

            wordDefinition.Add("Great", "The thing which is very big or even huge.");
            wordDefinition.Add("Small", "The thing which is not enought to be big or normal.");
            wordDefinition.Add("BlaBla", "The thing which is impossiple to underastnd.");
            wordDefinition.Add("Initialization", "The process of object to be ready for using.");

            /// При удалении ключа, удаляется и его значение.
            wordDefinition.Remove("BlaBla"));

            // Метод "ContainsKey" позволяет определить наличие в словаре указанного в качестве пар-ра слова.
            if (wordDefinition.ContainsKey("Initialization"))
            {
                // Получение значения, ассоциируемого с указанным ключом.
                Console.WriteLine(wordDefinition["Initialization"]);     
            }

            // Кол-во пар "ключ-значение".
            Console.WriteLine(wordDefinition.Count);

            Console.WriteLine("\n" + "All \"keys\" of dictionary \"wordDefinition:\"");
            foreach (string keys in wordDefinition.Keys)
            {
                Console.WriteLine(keys);
            }

            Console.ReadKey();
        }
    }
}
