//Створити суперклас Навчальний заклад і підкласи Школа, Університет, Факультет, Кафедра.
//Подумати, які з вищенаведених підкласів також можуть бути суперкласами.
//За допомогою конструктора задати кількість учнів у закладі.
//Визначити кількість викладачів у навчальному закладі, кількість класів у школі та рік заснування факультету.
//Вивести на екран кількість факультетів в університеті.

using _2sem_lab5;

School sch = new School("High School", 500, 30, 20);
sch.PrintInfo();

University uni = new University("KPI", 25000, 2000, 14);
uni.PrintInfo();

Faculty faculty = new Faculty("FICE", 2000, 200, 1962);
faculty.PrintInfo();

Cathedra cath = new Cathedra("IST", 200, 150, "Kornaga");
cath.PrintInfo();



Console.ReadKey();

