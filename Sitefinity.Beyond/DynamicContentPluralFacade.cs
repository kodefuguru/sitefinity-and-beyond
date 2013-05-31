namespace Sitefinity.Beyond
{
    using System;
    using System.Linq;
    using Telerik.Sitefinity.Data;
    using Telerik.Sitefinity.DynamicModules;
    using Telerik.Sitefinity.DynamicModules.Model;
    using Telerik.Sitefinity.Fluent;
    using Telerik.Sitefinity.Utilities.TypeConverters;

    public class DynamicContentPluralFacade<TParentFacade> : BasePluralFacade<DynamicContentPluralFacade<TParentFacade>, DynamicContentSingularFacade<TParentFacade>, TParentFacade, DynamicContent>
        where TParentFacade : BaseFacade
    {
        public Type type;

        public DynamicContentPluralFacade(AppSettings settings)
            : this(settings, typeof(DynamicContent))
        {
        }

        public DynamicContentPluralFacade(AppSettings settings, string className)
            : this(settings, TypeResolutionService.ResolveType(className))
        {
        }       

        public DynamicContentPluralFacade(AppSettings settings, Type type)
            : base(settings)
        {
            this.type = type;
        }

        protected override IManager InitializeManager()
        {
            return DynamicModuleManager.GetManager();
        }

        protected override IQueryable<DynamicContent> LoadItems()
        {
            return DynamicModuleManager.GetManager().GetDataItems(type);
        }
    }
}