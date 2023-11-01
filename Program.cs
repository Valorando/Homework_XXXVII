using System;
using System.Data.Entity;

Menu menu = new Menu();
menu.Show_menu();

class Games
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Studio { get; set; }
    public string Jenre { get; set; }
    public string Is_multiplayer { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public int Count_sales { get; set; }
}

class GamesContext : DbContext
{
    public GamesContext()
        : base("DBConnection")

    { }

    public DbSet<Games> Game { get; set; }
}

class Menu
{
    public void Show_menu()
    {
        Console.ForegroundColor = ConsoleColor.Green;

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

                if (key_one.Key == ConsoleKey.D1)
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
                                using(GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game;
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    foreach (Games g in games)
                                    {
                                        Console.WriteLine($"{g.Id}\t{g.Name}\t{g.Studio}\t{g.Jenre}\t{g.Is_multiplayer}\t{g.Year}\t{g.Rating}\t{g.Count_sales}");
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                                using (GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game;
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    foreach (Games g in games)
                                    {
                                        if (g.Is_multiplayer == "-")
                                        {
                                            Console.WriteLine($"{g.Id}\t{g.Name}\t{g.Studio}\t{g.Jenre}\t{g.Is_multiplayer}\t{g.Year}\t{g.Rating}\t{g.Count_sales}");
                                        }
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                                using (GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game;
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    foreach (Games g in games)
                                    {
                                        if (g.Is_multiplayer == "+")
                                        {
                                            Console.WriteLine($"{g.Id}\t{g.Name}\t{g.Studio}\t{g.Jenre}\t{g.Is_multiplayer}\t{g.Year}\t{g.Rating}\t{g.Count_sales}");
                                        }
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                                using (GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game.OrderByDescending(g => g.Count_sales).FirstOrDefault();
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    if (games != null)
                                    {
                                            Console.WriteLine($"{games.Id}\t{games.Name}\t{games.Studio}\t{games.Jenre}\t{games.Is_multiplayer}\t{games.Year}\t{games.Rating}\t{games.Count_sales}");
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                                using (GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game.OrderBy(g => g.Count_sales).FirstOrDefault();
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    if (games != null)
                                    {
                                        Console.WriteLine($"{games.Id}\t{games.Name}\t{games.Studio}\t{games.Jenre}\t{games.Is_multiplayer}\t{games.Year}\t{games.Rating}\t{games.Count_sales}");
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                                using (GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game.OrderByDescending(g => g.Rating).Take(3);
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    foreach (Games g in games)
                                    {
                                        Console.WriteLine($"{g.Id}\t{g.Name}\t{g.Studio}\t{g.Jenre}\t{g.Is_multiplayer}\t{g.Year}\t{g.Rating}\t{g.Count_sales}");
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                                using (GamesContext gc = new GamesContext())
                                {
                                    var games = gc.Game.OrderBy(g => g.Rating).Take(3);
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                    foreach (Games g in games)
                                    {
                                        Console.WriteLine($"{g.Id}\t{g.Name}\t{g.Studio}\t{g.Jenre}\t{g.Is_multiplayer}\t{g.Year}\t{g.Rating}\t{g.Count_sales}");
                                    }
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                }
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
                        Environment.Exit(0);
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
    }
}



