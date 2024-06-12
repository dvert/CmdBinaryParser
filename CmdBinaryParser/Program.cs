using CmdBinaryParser.Methods;

namespace CmdBinaryParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Не указаны параметры \n");
                Console.WriteLine("Используемые параметры: input.dat output.dat");
            }
            else
            {
                try
                {
                    string inputFile = args[0];
                    string outputFile = args[1];

                    var file = File.ReadAllText(inputFile);
                    
                    var read = new ReadFile();
                    var readData = read.ReadDataFromFile(inputFile);

                    var write = new WriteFile();
                    write.WriteOutputToFile(readData, outputFile);

                    Console.WriteLine($"Результаты записаны в файл: {outputFile}");
                }
                catch (Exception ex)
                {
                    var type = ex.GetType().ToString();

                    Console.WriteLine($"Тип ошибки : {type}");
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        }
    }