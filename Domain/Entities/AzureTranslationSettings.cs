﻿namespace Places.Domain.Entities;

public class AzureTranslationSettings
{
    public string SubscriptionKey { get; set; } = string.Empty;

    public string Endpoint { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;
}