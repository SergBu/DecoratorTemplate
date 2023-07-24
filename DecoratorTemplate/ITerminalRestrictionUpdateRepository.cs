using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTemplate
{
    public interface ITerminalRestrictionUpdateRepository
    {
        Task<Tuple<bool, List<int>>> UpdateAsync(int parentId = 0);
    }
}
