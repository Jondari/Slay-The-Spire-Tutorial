using UnityEngine;

public class HeroView : CombatantView
{
    public void Setup()
    {
        int tempHealth = 40;
        SetupBase(tempHealth, null);
    }
}
