//aqui ire declarando variables:
int mod = 0;
int renglon = 0;
int columna = 0;
string posicion = "";
int repetir = 0;

//PRIMERO SE IMPRIME UNA SECCION CON PURAS "O"...
string[,] tableroGato = { {"O","O","O" }, { "O", "O", "O" }, { "O", "O", "O" } };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(tableroGato[i, 0] + tableroGato[i, 1] + tableroGato[i, 2]);
}

do
{
    repetir = 0;
    //PREGUNTAMOS SI QUIERE MODIFICAR CASILLAS, Y CUANTAS(MAXIMO 9)
    do
    {
        Console.WriteLine("Cuantas modificaciones quieres hacer?");
        mod = int.Parse(Console.ReadLine());
        if (mod > 9)
        {
            Console.WriteLine("\nEl numero indicado excede el maximo de modificaciones posibles!!!\n");
        }
    } while (mod > 9);

    //UNA VEZ INDICADO EL NUMERO DE MODIFICACIONES, POR CADA MODIFICACION, SE PREGUNTARA LA POSICION A CAMBIAR
    for (int i = 0; i < mod; i++)
    {
        do
        {
            Console.WriteLine("Indica la posicion a modificar\n   Ej: 1,2");
            posicion = Console.ReadLine();
            if (int.Parse(posicion.Substring(0, 1)) > 2 || int.Parse(posicion.Substring(2, 1)) > 2)
            {
                Console.WriteLine("Valor fuera de rango, ingresa un numero entre 0 y 2");
            }
            else if (posicion.Substring(1,1) != ",")
            {
                Console.WriteLine("Error en el formato ingresado!");
            }
        } while (int.Parse(posicion.Substring(0, 1)) > 2 || int.Parse(posicion.Substring(2, 1)) > 2 || posicion.Substring(1, 1) != ",");

        renglon = int.Parse(posicion.Substring(0, 1));
        columna = int.Parse(posicion.Substring(2, 1));

        if (tableroGato[renglon, columna] == "O")
        {
            tableroGato[renglon, columna] = "X";
        }
        else
        {
            tableroGato[renglon, columna] = "O";
        }
    }
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(tableroGato[i, 0] + tableroGato[i, 1] + tableroGato[i, 2]);
    }

    Console.WriteLine("Deseas volver a modificar?\nSelecciona la tecla 1");
    repetir = int.Parse(Console.ReadLine());
   
} while (repetir == 1);

Console.WriteLine("Gracias por usar el Pseudo-Gato :)");