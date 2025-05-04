# Tour and Travels

A web-based travel booking platform developed using ASP.NET Web Forms. This application enables users to book bus, train, and tour packages, manage their bookings, and access various travel-related services.

## 🧭 Features

* **User Authentication**: Secure login and registration system.
* **Booking Services**:

  * Bus Ticket Booking (`BookBus.aspx`)
  * Train Ticket Booking (`BookTrain.aspx`)
  * Tour Package Booking (`BookPackage.aspx`)
* **Booking Management**:

  * Cancel Bus Tickets (`CancelBus.aspx`)
  * Cancel Train Tickets (`CancelTrainTicket.aspx`)
  * Cancel Flight Tickets (`CancelFlight.aspx`)
* **User Account Management**:

  * Change Password (`Changepassword.aspx`)
* **Informational Pages**:

  * About Us (`AboutUS.aspx`)
  * Contact Us (`ContactUs.aspx`)
* **Web Services**:

  * Banking Service Integration (`Bankservice.asmx`)
* **Master Pages**:

  * Before Login (`BeforeLogin.master`)
  * After Login (`AfterLogin.master`)

## 🛠️ Technologies Used

* **Frontend**: ASP.NET Web Forms
* **Backend**: C#
* **Database**: MSSQL Database Server
* **Web Services**: ASP.NET Web Services (`.asmx`)

## 🚀 Getting Started

### Prerequisites

* Visual Studio (2015 or later)
* .NET Framework (4.5 or later)
* SQL Server (for database management)

### Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/devjyotiprajapati/tour-and-travels.git
   ```



2. **Open in Visual Studio**:

   * Open the solution file (`.sln`) in Visual Studio.

3. **Configure Database**:

   * Set up the SQL Server database.
   * Update the connection strings in the `web.config` file accordingly.

4. **Build and Run**:

   * Build the solution to restore dependencies.
   * Run the application using IIS Express or your preferred web server.

## 📁 Project Structure

* `App_Code/`: Contains backend logic and helper classes.
* `App_Data/`: Holds database files.
* `Images/`: Stores image assets used in the application.
* `.aspx` Files: Frontend pages for various functionalities.
* `.master` Files: Master pages for consistent layout before and after login.
* `Bankservice.asmx`: Web service for banking operations.
