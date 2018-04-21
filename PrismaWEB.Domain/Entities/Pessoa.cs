namespace ProjetoModeloDDD.Domain.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        [Index(IsUnique = true)]
        public string Cpf { get; set; }
        public string Foto { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; }
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneMovel { get; set; }
        public string Endereco { get; set; }
        public int Pais_Id { get; set; }
        public int Estado_Id { get; set; }
        public int Cidade_Id { get; set; }
        public int Bairro_Id { get; set; }
        public int Logradouro_Id { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int Tipo { get; set; }

        public virtual Bairro Bairro { get; set; }      
        public virtual Cidade Cidade { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Logradouro Logradouro { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
