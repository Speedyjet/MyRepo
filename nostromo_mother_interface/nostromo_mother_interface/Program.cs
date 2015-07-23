using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nostromo_mother_interface
{
    class Program
    {
        private static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green; //устанавливаем цвет курсора
            string[] screenWords =
            {
                "COMPUTER", "12493.D" , "\t \t \t SHIP" , "WEYLAN-YUTANI" , "INTERFACE", "MOTHER", "MU-TH-UR 6000",  
                "NOSTROMO", "FUNCTION", "TANKER\\REFINERY", "CAPACITY", "200 000 000", "TONES"
            }; //слова, которые были на интерфейсе Ностромо
            foreach (string t1 in screenWords)
            {
                foreach (var t in t1) //счетчик для букв
                {
                    Thread.Sleep(30); // пауза
                    Console.Write(t);
                    //Console.Beep(800, 80); //звук курсора
                }

                Console.Write("\t"); //отступает абзац
                
            }
            Console.ReadKey();
        }
    }
}
