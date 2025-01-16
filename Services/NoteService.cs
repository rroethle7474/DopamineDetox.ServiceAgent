using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Interfaces;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Services
{
    public class NoteService : INoteService
    {
        private readonly IApiService _apiService;
        private const string BaseEndpoint = "api/Note";

        public NoteService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ApiResponse<IEnumerable<NoteDto>>> GetNotesAsync(GetNotesRequest request, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<IEnumerable<NoteDto>>(BaseEndpoint, request, cancellationToken);
        }

        public async Task<ApiResponse<NoteDto>> GetNoteAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<NoteDto>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<IEnumerable<string>>> GetNotesUserList(CancellationToken cancellationToken)
        {
            return await _apiService.GetAsync<IEnumerable<string>>($"{BaseEndpoint}/user-list", cancellationToken);
        }

        public async Task<ApiResponse<NoteDto>> CreateNoteAsync(NoteDto noteDto, CancellationToken cancellationToken)
        {
            return await _apiService.PostAsync<NoteDto>(BaseEndpoint, noteDto, cancellationToken);
        }

        public async Task<ApiResponse<NoteDto>> UpdateNoteAsync(int id, NoteDto noteDto, CancellationToken cancellationToken)
        {
            return await _apiService.PutAsync<NoteDto>($"{BaseEndpoint}/{id}", noteDto, cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteNoteAsync(int id, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/{id}", cancellationToken);
        }

        public async Task<ApiResponse<bool>> DeleteNotesByDate(DateTime date, bool isBefore, CancellationToken cancellationToken)
        {
            return await _apiService.DeleteAsync<bool>($"{BaseEndpoint}/deleteByDate?date={date:O}&isBefore={isBefore}", cancellationToken);
        }
    }
}
