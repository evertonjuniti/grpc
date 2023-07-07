# How to run this PoC

So here we have 3 "simple" projects:

1. NetCoreHelperLib : Here we have the .Net Core application that facilitates the use of `ISO8583.dll` (the one I've compiled from the C project), I've created some helper classes to avoid a lot of code to be implemented on the BFF application, I believe I've make things "cleaner" with this approach. Because this is a PoC, I've also included in this library a service to call the REST Api from the `generic-api` implementation, so we can always use the same payload for comparisons.

2. NetCoreRestApi   : Here we have the .Net Core BFF that will use the NetCoreHelperLib so we can try to exchange data using JSON but with the data itself transformed with ISO-8583 library. This project makes Api call to our `generic-api` so we can work with the same payload every time

3. NetCoreGrpc      : Here we have the .Net Core BFF with gRPC implementation in which we'll not use ISO-8583, we'll have pure gRPC for comparisons. This application uses the NetCoreHelperLib just to make que Api calls to our `generic-api` so we can make comparisons with other approaches.

Outside this folder, we have the `generic-api` folder in which we have our Java Spring Boot application with a dumb Api just to have the same payload for each BFF, so we can make comparisons with the payload directly making a call to this `generic-api` and making Api calls to our NetCoreRestApi and NetCoreGrpc solutions in this folder.

> These BFFs depends on the Java Spring Application in the `generic-api` folder outside this folder, you have to run this Java application and keep it running to test the BFFs

## The Generic Api (Java Spring Boot application)

Outside this folder, run the Java Application residing the `generic-api` folder (with Eclipse for example).

In the `generic-api` folder you will find the `Generic.postman_collection.json` file that is a Postman collection where you can make the GET Api calls already set in this collection. The BFFs will use this to make Api calls to this Generic Api and transform it's payload to test ISO-8583 and gRPC for the final client.

## The .Net Core REST Api

Inside `NetCoreRestApi` folder, you will find all of the source code, you can check what I've built to transform the payload from the `Generic-api` into a REST response using JSON but with the coded data using the ISO-8583 library.

You can find a Postman collection in this base folder (`BFFs folder`) in a file called `REST BFF.postman_collection.json'

## The .Net Core gRPC Api

Inside `NetCoreGrpc` folder, you will find all of the source code, you can check what I've built to transform the payload form the `Generic-api` using protocol buffers for response. Just for fun I've also included an implementation to use protocol buffers + ISO-8583, but for the results it didn't make any difference.

You can use Postman to make the Api calls to this solution, but I can't export the postman file.

But I'll show you how to create a Postman gRPC request:

Open Postman and click on the `New` button:

![Print - Postman - 1](/../main/images/postman_grpc_print1.png)

Click on the `gRPC` option:

![Print - Postman - 2](/../main/images/postman_grpc_print2.png)

Enter the URL (the default is `localhost:5051`):

![Print - Postman - 3](/../main/images/postman_grpc_print3.png)

On `Select a method` field, click in the "arrow" and then click the optin `Import a .proto file`:

![Print - Postman - 4](/../main/images/postman_grpc_print4.png)

In the "File Selection Windows", search for the `message.proto` file, it will be resided in `NetCoreGrpc\Protos` folder. Select the file and then click the `Open` button:

![Print - Postman - 5](/../main/images/postman_grpc_print5.png)

Click on the `Next` button:

![Print - Postman - 6](/../main/images/postman_grpc_print6.png)

Click on the `Import as API` button:

![Print - Postman - 7](/../main/images/postman_grpc_print7.png)

Wait some time and "puffff", now you can Invoke the method!

![Print - Postman - 8](/../main/images/postman_grpc_print8.png)

Now if you click on the "arrow" in the `Select a method` box, you'll see both methods imported from the `.proto` file:

![Print - Postman - 9](/../main/images/postman_grpc_print9.png)

Select one of the options and click on the `Message` tab and add the bellow payload:

`
{
    "code": "1"
}
`

![Print - Postman - 10](/../main/images/postman_grpc_print10.png)

And then click on the `Invoke` button to see the result:

![Print - Postman - 11](/../main/images/postman_grpc_print11.png)

## Wireshark filter to get info from the payload for each Api call:

Wireshark filter: ((tcp.dstport == 8080) or (tcp.dstport == 7158) or (tcp.dstport == 5051))

## Some of the links with the references that helped me to create the code:

[https://blog.quickbird.uk/calling-c-from-net-core-759563bab75d](https://blog.quickbird.uk/calling-c-from-net-core-759563bab75d)

[https://learn.microsoft.com/en-us/dotnet/framework/interop/marshalling-data-with-platform-invoke](https://learn.microsoft.com/en-us/dotnet/framework/interop/marshalling-data-with-platform-invoke)

[https://learn.microsoft.com/en-us/dotnet/framework/interop/marshalling-classes-structures-and-unions](https://learn.microsoft.com/en-us/dotnet/framework/interop/marshalling-classes-structures-and-unions)

[https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types)

[https://codereview.stackexchange.com/questions/190907/custom-enumeration-classes](https://codereview.stackexchange.com/questions/190907/custom-enumeration-classes)

[https://stackoverflow.com/questions/6637679/reflection-get-attribute-name-and-value-on-property](https://stackoverflow.com/questions/6637679/reflection-get-attribute-name-and-value-on-property)