using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Common.Events
{
    public record CartaoFalhaEvent(
        Guid FailureId,
        Guid ClienteId,
        string MessageType,
        string PayloadJson,
        int Attempt,
        string Reason,
        DateTime OccurredUtc
    );
}
