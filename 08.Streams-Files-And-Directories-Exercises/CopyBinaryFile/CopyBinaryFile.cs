namespace CopyBinaryFile
{
    using System;
    using System.IO;
    using System.Text;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream outputStream = new FileStream(outputFilePath, FileMode.OpenOrCreate))
                {
                    int n = 5;
                    byte[] buffer = new byte[n];
                    int readCount = inputStream.Read(buffer, 0, n);

                    while (readCount > 0)
                    {
                        string parsedBuffer = Encoding.ASCII.GetString(buffer);

                        outputStream.Write(buffer, 0, readCount);
                        readCount = inputStream.Read(buffer, 0, n);
                    }
                }
            }
        }
    }
}
