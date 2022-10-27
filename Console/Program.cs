// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;

ApartmentManager apartmentManager = new ApartmentManager(new EfApartmentDal());
Console.WriteLine("dfsdfsd");
//Apartment apartment=new Apartment() {Status=true,BlockId=1,Floor=4,Number=15,Type="3+1"};

//partmentManager.Add(apartment);

var result=apartmentManager.GetById(2).Data;
Console.WriteLine(result.Floor);
//foreach (var item in apartmentManager.GetAll().Data)
//{
//    Console.WriteLine(item.Number);
//}sdsdsdsdsds