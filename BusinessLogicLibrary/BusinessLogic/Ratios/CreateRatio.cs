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
    public class CreateRatio : ICreateRatio
    {
        private readonly IRepository<Ratio> _ratiosRepository;
        public CreateRatio(IRepository<Ratio> ratiosRepository)
        {
            _ratiosRepository = ratiosRepository;
        }   

        public async Task ExecuteAsync(Ratio ratios)
        {
            await _ratiosRepository.Insert(ratios);
        }

    }
}
