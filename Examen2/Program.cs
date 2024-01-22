using System;

namespace Examen2
{
    internal class Program
    {
       
        
            static void Main()
            {
                Console.Write("Numarul de persoane: ");
                int numberOfPeople = int.Parse(Console.ReadLine());

                Person[] people = new Person[numberOfPeople];

                for (int i = 0; i < numberOfPeople; i++)
                {
                    Console.WriteLine($"Persoana {i + 1}:");
                    Console.Write("Prenume: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Nume de familie: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Anul nasterii: ");
                    int yearOfBirth = int.Parse(Console.ReadLine());

                    people[i] = new Person
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        YearOfBirth = yearOfBirth
                    };
                }

                
                Person oldestPerson = PersonProcessor.GetOldestPerson(people);

                if (oldestPerson != null)
                {
                    Console.WriteLine($"Persoana cu varsta cea mai mare este: {oldestPerson.FirstName} {oldestPerson.LastName}, Varsta: {oldestPerson.Age}");
                }
                else
                {
                    Console.WriteLine("Nu s-au introdus persoane.");
                }
            }
        }