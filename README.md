# 🔄 Text Key-Value Replacing Tool (C# Console Application)

A simple and efficient C# console-based tool that replaces variables inside a text file using key–value mappings from another file.  
This project helps automate text manipulation tasks such as template processing, configuration generation, and bulk variable replacement.

---

## ✨ Features

- ✔ Replace placeholders in the format `<KEY>` with actual values  
- ✔ Reads key–value pairs from a separate file  
- ✔ Supports unlimited keys and values  
- ✔ Preserves text if key is not found  
- ✔ Fast and lightweight  
- ✔ Works on any Windows system with .NET installed  
- ✔ Clean and easy-to-modify codebase  

---
## ✨ GUI Based Also Available (replacingTool file) for user experience
## 🧠 How It Works

This tool uses two input files:

### **1️⃣ Key-Value File** (example: `key_value.txt`)
Contains mapping in the format:
ICCID:234567890
NAME:ANKIT
CITY:Noida


### **2️⃣ Input File** (example: `input.txt`)
Contains text where variables appear inside `< >` brackets:

17286567890<ICCID>4567890
Hello, <NAME> from <CITY>
<ValueNotFound>


### **Output File (example: `output.txt`)**
The tool generates a new file based on replacements:

172865678902345678904567890
Hello, ANKIT from KANPUR
<ValueNotFound>


✔ Only keys found in the key file are replaced  
✔ Keys not present remain unchanged  

---

## 🚀 Usage Guide

### **Step 1 — Prepare your input files**
Place `key_value.txt` and `input.txt` in any folder.

### **Step 2 — Update file paths in the code**

Inside `Program.cs`, modify these lines:

```csharp
string keyFile = @"C:\path\key_value.txt";
string inputFile = @"C:\path\input.txt";
string outputFile = @"C:\path\output.txt";

Step 3 — Run the project

Using Visual Studio:
Ctrl + F5
dotnet run

Step 4 — Check generated output

The replaced content will be saved at:
output.txt

🧩 Requirements

Windows 10/11

.NET SDK 6 / 7 / 8

Visual Studio (optional, for development)
📂 Project Structure

/ReplacingTool
 ├── Program.cs
 ├── key_value.txt (example)
 ├── input.txt (example)
 └── README.md

🛠 Technology Stack

C#

.NET 6 / 7 / 8

Regex for placeholder detection

📜 Regex Pattern Used

The tool uses the following regex pattern to detect placeholders:
<([^>]+)>

This extracts the key from <KEY>.

Logic:

If key exists in dictionary → replace with value

If key is missing → keep original <KEY>

❤️ Contribution

Pull requests are welcome!

Fork this repository

Create a feature branch

Commit your changes

Submit a Pull Request

📬 Contact

Made by Ankit Mourya
🔗 LinkedIn: https://www.linkedin.com/in/ankit-mourya-821aa223b/

Feel free to open an issue or suggest improvements!

⭐ Support

If you like this tool, please give this repository a star ⭐ on GitHub!

