
Blazor server side allows you to easily host a razor component but it uses the @page directive for routing.

If you use MVC with controllers and views it becomes harder to consume a component and have it hosted within the razor view so you can slowly rollout functionality with a richer user experience.

This component allows you to create razorcomponents that handle searching/editing/deleting/creating of things. The router does not allow state so you must use DI to inject a store or view model for the components to handle state transitions.

The ComponentRouter site shows how to use it but its as follows:

1) Add the project to your project
2) Call services.AddComponentRouter(); in the Startup:ConfigureServices() method
3) add the following to your MVC View/Razor page:

<CrudComponentRouter>
    <SearchComponent>
        Component or Text for Search Route
    </SearchComponent>
    <EditComponent>
        Component or Text for Edit Route
    </EditComponent>
    <DeleteComponent>
        Component or Text for Delete Route
    </DeleteComponent>
    <CreateComponent>
        Component or Text for Create Route
    </CreateComponent>
</CrudComponentRouter>

4) To navigate from within your components 
   Add @inject CrudComponentRouterService ComponentRouter 
   Then in your function add this.ComponentRouter.Navigate(Route)

