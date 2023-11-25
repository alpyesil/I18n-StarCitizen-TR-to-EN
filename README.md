# I18n-StarCitizen-TR-to-EN

## Overview

ConvertLetter is a simple C# console application designed to convert Turkish characters in an INI file to their English equivalents. It replaces Turkish characters like 'ş', 'ğ', 'ç', 'ö', 'ü', and 'ı' with their English counterparts.

## Usage

1. Place the INI file you want to convert in the same directory as the executable.
2. Run the application, and it will create a new folder named 'en' and save the converted INI file inside it.

## Instructions

1. **Installation:**
   - No installation is required. Simply download the executable and run it.

2. **Input:**
   - Ensure that the INI file you want to convert is named `global.ini` and is located in the same directory as the executable.

3. **Output:**
   - The converted INI file will be saved in a folder named 'en' in the same directory.

4. **Note:**
   - The application uses default encoding for reading and writing files (`Encoding.Default`). Make sure your INI file is compatible with this encoding.

5. **Example:**
   - Input: `tr/global.ini`
   - Output: `en/global.ini`

## Requirements

- .NET Core 3.1 or later

## License

This project is licensed under the [MIT License](LICENSE).

Feel free to reach out for any questions or improvements!
