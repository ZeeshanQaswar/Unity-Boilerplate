using System;

public static class GameActions
{

    public static Action LevelComplete;
    public static void LevelCompleteCall()
    {
        if (LevelComplete != null)
        {
            LevelComplete.Invoke();
        }
    }

    public static Action LevelFail;
    public static void LevelFailCall()
    {
        if (LevelFail != null)
        {
            LevelFail.Invoke();
        }
    }

    
}
