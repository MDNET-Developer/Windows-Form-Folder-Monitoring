# Folder Monitor System

An advanced system to monitor folder changes and process specific file types, developed by **Murad Aliyev**.

## 📁 Project Structure
Extension
Resources
Service
Abstract
IFileLoader.cs
IFileMonitor.cs
IFileTypeResolver.cs
Concrete
CsvFileLoader.cs
FileMonitor.cs
FileTypeResolver.cs
XmlFileLoader.cs
TxtFileLoader.cs
Factory
FileLoaderFactory.cs
FileType.cs
TestFiles
ViewModel
App.config
FrmMainFolderMonitor.cs
FrmSetting.cs


## 🚀 Features
- Real-time folder monitoring.
- Support for multiple file types (CSV, XML, TXT).
- Modular and extensible service-based architecture.
- Implemented **Factory Design Pattern** for file loaders.
- User-friendly Windows Forms interface for settings and monitoring.

## ⚙️ How to Use
1. Clone the repository:  
   ```bash
   git clone https://github.com/MDNET-Developer/FolderMonitorSystem.git
Open the solution in Visual Studio.
Build and run the project.
Configure the settings in the UI and start monitoring your folder.
💡 Design Patterns
This project makes use of the Factory Design Pattern to create and manage file loaders dynamically based on the file type.

📜 License
This project is licensed under the MIT License. See the LICENSE file for more details.

Created by Murad Aliyev
GitHub: MDNET-Developer
