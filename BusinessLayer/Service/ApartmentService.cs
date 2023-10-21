using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IMapper _mapper;


        public ApartmentService(
            IApartmentRepository apartmentRepository, 
            IMapper mapper)
        {
            _apartmentRepository = apartmentRepository;
            _mapper = mapper;
        }

        public void So(ApartmentDTO apartmentDTO)
        {
            Apartment apartment = new Apartment
            {
                BalconyCount = apartmentDTO.BalconyCount,
            };
        }
    }
}
