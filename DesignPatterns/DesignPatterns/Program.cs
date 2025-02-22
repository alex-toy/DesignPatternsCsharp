using ChainOfResponsability;
using ChainOfResponsability.Bad;
//using ChainOfResponsability.Good;
using ChainOfResponsability.Generic;
using ChainOfResponsability.Generic.Handlers;

HttpRequest request = new("danny", "123");

//BadWebServer webServer = new();
//webServer.Handle(request);

Validator validator = new() { Next = new Authenticator() { Next = new Logger() { Next = null } } };
WebServer server = new() { Handler = validator };
server.Handle(request);

WebServerB serverB = new() { Handler = new Validator() { Next = new AuthenticatorB() { Next = new Logger() { Next = null } } } };
serverB.Handle(request);