using System;

namespace Caeser_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                try
                {
                    Console.WriteLine("-----------------Caeser cipher-----------------");
                    Console.Write("Welcome to caeser cipher encryption/decryption tool\n Choose (1) for encryption / (2) for decryption / (3) solve (try all posibilities to crack encrypted text) \n choose :");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    int key;
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the word you want to encrypt :");
                            string plaintext = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the key :");
                            key = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Encrypt(plaintext, key));
                            break;
                        case 2:
                            Console.WriteLine("Enter the word you want to decrypt :");
                            string ciphertext = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the key :");
                            key = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Decrypt(ciphertext, key));
                            break;
                        case 3:
                            Console.WriteLine("Enter the word you want to decrypt :");
                            string encryptedtext = Convert.ToString(Console.ReadLine());
                            CrackCaesarCipher(encryptedtext);                  
                            break;
                        default:
                            break;
                    }
                    Console.Write("Do you want to perform another operation? (yes/no): ");
                    string continueChoice = Console.ReadLine().Trim().ToLower();
                    if (continueChoice != "yes")
                    {
                        continueRunning = false; // Exit the loop if the user does not want to continue
                    }
                }
                catch (FormatException ex)
                {
                    // Handle cases where the input is not a valid number
                    Console.WriteLine("Invalid input format. Please enter a valid number. " + ex);
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }



            }

        }
        private static char cipher(char ch , int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';  // base character , sets d to 'A' if the character is uppercase, or 'a' if it is lowercase. 
            return (char)((((ch + key) - d) % 26) + d); 
        }
        public static string Encrypt(string plaintext, int key)
        {

            string output = string.Empty;
            foreach (char letter in plaintext)
            {

                output += cipher(letter, key);
            }
            return output;

        }
        static string Decrypt(string ciphertext, int key)
        {
            string output = string.Empty;

            foreach (char letter in ciphertext)
            {

                output += cipher(letter,-key);
            }
            return output;

        }
        static void CrackCaesarCipher(string ciphertext)
        {
            // Try all possible shifts from 0 to 25
            for (int key = 0; key < 26; key++)
            {
                string decryptedMessage = Decrypt(ciphertext, key);
                Console.WriteLine($"Key {key}: {decryptedMessage}");
            }
        }



    }
}
