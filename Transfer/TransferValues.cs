
using restapi.DTO;
using restapi.Entities;

namespace restapi.Transfer
{
    public class TransferValues
    {
        public StudentDto? MapToStudentRepo(StudentEntity entity) {
            if (entity == null)
                return null;

            return new StudentDto {
                Id = entity.Id,
                Name = entity.Name,
                Fees = entity.Fees
            };
        }
    }
}