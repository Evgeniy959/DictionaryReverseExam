﻿using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            var exit = false;
            var dictionaryRus = new Dictionary<string, string>();
            var dictionaryEng = new Dictionary<string, string>();
            
            Show.Menu();
            var selectType = Console.ReadLine();
            do 
            { 
                 Show.submenu();
                 var select = Console.ReadLine();
                 if (selectType == "1")
                 {
                    switch (select)
                    {
                        case "1": // 1. Добавить
                            Methods.AddFileRus(dictionaryRus);
                            break;
                        case "2": // 2. Редактировать
                            Methods.EditRus(dictionaryRus);
                            break;
                        case "3": // 3. Удалить
                            Methods.DeleteRUS(dictionaryRus);
                            break;
                        case "4": // 4. Найти
                            Methods.FindRus(dictionaryRus);
                            break;
                        case "5": // 5. Показать весь словарь
                            Methods.PrintDictionary(dictionaryRus);
                            break;
                        case "6": //6.Сохранить в отдельный файл результата 
                            Methods.AddResFileRus(); 
                            break;
                        case "7": // 7. Возврат в предыдущее меню
                            Show.Menu();
                            selectType = Console.ReadLine();
                            break;
                        case "0": // 0. Выход
                            exit = true;
                            break;
                        default: // Неправильный ввод
                            Show.PrintLn("Повторите ввод");
                            Console.WriteLine();
                            break;
                    }
                 }
                 if (selectType == "2") 
                 {
                    switch (select)
                    {
                        case "1": // 1. Добавить
                            Methods.AddEng(dictionaryEng);
                            break;
                        case "2": // 2. Редактировать
                            Methods.EditEng(dictionaryEng);
                            break;
                        /*case "3": // 3. Удалить
              
                            break;*/
                        case "4": // 4. Найти
                            Methods.FindEng(dictionaryEng);
                            break;
                        case "5": // 5. Показать всё
                            Methods.PrintDictionary(dictionaryEng);
                            break;
                            /*case "6":
                                //6.Сохранить в отдельный файл результата*/ 
                         case "7": // 7. Возврат в предыдущее меню
                            Show.Menu();
                            selectType = Console.ReadLine();
                            break;
                         case "0": // 0. Выход
                             exit = true;
                             break;
                          default: // Неправильный ввод
                             Show.PrintLn("Повторите ввод");
                             Console.WriteLine();
                             break;
                    }
                 }
            } while (!exit);
              Show.PrintLn("До свидания...");
        }
    }
}
