namespace Checkers.Components;

public partial class Board
{
    private readonly PieceType[,] pieces = new PieceType[8, 8];

    private PieceType GetPiece(int row, int col) => pieces[row, col];

    private string GetPieceClass(int row, int col) => GetPiece(row, col) switch
    {
        PieceType.Red => "red",
        PieceType.RedKing => "red king",
        PieceType.Black => "black",
        PieceType.BlackKing => "black king",
        _ => "empty"
    };

    private void SetPiece(int row, int col, PieceType piece) => pieces[row, col] = piece;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        SetPiece(0, 1, PieceType.Red);
        SetPiece(3, 1, PieceType.BlackKing);
    }
}
