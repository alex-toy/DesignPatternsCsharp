﻿namespace Lookups;

public class Achat
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int ArticleId { get; set; }
    public Article Article { get; set; } = new Article();
    public int Quantite { get; set; }
}
