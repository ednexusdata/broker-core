using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OregonNexus.Broker.Connector.Payload;
using OregonNexus.Broker.Connector.PayloadContentTypes;
using OregonNexus.Broker.Domain;
using OregonNexus.Broker.Domain.Specifications;
using OregonNexus.Broker.SharedKernel;

namespace OregonNexus.Broker.Connector.Resolvers;

public interface IPayloadResolver
{
    public Task<IncomingPayloadSettings> FetchIncomingPayloadSettingsAsync<T>() where T : IPayload;

    public Task<OutgoingPayloadSettings> FetchOutgoingPayloadSettingsAsync<T>() where T : IPayload;
}