# Crossmodal-Interface

Created for NHanCE Lab

# What needs to be done before winter break!

Finish matching visual to auditory (should be simple)
  - goal : finish by the end of 12/13/2018
  
Finish matching visual to tactile (difficult!)
  - need to find a way to control the intensity of the vibrations of the tactors
  - may need to access the json file of the tactor and change the values there.
  - Spend all of 12/14/2018 on trying to figure out this problem.
  
If there is time, start on the database implmentation
  
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
