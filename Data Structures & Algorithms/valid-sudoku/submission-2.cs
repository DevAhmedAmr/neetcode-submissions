public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var colomsCache = new Dictionary<int, HashSet<char>>();
        var rowsCache = new Dictionary<int, HashSet<char>>();
        var gridCache = new Dictionary<string, HashSet<char>>();

        for (int row = 0; row < board.Length; row++) {
            // var c = KeyValuePair<int,int>(colom)

            if (!rowsCache.ContainsKey(row)) {
                // Console.WriteLine($"rowccash {row}");
                rowsCache[row] = new HashSet<char>();
            }
            for (int colom = 0; colom < board[row].Length; colom++) {
                var isNotEmpty = board[row][colom] != '.';

                // Console.WriteLine($"rowccash {row} {rowsCache.ContainsKey(row)}");

                if (!colomsCache.ContainsKey(colom)) {
                    colomsCache[colom] = new HashSet<char>();
                }

                if (!gridCache.ContainsKey($"{row/3},{colom/3}"))

                    gridCache[$"{row/3},{colom/3}"] = new HashSet<char>();

                if (isNotEmpty) {
                    if (!colomsCache[colom].Contains(board[row][colom]))
                        colomsCache[colom].Add(board[row][colom]);
                    else {
                        return false;
                    }
                }

                if (isNotEmpty) {
                    if (!(rowsCache[row].Contains(board[row][colom])))
                        rowsCache[row].Add(board[row][colom]);
                    else {
                        return false;
                    }
                }

                if (isNotEmpty) {
                    if (!gridCache[$"{row/3},{colom/3}"].Contains(board[row][colom]))
                        gridCache[$"{row/3},{colom/3}"].Add(board[row][colom]);
                    else
                        return false;
                }
            }
        }
        return true;
    }
}
