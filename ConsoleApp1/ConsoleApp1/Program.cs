using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Element> list = new List<Element>();
            list.Add(new Element(4, 15));
            list.Add(new Element(35, 8));


            Console.WriteLine( MakeTextBold("The quick brown fox jumps over the lazy dog.", list) );
        }

        public static String MakeTextBold(String text, List<Element> list)
        {
            string startSimbol = "<b>", endSimbol = "</b>";

            list.Sort();
            list.Reverse();
            foreach (var element in list)
            {
                text = text.Insert(element.Position + element.Size, endSimbol);
                text = text.Insert(element.Position, startSimbol);
            }

            return text;
        }

        public int Compare(Element x, Element y)
        {
            throw new NotImplementedException();
        }
    }

    public struct Element :  IComparable<Element>
    {
        public int Position, Size;

        public Element(int position, int size)
        {
            Position = position;
            Size = size;

        }
        public int CompareTo(Element comparePart)
        {
                return Position.CompareTo(comparePart.Position);
        }

    }
}
