using System.Collections.Generic;
using System.Threading.Tasks;

namespace HilltopBlazorWASM.Models
{
    public interface IDataAccessProvider{
        Task AddRecord(Object obj);
    }
}
