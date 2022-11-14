namespace ControlFlowExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When prompted, enter in the dimensions of an image");
            Console.WriteLine("Please enter the height of the image (please omit measurement unit).");
            var height = Console.ReadLine();
            Console.WriteLine("Very good, now please enter the width of the image (again omitting the measurement unit)");
            var width = Console.ReadLine();
            Console.WriteLine("Thank you");

            var heightValue = int.Parse(height);
            var widthValue = int.Parse(width);

            if (heightValue > widthValue)
            {
                Console.WriteLine("The image in question is a portrait composition.");
            } else if(heightValue < widthValue)
            {
                Console.WriteLine("The image in question is a landscape composition");
            } else
            {
                Console.WriteLine("The image is a square composition");
            }
        }
    }
}