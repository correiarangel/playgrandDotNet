using propiedMetodCosntrutores.Models;

Person person = new Person();

Course course = new Course();

person.Name = "Juca";
person.LastName = "Pirama";
person.Age = 30;
course.AddStudent(person);

Person p = new Person(name:"Juão",lastName:"Mane",age:30);



course.AddStudent(p);
course.CountStudent();
course.ShowStudent();


/* course.RemoveStudent(person);
course.CountStudent();
course.ShowStudent(); */