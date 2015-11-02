using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;


class Program
{
    static void Main()
    {
        string Result ="";
        
         Console.WriteLine("Enter number of test cases: "); // Prompt
	    string TempT = Console.ReadLine(); 
	    int T = Int32.Parse(TempT);
	    
	    for (int testCase = 0; testCase < T; testCase++)
	    {
	       // N K
	        string constraint = Console.ReadLine();
	        
	        string[] constraintArray = constraint.Split(' ');
	        
	        int N = Int32.Parse(constraintArray[0]);
	        int K = Int32.Parse(constraintArray[1]);
	        
	        // total students present
	        int totalStudents = 0;
	        
	       //student time
	        string studentArrival = Console.ReadLine();
	        
	        string[] studentArrivalArray = studentArrival.Split(' ');
	        
	        for(int x = 0; x < N; x++)
	        {
	            int student = Int32.Parse(studentArrivalArray[x]);
	            
	            // arrive before class
	            if(student<=0)
	            {
	                totalStudents++;
	            }
	            
	            // class is not cancelled
	            if(totalStudents>=K)
                    {
                        Result += "NO \n"; 
                        
                           break;
                    }
                           
	        }
	        
	        //class is cancelled
	         if(totalStudents<K)
                {
                    Result += "YES \n"; 
                    
                          
                }
	        
	        
	        
	        
	    }
	    
	     Console.WriteLine(Result); // Prompt
	    
	    
    }
}
