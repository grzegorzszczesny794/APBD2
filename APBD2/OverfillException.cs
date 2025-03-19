namespace APBD2
{
    internal class OverfillException : Exception
    {
        public OverfillException(string weigth) : base(String.Format("Overfill: {0}", weigth)) { }

        public OverfillException() { }
    }
}
