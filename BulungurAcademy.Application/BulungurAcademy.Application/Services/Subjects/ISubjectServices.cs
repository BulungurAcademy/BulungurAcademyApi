using BulungurAcademy.Application.DataTransferObjects;

namespace BulungurAcademy.Application.Services;
public interface ISubjectServices
{
    ValueTask<SubjectDto> CreateSubjectAsync(SubjectForCreationDto subjectForCreationDto);
    // IQueryable<SubjectDto> RetrieveSubjects(QueryParameter queryParameter);
    ValueTask<SubjectDto> RetrieveSubjectByIdAsync(Guid userId);
    ValueTask<SubjectDto> ModifySubjectAsync(SubjectForModificationDto subjectForModificationDto);
    ValueTask<SubjectDto> RemoveSubjectAsync(Guid userId);
}
