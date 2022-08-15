// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

double Distance (double x1, double y1,
                double z1,double x2, 
                double y2, double z2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return dist;
}
double mydist = Distance(7, -5, 0, 1, -1, 9);
Console.WriteLine(mydist);
