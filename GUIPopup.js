var popupTexture : Texture2D;
private var maggot : maggotpopup;
 
function Start () {
    maggot = FindObjectOfType(maggotpopup);
 
    if (popupTexture == null) {
        popupTexture = renderer.material.mainTexture;   
    }
}
 
function OnMouseDown () {
    maggot.Show(this);
}