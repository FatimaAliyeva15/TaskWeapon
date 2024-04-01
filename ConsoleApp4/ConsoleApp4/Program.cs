namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(20,13, false);


            bool check = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("0 - Informasiya almaq ucun");
                Console.WriteLine("1 - Shoot metodu ucun");
                Console.WriteLine("2 - Fire metodu ucun");
                Console.WriteLine("3 - GetRemainBulletCount metodu ucun");
                Console.WriteLine("4 - Reload metodu ucun");
                Console.WriteLine("5 - ChangeFireMode metodu ucun");
                Console.WriteLine("6 - Proqrami dayandirmaq ucun");
                Console.WriteLine("7 - Edit:");
                

                Console.WriteLine("");

                string choiceStr;
                byte choice;

                do
                {
                    Console.WriteLine("");
                    Console.Write("Sechim edin: ");             
                    choiceStr = Console.ReadLine();
                } while (!byte.TryParse(choiceStr, out choice));

                switch (choice)
                {
                    case 0:
                        Console.WriteLine($"Bullet Capacity: {weapon.BulletCapacity} \nBullet Count: {weapon.BulletCount} \nFire Mode: {weapon.FireMode}");
                        break;

                    case 1:
                        Console.WriteLine("");
                        weapon.Shoot();
                        break;

                    case 2:
                        Console.WriteLine("");
                        weapon.Fire();
                        break; 
                    
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;

                    case 4:
                        Console.WriteLine("");
                        weapon.Reload();
                        break; 
                    
                    case 5:
                        Console.WriteLine("");
                        weapon.ChangeFireMode();
                        break; 
                    
                    case 6:
                        Console.WriteLine("");
                        check = false;
                        Console.WriteLine("Proqram bitdi");
                        break;

                    case 7:
                        Console.WriteLine("");
                        Console.WriteLine("8 - Tutumu deyissin");
                        Console.WriteLine("9 - Gulle sayi deyissin");
                        break;

                    case 8:
                        string newCapacityStr;
                        int newCapacity;

                        do
                        {
                            Console.WriteLine("");
                            Console.Write("Yeni Gulle tutumu daxil edin: ");
                            newCapacityStr = Console.ReadLine();
                        } while (!int.TryParse(newCapacityStr, out newCapacity));

                        weapon.BulletCapacity = newCapacity;
                        Console.WriteLine(newCapacity);

                        break; 
                    
                    case 9:
                        string newCountStr;
                        int newCount;

                        do
                        {
                            Console.WriteLine("");
                            Console.Write("Yeni Gulle sayi daxil edin: ");
                            newCountStr = Console.ReadLine();
                        } while (!int.TryParse(newCountStr, out newCount));

                        weapon.BulletCount = newCount;
                        Console.WriteLine(newCount);
                        break;

                    default:
                        Console.WriteLine("Duzgun secim et");
                        break;
                }


            } while (check);

            



        }
    }
}
