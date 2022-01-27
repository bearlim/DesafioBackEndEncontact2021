using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteBackendEnContact.Core.Interface.ContactBook.Company;

namespace TesteBackendEnContact.Core.Domain.ContactBook.Company
{
    [Table("Company")]
    public class Company : ICompany
    {
        [Key]
        public int Id { get; set; }
        public int ContactBookId { get; set; }
        public string Name { get; set; }

        public Company(int id, int contactBookId=0, string name=null)
        {
            Id = id;
            ContactBookId = contactBookId;
            Name = name;
        }

        public Company()
        {

        }
    }
}
