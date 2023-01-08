using System.Text.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using TwilioConsoleSMS;

Console.WriteLine("Hello, World!");

var twilioConfigString = File.ReadAllText("twilioConfig.json");
var twilioConfig = JsonSerializer.Deserialize<TwilioConfig>(twilioConfigString);

TwilioClient.Init(twilioConfig.AccountSID, twilioConfig.AuthToken);

var message = MessageResource.Create(
    body: "Yuu have been verified.",
    from: new Twilio.Types.PhoneNumber("+100000000"), // From phone number
    to: new Twilio.Types.PhoneNumber("+200000000")); // Your phone number

Console.WriteLine(message.Status);