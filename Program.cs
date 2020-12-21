using System;

namespace circleAppV2
{
    class Program
    {
        static void Main(string[] args)
        { // Declarations
            const double pi = Math.PI;
            double radius = 0, circumference = 0, area = 0, diameter = 0;
            string selection, selection2, radiusMessage = "radius", circumferenceMessage = "circumference", areaMessage = "area", diameterMessage = "diameter",
                errorMessage = "Please select an option that is valid.", question = "What would you like to calculate {0} from? ({1},{2},{3})", r, c, a, d,
                enter = "Enter {0}", answer = "The {0} of the circle is {1}{2}", units = "cm", rounded = "Would you like the {0} rounded? (y/n)", roundedQAnswer, 
                roundedAnswer = "The rounded {0} is {1}{2}.", thankYou = "Thank you for using paradox#4005's circleAppV2 to calculate {0}!";
            // Convert chars to strings
            r = Char.ToString('r');
            c = Char.ToString('c');
            a = Char.ToString('a');
            d = Char.ToString('d');

            Console.WriteLine("Welcome to the circleAppV2\n\nSelect what you would like to calculate (radius, circumference, area or diameter.");
            selection = Console.ReadLine();
            if (selection == radiusMessage || selection == "Radius" || selection == r)
            {
                Console.WriteLine("\n" + question, radiusMessage, c, a, d);
                selection2 = Console.ReadLine();
                switch (selection2)
                {
                    case "c": // Formula for radius from circumference: r = C/ (pi*2)
                        Console.WriteLine("\n" + enter, circumferenceMessage);
                        circumference = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        radius = circumference / (pi * 2);
                        Console.WriteLine(answer, radiusMessage, radius, units + "\n");
                        Console.WriteLine(rounded, radiusMessage);
                        roundedQAnswer = Console.ReadLine();
                        Console.WriteLine("\n");
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            radius = Math.Round(radius);
                            Console.WriteLine(roundedAnswer, radiusMessage, radius, units);
                            Console.WriteLine("\n");
                            Console.WriteLine(thankYou, radiusMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n" + thankYou, radiusMessage);
                            Console.ReadKey();
                        }

                        break;
                    case "a": // Formula for radius from area: A/π = r^2, sqrt(r^2)
                        Console.WriteLine(enter, areaMessage);
                        area = Double.Parse(Console.ReadLine());
                        radius = area / pi;
                        radius = Math.Sqrt(radius);
                        Console.WriteLine(answer, radiusMessage, radius, units);
                        Console.WriteLine(rounded, radiusMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            radius = Math.Round(radius);
                            Console.WriteLine(roundedAnswer, radiusMessage, radius, units);
                            Console.WriteLine(thankYou, radiusMessage);
                            Console.ReadKey();
                        } else
                        {
                            Console.WriteLine(thankYou, radiusMessage);
                            Console.ReadKey();
                        }
                        break;
                    case "d": // Formula for radius from diameter: D/2
                        Console.WriteLine(enter, diameterMessage);
                        diameter = Double.Parse(Console.ReadLine());
                        radius = diameter / 2;
                        Console.WriteLine(answer, radiusMessage, radius, units);
                        Console.WriteLine(rounded, radiusMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            radius = Math.Round(radius);
                            Console.WriteLine(roundedAnswer, radiusMessage, radius, units);
                            Console.WriteLine(thankYou, radiusMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, radiusMessage);
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine(errorMessage);
                        break;
                }
            } else if (selection == circumferenceMessage || selection == c || selection == "Circumference")
            {
                Console.WriteLine(question, circumferenceMessage, r, a, d);
                selection2 = Console.ReadLine();
                switch (selection2) {
                    case "r": // 2*pi*r
                        Console.WriteLine(enter, radiusMessage);
                        radius = Double.Parse(Console.ReadLine());
                        circumference = 2 * pi * radius;
                        Console.WriteLine(answer, circumferenceMessage, circumference, units);
                        Console.WriteLine(rounded, circumferenceMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            circumference = Math.Round(circumference);
                            Console.WriteLine(roundedAnswer, circumferenceMessage, circumference, units);
                            Console.WriteLine(thankYou, circumferenceMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, circumferenceMessage);
                            Console.ReadKey();
                        }

                        break;
                    case "a":
                        Console.WriteLine(enter, areaMessage);
                        area = Double.Parse(Console.ReadLine());
                        radius = area / pi;
                        radius = Math.Sqrt(radius);
                        circumference = 2 * pi * radius;
                        Console.WriteLine(answer, circumferenceMessage, circumference, units);
                        Console.WriteLine(rounded, circumferenceMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            circumference = Math.Round(circumference);
                            Console.WriteLine(roundedAnswer, circumferenceMessage, circumference, units);
                            Console.WriteLine(thankYou, circumferenceMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, circumferenceMessage);
                            Console.ReadKey();
                        }
                        break;
                    case "d": // pi * d
                        Console.WriteLine(enter, diameterMessage);
                        diameter = Double.Parse(Console.ReadLine());
                        circumference = diameter * pi;
                        Console.WriteLine(answer, circumferenceMessage, circumference, units);
                        Console.WriteLine(rounded, circumferenceMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            circumference = Math.Round(circumference);
                            Console.WriteLine(roundedAnswer, circumferenceMessage, circumference, units);
                            Console.WriteLine(thankYou, circumferenceMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, circumferenceMessage);
                            Console.ReadKey();
                        }

                        break;
                    default:
                        break;

                }

            } else if (selection == areaMessage || selection == "Area" || selection == a) {
                Console.WriteLine(question, circumferenceMessage, r, c, d);
                selection2 = Console.ReadLine();
                switch (selection2) {
                    case "r": // pi * r^2
                        Console.WriteLine(enter, radiusMessage);
                        radius = Double.Parse(Console.ReadLine());
                        radius = Math.Pow(radius, 2);
                        area = pi * radius;
                        Console.WriteLine(answer, areaMessage, area, units);
                        Console.WriteLine(rounded, areaMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            circumference = Math.Round(area);
                            Console.WriteLine(roundedAnswer, areaMessage, circumference, units);
                            Console.WriteLine(thankYou, areaMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, areaMessage);
                            Console.ReadKey();
                        }
                        break;
                    case "c":
                        Console.WriteLine(enter, circumferenceMessage);
                        circumference = Double.Parse(Console.ReadLine());
                        circumference = Math.Pow(circumference, 2);
                        area = circumference / (4 * pi);
                        Console.WriteLine(answer, areaMessage, area, units);
                        Console.WriteLine(rounded, areaMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            circumference = Math.Round(area);
                            Console.WriteLine(roundedAnswer, areaMessage, circumference, units);
                            Console.WriteLine(thankYou, areaMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, areaMessage);
                            Console.ReadKey();
                        }
                        break;
                    case "d":
                        Console.WriteLine(enter, diameterMessage);
                        diameter = Double.Parse(Console.ReadLine());
                        radius = diameter / 2;
                        radius = Double.Parse(Console.ReadLine());
                        radius = Math.Pow(radius, 2);
                        area = pi * radius;
                        Console.WriteLine(answer, areaMessage, area, units);
                        Console.WriteLine(rounded, areaMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            circumference = Math.Round(area);
                            Console.WriteLine(roundedAnswer, areaMessage, circumference, units);
                            Console.WriteLine(thankYou, areaMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, areaMessage);
                            Console.ReadKey();
                        }
                        break;
                }

            } else if (selection == diameterMessage || selection == "Diameter" || selection == d) {
                Console.WriteLine(question, circumferenceMessage, r, c, a);
                selection2 = Console.ReadLine();
                switch (selection2) {
                    case "r":
                        Console.WriteLine(enter, radiusMessage);
                        radius = Double.Parse(Console.ReadLine());
                        diameter = radius * 2;
                        Console.WriteLine(answer, diameterMessage, diameter, units);
                        Console.WriteLine(rounded, diameterMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            diameter = Math.Round(diameter);
                            Console.WriteLine(roundedAnswer, diameterMessage, diameter, units);
                            Console.WriteLine(thankYou, diameterMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, diameterMessage);
                            Console.ReadKey();
                        }

                        break;
                    case "c":
                        Console.WriteLine(enter, circumferenceMessage);
                        circumference = Double.Parse(Console.ReadLine());
                        diameter = circumference / pi;
                        Console.WriteLine(answer, diameterMessage, area, units);
                        Console.WriteLine(rounded, diameterMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            diameter = Math.Round(diameter);
                            Console.WriteLine(roundedAnswer, diameterMessage, diameter, units);
                            Console.WriteLine(thankYou, diameterMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, diameterMessage);
                            Console.ReadKey();
                        }
                        break;
                    case "a":
                        Console.WriteLine(enter, areaMessage);
                        area = Double.Parse(Console.ReadLine());
                        radius = area / pi;
                        radius = Math.Sqrt(radius);
                        diameter = radius * 2;

                        Console.WriteLine(answer, diameterMessage, area, units);
                        Console.WriteLine(rounded, diameterMessage);
                        roundedQAnswer = Console.ReadLine();
                        if (roundedQAnswer == "yes" || roundedQAnswer == "y")
                        {
                            diameter = Math.Round(diameter);
                            Console.WriteLine(roundedAnswer, diameterMessage, diameter, units);
                            Console.WriteLine(thankYou, diameterMessage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(thankYou, diameterMessage);
                            Console.ReadKey();
                        }

                        break;
                    default:
                        Console.WriteLine(errorMessage);
                        break;
                }

            } else
            {
                Console.WriteLine(errorMessage);
                Console.ReadKey();
            }
        }
    }
}
