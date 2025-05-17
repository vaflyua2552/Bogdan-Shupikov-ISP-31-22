using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_55_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "image.bmp";
            string encryptedFilePath = "encrypted_image.dat";
            string decryptedFilePath = "decrypted_image.bmp";
            byte key = 123;

            EncryptFile(inputFilePath, encryptedFilePath, key);
            Console.WriteLine("Файл зашифрован");

            DecryptFile(encryptedFilePath, decryptedFilePath, key);
            Console.WriteLine("Файл расшифрован");
        }

        static void EncryptFile(string inputFilePath, string outputFilePath, byte key)
        {
            using (FileStream fileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                int byteRead;
                while ((byteRead = fileStream.ReadByte()) != -1)
                {
                    byte encryptedByte = (byte)(byteRead ^ key);
                    outputStream.WriteByte(encryptedByte);
                }
            }
        }

        static void DecryptFile(string inputFilePath, string outputFilePath, byte key)
        {
            using (FileStream fileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                int byteRead;
                while ((byteRead = fileStream.ReadByte()) != -1)
                {
                    byte decryptedByte = (byte)(byteRead ^ key);
                    outputStream.WriteByte(decryptedByte);
                }
            }
        }
    }
}