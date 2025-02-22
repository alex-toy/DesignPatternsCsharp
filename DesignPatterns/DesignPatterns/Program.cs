using System.Collections.Generic;
using ChainOfResponsability;
using ChainOfResponsability.Bad;
//using ChainOfResponsability.Good;
using ChainOfResponsability.Generic;
using ChainOfResponsability.Generic.Handlers;
using Visitor.Bad;
using Visitor.Generic;
using Visitor.Generic.Clients;
using Visitor.Generic.Visitors;
//using Visitor.Good;

//ChainResponsability();

Visitor();




static void ChainResponsability()
{
    HttpRequest request = new("danny", "123");

    //BadWebServer webServer = new();
    //webServer.Handle(request);

    Validator validator = new() { Next = new Authenticator() { Next = new Logger() { Next = null } } };
    WebServer server = new() { Handler = validator };
    server.Handle(request);

    WebServerB serverB = new() { Handler = new Validator() { Next = new AuthenticatorB() { Next = new Logger() { Next = null } } } };
    serverB.Handle(request);
}

static void Visitor()
{
    //List<BadClient> badClients = new()
    //{
    //    new BadRestaurant("restaurant", "resto@test.com"),
    //    new BadLaw("law", "law@test.fr"),
    //    new BadRetail("retail", "retail@test.com"),
    //};

    //foreach (var badClient in badClients)
    //{
    //    badClient.SendEmail();
    //}

    List<Client> clients = new()
    {
        new Restaurant("restaurant", "resto@test.com"),
        new Law("law", "law@test.fr"),
        new Retail("retail", "retail@test.com"),
    };

    foreach (var client in clients)
    {
        client.Accept(new EmailVisitor());
        client.Accept(new PDFExportVisitor());
    }
}