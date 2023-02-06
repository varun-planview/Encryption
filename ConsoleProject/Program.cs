using ConsoleProject;

Console.WriteLine("Please enter a password to use:");
string password = Console.ReadLine();
while (true)
{
    Console.WriteLine("Please enter a string to encrypt or e to exit:");
    string plaintext = Console.ReadLine();
    if (plaintext == "e")
        break;
    Console.WriteLine("");

    Console.WriteLine("Your encrypted string is:");
    string encryptedstring = StringCipher.Encrypt(plaintext, password);
    Console.WriteLine(encryptedstring);
    Console.WriteLine("");

    Console.WriteLine("Your decrypted string is:");
    string decryptedstring = StringCipher.Decrypt(encryptedstring, password);
    Console.WriteLine(decryptedstring);
    Console.WriteLine("");
}
