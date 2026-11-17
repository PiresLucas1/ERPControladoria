using System.Globalization;
using System.Xml.Linq;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    // Totais do quadro "Cálculo do Imposto" da NF-e (grupo total/ICMSTot do XML)
    public class TotaisNotaXml
    {
        public decimal BaseCalculoIcms { get; set; }       // vBC
        public decimal ValorIcms { get; set; }             // vICMS
        public decimal BaseCalculoIcmsST { get; set; }     // vBCST
        public decimal ValorIcmsST { get; set; }           // vST
        public decimal ValorTotalProdutos { get; set; }    // vProd
        public decimal ValorFrete { get; set; }            // vFrete
        public decimal ValorDesconto { get; set; }         // vDesc
        public decimal ValorOutrasDespesas { get; set; }   // vOutro
        public decimal ValorIpi { get; set; }              // vIPI
        public decimal ValorPis { get; set; }              // vPIS
        public decimal ValorCofins { get; set; }           // vCOFINS
        public decimal ValorTotalTributos { get; set; }    // vTotTrib
        public decimal ValorTotalNota { get; set; }        // vNF
    }

    // Impostos e valores de um item (<det>) da NF-e. Tag ausente vale zero
    public class ImpostoItemXml
    {
        public int NumeroItem { get; set; }                // det/@nItem
        public string CodProduto { get; set; }             // prod/cProd

        public decimal BaseIcms { get; set; }              // ICMSxx/vBC
        public decimal AliquotaIcms { get; set; }          // ICMSxx/pICMS
        public decimal ValorIcms { get; set; }             // ICMSxx/vICMS
        public decimal BaseIcmsST { get; set; }            // ICMSxx/vBCST
        public decimal AliquotaIcmsST { get; set; }        // ICMSxx/pICMSST
        public decimal ValorIcmsST { get; set; }           // ICMSxx/vICMSST
        public decimal BaseIpi { get; set; }               // IPITrib/vBC
        public decimal AliquotaIpi { get; set; }           // IPITrib/pIPI
        public decimal ValorIpi { get; set; }              // IPITrib/vIPI
        public decimal BasePis { get; set; }               // PISxx/vBC
        public decimal AliquotaPis { get; set; }           // PISxx/pPIS
        public decimal ValorPis { get; set; }              // PISxx/vPIS
        public decimal BaseCofins { get; set; }            // COFINSxx/vBC
        public decimal AliquotaCofins { get; set; }        // COFINSxx/pCOFINS
        public decimal ValorCofins { get; set; }           // COFINSxx/vCOFINS

        // Reforma tributária: grupo IBSCBS/gIBSCBS (a base é a mesma para IBS UF, IBS Mun. e CBS)
        public decimal BaseIbsCbs { get; set; }            // gIBSCBS/vBC
        public decimal AliquotaIbsUF { get; set; }         // gIBSUF/pIBSUF
        public decimal ValorIbsUF { get; set; }            // gIBSUF/vIBSUF
        public decimal AliquotaIbsMun { get; set; }        // gIBSMun/pIBSMun
        public decimal ValorIbsMun { get; set; }           // gIBSMun/vIBSMun
        public decimal AliquotaCbs { get; set; }           // gCBS/pCBS
        public decimal ValorCbs { get; set; }              // gCBS/vCBS

        public decimal ValorFrete { get; set; }            // prod/vFrete
        public decimal ValorDesconto { get; set; }         // prod/vDesc
        public decimal ValorOutrasDespesas { get; set; }   // prod/vOutro
        public decimal ValorTotalTributos { get; set; }    // imposto/vTotTrib
    }

    public class ExtrairTotaisNotaXml
    {
        /// <summary>
        /// Lê os impostos de cada item (<det>) do XML, na ordem em que aparecem.
        /// </summary>
        public List<ImpostoItemXml> ExtrairItens(string xml)
        {
            var itens = new List<ImpostoItemXml>();
            if (string.IsNullOrWhiteSpace(xml))
                return itens;

            XDocument doc = XDocument.Parse(xml);

            foreach (XElement det in doc.Descendants().Where(e => e.Name.LocalName == "det"))
            {
                XElement prod = Filho(det, "prod");
                XElement imposto = Filho(det, "imposto");

                // ICMS, PIS e COFINS vêm dentro de um subgrupo que varia com o CST (ICMS00, ICMS10, PISAliq, PISOutr...)
                XElement icms = PrimeiroFilho(Filho(imposto, "ICMS"));
                XElement ipi = Filho(Filho(imposto, "IPI"), "IPITrib");
                XElement pis = PrimeiroFilho(Filho(imposto, "PIS"));
                XElement cofins = PrimeiroFilho(Filho(imposto, "COFINS"));
                XElement ibsCbs = Filho(Filho(imposto, "IBSCBS"), "gIBSCBS");
                XElement ibsUF = Filho(ibsCbs, "gIBSUF");
                XElement ibsMun = Filho(ibsCbs, "gIBSMun");
                XElement cbs = Filho(ibsCbs, "gCBS");

                itens.Add(new ImpostoItemXml
                {
                    NumeroItem = int.TryParse(det.Attribute("nItem")?.Value, out int nItem) ? nItem : itens.Count + 1,
                    CodProduto = Filho(prod, "cProd")?.Value?.Trim(),

                    BaseIcms = LerValor(icms, "vBC"),
                    AliquotaIcms = LerValor(icms, "pICMS"),
                    ValorIcms = LerValor(icms, "vICMS"),
                    BaseIcmsST = LerValor(icms, "vBCST"),
                    AliquotaIcmsST = LerValor(icms, "pICMSST"),
                    ValorIcmsST = LerValor(icms, "vICMSST"),
                    BaseIpi = LerValor(ipi, "vBC"),
                    AliquotaIpi = LerValor(ipi, "pIPI"),
                    ValorIpi = LerValor(ipi, "vIPI"),
                    BasePis = LerValor(pis, "vBC"),
                    AliquotaPis = LerValor(pis, "pPIS"),
                    ValorPis = LerValor(pis, "vPIS"),
                    BaseCofins = LerValor(cofins, "vBC"),
                    AliquotaCofins = LerValor(cofins, "pCOFINS"),
                    ValorCofins = LerValor(cofins, "vCOFINS"),
                    BaseIbsCbs = LerValor(ibsCbs, "vBC"),
                    AliquotaIbsUF = LerValor(ibsUF, "pIBSUF"),
                    ValorIbsUF = LerValor(ibsUF, "vIBSUF"),
                    AliquotaIbsMun = LerValor(ibsMun, "pIBSMun"),
                    ValorIbsMun = LerValor(ibsMun, "vIBSMun"),
                    AliquotaCbs = LerValor(cbs, "pCBS"),
                    ValorCbs = LerValor(cbs, "vCBS"),

                    ValorFrete = LerValor(prod, "vFrete"),
                    ValorDesconto = LerValor(prod, "vDesc"),
                    ValorOutrasDespesas = LerValor(prod, "vOutro"),
                    ValorTotalTributos = LerValor(imposto, "vTotTrib")
                });
            }

            return itens;
        }

        private static XElement Filho(XElement pai, string nome)
        {
            return pai?.Elements().FirstOrDefault(e => e.Name.LocalName == nome);
        }

        private static XElement PrimeiroFilho(XElement pai)
        {
            return pai?.Elements().FirstOrDefault();
        }

        public TotaisNotaXml Executar(string xml)
        {
            var totais = new TotaisNotaXml();
            if (string.IsNullOrWhiteSpace(xml))
                return totais;

            XDocument doc = XDocument.Parse(xml);

            // Busca pelo nome local para não depender do namespace da SEFAZ
            XElement icmsTot = doc.Descendants()
                .FirstOrDefault(e => e.Name.LocalName == "ICMSTot");

            if (icmsTot == null)
                return totais;

            totais.BaseCalculoIcms = LerValor(icmsTot, "vBC");
            totais.ValorIcms = LerValor(icmsTot, "vICMS");
            totais.BaseCalculoIcmsST = LerValor(icmsTot, "vBCST");
            totais.ValorIcmsST = LerValor(icmsTot, "vST");
            totais.ValorTotalProdutos = LerValor(icmsTot, "vProd");
            totais.ValorFrete = LerValor(icmsTot, "vFrete");
            totais.ValorDesconto = LerValor(icmsTot, "vDesc");
            totais.ValorOutrasDespesas = LerValor(icmsTot, "vOutro");
            totais.ValorIpi = LerValor(icmsTot, "vIPI");
            totais.ValorPis = LerValor(icmsTot, "vPIS");
            totais.ValorCofins = LerValor(icmsTot, "vCOFINS");
            totais.ValorTotalTributos = LerValor(icmsTot, "vTotTrib");
            totais.ValorTotalNota = LerValor(icmsTot, "vNF");

            return totais;
        }

        // Tag ausente ou vazia vale zero. O XML da NF-e usa ponto como separador decimal
        private static decimal LerValor(XElement grupo, string tag)
        {
            if (grupo == null)
                return 0m;

            string texto = grupo.Elements()
                .FirstOrDefault(e => e.Name.LocalName == tag)?.Value;

            return decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valor)
                ? valor
                : 0m;
        }
    }
}
