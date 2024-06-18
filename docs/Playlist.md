1. Present the Case and talk about Github version control
 -

2. Talk About the processe (Inception, Elaboration, Construction og Testing)
- Inception: Vi lavde functionale krav og ikke functionale krav
- Elaboration: Vi Designede Classe Diagramer og lavede et design til Appen
- Construction: 
- Testing: Debugging under Construction Delen 


3. Show UI/UX and compare against design and showcase the functiality of the system
 -

4. Systemudvikling og Seperations of Concerns(Abstraktion og modularitet)
 - 

6.  Princippet indkapsling Princippet Komposition (aggregation) (Show Entities like Task)
 -dont focus to much on this

5. abstrakte typer (klasser og interfaces)
 - Abstrakte klasser kan ikke instansieres og bruges som basisklasser for andre klasser.
 - 
7. Design mønster Generic Repository med EF
 - Helps with Separates of concerns by abstraction
 - Helps with maintainablity by making a generic Repository that contains generic operations like CRUD that you can inherit

8. Talk about Entity Framework (Show DataContext) 
 - Entity Framework is a an ORM(Object-Relational Mapper) which can Generate a database from your entities and can remove the need to write sql to comunicate with the database.
 - It also helps with the amount code to maintain.

10. Princippet Arv (nedarving) og Generics
 - inherritents allows a class to "inherit" a class which gives access to "public" or "Protected" class Members
 - Generics can bruges til at angive datatypen først når methoden bliver brugt hvilket man kan bruge til at gøre en method can blive brugt af mange datatyper?

11. Dependency Injection
  - Inversion of control where the control of object creation and lifecycle is inverted fro mthe aplication code to a container or framwork 
  - Testing: DI facilitates easier unit testing by allowing dependencies to be mocked or stubbed.
  - Reusability: Components become more reusable since they are not bound to specific implementations of their dependencies.
    
12. virtual og override
 - Virtual allows the method to be eoverriden
 - Override allows the method to be customized to your liking and stil doing what the method was intended to be used for

13. Prinicppet Polymorfi
 - polymorfi består af interfaces, method overloading og Generics
 - Method overloading tillader flere metoder med samme navn men forskellige parameterlister i samme klasse.
 - Kan Bruges til at forbedre læsbarhed og genbrug af kode.


14. Talk about UI/UX med .NET MAUI, MVVM and XAML

-- Follow the process thru the code while taking about the following as they become relavent--

1. Constructor Chaining 
 - Constructor chaining refererer til en situation, hvor en constructor kalder en anden constructor i samme klasse

link to refence for the needs topics
- https://github.com/users/Obixander/projects/8/views/1?pane=issue&itemId=67641611 