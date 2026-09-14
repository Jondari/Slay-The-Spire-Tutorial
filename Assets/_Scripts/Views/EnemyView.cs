using TMPro;
using UnityEngine;

public class EnemyView : CombatantView
{
    [SerializeField] private TMP_Text attackText;
    public int AttackPower {  get; private set; }

    public void Setup()
    {
        AttackPower = 10;
        UpdateAttackText();
        int tempHealth = 100;
        SetupBase(tempHealth, null);
    }

    private void UpdateAttackText()
    {
        attackText.text = "ATK: " + AttackPower;
    }
}
