

namespace firstProject
{

    public class Menu
    {
       
        //menu informatie
        public string name;
        public bool hasVeganOption;
        public string starterDish;
        public string mainDish;
        public string desertDish;

        public void greeting()
        {
            Console.WriteLine("welkom bij het " + name + " menu");
        }

        public void veganOption()
        {
            if (hasVeganOption == true)
            { Console.WriteLine("*Dit menu heeft een vegan optie*"); }
            else { Console.WriteLine("*Dit menu heeft geen vegan option*"); }
        }

        public void chosenYet()
        {
            Console.WriteLine("heb je je optie al gemaakt?");
            Console.WriteLine("typ ja als u klaar bent");
            string ChosenYetResult = Console.ReadLine();
            if (ChosenYetResult == "ja ")
            {
                Console.WriteLine("welkom bij restaurant van weert");
                Console.WriteLine("kies astjeblieft een van de volgende opties");
                Console.WriteLine("een. bekijk de lunchkaart");
                Console.WriteLine("twee. bekijk de dinerkaart");
                string optieKeuze = Console.ReadLine();
                Console.WriteLine("u heeft gekozen optie :" + optieKeuze);
            }

        }

        

    }
    class Program
    {
    static void Main(string[] args)
        {
            //lunch menu
            Menu lunch = new Menu();
            {

                lunch.name = "lunch";
                lunch.starterDish = "Tomatensoep";
                lunch.mainDish = "Broodje gezond";
                lunch.desertDish = "Appeltaart";
                lunch.hasVeganOption = true;
            }

            //diner menu
            Menu diner = new Menu();
            {
                diner.name = "diner";
                diner.starterDish = "groente soep";
                diner.mainDish = "rendang";
                diner.desertDish = " 3 bollen vannille ijs";
                diner.hasVeganOption = false;
            }
         

            //gebruiker interactie
                
               //menuOptions
                Console.WriteLine("welkom bij restaurant van weert");
                Console.WriteLine("kies astjeblieft een van de volgende opties");
                Console.WriteLine("een. bekijk de lunchkaart");
                Console.WriteLine("twee. bekijk de dinerkaart");  
                string optieKeuze = Console.ReadLine();
                Console.WriteLine("u heeft gekozen optie :" + optieKeuze);

            if (optieKeuze == "een")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                lunch.greeting();
                Console.WriteLine("de starter voor het lunch menu is " + lunch.starterDish);
                Console.WriteLine("het hoofd menu voor het lunch menu is " + lunch.mainDish);
                Console.WriteLine("het dessert voor het lunch menu is " + lunch.desertDish);
                lunch.veganOption();
                lunch.chosenYet();

            }
            else if (optieKeuze == "twee")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                diner.greeting();
                Console.WriteLine("de starter voor het diner menu is " + diner.starterDish);
                Console.WriteLine("het hoofd menu voor het diner menu is " + diner.mainDish);
                Console.WriteLine("het dessert voor het diner menu is " + diner.desertDish);
                diner.veganOption();


            }
            else if (optieKeuze == "drie")
            {
                Console.WriteLine("Je hebt gekozen voor optie drie.");
            }
            else
            {
                Console.WriteLine("Kon de optie die is ingevoerd niet vinden.");
                Console.WriteLine("Kies astjeblieft een van de opties.");
            }
        }

        
    }
    
    
}