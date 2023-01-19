using BusinessLogicLibrary.BusinessLogic.Ratios.Interfaces;
using BusinessLogicLibrary.ViewModels;
using InterfaceLogicLibrary.InterfacesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.BusinessLogic.Ratios
{
    public class GetRatioById : IGetRatioById
    {

        private readonly IRepository<Ratio> _ratiosRepository;
        public GetRatioById(IRepository<Ratio> ratio)
        {
            _ratiosRepository = ratio;
        }

        public async Task<Ratio> ExecuteAsync(int id)
        {
            await _ratiosRepository.GetById(id);
            return (Ratio)_ratiosRepository;
        }

    }
}
