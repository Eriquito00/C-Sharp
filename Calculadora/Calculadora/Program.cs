using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int queTriar;
            Console.WriteLine("Exercici a provar? (1 suma 2 resta 3 multiplica 4 divideix 5 calcula preu PC)");
            queTriar = Convert.ToInt32(Console.ReadLine());
            switch (queTriar){

                case 1:
                    double suma1;
                    double suma2;
                    double resultatSuma;
                    Console.WriteLine("Suma");
                    Console.WriteLine("Posa el primer valor per sumar: ");
                    suma1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Posa el segon valor per sumar: ");
                    suma2 = Convert.ToDouble(Console.ReadLine());
                    resultatSuma = suma1 + suma2;
                    Console.WriteLine("El resultat de la suma es: " + resultatSuma + ".");
                    Console.ReadLine();
                    break;

                case 2:
                    double resta1;
                    double resta2;
                    double resultatResta;
                    Console.WriteLine("Resta");
                    Console.WriteLine("Posa el primer valor per restar: ");
                    resta1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Posa el segon valor per restar: ");
                    resta2 = Convert.ToDouble(Console.ReadLine());
                    resultatResta = resta1 - resta2;
                    Console.WriteLine("El resultat de la resta es: " + resultatResta + ".");
                    Console.ReadLine();
                    break;

                case 3:
                    double multi1;
                    double multi2;
                    double resultatMulti;
                    Console.WriteLine("Multiplica");
                    Console.WriteLine("Posa el primer valor per multiplicar: ");
                    multi1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Posa el segon valor per multiplicar: ");
                    multi2 = Convert.ToDouble(Console.ReadLine());
                    resultatMulti = multi1 * multi2;
                    Console.WriteLine("El resultat de la multiplicacio es: " + resultatMulti + ".");
                    Console.ReadLine();
                    break;

                case 4:
                    double divi1;
                    double divi2;
                    double resultatDivi;
                    double resultatDiviResta;
                    Console.WriteLine("Divideix");
                    Console.WriteLine("Posa el primer valor per dividir: ");
                    divi1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Posa el segon valor per dividir: ");
                    divi2 = Convert.ToDouble(Console.ReadLine());
                    resultatDivi = divi1 / divi2;
                    resultatDiviResta = divi1 % divi2;
                    Console.WriteLine("El resultat de la divicio es: " + resultatDivi + " i la resta de la divicio es " + resultatDiviResta + ".");
                    Console.ReadLine();
                    break;

                case 5:
                    double preuPc;
                    double Iva;
                    double Descompte;
                    double resultatPreu;
                    Console.WriteLine("Calcul preu pc");
                    Console.WriteLine("Posa el preu del teu ordinador");
                    preuPc = Convert.ToDouble(Console.ReadLine());
                    Iva = preuPc * 0.21;
                    Descompte = preuPc * 0.22;
                    resultatPreu = preuPc + Iva - Descompte;
                    Console.WriteLine("L'Iva es " + Iva + ", el descompte es " + Descompte + ", i el total a pagar es " + resultatPreu + ".");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
