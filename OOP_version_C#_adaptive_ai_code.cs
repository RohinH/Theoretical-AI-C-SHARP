// See https://aka.ms/new-console-template for more information

/////////////////////////////////////////////////////////////////////AI_MECHANISM_CODE_TEMPLATE_OOP_VERSION/////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Runtime.CompilerServices;
class Process{
    static void Main(string[] args)
    {   
 
        
       AI aiInstance = new AI(); //Create an instance of the AI class for each try of the level (refreshes the AI counters)
       aiInstance.set_ai_counters(AI.Ai_easy_counter, AI.Ai_medium_counter, AI.Ai_hard_counter);
       Buttons.set_buttons(Buttons.easy_button, Buttons.medium_button, Buttons.hard_button, Buttons.timer_button);



    }

}



public class Buttons {

    public static bool easy_button = false;
    public static bool medium_button = false;
    public static bool hard_button = false;
    public static bool timer_button = false;
public static void set_buttons(bool e_button,bool m_button,bool h_button,bool t_button){
            
            
            easy_button = e_button;
            medium_button = m_button;
            hard_button = h_button;
            timer_button = t_button;
 
}
}


class AI {

    public static int Ai_easy_counter = 0 ;
    public static int Ai_medium_counter = 0;
    public static int Ai_hard_counter = 0;



public void set_ai_counters(int easy_counter,int medium_counter,int hard_counter){

        Ai_easy_counter = easy_counter;
        Ai_medium_counter = medium_counter;
        Ai_hard_counter =  hard_counter;
}
public void ai_points_assignment(){
    
    //when "easy" button is selected
    if (Buttons.easy_button == true)
    {
        AI.Ai_easy_counter = 3;
        Progress_bar.set_timer();    
    }
    //when "medium" button is selected
    else if (Buttons.medium_button == true)
    {
        AI.Ai_medium_counter = 5;
        Progress_bar.set_timer();
        
    }
    //when "hard" button is selected
    else if (Buttons.hard_button == true)
    {
        AI.Ai_hard_counter = 7;
        Progress_bar.set_timer();
    }
}

}

class Progress_bar{
    public static bool set_timer(){
////"timer button that is pressed by player"

    while (Buttons.timer_button==true)
    {
    //play animation of ai progress bar increasing 
    Console.WriteLine("hey");
    }
    if (Buttons.timer_button==false)
    {
        //stop AI progress bar increasing
        Buttons.timer_button=false;
        end_of_message_display.message_display(0); 
        }
        return true;
    }

}

//displays message if player has beaten the AI or not depending on the score they get 
class end_of_message_display{
    public static int player_score; 
    public static void message_display(int aplayer_score){

        player_score = aplayer_score;

        if (Buttons.easy_button = true && player_score<3)
        {
            Console.WriteLine("Sorry the computer has beaten you");
        }
        else if (Buttons.easy_button == true && player_score>=3)
        {
            Console.WriteLine("Well done, you are super speedy, you have beaten the computer!");
        }
        else if (Buttons.medium_button == true && player_score<6)
        {
            Console.WriteLine("Sorry the computer has beaten you");
        }
        else if (Buttons.medium_button == true && player_score>=6)
        {
            Console.WriteLine("Well done, you are super speedy, you have beaten the computer!");
        }
        else if (Buttons.hard_button == true && player_score<7)
        {
            Console.WriteLine("Sorry the computer has beaten you");
        }
        else if (Buttons.hard_button == true && player_score>=7)
        {
            Console.WriteLine("Well done, you are super speedy, you have beaten the computer!");
        }
        else if ((Buttons.easy_button || Buttons.medium_button || Buttons.hard_button) &&
                   (player_score == AI.Ai_easy_counter || player_score == AI.Ai_medium_counter ||
                    player_score == AI.Ai_hard_counter)) 
        {
            Console.WriteLine("You and the AI have drawn in points");
        }
        
    }



}

//Allows the player to play the same level again but now with the adaptive ai taken into effect making the next run more challenging for the player
class restartLevel()
{
    private bool change_diffulty;
    private bool retry_level;
    private bool exit;

public void restart(bool change_dif, bool retry_lvl,bool exit_level)
{

    change_diffulty = change_dif;
    retry_level = retry_lvl;
    exit = exit_level;


    if (change_diffulty==true)
    { 
        Console.WriteLine("run subroutine to display difficulty select page"); 
    }
    else if (exit==true)
    {
        Console.WriteLine("run subroutine to display level selection page"); 
    }
    else if (retry_level==true)
    {
        if (end_of_message_display.player_score<3)
        {
            AI.Ai_easy_counter = 3;//keep easy counter the same as player did not get minimum score to beat the easy ai
           
        }
        else if (end_of_message_display.player_score>=3 && end_of_message_display.player_score<=5)
        {
            AI.Ai_medium_counter = 5;//new medium ai score
        }
        else if (end_of_message_display.player_score>=6 && end_of_message_display.player_score<=7)
        {   
            AI.Ai_hard_counter = 8;//new hard ai score
        }
        else if (end_of_message_display.player_score > 7 && end_of_message_display.player_score <= 9) 
        {
            AI.Ai_hard_counter = 9;//new hard ai score
        }
        else
        {
	        AI aiInstance = new AI();//creates instance of AI class to refresh points
            aiInstance.ai_points_assignment();//reset to normal ai score if the play beats the hard ai (player gets max score of 10)
        }
    }

            
    Progress_bar.set_timer();//start the run again for the same level
     
   }

}
