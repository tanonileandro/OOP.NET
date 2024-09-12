using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01.Models
{
    public class Student : Person
    {
        public string Study()
        {
            return "Estoy estudiando";
        }

        public string ShowAge()
        {
            return $"Mi edad es: {Age} años";
        }

        public override string Greet()
        {
            return $"Hola soy el estudiante {Name}";
        }
    }

}
