
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<PaisViewModel, Pais>();
            Mapper.CreateMap<CandidatoViewModel, Pessoa>();
            Mapper.CreateMap<PresidenteViewModel, Presidente>();
            Mapper.CreateMap<CargoViewModel, Cargo>();
        }
    }
}