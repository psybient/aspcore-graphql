## Intro 
This Project is initiated with :
`dotnet new webapp -o aspnetcoreapp`

### Requirments

`dotnet add package GraphQL --version 2.4.0`

`dotnet add package graphiql --version 1.2.0`

### run

`dotnet run`

### Use GraphiQL

Navigate to :
`https://localhost:5001/graphql/`

### Queries
We Seed the database in the main() method inside Program.cs

`query{author(id:1){name}}`

`mutation{addAuthor(name:"Paolo Coelho")}`

```query{authors {  id,name,books}}```

#### Resource
Base on [this article](https://dev.to/dotnet/how-you-can-build-a-web-api-using-graphql-net-core-and-entity-framework-1ago)