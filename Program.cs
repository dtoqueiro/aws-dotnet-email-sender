using System;
using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

namespace ses_sendmail_dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Sending Email...");
      using (var client = new AmazonSimpleEmailServiceV2Client(Amazon.RegionEndpoint.USEast2))
      {
        var sendRequest = new SendEmailRequest
        {
          FromEmailAddress = "no-repply@anfitriaoprime.com.br",
          Destination = new Destination { ToAddresses = { "cereso.rodrigues@anfitriaoprime.com.br" } },

          Content = new EmailContent
          {
            Simple = new Message
            {
              Subject = new Content
              {
                Data = "Mensagem de teste | Envio de e-mail usando o AWS SES"
              },
              Body = new Body
              {
                Html = new Content
                {
                  Data = "<html><body><h2>Email teste da AWS SES</h2><ul><li>Lista Html 01</li><li>Lista Html 02</li></body></html>"

                },
                Text = new Content
                {
                  Data = "Email teste da AWS SES"
                },

              },
            },
          }
        };

        try
        {
          var response = client.SendEmailAsync(sendRequest).Result;
          Console.WriteLine("Email sent! Message ID = {0}", response.MessageId);
        }
        catch (Exception ex)
        {
          Console.WriteLine("Send failed with exception: {0}", ex.Message);
        }
      }

      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }
  }
}
