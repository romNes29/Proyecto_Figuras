using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFIguras
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    menu_principal();
                    break;
                }catch(Exception e)
                {
                    Console.WriteLine("Error, por favor ingrese valores numericos.");
                    Console.Clear();
                }

            }




        }

        public static void muestra_Proposito()
        {
            Console.WriteLine("****************************************************************************************************\n"
                             +"* Este programa permite encontrar el área de un rectángulo, un cuadrado, un circulo y un triángulo *"+
                            "\n****************************************************************************************************\n"+
                              "* MENÚ *\n"+
                              "****************************");
        }
        public static void opciones_menu()
        {
            Console.WriteLine(
                  "* 1. Area de un rectangulo *" +
                "\n* 2. Area de un cuadrado.  *" +
                "\n* 3. Area de un circulo.   *" +
                "\n* 4. Area de un triangulo  *" +
                "\n* 5. Salir del programa    *" +
                "\n****************************" +
                "\n"+"\n");
            Console.WriteLine("Por favor ingrese una opción:");


        }
        public static void menu_principal()
        {
            int opcion = 0;
            while (opcion < 5)
            {
                muestra_Proposito();
                opciones_menu();
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        (double base_figura, double altura_figura) = solicita_medidas();
                        Console.WriteLine("---------------------------------------------------\n" +
                                          "Area de rectángulo: " + (float)area_Rectangulo(base_figura, altura_figura)+
                                          "\n---------------------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para regresar al menú.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la medida del lado: ");
                        double altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("---------------------------------------------------\n" + 
                                          "Area de cuadrado: " + area_Cuadrado(altura)+
                                          "\n---------------------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para regresar al menú.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Ingrese la medida del radio:");
                        double radio_circulo = double.Parse(Console.ReadLine());
                        Console.WriteLine("---------------------------------------------------\n" + 
                                          "Area del círculo: " + area_Circulo(radio_circulo)+
                                          "\n---------------------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para regresar al menú.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        (double base_triangulo, double altura_triangulo) = solicita_medidas();
                        Console.WriteLine("---------------------------------------------------\n" +
                                          "Area del triángulo:" + area_Triangulo(base_triangulo, altura_triangulo)+
                                          "\n---------------------------------------------------");
                        Console.WriteLine("Presione cualquier tecla para regresar al menú.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("-------------------------------------------"+
                                        "\n|              ¡Hasta Pronto!             |");
                      Console.WriteLine("\n| Presione cualquier teclas para salir... |"+
                                        "\n-------------------------------------------");
                        Console.ReadKey();
                        break;

                } //Close Switch

            } //Close while
        }

        public static (double,double) solicita_medidas()
        {
            Console.WriteLine("Ingrese la medida de la base:");
            double baseF = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la altura:");
            double altura = double.Parse(Console.ReadLine()); ;
            return (baseF,altura);
        }


        public static double area_Rectangulo(double baseF, double altura)
        {
            double area_rectangulo = 0;
            area_rectangulo = (baseF * altura);
            return (float)area_rectangulo;
        }

        public static double area_Cuadrado(double lado)
        {
            double area_cuadrado = 0.0;
            area_cuadrado = (lado * lado);
            return (float)area_cuadrado;
        }

        public static double area_Triangulo(double baseF, double altura)
        {
            double area_triangulo = 0;
            area_triangulo = ((baseF * altura) / 2);

            return (float)area_triangulo;
        }
        public static double area_Circulo(double radioC)
        {
            double area_circulo = 0;
            double pi = 3.14;
            area_circulo = pi * (Math.Pow(radioC,2));
            return (float)area_circulo;
        }
    }


}


