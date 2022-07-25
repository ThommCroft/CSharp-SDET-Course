# Structured Query Language

Structured Query Language (SQL) is a programming language used to manage relational databases and perform operations on the data in them. SQL is regularly used by database administrators, developers writing data integration scripts, and data analysts looking to set up and run analytical queries.

SQL is used for the following:

- Modifying database table and index structures
- Adding, updating, and deleting rows of data
- Retrieving subsets of information from within relational database management systems



SQL queries and other operations take the form of commands written as statements, enabling the user to add, modify or retrieve data from database tables.



#### SQL Database Creation

In Visual Studios, open the SQL Server Object Explorer and right-click on SQL Server you wish to create a database in, and select New Query.



In the SQL Query Tab, enter the following code:

							- CREATE DATABASE "Name Here";

Click the Execute button and then refresh the SQL Server.



To create a new table in the database, select the new database from the drop-down menu in the Query Window, then enter the following code:

- CREATE TABLE "Table Name" ( "Table Content Here" );



To remove a table (Drop):

- DROP TABLE IF EXISTS "Table Name";



SQL Data Types:

- BIT
- INT
- BIGINT
- FLOAT
- DECIMAL(2,1)
- CHAR()
- VARCHAR()
- TIME
- DATE
- DATETIME

Using 2 dashes (--) creates a comment displayed in green.



To put data into a table use the code:

- INSERT INTO "Table Name" ( "Data Names e.g. first_name" ) VALUES ( 'Tom' );

You can INSERT more than 1 row of data with the above code by separating each VALUES row with round brackets and a coma.

- INSERT INTO "Table Name" ( "Data Names e.g. first_name" ) VALUES ( 'Tom' ), ( 'Dave' );



Constraints can be added to fields when creating a table to specify that the field cannot be left null through adding the code:

- NOT NULL

Fields can be given default values when creating a table.



##### Primary Key:

You can set a field as a Primary Key when creating a table with the code:

- PRIMARY KEY

At the same time you can mark a field to only contain unique values with the code:

- UNIQUE

Assigning the IDENTITY code will allow SQL to automatically increment afield such as a Primary Key:

- PRIMARY KEY IDENTITY(1,1)



##### Foreign Key:

Foreign Keys are created by assigning a field the following code:

- FOREIGN KEY REFERENCES "Table Name" (field_id)

Inserting data into a table using a Foreign Key:

- e.g. ('field_name', 'foreign_key_id')



##### Alter Table Scheme:

You can change field data types in a table by using the code:

- ALTER TABLE "Table Name"
  - ADD "field_name" DECIMAL(10,0), "field_name" VARCHAR(200);

You can also remove columns using the Drop code.



##### Modify Data:

Data can be changed in a table by using the following code:

- UPDATE "Table Name" SET "field_name" = "field_value";

This can be more specific by using the WHERE code on an ID.

Fields can be deleted from a table with the DELETE code, in a similar way to UPDATE.