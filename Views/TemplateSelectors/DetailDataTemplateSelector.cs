using TestMauiApp.ViewModels;

namespace TestMauiApp.Views.TemplateSelectors
{
    public class DetailDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TypeStep { get; set; }
        public DataTemplate SearchStep { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            DetailViewStep myStep = (DetailViewStep)(short)item;

            switch (myStep)
            {
                case DetailViewStep.Type: return TypeStep;               
                case DetailViewStep.Search: return SearchStep;
                default: return null;
            }
        }
    }
}
