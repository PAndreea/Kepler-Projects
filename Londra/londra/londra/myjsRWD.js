function a1() {
    document.getElementById("demo").innerHTML = Date();
}
function a2() {
    document.getElementById('a').src = '/images/s.jpg';
}
function a3() {
    document.getElementById('a').src = '/images/lo.jpg';
}
function changeText2(id) {
    id.innerHTML = "HELOOOO!!!";
}
function toggleclass() {
    if (document.body.style.backgroundImage == 'url("images/rr.jpg")')
        document.body.style.backgroundImage = 'url("images/giphy.gif")';
    else
        document.body.style.backgroundImage = 'url("images/rr.jpg")';

}
function hideText() {
    if (document.getElementById('hide').style.visibility == 'hidden')
        document.getElementById('hide').style.visibility = 'visible';
    else
        document.getElementById('hide').style.visibility = 'hidden';
}