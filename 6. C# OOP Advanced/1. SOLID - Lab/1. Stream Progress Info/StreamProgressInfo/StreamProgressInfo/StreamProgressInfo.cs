namespace StreamProgressInfo
{
    public class StreamProgressInfo
    {
        //private File file;
        private IStreamable streamable;

        // If we want to stream a music file, we can't
        //public StreamProgressInfo(File file)
        public StreamProgressInfo(IStreamable streamable)
        {
            //this.file = file;
            this.streamable = streamable;
        }

        public int CalculateCurrentPercent()
        {
            //return (this.file.BytesSent * 100) / this.file.Length;
            return (streamable.BytesSent * 100) / streamable.Length;
        }
    }
}
