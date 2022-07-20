using System;

class Program
{
    static void Main(string[] args)
    {
        float widths = Input("幅", 1, 1000);

        float depth = Input("奥行", 1, 1000);

        float height = Input("高さ", 1, 1000);

        Box box = new Box(widths, depth, height);

        Console.WriteLine("表面積　：" + box.GetSurface() + "cm²\n体積　：" + box.GetVolume() + "cm³");
    }

    static float Input(string message, float min, float max)
    {
        while (true)
        {
            float number;
            Console.Write(message + "(" + min + "～" + max + ")  : ");
            try
            {
                number = float.Parse(Console.ReadLine());


                if (min <= number && number <= max)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("入力エラーです");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("えらー");
            }
        }
    }
}

class Box
{
    private float widths;
    private float depth;
    private float height;
    public Box(float w, float d, float h)
    {
        this.widths = w;
        this.depth = d;
        this.height = h;
    }

    public float GetSurface()
    {
        return (widths * depth) * 2 + (widths * height) * 2 + (depth * height) * 2;
    }

    public float GetVolume()
    {
        return widths * depth * height;
    }
}
