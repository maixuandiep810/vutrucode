using System;
using vigalileo.Utilities.UriUtils;

namespace vigalileo.BackendApi.Common.ViRouter
{
    public static class ViListRoutes
    {
        public static ViRoute[] AuthenticationRoutes = new ViRoute[] {
            new ViRoute(UriConstants.API_USERS_NAME_GET.PathRegex, UriConstants.API_USERS_NAME_GET.Method)
            };

        public static ViRoute[] AuthorizationRoutes = null;
    }
}