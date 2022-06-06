using System.Collections;
using System.Collections.Generic;
using TbsFramework.Cells;
using TbsFramework.Units;
using UnityEngine;
using UnityEngine.UI;

public class ChinaUnitDemo : Unit
    {

     public Color LeadingColor;
     public override void Initialize()
     {
         base.Initialize();
         transform.localPosition -= new Vector3(0, 0, 1);
         GetComponent<Renderer>().material.color = LeadingColor;
     }
     public override void MarkAsFriendly()
     {
          GetComponent<Renderer>().material.color = LeadingColor + new Color(0.8f, 1, 0.8f);
     }

    public override void MarkAsReachableEnemy()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.magenta;
    }

    public override void MarkAsSelected()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.green;
    }

    public override void UnMark()
    {
        GetComponent<Renderer>().material.color = LeadingColor;
    }

    public override void MarkAsAttacking(Unit other)
    {
    }

    public override void MarkAsDefending(Unit other)
    {
    }

    public override void MarkAsDestroyed()
    {
    }

    public override void MarkAsFinished()
    {
    }

    private void UpdateHpBar()
    {
        if (GetComponentInChildren<Image>() != null)
        {
            GetComponentInChildren<Image>().transform.localScale = new Vector3((float)((float)HitPoints / (float)TotalHitPoints), 1, 1);
            GetComponentInChildren<Image>().color = Color.Lerp(Color.red, Color.green,
                (float)((float)HitPoints / (float)TotalHitPoints));
        }
    }

    protected override void DefenceActionPerformed()
    {
        UpdateHpBar();
    }
}


