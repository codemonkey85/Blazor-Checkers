using static Checkers.Components.Enums;

namespace Checkers.Components;

public partial class Board
{
    private readonly PieceType[,] pieces = new PieceType[8, 8];

    private string GetPieceClass(int row, int col) => pieces[row, col] switch
    {
        PieceType.Red => "red",
        PieceType.Black => "black",
        PieceType.RedKing => "red king",
        PieceType.BlackKing => "black king",
        _ => "empty"
    };

    private void SetPiece(int row, int col, PieceType piece) => pieces[row, col] = piece;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        SetPiece(3, 4, PieceType.Red);
        SetPiece(3, 5, PieceType.Black);
    }
}

public static class Enums
{
    public enum PieceType
    {
        Empty,
        Red,
        Black,
        RedKing,
        BlackKing
    }
}
