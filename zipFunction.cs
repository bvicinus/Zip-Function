using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        string strA = A.ToString(); 
        string strB = B.ToString();  //convert to strings for manipulation
        
        string strZip = ""; // to be returned
        
        bool turn = true;  //keep track of whos turn it is 
        
        int aCounter = 0;
        int bCounter = 0; //iterate through the strings 
        
        while( aCounter < strA.Length  || bCounter < strB.Length ) {
            
            if(aCounter < strA.Length && turn) { //turn and available chars left 
                
                strZip = strZip + strA.Substring(aCounter, 1);
                aCounter++;
                turn = !turn; //change turns 
                
            }
           else if(turn && aCounter >= strA.Length) { //turn but no chars left 
               turn = !turn;
           }
            
            
            
            if(bCounter < strB.Length && !turn) { //turn and available chars left 
                
                strZip = strZip + strB.Substring(bCounter, 1);
                bCounter++;
                turn = !turn;
                
            }
            else if(!turn && bCounter >= strB.Length) { //turn but no chars left 
               turn = !turn;
           }
            
            
            
        }//end while
        return Int32.Parse(strZip); //return as an int 
        
        
        
        
        
    }
}