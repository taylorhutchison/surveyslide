using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Microsoft.Extensions.Configuration;

namespace SurveySlide {
    public class SurveySlideDB<T> {
        private readonly string DatabaseId = "Survey";
        private readonly string CollectionId = "Surveys";
        private DocumentClient client;

        public SurveySlideDB(IConfiguration configuration)
        {
            this.client = new DocumentClient(new Uri(configuration["DB:Endpoint"]), configuration["DB:PrimaryKey"]);
        }

        public async Task<T> GetItemAsync(string id)
        {
            try
            {
                var documentUri = UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id);
                var requestOptions = new RequestOptions {
                    PartitionKey = new PartitionKey("1"),
                    
                };
                Document document = await client.ReadDocumentAsync(documentUri, requestOptions);
                return (T)(dynamic)document;
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return default(T);
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<IEnumerable<T>> GetItemsAsync(Expression<Func<T, bool>> predicate)
        {
            try {
            IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
                UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
                new FeedOptions { MaxItemCount = -1, PartitionKey = new PartitionKey("1") })
                .Where(predicate)
                .AsDocumentQuery();

            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                results.AddRange(await query.ExecuteNextAsync<T>());
            }

            return results;
            }
            catch(Exception ex) {
                throw;
            }
        }

        public async Task<Document> CreateItemAsync(T item)
        {
            return await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId), item);
        }

        public async Task<Document> UpdateItemAsync(string id, T item)
        {
            return await client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id), item);
        }

        public async Task DeleteItemAsync(string id)
        {
            await client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id));
        }
    }
}