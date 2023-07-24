using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTemplate
{
    public interface ITerminalRestrictionRepository
    {
        Task<List<int>> GetAreaRestrictions(int terminalId, DateTime date, CancellationToken cancellationToken);
    }
}
