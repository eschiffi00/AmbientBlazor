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
    public class UpdateRatio : IUpdateRatio
    {
        private readonly IRepository<Ratio> _ratiosRepository;
        public UpdateRatio(IRepository<Ratio> ratioRepository)
        {
            _ratiosRepository = ratioRepository;
        }

        public async Task ExecuteAsync(Ratio ratio)
        {
            await _ratiosRepository.Update(ratio);
        }
    }
}
