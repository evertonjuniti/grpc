using Google.Protobuf;
using Grpc.Core;
using NetCoreHelperLib;

namespace NetCoreGrpc.Services
{
    public class MessageService : Messages.MessagesBase
    {
        private readonly ILogger<MessageService> _logger;
        IRestService restService;
        IIso8583Service iso8583Service;

        public MessageService(ILogger<MessageService> logger, IRestService restService, IIso8583Service iso8583Service)
        {
            _logger = logger;
            this.restService = restService;
            this.iso8583Service = iso8583Service;
        }

        public override Task<CommonMessageReply> CallCommonMessage(MessageRequest request, ServerCallContext context)
        {
            GenericModel model = restService.GetMessageAsync(request.Code).Result;

            CommonMessageReply response = new CommonMessageReply
            {
                Id = model.Id,
                Name = model.Name,
                Active = model.Active,
                Date = model.Date.ToString()
            };

            foreach (GenericChildModel child in model.Items)
                response.Items.Add(new CommonMessageItem
                {
                    ItemId = child.ItemId,
                    Description = child.Description,
                    Value = child.Value
                });

            return Task.FromResult(response);
        }

        public override Task<Iso8583MessageReply> CallISO8583Message(MessageRequest request, ServerCallContext context)
        {
            List<PackedModel> messages = iso8583Service.Transform(request.Code);

            Iso8583MessageReply response = new Iso8583MessageReply();

            foreach (PackedModel message in messages)
            {
                response.Mensagens.Add(new Iso8583MessageStructure
                {
                    ByteArray = ByteString.CopyFrom(message.ByteArray),
                    PackedSize = message.PackedSize
                });
            }

            return Task.FromResult(response);
        }
    }
}