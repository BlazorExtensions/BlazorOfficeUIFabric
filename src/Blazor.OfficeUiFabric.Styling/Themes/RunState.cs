using System.Collections.Generic;

namespace Blazor.OfficeUiFabric.Styling
{
    public class RunState
    {
        public RunState()
        {
            this.Buffer = new List<List<ThemingInstruction>>();
        }

        public void Deconstruct(out Mode mode, out int? flushTimer, out List<List<ThemingInstruction>> buffer)
        {
            mode = this.Mode;
            flushTimer = this.FlushTimer;
            buffer = this.Buffer;
        }


        public void Deconstruct(out Mode mode, out int? flushTimer)
        {
            mode = this.Mode;
            flushTimer = this.FlushTimer;
        }


      

        public Mode Mode { get; set; }
        public List<List<ThemingInstruction>> Buffer { get; set; }
        public int? FlushTimer { get; set; }
    }
}