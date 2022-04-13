﻿using CreationalDesignPattern.AbstractFactoryDesignPattern;
using CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;
using FactoryDesignPattern = CreationalDesignPattern.FactoryDesignPattern;
using FactoryDesignPatternInterface = CreationalDesignPattern.FactoryDesignPattern.Interface;
using FactoryMethodDesignPattern = CreationalDesignPattern.FactoryMethodDesignPattern;
using FactoryMethodDesignPatternInterface = CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

#region Factory Design Pattern
FactoryDesignPatternInterface.ICreditCard creditCard1 = FactoryDesignPattern.CardFactory.GetCreditCard("Platinum");

Console.WriteLine("Card Type : {0}", creditCard1.GetCardType());
Console.WriteLine("Card Annual Charge : {0}", creditCard1.GetAnnualCharge());
Console.WriteLine("Card Credit Limit : {0}", creditCard1.GetCreditLimit());
Console.WriteLine();
#endregion


#region Factory Method Design Pattern
FactoryMethodDesignPatternInterface.ICreditCard creditCard2 = new FactoryMethodDesignPattern.TitaniumFactory().SetCreditCard();

Console.WriteLine("Card Type : {0}", creditCard2.GetCardType());
Console.WriteLine("Card Annual Charge : {0}", creditCard2.GetAnnualCharge());
Console.WriteLine("Card Credit Limit : {0}", creditCard2.GetCreditLimit());
Console.WriteLine();
#endregion


#region Abstract Factory Design Pattern
AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory("Land");
IAnimal animal = animalFactory.GetAnimal("Lion");

Console.WriteLine("Animal Type : {0}", animal.GetType().Name);
Console.WriteLine("Animal Speak : {0}", animal.Speak());
Console.WriteLine();
#endregion