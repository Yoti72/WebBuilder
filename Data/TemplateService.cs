namespace WebBuilder.Data
{
    public class TemplateService
    {
        public TemplateModel CurrentTemplate { get; set; }

        public TemplateService()
        {
            CurrentTemplate = new TemplateModel();
        }
    }
}