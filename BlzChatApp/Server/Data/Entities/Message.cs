using System.ComponentModel.DataAnnotations;

namespace BlzChatApp.Server.Data.Entities
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        public Message()
        {
            Id = Guid.NewGuid();
            DateTime = DateTime.Now;
        }
    }
}
