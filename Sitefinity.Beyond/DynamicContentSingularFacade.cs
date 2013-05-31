namespace Sitefinity.Beyond
{
    using Telerik.Sitefinity.Data;
    using Telerik.Sitefinity.DynamicModules;
    using Telerik.Sitefinity.DynamicModules.Model;
    using Telerik.Sitefinity.Fluent;

    public class DynamicContentSingularFacade<TParentFacade> : BaseSingularFacade<DynamicContentSingularFacade<TParentFacade>, TParentFacade, DynamicContent>
        where TParentFacade : BaseFacade
    {
        public DynamicContentSingularFacade(AppSettings settings)
            : base(settings)
        {
        }

        protected override IManager InitializeManager()
        {
            return DynamicModuleManager.GetManager();
        }
    }
}