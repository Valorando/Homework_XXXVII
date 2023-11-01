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
                        Console.WriteLine("<Поиск>");
                        Console.Write("Введите ключевое слово: ");
                        string word = Console.ReadLine();
                        Console.WriteLine();
                        using (GamesContext gc = new GamesContext())
                        {
                            var games = gc.Game.Where(b =>
                            b.Name.ToLower().Contains(word) ||
                            b.Studio.ToLower().Contains(word) ||
                            b.Jenre.ToLower().Contains(word) ||
                            b.Is_multiplayer.ToLower().Contains(word) ||
                            b.Year.ToString().Contains(word) ||
                            b.Rating.ToString().Contains(word) ||
                            b.Count_sales.ToString().Contains(word)).ToList();

                            if(games.Any())
                            {
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("ID:\tНазвание:\tСтудия:\tЖанр:\tНаличие мультиплеера:\tГод выпуска:\tРейтинг:\tКоличество продаж:");
                                foreach (Games g in games)
                                {
                                    Console.WriteLine($"{g.Id}\t{g.Name}\t{g.Studio}\t{g.Jenre}\t{g.Is_multiplayer}\t{g.Year}\t{g.Rating}\t{g.Count_sales}");
                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Ничего не найдено.");
                            }
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

                if (key_one.Key == ConsoleKey.D3)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("<Добавление>");
                        Console.Write("Введите название игры: ");
                        string name = Console.ReadLine();

                        using (GamesContext gc = new GamesContext())
                        {
                            bool gameExists = gc.Game.Any(g => g.Name == name);

                            if (gameExists)
                            {
                                Console.WriteLine("Такая игра уже существует в базе данных.");
                            }
                            else
                            {
                                Console.Write("Введите разработчика: ");
                                string studio = Console.ReadLine();
                                Console.Write("Введите жанр игры: ");
                                string jenre = Console.ReadLine();
                                Console.Write("Имеется ли в игре мультиплеер? (Если да то +, если нет то - ): ");
                                string is_multiplayer = Console.ReadLine();
                                Console.Write("Введите год выпуска игры: ");
                                int year = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Введите рейтинг игры: ");
                                double rating = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Введите количество проданных экземпляров: ");
                                int count = Convert.ToInt16(Console.ReadLine());

                                Games games = new Games { Name = name, Studio = studio, Jenre = jenre, Is_multiplayer = is_multiplayer, Year = year, Rating = rating, Count_sales = count };
                                gc.Game.Add(games);
                                gc.SaveChanges();

                                Console.WriteLine("Игра успешно добавлена.");
                            }
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

                if (key_one.Key == ConsoleKey.D4)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("<Редактирование>");
                        Console.Write("Введите ID игры: ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите значение для замены: ");
                        string old_value = Console.ReadLine();
                        Console.WriteLine("Подсказка: внимательно проверяйте корректность значений, во избежание замены не тех значений.");
                        Console.Write("Введите новое значение: ");
                        string new_value = Console.ReadLine();
                        Console.WriteLine();
                        using(GamesContext gc = new GamesContext())
                        {
                            var game = gc.Game.FirstOrDefault(b => b.Id == Id);

                            if (game != null)
                            {
                                if (game.Name == old_value) game.Name = new_value;
                                if (game.Studio== old_value) game.Studio = new_value;
                                if (game.Jenre == old_value) game.Jenre = new_value;
                                if (game.Is_multiplayer == old_value) game.Is_multiplayer = new_value;
                                gc.SaveChanges();
                                Console.WriteLine("Запись успешно обновлена.");
                            }
                            else
                            {
                                Console.WriteLine("Игра с указанным ID не найдена.");
                            }
                            Console.WriteLine();
                        }

                        if (int.TryParse(old_value, out int oldYear) && int.TryParse(new_value, out int newYear) && int.TryParse(old_value, out int oldCount) && int.TryParse(new_value, out int newCount))
                        {
                            using (GamesContext gc = new GamesContext())
                            {
                                var game = gc.Game.FirstOrDefault(b => b.Id == Id);

                                if (game != null)
                                {
                                    if (game.Year == oldYear) game.Year = newYear;
                                    if (game.Count_sales == oldCount) game.Count_sales = newCount;
                                    gc.SaveChanges();
                                    Console.WriteLine("Запись успешно обновлена.");
                                }
                            }
                        }
                        
                        if (double.TryParse(old_value, out double oldRating) && double.TryParse(new_value, out double newRating))
                        {
                            using (GamesContext gc = new GamesContext())
                            {
                                var game = gc.Game.FirstOrDefault(b => b.Id == Id);

                                if (game != null)
                                {
                                    if (game.Rating == oldRating) game.Rating = newRating;
                                    gc.SaveChanges();
                                    Console.WriteLine("Запись успешно обновлена.");
                                }
                            }
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

                if (key_one.Key == ConsoleKey.D5)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("<Удаление>");
                        Console.Write("Введите ID игры для удаления: ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Вы точно уверены что хотите удалить эту игру?(Да/Нет): ");
                        string key = Console.ReadLine();

                        if(key == "Да" || key == "да" || key == "ДА" || key == "дА")
                        {
                            using (GamesContext gc = new GamesContext())
                            {
                                var games = gc.Game.FirstOrDefault(b => b.Id == Id);

                                if (games != null)
                                {
                                    gc.Game.Remove(games);
                                    gc.SaveChanges();
                                    Console.WriteLine($"Игра с ID {Id} успешно удалена.");

                                    gc.SaveChanges();
                                }
                                else
                                {
                                    Console.WriteLine($"Игра с ID {Id} не найдена.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Операция по удалению отменена.");
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



