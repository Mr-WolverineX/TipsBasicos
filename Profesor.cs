


namespace TipsBasicos
{

    // CLASE PROFESOR ES CLASE HIJA
    // CLASE PROFESOR EXTIENDE A CLASE PERSONA PARA TENR ACCESO A SUS DATOS

    public class Profesor : Persona 
    {

            public decimal salario; // ATRIBUTO


            public void enseñar(){  // METODO

            Console.WriteLine("El profe enseña con el metodo enseñar");
            }


    }

    

}
