namespace tp_1_p_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se ingresan 10 números. Se pide indicar cual fue el mayor y cuantas veces se repitió.
            //Utilice funciones. Utilice vectores.

            int[] vec = new int[10];//instanciamos un vector de 10 posiciones. como el enunciado dice: se ingresan 10 numeros

            IngresarNumeros(vec);//toma de numeros

            int mayor = ObtenerMayor(vec); //instanciamos mayor y llamamos al metodo enviandole el parametro de vec
            int mayorCant = MayorCant(vec, mayor); //instanciamos la cantidad de veces que se ingreso el mayor, y llamamos al metodo enviandole los parametros de vec, mayor
                                                   //esto para que pueda recorrer el vector con el valor de mayor y asi saber cuando se incrementa el contador.

            Console.WriteLine("El mayor fue " +mayor+ " con una cantidad de " +mayorCant+ " veces."); //una vez finalizado el programa se muestra el mayor y la cantidad de veces ingresado

        }
        static void IngresarNumeros(int[] vec) 
        {
            for (int i = 0; i < vec.Length; i++) //bucle for de 10 veces (vec.Lenght = 10)
            {
                Console.WriteLine("Ingrese un número " +(i+1)+ ":");//i+1 porque para el usuario es de 1-10 pero en realidad seria 0-9

                vec[i] = int.Parse(Console.ReadLine());//por cada vuelta del for se guarda lo ingresado
            }
        }

        static int ObtenerMayor(int[] vec) 
        {
            int mayor = vec[0]; //declaramos donde se va a guardar el mayor con la primer posicion del vector (osea el primer valor ingresado)

            for (int i = 1; i < vec.Length; i++) //nos paramos en cada posicion del vector
            {
                if (vec[i] > mayor) //si la posicion en la que estoy parado, es mayor al valor de mayor:
                {
                    mayor = vec[i]; //reescribimos mayor por la posicion en la que estamos parados
                }
            }

            return mayor; //termina el metodo; retornamos mayor
        }

        static int MayorCant(int[] vec, int mayor) //toma como parametros el vector con sus valores y el valor de mayor (vec, mayor)
        {
            int contador = 0; //instanciamos un contador

            for (int i = 0; i < vec.Length; i++) //recorremos cada posicion del vector
            {
                if (vec[i] == mayor) //si la posicion en la que estoy parado es igual a mayor
                    contador++; //le sumamos uno al contador;
            }

            return contador; //termina el metodo; retornamos el contador
        }
    }
}
