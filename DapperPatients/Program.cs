using Dapper;
using System;
using System.Data.SqlClient;

namespace DapperPatients
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DapperPatients;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var connection = new SqlConnection(cs);
            connection.Open();
            /*
            int res1 = connection.Execute(
                @"CREATE TABLE lekar (
                clic int IDENTITY NOT NULL, 
                jmeno varchar(40) NOT NULL, 
                specializace varchar(20) NOT NULL, 
                CONSTRAINT PK_lekar PRIMARY KEY CLUSTERED (clic))"
            );
            Console.WriteLine(res1);
            */
            /*
            int res2 = connection.Execute(
                @"CREATE TABLE pacient (
                cpac int IDENTITY NOT NULL,
                jmeno varchar(40) NOT NULL,
                adresa varchar(255) NOT NULL,
                narozen date NOT NULL,
                telefon char(9) DEFAULT NULL,
                PRIMARY KEY (cpac))"
            );
            Console.WriteLine(res2);

            int res3 = connection.Execute(
                @"CREATE TABLE navsteva (
                datum date NOT NULL,
                clic int NOT NULL REFERENCES lekar(clic),
                cpac int NOT NULL REFERENCES pacient(cpac),
                diagnoza varchar(255)  NOT NULL,
                cena int DEFAULT NULL,
                PRIMARY KEY (datum,clic,cpac))"
            );
            Console.WriteLine(res3);
            */
            
            int res4 = connection.Execute(
                @"INSERT INTO lekar (jmeno, specializace) VALUES
                ('MUDr. František Vomáčka', 'pediatr')
                ");
            Console.WriteLine(res4);
            
        }
    }
}
