﻿using ShortenerLink.Model.UriShortener.DTOs;

namespace ShortenerLink.BLL.UriShortener.Interfaces;

public interface IUriShortenerService
{
    Task<UriShortenerDto> CreateShortUriAsync(string originalUrl);

    Task<UriShortenerDto> GetShortUriAsync(string shortUrl);

    Task<bool> CheckIsExistUriAsync(string orginalUrl);

    Task IncrementUsedUriAsync(string shortUrl);

    Task<int> GetUrlUsedCount(string shortUrl);
}
