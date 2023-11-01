using System.Data.Entity;


Console.BackgroundColor = ConsoleColor.Green;
while (true)
{
    try
    {
        Console.WriteLine();
        Console.WriteLine("<<Для выбора нужной вам опции нажмите на соответствующую клавишу>>");
        Console.WriteLine("1 - Просмотр.");
        Console.WriteLine("2 - Поиск.");
        Console.WriteLine("3 - Добавление.");
        Console.WriteLine("4 - Редактирование.");
        Console.WriteLine("5 - Удаление.");
        Console.WriteLine("6 - Выход.");
        Console.WriteLine();

        ConsoleKeyInfo key_one = Console.ReadKey();

        if(key_one.Key == ConsoleKey.D1)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("<Просмотр>");
                Console.WriteLine("<<Для выбора нужной вам опции нажмите на соответствующую клавишу>>");
                Console.WriteLine("1 - Все игры.");
                Console.WriteLine("2 - Однопользовательские игры.");
                Console.WriteLine("3 - Многопользовательские игры.");
                Console.WriteLine("4 - Самая часто продаваемая игра.");
                Console.WriteLine("5 - Самая не часто продаваемая игра.");
                Console.WriteLine("6 - Топ 3 самых популярных игр.");
                Console.WriteLine("7 - Топ 3 самых непопулярных игр.");
                Console.WriteLine("8 - Вернуться в основное меню.");
                Console.WriteLine();

                ConsoleKeyInfo key_two = Console.ReadKey();

                if (key_two.Key == ConsoleKey.D1)
                {
                    try
                    {
                        Console.WriteLine();
                        // все игры
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D2)
                {
                    try
                    {
                        Console.WriteLine();
                        // только синглплей
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D3)
                {
                    try
                    {
                        Console.WriteLine();
                        // только мультиплей
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D4)
                {
                    try
                    {
                        Console.WriteLine();
                        // частопродаваемая
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D5)
                {
                    try
                    {
                        Console.WriteLine();
                        // не часто продаваемая
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D6)
                {
                    try
                    {
                        Console.WriteLine();
                        // топ 3 популярных
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D7)
                {
                    try
                    {
                        Console.WriteLine();
                        // топ 3 непопулярных
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                if (key_two.Key == ConsoleKey.D8)
                {
                    try
                    {
                        Console.WriteLine();

                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine();
            }
        }

        if (key_one.Key == ConsoleKey.D2)
        {
            try
            {
                Console.WriteLine();
                // поиск игры
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine();
            }
        }

        if (key_one.Key == ConsoleKey.D3)
        {
            try
            {
                Console.WriteLine();
                // добавление игры
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine();
            }
        }

        if (key_one.Key == ConsoleKey.D4)
        {
            try
            {
                Console.WriteLine();
                // редактирование игры
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine();
            }
        }

        if (key_one.Key == ConsoleKey.D5)
        {
            try
            {
                Console.WriteLine();
                // удаление игры
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine();
            }
        }

        if (key_one.Key == ConsoleKey.D6)
        {
            try
            {
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine();
            }
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine();
        Console.WriteLine($"Ошибка: {ex.Message}");
        Console.WriteLine();
    }
}



