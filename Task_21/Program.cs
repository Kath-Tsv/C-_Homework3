// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double xA = 1;
double yA = 10;
double zA = 15;
double xB = 2;
double yB = 20;
double zB = 25;

Task21 (xA, yA, zA, xB, yB, zB);

void Task21 (double xA, double yA, double zA, double xB, double yB, double zB)
{
   double distance = Math.Sqrt((Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2)));
    Console.WriteLine ($"Расстояние между точками А ({xA}, {yA}, {zA}) и В ({xB}, {yB}, {zB}) равно: {distance}");
}