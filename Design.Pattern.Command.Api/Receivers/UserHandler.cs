using Design.Pattern.Command.Api.Commands;

namespace Design.Pattern.Command.Api.Receivers;

public class UserHandler :
    IReceiver<UpdateNameCommand, ResponseState>, IReceiver<UpdateAgeCommand, ResponseState>
{
    private Dictionary<int, ICommand<ResponseState>> _Stack = new();
    public ResponseState Handle(UpdateNameCommand updateNameCommand)
    {
        updateNameCommand.Execute();
        _Stack.Add(updateNameCommand.Id, updateNameCommand);
        return new ResponseState(200, "Nome alterado com sucesso");
    }

    public ResponseState Handle(UpdateAgeCommand command)
    {
        command.Execute();
        _Stack.Add(command.Id, command);
        return new ResponseState(200, "Idade alterada com sucesso");
    }
}



