using DopamineDetox.Domain.Dtos;
using DopamineDetox.ServiceAgent.Models.Responses;
using DopamineDetox.ServiceAgent.Requests;

namespace DopamineDetox.ServiceAgent.Interfaces
{
    public interface INoteService
    {
        //Another test.
        Task<ApiResponse<IEnumerable<NoteDto>>> GetNotesAsync(GetNotesRequest request, CancellationToken cancellationToken);
        Task<ApiResponse<NoteDto>> GetNoteAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<NoteDto>> CreateNoteAsync(NoteDto noteDto, CancellationToken cancellationToken);
        Task<ApiResponse<NoteDto>> UpdateNoteAsync(int id, NoteDto noteDto, CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteNoteAsync(int id, CancellationToken cancellationToken);
        Task<ApiResponse<IEnumerable<string>>> GetNotesUserList(CancellationToken cancellationToken);
        Task<ApiResponse<bool>> DeleteNotesByDate(DateTime startingDate, bool isBefore, CancellationToken cancellationToken);
    }
}
