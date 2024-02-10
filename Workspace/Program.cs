using Business.Concrete;
using Entities.Concrete;

Person person = new Person();

person.Name = "ÖZLEM";
person.LastName = "AKGÜNOĞLU";
person.NationalID = 11215648945;
person.BirthYear = 1998;

PttManager pttManager=new PttManager(new PersonManager());
pttManager.GiveMask(person);




