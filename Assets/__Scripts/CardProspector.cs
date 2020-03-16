using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// An enum defines a variable type with a few prenamed values        // a 
public enum eCardState
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardProspector : Card
{ // Make sure CardProspector extends Card 
    [Header("Set Dynamically: CardProspector")]
    // This is how you use the enum eCardState 
    public eCardState state = eCardState.drawpile;
    // The hiddenBy list stores which other cards will keep this one face down 
    public List<CardProspector> hiddenBy = new List<CardProspector>();
    // The layoutID matches this card to the tableau XML if it's a tableau card 
    public int layoutID;
    // The SlotDef class stores information pulled in from the LayoutXML <slot> 
    public SlotDef slotDef;

    public override void OnMouseUpAsButton()
    {
        Prospector.S.CardClicked(this);
        base.OnMouseUpAsButton();
    }
}
