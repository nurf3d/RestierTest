using System.ComponentModel.DataAnnotations;

namespace RestierTests.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Timestamp]
        public byte[] Rowversion { get; set; }
    }
}