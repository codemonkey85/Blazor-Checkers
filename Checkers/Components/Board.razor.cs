namespace Checkers.Components;

public partial class Board
{
    private readonly PieceType[,] pieces = new PieceType[8, 8];


    private readonly (int Row, int Col)[] DefaultBlackPositions = new (int Row, int Col)[]
    {
        (0, 1), (0, 3), (0, 5), (0, 7),
        (1, 0), (1, 2), (1, 4), (1, 6),
        (2, 1), (2, 3), (2, 5), (2, 7)
    };

    private readonly (int Row, int Col)[] DefaultRedPositions = new (int Row, int Col)[]
    {
        (5, 0), (5, 2), (5, 4), (5, 6),
        (6, 1), (6, 3), (6, 5), (6, 7),
        (7, 0), (7, 2), (7, 4), (7, 6)
    };

    private PieceType SelectedPiece { get; set; } = PieceType.Empty;

    private int SelectedRow { get; set; }

    private int SelectedColumn { get; set; }

    private PieceType GetPiece(int row, int col) => pieces[row, col];

    private static string GetPieceClass(PieceType pieceType) => pieceType switch
    {
        PieceType.Red => "red",
        PieceType.RedKing => "red king",
        PieceType.Black => "black",
        PieceType.BlackKing => "black king",
        _ => "empty"
    };

    private static string GetTileTitle(PieceType pieceType) => pieceType switch
    {
        PieceType.Red => "Red Piece",
        PieceType.RedKing => "Red King",
        PieceType.Black => "Black Piece",
        PieceType.BlackKing => "Black King",
        _ => "Empty Tile"
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

    private void OnTileClick(int row, int column)
    {
    }
}
