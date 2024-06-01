using System;
using System.Collections;
using System.Linq;
using System.Data;
public class GradeCalculator
{
    public static void Main(String [] arg){
        Console.WriteLine("Enter a ScoreNumber between 0 and 100");
        int ScoreNumber = Convert.ToInt32(Console.ReadLine());
        char grade;
        if(ScoreNumber > 100 || ScoreNumber < 0){
            Console.WriteLine("Invalid Scores");
        }
        else {
            if (ScoreNumber >= 90 && ScoreNumber <= 100){
                grade = 'A';
            }
           else if (ScoreNumber >= 80 && ScoreNumber <= 89){
                grade = 'B';
            }
           else if  (ScoreNumber >= 70 && ScoreNumber <= 79){
                grade = 'C';
           }
           else if (ScoreNumber >= 60 && ScoreNumber <= 69){
            grade = 'D';
           }
           else { 
            grade = 'F';
        }
        Console.WriteLine("Score Number: " + ScoreNumber + "Grade: " + grade);
        
}

        
    }
    
}