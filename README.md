<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Folder Monitor System</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 0 20px;
            color: #333;
            background-color: #f9f9f9;
        }
        h1, h2, h3 {
            color: #0056b3;
        }
        pre {
            background: #eee;
            padding: 15px;
            border-radius: 5px;
            overflow-x: auto;
        }
        code {
            background: #f4f4f4;
            padding: 2px 4px;
            border-radius: 4px;
            font-size: 90%;
        }
        ul {
            margin: 10px 0;
            padding-left: 20px;
        }
        .folder-structure {
            background: #fefefe;
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 5px;
        }
        .folder-structure ul {
            list-style: none;
            padding-left: 20px;
        }
        .folder-structure li {
            margin: 5px 0;
        }
        .footer {
            margin-top: 20px;
            font-size: 0.9em;
            color: #555;
        }
    </style>
</head>
<body>
    <header>
        <h1>Folder Monitor System</h1>
        <p>An advanced system to monitor folder changes and process specific file types, developed by <strong>Murad Aliyev</strong>.</p>
    </header>
    
    <section>
        <h2>📁 Project Structure</h2>
        <div class="folder-structure">
            <ul>
                <li>Extension</li>
                <li>Resources</li>
                <li>Service
                    <ul>
                        <li>Abstract
                            <ul>
                                <li>IFileLoader.cs</li>
                                <li>IFileMonitor.cs</li>
                                <li>IFileTypeResolver.cs</li>
                            </ul>
                        </li>
                        <li>Concrete
                            <ul>
                                <li>CsvFileLoader.cs</li>
                                <li>FileMonitor.cs</li>
                                <li>FileTypeResolver.cs</li>
                                <li>XmlFileLoader.cs</li>
                                <li>TxtFileLoader.cs</li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>Factory
                    <ul>
                        <li>FileLoaderFactory.cs</li>
                        <li>FileType.cs</li>
                    </ul>
                </li>
                <li>TestFiles</li>
                <li>ViewModel</li>
                <li>App.config</li>
                <li>FrmMainFolderMonitor.cs</li>
                <li>FrmSetting.cs</li>
            </ul>
        </div>
    </section>
    
    <section>
        <h2>🚀 Features</h2>
        <ul>
            <li>Real-time folder monitoring.</li>
            <li>Support for multiple file types (CSV, XML, TXT).</li>
            <li>Modular and extensible service-based architecture.</li>
            <li>Implemented <strong>Factory Design Pattern</strong> for file loaders.</li>
            <li>User-friendly Windows Forms interface for settings and monitoring.</li>
        </ul>
    </section>
    
    <section>
        <h2>⚙️ How to Use</h2>
        <ol>
            <li>Clone the repository: <code>git clone https://github.com/your-username/FolderMonitorSystem.git</code></li>
            <li>Open the solution in Visual Studio.</li>
            <li>Build and run the project.</li>
            <li>Configure the settings in the UI and start monitoring your folder.</li>
        </ol>
    </section>
    
    <section>
        <h2>💡 Design Patterns</h2>
        <p>This project makes use of the <strong>Factory Design Pattern</strong> to create and manage file loaders dynamically based on the file type.</p>
    </section>
    
    
    <footer class="footer">
        <p>Created by <strong>Murad Aliyev</strong> | GitHub: <a href="https://github.com/MDNET-Developer" target="_blank">MDNET-Developer</a></p>
    </footer>
</body>
</html>
