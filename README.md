The repository is used to reproduce an [issue on StackOver](https://stackoverflow.com/questions/72048707/asp-net-core-jsonserializeroptions-defaultignorecondition-not-working-for-ienu): 
> ASP .NET Core - JsonSerializerOptions.DefaultIgnoreCondition not working for IEnumerable<T> 

To replicate, clone the repo and run `dotnet run`. The API service has three endpoints:

1. /objectResult - return an [ObjectResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.objectresult?view=aspnetcore-3.1). 
   GET /objectResult
   ```json
   {
       "bar": null,
       "foo": 1
   }
   ```

2. /jsonResult - return an [JsonResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.jsonresult?view=aspnetcore-3.1) 
   GET /jsonResult
   ```json
   {
       "foo": "1"
   }
   ```

3. /contentResult - return an [ContentResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.contentresult?view=aspnetcore-3.1) 
   GET /contentResult
   ```json
   {
       "foo": "1"
   }
   ```