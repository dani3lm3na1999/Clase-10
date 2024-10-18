using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAoo
{
    public class Program
    {
        static void Main(string[] args)
        {

            //int[] myArrayInt = new int[5];

            // Creando un objeto llamada myArrayList y lo estamos inicializando vacio.
            ArrayList myArrayList = new ArrayList();

            // Utilizar el método Add
            myArrayList.Add("Hola");
            myArrayList.Add(10);
            myArrayList.Add(true);

            // Mostrar por pantalla
            //MostrarElementos(myArrayList);

            ArrayList myArrayList2 = new ArrayList();
            myArrayList2.Add("Hola");
            myArrayList2.Add("Mundo");
            myArrayList2.Add("Hola");

            //MostrarElementos(myArrayList2);

            // Utilizar método Remove
            myArrayList2.Remove("Hola");

            Console.WriteLine(new string('-',20));

            //MostrarElementos(myArrayList2);

            // Utilizar método Count
            int conteo1 = myArrayList.Count;
            int conteo2 = myArrayList2.Count;

            //Console.WriteLine("El número de elementos en la primera colección es de: {0}", conteo1);
            //Console.WriteLine("El número de elementos en la segunda colección es de: {0}", conteo2);


            // Utilizar método Contains
            ArrayList nombres = new ArrayList();
            nombres.Add("Juan");
            nombres.Add("Jose");
            nombres.Add("Miguel");
            nombres.Add("Maritza");
            nombres.Add("Xiomara");

            bool contiene = nombres.Contains("Daniel");

            //Console.WriteLine(contiene);


            ArrayList myArrayList3 = new ArrayList();
            myArrayList3.Add("Hola");
            myArrayList3.Add(", desde C#");

            // Utilizar el método Insert
            myArrayList3.Insert(1, "Mundo");

            MostrarElementos(myArrayList3);

            Console.ReadLine();
        }

        static void MostrarElementos(ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
