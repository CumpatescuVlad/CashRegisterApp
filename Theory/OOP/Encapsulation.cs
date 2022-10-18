namespace OOP
{
    public class Encapsulation
    {
        //Encapsulation is the first OOP priciple that suggests that global variables should be avoided,making the code secure
        //all variables, methods,props  should be in a class guarded by an acces modifier 
        //which are private,public, proteected,internal,private-protected,protected internal
        //also encapsulation could happen trough the use of atuo implemented props that acces private fields
        //props that hvae accesors like getters and setters get;set;

        private string _name = "Alexander";

        public int Age { get; set; }

        public string Name { get=>_name;}

        public void CreatePerson()
        {
            Age = 25;

            Console.WriteLine($"My name is {Name} and my age is {Age} years old");
        }

    }
}
