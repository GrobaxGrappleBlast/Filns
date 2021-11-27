namespace Filns_Interfaces {
    public interface IDocument
        {
            string filepath { get; set; }
            IDocAttribute[] vars { get; set; }

        }
}