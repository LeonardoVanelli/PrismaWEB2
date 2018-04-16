namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            Candidatocargos = new HashSet<Candidatocargos>();
            Favoritos = new HashSet<Favorito>();
            Favoritos1 = new HashSet<Favorito>();
            Presidentes = new HashSet<Presidente>();
            Presidentes1 = new HashSet<Presidente>();
            Votocandidatoleis = new HashSet<Votocandidatoleis>();
            Votos = new HashSet<Voto>();
            Votos1 = new HashSet<Voto>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }

        public string Foto { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public bool Ativo { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(12)]
        public string TelefoneFixo { get; set; }

        [StringLength(12)]
        public string TelefoneMovel { get; set; }

        [StringLength(60)]
        public string Endereco { get; set; }

        public int? Pais_Id { get; set; }

        public int? Estado_Id { get; set; }

        public int? Cidade_Id { get; set; }

        public int? Bairro_Id { get; set; }

        public int? Logradouro_Id { get; set; }

        [StringLength(8)]
        public string Cep { get; set; }

        [StringLength(6)]
        public string Numero { get; set; }

        [StringLength(60)]
        public string Complemento { get; set; }

        public int Tipo { get; set; }

        public virtual Bairro Bairros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Candidatocargos> Candidatocargos { get; set; }

        public virtual Cidade Cidades { get; set; }

        public virtual Estado Estados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favorito> Favoritos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favorito> Favoritos1 { get; set; }

        public virtual Logradouro Logradouros { get; set; }

        public virtual Pais Paises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presidente> Presidentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presidente> Presidentes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Votocandidatoleis> Votocandidatoleis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voto> Votos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voto> Votos1 { get; set; }
    }
}
