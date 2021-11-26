using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore.Model
{
    public class ResultAnalyzer
    {
        private IBoard _board;
        private const int BOARD_SIZE = 9;

        public ResultAnalyzer(IBoard board)
        {
            this._board = board;
        }

        public ResultType Analyze()
        {
            if (CheckRow() || CheckColumn() || CheckDiagonal())
            {
                return ResultType.WIN;
            }
            else if (!_board.IsBoardFull())
            {
                return ResultType.NO_RESULT;
            }
            else
            {
                return ResultType.DRAW;
            }
        }
        private bool CheckRow()
        {
            var cellArray = _board.CellArray;
            var column = 3;

            for (int i = 0; i < BOARD_SIZE; i += column)
            {
                if (cellArray[i].Mark == cellArray[i + 1].Mark
                    && cellArray[i + 1].Mark == cellArray[i + 2].Mark
                    && cellArray[i].Mark != MarkType.EMPTY
                    && cellArray[i + 1].Mark != MarkType.EMPTY
                    && cellArray[i + 2].Mark != MarkType.EMPTY)
                { 
                    return true;
                }
            }
            return false;
        }

        private bool CheckColumn()
        {
            var cellArray = _board.CellArray;
            var row = 3;

            for (int i = 0; i < row; i++)
            {
                if (cellArray[i].Mark == cellArray[i + row].Mark
                    && cellArray[i + row].Mark == cellArray[i + row * 2].Mark
                    && cellArray[i].Mark != MarkType.EMPTY
                    && cellArray[i + row].Mark != MarkType.EMPTY
                    && cellArray[i + row * 2].Mark != MarkType.EMPTY)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckDiagonal()
        {
            var cellArray = _board.CellArray;
            if ((cellArray[0].Mark == cellArray[4].Mark && cellArray[4].Mark == cellArray[8].Mark)
                || (cellArray[2].Mark == cellArray[4].Mark && cellArray[4].Mark == cellArray[6].Mark)
                && cellArray[4].Mark != MarkType.EMPTY
                && cellArray[0].Mark != MarkType.EMPTY
                && cellArray[8].Mark != MarkType.EMPTY
                && cellArray[2].Mark != MarkType.EMPTY
                && cellArray[4].Mark != MarkType.EMPTY
                && cellArray[6].Mark != MarkType.EMPTY
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
