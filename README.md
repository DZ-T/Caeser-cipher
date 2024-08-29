# Caesar Cipher Tool

## Overview

This project is a simple command-line tool for encryption and decryption using the Caesar cipher, a basic form of encryption that shifts characters in the alphabet. The tool also includes functionality to attempt to crack a Caesar cipher by trying all possible shift values.

## Features

1. **Encryption**: Encrypt a given plaintext with a specified key.
2. **Decryption**: Decrypt a given ciphertext using a specified key.
3. **Cracking**: Attempt to crack a Caesar cipher by trying all possible shift values (0-25).

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (any version compatible with C#)
- A command-line terminal

### Running the Program

1. Clone the repository to your local machine:
  ```bash
        git clone https://github.com/DZ-T/Caeser-cipher.git
  ```

2. Navigate to the project directory:
  ```bash
        cd Caeser-cipher
  ```

3. Build and run the project:

  ```bash
      dotnet run
   ```

## Usage

Once the program is running, you'll be prompted to choose an operation:

1. **Encryption**
   - Enter the word you want to encrypt.
   - Enter the key (an integer) to use for encryption.

2. **Decryption**
   - Enter the word you want to decrypt.
   - Enter the key (an integer) used for encryption.

3. **Cracking**
   - Enter the encrypted text you want to crack.
   - The program will try all possible shift values and display the results.

You can perform multiple operations by choosing "yes" when asked if you want to perform another operation. To exit, choose "no".

## Code Explanation

- **Main Method**: The entry point of the program. It provides a menu to the user to select encryption, decryption, or cracking operations and handles user input and program flow.

- **cipher Method**: Applies the Caesar cipher transformation to a single character, shifting it by a given key. Handles both uppercase and lowercase letters.

- **Encrypt Method**: Encrypts a string using the Caesar cipher by shifting each character according to the given key.

- **Decrypt Method**: Decrypts a string using the Caesar cipher by shifting each character back by the given key.

- **CrackCaesarCipher Method**: Attempts to decrypt a given ciphertext using all possible shift values (0-25) to find a readable message.

## Error Handling

The program includes basic error handling to manage invalid inputs and unexpected errors, ensuring a smoother user experience.

## Contributing

If you wish to contribute to this project, please fork the repository and create a pull request with your changes. Ensure that your code adheres to the existing style and includes appropriate test cases.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For questions or issues, please open an issue in the repository or contact me at [taha32mokaddem@gmail.com](mailto:taha32mokaddem@gmail.com).

