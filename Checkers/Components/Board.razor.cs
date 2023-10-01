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
        ResetBoard();
    }

    private void ResetBoard()
    {
        for (var row = 0; row < 8; row++)
        {
            for (var col = 0; col < 8; col++)
            {
                if (DefaultBlackPositions.Contains((row, col)))
                {
                    SetPiece(row, col, PieceType.Black);
                    continue;
                }
                if (DefaultRedPositions.Contains((row, col)))
                {
                    SetPiece(row, col, PieceType.Red);
                    continue;
                }
                SetPiece(row, col, PieceType.Empty);
            }
        }

    }

    private (int Row, int Col)[] DefaultBlackPositions = new (int Row, int Col)[]
    {
        (0, 1), (0, 3), (0, 5), (0, 7),
        (1, 0), (1, 2), (1, 4), (1, 6),
        (2, 1), (2, 3), (2, 5), (2, 7)
    };

    private (int Row, int Col)[] DefaultRedPositions = new (int Row, int Col)[]
    {
        (5, 0), (5, 2), (5, 4), (5, 6),
        (6, 1), (6, 3), (6, 5), (6, 7),
        (7, 0), (7, 2), (7, 4), (7, 6)
    };
}
