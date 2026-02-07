namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = ArrayCreator.Create(10, 17);
            var texts = ArrayCreator.Create(20, "Default");
        }
    }
}
