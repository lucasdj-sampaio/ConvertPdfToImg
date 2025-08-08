# 📄 PDF to Image Converter 🖼️

A high-performance C# application that reads PDF files and converts them into images quickly and efficiently. Designed to handle large PDF documents, including those with 100+ pages, this tool enables seamless integration with legacy systems or applications that do not natively support PDF files.

## ⚡ Features

- 🚀 **Fast PDF to Image conversion** — optimized for speed and performance  
- 📚 **Supports large PDFs** — easily process documents with 100 or more pages  
- 🗂️ **Batch processing** — input multiple PDFs for conversion in one go  
- 🏛️ **Legacy system compatibility** — generate image outputs usable by systems lacking PDF support  
- 🔌 **Simple integration** — easily incorporate into existing workflows or automation pipelines

## 🛠️ Getting Started

### Prerequisites

- .NET Framework / .NET Core (specify version if needed)  
- PDF processing library (e.g., PdfiumViewer, iTextSharp)

### Important: Required DLL folders for Debug and Release

For the converter to work properly, the following folders **must be present** inside both the `Debug` and `Release` folders of your project:

```

bin\Debug
├── x64
├── x86
└── nl\\

bin\Release
├── x64
├── x86
└── nl\\

````

Make sure to copy these folders from your dependencies or build outputs accordingly.

### How to Use

1. Place your PDF files into the input folder (or specify file paths via the app).  
2. Run the converter application.  
3. Converted images will be saved in the output folder, organized by PDF file name and page number.  

### Example

```bash
dotnet run -- input.pdf output_folder
````

## ❓ Why Use This Tool?

Many legacy systems or older applications lack native support for PDF documents. By converting PDFs into images, this tool allows you to:

* 🖼️ Display PDF content as images on platforms without PDF viewers
* 🔄 Integrate PDF content into workflows that only support image formats
* ⚡ Process large documents without sacrificing speed or quality

## 🤝 Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

---

Built with ❤️ in C#
