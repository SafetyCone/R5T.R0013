using System;


namespace R5T.R0013.Construction
{
    public class PageRoutes : IPageRoutes
    {
        #region Infrastructure

        public static IPageRoutes Instance { get; } = new PageRoutes();


        private PageRoutes()
        {
        }

        #endregion
    }
}
