using System;
using Twilio.TwiML;
using Twilio.TwiML.Voice;

class Example
{
    static void Main()
    {
        var response = new VoiceResponse();
        var refer = new Refer();
        refer.ReferSip("sip:alice@example.com");
        response.Append(refer);

        Console.WriteLine(response.ToString());
    }
}
