using CreationalDesignPattern.Builder.BuilderDesignPattern.EX1;
using CreationalDesignPattern.Builder.BuilderDesignPattern.EX1.ConcreteBuilder;
using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2;
using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.ConcreteBuilder;
using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern;
using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;
using CreationalDesignPattern.Fluent.FluentInterfaceDesignPattern;
using CreationalDesignPattern.Singleton.NoThreadSafeSingletonDesignPattern;
using FactoryDesignPattern = CreationalDesignPattern.Factory.FactoryDesignPattern;
using FactoryDesignPatternInterface = CreationalDesignPattern.Factory.FactoryDesignPattern.Interface;
using FactoryMethodDesignPattern = CreationalDesignPattern.Factory.FactoryMethodDesignPattern;
using FactoryMethodDesignPatternInterface = CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;
using ThreadSafeSingletonDesignPattern = CreationalDesignPattern.Singleton.ThreadSafeSingletonDesignPattern;
using EagerLoadingSingletonDesignPattern = CreationalDesignPattern.Singleton.EagerLoadingSingletonDesignPattern;
using LazyLoadingSingletonDesignPattern = CreationalDesignPattern.Singleton.LazyLoadingSingletonDesignPattern;

#region Factory

#region Factory Design Pattern
Console.WriteLine("Factory Design Pattern");
FactoryDesignPatternInterface.ICreditCard creditCard1 = FactoryDesignPattern.CardFactory.GetCreditCard("Platinum");
Console.WriteLine("Card Type : {0}", creditCard1.GetCardType());
Console.WriteLine("Card Annual Charge : {0}", creditCard1.GetAnnualCharge());
Console.WriteLine("Card Credit Limit : {0}", creditCard1.GetCreditLimit());
Console.WriteLine();
#endregion


#region Factory Method Design Pattern
Console.WriteLine("Factory Method Design Pattern");
FactoryMethodDesignPatternInterface.ICreditCard creditCard2 = new FactoryMethodDesignPattern.TitaniumFactory().SetCreditCard();
Console.WriteLine("Card Type : {0}", creditCard2.GetCardType());
Console.WriteLine("Card Annual Charge : {0}", creditCard2.GetAnnualCharge());
Console.WriteLine("Card Credit Limit : {0}", creditCard2.GetCreditLimit());
Console.WriteLine();
#endregion


#region Abstract Factory Design Pattern
Console.WriteLine("Abstract Factory Design Pattern");
AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory("Land");
IAnimal animal = animalFactory.GetAnimal("Lion");
Console.WriteLine("Animal Type : {0}", animal.GetType().Name);
Console.WriteLine("Animal Speak : {0}", animal.Speak());
Console.WriteLine();
#endregion

#endregion


#region Builder Design Pattern
Console.WriteLine("Builder Design Pattern");
ReportDirector reportDirector = new ReportDirector();
PDFReport pdfReport = new PDFReport();
Report report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();
Console.WriteLine();

Console.WriteLine("Builder Design Pattern");
BeverageDirector beverageDirector = new BeverageDirector();
CoffeeBeverage coffeeBeverage = new CoffeeBeverage();
Beverage beverage = beverageDirector.MakeBeverage(coffeeBeverage);
Console.WriteLine(beverage.ShowBeverage());
Console.WriteLine();
#endregion



#region Fluent Interface Design Pattern
Console.WriteLine("Fluent Interface Design Pattern");
FluentEmployee employee = new FluentEmployee();
var data = employee.EmployeeId(1).EmployeeName("EmployeeName").EmployeeEmail("EmployeeEmail").EmployeeSalary(750);
//Console.WriteLine("Employee ID : {0}");
//Console.WriteLine("Employee Name : {0}");
//Console.WriteLine("Employee Email : {0}");
//Console.WriteLine("Employee Salary : {0}");
Console.WriteLine();
#endregion


#region Singleton Design Pattern
Console.WriteLine("Singleton Design Pattern");
Singleton fromTeachaer = Singleton.GetInstance;
fromTeachaer.PrintDetails("From Teacher");
Singleton fromStudent = Singleton.GetInstance;
fromStudent.PrintDetails("From Student");
Console.WriteLine();
#endregion


#region Thread Safe Singleton Design Pattern
Console.WriteLine("Thread Safe Singleton Design Pattern");
Parallel.Invoke(
    () => {
        ThreadSafeSingletonDesignPattern.Singleton fromTeacher = ThreadSafeSingletonDesignPattern.Singleton.GetInstance;
        fromTeacher.PrintDetails("From Teacher");
    },
    () => {
        ThreadSafeSingletonDesignPattern.Singleton fromStudent = ThreadSafeSingletonDesignPattern.Singleton.GetInstance;
        fromStudent.PrintDetails("From Student");
    });
Console.WriteLine();
#endregion


#region Eager Loading Thread Safe Singleton Design Pattern
Console.WriteLine("Eager Loading Thread Safe Singleton Design Pattern");
Parallel.Invoke(
    () => {
        EagerLoadingSingletonDesignPattern.Singleton fromTeacher = EagerLoadingSingletonDesignPattern.Singleton.GetInstance;
        fromTeacher.PrintDetails("From Teacher");
    },
    () => {
        EagerLoadingSingletonDesignPattern.Singleton fromStudent = EagerLoadingSingletonDesignPattern.Singleton.GetInstance;
        fromStudent.PrintDetails("From Student");
    });
Console.WriteLine();
#endregion

#region Lazy Loading Thread Safe Singleton Design Pattern
Console.WriteLine("Lazy Loading Thread Safe Singleton Design Pattern");
Parallel.Invoke(
    () => {
        LazyLoadingSingletonDesignPattern.Singleton fromTeacher = LazyLoadingSingletonDesignPattern.Singleton.GetInstance;
        fromTeacher.PrintDetails("From Teacher");
    },
    () => {
        LazyLoadingSingletonDesignPattern.Singleton fromStudent = LazyLoadingSingletonDesignPattern.Singleton.GetInstance;
        fromStudent.PrintDetails("From Student");
    });
Console.WriteLine();
#endregion