namespace Logger
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
