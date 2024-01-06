// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com
using System.Text.Json;
using Ardalis.GuardClauses;

namespace OregonNexus.Broker.Domain;

public class Manifest
{
    public string RequestType { get; set; } = default!;
    public Student? Student { get; set; }
    public RequestAddress? From { get; set; }
    public RequestAddress? To { get; set; }
    public string? Note { get; set; }
    public List<ManifestContent>? Contents { get; set; }
}