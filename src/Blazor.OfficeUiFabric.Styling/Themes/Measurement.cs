namespace Blazor.OfficeUiFabric.Styling
{
    public class Measurement
    {
        /// <summary>
        /// Count of style element injected, which is the slow operation in IE
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Total duration of all loadStyles exectionss
        /// </summary>
        public long Duration { get; set; }

    }
}