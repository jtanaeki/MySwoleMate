# MySwoleMate <img align="right" width="300" height="200" src="MySwoleMate/Images/weights.jpg">
### Personal Workout Management System
<br>
<a href="CODE_OF_CONDUCT.md">
    <img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-2.0-4baaaa.svg" />
</a>

---

The consummate personal fitness application that provides a personal trainer, as well as the essential tools he or she needs in order to become a successful personal trainer.

## Setting Up Local Environment
The following instructions will help you set up a local development environment, run the project on your machine for development and testing purposes, and deploy it on a live system. See [Deployment](https://github.com/jtanaeki/MySwoleMate/blob/main/README.md#deployment) for notes on how to deploy the project. See [How to Discuss and Contribute](https://github.com/jtanaeki/MySwoleMate#how-to-discuss-and-contribute) for notes on how to contribute to this repository.

### Prerequisites
Before building and testing the application, you must make sure to have any IDE installed that supports .NET Core development, such as the latest version of [Visual Studio Community](https://visualstudio.microsoft.com/downloads/#). You will also need to install [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) on your system.

If you are running the application on the command line, you will need to download and install the latest version of [.NET SDK and .NET Core SDK](https://dotnet.microsoft.com/download).

### Cloning the Repository
After installing the necessary software, you can clone a local copy of the repository. A [ZIP file version](https://github.com/jtanaeki/MySwoleMate/archive/refs/heads/main.zip) of the copy can be downloaded, or you can clone the repository directly over HTTPS from the command line:

```bash
git clone https://github.com/jtanaeki/MySwoleMate.git
```

### Tables in Database
![Image of Database Tables](https://user-images.githubusercontent.com/55217672/114484461-45218d00-9bd8-11eb-88f0-3a76c9eb9057.png)

## Running the Application
The following instructions will help you get the program running via your preferred IDE or from the command line.

### Running With Visual Studio
To run the application with Visual Studio, open the file, `MySwoleMate.sln`. To debug, run the server by pressing `F5`.

### Running With Visual Studio Code
To run the application with Visual Studio Code, you will first need to open the repository directory using the `Open Folder...` option.

Second, make sure [the recommended extensions for the workspace are installed](https://code.visualstudio.com/docs/editor/extension-gallery#_recommended-extensions). Note that extension recommendations are classified as either "Workspace Recommendations" or "Other Recommendations", but only the "Workspace Recommendations" are required.

After the required extensions are installed, you can run the server by pressing `F5` to debug.

### Running From The Command Line
To run the application from the command line, build the application and then run the resulting executable file directly. When running the executable directly, you can add command line options. Add the `--help` flag to list details on all the supported command line options. Assuming .NET 5.0 is installed on your system:

1. Build the project

    ```bash
    dotnet build          # Build the project
    cd bin/Debug/net5.0         # Change into the build output directory
    ```

2. Execute the build output. On Linux, Mac, etc. use `./MySwoleMate` and on Windows use `MySwoleMate.exe`.

## Deployment
### Enabling IIS Features
Before using Visual Studio to deploy the application through Internet Information Services (IIS), you must make sure the features for IIS are enabled:
1. Go to Control Panel → Programs → Turn Windows features on or off (Alternatively, you can type "Turn Windows features on or off" in the search box next to the Start Menu).
2. Make sure "Internet Information Services" and "Internet Information Services Hostable Web Core" are selected.
3. Expand the "Internet Information Services" folder → Expand the "World Wide Web Services" folder → Expand the "Application Development Features".
4. Select the latest ASP.NET version (4.0+). Other required folders will then automatically be selected.
5. Click OK.
6. Windows will search for the required files and apply changes.
7. Click Close.

### Deploying Locally
Please read [Deploy an app to a folder using Visual Studio](https://docs.microsoft.com/en-us/visualstudio/deployment/quickstart-deploy-to-local-folder?view=vs-2019) for step-by-step instructions on publishing the application to a local folder. Remember to connect with SQL Server.

### Sample Page
![Image of Sample Page](https://user-images.githubusercontent.com/55217672/114323937-8bea8680-9af5-11eb-820a-8cd3f15ba8c1.png)

## Tools Used
### Servers
* [Internet Information Services (IIS)](https://www.iis.net/)

### Databases
* [SQL Server](https://www.microsoft.com/en-us/sql-server/)

### Languages & Frameworks
* [ASP.NET](https://dotnet.microsoft.com/apps/aspnet)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)

## How to Discuss and Contribute
Some of the best ways to contribute are to try things out, file issues, join in design conversations, and make pull-requests. Please read [CONTRIBUTING.md](CONTRIBUTING.md) before you begin for details on our [code of conduct](CODE_OF_CONDUCT.md), as well as the process for submitting [pull requests](https://github.com/jtanaeki/MySwoleMate/pulls) to us. Proposals for changes and other issues specific to MySwoleMate can be found [here](https://github.com/jtanaeki/MySwoleMate/issues).
