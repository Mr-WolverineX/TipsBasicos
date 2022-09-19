


namespace TipsBasicos
{

     class Program
    {

        static void Main(string[] args)
        {

                //EJERCICIO 1

                // Matriz o Array
                var myArray = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};


                // SUMAR ARRAY
                //METODO 1
                Console.WriteLine(myArray.Sum());
                // METODO 2
                var sum = myArray.Aggregate(0, 
                        (accum, current) => accum + current);
                        Console.WriteLine(sum);
//----------------------------------------------------------------------

                //EJERCICIO 2

                // Vector
                int [] vector = new int [3];
                vector[0]= 5;
                vector[1]= 5;
                vector[2]= 5;

                // sumar vector
                Console.WriteLine(vector.Sum());
//----------------------------------------------------------------------
                
                //EJERCICIO 3
                 // Instanciar una clase y herencia

                // Instanciar de la clase profesor
                Profesor pr = new Profesor();
                pr.hablar(); // se puede accesar al metodo hablar de la clase persona por que la clase profesor tiene una extencion para accesar a los datos


                //Instancia de la clase estudiante
                Estudiante estu =  new Estudiante();
                estu.hablar(); 


                //EJERCICIO 4
                // POLIMORFISMO
                
        }
    }

}
