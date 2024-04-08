using System.ComponentModel.DataAnnotations;

namespace SixMinApi.Dtos
{
    public class CommandUpdateDto
    {
        public string? HowTo { get; set;}

        public string? Platform { get; set; }

        public string? ComandLine{ get; set; }
    }
}