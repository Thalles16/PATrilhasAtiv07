using System;

class Program
{
    static void Main()
    {
    	int [,] numeros = {
    		{1,2,3},
    		{4,5,6},
    		{7,8,9}
    	};
    	
    	for(int i =0; i < 3; i++){
    	
    		for(int j =0; j <3; j++){
    			Console.Write(numeros[i,j]);
    		}
    		Console.WriteLine();
    	}
    	
    	Console.ReadKey();
    
}
}
