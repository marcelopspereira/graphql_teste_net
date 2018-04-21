using GraphQL.Types;

namespace graphql_teste
{
    public class HelloWorldSchema : Schema
    {
        public HelloWorldSchema(HelloWorldQuery query)
        {
            Query = query;
        }
    }
}