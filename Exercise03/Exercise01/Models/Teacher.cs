namespace Exercise01.Models
{
    public class Teacher : Person
    {
        public string Teach()
        {
            return "Estoy explicando";
        }

        public override string Greet()
        {
            return $"Hola soy el profesor {Name}";
        }
    }
}