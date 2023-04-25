using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Вы типо охотник на призраков. В доме перед вами он 100% есть, отвечаю. Вы заходите в дом, вокруг очень темно. Хотите включить фонарик? (Просто впиши цифру 1 или 2)");
            Console.WriteLine("1.Включить фонарик");
            Console.WriteLine("2.Оставить фонарик выключенным");

            int vibor = Convert.ToInt32(Console.ReadLine());
            if (vibor == 1)
            {
                Console.WriteLine("Ты молодец! Увидел капкан прямо перед ногами. Ты не умер, поздравляю!");
                Console.ReadLine();
                Console.WriteLine("Ты услушал какой-то шум на втором этаже, и ты думаешь: 'Вот он! Мой шанс!'. Что же ты сделаешь? Понесешься сломя голову на второй этаж или лучше оценишь обстановку?");
                Console.WriteLine("1.Подняться на второй этаж");
                Console.WriteLine("2.Оценить обстановку");

                int vibor2 = Convert.ToInt32(Console.ReadLine());
                if (vibor2 == 1)
                {
                    Console.WriteLine("Хорош! Ты подвернул лодыжку! Дом старый, конечно же лестница провалиться под тобой! Ну ладно, ты не умер, но тебе теперь трудно ходить");
                    Console.ReadLine();
                }


                if (vibor2 == 2)
                {
                    Console.WriteLine("Ты увидел, что лестница не в самом лучшем состоянии. Она определённо рухнет под твоим весом, поэтому второй этаж для тебя закрыт. Не стоит туда подниматься.");
                    Console.ReadLine();

                }

                Console.WriteLine("Ладно, мы уже поняли, что ты не хочешь уходить отсюда. Давай иди дальше. Кстати! Забыли сообщить, что ты, как НАСТОЯЩИЙ ОХОТНИК ЗА ПРИВЕДЕНИЯМИ взял с собой какое-то снаряжение. Я буду иногда тебе предлагать его использовать. Не знаю поможет оно тебе или нет :)");
                Console.ReadLine();
                Console.WriteLine("Ты медленно, как ниндзя, крадёшься на кухню, осматривая всё подряд. СНОВА ШУМ (как неожиданно). Что же ты будешь делать? Пойдёшь туда, откуда доносится шум? Или спрячешься?");
                Console.WriteLine("1.Пойду!!!!");
                Console.WriteLine("2.Ни, я спрячусь");

                int vibor3 = Convert.ToInt32(Console.ReadLine());
                if (vibor3 == 1)
                {
                    Console.WriteLine("Вы увидели гостивент. Такого страшного призрака, который стоял, дёргался. Пока что он не собирался на тебя нападать. Ты достал фотоаппарат. " +
                        "Пока ты наводил на него камеру, ОН ТЕБЯ ЗАМЕТИЛ! Что же ты будешь делать? Может сфоткаешь его перед смертью?");
                    Console.WriteLine("1.Го");
                    Console.WriteLine("2.Не, я всё равно умру");

                    int vibor4 = Convert.ToInt32(Console.ReadLine());
                    if (vibor4 == 1)
                    {
                        Console.WriteLine("Призрак скрючился и на время ты его застанил. У тебя появилось преимущество! Спрячешься где-нибудь поблизости или лучше убежишь?");
                        Console.WriteLine("1.Спрячусь");
                        Console.WriteLine("2.БЕЖАТЬ");

                        int vibor5 = Convert.ToInt32(Console.ReadLine());
                        if (vibor5 == 1)
                        {
                            Console.WriteLine("Ты спрятался и смог избежать смерти!");
                        }
                        if ((vibor5 == 2) && (vibor2 == 2))
                        {
                            Console.WriteLine("Ты убежал в дальнюю комнату и спрятался там!");
                            Console.ReadLine();

                        }
                        if ((vibor5 == 2) && (vibor2 == 1))
                        {
                            Console.WriteLine("Ты забыл, что подвернул лодыжку?)) Ты не смог далеко убежать и тебя съели. ням ням");
                            Console.WriteLine("Нажмите enter, чтобы вернуться в начало");
                            Console.ReadLine();
                            return true;
                        }
                        return true;
                    }
                    if (vibor4 == 2)
                    {
                        Console.WriteLine("Ты и глазом не успел моргнуть, как тебя съели. ням ням");
                        Console.WriteLine("Нажмите enter, чтобы вернуться в начало");
                        Console.ReadLine();
                        return true;
                    }
                }
                if (vibor3 == 2)
                {
                    Console.WriteLine("Ты спрятался и смог избежать смерти!");
                    Console.ReadLine();
                }
                return true;

            }
            else if (vibor == 2)
            {
                Console.WriteLine("Ты реально подумал, что ходить в темноте по незнакомому дому это безопасно? Ты попал в капкан, ну и типо умер, мейби от потери крови");
                Console.WriteLine("Нажмите enter, чтобы вернуться в начало");
                Console.ReadLine();
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}