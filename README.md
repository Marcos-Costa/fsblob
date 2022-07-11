# fsblob
just playing around with blobs

# Checklist
| Done | Category             | Design consideration                                                                                                                                  |
|------|----------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------|
|      | Scalability targets  | Can you design your application to use no more than the maximum number of storage accounts?                                                           |
|      | Scalability targets  | Are you avoiding approaching capacity and transaction limits?                                                                                         |
|      | Scalability targets  | Are a large number of clients accessing a single blob concurrently?                                                                                   |
|      | Scalability targets  | Is your application staying within the scalability targets for a single blob?                                                                         |
|      | Partitioning         | Is your naming convention designed to enable better load-balancing?                                                                                   |
|      | Networking           | Do client-side devices have sufficiently high bandwidth and low latency to achieve the performance needed?                                            |
|      | Networking           | Do client-side devices have a high quality network link?                                                                                              |
|      | Networking           | Is the client application in the same region as the storage account?                                                                                  |
|      | Direct client access | Are you using shared access signatures (SAS) and cross-origin resource sharing (CORS) to enable direct access to Azure Storage?                       |
|      | Caching              | Is your application caching data that is frequently accessed and rarely changed?                                                                      |
|      | Caching              | Is your application batching updates by caching them on the client and then uploading them in larger sets?                                            |
|      | .NET configuration   | Are you using .NET Core 2.1 or later for optimum performance?                                                                                         |
|      | .NET configuration   | Have you configured your client to use a sufficient number of concurrent connections?                                                                 |
|      | .NET configuration   | For .NET applications, have you configured .NET to use a sufficient number of threads?                                                                |
|      | Parallelism          | Have you ensured that parallelism is bounded appropriately so that you don't overload your client's capabilities or approach the scalability targets? |
|      | Tools                | Are you using the latest versions of Microsoft-provided client libraries and tools?                                                                   |
|      | Retries              | Are you using a retry policy with an exponential backoff for throttling errors and timeouts?                                                          |
|      | Retries              | Is your application avoiding retries for non-retryable errors?                                                                                        |
|      | Copying blobs        | Are you copying blobs in the most efficient manner?                                                                                                   |
|      | Copying blobs        | Are you using the latest version of AzCopy for bulk copy operations?                                                                                  |
|      | Copying blobs        | Are you using the Azure Data Box family for importing large volumes of data?                                                                          |
|      | Content distribution | Are you using a CDN for content distribution?                                                                                                         |
|      | Use metadata         | Are you storing frequently used metadata about blobs in their metadata?                                                                               |
|      | Uploading quickly    | When trying to upload one blob quickly, are you uploading blocks in parallel?                                                                         |
|      | Uploading quickly    | When trying to upload many blobs quickly, are you uploading blobs in parallel?                                                                        |
|      | Blob type            | Are you using page blobs or block blobs when appropriate?                                                                                             |
