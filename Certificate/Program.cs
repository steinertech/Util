var list = new string[] 
{ 
    "https://google.com", 
    "https://github.com", 
};

foreach (var item in list)
{
    using var handler = new HttpClientHandler();

    handler.ServerCertificateCustomValidationCallback = (requestMessage, certificate, x509Chain, SsIPolicyErrors) =>
    {
        Console.WriteLine($"Certificate Expiration Date: {certificate?.GetExpirationDateString()} ({requestMessage.RequestUri})");
        return true;
    };

    using var client = new HttpClient(handler);

    await client.GetAsync(item);
}
