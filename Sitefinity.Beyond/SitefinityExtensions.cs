namespace Sitefinity.Beyond
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Telerik.Sitefinity.DynamicTypes.Model;
    using Telerik.Sitefinity.Fluent;
    
    public static class SitefinityExtensions
    {
        public static DynamicContentPluralFacade<BaseFacade> DynamicContent<TDynamicType>(this FluentSitefinity fluent)
            where TDynamicType : DynamicTypeBase
        {
            return new DynamicContentPluralFacade<BaseFacade>(fluent.AppSettings, typeof(TDynamicType));
        }

        public static DynamicContentPluralFacade<BaseFacade> DynamicContent(this FluentSitefinity fluent, string className)
        {
            return new DynamicContentPluralFacade<BaseFacade>(fluent.AppSettings, className);
        }

        public static DynamicContentPluralFacade<BaseFacade> DynamicContent(this FluentSitefinity fluent, Type type)
        {
            return new DynamicContentPluralFacade<BaseFacade>(fluent.AppSettings, type);
        }
    }
}