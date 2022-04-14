using CreationalDesignPattern.Builder.BuilderDesignPattern.EX1;
using CreationalDesignPattern.Builder.BuilderDesignPattern.EX1.ConcreteBuilder;
using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2;
using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.ConcreteBuilder;
using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern;
using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;
using FactoryDesignPattern = CreationalDesignPattern.Factory.FactoryDesignPattern;
using FactoryDesignPatternInterface = CreationalDesignPattern.Factory.FactoryDesignPattern.Interface;
using FactoryMethodDesignPattern = CreationalDesignPattern.Factory.FactoryMethodDesignPattern;
using FactoryMethodDesignPatternInterface = CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;


#region Factory

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

#endregion


#region Builder Design Pattern
ReportDirector reportDirector = new ReportDirector();
PDFReport pdfReport = new PDFReport();
Report report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();
Console.WriteLine();

BeverageDirector beverageDirector = new BeverageDirector();
CoffeeBeverage coffeeBeverage = new CoffeeBeverage();
Beverage beverage = beverageDirector.MakeBeverage(coffeeBeverage);
Console.WriteLine(beverage.ShowBeverage());
Console.WriteLine();
#endregion