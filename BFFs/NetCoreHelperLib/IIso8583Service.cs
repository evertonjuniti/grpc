namespace NetCoreHelperLib
{
    public interface IIso8583Service
    {
        List<PackedModel> Transform(string id);
    }
}
