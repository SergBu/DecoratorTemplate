using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTemplate
{
    public class TerminalRestrictionUpdateRepositoryDecorator : ITerminalRestrictionUpdateRepository
    {
        private readonly ITerminalRestrictionUpdateRepository _terminalRestrictionUpdateRepository;

        public TerminalRestrictionUpdateRepositoryDecorator(ITerminalRestrictionUpdateRepository terminalRestrictionUpdateRepository)
        {
            _terminalRestrictionUpdateRepository = terminalRestrictionUpdateRepository;
        }
        public async Task<Tuple<bool, List<int>>> UpdateAsync(int parentId = 0)
        {
            var result = await _terminalRestrictionUpdateRepository.UpdateAsync(parentId);

            return result;
        }
    }
}
