using System.Text.Json;

namespace Grupparbete.Model
{
    public class Task
    {
        public int Id { get; set; }
        public string description { get; set; }
        public string created_at { get; set; }
        public bool is_complete { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Task>(this);
        //eturn base.ToString();

    }

}
