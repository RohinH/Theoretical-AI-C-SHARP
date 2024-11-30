using System.Runtime.Serialization;
/////////////////////////////////////////////////////////////////////AI_MECHANISM_CODE_TEMPLATE/////////////////////////////////////////////////////////////////////////////////////////

    var Ai_easy_counter = 0;
    var Ai_medium_counter = 0;
    var Ai_hard_counter = 0;

    var easy_button = false;
    var medium_button = false;
    var hard_button = false;

    var player_score = 0;
    bool timer_button = false;

static void ai_points_assignment(int Ai_easy_counter, int Ai_medium_counter, int Ai_hard_counter, 
bool easy_button, bool medium_button, bool hard_button, int player_score,bool timer_button){
// See https://aka.ms/new-console-template for more information

//implicitly typed variable - automatically detects the datatype of the variable

    //var easy = 1;
    //var medium = 2;
    //var hard = 3;


//when "easy" button is selected
if (easy_button == true)
{
    Ai_easy_counter = 3;
    end_of_level_message(player_score,easy_button,medium_button,hard_button,timer_button,Ai_easy_counter,Ai_medium_counter,Ai_hard_counter);

}
//when "medium" button is selected
else if (medium_button == true)
{
     Ai_medium_counter = 5;
     end_of_level_message(player_score,easy_button,medium_button,hard_button,timer_button,Ai_easy_counter,Ai_medium_counter,Ai_hard_counter);
}
//when "hard" button is selected
else if (hard_button == true)
{
     Ai_hard_counter = 7;
     end_of_level_message(player_score,easy_button,medium_button,hard_button,timer_button,Ai_easy_counter,Ai_medium_counter,Ai_hard_counter);
}

progress_bar(Ai_easy_counter, Ai_medium_counter, Ai_hard_counter, 
easy_button, medium_button, hard_button,player_score);

Console.WriteLine(Ai_hard_counter);
}

ai_points_assignment(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);



static void progress_bar(int Ai_easy_counter, int Ai_medium_counter, int Ai_hard_counter, 
bool easy_button, bool medium_button, bool hard_button, int player_score){

var timer_button = false;//"timer button that is pressed by player"
//Console.WriteLine(timer_button);

//when "timer" button is pressed
while (timer_button==true)
{
    //play animation of ai progress bar increasing 
    Console.WriteLine("hey");
}
if (timer_button==false)
    {
        //stop AI progress bar increasing
        ai_points_assignment(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);
        
    }

}

progress_bar(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score);




//displays message if player has beaten the AI or not depending on the score they get 
static void end_of_level_message(int player_score,bool easy_button, bool medium_button, bool hard_button, bool timer_button,int Ai_easy_counter,int Ai_medium_counter,int Ai_hard_counter){

    if (timer_button==false && easy_button==true && player_score<3)
    {
       Console.WriteLine("Sorry, the computer has beaten you!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);
    }
    else if (timer_button==false && easy_button==true && player_score>=3)
    {
       Console.WriteLine("Well done, you are super speedy, you have beaten the computer!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);

    }
    else if (timer_button==false && medium_button==true && player_score<6)
    {
       Console.WriteLine("Sorry, the computer has beaten you!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);

    }
    else if (timer_button==false && medium_button==true && player_score>=6)
    {
       Console.WriteLine("Well done, you are super speedy, you have beaten the computer!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);

    }
    else if (timer_button==false && hard_button==true && player_score<7)
    {
       Console.WriteLine("Sorry, the computer has beaten you!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);

    }
    else if (timer_button==false && hard_button==true && player_score>=7)
    {
       Console.WriteLine("Well done, you are super speedy, you have beaten the computer!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);

    }
    else if (timer_button==false && easy_button==true && medium_button==true && hard_button==true && (player_score==Ai_easy_counter || player_score == Ai_medium_counter || player_score == Ai_hard_counter))
    {
       Console.WriteLine("You are the AI have drawn in points!");
       restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter,easy_button,medium_button,hard_button,player_score,timer_button);

    }
    
}

//sets the level diffuclty and the ai_counter difficulty. plays the progress bar if the timer button has been pressed and it stops the progress bar if the timer button has been pressed again
//ai_points_assignment is referenced in progress bar as you need to link the timer_button to then be used in the end_of_level_message which needs to ONLY WORK when timer_button is false.
// the end_of_level 





//Allows the player to play the same level again but now with the adaptive ai taken into effect making the next run more challenging for the player
static void restartLevel(int Ai_easy_counter, int Ai_medium_counter, int Ai_hard_counter, 
bool easy_button, bool medium_button, bool hard_button, int player_score,bool timer_button){


    var retry_level = false;
    var change_difficulty = false;
    var exit = false;

    Console.WriteLine("ALL SUBROUTINES WORK");
    if (change_difficulty==true)
    {
        //run subroutine to display difficulty select page 
    }
    else if (exit==true)
    {
        //run subroutine to display level selection page 
    }
    else if (retry_level==true)
    {
        
        if (player_score<3)
        {   Ai_easy_counter  = 3; //keep easy counter the same as player did not get minimum score to beat the easy ai

            //run subroutine to load that level again

        progress_bar(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter, 
easy_button,medium_button,hard_button,player_score);//start the run again for the same level
     
        }
        else if (player_score>=3 && player_score<=5)
        {
            Ai_medium_counter = 5; //new medium ai score
        }
        else if (player_score>=6 && player_score<=7)
        {
            Ai_hard_counter = 8;   //new hard ai score
        }
        else if (player_score>7 && player_score<=9)
        {
            Ai_hard_counter = 9; //new hard ai score
        }
        else
            ai_points_assignment(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter, 
easy_button,medium_button,hard_button,player_score,timer_button); //reset to normal ai score if the play beats the hard ai (player gets max score of 10)
    
    progress_bar(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter, 
easy_button,medium_button,hard_button,player_score);//start the run again for the same level

    Console.WriteLine("ALL SUBROUTINES WORK");
    }

}
restartLevel(Ai_easy_counter,Ai_medium_counter,Ai_hard_counter, 
easy_button,medium_button,hard_button,player_score,timer_button);

