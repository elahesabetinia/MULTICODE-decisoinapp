using System;

namespace DecisionApp
{
    public class DecisionTreeDrawer
    {
        public static void DrawDecisionTree()
        {
            Console.WriteLine("here is your decisoin tree please answer quetions with yess or no");
            Console.WriteLine("are you still alive?")
            string answer = KeyBoard.GetYesOrNo();

            switch (answer)
            {
                case "yes":
                   
                    Console.WriteLine("   be happy\n becuase you are lucky \n  :)");
                    break;
                case "no":
                  
                    Console.WriteLine("   oh really?\n  do i look like a stupid to you?\n  -_-");
                    break;
            }
        }
    }
}
