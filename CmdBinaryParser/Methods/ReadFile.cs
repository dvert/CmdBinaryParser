namespace CmdBinaryParser.Methods
{
    /// <summary>
    /// Чтение данных из файла
    /// </summary>
    public class ReadFile
    {
        public List<string> ReadDataFromFile(string inputFile)
        {
            List<string> substrings = new List<string>();

                try
            {

                var file = File.ReadAllText(inputFile);
                var strWithoutSpaces = file.Replace(", ", "");
                substrings = SplitString(strWithoutSpaces, sizeof(int));


                static List<string> SplitString(string input, int size)
                {
                    int numParts = (int)Math.Ceiling((double)input.Length / size);
                    var parts = new List<string>(numParts);

                    for (int i = 0; i < numParts; i++)
                    {
                        int startIndex = i * size;
                        int length = Math.Min(size, input.Length - startIndex);
                        parts.Add(input.Substring(startIndex, length));
                    }
                    return parts;
                }

                if (!File.Exists(inputFile))
                {
                    throw new FileNotFoundException("Файл не найден", inputFile);
                }
            }

            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка чтения файла {ex}");
            }

            return substrings;
        }
    }
}