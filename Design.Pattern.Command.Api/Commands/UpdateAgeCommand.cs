namespace Design.Pattern.Command.Api.Commands
{
    public class UpdateAgeCommand : ICommand<ResponseState>
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public void Execute()
        {
            var user = new User();
            user.Id = Id;
            user.Age = Age;
        }
    }
}
