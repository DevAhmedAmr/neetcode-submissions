public class Solution {
    public bool IsValidSudoku(char[][] board) {

        var colomsCache=new  Dictionary<int,HashSet<char>>();
        var rowsCache=new Dictionary<int,HashSet<char>>();
       var gridCache=new Dictionary<string,HashSet<char>>();
        

        for (int colom = 0; colom < board.Length;colom++){

           // var c = KeyValuePair<int,int>(colom)
            if(!colomsCache.ContainsKey(colom) ){
                colomsCache[colom] = new HashSet<char>();
            }

            for (int row = 0; row < board[colom].Length;row++){
                var isNotEmpty=board[colom][row]  !='.';
                
                //Console.WriteLine($"rowccash {row} {rowsCache.ContainsKey(row)}");

             if(!rowsCache.ContainsKey(row) ){
                //Console.WriteLine($"rowccash {row}");
                rowsCache[row] = new HashSet<char>();}


             if(!gridCache.ContainsKey($"{colom/3},{row/3}"))
            
                gridCache[$"{colom/3},{row/3}"] = new HashSet<char>();

                if (isNotEmpty){
                if (!colomsCache[colom].Contains(board[colom][row]) )
                    colomsCache[colom].Add(board[colom][row]);
                else{
                return false;}}


               if (isNotEmpty){
                if (!(rowsCache[row].Contains(board[colom][row])) )
                    rowsCache[row].Add(board[colom][row]);
                else{
                return false;}}


            if (isNotEmpty){

                if (!gridCache[$"{colom/3},{row/3}"].Contains(board[colom][row]))
                     gridCache[$"{colom/3},{row/3}"].Add(board[colom][row]);
                else
                return false;}
            }
                
            

        }
        return true;
        
    }
}
