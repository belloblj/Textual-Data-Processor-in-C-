# 📊 Textual Data Processor in C#

A C# console app that analyzes user-entered text to count words, vowels, and word frequencies. Handles punctuation, compound words like "his/her", and outputs clean, aligned results. Built for learning string manipulation and text analytics.


![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)
![Language](https://img.shields.io/badge/language-C%23-68217A)
![Platform](https://img.shields.io/badge/platform-.NET%206.0-lightgrey)

---

## 🧠 Overview
This C# console application analyzes a paragraph of text entered by the user. It performs three key operations:
- **Word Count**: Total number of words.
- **Vowel Count**: Number of vowels (`a, e, i, o, u`) regardless of case.
- **Word Frequency**: Frequency of each unique word, sorted alphabetically.

---

## 🚀 Features
- Case-insensitive analysis for vowels and word frequency.
- Punctuation is stripped before word processing.
- Compound words like `his/her` are split correctly.
- Clean, aligned output formatting for readability.
- Ready for extension to file I/O or GUI.

---

## 🖼️ Screenshot

<img width="779" height="454" alt="image" src="https://github.com/user-attachments/assets/587f9ef7-981e-4554-ae45-49bdb05809ae" />



---

## 🛠️ Getting Started

### Requirements
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download)
- C# compiler

### Run the Program

```bash
dotnet run
```

## Notes
- Words are defined as alphabetic sequences separated by spaces or slashes.
- Punctuation is stripped before analysis.
- Word frequency is case-insensitive.
- Output is formatted for clarity and alignment.

 ## License
This project is licensed under the MIT License.
