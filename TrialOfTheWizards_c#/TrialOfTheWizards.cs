using System;

namespace TrialOfTheWizards
{
    class Wizard
    {
        int healthbar = 3;
        public string name;
        public string spellType;
        public int spellsRemaining;
        public float experience;
        public static int WizardCount;

        public Wizard()
        {
            spellsRemaining = 2;
            experience = 1f;

            WizardCount++;
        }

        public int castSpell(int healthbar)
        {
            Console.WriteLine(name + " casts " + spellType);
            spellsRemaining--;
            if(spellsRemaining < 0)
            {
                switch(healthbar)
                {
                    case 1:
                        Console.WriteLine("Sorry, You have Failed the Trials of the Wizards :(");
                        return healthbar;
                    default:
                        Console.WriteLine(name + " has no spell uses left! You must Meditate next turn or else you'll take Damage!");
                        Console.WriteLine("You took 1 Point of Damage");
                        healthbar--;
                        Console.WriteLine("\nYou are currently at " + healthbar + " Health");
                        return healthbar;
                }
            }
            else
            {
                Console.WriteLine("You have beat this Wizard!");
                return healthbar;
            }
        }
        public void Meditate()
        {
            Console.WriteLine(name + " Meditates and regains Spell Uses and Health");
            healthbar++;
            spellsRemaining = 2;

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard03 = new Wizard();
            Wizard wizard02 = new Wizard();
            Wizard wizard01 = new Wizard();
            
            wizard02.name = "Merline";
            wizard01.name = "Ragnar";
            wizard02.spellType = "Ice";
            wizard01.spellType = "Fire";


            Console.WriteLine("What is your Wizard's Name?");
            wizard03.name = Console.ReadLine();
            wizard03.spellsRemaining = 2; 
            Console.WriteLine("What is your Wizard's Element?\nChoose 1 for Ice\nChoose 2 for Fire\nChoose 3 for Earth\nChoose 4 for Air");
            int element = Convert.ToInt16(Console.ReadLine());
            if(element == 1)
            {
                Console.Write("Your Wizard is named " + wizard03.name + " and is the Ice Element Type");
                wizard03.spellType = "Ice";
            }
            else if(element == 2)
            {
                  Console.Write("Your Wizard is named " + wizard03.name + " and is the Fire Element Type");
                  wizard03.spellType = "Fire";
            }
            else if(element == 3)
            {
                  Console.Write("Your Wizard is named " + wizard03.name + " and is the Earth Element Type");
                  wizard03.spellType = "Earth";
            }
            else
            {
                  Console.Write("Your Wizard is named " + wizard03.name + " and is the Air Element Type");
                  wizard03.spellType= "Air";
            }

        for (int i = 0; i < 6; i++)
        {
            Random numberGen = new Random();
            int wizardNumber = 0;
            wizardNumber = numberGen.Next(0,2);
            if(wizardNumber == 0)
            {
                string opponent = wizard01.name;
                Console.WriteLine("\nYou are attacked by " + opponent);
            }
            else
            {
                string opponent = wizard02.name;
                Console.WriteLine("\nYou are attacked by " + opponent);
            }

            Console.WriteLine("\nWhat would you like " + wizard03.name + " to do?\nPress 1 for Attack \nPress 2 for Meditate");
            int move = Convert.ToInt16(Console.ReadLine());
            if(move == 1)
            {
                wizard03.castSpell();
                if(healthbar < 1)
                {
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
            else
            {
                wizard03.Meditate();
                Console.WriteLine("You currently have " + wizard03.spellsRemaining + " and " + healthbar + " health remaining!");
            }
        }

            if(wizard03.experience <= 1)
            {
              Console.WriteLine(wizard03.name + " Finished at Level 1.\nCongrats you've passed the Trials of the Wizards!!");   
            }
            else if(wizard03.experience >= 2 && wizard03.experience <= 3)
            {
              Console.WriteLine(wizard03.name + " Finished at Level 2.\nCongrats you've passed the Trials of the Wizards!!");
            }
            else if(wizard03.experience >= 3 && wizard03.experience <= 4)
            {
                Console.WriteLine(wizard03.name + " Finished at Level 3.\nCongrats you've passed the Trials of the Wizards!!");
            }
            else
            {
                Console.WriteLine(wizard03.name + " Finished at Level 4.\nCongrats you've passed the Trials of the Wizards!!");
            }
        

            //Wait before Closing
            Console.ReadKey();
        }
    }
}
