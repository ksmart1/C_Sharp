namespace PhotoDemo;

class Program
{
    static void Main(string[] args)
    {
        Photo photo1 = new Photo(8, 10);
        Console.WriteLine(photo1.ToString());
        Photo photo2 = new Photo(10, 12);
        Console.WriteLine(photo2.ToString());
        Photo photo3 = new Photo(3, 5);
        Console.WriteLine(photo3.ToString());
        MattedPhoto matte1 = new MattedPhoto(10, 12, "gray");
        Console.WriteLine(matte1.ToString());
        FramedPhoto framed = new FramedPhoto(10, 12, "wood", "modern");
        Console.WriteLine(framed.ToString());

    }
}

