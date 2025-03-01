using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Adapter;
using Adapter.Adapters;
using Adapter.Colors;
using Bridge.Bad;
using Bridge.Good;
using Bridge.Good.Dimensions;
using ChainOfResponsability;
using ChainOfResponsability.Bad;
//using ChainOfResponsability.Good;
using ChainOfResponsability.Generic;
using ChainOfResponsability.Generic.Handlers;
using Composite.Good.Items;
using Composite.Good.Structure;

//using Composite.Bad;
using Interpretor;
using Visitor.Bad;
using Visitor.Generic;
using Visitor.Generic.Clients;
using Visitor.Generic.Visitors;
//using Visitor.Good;

//ChainResponsability();

//Visitor();

//Interpretor();

//Composite();

//Adapter();

Bridge();

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

static void Interpretor()
{
    Interpreter interpretor = new(new Context());
    Console.WriteLine(interpretor.Interpret("2 * 3"));
    Console.WriteLine(interpretor.Interpret("2 * 3 + 6"));
    Console.WriteLine(interpretor.Interpret("2 * 4 - 6"));
}

static void Composite()
{
    var box1 = new Box();
    box1.Add(new Keyboard());
    box1.Add(new Mouse());

    var box2 = new Box();
    box2.Add(new Keyboard());
    box2.Add(new Mouse());

    var box = new Box();
    box.Add(box1);
    box.Add(box2);
    //var price = box.GetPrice();
    var price = box.GetPrice();
    Console.WriteLine(price);
}

static void Adapter()
{
    VideoEditor editor = new(new Video());
    editor.ApplyColor(new BlackAndWhiteColor());
    editor.ApplyColor(new RainbowColor());
    editor.ApplyColor(new VividColor());
}

static void Bridge()
{
    Sony_Low_Basic_Remote badRemote1 = new();
    badRemote1.TurnOn();
    badRemote1.VolumeUp();

    RemoteControl remote = new RemoteControl() { 
        Brand = new Brand { Label = "sony" },
        Power = new Power { Category = "low", Value = 87 },
        Functionality = new Functionality { Label = "Basic" }, 
    };
    remote.TurnOn();
    remote.VolumeUp();

    LG_Medium_Advanced_Remote badRemote2 = new();
    badRemote2.TurnOn();
    badRemote2.VolumeUp();

    RemoteControl remote2 = new RemoteControl()
    {
        Brand = new Brand { Label = "LG" },
        Power = new Power { Category = "Medium", Value = 865 },
        Functionality = new Functionality { Label = "advanced" },
    };
    remote2.TurnOn();
    remote2.VolumeUp();
}