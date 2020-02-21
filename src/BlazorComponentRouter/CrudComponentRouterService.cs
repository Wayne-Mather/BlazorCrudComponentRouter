using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Components;

namespace BlazorComponentRouting
{
    
    public enum RouterState
    {
        Search,
        Edit,
        Delete,
        Create
    }
    
    public class CrudComponentRouterService
    {
        private CrudComponentRouter _router;
        
        public void RegisterRouter(CrudComponentRouter router)
        {
            
            this._router = router;
        }

        public void Navigate(RouterState state)
        {
            _router?.Navigate(state);
        }
    }
}