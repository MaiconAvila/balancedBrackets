namespace balanceBrackets
{
    class Program
    {
        static void Main()
        {
            string inputData = GetDataUser();

            var valueBrackets = CheckBrackets(inputData);

            Console.WriteLine(valueBrackets);
            Console.WriteLine("\nThank you for using our services.");
        }
        
        static string CheckBrackets(string brackets)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < brackets.Length; i++)
            {
                char character = brackets[i];
                if (character == '[' || character == '{' || character == '(')
                    stack.Push(character);
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (!stack.Any())
                        return "is not valid";

                    switch (character)
                    {
                        case ']':
                            if (stack.Pop() != '[')
                                return "is not valid";
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                                return "is not valid";
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                                return "is not valid";
                            break;
                        default:
                            break;
                    }
                }
            }
            
            if (!stack.Any())
                return "is valid";
            return "is not valid";
        }

        private static string GetDataUser()
        {
            Console.WriteLine();
            Console.WriteLine("Please, write the brackets");
            Console.WriteLine();

            string inputData = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return inputData;
        }
    }
}