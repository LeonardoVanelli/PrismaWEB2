
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Pais, PaisViewModel>();
            Mapper.CreateMap<Pessoa, CandidatoViewModel>();
            Mapper.CreateMap<Cargo, CargoViewModel>();
            Mapper.CreateMap<Presidente, PresidenteViewModel>();            
            Mapper.CreateMap<Lei, LeiViewModel>();
        }
    }
}



