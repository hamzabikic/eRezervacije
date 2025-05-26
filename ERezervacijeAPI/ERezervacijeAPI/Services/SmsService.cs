using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ERezervacijeAPI.Services
{
    public class SmsService
    {
        public static void posaljiPoruku (string phoneNumber, string text)
        {
            var accountSid = "-- OVDJE NALIJEPITI VAŠ TWILIO ACCOUNT-SID --";
            var authToken = "-- OVDJE NALIJEPITI VAŠ TWILIO AUTH-TOKEN --";
            TwilioClient.Init(accountSid, authToken);
            var poruka = "Restoran Premija - ERezervacije: ";
            poruka += text;
            var messageOptions = new CreateMessageOptions(
              new PhoneNumber(phoneNumber));
            messageOptions.MessagingServiceSid = "-- OVDJE NALIJEPITI VAŠ TWILIO MESSAGING SERVICE SID --";
            messageOptions.Body = poruka;

            try
            {
                var message = MessageResource.Create(messageOptions);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
