class TicTacToeGame
{
    public void Run()
    {
        Board board = new Board();
        BoardRenderer renderer = new BoardRenderer();
        Player player1 = new Player(CellType.X);
        Player player2 = new Player(CellType.O);
        Player currentPlayer = player1;
        WinChecker winChecker = new WinChecker();

        while (!winChecker.HasXWon(board) && !winChecker.HasOWon(board) && !winChecker.IsBoardFull(board))
        {
            Console.WriteLine($"It is {currentPlayer.Token}'s turn.");
            renderer.Render(board);
            Location target = player1.GetChoice(board);
            board.Set(target, currentPlayer.Token);

            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }
        }

        renderer.Render(board);
        if (winChecker.HasXWon(board))
        {
            Console.WriteLine("X won!");
        }
        else if (winChecker.HasOWon(board))
        {
            Console.WriteLine("O won!");
        }
        else
        {
            Console.WriteLine("Draw!");
        }
    }
}