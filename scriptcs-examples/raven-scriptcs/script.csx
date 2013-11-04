using Raven.Client;
using Raven.Client.Embedded;
using Raven.Client.Indexes;

Console.WriteLine("Starting RavenDB server...");

EmbeddableDocumentStore documentStore = null;
try
{
    documentStore = new EmbeddableDocumentStore { UseEmbeddedHttpServer = true };
    documentStore.Initialize();

    var url = string.Format("http://localhost:{0}", documentStore.Configuration.Port);
    Console.WriteLine("RavenDB started, listening on {0}.", url);

    Console.ReadKey();
}
finally
{
    if (documentStore != null)
        documentStore.Dispose();
}