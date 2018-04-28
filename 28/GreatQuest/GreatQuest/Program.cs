using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quest
{
    class Program
    {
        //Историю Мимира и рассказы торговца ещё не доделал
        //static int[] Stories = { 1, 2, 3, 4 };
        static bool sword = false;
        static bool armor = false;
        static bool horse = true;
        static bool robberInForest = true;
        static double health = 130;
        static double robberHealth = 100;
        static double aramHealth = 200;
        static double damage = 30;
        static double robberDamage = 50;
        static double aramDamage = 80;
        static double money = 100;

        static Random rend = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Вы - герой,который мечтает о подвигах!Но пока что у вас есть только ваш верный конь ;( ");
            Console.WriteLine();
            Thread.Sleep(500);
            Field();
        }
        static void Field()
        {
            Console.WriteLine("Вы находитесь на поле.Ваши варианты действий:");
            Console.WriteLine("1.Отправиться в лавку Торговца.");
            Console.WriteLine("2.Отправиться в лес.");
            Console.WriteLine("3.Отправиться в деревню.");
            Console.WriteLine("4.Послушать историю Хранителя поля.");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Добрый день!Меня зовут Альфред,и я Главный торговец этой страны!");
                Thread.Sleep(500);
                ShopTrader();
            }
            else if (answer == 2)
            {
                Forest();
            }
            else if (answer == 3)
            {
                Village();
            }
            else if (answer == 4)
            {
                Console.WriteLine();
                Console.WriteLine("О,я рад,что ты пришёл послушать историю этого мира!");
                Console.WriteLine("Я Мимир,хранитель поля!");
                Story();
            }

        }
        static void ShopTrader()
        {
            Thread.Sleep(500);
            Console.WriteLine("Чтобы вы хотели сделать?");
            Console.WriteLine();
            Console.WriteLine("Варианты действий:");
            Console.WriteLine("1.Продать коня.");
            Console.WriteLine("2.Купить меч.");
            Console.WriteLine("3.Купить броню.");
            Console.WriteLine("4.Отправиться на поле.");
            Console.WriteLine("5.Отправиться в лес.");
            Console.WriteLine("6.Отправиться в деревню.");
            Console.WriteLine("7.Купить аптечку.");
            int answer2 = int.Parse(Console.ReadLine());
            if (answer2 == 1)
            {
                if (horse == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Отличный конь!Поверьте,он попал в добрые руки!");
                    money = money + 200;
                    Console.WriteLine("В вашем кошельке - " + money + " нуток.");
                    horse = false;
                    ShopTrader();
                }
                else
                {
                    Console.WriteLine("Но у вас же нет коня...");
                    ShopTrader();
                }
            }
            else if (answer2 == 2)
            {
                if (money >= 150 && sword == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вот ваш новый меч!Его ковали в самом Штормграде!");
                    damage = damage + 50;
                    money = money - 150;
                    sword = true;
                    Console.WriteLine("Ваш урон - " + damage);
                    ShopTrader();
                }
                else
                {
                    if (sword == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("У вас уже есть меч...");
                        ShopTrader();
                    }
                    else if (money < 150)
                    {
                        Console.WriteLine();
                        Console.WriteLine("У вас недостаточно денег...");
                        ShopTrader();
                    }
                }
            }
            else if (answer2 == 3)
            {
                if (money >= 150 && armor == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вот ваша броня!Её сковали сами гномы Чёрной горы!");
                    health = health + 20;
                    Console.WriteLine("Ваше здоровье - " + health);
                    money = money - 150;
                    armor = true;
                    Console.WriteLine();
                    ShopTrader();
                }
                else
                {
                    if (armor == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("У вас уже есть броня...");
                        ShopTrader();
                    }
                    else if (money < 150)
                    {
                        Console.WriteLine();
                        Console.WriteLine("У вас недостаточно денег...");
                        ShopTrader();
                    }

                }
            }
            else if (answer2 == 4)
            {
                Console.WriteLine();
                Field();
            }
            else if (answer2 == 5)
            {
                Console.WriteLine();
                Forest();
            }
            else if (answer2 == 6)
            {
                Console.WriteLine();
                Village();
            }
            else if(answer2 == 7)
            {
                if(money >= 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вот ваша аптечка!");
                    health = health + 30;
                    money = money - 20;
                    Console.WriteLine("Ваше здоровье - " + health);
                    ShopTrader();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("У вас недостаточно денег...");
                    ShopTrader();
                }
            }
        }
        static void Forest()
        {
            if (robberInForest == true)
            {
                Console.WriteLine();
                Console.WriteLine("О нет! На вас со спины напали разбойники-мурлоки!");
                health = health - 30;
                Console.WriteLine("Ваше здоровье - " + (health - 30));
                Console.WriteLine("1.Вернуться на поле?");
                Console.WriteLine("2.Принять бой!");
                Console.WriteLine("3.Бежать в лавку Торговца!");
                Thread.Sleep(500);
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine();
                    Field();
                }
                else if (a == 2)
                {
                    Console.WriteLine();
                    FightWithRobbery();
                }
                else if (a == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Что с вами случилось?Вы сбежали от мурлоков?");
                    Console.WriteLine("Последнее время их стало слишком много в нашем лесу...");
                    Console.WriteLine("Я бы мог вам заплатить,если вы избавитесь от них!");
                    ShopTrader();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Лес безопасен...");
                Console.WriteLine("1.Отправиться в деревню?");
                Console.WriteLine("2.Отправиться на поле.");
                Console.WriteLine("3.Сходить в лавку Торговца!");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine();
                    Village();
                }
                else if (a == 2)
                {
                    Console.WriteLine();
                    Field();
                }
                else if (a == 3)
                {
                    Console.WriteLine();
                    ShopTrader();
                }
            }
            Console.ReadLine();
        }
        static void FightWithRobbery()
        {
            while (true)
            {
                robberDamage = GetReducedAttack(robberHealth, 100, 50);
                Console.WriteLine("Ваше здоровье - " + (health - robberDamage) + ".Здоровье мурлоков - " + (robberHealth - damage) + ".");
                health = health - robberDamage;
                robberHealth = robberHealth - damage;
                if (health < 1 || robberHealth < 1)
                {
                    break;
                }
                Console.WriteLine("Продолжаем бой?");
                string answerF = Console.ReadLine().ToLower();
                if(answerF == "нет")
                {
                    Console.WriteLine("1.Вернуться на поле?");
                    Console.WriteLine("2.Бежать в лавку Торговца!");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.WriteLine();
                        Field();
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine();
                        ShopTrader();
                    }
                }

            }
            if (health <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы погибли...!");
                NewGame();
            }
            if (robberHealth <= 0 && health >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы выиграли!Поздравляю!");
                robberInForest = false;
                money = money + 500;
                Console.WriteLine("Вот ваша награда - " + money);
                Console.WriteLine("Так же после этой битвы вы улучшили свои навыки!");
                damage = damage + 75;
                Console.WriteLine("Ваш урон - " + damage);
                Console.WriteLine();
                Console.WriteLine("Ваши варианты действий:");
                Console.WriteLine("1.Отправиться в лавку Торговца.");
                Console.WriteLine("2.Отправиться на поле.");
                Console.WriteLine("3.Отправиться в деревню.");
                int b = int.Parse(Console.ReadLine());
                if(b == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Вы избавились от разбойников?");
                    Console.WriteLine("Отлично!");
                    ShopTrader();
                }
                else if(b == 2)
                {
                    Console.WriteLine();
                    Field();
                }
                else if(b == 3)
                {
                    Console.WriteLine();
                    Village();
                }

            }
            if (robberHealth <= 0 && health <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы проиграли!Но выполнили задание и убили мурлоков!");
                NewGame();
            }
            Console.ReadLine();
        }
        static void Village()
        {
            Console.WriteLine();
            Console.WriteLine("Вот вы и в деревне...");
            Console.WriteLine("Большая часть домов разграблена и разрушена...");
            Console.WriteLine("Вы уcлышали крики и побежали на помощь!");
            Console.WriteLine("И  тут вы встретили его...Арама!");
            Console.WriteLine("К сожалению,вам не удалось увернуться от его удара...");
            health = health - 30;
            Console.WriteLine("Ваше здоровье - " + health);
            Console.WriteLine("Варианты действий - ");
            Console.WriteLine("1.Бежать в лес...");
            Console.WriteLine("2.Принять бой!");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine();
                Forest();
            }
            else if (a == 2)
            {
                Console.WriteLine();
                FightWithAram();
            }
    
        }
        static void FightWithAram()
        {
            while (true)
            {
                aramDamage = GetReducedAttack(aramHealth, 200, 80);
                Console.WriteLine("Ваше здоровье - " + (health - aramDamage) + ".Здоровье Арама - " + (aramHealth - damage) + ".");
                health = health - aramDamage;
                aramHealth = aramHealth - damage;
                if (health < 1 || aramHealth < 1)
                {
                    break;
                }
                Console.WriteLine("Продолжаем бой?");
                string answerF = Console.ReadLine().ToLower();
                if (answerF == "нет")
                {
                    Console.WriteLine("Вы бежите в лес...");
                    Console.WriteLine();
                    Forest();      
                }
            }
            if (health <= 0 && aramHealth > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы погибли...!");
                NewGame();
            }
            if (aramHealth <= 0 && health >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы победили Арама!");
                Console.WriteLine("Вы прошли квест и стали героем!");
                Console.WriteLine("Поздравляю!");
                NewGame();
            }
            if (aramHealth <= 0 && health >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Вы победили Арама ценой своей жизни...");
                Console.WriteLine("Жители деревни вас никогда не забудут!");
                NewGame();
            }
        }
        static void Story()
        {
            Console.WriteLine();
            Console.WriteLine("И вот мой рассказ...");
            Console.WriteLine();
            Console.WriteLine("Раньше,несколько сотен лет назад,этот мир населяли великаны!");
            Console.WriteLine("Сейчас они почти все вымерли,но ходят слухи,что один ещё жив.");
            Console.WriteLine("Его зовут - Арам!");
            Console.WriteLine("Во многих деревнях боятся его прихода,ибо он несёт только хаос и разрушения!");
            Console.WriteLine("Говорят,что он само порождение Тьмы...");
            Console.WriteLine("Ладно,не будем о нём...");
            Console.WriteLine("Хочешь узнать о нашей стране?");
            string answer3 = Console.ReadLine().ToLower();
            if (answer3 == "да")
            {
                Console.WriteLine();
                Console.WriteLine("Около века назад монгольский завоеватель,Чингин Тиран,вторгся в нашу страну...");
                Console.WriteLine("Мы пытались отбиться,но все было бесполезно...");
                Console.WriteLine("Ходят слухи,что Чингин продал душу Повелителю Тьмы!И из-за этого он до сих пор жив и царствует...");
                Console.WriteLine("Мы всё ждем героя,чтобы он освободил нас! "); //Намёк на продолжение 
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("О нет!Герой!Арам вернулся и напал на соседнюю деревню!");
                Console.WriteLine("Чтобы попасть в неё,надо пройти через Великий лес!");
                Console.WriteLine("Быстрее,и ты сможешь спасти жителей!");
                Console.WriteLine();
                Field();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Может в следующий раз....О нет!");
                Console.WriteLine("Герой!Арам вернулся и напал на соседнюю деревню!");
                Console.WriteLine("Чтобы попасть в неё,надо пройти через Великий лес!");
                Console.WriteLine("Быстрее,и ты сможешь спасти жителей!");
                Console.WriteLine();
                Field();
            }
            //Console.WriteLine("Герой!До меня доходят слухи,что Арам грабит соседнюю деревню!");
            //Console.WriteLine("Чтобы попасть в неё,надо пройти через Великий лес!");
            //Console.WriteLine("Быстрее,и ты сможешь спасти жителей!");
            //Console.ReadLine();
        }
        static void NewGame()
        {
            Console.WriteLine();
            Console.WriteLine("Хотите начать заново?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "да")
            {
                Console.Clear();
                Console.WriteLine("Вы - герой,который мечтает о подвигах!Но пока что у вас есть только ваш верный конь ;( ");
                Console.WriteLine();
                Thread.Sleep(500);
                sword = false;
                armor = false;
                horse = true;
                health = 100;
                robberHealth = 100;
                aramHealth = 200;
                damage = 30;
                robberDamage = 50;
                aramDamage = 80;
                money = 100;
                Field();
            }
            if (answer == "нет")
            {
                Console.WriteLine();
                Console.WriteLine("Тогда ваше путешествие подощло к концу...");
                Console.Clear();
                Console.ReadLine();
            }
        }
        static double GetReducedAttack(double health, double maxHealth, double maxAttack)
        {
            double x = maxHealth / health;
            double attack = maxAttack / x;
            return attack;
        }
    }
}