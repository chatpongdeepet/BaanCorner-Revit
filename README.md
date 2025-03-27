# Unit Converter Application  

---

## 📖 Description  

**Unit Converter** is a Windows Presentation Foundation (WPF) application developed using **.NET Framework 4.8** and implemented in **C# 13.0**. The application is designed for managing and configuring project units across various disciplines efficiently. It supports importing, exporting, and modifying unit formats for common and discipline-specific configurations such as electrical units.

---

## 🛠 Features  

- **Unit Import/Export**:  
  - Allows the export of project unit configurations to a file.  
  - Provides an option to import unit configurations from an external file and apply them to the project.  

- **Discipline-Based Configuration**:  
  - Units are categorized into disciplines such as **Common** and **Electrical** for organized and efficient management.  

- **Editable Unit Settings**:  
  - Modify unit formats using dropdowns (e.g., ComboBoxes) for different disciplines like `Common` and `Electrical`.  

- **Interactive UI**:  
  - Intuitive and modern UI with features like tabs for different disciplines and custom-styled buttons with icons for easy navigation.

---

## 📁 Project Structure  

1. **UI Components**:  
   - The main UI layout is defined in `UnitConverter.xaml`.  
   - It uses a `TabControl` structure where each tab represents a discipline.  
   - `DataGrid` components are provided for unit editing, with columns for Unit Names and Format options.

2. **Logical Components**:  
   - The main functionalities, such as importing, exporting, and updating unit configurations, are implemented in `UnitConverter.xaml.cs`.  
   - The application uses models like the `Unit` class to represent individual project units.

---

## 🚀 Getting Started  

### Prerequisites  

- **.NET Framework 4.8** installed on your system.
- Visual Studio or JetBrains Rider (recommended for development).

### Steps to Run the Project  

1. Clone or download the project repository to your local machine.  
2. Open the solution in your preferred IDE.  
3. Build the project to restore the dependencies.  
4. Run the application to launch the Unit Converter.  

---

## 🔑 Key Classes & Functions  

### Classes:  
- **`MainWindow`**:  
  Represents the main window of the application and manages user interactions.  

- **`Unit`**:   
   Model representing a unit with the following properties:  
```csharp
string UnitName  
  string ForgeTypeId  
  List<string> FormatOptions  
  string SelectedFormat
```

### Core Methods in MainWindow:  
| Method                      | Description                                                                                   |
|-----------------------------|-----------------------------------------------------------------------------------------------|
| `PopulateGrid()`            | Populates the DataGrid with unit data based on the discipline (e.g., Common, Electrical).     |
| `UpdateProjectUnits()`      | Updates the project units with configured/edited formats.                                     |
| `ExportProjectUnits()`      | Handles exporting current units to an external file.                                          |
| `ReadImportFile()`          | Reads and parses imported unit configurations from a file.                                    |
| `ExportButton_Click()`      | Event handler for the **Export** button. Initiates the exporting process.                    |
| `ImportButton_Click()`      | Event handler for the **Import** button. Initiates the file selection and importing process.  |

---

## 🎨 User Interface Overview  

1. **Navigation Buttons**:  
   - **Export Button**: Styled with a custom icon and labeled "Export".  
   - **Import Button**: Styled with a custom icon and labeled "Import".  

2. **Tabs for Disciplines**:  
   - Categories like **Common** and **Electrical** are displayed as tabs.  

3. **Data Grids**:  
   - Each tab contains a `DataGrid` for displaying and configuring units. Columns include:
      - **Unit Name**: Read-only column displaying the unit name.  
      - **Unit Format**: Editable dropdown (ComboBox) to select the desired unit format.  

---

## 📤 Importing & Exporting Units  

1. **Export Units**:  
   - Click the **Export Button** to save the current unit configuration as an external file.  
   
2. **Import Units**:  
   - Click the **Import Button** to select and load a configuration file. The units will be displayed in their respective discipline tabs for further editing or application to the project.

---

## 📜 License  

Open-source project. You may use, modify, and distribute the project code under appropriate permissions.

---

## 🧑‍💻 Authors  

This project utilizes WPF and C# technologies and other resources to accomplish an elegant and simple unit conversion utility.
