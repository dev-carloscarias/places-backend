﻿namespace Places.Domain.Entities;

public class TranslationRequest
{
    public string SourceLanguage { get; set; } = string.Empty;

    public string TargetLanguage { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;
}