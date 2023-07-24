using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTemplate
{
    public class TerminalRestrictionRepository : ITerminalRestrictionRepository
    {
        private readonly string _errorMessage;

        public TerminalRestrictionRepository()
        {
        }

        public async Task<List<int>> GetAreaRestrictions(int terminalId, DateTime date,
            CancellationToken cancellationToken)
        {
            try
            {
                var result = new List<int> { terminalId };

                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}