using PersonnelTrackingSystem.Entities.DTOs;
using System.Collections.Generic;

namespace PersonnelTrackingSystem.BLL.Abstract
{
    public interface IPersonelService
    {
        List<PersonelDto> GetAll();
        PersonelDto GetById(int id);
        void Add(PersonelDto personel);
        void Update(PersonelDto personel);
        void Delete(int id);
    }
}
