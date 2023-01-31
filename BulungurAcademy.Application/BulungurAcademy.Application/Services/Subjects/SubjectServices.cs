using BulungurAcademy.Application.DataTransferObjects;
using BulungurAcademy.Infrastructure.Repositories.Subjects;

namespace BulungurAcademy.Application.Services;
public partial class SubjectServices : ISubjectServices
{
    //============= partial bo'ldi keyinchalik validatsiyalarni o'rnatish va boshqa ammallar uchun
    private readonly ISubjectRepository subjectRepository;
    public SubjectServices(ISubjectRepository subjectRepository) =>
        this.subjectRepository = subjectRepository;

    /// <summary>
    /// Subject Create
    /// </summary>
    public ValueTask<SubjectDto> CreateSubjectAsync(SubjectForCreationDto subjectForCreationDto)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get subject Retrieve by id
    /// </summary>
    public ValueTask<SubjectDto> RetrieveSubjectByIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Subject Modify
    /// </summary>
    public ValueTask<SubjectDto> ModifySubjectAsync(SubjectForModificationDto subjectForModificationDto)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Subject Remove
    /// </summary>
    public ValueTask<SubjectDto> RemoveSubjectAsync(Guid userId)
    {
        throw new NotImplementedException();
    }
}
