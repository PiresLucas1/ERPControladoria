using System;
using System.Collections.Generic;
using System.Linq;

public static class EstoqueEnum
{
    public enum Estoque
    {
        AmazonFBAOnsiteFull = 1,
        Geral = 2,
        MercadoLivreFULL = 3,
        MercadoLivreLocal = 4,
        RaiaDrogasil = 5,
        Shopee = 6,
        Shopee205632595Fulfillment = 7,
        Shopee205655037Fulfillment = 8,
        Shopee205655101Fulfillment = 9,
        ShopeeGarnierFulfillment = 10,
        ShopeeLorealFulfillment = 11,
        ShopeeMaybellineFulfillment = 12,
        ShopeeZanupFulfillm = 13,
        Solfarma = 14,
        TikTokShop = 15
    }

    private static readonly Dictionary<Estoque, string> _map = new Dictionary<Estoque, string>
    {
        { Estoque.AmazonFBAOnsiteFull, "Amazon - FBA Onsite (Full)" },
        { Estoque.Geral, "Geral" },
        { Estoque.MercadoLivreFULL, "Mercado Livre - FULL" },
        { Estoque.MercadoLivreLocal, "Mercado Livre - Local" },
        { Estoque.RaiaDrogasil, "Raia Drogasil" },
        { Estoque.Shopee, "Shopee" },
        { Estoque.Shopee205632595Fulfillment, "Shopee 205632595 (Fulfillment)" },
        { Estoque.Shopee205655037Fulfillment, "Shopee 205655037 (Fulfillment)" },
        { Estoque.Shopee205655101Fulfillment, "Shopee 205655101 (Fulfillment)" },
        { Estoque.ShopeeGarnierFulfillment, "Shopee Garnier (Fulfillment)" },
        { Estoque.ShopeeLorealFulfillment, "Shopee L'Oréal (Fulfillment)" },
        { Estoque.ShopeeMaybellineFulfillment, "Shopee Maybelline (Fulfillment)" },
        { Estoque.ShopeeZanupFulfillm, "Shopee Zanup (Fulfillm)" },
        { Estoque.Solfarma, "Solfarma" },
        { Estoque.TikTokShop, "TikTok Shop" }
    };

    public static string st(Estoque estoque)
        => _map.TryGetValue(estoque, out var desc) ? desc : estoque.ToString();

    public static Estoque GetPorId(int id)
        => Enum.IsDefined(typeof(Estoque), id)
            ? (Estoque)id
            : throw new ArgumentException($"ID {id} inválido para EstoqueEnum");


    public static Estoque GetPorNome(string nome)
    {
        var match = _map.FirstOrDefault(x =>
            x.Value.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (!match.Equals(default(KeyValuePair<Estoque, string>)))
            return match.Key;

        throw new ArgumentException($"Nome '{nome}' inválido para EstoqueEnum");
    }
    public static List<(int Id, string Descricao)> GetLista()
        => _map.Select(x => ((int)x.Key, x.Value)).ToList();
}
