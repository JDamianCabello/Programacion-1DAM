using System;
//-------------------------------
//Necesario para usar los Encoding de la consola (para mostrar caracteres que normalmente no se verian)
using System.Text;

namespace ExamenRecu1TrimResuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agregamos los encoding tanto de lectura como escritura (No se ha explicado aún es del año pasado).
            Console.InputEncoding = Encoding.Default;
            Console.OutputEncoding = Encoding.Default;


            //Llamamos a nuestro menú para iniciar el programa
            UIMenu();
        }

        static void UIMenu()
        {
            #region Variables necesarias

            //Declaro una variable ConsoleKeyInfo la cual es una estructura con estos datos : ConsoleKey key (tecla pulsada), char keychar (El caracter que envia) y ConsoleModifiers modifiers (lee teclas muertas ctrl, alt, mayus).
            ConsoleKeyInfo tecla;

            Console.CursorVisible = false; //Oculto el cursor por estetica.


            //Creo las dos matrices dentadas.
            #region ejemplos de inicializacion de matrices dentadas.
            /*  Empezamos declarando la matriz: Se declaran de la forma tipo[][] nombre = new tipo [dimensiones][]
                 *  
                 *  NOTA: hay 3 formas de declarar una matriz dentada
                 *  
                 *  
                 *  1:      char[][] primerEjemplo = new char[3][];
                 *          primerEjemplo[0] = new char[3];
                 *          primerEjemplo[1] = new char[6];
                 *          primerEjemplo[2] = new char[1];
                 *          
                 *          
                 *  2:      char[][] segundoEjemplo = new char[3][];
                 *          segundoEjemplo[0] = new char[] { 1, 2, 3 };
                 *          segundoEjemplo[1] = new char[] { 1, 2, 3, 4 ,5 ,6 };
                 *          segundoEjemplo[2] = new char[] { 1 };
                 *          
                 *          
                 *  3:      char[][] tercerEjemplo = new char[3][]
                 *          {
                 *              new char[3],
                 *              new char[6],
                 *              new char[1]
                 *          };
                 *          
                 *          
                 * Cualquiera de las 3 es totalmente válida para este ejercicio...
                 * Explicado esto la creamos.
                 */
            #endregion

            char[][] unaMatrizDentada = new char[3][]
            {
                new char[3],
                new char[6],
                new char[1]
            };

            char[][] copiaDeUnaMatrizDentada = new char[3][]
{
                new char[3],
                new char[6],
                new char[1]
};

            //VARIABLES NECESARIAS PARA el MÉTODO DEL EJERCICIO 2

            string fraseAEncriptar = string.Empty;
            int contador = 0; 
            #endregion

            #region Nota del menú
            /*
                 * Creamos un Do While dentro de otro, para asegurar que una vez sale del más interno (el menú en sí), podemos pedir confirmación para abandonar el programa.
                 * Otra forma sería añadir un case ConsoleKey.S: quedando solo con un do while
                 * 
                 * bool bandera = true;
                 * do
                 * {
                 *      switch(tecla.Key) 
                 *       {
                 *          case ConsoleKey.S:
                 *              Console.Clear();
                 *              Console.WriteLine(""Seguro que quieres salir? S/n");
                 *              tecla = Console.ReadKey(true);
                 *              if (tecla.Key == ConsoleKey.S)
                 *                  bandera = false
                 *              break;
                 *       }
                 * 
                 * }
                 * while(bandera)
                 */
            #endregion

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Examen recuperación 1er Trimestre resuelto.\n\n");
                    Console.WriteLine("{0}     {1}     {2}", "Cabello", "Juan Damián", DateTime.Now.ToShortDateString()); //Obtenemos la fecha actual de la clase DateTime con su método now() y luego ToShortDateString() para la fecha corta (forma dd/mm/aaaa).
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("\tA. Encriptación Cesar");
                    Console.WriteLine("\tB. Matriz de referencia");
                    Console.WriteLine("\tC. Cálculo de salarios");
                    Console.Write("\tS. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Salir");
                    Console.ResetColor();
                    tecla = Console.ReadKey(true); //Con la sobrecarga true quitamos el eco de la pantalla

                    switch(tecla.Key) //Nos basamos en el key de la tecla pues ya está implementada la enumeración en el lenguaje.
                    {
                        case ConsoleKey.A:
                            #region Menu Ej 2
                            Console.Clear();
                            //Declaro el string y el contador a valores por defecto por que sino, si entra desde el menú mantendrían sus antiguos valores (y creeme, no queremos eso).
                            fraseAEncriptar = string.Empty;
                            contador = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\t\tENCRIPTACIÓN CESAR\n");
                            Console.ResetColor();
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Tenga en cuenta que las letras ni siquiera se mostrarán en pantalla.");
                            Console.SetCursorPosition(0, 16);
                            Console.WriteLine("Pulse Esc para volver al menú principal.");
                            Console.CursorTop = 6;
                            Console.WriteLine("Por favor, introduce tu frase a encriptar:");

                            do
                            {
                                Console.SetCursorPosition(0, 10);
                                Console.Write("FRASE:  ");
                                Console.SetCursorPosition(0, 12);
                                Console.Write("\nEN CESAR: ");
                                tecla = Console.ReadKey(true);
                                if (char.IsDigit(tecla.KeyChar)) //Comprobamos si el caracter de la tecla pulsada es un número.
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(contador + 11, 10);
                                    Console.Write(tecla.KeyChar);
                                    Console.ResetColor();
                                    contador++;
                                    Console.SetCursorPosition(contador + 10, 13);
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(Cesar(tecla.KeyChar));
                                    Console.ResetColor();
                                }
                            } while (tecla.Key != ConsoleKey.Escape); //Si pulsamos Esc se ejecuta el break y nos devuelve al principio del Do While, es decir, al menú.
                            break; 
                        #endregion
                        case ConsoleKey.B:
                            #region Menu Ej 3
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\t\tMATRICES DENTADAS\n");
                            Console.ResetColor();
                            Console.WriteLine("--------------------------------------------------------------------");

                            Console.WriteLine("\nIntentando rellenar la matriz original...");
                            if (Rellenar(unaMatrizDentada))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nMatriz original rellenada aleatoriamente correctamente :)");
                                Console.ResetColor();
                            }
                            else
                                Console.WriteLine("Se produjo un error.");

                            Console.WriteLine("\nIntentando copiar la matriz original...");
                            if (Copiar(copiaDeUnaMatrizDentada, unaMatrizDentada))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nMatriz original copiada correctamente :)");
                                Console.ResetColor();
                            }
                            else
                                Console.WriteLine("Se produjo un error.");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\n\t\tMOSTRANDO MATRICES;");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nOriginal:");
                            Console.ResetColor();
                            Mostrar(unaMatrizDentada);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\nCopia:");
                            Console.ResetColor();
                            Mostrar(copiaDeUnaMatrizDentada);

                            Console.WriteLine("\n\nFIN... Pulsa una tecla para volver al menú principal.");
                            Console.ReadKey();
                            break; 
                        #endregion
                        case ConsoleKey.C:
                            CalcularSueldo();
                            break;
                    }
                } while(tecla.Key != ConsoleKey.S); //Estaremos en el while siempre que la enum de tecla.key no sea "S"
                Console.Clear();
                Console.WriteLine("Seguro que quieres salir? S/n");
                tecla = Console.ReadKey(true);
            } while(tecla.Key != ConsoleKey.S);

        }

        #region Método ejercicio 2

        /// <summary>
        /// Método que encripta un caracter con 5 posiciones a la derecha.
        /// </summary>
        /// <param name="frase">El caracter a desplazar a la derecha</param>
        /// <returns>El caracter ya desplazado</returns>
        static char Cesar(char caracter)
        {

            //Declaro una variable de tipo string para que el array nunca salga de los valores establecidos.
            //También serviria un array cualquier tipo (char, string, int, e incluso de object).
            const string NUMEROS = "0123456789";

            //Añado un char auxiliar para nunca modificar el caracter que llega.Podríamos usar el mismo que llega, que no pasaría nada, pero no es recomendable.
            char mander = '\0';

            //Añado también un booleano que usaré como flag (bandera) para terminar el bucle en caso de encontrar el número antes de tiempo y evitar iteraciones absurdas.
            bool salida = true;

            //Como usaré un while y quiero recorer el string "NUMEROS" necesito un contador para ir posición por posición.
            int contador = 0;


            while (salida)
            {
                //Compruebo si el caracter es igual a alguno de los del string "NUMEROS".
                if (caracter == NUMEROS[contador])
                {
                    //De ser así aplico la formula de array circular la cual es Indice % Array.Length.
                    mander = NUMEROS[(contador + 5) % NUMEROS.Length];

                    //También cambio la bandera a falso para que salga del while.
                    salida = false;
                }
                contador++; //Siempre que no se da el if aumentamos contador.
            }

            return mander;

            #region Notas Adicionales Del Método
            /*      NOTAS:
             * 
             *      -OTRAS FORMAS DE HACERLO:
             *      
             *      Se podría usar el bucle for pues esta pensado para realizar X iteraciones como por ejemplo recorrer el string "NUMEROS".
             *      El motivo de no usarlo es el break que hay dentro del if para terminar el bucle envolvente (es decir el for) pues este mismo esta pensado para acabar y terminar, y no para cortarse en la mitad. De ahí que use el while.
             *      
             *      
             *      Expongo el código del método
             *      
             *          for (int i = 0; i < NUMEROS.Length; i++)
             *              if (caracter == NUMEROS[i])
             *              {
             *                  auxCesar = NUMEROS[(i + 5) % NUMEROS.Length];
             *                  break;
             *              }
             *              
             *     Se podría pasar un string al método (Suponiendo que ya hemos controlado que solo entren números en él). Para hacerlo con el while necesitariamos otro contador más y con el for seria añadir uno más que recorra desde 0 hasta frase.Length.
             */
            #endregion
        } 

        #endregion

        #region Métodos Ejercicio 3

        /// <summary>
        /// Muestra una matriz dentada, sea cuales sean sus dimensiones.
        /// </summary>
        /// <param name="M"></param>
        static void Mostrar(char[][] M)
        {
            //Este primer for obtiene el total de dimensiones de la matriz con M.Length (en este caso 3).
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write("DIMENSIÓN [{0}] -> \t", i);
                //Este otro for obtiene el Length de la posicion de i, es decir desde la 0 hasta la 3.
                for (int j = 0; j < M[i].Length; j++)
                    Console.Write(M[i][j] + "\t");
                Console.WriteLine(); //Se añade el salto de línea para dar su correspondiente formato.
            }
        }

        /// <summary>
        /// Rellena una matriz aleatoriamente con letras mayúsculas desde la A hasta la Z.
        /// </summary>
        /// <param name="M">La matriz dentada a rellenar aleatoriamente.</param>
        /// <returns>La matriz dentada con valores pseudoaleatorios.</returns>
        static bool Rellenar(char[][] M)
        {
            //Instancio la clase random para crear resultados pseudoaleatorios.
            Random rnd = new Random();

            for (int i = 0; i < M.Length; i++)
                for (int j = 0; j < M[i].Length; j++)
                    M[i][j] = (char)rnd.Next('A', 'Z' + 1); //Añado desde el caracter A hasta la Z (en el random siempre es final -1, de ahí ese +1). Obviamente el método random solo trabaja con enteros por lo que usará su ASCII, luego aplico una conversión explicita con el "(char)".

            return true;
        }

        /// <summary>
        /// Copia una matriz en otra (siempre que pueda). Si una de ellas es mas pequeña que la otra lanza IndexOutOfRangeException (que en este caso es imposible).
        /// </summary>
        /// <param name="destino">La matriz hacia la que se copian los datos.</param>
        /// <param name="origen">Matriz desde la cual se leen y se copian los datos.</param>
        /// <returns></returns>
        static bool Copiar(char[][] destino, char[][] origen)
        {

            try
            {
                for (int i = 0; i < origen.Length; i++)
                    for (int j = 0; j < origen[i].Length; j++)
                        destino[i][j] = origen[i][j];
            }
            catch (IndexOutOfRangeException) //Esto en este ejercicio es imposible que entre por aquí.
            {
                Console.WriteLine("Una de las matrices se salió de su rango de indices.");
            }

            return true;
        }

        #endregion

        #region Método ejercicio 4

        //Aviso estoy intentando hacer esto en 1h:30m máximo (para simular un examen) me quedan 17 min por lo que este método puede salir "algo más feo".
        static void CalcularSueldo()
        {
            //Creamos las constantes necesarias.
            #region Constantes
            const double SUELDO_A = 6;
            const double SUELDO_A_EXTRA = 9;
            const double SUELDO_B = 7;
            const double SUELDO_B_EXTRA = 9.5;
            const double SUELDO_C = 8;
            const double SUELDO_C_EXTRA = 10;
            const int MAXHORAS = 40;
            #endregion

            //Variables que usaremos durante la ejecución del método.
            ConsoleKeyInfo tipoEmpleado;
            string nombre = string.Empty;
            uint totalHoras = 0;
            bool bandera = true;


            Console.Clear();
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\tGESTIÓN DE EMPLEADOS\n");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------");


            Console.Write("Introduzca el nombre del empleado: ");
            nombre = Console.ReadLine();

            do
            {
                Console.Write("Introduzca el tipo de empleado (A, B, C): ");
                tipoEmpleado = Console.ReadKey();
                if (tipoEmpleado.Key != ConsoleKey.A && tipoEmpleado.Key != ConsoleKey.B && tipoEmpleado.Key != ConsoleKey.C) //Si no es A, B o C no cambiamos la bandera y lo dejamos continuar con la ejecución.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR, solo se admite A, B, C.\n");
                    Console.ResetColor();
                }
                else
                    bandera = false; //Si es un tipo válido modificamos la bandera.
            } while (bandera);


            bandera = true; //Volvemos a poner la bandera a true para usarla igual que antes con la conversión a entero.
            do
            {
                Console.Write("\nIntroduzca el total de horas: ");
                if (uint.TryParse(Console.ReadLine(), out totalHoras))  //Si el sistema falla al intentar convertirlo a uint no dejará continuar la ejecución debido a la bandera.
                    bandera = false;    //En caso de poder hacer la conversión modificamos la bandera
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR, el formato no es válido solo se admiten números enteros y no negativos.");
                    Console.ResetColor();
                }
            } while (bandera);

            //Escribimos los datos del trabajador en consola (dando un poco de formato).
            Console.WriteLine("\n\n\n\t\tDATOS TRABAJADOR:");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("             Nombre trabajador: {0}", nombre);
            Console.WriteLine("               Tipo trabajador: {0}", char.ToUpper(tipoEmpleado.KeyChar)); //Escribimos el tipo del KeyChar de la tecla (ya se explico antes como estaba formado un ConsoleKeyInfo).
            if (totalHoras > MAXHORAS) //En caso de no haber horas extras no las ponemos.
            {
                Console.WriteLine("        Total horas ordinarias: 40");
                Console.WriteLine("            Total horas extras: {0}", totalHoras - 40);
            }
            else
                Console.WriteLine("        Total horas ordinarias: {0}", totalHoras);

            switch (tipoEmpleado.Key) //Según el tipo de trabajador y el total de horas le asignamos su sueldo.
            {
                case ConsoleKey.A:
                    if (totalHoras > MAXHORAS)                             //Con C damos formato de moneda al número (Nos la coje automáticamente del sistema por lo que sera € para nosotros.
                        Console.WriteLine("               Total a cobrar : {0:C}", MAXHORAS * SUELDO_A + (totalHoras - MAXHORAS) * SUELDO_A_EXTRA);
                    else
                        Console.WriteLine("               Total a cobrar : {0:C}", totalHoras * SUELDO_A);
                    break;
                case ConsoleKey.B:
                    if (totalHoras > MAXHORAS)
                        Console.WriteLine("               Total a cobrar : {0:C}", MAXHORAS * SUELDO_B + (totalHoras - MAXHORAS) * SUELDO_B_EXTRA);
                    else
                        Console.WriteLine("               Total a cobrar : {0:C}", totalHoras * SUELDO_B);
                    break;
                case ConsoleKey.C:
                    if (totalHoras > MAXHORAS)
                        Console.WriteLine("               Total a cobrar : {0:C}", MAXHORAS * SUELDO_C + (totalHoras - MAXHORAS) * SUELDO_C_EXTRA);
                    else
                        Console.WriteLine("               Total a cobrar : {0:C}", totalHoras * SUELDO_C);
                    break;
            }

            Console.WriteLine("AVISO: ese \"?\" despues del número y antes de \"Euros\" es su simbolo de la moneda que no sale en consola.");
            Console.WriteLine("\n\nFin datos trabajador, pulsa una tecla para volver al menú.");
            Console.ReadKey();

        } 
        #endregion
    }
}
