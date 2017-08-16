using System;

namespace DesignPatterns
{
    public static class BuilderDriver
    {
        public static void Do()
        {
            var builder = new HtmlBuilder("ul");
            builder
            .AddChild("li", "hello")
            .AddChild("li", "world"); //chaining from fluent builder
            Console.WriteLine(builder.ToString());
        }
    }
}