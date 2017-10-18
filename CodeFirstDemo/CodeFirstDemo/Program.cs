using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogDbContext :  DbContext
    {
        public DbSet<Post> Posts { get; set; }   
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

//PACKAGE MANAGER CONSOLE

/*
Each package is licensed to you by its owner. NuGet is not responsible for, nor does it grant any licenses to, third-party packages. Some packages may include dependencies which are governed by additional licenses. Follow the package source (feed) URL to determine any dependencies.

Package Manager Console Host Version 3.4.4.1321

Type 'get-help NuGet' to see all available NuGet commands.

PM> install-package EntityFramework
Attempting to gather dependency information for package 'EntityFramework.6.1.3' with respect to project 'CodeFirstDemo', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'EntityFramework.6.1.3' with DependencyBehavior 'Lowest'
Resolving actions to install package 'EntityFramework.6.1.3'
Resolved actions to install package 'EntityFramework.6.1.3'
Adding package 'EntityFramework.6.1.3' to folder 'F:\VisualStudioProjects\CodeFirstDemo\packages'
Added package 'EntityFramework.6.1.3' to folder 'F:\VisualStudioProjects\CodeFirstDemo\packages'
Added package 'EntityFramework.6.1.3' to 'packages.config'
Executing script file 'F:\VisualStudioProjects\CodeFirstDemo\packages\EntityFramework.6.1.3\tools\init.ps1'
Executing script file 'F:\VisualStudioProjects\CodeFirstDemo\packages\EntityFramework.6.1.3\tools\install.ps1'

Type 'get-help EntityFramework' to see all available Entity Framework commands.
Successfully installed 'EntityFramework 6.1.3' to CodeFirstDemo
PM> enable-migrations
Checking if the context targets an existing database...
Code First Migrations enabled for project CodeFirstDemo.
PM> add-migration CreatePost
Scaffolding migration 'CreatePost'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration CreatePost' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702082008086_CreatePost].
Applying explicit migration: 201702082008086_CreatePost.
Running Seed method.
PM> 
*/