using Ahura.Platform.Application.Command.Base;
using Ahura.Platform.Application.Command.Common;
using Ahura.Platform.Application.Query.Base;
using Exception = System.Exception;

namespace Client.Infra;

internal class ExceptionResult
{
    public void ExceptionCommandResult(CommandResult commandResult)
    {
        if (commandResult.Status == ApplicationServiceStatus.Ok)
            return;

        MessageBox.Show(commandResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }


    public void ExceptionQueryResult<T>(QueryResult<T> queryResult)
    {
        throw new Exception(queryResult.Message);
    }
}