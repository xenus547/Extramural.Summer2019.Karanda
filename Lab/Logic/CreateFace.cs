using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class CreateFace
    {
        public static string CreateF()
        {
            var builder = new StringBuilder();
            builder.Append("\n +\"\"\"\"\"+");
            builder.Append("\n(| o o |)");
            builder.Append("\n |  ^  |");
            builder.Append("\n | '-' |");
            builder.Append("\n +-----+");

            return builder.ToString();
        }
    }
}
