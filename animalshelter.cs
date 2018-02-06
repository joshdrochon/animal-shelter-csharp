using System;
using System.Collections.Generic;

public class Animal
{
  public string Name;
  public int Age;
  public string Species;
  public string Gender;
  public bool Available;
}

public class Program
{
  public static void Main()
  {
    Animal jack = new Animal();
    jack.Name = "Jack";
    jack.Age = 2;
    jack.Species = "Dog";
    jack.Gender = "Male";
    jack.Available = false;

    Animal buster = new Animal();
    buster.Name = "Buster";
    buster.Age = 4;
    buster.Species = "Dog";
    buster.Gender = "Male";
    buster.Available = false;

    Animal pearl = new Animal();
    pearl.Name = "Pearl";
    pearl.Age = 6;
    pearl.Species = "Cat";
    pearl.Gender = "Female";
    pearl.Available = true;


    List<Animal> Profile = new List<Animal>() { jack, buster, pearl};

    Animal slithers = new Animal();
    slithers.Name = "Slithers";
    slithers.Age = 32;
    slithers.Species = "Snake";
    slithers.Gender = "N/A";
    slithers.Available = true;

    Profile.Add(slithers);

    slithers.Age = 27;
    slithers.Gender = "female";

    List<Animal> Adoptable = new List<Animal>();

    foreach (Animal element in Profile)
    {
      if(element.Available == true)
      {
        Adoptable.Add(element);
      }
    }

    Console.WriteLine("Would you like to see only the adoptable animals? ['Y' for yes. 'Enter' for now]");

    string response = Console.ReadLine().ToUpper();

    if(response == "Y")
    {
      Console.WriteLine("GEt it!");
    }
    else

  }
}
