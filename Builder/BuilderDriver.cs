using System;

namespace DesignPatterns
{
    public static class BuilderDriver
    {
        public static void Do()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());
        }
    }
}