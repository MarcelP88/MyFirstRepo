// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

public class Program
{
    public static void Main (string[]args)
    {
        char[] vowel_list = {'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};
        char[] num_and_char_list = {'1','2','3','4','5','6','7','8','9','!','@','#','$','%','&'};
        char[] consonant_list = new char[22];
        consonant_list[0] = 'a';

        bool contains_vowel = false;


        for (int i = 1; i < consonant_list.Length; i++)
        {
            contains_vowel = vowel_list.Contains(Convert.ToChar(consonant_list[i-1] +1));

            if (contains_vowel == true )
            {
                consonant_list[i] = Convert.ToChar(consonant_list[i-1] +2);
                Console.WriteLine(consonant_list[i]);

                contains_vowel = false;
                continue;
            }

            

            else
            {
                consonant_list[i] = Convert.ToChar(consonant_list[i-1] +1);
                Console.WriteLine(consonant_list[i]);
            
            }

           

            
        }
                                    //string formatting
        Console.WriteLine("input {0} {1} {2}","character","book",  consonant_list[0]);
        ConsoleKey info = System.Console.ReadKey().Key;
        char input = Convert.ToChar(info);
        
        for(int i = 0; i < vowel_list.Length; i++)
        {
            if(input == vowel_list[i])
            {
                Console.WriteLine("its a vowel");
                return;
            }
           
        }

        for (int i = 0; i < num_and_char_list.Length; i++)
        {
            if (input == num_and_char_list[i])
            {
                Console.WriteLine("please enter letter");
                return;
            }
        
        }
       
        Console.WriteLine("its a consonant");
    }

}    


                    

   
    





            


        
            
        
        
        
        
        
        
        
        
    

    
    
       


    

 