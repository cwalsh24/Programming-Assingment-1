/**
 * @file Program.cs
 * @author Connor Walsh
 * @date 2023-1-19
 * @brief this is the library header file
 * 
 * This program allows the user to build a list of animals and search for information on said list. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assingment_1_Animal_List
{
    /**
      * The Animal class contains abstract methods for an Animal object that are to be overwritten.
      *
      * @class Animal
      * @brief abstract class representing an animal.
      *
      */
    public abstract class Animal
    {
        //private variables containing the different attributes of an animal
        private string Name;
        private int Age;
        private string Noise;
        private int Weight;

        /**
          * The printInfo method prints the information associated with an Animal object.
          * This method is abstract so it does not contain any actual implementation. It is meant to be overwritten.
          *
          * @pre An animal object must be declared.
          * @return void This function returns nothing.
          * @post The information has been printed.
          * 
          */
        public abstract void printInfo();

        /**
          * The makeNoise method prints the information associated with an Animal object.
          * This method is abstract so it does not contain any actual implementation. It is meant to be overwritten.
          *
          * @pre An animal object must be declared.
          * @return void This function returns nothing.
          * @post The noise has been printed.
          * 
          */
        public abstract void makeNoise();

        /**
          * The ageUp method increases the age value for an Animal object
          * This method is abstract so it does not contain any actual implementation. It is meant to be overwritten.
          *
          * @pre An animal object must be declared.
          * @return void This function returns nothing.
          * @post The age value has been increased.
          * 
          */
        public abstract void ageUp();

        /**
          * The attributes method takes in user specified values for Name, Age, and Weight so that they can be initialized.
          * This method is abstract so it does not contain any actual implementation. It is meant to be overwritten.
          *
          * @pre An animal object must be declared.
          * @return void This function returns nothing.
          * @post The variables have been initialized.
          * 
          */
        public abstract void attributes(string nameInput, int ageInput, int weightInput);

        /**
          * These are the getter and setter methods for the Name variable. We need this because it is private.
          *
          * @pre An animal object must be declared.
          * @return The setter method is void, the getter returns the Name value which is a string.
          * @post The getter returns the value of Name, the setter changes the value of Name.
          * 
          */
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        /**
          * These are the getter and setter methods for the Age variable. We need this because it is private.
          *
          * @pre An animal object must be declared.
          * @return The setter method is void, the getter returns the Age value which is an int.
          * @post The getter returns the value of Age, the setter changes the value of Age.
          * 
          */
        public int age
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        /**
          * These are the getter and setter methods for the Noise variable. We need this because it is private.
          *
          * @pre An animal object must be declared.
          * @return The setter method is void, the getter returns the Noise value which is a string.
          * @post The getter returns the value of Noise, the setter changes the value of Noise.
          * 
          */
        public string noise
        {
            get
            {
                return Noise;
            }

            set
            {
                Noise = value;
            }
        }

        /**
          * These are the getter and setter methods for the Weight variable. We need this because it is private.
          *
          * @pre An animal object must be declared.
          * @return The setter method is void, the getter returns the Weight value which is an int.
          * @post The getter returns the value of Weight, the setter changes the value of Weight.
          * 
          */
        public int weight
        {
            get
            {
                return Weight;
            }

            set
            {
                Weight = value;
            }
        }
    }

    /**
      * The Cat class overrwrites the abstract methods in the Animal class for a Cat object
      *
      * @class Cat
      * @brief concrete class representing a cat
      *
      */
    public class Cat : Animal
    {
        /**
          * The attributes method from the Animal class is overwritten here in order to replace the values of 
          * it's private variables with ones that are associated with a Cat. Three of these are user inputted.
          *
          * @pre A Cat object must be declared.
          * @return void This function returns nothing.
          * @post The private variables have been assigned their values.
          * 
          */
        public override void attributes(string nameInput, int ageInput, int weightInput) 
        {
            //noise is automatically set when the constructor is called because there isn't a reason for it to change
            noise = "meow";
            name = nameInput;
            age = ageInput;
            weight = weightInput;
        }

        /**
          * The printInfo method from the Animal class is overwritten here in order to print the information
          * associated with the Cat object. 
          *
          * @pre A Cat object must be declared.
          * @return void This function returns nothing.
          * @post The information for the Cat object has been printed.
          * 
          */
        public override void printInfo()
        {
            //prints out the information for the Cat object
            Console.WriteLine("Species: Cat");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Noise: " + noise);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight + " lbs");
        }

        /**
          * The makeNoise method from the Animal class is overwritten here in order to print the noise
          * associated with the Cat object. 
          *
          * @pre A Cat object must be declared.
          * @return void This function returns nothing.
          * @post The noise the cat makes is printed.
          * 
          */
        public override void makeNoise()
        {
            //prints out the noise the cat makes
            Console.WriteLine(noise);
        }

        /**
          * The ageUp method from the Animal class is overwritten here in order to increase the Age value 
          * associated with the Cat object. 
          *
          * @pre A Cat object must be declared.
          * @return void This function returns nothing.
          * @post The Age value is increased by 1, a message is printed to the user. 
          * 
          */
        public override void ageUp()
        {
            //increases the age value by one
            Console.WriteLine(name + "'s age has been increased by one year");
            age = age + 1;
        }
    }

    /**
      * The Cassowary class overrwrites the abstract methods in the Animal class for a Cassowary object
      *
      * @class Cassowary
      * @brief concrete class representing a cassowary
      *
      */
    public class Cassowary : Animal
    {
        /**
          * The attributes method from the Animal class is overwritten here in order to replace the values of 
          * it's private variables with ones that are associated with a Cassowary. Three of these are user inputted.
          *
          * @pre A Cassowary object must be declared.
          * @return void This function returns nothing.
          * @post The private variables have been assigned their values.
          * 
          */
        public override void attributes(string nameInput, int ageInput, int weightInput)
        {
            noise = "squawk";
            name = nameInput;
            age = ageInput;
            weight = weightInput;
        }

        /**
          * The printInfo method from the Animal class is overwritten here in order to print the information
          * associated with the Cassowary object. 
          *
          * @pre A Cassowary object must be declared.
          * @return void This function returns nothing.
          * @post The information for the Cassowary object has been printed.
          * 
          */
        public override void printInfo()
        {
            //prints all of the information associated with the cassowary object
            Console.WriteLine("Species: Cassowary");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Noise: " + noise);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight + " lbs");
        }

        /**
          * The makeNoise method from the Animal class is overwritten here in order to print the noise
          * associated with the Cassowary object. 
          *
          * @pre A Cassowary object must be declared.
          * @return void This function returns nothing.
          * @post The noise the Cassowary makes is printed.
          * 
          */
        public override void makeNoise()
        {
            //prints the cassowary noise to the user
            Console.WriteLine(noise); 
        }

        /**
          * The ageUp method from the Animal class is overwritten here in order to increase the Age value 
          * associated with the Cassowary object. 
          *
          * @pre A Cassowary object must be declared.
          * @return void This function returns nothing.
          * @post The Age value is increased by 1, a message is printed to the user. 
          * 
          */
        public override void ageUp()
        {
            //increases the age value by 1
            Console.WriteLine(name + "'s age has been increased by one year");
            age = age + 1;
        }
    }

  /**
    * The Crab class overrwrites the abstract methods in the Animal class for a Crab object
    *
    * @class Crab
    * @brief concrete class representing a crab
    *
    */
    public class Crab : Animal
    {
        /**
          * The attributes method from the Animal class is overwritten here in order to replace the values of 
          * it's private variables with ones that are associated with a Crab. Three of these are user inputted.
          *
          * @pre A Crab object must be declared.
          * @return void This function returns nothing.
          * @post The private variables have been assigned their values.
          * 
          */
        public override void attributes(string nameInput, int ageInput, int weightInput)
        {
            noise = "money money money";
            name = nameInput;
            age = ageInput;
            weight = weightInput;
        }

        /**
          * The printInfo method from the Animal class is overwritten here in order to print the information
          * associated with the Crab object. 
          *
          * @pre A Crab object must be declared.
          * @return void This function returns nothing.
          * @post The information for the Crab object has been printed.
          * 
          */
        public override void printInfo()
        {
            //prints the information associated with the crab object
            Console.WriteLine("Species: Crab");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Noise: " + noise);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight + " lbs");
        }

        /**
          * The makeNoise method from the Animal class is overwritten here in order to print the noise
          * associated with the Crab object. 
          *
          * @pre A Crab object must be declared.
          * @return void This function returns nothing.
          * @post The noise the crab makes is printed.
          * 
          */
        public override void makeNoise()
        {
            //prints the noise the crab makes
            Console.WriteLine(noise); 
        }

        /**
          * The ageUp method from the Animal class is overwritten here in order to increase the Age value 
          * associated with the Crab object. 
          *
          * @pre A Crab object must be declared.
          * @return void This function returns nothing.
          * @post The Age value is increased by 1, a message is printed to the user. 
          * 
          */
        public override void ageUp()
        {
            //increases the crab's age by 1
            Console.WriteLine(name + "'s age has been increased by one year");
            age = age + 1;
        }
    }

  /**
    * The World class contains the driver for the code along with a method to help with creating the Animal list.
    *
    * @class World
    * @brief main driver for the code
    *
    */
    class World
    {
        //this line declares the animal list
        List<Animal> animalList = new List<Animal>();

        /**
          * The newEntry method is designed to take in a new Animal object and store it into the list with 
          * the user specified attributes.
          *
          * @pre The list and Animal object must be declared and a string must be created. 
          * @return void This function returns nothing.
          * @post The new Animal object has been stored inside of the list.
          * 
          */
        static void newEntry(string choice, List<Animal> animalList, Animal newAnimal)
        {
            //these variables will store in the user inputted attribute values
            string Name;
            string Age;
            string Weight;

            //if the number is 1 then a Cat object is created
            if (choice == "1")
            {
                newAnimal = new Cat();
            }

            //if the number is 2 then a Cassowary object is created
            else if (choice == "2")
            {
                newAnimal = new Cassowary();
            }

            //if the number is 3 then a Crab object is created
            else if (choice == "3")
            {
                newAnimal = new Crab();
            }

            //the function exits if the number is something other than 1, 2, or 3
            else
            {
                return;
            }

            //the following lines prompt the user to enter information about the animal
            Console.Write("Enter the name of your animal: ");
            Name = Console.ReadLine();
            Console.Write("Enter the age of your animal: ");
            Age = Console.ReadLine();
            Console.Write("Enter the weight of your animal in pounds: ");
            Weight = Console.ReadLine();

            //checks to see if the Age value is valid
            if(int.TryParse(Age, out int value1) == false)
            {
                Console.Write("Invalid Input");
                return;
            }

            //checks to see if the Weight value is valid
            if (int.TryParse(Weight, out int value2) == false)
            {
                Console.Write("Invalid Input");
                return;
            }

            //we need to call the attribute method to send the user inputted information to the 
            //class. The Age and Weight values must be converted from strings to integers. 
            newAnimal.attributes(Name, Convert.ToInt32(Age), Convert.ToInt32(Weight));

            //this line adds the animal object to the list
            animalList.Add(newAnimal);

            //prints a message letting the user know that the process was completed
            Console.WriteLine(Name + " has been added successfully");
        }


        /**
          * This is the main method for the program. It contains the looping menu that allows the user to call the different
          * classes and the methods inside of them to build their animal list.
          * 
          */
        static void Main(string[] args)
        {
            //declare the existance of a world object so we can use the methods
            World p = new World();
            //this variable stores the user's choice at the menu
            string userInput;

            //the following lines list the choices that are avaliable to the user
            Console.WriteLine("Welcome to the Animal List program!");
            Console.WriteLine("1. Print the list");
            Console.WriteLine("2. Print the info of an animal in the list");
            Console.WriteLine("3. Print the noise of an animal in the list");
            Console.WriteLine("4. Increase the age of an animal in the list");
            Console.WriteLine("5. Add a new animal to the list");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            //these lines prompt the user for their choice and store the choice
            Console.Write("Enter the number of the function you would like to perform: ");
            userInput = Console.ReadLine();

            //if the user enters the number 6, the loop exits and the program closes
            while (userInput != "6")
            {
                //if the user selects 1, the entire list and all info within is printed
                if (userInput == "1")
                {
                    //loops through the list and prints the info
                    foreach (Animal a in p.animalList)
                    {
                        //prints the info of the current animal
                        a.printInfo();
                    }
                }

                if (userInput == "2")
                {
                    string choice2;

                    Console.Write("Enter the name of the Animal: ");
                    choice2 = Console.ReadLine();

                    //searches the list for the name
                    Animal aObject = p.animalList.Find(n => n.name == choice2);

                    //prints the object information, needs the if statement incase the object isn't found
                    if (aObject != null)
                    {
                        Console.WriteLine();
                        aObject.printInfo();
                    }

                }

                if (userInput == "3")
                {
                    string choice;

                    Console.Write("Enter the name of the Animal: ");
                    choice = Console.ReadLine();

                    //searches the list for the name
                    Animal aObject = p.animalList.Find(n => n.name == choice);

                    //prints the object information, needs the if statement incase the object isn't found
                    if (aObject != null)
                    {
                        Console.WriteLine();
                        aObject.makeNoise();
                    }

                }

                if (userInput == "4")
                {
                    string choice;

                    Console.Write("Enter the name of the Animal: ");
                    choice = Console.ReadLine();

                    //searches the list for the name
                    Animal aObject = p.animalList.Find(n => n.name == choice);

                    //prints the object information, needs the if statement incase the object isn't found
                    if (aObject != null)
                    {
                        Console.WriteLine();
                        aObject.ageUp();
                    }

                }

                //if the user inputs the number 5, then this allows them to pick an Animal to add
                if (userInput == "5")
                {
                    string choice;
                    Console.WriteLine("Choices: 1. Cat | 2. Cassowary | 3. Crab");
                    Console.WriteLine();
                    Console.Write("Enter the number of the animal you would like to add: ");
                    choice = Console.ReadLine();
                    Console.WriteLine();

                    //the user's choice must be either 1 2 or 3 because there are no other animal options
                    if ((choice != "1") && (choice != "2") && (choice != "3"))
                    {
                        //if the user inputs an incorrect value they are given a warning
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        //since the Animal object is abstract we need to set it to null
                        Animal a = null;
                        //this should call the new animal method
                        newEntry(choice, p.animalList, a);

                    }

                }

                //these lines prompt the user for another choice
                Console.WriteLine();
                Console.Write("Enter another number of your choice: ");
                userInput = Console.ReadLine();
                Console.WriteLine();

            }

        }
    }
}

