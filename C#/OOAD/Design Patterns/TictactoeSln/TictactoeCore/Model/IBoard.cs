namespace TictactoeCore.Model
{
    public interface IBoard
    {
        Cell[] CellArray { get; }

        bool IsBoardEmpty();
        bool IsBoardFull();
        void MarkBoard(MarkType inputMarkType, int location);
    }
}