using Grpc.Net.Client;
using Foodzilla.Presentation.Customer;

Console.WriteLine("Hello, World!");

var request = new GetCustomerRpcQuery() { Id = 1 };

var channel = GrpcChannel.ForAddress("https://localhost:44354/");

var client = new CustomerRpcService.CustomerRpcServiceClient(channel);

var response = await client.GetCustomerRpcAsync(request);

Console.WriteLine(response.Name + " " + " " + response.Family + " " +  " " + response.NationalCode);