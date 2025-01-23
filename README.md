# NamesControl Application

The repository contains one solution consisting of three projects:

- **NamesControlClient**: A client application that provides a simple GUI using Windows Forms. The user can manage a remote database running on the server side. The connection is made using TCP/IP.
- **NamesControlServer**: An application that manages its own database system, containing a table of people (with unique ID, first name, and second name). It can serve multiple clients asynchronously.
- **PacketManager**: (Should be named `NamesControlLib`, but something went wrong in Visual Studio, and I haven't been able to fix it yet.) This is a library shared between the client and server.

Note: handed version is in brunch 'Develop'.