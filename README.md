# DopamineDetox.ServiceAgent

## Overview

The `DopamineDetox.ServiceAgent` package is a service agent used for the Social Media Detox Project to connect to various APIs. This package provides a set of services and models to facilitate communication with the backend services.

## Features

- **API Service**: A generic service to handle HTTP requests (GET, POST, PUT, PATCH, DELETE) with error handling and response processing.
- **Request Models**: Models to structure the data sent to the API.
- **Response Models**: Models to structure the data received from the API.
- **Service Interfaces**: Interfaces defining the contract for various services.
- **Service Implementations**: Concrete implementations of the service interfaces.

## Services

### ApiService

A generic service to handle HTTP requests with methods for:
- `GetAsync<T>(string endpoint, CancellationToken cancellationToken = default)`
- `PostAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default)`
- `PutAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default)`
- `PatchAsync<T>(string endpoint, object data, CancellationToken cancellationToken = default)`
- `DeleteAsync<T>(string endpoint, CancellationToken cancellationToken = default)`

### ContentTypeService

Interface and implementation for managing content types:
- `GetContentTypesAsync(CancellationToken cancellationToken)`
- `GetContentTypeAsync(int id, CancellationToken cancellationToken)`
- `CreateContentTypeAsync(ContentTypeDto contentTypeDto, CancellationToken cancellationToken)`
- `UpdateContentTypeAsync(int id, ContentTypeDto contentTypeDto, CancellationToken cancellationToken)`
- `DeleteContentTypeAsync(int id, CancellationToken cancellationToken)`

### HistorySearchResultService

Interface and implementation for managing history search results:
- `GetHistorySearchResultsAsync(CancellationToken cancellationToken)`
- `GetHistorySearchResultAsync(int id, CancellationToken cancellationToken)`
- `CreateHistorySearchResultAsync(HistorySearchResultDto historySearchResultDto, CancellationToken cancellationToken)`
- `UpdateHistorySearchResultAsync(int id, HistorySearchResultDto historySearchResultDto, CancellationToken cancellationToken)`
- `DeleteHistorySearchResultAsync(int id, CancellationToken cancellationToken)`

## Models

### Requests

- `UpdateProfileRequest`: Model for updating user profile information.

### Responses

- `ApiResponse<T>`: Generic model for API responses.

## Installation

To install the `DopamineDetox.ServiceAgent` package, run the following command in the Package Manager Console:

## Authors

- Ryan Roethle

## License

This project is licensed under the MIT License.
