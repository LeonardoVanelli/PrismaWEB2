namespace ProjetoModeloDDD.Domain.Entities
{
    using ProjetoModeloDDD.Domain.Attribute;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pessoa
    {
        public int Id { get; set; }

        [VisivelView]   
        [MaxLength(120)]        
        public string Nome { get; set; }

        [VisivelView(Campos = "Grid")]        
        public DateTime DataNascimento { get; set; }

        [VisivelView(Campos = "Grid")]
        [Index(IsUnique = true)]
        public string Cpf { get; set; }

        [VisivelView(Campos = "Grid")]
        public string Foto { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        [VisivelView(Campos = "Grid")]
        public bool Ativo { get; set; }

        [VisivelView(Campos = "Grid")]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [VisivelView(Campos = "Grid")]
        public string TelefoneFixo { get; set; }

        [VisivelView]
        public string TelefoneMovel { get; set; }

        [VisivelView(Campos = "Grid")]
        public string Endereco { get; set; }

        [VisivelView(Campos = "Grid")]
        public int Pais_Id { get; set; }

        [VisivelView(Campos = "Grid")]
        public int Estado_Id { get; set; }

        [VisivelView(Campos = "Grid")]
        public int Cidade_Id { get; set; }

        [VisivelView(Campos = "Grid")]
        public int Bairro_Id { get; set; }

        [VisivelView(Campos = "Grid")]
        public int Logradouro_Id { get; set; }

        [VisivelView(Campos = "Grid")]
        public string Cep { get; set; }

        [VisivelView(Campos = "Grid")]
        public string Numero { get; set; }

        [VisivelView(Campos = "Grid")]
        public string Complemento { get; set; }

        public int Tipo { get; set; }


        [ForeignKey("Bairro_Id")]
        public virtual Bairro Bairro { get; set; }      
        [ForeignKey("Cidade_Id")]
        public virtual Cidade Cidade { get; set; }
        [ForeignKey("Estado_Id")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("Logradouro_Id")]
        public virtual Logradouro Logradouro { get; set; }
        [ForeignKey("Pais_Id")]
        public virtual Pais Pais { get; set; }
    }
}
