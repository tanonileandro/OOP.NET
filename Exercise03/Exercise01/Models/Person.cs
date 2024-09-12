namespace Exercise01.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; private set; }

        public void SetAge(int age)
        {
            Age = age;
        }

        public virtual string Greet()
        {
            return $"Hola soy {Name}";
        }
    }
}
