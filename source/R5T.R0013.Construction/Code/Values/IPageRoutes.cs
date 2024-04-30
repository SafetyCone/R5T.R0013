using System;

using R5T.T0131;


namespace R5T.R0013.Construction
{
    [ValuesMarker]
    public partial interface IPageRoutes : IValuesMarker
    {
        /// <summary>
        /// <para><value>/PageExample</value></para>
        /// </summary>
        public const string PageExample = "/PageExample";

        /// <summary>
        /// <para><value>/</value></para>
        /// </summary>
        public const string Home = "/";
    }
}
