using AutoMapper;
using PersonnelTrackingSystem.BLL.Abstract;
using PersonnelTrackingSystem.DAL;
using PersonnelTrackingSystem.Entities.DTOs;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PersonnelTrackingSystem.BLL.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly PersonnelTrackingDbContext _context;
        private readonly IMapper _mapper;

        public PersonelManager()
        {
            _context = new PersonnelTrackingDbContext();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mapping.MappingProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public List<PersonelDto> GetAll()
        {
            var entities = _context.Personel.ToList();
            return _mapper.Map<List<PersonelDto>>(entities);
        }

        public PersonelDto GetById(int id)
        {
            var entity = _context.Personel.Find(id);
            return _mapper.Map<PersonelDto>(entity);
        }

        public void Add(PersonelDto dto)
        {
            var entity = _mapper.Map<Personel>(dto);
            _context.Personel.Add(entity);
            _context.SaveChanges();
        }

        public void Update(PersonelDto dto)
        {
            var entity = _mapper.Map<Personel>(dto);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Personel.Find(id);
            if (entity != null)
            {
                _context.Personel.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
