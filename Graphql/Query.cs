// Graphql/Query.cs

using System.Collections.Generic;
using GraphQL;
using System.Linq;
using Api.Database;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
//using Api.Controller;
namespace Api.Graphql 
{
  public class Query
  {

    [GraphQLMetadata("books")]
    public IEnumerable<Book> GetBooks()
    {
      return Enumerable.Empty<Book>();
    }

    [GraphQLMetadata("authors")]
    public IEnumerable<Author> GetAuthors() 
    {
      return Enumerable.Empty<Author>();
    }

    [GraphQLMetadata("author")]
    public Author GetAuthor(int id)
    {
      return null;
    } // will return author(id: ID): Author

    [GraphQLMetadata("hello")]
    public string GetHello()
    {
      return "World";
    }
  }
}