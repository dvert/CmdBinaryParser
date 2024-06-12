namespace CmdBinaryParser.Methods
{
    /// <summary>
    /// Запись полученных данных в файл
    /// </summary>
    public class WriteFile
    {
        public void WriteOutputToFile(List<string> data, string outputFile)
        {
            try
            {
                data.Reverse();
                string concatenatedString = string.Join(", ", data);

                using (StreamWriter writer = new StreamWriter(outputFile))
                { 
                    writer.Write(concatenatedString);
                }

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка записи результатов: {ex.Message}");
            }
        }
    }
}
