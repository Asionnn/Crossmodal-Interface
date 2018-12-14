# Crossmodal-Interface

Created for NHanCE Lab

# What needs to be done between 12/14/2018 - 1/4/2019!!!
  -create several wav files of the alert sound each at a different volume 
  -implement the modal matching between audio and visual(The participant must do this 3 times)
  -read the tactor documentation and find out how to connect to them
  -implement modal matching between tactile and visual(The participant must do this 3 times)
  -work on database storage
  -make the interface look prettier
  -test to make sure the application works on the minisim
  
# Instructions

// Thought Microsoft SQL Server is eaiser to maintain, so lets do sql server

Download and Install SQL Server 2017 Developer Edition

Download and Install SMSS

Connect to Local SQL Server in Visual Studio

Create new database at the lab

Create a table with following schema:
CREATE TABLE [dbo].[Users] (
[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
[FirstName] NVARCHAR (50) NOT NULL,
[LastName] NVARCHAR (50) NOT NULL,
[Visual] INT NOT NULL,
[Auditory] INT NOT NULL,
[Tactile] INT NOT NULL,
);

Run the code and exam the database, there should be a new row in the database. (code changes see commit history)

# Info

Connection String: Server=localhost;Database=master;Trusted_Connection=True;
