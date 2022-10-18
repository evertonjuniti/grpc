using NetCoreIso8583x64Lib;

namespace NetCoreHelperLib
{
    public class Iso8583Service : IIso8583Service
    {
        IMessage iso8385MessageService;
        IRestService restService;

        public Iso8583Service(IMessage message, IRestService restService)
        {
            this.iso8385MessageService = message;
            this.restService = restService;
        }

        public List<PackedModel> Transform(string id)
        {
            List<PackedModel> response = new List<PackedModel>();

            GenericModel model = restService.GetMessageAsync(id).Result;

            List<string> byteMessages = new List<string>();

            iso8385MessageService.SetMessage<GenericModel>(model);
            iso8385MessageService.PackMessage();
            response.Add(new PackedModel()
            {
                ByteArray = iso8385MessageService.GetByteArray(),
                PackedSize = iso8385MessageService.GetPackedSize()
            });

            foreach (GenericChildModel child in model.Items)
            {
                iso8385MessageService.SetMessage<GenericChildModel>(child);
                iso8385MessageService.PackMessage();
                response.Add(new PackedModel()
                {
                    ByteArray = iso8385MessageService.GetByteArray(),
                    PackedSize = iso8385MessageService.GetPackedSize()
                });
            }
            /*
            foreach (PackedModel pack in response)
            {
                iso8385MessageService.UnpackMessage(pack.ByteArray, pack.PackedSize);
                Console.WriteLine(iso8385MessageService.GetMessageFields());
            }
            */
            return response;
        }
    }
}
