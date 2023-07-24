using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTemplate
{
    public class TerminalRestrictionUpdateRepository : ITerminalRestrictionUpdateRepository
    {
        private readonly ITerminalRestrictionRepository _iterminalrestrictionRepository;
        private readonly string _errorMessage;
        public TerminalRestrictionUpdateRepository(ITerminalRestrictionRepository iterminalrestrictionRepository)
        {
            _iterminalrestrictionRepository = iterminalrestrictionRepository;

            _errorMessage = $"{this.GetType().Name} ({{0}})";
        }

        public async Task<Tuple<bool, List<int>>> UpdateAsync(int parentId = 0)
        {
            try
            {
                return Tuple.Create(true, new List<int> { parentId });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
