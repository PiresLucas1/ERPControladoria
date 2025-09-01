using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.view.Interfaces
{
    internal interface IProdutoServico
    {
        int codigo {  get; set; }
        string Name { get; set; }

    }
    public class ProdutoServico : IProdutoServico
    {
        public int codigo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IDtoSelecaoCompletaItemForm
    {
        DataTable data { get; set; }
    }
    public class DtoSelecaoCompletaItemForm : IDtoSelecaoCompletaItemForm
    {
        public DataTable data { get; set; }
    }
}
