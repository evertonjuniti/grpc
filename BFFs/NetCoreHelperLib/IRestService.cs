namespace NetCoreHelperLib
{
    public interface IRestService
    {
        Task<GenericModel?> GetMessageAsync(string id);
    }
}
