function Start() {
    Hide();
}
 
function Hide() {
    guiTexture.enabled = false;
}
 
function Show(maggot : Maggot) {
 
    if (!guiTexture.enabled) {
        var t = maggot.popupTexture;
        var rect = Rect( -t.width/2, -t.height/2, t.width, t.height );
        guiTexture.pixelInset = rect;
        guiTexture.texture = t;
        guiTexture.enabled = true;
    }   
}
 
function OnMouseUp () {
    Hide();
}