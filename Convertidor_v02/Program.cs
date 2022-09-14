//Librerias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//PD: DESCONOZCO LAS LIBRERIAS DE ARRIBA

namespace Convertidor_v02
{
    class Program
    {
        static void Main(string[] args)//Inicio del programa
        {
            Thread.Sleep(800);
            //declaracion de variables
            double kg = 2.2045;
            double lb = 0.4536;
            double res_final;
            int salida = 9;
            int inicio = 8;

        //inicio del case 1 y 2
         inicio_1:
         inicio_3:
                //impresion de pantalla del menu
                Console.WriteLine("Wey que desea convertir:" + "\n" +
                    "(1) conversion de kilogramo a libra" + "\n" +
                    "(2) conversion de libra a kilogramo" + "\n" +
                    "(4) regresar al inicio" + "\n" +
                    "(5) informacion de como se realiza la conversion" + "\n" +
                    "(9) salir" + "\n" +
                    "");

                Thread.Sleep(800);//temporizador para cargar la siguiente linea
                Console.WriteLine("Cargado.........");

                //Captura de opcion a escoger
                Console.WriteLine("Ingrese la opcion que desea realizar: ");
                int escoger = Convert.ToInt32(Console.ReadLine());//Guarda el valor escogido


            //Inicio del switch

        inicio_2: switch (escoger) //dependiendo del valor escogido realizara cierta opcion(case)
                {

                //________________________________________________________________________________

                    case 1://primera opcion
                        Console.WriteLine("Ingrese el cantidad para canvertir: ");
                        double num = Convert.ToDouble(Console.ReadLine());

                        res_final = num * kg;

                        Console.WriteLine("Resultado de l conversion: " + res_final);

                    //ventana de opcion de retorno o de salida
                    Thread.Sleep(800);

                    Console.WriteLine("\n" + "desea volver haccer una nueva conversion: " + "\n" +
                        "escriba un (7), si desea regresar al menu de inicio : " + "\n" +
                        "escriba un (8), si desea regresar: " + "\n" +
                        "escriba un (9), si no desea regresar y desea finalizar el programa: " + "\n" +
                        " ");
                    int des_2 = Convert.ToInt32(Console.ReadLine());

                    if (des_2 == 8) { goto inicio; } else if (des_2 == 9) { goto salida_2; } else if (des_2 == 7) { goto inicio_1; } else { return; }

                    //hasta aqui termina la ventana de retorno o de salida

                    break;
                //____________________________________________________________________________________

                //______________________________________________________________________________________

                case 2://segunda opcion 
                        Console.WriteLine("Ingrese el cantidad para canvertir: ");
                        double num_2 = Convert.ToDouble(Console.ReadLine());

                        res_final = num_2 * lb;

                        Console.WriteLine("Resultado de la conversion: " + res_final);
                        
                    //ventana de opcion de retorno o de salida
                        Thread.Sleep(800);

                        Console.WriteLine("\n" + "desea volver haccer una nueva conversion: " + "\n" +
                            "escriba un (7), si desea regresar al menu de inicio : " + "\n" +
                            "escriba un (8), si desea regresar: " + "\n" +
                            "escriba un (9), si no desea regresar y desea finalizar el programa: " + "\n" +
                            " ");
                        int des = Convert.ToInt32(Console.ReadLine());

                    if (des == 8) { goto inicio; } else if (des == 9) { goto salida_2; } else if (des == 7) { goto inicio_1; } else { return; }//su objectivo realizar la peticion del usuario que toma en la venta de retorno o de slida
                         
                        /*salida = des;
                        inicio = des;*/
                    //hasta aqui termina la ventana de retorno o de salida
                       
                        break;

                    //________________________________________________________________________________________

                    case 4://opcion de regreso 
                inicio:
                    goto inicio_2;

                        break;

                //_______________________________________________________________________________________

                case 5:
                    Console.WriteLine("Para mas informacion ingrese el siguiente enlace: ");

                    //ventana de opcion de retorno o de salida
                    Thread.Sleep(800);

                    Console.WriteLine("\n" + "desea volver haccer una nueva conversion: " + "\n" +
                        "escriba un (8), si desea regresar: " + "\n" +
                        "escriba un (9), si no desea regresar y desea finalizar el programa: " + "\n" +
                        " ");
                    int des_3 = Convert.ToInt32(Console.ReadLine());

                    if (des_3 == 8) { goto inicio_3; } else if (des_3 == 9) { goto salida_2; } else { return; }//su objectivo realizar la peticion del usuario que toma en la venta de retorno o de slida

                    /*salida = des;
                    inicio = des;*/
                    //hasta aqui termina la ventana de retorno o de salida

                    break;

                    //________________________________________________________________________________________

                    case 9://Salida
                    salida_2:
                        Console.WriteLine("Saliendo, espere un momento.....");
                        Thread.Sleep(800);
                        goto salida;//ir a la linea 80 (cierre de programa)
                        break;

                    //_________________________________________________________________________________________

                }//fin del switch 

            

            Console.ReadKey();//para que no cierre el program de golpe
        salida: return;//salida del case 9
        



        }//fin del programa


    }

}//fin del la clase del programa principal 



