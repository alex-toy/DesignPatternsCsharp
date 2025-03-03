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
using Lookups;
using Proxy.Bad;
using Proxy.Bad.ThirdPartyVideoLib;
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

//Bridge();

//Lookup();

Proxy();

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

    RemoteControl remote = new RemoteControl()
    {
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

static void Lookup()
{
    List<Article> articles = new()
    {
        new Article { Id = 1, Title = "iphone", Price = 200  },
        new Article { Id = 2, Title = "mac book", Price = 1300 },
    };

    List<Achat> achats = new()
    {
        new Achat { UserId = 1, ArticleId = 1, Quantite = 2  },
        new Achat { UserId = 1, ArticleId = 2, Quantite = 3  },
        new Achat { UserId = 2, ArticleId = 1, Quantite = 1  },
        new Achat { UserId = 2, ArticleId = 2, Quantite = 2  },
    };

    List<User> users = new()
    {
        new User { Id = 1, Name = "seb" },
        new User { Id = 2, Name = "alex" },
    };

    //foreach (var achat in achats)
    //{
    //    foreach (var article in articles)
    //    {
    //        if (achat.ArticleId == article.Id) achat.Article = article;
    //    }
    //}

    var articleParId = articles.ToDictionary(a => a.Id);
    foreach (var achat in achats)
    {
        achat.Article = articleParId[achat.ArticleId];
    }

    var userParId = users.ToDictionary(a => a.Id);
    foreach (var achat in achats)
    {
        achat.User = userParId[achat.UserId];
    }

    //foreach (User user in users)
    //{
    //    foreach (Achat achat in achats)
    //    {
    //        if (achat.UserId == user.Id)
    //        {
    //            user.Achats.Add(achat);
    //        }
    //    }
    //}

    ILookup<int, Achat> achatParUser = achats.ToLookup(a => a.UserId);
    foreach (User user in users)
    {
        user.Achats = achatParUser[user.Id].ToList();
    }

    foreach (User user in users)
    {
        Console.WriteLine($"id {user.Id} - {user.Name}");
        foreach (Achat achat in user.Achats)
        {
            Console.WriteLine($"     {achat.Article.Title} : {achat.Quantite} * {achat.Article.Price} = {achat.Quantite * achat.Article.Price}");
        }
    }

    ILookup<int, Achat> achatParArticle = achats.ToLookup(a => a.ArticleId);
    foreach (Article article in articles)
    {
        article.Achats = achatParArticle[article.Id].ToList();
    }

    foreach (Article article in articles)
    {
        Console.WriteLine($"id {article.Id} - {article.Title}");
        foreach (Achat achat in article.Achats)
        {
            Console.WriteLine($"     {achat.User.Name} : {achat.Quantite} * {achat.Article.Price} = {achat.Quantite * achat.Article.Price}");
        }
    }
}

static void Proxy()
{
    BadVideoList videoList = new BadVideoList();
    string[] videoIds = ["v1", "v2", "v3"];
    foreach (var videoId in videoIds)
    {
        videoList.Add(new BadYouTubeVideo(videoId));
    }
}