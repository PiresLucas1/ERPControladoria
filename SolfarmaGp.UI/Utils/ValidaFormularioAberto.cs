namespace SolfarmaGp.UI.Utils
{
    static class ValidaFormularioAberto
    {
        public static bool FormAberto(Type tipoForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tipoForm)
                {
                    form.Focus(); // traz o form existente para frente
                    return true;
                }
            }
            return false;
        }
    }
}
